---
title: "Cómo realiza ClickOnce actualizaciones de aplicaciones | Documentos de Microsoft"
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
- updates, ClickOnce
- ClickOnce deployment, updates
- deploying applications [ClickOnce], application updates
ms.assetid: d54313c2-cf0c-420d-b151-99953a95f0bb
caps.latest.revision: "9"
author: stevehoag
ms.author: shoag
manager: wpickett
ms.workload: multiple
ms.openlocfilehash: 6ee199aa98c0c5b72a5693c840b892929e55477a
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-clickonce-performs-application-updates"></a>Cómo realiza ClickOnce actualizaciones de aplicaciones
ClickOnce utiliza la información de versión del archivo especificada en el manifiesto de implementación de una aplicación para decidir si se deben actualizar los archivos de la aplicación. Una vez iniciada una actualización, ClickOnce utiliza una técnica denominada *revisión de archivos* para evitar la descarga de redundancia de los archivos de la aplicación.  
  
## <a name="file-patching"></a>La revisión de archivos  
 Al actualizar una aplicación, ClickOnce no descargar todos los archivos de la nueva versión de la aplicación a menos que los archivos han cambiado. En su lugar, compara las firmas hash de los archivos especificados en el manifiesto de aplicación para la aplicación actual con las firmas en el manifiesto de la nueva versión. Si las firmas de un archivo son diferentes, ClickOnce descarga la nueva versión. Si las firmas coinciden, el archivo no ha cambiado de una versión a la siguiente. En este caso, ClickOnce copia el archivo existente y lo usa en la nueva versión de la aplicación. Este enfoque impide que ClickOnce de tener que descargar toda la aplicación de nuevo, incluso si solo uno o dos archivos han cambiado.  
  
 La revisión de archivos también funciona para los ensamblados que se descargan a petición mediante el <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroup%2A> y <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroupAsync%2A> métodos.  
  
 Si usa Visual Studio para compilar su aplicación, generará nuevas firmas hash para todos los archivos cada vez que se vuelve a generar todo el proyecto. En este caso, todos los ensamblados se descargarán en el cliente, aunque pueden haber cambiado solo algunos ensamblados.  
  
 La revisión de archivos no funciona para los archivos que están marcados como datos y se almacenan en el directorio de datos. Estos se descargarán siempre, independientemente de la firma del archivo hash. Para obtener más información sobre el directorio de datos, vea [obtener acceso Local y remoto datos en aplicaciones ClickOnce](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md).  
  
## <a name="see-also"></a>Vea también  
 [Elegir una estrategia de actualización de ClickOnce](../deployment/choosing-a-clickonce-update-strategy.md)   
 [Elegir una estrategia de implementación ClickOnce](../deployment/choosing-a-clickonce-deployment-strategy.md)