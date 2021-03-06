---
title: Adjuntar y separar a un programa | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- debug engines, attaching to programs
- debug engines, detaching from programs
ms.assetid: 79dcbb9b-c7f8-40fc-8a00-f37fe1934f51
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: a5b0783cd011c91b9592479c7b64c6cb6a1afaa1
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="attaching-and-detaching-to-a-program"></a>Adjuntar y separar a un programa
Para asociar al depurador requiere el envío de la secuencia correcta de métodos y eventos con los atributos adecuados.  
  
## <a name="sequence-of-methods-and-events"></a>Secuencia de métodos y eventos  
  
1.  El Administrador de sesión de depuración (SDM) llama el [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) método.  
  
     Según el modelo de proceso del motor DE depuración, el `IDebugProgramNodeAttach2::OnAttach` método devuelve uno de los métodos siguientes, que determina qué ocurre después.  
  
     Si `S_FALSE` se devuelve, el motor de depuración se ha adjuntado correctamente al programa. En caso contrario, el [adjuntar](../../extensibility/debugger/reference/idebugengine2-attach.md) método se llama para completar el proceso de conexión.  
  
     Si `S_OK` se devuelve, es la DE que se cargará en el mismo proceso que el SDM. El SDM realiza las tareas siguientes:  
  
    1.  Llamadas [GetEngineInfo](../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md) para obtener la información de motor de la DE.  
  
    2.  Participa en la DE la creación.  
  
    3.  Llamadas [adjuntar](../../extensibility/debugger/reference/idebugengine2-attach.md).  
  
2.  Los envíos DE un [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) para el SDM con un `EVENT_SYNC` atributo.  
  
3.  Los envíos DE un [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) para el SDM con un `EVENT_SYNC` atributo.  
  
4.  Los envíos DE un [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) para el SDM con un `EVENT_SYNC_STOP` atributo.  
  
 Cuando se desasocia un programa es un sencillo proceso de dos pasos, como se indica a continuación:  
  
1.  Las llamadas SDM [separar](../../extensibility/debugger/reference/idebugprogram2-detach.md).  
  
2.  Los envíos DE un [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md).  
  
## <a name="see-also"></a>Vea también  
 [Llamada a eventos del depurador](../../extensibility/debugger/calling-debugger-events.md)