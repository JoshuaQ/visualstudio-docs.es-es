---
title: byteOffset (Int8Array) de la propiedad | Documentos de Microsoft
ms.custom: 
ms.date: 01/18/2017
ms.prod: windows-client-threshold
ms.reviewer: 
ms.suite: 
ms.technology: devlang-javascript
ms.tgt_pltfrm: 
ms.topic: language-reference
dev_langs:
- JavaScript
- TypeScript
- DHTML
ms.assetid: b155bf97-d567-4921-8edd-dbca0d84b6cf
caps.latest.revision: "7"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.openlocfilehash: 66ef19bafd3f33461ce1f632e735400e8acf10c6
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="byteoffset-property-int8array"></a>byteOffset (Propiedad, Int8Array)
Sólo lectura. Desplazamiento de esta matriz desde el principio de su ArrayBuffer, en bytes, corregido en tiempo de construcción.  
  
## <a name="syntax"></a>Sintaxis  
  
```JavaScript  
var arrayOffset = int8Array.byteOffset;  
```  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra cómo obtener el desplazamiento de la matriz.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Int8Array(buffer.byteLength);  
            alert(intArr.byteOffset);  
        }  
    }  
  
```  
  
## <a name="requirements"></a>Requisitos  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]