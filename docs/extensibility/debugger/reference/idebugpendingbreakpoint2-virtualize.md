---
title: IDebugPendingBreakpoint2::Virtualize | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugPendingBreakpoint2::Virtualize
helpviewer_keywords:
- Virtualize method
- IDebugPendingBreakpoint2::Virtualize method
ms.assetid: 58c8e9a5-4494-47c2-bddb-56f628da6a2d
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 98a4184813f424357dcc6fdecf87289351022dc0
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugpendingbreakpoint2virtualize"></a>IDebugPendingBreakpoint2::Virtualize
Alterna el estado de este virtualizado pendiente de punto de interrupción. Cuando un punto de interrupción pendiente está virtualizado, el motor de depuración intentará enlazarla cada vez que carga el nuevo código en el programa.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT Virtualize(   
   BOOL fVirtualize  
);  
```  
  
```cpp  
int Virtualize(   
   int fVirtualize  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `fVirtualize`  
 [in] Establecer a distinto de cero (`TRUE`) para virtualizar el punto de interrupción pendiente, o en cero (`FALSE`) para desactivar la virtualización.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error. Devuelve `E_BP_DELETED` si se ha eliminado el punto de interrupción.  
  
## <a name="remarks"></a>Comentarios  
 Un punto de interrupción virtualizado se enlaza cada vez que se carga el código.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra cómo implementar este método para un sencillo `CPendingBreakpoint` objeto que expone la [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) interfaz.  
  
```cpp  
HRESULT CPendingBreakpoint::Virtualize(BOOL fVirtualize)    
{    
   HRESULT hr;    
  
   // Verify that the pending breakpoint has not been deleted. If deleted,   
   // then return hr = E_BP_DELETED.    
   if (m_state.state != PBPS_DELETED)    
   {    
      if (fVirtualize)    
      {    
         // Set the PBPSF_VIRTUALIZED flag in the PENDING_BP_STATE_FLAGS   
         // structure.    
         SetFlag(m_state.flags, PBPSF_VIRTUALIZED);    
      }    
      else    
      {    
         // Clear the PBPSF_VIRTUALIZED flag in the PENDING_BP_STATE_FLAGS   
         // structure.    
         ClearFlag(m_state.flags, PBPSF_VIRTUALIZED);    
      }    
      hr = S_OK;    
   }    
   else    
   {    
      hr = E_BP_DELETED;    
   }    
  
   return hr;    
}    
```  
  
## <a name="see-also"></a>Vea también  
 [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)