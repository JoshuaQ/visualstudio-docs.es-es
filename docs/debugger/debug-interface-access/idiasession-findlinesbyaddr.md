---
title: 'Idiasession:: Findlinesbyaddr | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs: C++
helpviewer_keywords: IDiaSession::findLinesByAddr method
ms.assetid: 640403c0-14cf-403c-ad19-38b3bdc28ca8
caps.latest.revision: "8"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: e7a8fd6b98f6c92eb90c253917be2374c3195b9f
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="idiasessionfindlinesbyaddr"></a>IDiaSession::findLinesByAddr
Recupera las líneas en una operación de compilación especificado que contienen una dirección especificada.  
  
## <a name="syntax"></a>Sintaxis  
  
```C++  
HRESULT findLinesByAddr (   
   DWORD                 seg,  
   DWORD                 offset,  
   DWORD                 length,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 `seg`  
 [in] Especifica el componente de la sección de la dirección específica.  
  
 `offset`  
 [in] Especifica el componente de desplazamiento de la dirección específica.  
  
 `length`  
 [in] Especifica el número de bytes del intervalo de direcciones para cubrir con esta consulta.  
  
 `ppResult`  
 [out] Devuelve un [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) objeto que contiene una lista de la línea de todos los números que cubren el intervalo de direcciones especificado.  
  
## <a name="return-value"></a>Valor devuelto  
 Si se realiza correctamente, devuelve `S_OK`; en caso contrario, devuelve un código de error.  
  
## <a name="example"></a>Ejemplo  
 En este ejemplo se muestra una función que obtiene todos los números de línea contenidos en una función utilizando la dirección y la longitud de la función.  
  
```C++  
IDiaEnumLineNumbers* GetLineNumbersByAddr(IDiaSymbol *pFunc,  
                                          IDiaSession *pSession)  
{  
    IDiaEnumLineNumbers* pEnum = NULL;  
    DWORD                seg;  
    DWORD                offset;  
    ULONGLONG            length;  
  
    if (pFunc->get_addressSection ( &seg ) == S_OK &&  
        pFunc->get_addressOffset ( &offset ) == S_OK)  
    {  
        pFunc->get_length ( &length );  
        pSession->findLinesByAddr( seg, offset, static_cast<DWORD>( length ), &pEnum );  
    }  
    return(pEnum);  
}  
```  
  
## <a name="see-also"></a>Vea también  
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)   
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaSession::findLinesByVA](../../debugger/debug-interface-access/idiasession-findlinesbyva.md)