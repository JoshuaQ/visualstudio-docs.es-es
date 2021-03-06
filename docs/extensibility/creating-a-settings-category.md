---
title: "Crear una categoría de configuración | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: profile settings, creating categories
ms.assetid: 97c88693-05ff-499e-8c43-352ee073dcb7
caps.latest.revision: "39"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 2bdf3231f2df8b3700c7865fa53e60003b814a5f
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="creating-a-settings-category"></a>Crear una categoría de configuración
En este tutorial creará una categoría de configuración de Visual Studio y usarlo para guardar los valores para y restaurar los valores de un archivo de configuración. Una categoría de configuración es un grupo de propiedades relacionadas que aparecen como "punto de configuración personalizada;" es decir, como una casilla de verificación en la **importar y configuraciones de exportaciones** asistente. (Puede encontrar en el **herramientas** menú.) Valores de configuración se guarda o se restaura como una categoría, y opciones de configuración individuales no se muestran en el asistente. Para más información, vea [Personalizar el IDE de Visual Studio](../ide/personalizing-the-visual-studio-ide.md).  
  
 Crear una categoría de configuración mediante la derivación desde la <xref:Microsoft.VisualStudio.Shell.DialogPage> clase.  
  
 Para iniciar este tutorial, primero debe completar la primera sección del [crear una página de opciones](../extensibility/creating-an-options-page.md). La cuadrícula de propiedades opciones resultante le permite examinar y cambiar las propiedades de la categoría. Después de guardar la categoría de propiedad en un archivo de configuración, examine el archivo para ver cómo se almacenan los valores de propiedad.  
  
## <a name="prerequisites"></a>Requisitos previos  
 A partir de Visual Studio 2015, no instale el SDK de Visual Studio desde el centro de descarga. Se incluye como una característica opcional en el programa de instalación de Visual Studio. También puede instalar el SDK de VS más adelante. Para obtener más información, consulte [instalar el SDK de Visual Studio](../extensibility/installing-the-visual-studio-sdk.md).  
  
## <a name="creating-a-settings-category"></a>Crear una categoría de configuración  
 En esta sección, utiliza un punto de configuración personalizada para guardar y restaurar los valores de la categoría de configuración.  
  
#### <a name="to-create-a-settings-category"></a>Para crear una categoría de configuración  
  
1.  Completar la [crear una página de opciones](../extensibility/creating-an-options-page.md).  
  
2.  Abra el archivo VSPackage.resx y agregar estas tres cadenas de recursos:  
  
    |nombre|Valor|  
    |----------|-----------|  
    |106|Mi categoría|  
    |107|Mi configuración|  
    |108|OptionInteger y OptionFloat|  
  
     Esto crea los recursos de ese nombre de la categoría "My Category", el objeto "My Settings" y la descripción de la categoría "OptionInteger y OptionFloat".  
  
    > [!NOTE]
    >  De estos tres, solo el nombre de categoría no aparece en el Asistente para importar y exportar configuraciones.  
  
3.  En MyToolsOptionsPackage.cs, agregue un `float` propiedad denominada `OptionFloat` a la `OptionPageGrid` de la clase, como se muestra en el ejemplo siguiente.  
  
    ```csharp  
    public class OptionPageGrid : DialogPage  
    {  
        private int optionInt = 256;  
        private float optionFloat = 3.14F;  
  
        [Category("My Options")]  
        [DisplayName("My Integer option")]  
        [Description("My integer option")]  
        public int OptionInteger  
        {  
            get { return optionInt; }  
            set { optionInt = value; }  
        }  
        [Category("My Options")]  
        [DisplayName("My Float option")]  
        [Description("My float option")]  
        public float OptionFloat  
        {  
            get { return optionFloat; }  
            set { optionFloat = value; }  
        }  
    }  
    ```  
  
    > [!NOTE]
    >  El `OptionPageGrid` categoría denominada "My Category" ahora consta de las dos propiedades, `OptionInteger` y `OptionFloat`.  
  
4.  Agregar un <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> a la `MyToolsOptionsPackage` clase y asígnele el nombre de categoría "My Category", asígnele el ObjectName "My Settings" y isToolsOptionPage se establece en true. Establezca los categoryResourceID, objectNameResourceID y DescriptionResourceID en el recurso de cadena correspondiente que se hayan creado anteriormente.  
  
    ```csharp  
    [ProvideProfileAttribute(typeof(OptionPageGrid),   
        "My Category", "My Settings", 106, 107, isToolsOptionPage:true, DescriptionResourceID = 108)]  
    ```  
  
