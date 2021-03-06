---
title: "Evaluación de la pila de llamadas | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], call stack evaluation
- call stacks, evaluation
ms.assetid: 373d6b49-0459-4cce-816e-05745a44fe49
caps.latest.revision: "8"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: fddbe370362eb30dd9560e51574847d808c126fd
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="call-stack-evaluation"></a>Evaluación de la pila de llamadas
Para ver los marcos de pila de la pila de llamadas durante el modo de interrupción, debe implementar la [EnumFrameInfo](../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) método.  
  
## <a name="methods-for-evaluation"></a>Métodos para la evaluación  
 Un motor de depuración simple (Alemania), puede haber solo un marco de pila. Para examinar el marco de pila durante el modo de interrupción, debe implementar los métodos siguientes de [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md).  
  
|Método|Descripción|  
|------------|-----------------|  
|[GetCodeContext](../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md)|Obtiene el contexto del código para un marco de pila. El contexto del código representa el puntero de instrucción actual en un marco de pila.|  
|[GetDocumentContext](../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md)|Obtiene el contexto del documento para un marco de pila. El contexto del documento representa la ubicación actual en el código fuente de un marco de pila. Es necesario para ver el código fuente cuando se detiene en un programa.|  
  
 Estos métodos requieren la implementación de varias interfaces relacionadas con el contexto y métodos. Por lo tanto, debe implementar la [GetDocumentContext](../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md) método y los métodos siguientes de [IDebugDocumentContext2](../../extensibility/debugger/reference/idebugdocumentcontext2.md).  
  
|Método|Descripción|  
|------------|-----------------|  
|[GetStatementRange](../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md)|Obtiene el intervalo de la instrucción de archivo de un contexto de documento.|  
  
 Para enumerar los contextos de código, debe implementar todos los métodos de [IEnumDebugCodeContexts2](../../extensibility/debugger/reference/ienumdebugcodecontexts2.md).  
  
## <a name="see-also"></a>Vea también  
 [Control de ejecución y evaluación de estado](../../extensibility/debugger/execution-control-and-state-evaluation.md)