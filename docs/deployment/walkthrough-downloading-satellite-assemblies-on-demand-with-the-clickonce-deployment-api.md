---
title: "Tutorial: Descargar ensamblados satélite a petición con la API de implementación de ClickOnce | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-deployment
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- ClickOnce deployment, globalization
- localization, Windows Forms
- Windows Forms, localization
- globalization, ClickOnce
- satellite assemblies, ClickOnce
- ClickOnce deployment, on-demand download
- localization, ClickOnce deployment
- ClickOnce deployment, localization
ms.assetid: fdaa553f-a27e-44eb-a4e2-08c122105a87
caps.latest.revision: "11"
author: stevehoag
ms.author: shoag
manager: wpickett
ms.workload: multiple
ms.openlocfilehash: daa6b9b61083f61d631c6dd55265c338c08ff7f9
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api"></a>Tutorial: Descargar ensamblados satélite a petición con la API de implementación de ClickOnce
Las aplicaciones de Windows Forms pueden configurarse para varias referencias culturales utilizando ensamblados satélite. Un *ensamblado satélite* es un ensamblado que contiene los recursos de aplicación para una referencia cultural que no sea la referencia cultural predeterminada de la aplicación.  
  
 Como se describe en [localizar aplicaciones ClickOnce](../deployment/localizing-clickonce-applications.md), puede incluir varios ensamblados satélite para varias referencias culturales en la misma [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] implementación. De forma predeterminada, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] descargará todos los ensamblados satélite en su implementación en el equipo cliente, aunque un cliente individual probablemente solo requiera un único ensamblado satélite.  
  
 En este tutorial se demuestra cómo marcar los ensamblados satélite como opcionales y descargar únicamente el ensamblado que necesite un equipo cliente para la configuración de su referencia cultural actual. El siguiente procedimiento usa las herramientas disponibles en el [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)]. También puede realizar esta tarea mediante [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  Consulte también los tutoriales sobre [descarga de ensamblados satélite a petición con la API de implementación de ClickOnce mediante el diseñador](http://msdn.microsoft.com/library/ms366788\(v=vs.110\)) o [descarga de ensamblados satélite a petición con la API de implementación de ClickOnce mediante el diseñador](http://msdn.microsoft.com/library/ms366788\(v=vs.120\)).  
  
> [!NOTE]
>  Con fines de prueba, el siguiente ejemplo de código establece la referencia cultural en `ja-JP`mediante programación. Vea la sección “Pasos siguientes“ más adelante en este tema para obtener información sobre cómo ajustar este código para un entorno de producción.  
  
## <a name="prerequisites"></a>Requisitos previos  
 En este tema, se da por sentado que sabe agregar recursos localizados a la aplicación mediante Visual Studio. Para obtener instrucciones detalladas, vea [Tutorial: Adaptar Windows Forms](https://msdn.microsoft.com/en-us/library/vstudio/y99d1cd3\(v=vs.100\).aspx).  
  
### <a name="to-download-satellite-assemblies-on-demand"></a>Para descargar ensamblados satélite a petición  
  
1.  Agregue el siguiente código a la aplicación para habilitar la descarga a petición de ensamblados satélite.  
  
     [!code-csharp[ClickOnce.SatelliteAssembliesSDK#1](../deployment/codesnippet/CSharp/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api_1.cs)]
     [!code-vb[ClickOnce.SatelliteAssembliesSDK#1](../deployment/codesnippet/VisualBasic/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api_1.vb)]  
  
2.  Genere los ensamblados satélite de la aplicación mediante [Resgen.exe (generador de archivos de recursos)](/dotnet/framework/tools/resgen-exe-resource-file-generator) o [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
3.  Genere un manifiesto de aplicación o abra el manifiesto de aplicación existente mediante MageUI.exe. Para obtener más información sobre esta herramienta, consulte [MageUI.exe (generación de manifiestos y herramienta de edición, cliente gráfico)](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client).  
  
4.  Haga clic en la ficha **Archivos** .  
  
5.  Haga clic en el botón **puntos suspensivos** (**...**) y seleccione el directorio que contenga todos los ensamblados y archivos de la aplicación, incluidos los ensamblados satélite generados mediante Resgen.exe (el nombre de los ensamblados satélite tiene la siguiente forma: *isoCode*\ApplicationName.resources.dll, donde *isoCode* es un identificador de idioma en formato RFC 1766).  
  
6.  Haga clic en **Rellenar** para agregar los archivos a la implementación.  
  
7.  Active la casilla **Opcional** de cada ensamblado satélite.  
  
8.  Establezca el campo de grupo de cada ensamblado satélite en su identificador de idioma ISO. Por ejemplo, para un ensamblado satélite japonés, debe especificar el nombre de grupo de descarga `ja-JP`. De este modo, se habilitará el código agregado en el paso 1 para descargar el ensamblado satélite adecuado, en función del valor de la propiedad <xref:System.Threading.Thread.CurrentUICulture%2A> del usuario.  
  
## <a name="next-steps"></a>Pasos siguientes  
 En un entorno de producción, probablemente tenga que quitar la línea en el ejemplo de código que establece <xref:System.Threading.Thread.CurrentUICulture%2A> en un valor específico porque los equipos cliente tendrán establecido el valor correcto de forma predeterminada. Cuando la aplicación se ejecute en un equipo cliente japonés, por ejemplo, <xref:System.Threading.Thread.CurrentUICulture%2A> será `ja-JP` de forma predeterminada. Establecer este valor mediante programación es una buena manera de probar los ensamblados satélite antes de implementar la aplicación.  
  
## <a name="see-also"></a>Vea también  
 [Localizar aplicaciones ClickOnce](../deployment/localizing-clickonce-applications.md)