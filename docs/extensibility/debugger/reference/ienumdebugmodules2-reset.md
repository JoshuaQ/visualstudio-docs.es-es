---
title: "IEnumDebugModules2::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugModules2::Reset"
helpviewer_keywords: 
  - "IEnumDebugModules2::Reset"
ms.assetid: f6ff364c-2644-4919-b950-3cb82eb6f601
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
caps.handback.revision: 9
---
# IEnumDebugModules2::Reset
[!INCLUDE[vs2017banner](../../../code-quality/includes/vs2017banner.md)]

Restablece la enumeración en el primer elemento.  
  
## Sintaxis  
  
```cpp#  
HRESULT Reset(  
   void  
);  
```  
  
```c#  
int Reset();  
```  
  
## Valor devuelto  
 Si finaliza correctamente, devuelve `S_OK`; de lo contrario, devuelve un código de error.  
  
## Comentarios  
 Después de que se llame a este método, la siguiente llamada al método de [Siguiente](../../../extensibility/debugger/reference/ienumdebugmodules2-next.md) devuelve el primer elemento de la enumeración.  
  
## Vea también  
 [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)