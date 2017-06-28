---
title: "C&#243;mo: Instrumentar un componente nativo independiente y recopilar datos de control de tiempo con el generador de perfiles desde la l&#237;nea de comandos | Microsoft Docs"
ms.custom: ""
ms.date: "12/15/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 36883074-9be8-4e90-a66f-7e87f21fcd30
caps.latest.revision: 25
caps.handback.revision: 25
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# C&#243;mo: Instrumentar un componente nativo independiente y recopilar datos de control de tiempo con el generador de perfiles desde la l&#237;nea de comandos
[!INCLUDE[vs2017banner](../code-quality/includes/vs2017banner.md)]

En este tema se describe cómo utilizar las herramientas de línea de comandos de las herramientas de generación de perfiles de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] para instrumentar un componente nativo, tal como un archivo .exe o .dll de C\+\+ y para recopilar datos detallados de control de tiempo.  
  
> [!NOTE]
>  Las herramientas de línea de comandos de las Herramientas de generación de perfiles se encuentran en el subdirectorio \\Team Tools\\Performance Tools del directorio de instalación de [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)].  En equipos de 64 bits, están disponibles las dos versiones de las herramientas, la de 64 bits y la de 32 bits.  Para utilizar las herramientas de línea de comandos del generador de perfiles, debe agregar la ruta de acceso de las herramientas a la variable de entorno PATH de la ventana Símbolo del sistema o agregarla al propio comando.  Para obtener más información, vea [Especificar la ruta de acceso a las herramientas de línea de comandos](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).  
  
 Para recopilar datos de control de tiempo detallados de un componente con el método de instrumentación, utilice la herramienta [VSInstr.exe](../profiling/vsinstr.md) para generar una versión instrumentada del componente.  A continuación, inicie el generador de perfiles.  Cuando se ejecute el componente instrumentado, los datos de tiempo se recopilarán inmediatamente en un archivo de datos.  Puede pausar y reanudar la recolección de datos durante la sesión de generación de perfiles.  
  
 Para finalizar una sesión de generación de perfiles, cierre la aplicación de destino y apague explícitamente el generador de perfiles.  
  
## Iniciar la sesión de generación de perfiles  
  
#### Para iniciar la generación de perfiles utilizando el método de instrumentación  
  
1.  Abra una ventana de símbolo del sistema.  
  
2.  Utilice la herramienta **VSInstr** para generar una versión instrumentada de la aplicación de destino.  
  
3.  Inicie el generador de perfiles.  Escriba:  
  
     **VSPerfCmd \/start:trace \/output:** `OutputFile` \[`Options`\]  
  
    -   La opción [\/start](../profiling/start.md)**:trace** inicializa el generador de perfiles.  
  
    -   La opción [\/output](../profiling/output.md)**:**`OutputFile` es necesaria con **\/start**.  `OutputFile` especifica el nombre y la ubicación del archivo de datos de generación de perfiles \(.vsp\).  
  
     Puede utilizar una o más de las opciones siguientes con la opción **\/start:trace**.  
  
    |Opción|Descripción|  
    |------------|-----------------|  
    |[\/usuario](../profiling/user-vsperfcmd.md) **:**\[`Domain`**\\**\]`UserName`|Especifica el dominio y el nombre de usuario de la cuenta propietaria del proceso para el que se han generado perfiles.  Esta opción solamente es necesaria si el proceso se está ejecutando como otro usuario distinto del usuario que inició sesión.  El propietario del proceso se muestra en la columna Nombre de usuario de la pestaña Procesos del Administrador de tareas de Windows.|  
    |[\/crosssession](../profiling/crosssession.md)|Habilita la generación de perfiles de procesos en otras sesiones.  Esta opción es necesaria si la aplicación se ejecuta en una sesión diferente.  El identificador de sesión se muestra en la columna Id. de sesión de la pestaña Procesos del Administrador de tareas de Windows.  **\/CS** se puede especificar como una abreviatura de **\/crosssession**.|  
    |[\/globaloff](../profiling/globalon-and-globaloff.md)|Inicia el generador de perfiles con la recolección de datos en pausa.  Utilice [\/globalon](../profiling/globalon-and-globaloff.md) para reanudar la generación de perfiles.|  
    |[\/counter](../profiling/counter.md) **:** `Config`|Recopila información del contador de rendimiento del procesador especificado en `Config`.  La información del contador se agrega a los datos recopilados en cada evento de generación de perfiles.|  
    |[\/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`|Especifica un contador de rendimiento de Windows que se va a recopilar durante la generación de perfiles.|  
    |[\/automark](../profiling/automark.md) **:** `Interval`|Se utiliza únicamente con **\/wincounter**.  Especifica el número de milisegundos entre eventos de recopilación de contadores de rendimiento de Windows.  El valor predeterminado es 500 ms.|  
    |[\/events](../profiling/events-vsperfcmd.md) **:** `Config`|Especifica un evento de Seguimiento de eventos para Windows \(ETW\) que se va a recopilar durante la generación de perfiles.  Los eventos ETW se recopilan en un archivo \(.etl\) independiente.|  
  
4.  Inicie la aplicación de destino de la manera habitual.  
  
## Controlar la recolección de datos  
 Mientras se ejecuta la aplicación de destino, puede controlar la recolección de datos iniciando o deteniendo la escritura de los datos en un archivo mediante el uso de las opciones de **VSPerfCmd.exe**.  Al controlar la recolección de datos, puede recopilar datos de una parte específica de la ejecución de un programa, como por ejemplo el inicio o el cierre de una aplicación.  
  
#### Para iniciar y detener la recolección de datos  
  
-   Los siguientes pares de opciones inician y detienen la recolección de datos.  Especifique cada opción en una línea de comandos diferente.  Puede activar y desactivar la recolección de datos varias veces.  
  
    |Opción|Descripción|  
    |------------|-----------------|  
    |[\/globalon \/globaloff](../profiling/globalon-and-globaloff.md)|Inicia \(**\/globalon**\) o detiene \(**\/globaloff**\) la recolección de datos de todos los procesos.|  
    |[\/processon](../profiling/processon-and-processoff.md) **:** `PID` [\/processoff](../profiling/processon-and-processoff.md)**:**`PID`|Inicia \(**\/processon**\) o detiene \(**\/processoff**\) la recolección de datos para el proceso especificado por el identificador de proceso \(`PID`\).|  
    |[\/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [\/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Inicia \(**\/threadon**\) o detiene \(**\/threadoff**\) la recolección de datos del subproceso especificado por el identificador del subproceso \(`TID`\).|  
  
## Finalizar la sesión de generación de perfiles  
 Para finalizar una sesión generación de perfiles, cierre la aplicación que está ejecutando el componente instrumentado y, a continuación, llame a la opción **VSPerfCmd** [\/shutdown](../profiling/shutdown.md) para desactivar el generador de perfiles y cerrar el archivo de datos de generación de perfiles.  
  
#### Para finalizar una sesión de generación de perfiles  
  
1.  Cierre la aplicación de destino.  
  
2.  Apague el generador de perfiles.  Escriba:  
  
     **VSPerfCmd \/shutdown**  
  
## Vea también  
 [Generar perfiles para aplicaciones independientes](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Vistas de datos del método de instrumentación](../profiling/instrumentation-method-data-views.md)