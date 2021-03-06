---
title: DEBUG_ADDRESS_UNION | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: DEBUG_ADDRESS_UNION
helpviewer_keywords: DEBUG_ADDRESS_UNION union
ms.assetid: e3d11aab-de0d-4109-b5dc-11e07e64382d
caps.latest.revision: "9"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: fc4e5c4bf075c69f4549e34185d407ba9fb95cd5
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="debugaddressunion"></a>DEBUG_ADDRESS_UNION
Describe los diferentes tipos de direcciones.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
typedef struct _tagDEBUG_ADDRESS_UNION {  
   ADDRESS_KIND dwKind;  
   union {  
      NATIVE_ADDRESS                  addrNative;  
      UNMANAGED_ADDRESS_THIS_RELATIVE addrThisRel;  
      UNMANAGED_ADDRESS_PHYSICAL      addrUPhysical;  
      METADATA_ADDRESS_METHOD         addrMethod;  
      METADATA_ADDRESS_FIELD          addrField;  
      METADATA_ADDRESS_LOCAL          addrLocal;  
      METADATA_ADDRESS_PARAM          addrParam;  
      METADATA_ADDRESS_ARRAYELEM      addrArrayElem;  
      METADATA_ADDRESS_RETVAL         addrRetVal;  
      DWORD                           unused;  
   } addr;  
} DEBUG_ADDRESS_UNION;  
```  
  
```csharp  
public struct DEBUG_ADDRESS_UNION {  
   public ADDRESS_KIND dwKind;  
   public IntPtr       unionmember;  
}  
```  
  
## <a name="terms"></a>Términos  
 dwKind  
 Un valor de la [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeración, que especifica cómo interpretar la unión.  
  
 addr.addrNative  
 [Solo en C++] Contiene el [NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md) estructura si `dwKind` = ADDRESS_KIND_NATIVE.  
  
 addr.addrThisRel  
 [Solo en C++] Contiene el[UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md) estructura si `dwKind` = ADDRESS_KIND_UNMANAGED_THIS_RELATIVE.  
  
 addr.addUPhysical  
 [Solo en C++] Contiene el[UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md) estructura si `dwKind` = ADDRESS_KIND_UNMANAGED_PHYSICAL.  
  
 addr.addrMethod  
 [Solo en C++] Contiene el[METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md) estructura si `dwKind` = ADDRESS_KIND_METHOD.  
  
 addr.addrField  
 [Solo en C++] Contiene el[METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md) estructura si `dwKind` = ADDRESS_KIND_FIELD.  
  
 addr.addrLocal  
 [Solo en C++] Contiene el[METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md) estructura si `dwKind` = ADDRESS_KIND_LOCAL.  
  
 addr.addrParam  
 [Solo en C++] Contiene el[METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md) estructura si `dwKind` = ADDRESS_KIND_PARAM.  
  
 addr.addrArrayElem  
 [Solo en C++] Contiene el[METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md) estructura si `dwKind` = ADDRESS_KIND_ARRAYELEM.  
  
 addr.addrRetVal  
 [Solo en C++] Contiene el[METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md) estructura si `dwKind` = ADDRESS_KIND_RETVAL.  
  
 addr.Unused  
 Relleno [C++ solo].  
  
 Addr  
 [Solo en C++] El nombre de la unión.  
  
 UnionMember  
 [Sólo en C#] Este valor es necesario que se van a calcular para el tipo de estructura adecuada según `dwKind`. Vea la sección Comentarios para la asociación entre `dwKind` y la interpretación de la unión.  
  
## <a name="remarks"></a>Comentarios  
 Esta estructura es parte de la [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) estructura y representa uno de una serie de diferentes tipos de direcciones (la `DEBUG_ADDRESS` estructura se rellena mediante una llamada a la [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md) método).  
  
 [Sólo en C#] En la tabla siguiente se muestra cómo interpretar la `unionmember` miembro para cada tipo de dirección. En el ejemplo se muestra cómo hacerlo para un tipo de dirección.  
  
|`dwKind`|`unionmember`interpreta como|  
|--------------|----------------------------------|  
|`ADDRESS_KIND_NATIVE`|[NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md)|  
|`ADDRESS_KIND_UNMANAGED_THIS_RELATIVE`|[UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md)|  
|`ADDRESS_KIND_UNMANAGED_PHYSICAL`|[UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md)|  
|`ADDRESS_KIND_METHOD`|[METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md)|  
|`ADDRESS_KIND_FIELD`|[METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md)|  
|`ADDRESS_KIND_LOCAL`|[METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md)|  
|`ADDRESS_KIND_PARAM`|[METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md)|  
|`ADDRESS_KIND_ARRAYELEM`|[METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md)|  
|`ADDRESS_KIND_RETVAL`|[METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md)|  
  
## <a name="example"></a>Ejemplo  
 Este ejemplo muestra cómo interpretar un tipo de dirección (`METADATA_ADDRESS_ARRAYELEM`) de la `DEBUG_ADDRESS_UNION` estructura en C#. Los elementos restantes se pueden interpretar de la misma forma.  
  
```csharp  
using System;  
using System.Runtime.Interop.Services;  
using Microsoft.VisualStudio.Debugger.Interop;  
  
namespace MyPackage  
{  
    public class MyClass  
    {  
        public void Interpret(DEBUG_ADDRESS_UNION dau)  
        {  
            if (dau.dwKind == (uint)enum_ADDRESS_KIND.ADDRESS_KIND_METADATA_ARRAYELEM)  
            {  
                 METADATA_ADDRESS_ARRAYELEM arrayElem =  
                     (METADATA_ADDRESS_ARRAYELEM)Marshal.PtrToStructure(dau.unionmember,  
                                 typeof(METADATA_ADDRESS_ARRAYELEM));  
            }  
        }  
    }  
}  
```  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Ensamblado: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## <a name="see-also"></a>Vea también  
 [Estructuras y uniones](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)   
 [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)   
 [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)