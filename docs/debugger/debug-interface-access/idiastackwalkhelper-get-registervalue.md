---
title: IDiaStackWalkHelper::get_registerValue | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs: C++
helpviewer_keywords: IDiaStackWalkHelper2::get_registerValue method
ms.assetid: 46ac5eee-73a3-44a1-8635-6c58ba193cb6
caps.latest.revision: "9"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: dac8991fa31aae0ba65b0377e159b20256c4a416
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idiastackwalkhelpergetregistervalue"></a>IDiaStackWalkHelper::get_registerValue
Recupera el valor de un registro.  
  
## <a name="syntax"></a>Sintaxis  
  
```C++  
HRESULT get_registerValue (   
   DWORD      index,  
   ULONGLONG* pRetVal  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `index`  
 [in] Un valor de la [CV_HREG_e (enumeración)](../../debugger/debug-interface-access/cv-hreg-e.md) enumeración especifica que registrarse para obtener el valor de.  
  
 `pRetVal`  
 [out] Devuelve el valor actual del registro.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error.  
  
## <a name="remarks"></a>Comentarios  
 A pesar de que el tamaño de la `pRetVal` parámetro, debe almacenar una implementación sólo de lo que contiene normalmente el registro. Por ejemplo, un registro de 8 bits contiene solo los 8-bits inferiores del valor especificado. Este valor de 8 bits se expande a 64 bits cuando se devuelve desde este método.  
  
## <a name="see-also"></a>Vea también  
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)   
 [CV_HREG_e (enumeración)](../../debugger/debug-interface-access/cv-hreg-e.md)