---
title: BPREQI_FIELDS | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: BPREQI_FIELDS
helpviewer_keywords: BPREQI_FIELDS enumeration
ms.assetid: 679e771e-4a79-484e-af37-f962ef4aa245
caps.latest.revision: "14"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 1e7c0206ca5834b281447e9a00c4ce3cad0c247c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="bpreqifields"></a>BPREQI_FIELDS
Especifica la información que se va a recuperar sobre una solicitud de punto de interrupción.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
enum enum_BPREQI_FIELDS {   
   BPREQI_BPLOCATION   = 0x0001,  
   BPREQI_LANGUAGE     = 0x0002,  
   BPREQI_PROGRAM      = 0x0004,  
   BPREQI_PROGRAMNAME  = 0x0008,  
   BPREQI_THREAD       = 0x0010,  
   BPREQI_THREADNAME   = 0x0020,  
   BPREQI_PASSCOUNT    = 0x0040,  
   BPREQI_CONDITION    = 0x0080,  
   BPREQI_FLAGS        = 0x0100,  
   BPREQI_ALLOLDFIELDS = 0x01ff  
   BPREQI_VENDOR       = 0x0200,   // BP_REQUEST_INFO2 only  
   BPREQI_CONSTRAINT   = 0x0400,   // BP_REQUEST_INFO2 only  
   BPREQI_TRACEPOINT   = 0x0800,   // BP_REQUEST_INFO2 only  
   BPREQI_ALLFIELDS    = 0x0fff    // BP_REQUEST_INFO2 only  
};  
typedef DWORD BPREQI_FIELDS;  
```  
  
```csharp  
public enum enum_BPREQI_FIELDS {   
   BPREQI_BPLOCATION   = 0x0001,  
   BPREQI_LANGUAGE     = 0x0002,  
   BPREQI_PROGRAM      = 0x0004,  
   BPREQI_PROGRAMNAME  = 0x0008,  
   BPREQI_THREAD       = 0x0010,  
   BPREQI_THREADNAME   = 0x0020,  
   BPREQI_PASSCOUNT    = 0x0040,  
   BPREQI_CONDITION    = 0x0080,  
   BPREQI_FLAGS        = 0x0100,  
   BPREQI_ALLOLDFIELDS = 0x01ff  
   BPREQI_VENDOR       = 0x0200,   // BP_REQUEST_INFO2 only  
   BPREQI_CONSTRAINT   = 0x0400,   // BP_REQUEST_INFO2 only  
   BPREQI_TRACEPOINT   = 0x0800,   // BP_REQUEST_INFO2 only  
   BPREQI_ALLFIELDS    = 0x0fff    // BP_REQUEST_INFO2 only  
};  
```  
  
## <a name="members"></a>Miembros  
 BPREQI_BPLOCATION  
 Inicializar o utilizar el `bpLocation` campo (ubicación de punto de interrupción) de la [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) o [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) estructura.  
  
 BPREQI_LANGUAGE  
 Inicializar o utilizar el `guidLanguage` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_PROGRAM  
 Inicializar o utilizar el `pProgram` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_PROGRAMNAME  
 Inicializar o utilizar el `bstrProgramName` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_THREAD  
 Inicializar o utilizar el `pThread` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_THREADNAME  
 Inicializar o utilizar el `bstrThreadName` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_PASSCOUNT  
 Inicializar o utilizar el `bpPassCount` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_CONDITION  
 Inicializar o utilizar el `bpCondition` campo (condición de punto de interrupción) de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_FLAGS  
 Inicializar o utilizar el `dwFlags` campo de la `BP_REQUEST_INFO` o `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_ALLOLDFIELDS  
 Inicializar o utilizar todos los campos de la de la `BP_REQUEST_INFO` estructura.  
  
 BPREQI_VENDOR  
 Inicializar o utilizar el `guidVendor` campo `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_CONSTRAINT  
 Inicializar o utilizar el `bstrConstraint` campo `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_TRACEPOINT  
 Inicializar o utilizar el `bstrTracepoint` campo `BP_REQUEST_INFO2` estructura.  
  
 BPREQI_ALLFIELDS  
 Especifica todos los campos de la `BP_REQUEST_INFO2` estructura.  
  
## <a name="remarks"></a>Comentarios  
 Pasa como un argumento a la [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md) y [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) métodos para especificar qué campos de la [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) y [BP_REQUEST_INFO2 ](../../../extensibility/debugger/reference/bp-request-info2.md) estructuras son se inicialice.  
  
 Estas marcas también se utilizan para indicar qué campos de la `BP_REQUEST_INFO` y `BP_REQUEST_INFO2` estructuras se utilizan y válido cuando se devuelve cada estructura.  
  
 Estos valores se pueden combinar con un bit a bit `OR`.  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Enumeraciones](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md)   
 [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)   
 [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)