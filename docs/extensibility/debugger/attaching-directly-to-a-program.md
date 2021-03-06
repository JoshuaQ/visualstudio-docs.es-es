---
title: Conectar directamente a un programa | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: debug engines, attaching to programs
ms.assetid: ad2b7db8-821c-440c-ba07-c55c6a395e0f
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: c528925e323e4cff5784365e3097cc7f5f414963
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="attaching-directly-to-a-program"></a>Conectar directamente a un programa
Los usuarios que van a depurar programas en un proceso que ya se está ejecutando normalmente siguen este proceso:  
  
1.  En el IDE, elija la **procesos de depuración** línea de comandos desde el **herramientas** menú.  
  
     El **procesos** aparece el cuadro de diálogo.  
  
2.  Elija un proceso y haga clic en el **adjuntar** botón.  
  
     El **adjuntar al proceso** aparece el cuadro de diálogo, enumerar todos los motores de depuración (DEs) instalados en el equipo.  
  
3.  Especifique el DEs se usa para depurar el proceso seleccionado y, a continuación, haga clic en **Aceptar**.  
  
 El paquete de depuración inicia una sesión de depuración y le pasa la lista de DEs. La sesión de depuración a su vez pasa esta lista, junto con una función de devolución de llamada, para el proceso seleccionado y, a continuación, le pide el proceso para enumerar sus programas en ejecución.  
  
 Mediante programación, en respuesta a la solicitud del usuario, el paquete de depuración crea una instancia del Administrador de sesión de depuración (SDM) y le pasa la lista de DEs seleccionado. Junto con la lista, el paquete de depuración pasa el SDM un [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md) interfaz. El paquete de depuración pasa a la lista de DEs para el proceso seleccionado mediante una llamada a [IDebugProcess2::Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md). El SDM, a continuación, llama [IDebugProcess2::EnumPrograms](../../extensibility/debugger/reference/idebugprocess2-enumprograms.md) en el puerto para enumerar los programas que se ejecutan en el proceso.  
  
 Desde este punto, cada motor de depuración se adjunta a un programa exactamente como se detalla en [adjuntar después de iniciar un](../../extensibility/debugger/attaching-after-a-launch.md), con dos excepciones.  
  
 Para mejorar la eficacia, DEs que se implementan para compartir un espacio de direcciones con el SDM están agrupados para que cada Alemania tiene un conjunto de programas se asociará. En este caso, [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md) llamadas [IDebugEngine2::Attach](../../extensibility/debugger/reference/idebugengine2-attach.md) y pasa una matriz de programas para adjuntar a.  
  
 La segunda excepción es que los eventos de inicio enviados por una DE asociación a un programa que ya se está ejecutando no suele tener el evento de punto de entrada.  
  
## <a name="see-also"></a>Vea también  
 [Envío de eventos de inicio después de un lanzamiento](../../extensibility/debugger/sending-startup-events-after-a-launch.md)   
 [Tareas de depuración](../../extensibility/debugger/debugging-tasks.md)