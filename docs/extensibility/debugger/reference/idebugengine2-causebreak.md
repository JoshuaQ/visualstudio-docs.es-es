---
title: IDebugEngine2::CauseBreak | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugEngine2::CauseBreak
helpviewer_keywords: IDebugEngine2::CauseBreak
ms.assetid: 17fe4698-b04e-4798-8412-80e0da60c387
caps.latest.revision: "8"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: c6fc6558ded5ab68f54170c07e2482ab2357475b
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugengine2causebreak"></a>IDebugEngine2::CauseBreak
Las solicitudes de todos los programas que se está depurando este motor de depuración (Alemania) para detener la ejecución de la próxima vez que uno de sus subprocesos intenta ejecutar.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT CauseBreak(   
   void   
);  
```  
  
```csharp  
int CauseBreak();  
```  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error.  
  
## <a name="remarks"></a>Comentarios  
 Este método es asincrónico: una [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) evento se envía cuando el programa siguiente intenta ejecutar después de que se llama a este método.  
  
## <a name="see-also"></a>Vea también  
 [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)   
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)