---
title: IDebugDisassemblyStream2::GetCodeLocationId | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugDisassemblyStream2::GetCodeLocationId
helpviewer_keywords: IDebugDisassemblyStream2::GetCodeLocationId
ms.assetid: 567adfb8-2f54-499a-a027-e4ecb82277ef
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: b042a3a88ed1e64bf7093c0e1ce52da746186921
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugdisassemblystream2getcodelocationid"></a>IDebugDisassemblyStream2::GetCodeLocationId
Devuelve un identificador de ubicación de código para un contexto de código determinado.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT GetCodeLocationId(   
   IDebugCodeContext2* pCodeContext,  
   UINT64*             puCodeLocationId  
);  
```  
  
```csharp  
int GetCodeLocationId(   
   IDebugCodeContext2 pCodeContext,  
   out ulong          puCodeLocationId  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `pCodeContext`  
 [in] Un [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) objeto se convierta en un identificador.  
  
 `puCodeLocationId`  
 [out] Devuelve el identificador de ubicación del código. Vea la sección Comentarios.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error. Devuelve `E_CODE_CONTEXT_OUT_OF_SCOPE` si el contexto del código es válido, pero fuera del ámbito.  
  
## <a name="remarks"></a>Comentarios  
 El identificador de ubicación de código es específico para el motor de depuración (Alemania) admiten el desensamblado. Este identificador de ubicación se utiliza internamente por la DE para realizar el seguimiento de las posiciones en el código y suele ser una dirección o desplazamiento de algún tipo. El único requisito es que si el contexto del código de una ubicación es menor que el contexto del código de otra ubicación, el identificador de ubicación de código correspondiente de la primera contexto del código también debe ser menor que el identificador de ubicación de código de la segundo contexto del código.  
  
 Para recuperar el contexto del código de un identificador de ubicación del código, llame a la [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md) método.  
  
## <a name="see-also"></a>Vea también  
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md)