5.  Compile la solución y comience la depuración. En la instancia experimental debería ver que **mi página de cuadrícula** ahora tiene valores enteros y flotantes.  
  
## <a name="examining-the-settings-file"></a>Examine el archivo de configuración  
 En esta sección, exportará los valores de categoría de propiedad a un archivo de configuración. Examine el archivo y, a continuación, importe los valores en la categoría de propiedad.  
  
1.  Inicie el proyecto en modo de depuración presionando F5. Esto inicia la instancia experimental.  
  
2.  Abra la **herramientas / opciones** cuadro de diálogo.  
  
3.  En la vista de árbol en el panel izquierdo, expanda **categoría Mis** y, a continuación, haga clic en **mi página de cuadrícula**.  
  
4.  Cambie el valor de **OptionFloat** a 3,1416 y **OptionInteger** a 12. Haga clic en **Aceptar**.  
  
5.  En el **herramientas** menú, haga clic en **importar y exportar configuraciones**.  
  
     El **importar y exportar configuraciones** aparece el Asistente para.  
  
6.  Asegúrese de que **exportar la configuración de entorno seleccionada** está seleccionada y, a continuación, haga clic en **siguiente**.  
  
     El **elegir configuración de la exportación** aparecerá la página.  
  
7.  Haga clic en **mi configuración**.  
  
     El **descripción** cambia a **OptionInteger y OptionFloat**.  
  
8.  Asegúrese de que **My Settings** es la única categoría que está seleccionada y, a continuación, haga clic en **siguiente**.  
  
     El **nombre su archivo de configuración** aparece la página.  
  
9. Asigne al nuevo archivo de configuración `MySettings.vssettings` y guárdela en un directorio adecuado. Haga clic en **Finalizar**.  
  
     El **exportación completa** página informa de que la configuración se exportaron correctamente.  
  
10. En el **archivo** menú, elija **abiertos**y, a continuación, haga clic en **archivo**. Busque `MySettings.vssettings` y ábralo.  
  
     Puede encontrar la categoría de propiedad que exportó a la siguiente sección del archivo (el GUID se diferenciarán).  
  
    ```  
    <Category name="My Category_My Settings"   
          Category="{4802bc3e-3d9d-4591-8201-23d1a05216a6}"   
          Package="{6bb6942e-014c-489e-a612-a935680f703d}"   
          RegisteredName="My Category_My Settings">  
          PackageName="MyToolsOptionsPackage">  
       <PropertyValue name="OptionFloat">3.1416</PropertyValue>   
       <PropertyValue name="OptionInteger">12</PropertyValue>   
    </Category>  
    ```  
  
     Tenga en cuenta que el nombre de categoría completa se forma mediante la adición de un carácter de subrayado en el nombre de categoría seguido por el nombre del objeto. OptionFloat y OptionInteger aparecen en la categoría, junto con sus valores exportados.  
  
11. Cierre el archivo de configuración sin modificarlo.  
  
12. En el **herramientas** menú, haga clic en **opciones**, expanda **categoría Mis**, haga clic en **mi página de cuadrícula** y, a continuación, cambie el valor de  **OptionFloat** a 1.0 y **OptionInteger** en 1. Haga clic en **Aceptar**.  
  
13. En el **herramientas** menú, haga clic en **importar y exportar configuraciones**, seleccione **importar la configuración de entorno seleccionada**y, a continuación, haga clic en **siguiente**.  
  
     El **Guardar configuración actual** aparecerá la página.  
  
14. Seleccione **No, sólo importar la nueva configuración** y, a continuación, haga clic en **siguiente**.  
  
     El **elegir una colección de configuraciones para importar** aparecerá la página.  
  
15. Seleccione el `MySettings.vssettings` un archivo en el **My Settings** nodo de la vista de árbol. Si el archivo no aparece en la vista de árbol, haga clic en **examinar** y localizarlo. Haga clic en **Siguiente**.  
  
     El **elegir configuraciones para importar** aparece el cuadro de diálogo.  
  
16. Asegúrese de que **My Settings** está seleccionada y, a continuación, haga clic en **finalizar**. Cuando el **importación completada** aparece en la página, haga clic en **cerrar**.  
  
17. En el **herramientas** menú, haga clic en **opciones**, expanda **categoría Mis**, haga clic en **mi página de cuadrícula** y compruebe que dispone de los valores de categoría de propiedad se han restaurado.