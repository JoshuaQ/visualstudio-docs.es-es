---
title: IEnumDebugPorts2 | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IEnumDebugPorts2
helpviewer_keywords: IEnumDebugPorts2
ms.assetid: 1754eef3-cf62-42e0-b218-1911acba77d4
caps.latest.revision: "12"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 277189c9b5510df1da4802e42225ffafa4b6995c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ienumdebugports2"></a>IEnumDebugPorts2
Esta interfaz enumera los puertos de un proveedor de equipos o el puerto.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
IEnumDebugPorts2 : IUnknown  
```  
  
## <a name="notes-for-implementers"></a>Notas para los implementadores  
 Un proveedor de puerto personalizado implementa esta interfaz para representar una lista de los puertos creados por el proveedor. Visual Studio implementa esta interfaz para admitir su propio proveedor del puerto.  
  
## <a name="notes-for-callers"></a>Notas para los llamadores  
 Llame a [EnumPorts](../../../extensibility/debugger/reference/idebugportsupplier2-enumports.md) para obtener esta interfaz que representa una lista de los puertos creados por el proveedor del puerto. Llame a [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md) para obtener esta interfaz que representa una lista de puertos que se guardaron en el disco.  
  
## <a name="methods-in-vtable-order"></a>Métodos en orden de Vtable  
 La tabla siguiente muestran los métodos de `IEnumDebugPorts2`.  
  
|Método|Descripción|  
|------------|-----------------|  
|[Siguiente](../../../extensibility/debugger/reference/ienumdebugports2-next.md)|Recupera un número especificado de puertos en una secuencia de enumeración.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugports2-skip.md)|Omite un número especificado de puertos en una secuencia de enumeración.|  
|[Restablecer](../../../extensibility/debugger/reference/ienumdebugports2-reset.md)|Restablece una secuencia de enumeración al principio.|  
|[Clon](../../../extensibility/debugger/reference/ienumdebugports2-clone.md)|Crea un enumerador que contiene el mismo estado de enumeración que el enumerador actual.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugports2-getcount.md)|Obtiene el número de puertos de un enumerador.|  
  
## <a name="remarks"></a>Comentarios  
 Visual Studio usa esta interfaz para ayudar a rellenar una lista de puertos utilizados para adjuntar a procesos.  
  
 Normalmente, un motor de depuración no usa esta interfaz.  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Interfaces de núcleo](../../../extensibility/debugger/reference/core-interfaces.md)   
 [EnumPorts](../../../extensibility/debugger/reference/idebugcoreserver2-enumports.md)   
 [EnumPorts](../../../extensibility/debugger/reference/idebugportsupplier2-enumports.md)