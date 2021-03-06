---
title: IDebugEngine2 | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugEngine2
helpviewer_keywords: IDebugEngine2 interface
ms.assetid: 1f0e9ac0-6dfb-461a-976c-888d82144cdb
caps.latest.revision: "15"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 95a1a8c48bd6eab0f21ccc85a125b5d10f42ef4e
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugengine2"></a>IDebugEngine2
Esta interfaz representa un motor de depuración (Alemania). Se utiliza para administrar varios aspectos de una sesión de depuración, desde la creación de puntos de interrupción para establecer y borrar las excepciones.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
IDebugEngine2 : IUnknown  
```  
  
## <a name="notes-for-implementers"></a>Notas para los implementadores  
 Esta interfaz se implementa mediante un Alemania personalizado para administrar la depuración de programas. Esta interfaz se debe implementar en la DE.  
  
## <a name="notes-for-callers"></a>Notas para los llamadores  
 El Administrador de sesión de depuración (SDM) para administrar la sesión de depuración, incluidos administración de excepciones, crear puntos de interrupción y responder a eventos sincrónicos enviados por el DE llama a esta interfaz.  
  
## <a name="methods-in-vtable-order"></a>Métodos en orden de Vtable  
 La tabla siguiente muestran los métodos de `IDebugEngine2`.  
  
|Método|Descripción|  
|------------|-----------------|  
|[EnumPrograms](../../../extensibility/debugger/reference/idebugengine2-enumprograms.md)|Crea un enumerador para todos los programas que está siendo depurado por un Alemania.|  
|[Asociar](../../../extensibility/debugger/reference/idebugengine2-attach.md)|Asocia un Alemania a un programa.|  
|[CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md)|Crea un punto de interrupción pendiente en el DE.|  
|[SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md)|Especifica cómo el Alemania debe controlar una excepción determinada.|  
|[RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md)|Elimina la excepción especificada para que ya no se administran mediante el motor de depuración.|  
|[RemoveAllSetExceptions](../../../extensibility/debugger/reference/idebugengine2-removeallsetexceptions.md)|Quita la lista de excepciones que se estableció el IDE para una determinada arquitectura de tiempo de ejecución o un lenguaje.|  
|[GetEngineID](../../../extensibility/debugger/reference/idebugengine2-getengineid.md)|Obtiene el GUID de la DE.|  
|[DestroyProgram](../../../extensibility/debugger/reference/idebugengine2-destroyprogram.md)|Informa a DE que el programa especificado ha terminado atípicamente y que la DE debe limpiar todas las referencias al programa y enviar un programa destruir eventos.|  
|[ContinueFromSynchronousEvent](../../../extensibility/debugger/reference/idebugengine2-continuefromsynchronousevent.md)|Lo llama el SDM para indicar que un evento de depuración sincrónico, previamente enviado por el Alemania a SDM, se recibe y procesa.|  
|[SetLocale](../../../extensibility/debugger/reference/idebugengine2-setlocale.md)|Establece la configuración regional de la DE.|  
|[SetRegistryRoot](../../../extensibility/debugger/reference/idebugengine2-setregistryroot.md)|Establece la raíz del registro actualmente en uso por el DE.|  
|[SetMetric](../../../extensibility/debugger/reference/idebugengine2-setmetric.md)|Establece una métrica.|  
|[CauseBreak](../../../extensibility/debugger/reference/idebugengine2-causebreak.md)|Solicitudes que todos los programas que está siendo depurados por esta DE detener la ejecución la próxima vez que uno de sus subprocesos intenta ejecutar.|  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Evento](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)   
 [GetEngine](../../../extensibility/debugger/reference/idebugenginecreateevent2-getengine.md)