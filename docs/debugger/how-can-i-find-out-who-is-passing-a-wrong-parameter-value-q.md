---
title: "Cómo averiguar quién está pasando un valor de parámetro erróneo | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vs.debug.parameters
dev_langs:
- CSharp
- VB
- FSharp
- C++
helpviewer_keywords:
- debugging [C++], parameters
- parameters [debugger]
- passing parameters, troubleshooting wrong values
- functions [debugger], detecting wrong parameter values
- parameter values, troubleshooting
ms.assetid: 1f1ae455-0e25-4e9d-b33f-53908f5bd6ce
caps.latest.revision: "19"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 77c4953840c879a14406003f0bafffe98908cd95
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-can-i-find-out-who-is-passing-a-wrong-parameter-value"></a>Cómo averiguar quién está pasando un valor de parámetro erróneo
## <a name="problem-description"></a>Descripción del problema  
 Una de las funciones recibe un valor de parámetro erróneo. La llamada a esta función se realiza desde múltiples lugares. ¿Cómo puedo averiguar qué llamada está pasando el valor erróneo?  
  
## <a name="solution"></a>Soluciones  
  
#### <a name="to-resolve-this-problem"></a>Para solucionar este problema  
  
1.  Establezca un punto de interrupción de ubicación al principio de la función.  
  
2.  Haga clic en el punto de interrupción y seleccione **condición**.  
  
3.  En el **condición de punto de interrupción** cuadro de diálogo, haga clic en el **condición** casilla de verificación. Vea [avanzada de los puntos de interrupción](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).  
  
4.  Escriba una expresión, como `Var==3`, en el cuadro de texto, donde `Var` es el nombre del parámetro que contiene el valor no válido, y `3` es el valor no válido que se le ha pasado.  
  
5.  Seleccione el **es True** botón de radio y haga clic en el **Aceptar** botón.  
  
6.  Ejecute el programa otra vez. El punto de interrupción hace que el programa se detenga al principio de la función cuando el parámetro `Var` sea `3`.  
  
7.  Utilice la ventana Pila de llamadas para detectar la función que realizó la llamada y navegar hasta su código fuente. Para obtener más información, consulte [Cómo: utilizar la ventana Pila de llamadas](../debugger/how-to-use-the-call-stack-window.md).  
  
## <a name="see-also"></a>Vea también  
 [Preguntas frecuentes sobre depuración de código nativo](../debugger/debugging-native-code-faqs.md)   
 [Puntos de interrupción](http://msdn.microsoft.com/en-us/fe4eedc1-71aa-4928-962f-0912c334d583)   
 [Depuración de código nativo](../debugger/debugging-native-code.md)