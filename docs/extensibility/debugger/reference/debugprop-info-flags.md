---
title: DEBUGPROP_INFO_FLAGS | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: DEBUGPROP_INFO_FLAGS
helpviewer_keywords: DBGPROP_INFO_FLAGS enumeration
ms.assetid: 1c7fe777-615e-4929-9ed4-970d9fe0eb81
caps.latest.revision: "11"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 8e154f6e2ac9ef18632af875c13b00c63a283d59
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="debugpropinfoflags"></a>DEBUGPROP_INFO_FLAGS
Especifica qué información debe recuperar sobre un objeto de propiedad de depuración.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
enum enum_DEBUGPROP_INFO_FLAGS {   
   DEBUGPROP_INFO_FULLNAME          = 0x00000001,  
   DEBUGPROP_INFO_NAME              = 0x00000002,  
   DEBUGPROP_INFO_TYPE              = 0x00000004,  
   DEBUGPROP_INFO_VALUE             = 0x00000008,  
   DEBUGPROP_INFO_ATTRIB            = 0x00000010,  
   DEBUGPROP_INFO_PROP              = 0x00000020,  
   DEBUGPROP_INFO_VALUE_AUTOEXPAND  = 0x00010000,  
   DEBUGPROP_INFO_VALUE_NOFUNCEVAL  = 0x00020000,  
   DEBUGPROP_INFO_VALUE_RAW         = 0x00040000,  
   DEBUGPROP_INFO_VALUE_NO_TOSTRING = 0x00080000  
   DEBUGPROP_INFO_NONE              = 0x00000000,  
   DEBUGPROP_INFO_STANDARD          = DEBUGPROP_INFO_ATTRIB |  
                                      DEBUGPROP_INFO_NAME |  
                                      DEBUGPROP_INFO_TYPE |  
                                      DEBUGPROP_INFO_VALUE,  
   DEBUGPROP_INFO_ALL               = 0xffffffff  
};  
typedef DWORD DEBUGPROP_INFO_FLAGS;  
```  
  
```csharp  
public enum enum_DEBUGPROP_INFO_FLAGS {   
   DEBUGPROP_INFO_FULLNAME          = 0x00000001,  
   DEBUGPROP_INFO_NAME              = 0x00000002,  
   DEBUGPROP_INFO_TYPE              = 0x00000004,  
   DEBUGPROP_INFO_VALUE             = 0x00000008,  
   DEBUGPROP_INFO_ATTRIB            = 0x00000010,  
   DEBUGPROP_INFO_PROP              = 0x00000020,  
   DEBUGPROP_INFO_VALUE_AUTOEXPAND  = 0x00010000,  
   DEBUGPROP_INFO_VALUE_NOFUNCEVAL  = 0x00020000,  
   DEBUGPROP_INFO_VALUE_RAW         = 0x00040000,  
   DEBUGPROP_INFO_VALUE_NO_TOSTRING = 0x00080000  
   DEBUGPROP_INFO_NONE              = 0x00000000,  
   DEBUGPROP_INFO_STANDARD          = DEBUGPROP_INFO_ATTRIB |  
                                      DEBUGPROP_INFO_NAME |  
                                      DEBUGPROP_INFO_TYPE |  
                                      DEBUGPROP_INFO_VALUE,  
   DEBUGPROP_INFO_ALL               = 0xffffffff  
};  
```  
  
## <a name="members"></a>Miembros  
 DEBUGPROP_INFO_FULLNAME  
 Inicializar o utilizar el `bstrFullName` campo.  
  
 DEBUGPROP_INFO_NAME  
 Inicializar o utilizar el `bstrName` campo.  
  
 DEBUGPROP_INFO_TYPE  
 Inicializar o utilizar el `bstrType` campo.  
  
 DEBUGPROP_INFO_VALUE  
 Inicializar o utilizar el `bstrValue` campo.  
  
 DEBUGPROP_INFO_ATTRIB  
 Inicializar o utilizar el `dwAttrib` campo.  
  
 DEBUGPROP_INFO_PROP,  
 Inicializar o utilizar el `pProperty` campo que contenga un [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interfaz.  
  
 DEBUGPROP_INFO_VALUE_AUTOEXPAND  
 Especifica que el campo de valor debe contener el valor auto y ampliado, si está disponible para este tipo de objeto.  
  
 DEBUGPROP_INFO_VALUE_NOFUNCEVAL  
 Desusado.  
  
 DEBUGPROP_INFO_VALUE_RAW  
 No se devuelven los valores beautified o los miembros (es decir, no dan formato a los valores).  
  
 DEBUGPROP_INFO_VALUE_NO_TOSTRING  
 No devuelven ningún valor sintetizada especiales (por ejemplo, no llame a `ToString()` en un objeto para generar un valor).  
  
 DEBUGPROP_INFO_NONE  
 Especifica que no se establecen marcas.  
  
 DEBUGPROP_INFO_STANDARD  
 Inicializar o utilizar el `dwAttrib`, `bstrName`, `bstrType`, y `bstrValue` campos.  
  
 DEBUGPROP_INFO_All  
 Indica una máscara de todas las marcas.  
  
## <a name="remarks"></a>Comentarios  
 Estos valores se pasan a la [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md), [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md), y [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md) métodos para indicar qué campos se puede inicializar el [ DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) estructura.  
  
 Estos valores también se usan para la `dwFields` miembro de la `DEBUG_PROPERTY_INFO` estructura para indicar qué campos de la estructura se usan y válido cuando se devuelve la estructura.  
  
 Estos valores se pueden combinar con un bit a bit `OR`.  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Enumeraciones](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md)   
 [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)   
 [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md)   
 [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)