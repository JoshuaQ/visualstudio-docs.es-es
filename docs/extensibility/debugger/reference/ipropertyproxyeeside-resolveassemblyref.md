---
title: IPropertyProxyEESide::ResolveAssemblyRef | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: IPropertyProxyEESide::ResolveAssemblyRef
helpviewer_keywords: IPropertyProxyEESide::ResolveAssemblyRef
ms.assetid: 662ca0a6-dad0-4c00-a718-bb3bbc5bd9da
caps.latest.revision: "12"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: cffe6a2c94896a045a5d4ec06bf0dc62cd29cb91
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ipropertyproxyeesideresolveassemblyref"></a>IPropertyProxyEESide::ResolveAssemblyRef
Determina la ubicación de la referencia de ensamblado administrado especificado.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
HRESULT ResolveAssemblyRef(  
   BSTR*                  assemName,  
   IEEDataStorage**       assemBytes,  
   IEEDataStorage**       assemPdb,  
   BSTR*                  assemLocation,  
   ASSEMBLYLOCRESOLUTION* alr  
);  
```  
  
```csharp  
int ResolveAssemblyRef(  
   ref string                     assemName,  
   out IEEDataStorage             assemBytes,  
   out IEEDataStorage             assemPdb,  
   out string                     assemLocation,  
   out enum_ASSEMBLYLOCRESOLUTION alr  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `assemName`  
 [in] Nombre del ensamblado que se va a resolver.  
  
 `assemBytes`  
 [out] Devuelve un [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) que contiene los bytes de ensamblado asociados a la referencia de objeto.  
  
 `assemPdb`  
 [out] Devuelve un `IEEDataStorage` objeto que contiene el símbolo de almacena datos asociados a esta referencia.  
  
 `assemLocation`  
 [out] Devuelve la ubicación de ruta de acceso de esta referencia.  
  
 `alr`  
 [out] Devuelve un valor de la [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md) enumeración que indica la ubicación del ensamblado de la referencia.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error.  
  
## <a name="remarks"></a>Comentarios  
 Normalmente, este método no se implementa mediante un evaluador de expresiones personalizado.  
  
## <a name="see-also"></a>Vea también  
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)   
 [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md)