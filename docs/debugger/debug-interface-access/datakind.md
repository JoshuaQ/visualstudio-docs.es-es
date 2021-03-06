---
title: DataKind | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs: C++
helpviewer_keywords: DataKind enumeration
ms.assetid: b64be708-22d6-4360-99e7-8f4e6b196de7
caps.latest.revision: "8"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 7fecbec475aee44efd9a91a24ec933dbbbcb17e9
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="datakind"></a>DataKind
Indica el ámbito determinado de un valor de datos.  
  
## <a name="syntax"></a>Sintaxis  
  
```C++  
enum DataKind {   
   DataIsUnknown,  
   DataIsLocal,  
   DataIsStaticLocal,  
   DataIsParam,  
   DataIsObjectPtr,  
   DataIsFileStatic,  
   DataIsGlobal,  
   DataIsMember,  
   DataIsStaticMember,  
   DataIsConstant  
};  
```  
  
## <a name="elements"></a>Elementos  
 DataIsUnknown  
 No se puede determinar el símbolo de datos.  
  
 DataIsLocal  
 Elemento de datos es una variable local.  
  
 DataIsStaticLocal  
 Elemento de datos es una variable local estática.  
  
 DataIsParam  
 Elemento de datos es un parámetro formal.  
  
 DataIsObjectPtr  
 Elemento de datos es un puntero de objeto (`this`).  
  
 DataIsFileStatic  
 Elemento de datos es una variable de ámbito de archivo.  
  
 DataIsGlobal  
 Elemento de datos es una variable global.  
  
 DataIsMember  
 Elemento de datos es una variable de miembro de objeto.  
  
 DataIsStaticMember  
 Elemento de datos es una variable estática de la clase.  
  
 DataIsConstant  
 Elemento de datos es un valor constante.  
  
## <a name="remarks"></a>Comentarios  
 Los valores de esta enumeración son devueltos por la [idiasymbol:: Get_datakind](../../debugger/debug-interface-access/idiasymbol-get-datakind.md) método.  
  
## <a name="requirements"></a>Requisitos  
 Encabezado: cvconst.h  
  
## <a name="see-also"></a>Vea también  
 [Enumeraciones y estructuras](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaSymbol::get_dataKind](../../debugger/debug-interface-access/idiasymbol-get-datakind.md)