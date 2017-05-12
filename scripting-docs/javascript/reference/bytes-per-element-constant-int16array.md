---
title: "BYTES_PER_ELEMENT (Constante, Int16Array) | Microsoft Docs"
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
ms.assetid: b1359cc3-a456-493f-be34-f797dab8ede4
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
caps.handback.revision: 7
---
# BYTES_PER_ELEMENT (Constante, Int16Array)
Tamaño en bytes de cada elemento de la matriz.  
  
## Sintaxis  
  
```javascript  
var arraySize = int8Array.BYTES_PER_ELEMENT;  
```  
  
## Ejemplo  
 En el ejemplo siguiente se muestra cómo obtener el tamaño de los elementos de la matriz.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Int16Array(buffer.byteLength / 2);  
            alert(intArr.BYTES_PER_ELEMENT);  
        }  
    }  
  
```  
  
## Requisitos  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]