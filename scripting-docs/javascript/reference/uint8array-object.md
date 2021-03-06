---
title: Objeto Uint8Array | Documentos de Microsoft
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
ms.assetid: ae78b3ee-b660-4625-ac7b-d414a0842c87
caps.latest.revision: "15"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.openlocfilehash: 72002af4ca92d1104a3c3c3bb2339e63856a80a6
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="uint8array-object"></a>Uint8Array (Objeto)
Matriz con tipo de valores enteros sin signo de 8 bits. El contenido se inicializa en 0. Si el número de bytes solicitado no se puede asignar, se produce una excepción.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
  
      uint8Array = new Uint8Array( length );  
uint8Array = new Uint8Array( array );  
uint8Array = new Uint8Array( buffer, byteOffset, length);  
```  
  
## <a name="parameters"></a>Parámetros  
 `uint8Array`  
 Obligatorio. El nombre de variable a la que el **Uint8Array** se asigna al objeto.  
  
 `length`  
 Especifica el número de elementos de la matriz.  
  
 `array`  
 Matriz (o matriz con tipo) incluida en esta matriz. El contenido se inicializa en el contenido de la matriz o matriz con tipo especificada; todos los elementos se convierten al tipo Uint8.  
  
 `buffer`  
 ArrayBuffer que el objeto Uint8Array representa.  
  
 `byteOffset`  
 Opcional. Especifica el desplazamiento en bytes desde el principio del búfer donde debe empezar el objeto Uint8Array.  
  
 `length`  
 Número de elementos de la matriz.  
  
## <a name="constants"></a>Constantes  
 En la tabla siguiente se muestran las constantes del objeto `Uint8Array`.  
  
|Constante|Descripción|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT (constante)](../../javascript/reference/bytes-per-element-constant-uint8array.md)|Tamaño en bytes de cada elemento de la matriz.|  
  
## <a name="properties"></a>Propiedades  
 En la tabla siguiente se muestran las constantes del objeto `Uint8Array`.  
  
|Propiedad|Descripción|  
|--------------|-----------------|  
|[búfer de propiedad](../../javascript/reference/buffer-property-uint8array.md)|Sólo lectura. Obtiene el ArrayBuffer al que hace referencia esta matriz.|  
|[Propiedad byteLength](../../javascript/reference/bytelength-property-uint8array.md)|Sólo lectura. Longitud de esta matriz desde el principio de su ArrayBuffer, en bytes, corregida en tiempo de construcción.|  
|[Propiedad byteOffset](../../javascript/reference/byteoffset-property-uint8array.md)|Sólo lectura. Desplazamiento de esta matriz desde el principio de su ArrayBuffer, en bytes, corregido en tiempo de construcción.|  
|[Propiedad Length](../../javascript/reference/length-property-uint8array.md)|Longitud de la matriz.|  
|||  
  
## <a name="methods"></a>Métodos  
 En la tabla siguiente se muestran los métodos del objeto `Uint8Array`.  
  
|Método|Descripción|  
|------------|-----------------|  
|[set (Método, Uint8Array)](../../javascript/reference/set-method-uint8array.md)|Establece un valor o una matriz de valores.|  
|[subarray (Método, Uint8Array)](../../javascript/reference/subarray-method-uint8array.md)|Obtiene una nueva vista de Uint8Array del almacén de ArrayBuffer para esta matriz.|  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra cómo usar un objeto Uint8Array para procesar los datos binarios adquiridos de un objeto XmlHttpRequest:  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Uint8Array(buffer.byteLength);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getUint8(i);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## <a name="requirements"></a>Requisitos  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]