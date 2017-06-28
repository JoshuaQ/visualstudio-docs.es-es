---
title: "length (Propiedad, Float32Array) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: ae077c5f-e3a4-4815-928b-312cae6cff50
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
caps.handback.revision: 7
---
# length (Propiedad, Float32Array)
Longitud de la matriz.  
  
## Sintaxis  
  
```javascript  
var arrayLength = float32Array.length;  
```  
  
## Ejemplo  
 En el ejemplo siguiente se muestra cómo obtener la longitud de la matriz.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var floatArr = new Float32Array(buffer.byteLength / 4);  
            alert(floatArr.length);  
        }  
    }  
  
```  
  
## Requisitos  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]