---
title: "Cómo: especificar dónde Visual Studio copia los archivos | Documentos de Microsoft"
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
- publishing, specifying location
- Publish Location property
ms.assetid: 6c552700-dda3-49fe-af98-4717344fda07
caps.latest.revision: "12"
author: stevehoag
ms.author: shoag
manager: wpickett
ms.workload: multiple
ms.openlocfilehash: 9392686e08048ea88615b927cf942d66a4b9a06c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-specify-where-visual-studio-copies-the-files"></a>Cómo: Especificar dónde Visual Studio copia los archivos
Al publicar una aplicación mediante ClickOnce, la propiedad `Publish Location` especifica la ubicación donde se colocan los archivos de la aplicación y el manifiesto. La ubicación puede ser una ruta de acceso de archivo o la ruta de acceso a un servidor FTP.  
  
 Puede especificar el `Publish Location` propiedad en el **publicar** página de la **Diseñador de proyectos**, o mediante el Asistente para publicación. Para obtener más información, consulte [Cómo: publicar una aplicación ClickOnce sin usar el Asistente para publicación](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).  
  
> [!NOTE]
>  Cuando se instala más de una versión de una aplicación con ClickOnce, la instalación mueve las versiones anteriores de la aplicación a una carpeta llamada Archivo, en la ubicación de publicación que especifiques. Al archivar las versiones anteriores de esta manera, el directorio de instalación se mantiene limpio de carpetas de versiones anteriores.  
  
### <a name="to-specify-a-publishing-location"></a>Para especificar una ubicación de publicación  
  
1.  Seleccione un proyecto en el **Explorador de soluciones**y, en el menú **Proyecto** , haga clic en **Propiedades**.  
  
2.  Haga clic en el **publicar** ficha.  
  
3.  En el **ubicación de publicación** , escriba la ubicación de publicación mediante uno de los siguientes formatos:  
  
    -   Para publicar en una ruta de acceso de disco o recurso compartido de archivo, escriba la ruta de acceso mediante una ruta de acceso UNC (\\\Server\ApplicationName) o una ruta de acceso de archivo (C:\Deploy\ApplicationName).  
  
    -   Para publicar en un servidor FTP, escriba la ruta de acceso con el formato ftp://ftp.microsoft.com/NombreAplicación.  
  
     Tenga en cuenta que el texto debe estar presente en el **ubicación de publicación** cuadro en orden para el botón Examinar (**...** ) para que funcione botón.  
  
## <a name="see-also"></a>Vea también  
 [Publicar aplicaciones ClickOnce](../deployment/publishing-clickonce-applications.md)   
 [Cómo: Publicar una aplicación ClickOnce mediante el Asistente para publicación](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)