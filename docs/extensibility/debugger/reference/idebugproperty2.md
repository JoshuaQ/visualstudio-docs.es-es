---
title: IDebugProperty2 | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugProperty2
helpviewer_keywords: IDebugProperty2 interface
ms.assetid: a7d5c70f-a1a5-4120-9f70-184e01c25bff
caps.latest.revision: "11"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 8dc1305fb8534dc8e14192268913290aef25f2cc
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugproperty2"></a>IDebugProperty2
Esta interfaz representa una propiedad de marco de pila, una propiedad de documento de programa o alguna otra propiedad. La propiedad suele ser el resultado de evaluación de una expresión.  
  
> [!NOTE]
>  Este uso de "propiedad" no debe confundirse con la que lo que significa que una variable de miembro de una clase, aunque un `IDebugProperty2` puede representar dicha entidad.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
IDebugProperty2 : IUnknown  
```  
  
## <a name="notes-for-implementers"></a>Notas para los implementadores  
 La DE implementa esta interfaz para representar un determinado tipo de valor. Por ejemplo, el valor puede ser un valor numérico como resultado de una evaluación de expresión, un contexto de memoria que se utiliza para mostrar la memoria o una lista de registros y sus valores.  
  
## <a name="notes-for-callers"></a>Notas para los llamadores  
 Llame a [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) o [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) para obtener esta interfaz, que representa el resultado de una evaluación. `IDebugExpression2::EvaluateAsync`devuelve esta interfaz mediante el envío de un [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) interfaz para el SDM, que a su vez llama [GetResult](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getresult.md) para recuperar la propiedad.  
  
 [GetDebugProperty](../../../extensibility/debugger/reference/idebugpropertycreateevent2-getdebugproperty.md) devuelve esta interfaz para proporcionar el documento de script asociado.  
  
 [GetReturnValue](../../../extensibility/debugger/reference/idebugreturnvalueevent2-getreturnvalue.md) devuelve esta interfaz para representar el valor devuelto de una función.  
  
 [GetDebugProperty](../../../extensibility/debugger/reference/idebugprogram2-getdebugproperty.md) devuelve esta interfaz para representar varias propiedades del programa como un nombre o un contexto de la memoria.  
  
 [GetDebugProperty](../../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md) devuelve esta interfaz para representar varias propiedades del marco de pila como variables locales.  
  
## <a name="methods-in-vtable-order"></a>Métodos en orden de Vtable  
 La tabla siguiente muestran los métodos de `IDebugProperty2`.  
  
|Método|Descripción|  
|------------|-----------------|  
|[GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md)|Rellena un [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) estructura que describe una propiedad.|  
|[SetValueAsString](../../../extensibility/debugger/reference/idebugproperty2-setvalueasstring.md)|Establece el valor de una propiedad de una cadena.|  
|[SetValueAsReference](../../../extensibility/debugger/reference/idebugproperty2-setvalueasreference.md)|Establece el valor de la propiedad del valor de una determinada referencia.|  
|[EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)|Enumera a los elementos secundarios de una propiedad.|  
|[GetParent](../../../extensibility/debugger/reference/idebugproperty2-getparent.md)|Devuelve al elemento primario de una propiedad.|  
|[GetDerivedMostProperty](../../../extensibility/debugger/reference/idebugproperty2-getderivedmostproperty.md)|Devuelve la propiedad que describe la propiedad más derivado de una propiedad.|  
|[GetMemoryBytes](../../../extensibility/debugger/reference/idebugproperty2-getmemorybytes.md)|Devuelve los bytes de memoria que componen el valor de una propiedad.|  
|[GetMemoryContext](../../../extensibility/debugger/reference/idebugproperty2-getmemorycontext.md)|Devuelve el contexto de la memoria para un valor de propiedad.|  
|[GetSize](../../../extensibility/debugger/reference/idebugproperty2-getsize.md)|Devuelve el tamaño, en bytes, del valor de propiedad.|  
|[GetReference](../../../extensibility/debugger/reference/idebugproperty2-getreference.md)|Devuelve una referencia al valor de esta propiedad.|  
|[GetExtendedInfo](../../../extensibility/debugger/reference/idebugproperty2-getextendedinfo.md)|Devuelve la información extendida de una propiedad.|  
  
## <a name="remarks"></a>Comentarios  
 Una propiedad, como se representa mediante un `IDebugProperty2` de la interfaz, puede considerarse como un valor con un nombre, un tipo y una dirección. En términos más generales, un `IDebugProperty2` puede representar cualquier cosa que tiene una estructura jerárquica, con nodos secundarios y elementos primarios.  
  
 Una propiedad es normalmente transitoria, solo que duran como el marco de pila actual, por ejemplo. Por otro lado, una referencia, tal como está representado por un [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) interfaz dura siempre y cuando el valor permanece en memoria.  
  
 Puede usar el IDE de la `IDebugProperty2` interfaz para que los usuarios puedan examinar y modificar las propiedades en tiempo de ejecución.  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Interfaces de núcleo](../../../extensibility/debugger/reference/core-interfaces.md)   
 [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)   
 [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)