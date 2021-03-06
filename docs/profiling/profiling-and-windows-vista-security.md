---
title: Generar perfiles y seguridad en Windows Vista | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- Profiling Tools,security
- performance tools, security
ms.assetid: 842112fc-b886-4801-8cd7-a25b314b0393
caps.latest.revision: "19"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 0dad9e27eff76c36cadf132cb3a1b0aaec1e44da
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="profiling-and-windows-vista-security"></a>Generar perfiles y seguridad en Windows Vista
En función de la configuración de los permisos de acceso de usuario de [!INCLUDE[wiprlhext](../debugger/includes/wiprlhext_md.md)] que haya facilitado un administrador de equipo, un usuario puede tener permisos de seguridad para generar perfiles de un proceso en ese equipo. En los siguientes ejemplos se muestran las posibles diferencias existentes entre los usuarios:  
  
-   Algunos usuarios pueden tener acceso a las características avanzadas de generación de perfiles cuando el administrador ha configurado el controlador y el servicio para que se inicien.  
  
-   Los usuarios de dominio pueden tener acceso solo a la generación de perfiles de ejemplo.  
  
-   Algunos usuarios pueden denegar el acceso a la generación de perfiles a todos los demás usuarios.  
  
 Para obtener más información, consulte las opciones ADMIN de [VSPerfCmd](../profiling/vsperfcmd.md).  
  
## <a name="cross-session-profiling"></a>Generación de perfiles entre sesiones  
 La *generación de perfiles entre sesiones* es la capacidad de generar perfiles de un proceso que se ejecuta en una sesión diferente. Por ejemplo, la mayoría de servicios se ejecutan en la sesión 0 y los usuarios no pueden ejecutarse directamente en la sesión 0. Mediante el uso del botón **Adjuntar al proceso** en la barra de herramientas del explorador de rendimiento o la opción /attach de la herramienta de línea de comandos VSPerfCmd, puede generar perfiles de la mayoría de los procesos en otras sesiones de inicio.  
  
 Puede ver una lista de los procesos que están disponibles mediante el establecimiento de las opciones de visibilidad de generación de perfiles entre procesos. Estas opciones están disponibles en la ventana **Adjuntar al proceso** que aparece al hacer clic en **Adjuntar al proceso**:  
  
-   **Mostrar los procesos de todos los usuarios**  
  
     Cuando no se selecciona esta opción, la lista muestra solamente los procesos que pertenecen al usuario actual. Cuando **Mostrar procesos de todos los usuarios** está seleccionada, la lista muestra los procesos de todos los usuarios.  
  
-   **Mostrar los procesos de todas las sesiones**  
  
     Cuando no se selecciona esta opción, la lista muestra los procesos de la sesión actual. Cuando se selecciona esta opción, la lista muestra los procesos de todas las sesiones.  
  
## <a name="see-also"></a>Vea también  
 [Información general](../profiling/overviews-performance-tools.md)   
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Cómo: Conectar a procesos en ejecución](http://msdn.microsoft.com/en-us/636d0a52-4bfd-48d2-89ad-d7b9ca4dc4f4)