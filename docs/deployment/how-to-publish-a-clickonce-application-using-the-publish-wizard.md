---
title: "Cómo: publicar una aplicación ClickOnce sin usar el Asistente para publicación | Documentos de Microsoft"
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
- ClickOnce deployment, publishing
- deploying applications [ClickOnce], Publish wizard
- Windows applications, ClickOnce deployments
- publishing, ClickOnce
ms.assetid: 2e4aa67c-4445-4f7b-9e03-9acb95829127
caps.latest.revision: "25"
author: stevehoag
ms.author: shoag
manager: wpickett
ms.workload: multiple
ms.openlocfilehash: d314763f8ff4dc170148cca166e3ecdff051ae24
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-publish-a-clickonce-application-using-the-publish-wizard"></a>Cómo: Publicar una aplicación ClickOnce sin usar el Asistente para publicación
Para que una aplicación ClickOnce esté disponible para los usuarios, debe publicarla en un recurso compartido de archivos o ruta de acceso, en un servidor FTP o en un medio extraíble. Puede publicar la aplicación mediante el Asistente para publicación; propiedades adicionales relacionados a la publicación están disponibles en la **publicar** página de la **Diseñador de proyectos**. Para obtener más información, consulte [publicar aplicaciones ClickOnce](../deployment/publishing-clickonce-applications.md).  
  
 Antes de ejecutar el Asistente para publicación, debe establecer las propiedades de publicación correctamente. Por ejemplo, si desea designar una clave para firmar la aplicación ClickOnce, puede hacerlo en el **firma** página de la **Diseñador de proyectos**. Para más información, consulte [Proteger las aplicaciones ClickOnce](../deployment/securing-clickonce-applications.md).  
  
> [!NOTE]
>  Cuando se instala más de una versión de una aplicación con ClickOnce, la instalación mueve las versiones anteriores de la aplicación a una carpeta llamada Archivo, en la ubicación de publicación que especifiques. Al archivar las versiones anteriores de esta manera, el directorio de instalación se mantiene limpio de carpetas de versiones anteriores.  
  
> [!NOTE]
>  Los cuadros de diálogo y los comandos de menú que se ven pueden diferir de los descritos en la Ayuda, dependiendo de los valores de configuración o de edición activos. Para cambiar la configuración, haga clic en **Importar y exportar configuraciones** en el menú **Herramientas** . Para más información, vea [Personalizar el IDE de Visual Studio](../ide/personalizing-the-visual-studio-ide.md).  
  
### <a name="to-publish-to-a-file-share-or-path"></a>Para publicar en un recurso compartido de archivos o en una ruta de acceso  
  
1.  En **el Explorador de soluciones**, seleccione el proyecto de aplicación.  
  
2.  En el **generar** menú, haga clic en **publicar**`Projectname`.  
  
     Aparece el Asistente para publicación.  
  
3.  En el **donde desea publicar la aplicación?** página, escriba una dirección válida de servidor FTP o una ruta de acceso de archivo válida con uno de los formatos mostrados y, a continuación, haga clic en **siguiente**.  
  
4.  En el **cómo los usuarios instalan la aplicación?** página, seleccione la ubicación donde los usuarios irán para instalar la aplicación:  
  
    -   Si los usuarios instalarán desde un sitio Web, haga clic en **desde un sitio Web** y escriba una dirección URL que corresponde a la ruta de acceso de archivo que especificó en el paso anterior. Haga clic en **Siguiente**. (Esta opción se usa normalmente cuando se especifica una dirección FTP como ubicación de publicación. No se permite la descarga directa desde FTP. Por lo tanto, tiene que especificar una dirección URL aquí).  
  
    -   Si los usuarios instalarán la aplicación directamente desde el recurso compartido de archivos, haga clic en **recurso compartido de archivo o ruta de acceso de UNC a**y, a continuación, haga clic en **siguiente**. (Esto es para la publicación de ubicaciones de formato c:\deploy\myapp o \\\server\myapp.)  
  
    -   Si los usuarios van a instalar desde medios extraíbles, haga clic en **desde un CD-ROM o DVD-ROM**y, a continuación, haga clic en **siguiente**.  
  
5.  En el **la aplicación estará disponible sin conexión?** página, haga clic en la opción adecuada:  
  
    -   Si desea permitir que la aplicación se ejecute cuando el usuario está desconectado de la red, haga clic en **Sí, esta aplicación estará disponible en línea o sin conexión**. Un acceso directo en el **iniciar** menú se creará para la aplicación.  
  
    -   Si desea ejecutar la aplicación directamente desde la ubicación de publicación, haga clic en **No, esta aplicación sólo está disponible en línea**. Un acceso directo en el **iniciar** menú no se creará.  
  
     Haga clic en **Siguiente** para continuar.  
  
6.  Haga clic en **finalizar** para publicar la aplicación.  
  
     El estado de publicación se muestra en el área de notificación del estado.  
  
### <a name="to-publish-to-a-cd-rom-or-dvd-rom"></a>Para publicar en un CD-ROM o DVD-ROM  
  
1.  En **el Explorador de soluciones**, haga clic en el proyecto de aplicación y haga clic en **propiedades**.  
  
     Aparece el **Diseñador de proyectos**.  
  
2.  Haga clic en el **publicar** ficha para abrir el **publicar** página en el **Diseñador de proyectos**y haga clic en el **Asistente para publicación** botón.  
  
     Aparece el Asistente para publicación.  
  
3.  En el **donde desea publicar la aplicación?** página, escriba la ruta de acceso de archivo o ubicación FTP donde se publicará la aplicación, por ejemplo, d:\deploy. A continuación, haga clic en **siguiente** para continuar.  
  
4.  En el **cómo los usuarios instalan la aplicación?** página, haga clic en desde un **CD-ROM o DVD-ROM**y, a continuación, haga clic en **siguiente**.  
  
    > [!NOTE]
    >  Si desea que la instalación se ejecute automáticamente cuando se inserta el CD-ROM en la unidad, abra el **publicar** página en el **Diseñador de proyectos** y haga clic en el **opciones** botón y, a continuación, en la **opciones de publicación** asistente, seleccione **instalaciones para CD-ROM, se inicia automáticamente el programa de instalación cuando se inserta el CD**.  
  
5.  Si distribuye su aplicación en CD-ROM, quizás quiera proporcionar actualizaciones desde un sitio web. En el **dónde buscará la aplicación las actualizaciones?** página, elija una opción de actualización:  
  
    -   Si la aplicación buscará actualizaciones, haga clic en **la aplicación buscará actualizaciones en la siguiente ubicación** y escriba la ubicación donde se publicarán las actualizaciones. Puede ser una ubicación de archivos, un sitio web o un servidor FTP.  
  
    -   Si la aplicación no buscará actualizaciones, haga clic en **la aplicación no buscará actualizaciones**.  
  
     Haga clic en **Siguiente** para continuar.  
  
6.  Haga clic en **finalizar** para publicar la aplicación.  
  
     El estado de publicación se muestra en el área de notificación del estado.  
  
    > [!NOTE]
    >  Una vez completa la publicación, tendrá que usar un grabador de CD o de DVD para copiar los archivos desde la ubicación especificada en el paso 3 al CD-ROM o DVD-ROM.  
  
## <a name="see-also"></a>Vea también  
 [Seguridad e implementación ClickOnce](../deployment/clickonce-security-and-deployment.md)   
 [Proteger las aplicaciones ClickOnce](../deployment/securing-clickonce-applications.md)   
 [Implementación de una solución de Office mediante ClickOnce](/office-dev/office-dev/deploying-an-office-solution-by-using-clickonce)