---
title: IDebugPortSupplier2::CanAddPort | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugPortSupplier2::CanAddPort
helpviewer_keywords: IDebugPortSupplier2::CanAddPort
ms.assetid: 41f69e0a-e82c-473d-8b7a-0c40fc5730fc
caps.latest.revision: "8"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 6b493229ab33f628c54580711604b16a4e2b5c5b
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugportsupplier2canaddport"></a>IDebugPortSupplier2::CanAddPort
Comprueba que un proveedor de puerto puede agregar nuevos puertos.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT CanAddPort(   
   void   
);  
```  
  
```csharp  
int CanAddPort();  
```  
  
## <a name="return-value"></a>Valor devuelto  
 Si se puede agregar el puerto, devuelve `S_OK`; en caso contrario, devuelve `S_FALSE` para indicar que no hay puertos pueden agregarse a este proveedor del puerto.  
  
## <a name="remarks"></a>Comentarios  
 Llamar a este método antes de llamar a la [agregar puerto](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md) método debido a que el último método crea el puerto así como agregar, que podría ser una operación que consume mucho tiempo.  
  
## <a name="see-also"></a>Vea también  
 [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)   
 [Agregar puerto](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)