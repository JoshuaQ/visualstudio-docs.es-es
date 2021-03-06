---
title: "Depurar opciones de ejecución paso a paso (heredado) | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: reference
helpviewer_keywords:
- branch stepping
- stepping, options in workflow debugging
- debugging, stepping options
- debugging workflows, stepping options
- instance stepping
ms.assetid: 3e9e3041-68c7-4f16-9bd6-da5e5144744b
caps.latest.revision: "5"
author: ErikRe
ms.author: erikre
manager: erikre
ms.workload: multiple
ms.openlocfilehash: b93226b7223272c04b7d2e6b36b82cf737cd1b86
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="debug-stepping-options-legacy"></a>Depurar opciones de ejecución paso a paso (Heredado)
En este tema se describe cómo depurar aplicaciones [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] con actividades simultáneas en [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] heredado. Use el [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] heredado cuando deba tener como destino [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] o [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 Cuando esté depurando actividades heredadas cuya ejecución sea simultánea, como **ParallelActivity** o **ConditionedActivityGroup**, puede usar una de las dos opciones siguientes para recorrer el código .  
  
-   **Crear una bifurcación ejecución paso a paso.** Este modo de avance le permite recorrer y depurar una bifurcación determinada de una actividad compuesta, como el **ParallelActivity** o **ConditionalActivityGroup** actividad. Al utilizar esta opción para depurar, no advertirá que se produce un cambio de control como consecuencia de la ejecución simultánea de otras actividades en el flujo de trabajo. El depurador solo pasa a través de las actividades de la rama seleccionada actualmente aunque otras actividades del flujo de trabajo se puedan estar ejecutando de forma simultánea. Por ejemplo, de forma predeterminada, la bifurcación del extremo izquierdo en una **ParallelActivity** actividad y la primera actividad secundaria de un **ConditionedActivityGroup** actividad se utilizan para avanzar. Si el usuario está interesado en depurar cualquier otra rama o actividad secundaria, debe colocar un punto de interrupción explícito en esa rama o actividad secundaria. El avance continúa en esa bifurcación cuando se activa el punto de interrupción.  
  
-   **La instancia de ejecución paso a paso.** Este modo de avance le permite pasar por y depurar actividades en el flujo de trabajo que se ejecutan concurrentemente. Con esta opción, observará que se produce un cambio de control al ejecutar actividades del flujo de trabajo simultáneamente.  
  
 De forma predeterminada, está seleccionada la opción de ejecución paso a paso por bifurcaciones y los usuarios pueden pasar de una opción a otra al depurar un flujo de trabajo heredado.  
  
 Debe seleccionar la opción de ejecución paso a paso por instancias cuando depure flujos de trabajo de máquina de estados heredados.  
  
## <a name="see-also"></a>Vea también  
 [Depurar flujos de trabajo heredado](../workflow-designer/debugging-legacy-workflows.md)   
 [Cómo: Cambiar la opción de ejecución paso a paso de depuración (heredado)](../workflow-designer/how-to-change-the-debug-stepping-option-legacy.md)