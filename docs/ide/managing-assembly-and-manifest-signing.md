---
title: Administrar la firma de ensamblados y manifiestos | Microsoft Docs
ms.custom: 
ms.date: 02/17/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- manifests [Visual Studio]
- signing manifests [Visual Studio]
- application manifests [Visual Studio]
- assemblies [Visual Studio], signing
ms.assetid: 6c1ef36b-25f7-4ad0-b29a-51801b7a5420
caps.latest.revision: "15"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: d8227a514887150e3477e026a238df608fe98d11
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="managing-assembly-and-manifest-signing"></a>Administrar la firma de ensamblados y manifiestos
La firma de nombre seguro ofrece una identidad única a un componente de software. Los nombres seguros se usan para garantizar que otra persona no puede suplantar la identidad del ensamblado y para garantizar que las dependencias de componente e instrucciones de configuración se asignan al componente y a la versión del componente correctos.  
  
 Un nombre seguro se compone de la identidad del ensamblado (nombre de texto simple, número de versión e información sobre referencia cultural), más un token de clave pública y una firma digital.  
  
 Para obtener información sobre cómo firmar ensamblados en proyectos de Visual Basic y C#, consulte [Crear y utilizar ensamblados con nombre seguro](http://msdn.microsoft.com/Library/ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9).  
  
 Para obtener información sobre cómo firmar ensamblados en proyectos de Visual C++, consulte [Ensamblados de nombre seguro (Firma de ensamblados) (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli).  

> [!NOTE]
>  La firma de nombre seguro no protege contra la ingeniería inversa del ensamblado.  Para protegerse contra las técnicas de ingeniería inversa, consulte [Dotfuscator Community Edition (CE)](dotfuscator/index.md).
  
## <a name="asset-types-and-signing"></a>Tipos de recursos y firma  
 Puede firmar manifiestos de aplicación y ensamblados .NET. Entre ellas se incluyen las siguientes:  
  
-   archivos ejecutables (.exe)  
  
-   manifiestos de aplicación (.exe.manifest)  
  
-   manifiestos de implementación (.application)  
  
-   ensamblados de componente compartido (.dll)  
  
Debe firmar los siguientes tipos de recurso:  
  
1.  Ensamblados, si quiere implementarlos en la caché global de ensamblados (GAC).  
  
2.  Manifiestos de implementación y aplicación [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)]. Visual Studio permite firmar de manera predeterminada estas aplicaciones.  
  
3.  Los ensamblados de interoperabilidad primarios, que se usan para la interoperabilidad COM. La utilidad TLBIMP exige nombres seguros al crear un ensamblado de interoperabilidad primario de una biblioteca de tipos COM.  
  
En general, no debería firmar archivos ejecutables. Un componente con nombre seguro no puede hacer referencia a un componente con nombre no seguro que se implementa con la aplicación. Visual Studio no firma los archivos ejecutables de aplicaciones, pero en su lugar firma el manifiesto de aplicación, que señala al archivo ejecutable de nombre no seguro. Se recomienda evitar firmar componentes que son privados para la aplicación, porque si los firma puede ser más difícil administrar las dependencias.  
  
## <a name="how-to-sign-an-assembly-in-visual-studio"></a>Cómo firmar un ensamblado en Visual Studio  
 Puede firmar una aplicación o componente mediante la pestaña **Firma** de la ventana Propiedades del proyecto (haga clic con el botón derecho en el nodo del proyecto en el **Explorador de soluciones** y seleccione **Propiedades**, escriba las **propiedades del proyecto** en la ventana **Inicio rápido** o pulse ALT + ENTRAR en la ventana **Explorador de soluciones**). En la pestaña **Firma**, active la casilla **Firmar el ensamblado**.  
  
 Especifique un archivo de clave. Si decide crear un nuevo archivo de clave, tenga en cuenta que los nuevos archivos de clave se crean siempre en el formato .pfx. Necesita un nombre y una contraseña para el nuevo archivo.  
  
> [!WARNING]
>  Siempre debe proteger el archivo de clave con una contraseña para evitar que otra persona lo use. También puede proteger las claves mediante proveedores o almacenes de certificados.  
  
 También puede señalar a una clave que ya ha creado. Para obtener más información sobre la creación de claves, consulte [Cómo: Crear un par de claves privada y pública](/dotnet/framework/app-domains/how-to-create-a-public-private-key-pair).  
  
 Si tiene acceso solo a una clave pública, puede usar Retrasar la firma para aplazar la asignación de la clave. Para habilitar Retrasar la firma, active la casilla **Retrasar firma solo**. Un proyecto con retraso de firma no se ejecutará y no lo podrá depurar. En cambio, puede omitir la comprobación durante el desarrollo al usar [Sn.exe (Herramienta de nombre seguro)](/dotnet/framework/tools/sn-exe-strong-name-tool) con la opción `-Vr`.  
  
 Para obtener información sobre cómo firmar manifiestos, consulte [Cómo: Firmar aplicaciones y manifiestos de implementación](../ide/how-to-sign-application-and-deployment-manifests.md).  
  
## <a name="see-also"></a>Vea también  
 [Ensamblados con nombre seguro](/dotnet/framework/app-domains/strong-named-assemblies)   
 [Ensamblados de nombre seguro (Firma de ensamblados) (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli)