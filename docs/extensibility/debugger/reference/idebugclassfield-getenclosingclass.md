---
title: IDebugClassField::GetEnclosingClass | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IDebugClassField::GetEnclosingClass
helpviewer_keywords: IDebugClassField::GetEnclosingClass method
ms.assetid: a0c12e3c-9ea0-4dfb-9e45-8cea18725022
caps.latest.revision: "9"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 440b9845ae7f3dd57b34b4ce25f48bea3aaa7e80
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idebugclassfieldgetenclosingclass"></a>IDebugClassField::GetEnclosingClass
Obtiene la clase que contiene esta clase.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT GetEnclosingClass(   
   IDebugClassField** ppClassField  
);  
```  
  
```csharp  
int GetEnclosingClass(  
   out IDebugClassField ppClassField  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `ppClassField`  
 [out] Devuelve un [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) clase de objeto que representa el envolvente. Devuelve un valor null si no hay ninguna clase envolvente.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve S_OK; en caso contrario, devuelve un código de error.  
  
## <a name="remarks"></a>Comentarios  
 Si la clase representada por este [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) objeto es una clase anidada, la `ppClassField` parámetro devuelve un `IDebugClassField` clase de objeto que representa el envolvente. Por ejemplo, dada esta definición de clase:  
  
```  
class RootClass {  
   class NestedClass { }  
};  
```  
  
 Llamar a la `GetEnclosingClass` método en el `IDebugClassField` objeto que representa el `NestedClass` clase devuelve una `IDebugClassField` objeto que representa la clase `RootClass`.  
  
## <a name="see-also"></a>Vea también  
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)