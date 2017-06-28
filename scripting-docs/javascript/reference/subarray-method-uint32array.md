---
title: "subarray (M&#233;todo, Uint32Array) | Microsoft Docs"
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
ms.assetid: 4c183208-12ec-4051-bf0f-a4f7c112cea1
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
caps.handback.revision: 13
---
# subarray (M&#233;todo, Uint32Array)
Obtiene una nueva vista Uint32Array del almacén de [ArrayBuffer \(Objeto\)](../../javascript/reference/arraybuffer-object.md) para esta matriz, especificando los primeros y últimos miembros de la submatriz.  
  
## Sintaxis  
  
```javascript  
var newUint32Array = uint32Array.subarray(begin, end);  
```  
  
## Parámetros  
 `newUint32Array`  
 Submatriz que devuelve este método.  
  
 `begin`  
 Índice del principio de la matriz.  
  
 `end`  
 Índice del final de la matriz,  sin incluir.  
  
## Comentarios  
 Si el valor `begin` o `end` es negativo, hace referencia a un índice contando desde el final de la matriz, no desde el principio.  Si `end` no se especifica, la submatriz contiene todos los elementos desde `begin` hasta el final de la matriz con tipo.  El intervalo especificado por los valores `begin` y `end` se fija en el intervalo de índices válido para la matriz actual.  Si la longitud calculada de la nueva matriz con tipo fuera negativa, se fija en cero.  La matriz devuelta será del mismo tipo que la matriz en la que se invoca este método.  
  
## Ejemplo  
 En el ejemplo siguiente se muestra cómo obtener una submatriz de dos elementos, empezando por el primer elemento de la matriz.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var intArr = new Uint32Array(buffer.byteLength / 4);  
            var subArr = intArr.subarray(0, 2);  
        }  
    }  
  
```  
  
## Requisitos  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]