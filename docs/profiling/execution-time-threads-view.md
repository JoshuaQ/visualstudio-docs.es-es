---
title: "Tiempo de ejecución (vista de subprocesos) | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology:
- vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- vs.cv.threads.timeline.execution
helpviewer_keywords:
- Concurrency Visualizer, Execution Time (Threads View)
ms.assetid: 80c100f8-2502-4613-bfef-4f4f2e09cc8d
caps.latest.revision: 10
author: mikejo5000
ms.author: mikejo
manager: ghogen
translation.priority.ht:
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- ru-ru
- zh-cn
- zh-tw
translation.priority.mt:
- cs-cz
- pl-pl
- pt-br
- tr-tr
translationtype: Human Translation
ms.sourcegitcommit: 5db97d19b1b823388a465bba15d057b30ff0b3ce
ms.openlocfilehash: ee9d0dc29509e9b41fbec9691061c1ed928f063c
ms.lasthandoff: 02/22/2017

---
# <a name="execution-time-threads-view"></a>Tiempo de ejecución (Vista de subprocesos)
Estos segmentos de la escala de tiempo de la vista de subprocesos representan el tiempo de ejecución, cuando el subproceso está realizando activamente una tarea en un núcleo lógico en el sistema.  
  
 Los cambios en el estado del subproceso se detectan mediante eventos de cambio de contexto de kernel. El seguimiento de eventos para Windows (ETW) captura pilas de muestras cada milisegundo. En un segmento verde muy corto, es posible que no se tome ninguna muestra. Por lo tanto, puede que algunos segmentos de ejecución cortos no muestren ninguna pila de llamadas.  
  
 Al hacer clic en un segmento de ejecución, el visualizador de simultaneidad muestra la pila de muestras más cercana a la ubicación del clic. La ubicación de esa pila de muestras se indica mediante una flecha negra, o un símbolo de intercalación, sobre la escala de tiempo y la pila de muestras aparece en la pestaña **Actual**.  
  
 Para ver un perfil de muestreo tradicional para todos los segmentos de ejecución en la vista actual, haga clic en **Ejecución** en el perfil de escala de tiempo visible.  
  
## <a name="see-also"></a>Vea también  
 [Informe del perfil de ejecución](../profiling/execution-profile-report.md)   
 [Vista de subprocesos](../profiling/threads-view-parallel-performance.md)