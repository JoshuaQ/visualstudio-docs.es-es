---
title: "IEnumDebugPorts2::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugPorts2::Reset"
helpviewer_keywords: 
  - "IEnumDebugPorts2::Reset"
ms.assetid: 67da406c-eadb-421e-ae12-e26e9866f262
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
caps.handback.revision: 9
---
# IEnumDebugPorts2::Reset
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
 Después de que se llame a este método, la siguiente llamada al método de [Siguiente](../../../extensibility/debugger/reference/ienumdebugports2-next.md) devuelve el primer elemento de la enumeración.  
  
## Vea también  
 [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)