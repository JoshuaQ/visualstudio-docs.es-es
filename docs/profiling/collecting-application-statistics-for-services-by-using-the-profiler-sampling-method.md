---
title: "Recopilar estadísticas de la aplicación para los servicios utilizando el método de muestreo del generador de perfiles | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 07840ab2-3a92-4744-ac87-48b19e0ceecd
caps.latest.revision: "14"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 96c4bb5a9ea5b7ff85f115048fc057191884a016
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="collecting-application-statistics-for-services-by-using-the-profiler-sampling-method"></a>Recopilar estadísticas de la aplicación para los servicios utilizando el método de muestreo del generador de perfiles
En esta sección se describen los procedimientos y las opciones para recopilar estadísticas de rendimiento para servicios de Windows mediante el método de muestreo desde la línea de comandos.  
  
> [!NOTE]
>  Las características de seguridad mejoradas en Windows 8 y Windows Server 2012 requirieron cambios significativos en la forma en que el generador de perfiles de Visual Studio recopila datos en estas plataformas. Las aplicaciones para UWP también requieren nuevas técnicas de recopilación. Consulte [Herramientas de rendimiento en aplicaciones de Windows 8 y Windows Server 2012](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## <a name="common-tasks"></a>Tareas comunes  
  
|Tarea|Contenido relacionado|  
|----------|---------------------|  
|**Adjuntar el generador de perfiles a un servicio de .NET**|-   [Cómo: Adjuntar el generador de perfiles a un servicio de .NET para recopilar estadísticas de la aplicación](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-application-statistics-by-using-the-command-line.md)|  
|**Agregar datos de interacción de capas**|-   [Recopilar datos de interacción de capas](../profiling/adding-tier-interaction-data-from-the-command-line.md)|  
|**Adjuntar el generador de perfiles a un servicio de C o C++**|-   [Cómo: Adjuntar el generador de perfiles a un servicio nativo para recopilar estadísticas de la aplicación](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-application-statistics-by-using-the-command-line.md)|  
  
## <a name="related-tasks"></a>Tareas relacionadas  
  
### <a name="profiling-windows-services"></a>Generar perfiles de servicios de Windows  
  
|Tarea|Contenido relacionado|  
|----------|---------------------|  
|**Generar perfiles mediante el método de instrumentación**|-   [Recopilar datos de control de tiempo detallados utilizando la instrumentación](../profiling/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method-from-the-profiler-command-line.md)|  
|**Generar perfiles de recolección de elementos no utilizados y de asignación de memoria de .NET**|-   [Recopilar datos de memoria de .NET](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md)|  
|**Generar perfiles de actividad de subprocesos y contención de recursos**|-   [Recopilar datos de simultaneidad](../profiling/collecting-concurrency-data-for-a-service-by-using-the-profiler-command-line.md)|  
  
### <a name="profiling-by-using-the-sampling-method"></a>Generar perfiles utilizando el método de muestreo  
  
|Tarea|Contenido relacionado|  
|----------|---------------------|  
|**Generar perfiles de aplicaciones independientes (cliente)**|-   [Recopilar estadísticas de aplicación mediante muestreo](../profiling/collecting-application-statistics-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Generar perfiles de aplicaciones web ASP.NET**|-   [Recopilar estadísticas de aplicación mediante muestreo](../profiling/collecting-application-statistics-for-aspnet-web-applications-using-the-profiler-sampling-method-from-the-command-line.md)|  
  
### <a name="analyzing-sampling-data-views-and-reports"></a>Analizar vistas e informes de datos de muestreo  
 [Vistas de datos del método de muestreo](../profiling/profiler-sampling-method-data-views.md)