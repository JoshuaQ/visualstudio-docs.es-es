---
title: "C&#243;mo: Abrir un modelo desde un archivo en el c&#243;digo del programa | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d7d68697-5418-4263-bdb2-48401924ea71
caps.latest.revision: 8
author: "alancameronwills"
ms.author: "awills"
manager: "douge"
caps.handback.revision: 8
---
# C&#243;mo: Abrir un modelo desde un archivo en el c&#243;digo del programa
[!INCLUDE[vs2017banner](../code-quality/includes/vs2017banner.md)]

Puede abrir modelos ADSL en cualquier aplicación.  
  
 De una extensión de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] , puede utilizar ModelBus con este fin.  ModelBus proporciona el mecanismo estándar para hacer referencia a un modelo o elementos en un modelo, y encontrar el modelo si ha desplazado.  Para obtener más información, vea [Integrar modelos utilizando Modelbus de Visual Studio](../modeling/integrating-models-by-using-visual-studio-modelbus.md).  
  
## Versión de .NET Framework de destino  
 Establezca **Versión de .NET Framework de destino** de proyecto de aplicación a **.NET Framework 4**.  
  
#### Para establecer el marco de destino  
  
1.  Abra el proyecto de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] para la aplicación en la que desea leer un modelo ADSL.  
  
2.  En el **Explorador de soluciones**, haga clic con el botón secundario del mouse en el proyecto y, a continuación, seleccione **Propiedades**.  
  
3.  En la ventana propiedades del proyecto, en la pestaña de **Aplicación** , establezca el campo de **Versión de .NET Framework de destino** a **.NET Framework 4**.  
  
> [!NOTE]
>  Puede que necesite hacer esto aunque se **.NET Framework 4** seleccionado en el cuadro de diálogo de creación del proyecto.  El marco de destino no debe ser **.NET Framework 4 client profile**.  
  
## Referencias  
 Tiene que agregar estas referencias al proyecto de aplicación de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] :  
  
-   `Microsoft.VisualStudio.Modeling.Sdk.11.0`  
  
    -   Si no ve esta bajo la pestaña de **.NET** en el cuadro de diálogo de **Agregue referencias** , haga clic en la pestaña de **Examinar** y navegue a `%Program Files%\Microsoft Visual Studio 2010 SDK\VisualStudioIntegration\Common\Assemblies \`.  
  
-   El ensamblado ADSL, que encontrará en la carpeta bin el proyecto ADSL.  Su nombre es normalmente el formato: *la compañía*.*TheProject*`. Dsl.dll`.  
  
## Clases importantes en ADSL  
 Antes de poder escribir código que lee DSL, debe conocer los nombres de algunas de las clases generadas por ADSL.  En la solución ADSL, abra el proyecto de **DSL** y busca en la carpeta de **GeneratedCode** .  O bien, haga doble clic en el ensamblado ADSL en el proyecto **Referencias**, y abra el espacio de nombres ADSL en **Examinador de objetos**.  
  
 Éstas son clases que debe identificar:  
  
-   *TheDslRootClass* \- Éste es el nombre de la clase de `DslDefinition.dsl`.  
  
-   *TheDslName* `SerializationHelper` \- clase de This is definido en `SerializationHelper.cs` en el proyecto ADSL.  
  
-   *TheDslName* `DomainModel` \- clase de This is definido en `DomainModel.cs` en el proyecto ADSL.  
  
## Leer de un archivo  
 El ejemplo siguiente se ha diseñado para leer ADSL en las que las clases importantes son como sigue:  
  
-   FamilyTreeModel  
  
-   FamilyTreeSerializationHelper  
  
-   FamilyTreeDomainModel  
  
 Otra clase de dominio en este DSL es persona.  
  
```  
using System;  
using Microsoft.VisualStudio.Modeling;  
using Company.FamilyTree; // Your DSL namespace  
  
namespace StandaloneReadDslConsole  
{ class Program  
  { static void Main(string[] args)  
    {  
      // The path of a DSL model file:  
      string dslModel = @"C:\FamilyTrees\Tudor.ftree";  
      // Set up the Store to read your type of model:  
      Store store = new Store(  
        typeof(Company.FamilyTree.FamilyTreeDomainModel));  
      // The Model type generated by the DSL:  
      FamilyTreeModel familyTree;  
      // All Store changes must be in a Transaction:  
      using (Transaction t =   
        store.TransactionManager.BeginTransaction("Load model"))  
      {  
        familyTree =   
           FamilyTreeSerializationHelper.Instance.  
              LoadModel(store, dslModel, null, null, null);  
        t.Commit(); // Don't forget this!  
      }  
      // Now we can read the model:  
      foreach (Person p in familyTree.People)  
      {  
        Console.WriteLine(p.Name);   
        foreach (Person child in p.Children)  
        {  
          Console.WriteLine("    " + child.Name);  
        }  
} } } }  
```  
  
## Guardar un archivo  
 Suma siguiente al código anterior realiza un cambio en el modelo y lo guarda en un archivo.  
  
```  
using (Transaction t =  
  store.TransactionManager.BeginTransaction("update model"))  
{  
  // Create a new model element:  
  Person p = new Person(store);  
  // Set its embedding relationship:  
  p.FamilyTreeModel = familyTree;  
  // - same as: familyTree.People.Add(p);  
  // Set its properties:  
  p.Name = "Edward VI";  
  t.Commit(); // Don't forget this!  
}  
// Save the model:  
try  
{  
  SerializationResult result = new SerializationResult();  
  FamilyTreeSerializationHelper.Instance  
    .SaveModel(result, familyTree, @"C:\FamilyTrees\Tudor-upd.ftree");  
  // Report any error:  
  if (result.Failed)  
  {  
    foreach (SerializationMessage message in result)  
    {  
      Console.WriteLine(message);  
    }  
  }  
}  
catch (System.IO.IOException ex)  
{ ... }  
```