---
title: Recopilar datos de simultaneidad de subprocesos y procesos | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- concurrency profiling method
- Profiling Tools, concurrency method
ms.assetid: fa03d381-a9ee-408c-876d-05111e29225b
caps.latest.revision: "14"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 130e8ba80bb4d8f28ee64aeba1202463552eb20a
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="collecting-thread-and-process-concurrency-data"></a>Recopilar datos de simultaneidad de subprocesos y procesos
El método de generación de perfiles de simultaneidad de las herramientas de generación de perfiles de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] permite recopilar datos de contención de recursos que incluyen información sobre cada evento de sincronización que hace que una función de la aplicación perfilada espere para obtener acceso a un recurso.  
  
 **Requisitos**  
  
-   [!INCLUDE[vsUltLong](../code-quality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../code-quality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../code-quality/includes/vspro_md.md)]  
  
 Puede especificar el método de generación de perfiles de simultaneidad mediante uno de los procedimientos siguientes:  
  
-   En la primera página del Asistente de generación de perfiles, haga clic en **Simultaneidad**  
  
-   En la página **General** del cuadro de diálogo de propiedades de la sesión de rendimiento, haga clic en **Simultaneidad**.  
  
-   En la barra de herramientas **Explorador de rendimiento**, en la lista **Método**, haga clic en **Simultaneidad**.  
  
## <a name="common-tasks"></a>Tareas comunes  
 Puede especificar opciones adicionales en el cuadro de diálogo *Páginas de propiedades de***sesión de rendimiento** de la sesión de rendimiento. Para abrir este cuadro de diálogo:  
  
-   En el **Explorador de rendimiento**, haga clic con el botón secundario del mouse en el nombre de la sesión y, a continuación, haga clic en **Propiedades**.  
  
 Las tareas de la tabla siguiente describen las opciones que puede especificar en el cuadro de diálogo *Páginas de propiedades de***sesión de rendimiento** cuando genere perfiles mediante el método de simultaneidad.  
  
|Tarea|Contenido relacionado|  
|----------|---------------------|  
|En la página **General** , especifique los detalles de nomenclatura del archivo de datos de generación de perfiles generado (.vsp).|-   [Cómo: Establecer opciones de nombre de archivo de datos de rendimiento](../profiling/how-to-set-performance-data-file-name-options.md)|  
|En la página **Iniciar**, especifique la aplicación que quiere iniciar si tiene varios proyectos .exe en la solución de código.|-   [Cómo: Especificar el binario de inicio](../profiling/how-to-specify-the-binary-to-start.md)|  
|En la página **Interacción de capas** , agregue los datos de la llamada ADO.NET a la ejecución de la generación de perfiles.|-   [Recopilar datos de interacción de capas](../profiling/collecting-tier-interaction-data.md)|  
|En la página **Contadores de Windows** , especifique uno o varios contadores de rendimiento de sistema operativo para agregar a los datos de generación de perfiles como marcas.|-   [Cómo: Recopilar datos de contadores de Windows](../profiling/how-to-collect-windows-counter-data.md)|  
|En la página **Avanzado**, especifique la versión del runtime de .NET Framework de la cual quiere generar el perfil si los módulos de aplicación utilizan varias versiones. De forma predeterminada, se genera el perfil de la primera versión cargada.|-   [Cómo: Especificar el runtime de .NET Framework](../profiling/how-to-specify-the-dotnet-framework-runtime.md)|