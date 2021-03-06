---
title: IDebugStackFrame2::GetPhysicalStackRange | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugStackFrame2::GetPhysicalStackRange
helpviewer_keywords: IDebugStackFrame2::GetPhysicalStackRange
ms.assetid: 2f6992e2-ac1c-433f-83b7-a7f83a4ce63d
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: e90137ada43a127dc3c7eac3c98620f3a846d024
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugstackframe2getphysicalstackrange"></a>IDebugStackFrame2::GetPhysicalStackRange
Obtiene una representación dependientes del equipo del intervalo de direcciones físicas asociado a un marco de pila.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT GetPhysicalStackRange (   
   UINT64* paddrMin,  
   UINT64* paddrMax  
);  
```  
  
```csharp  
int GetPhysicalStackRange (   
   out ulong paddrMin,  
   out ulong paddrMax  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `paddrMin`  
 [out] Devuelve la dirección física más bajo asociada con este marco de pila.  
  
 `paddrMax`  
 [out] Devuelve la dirección física mayor asociada con este marco de pila.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error.  
  
## <a name="remarks"></a>Comentarios  
 La información devuelta por este método es usar el Administrador de sesión de depuración (SDM) para ordenar los marcos de pila.  
  
 Se supone que la pila de llamadas crece hacia abajo, es decir, que se agregan nuevos marcos de pila en direcciones de memoria cada vez más inferiores. Una arquitectura en tiempo de ejecución debe proporcionar el intervalo de pila física que coincida con esta suposición.  
  
## <a name="see-also"></a>Vea también  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)