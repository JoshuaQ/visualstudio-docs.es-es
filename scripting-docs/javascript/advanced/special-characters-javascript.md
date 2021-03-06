---
title: Caracteres especiales (JavaScript) | Microsoft Docs
ms.custom: 
ms.date: 01/18/2017
ms.prod: windows-client-threshold
ms.reviewer: 
ms.suite: 
ms.technology: devlang-javascript
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- JavaScript
- TypeScript
- DHTML
helpviewer_keywords:
- line terminator character
- white space character
- Unicode character
- escape sequence
- backslash (\)
ms.assetid: 3b38b1bd-1f0f-4748-b13e-55cab36fd126
caps.latest.revision: "31"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.openlocfilehash: 0eaae8dfc84d9a3be6db54c50558d4cf675a53a8
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="special-characters-javascript"></a>Caracteres especiales (JavaScript)
[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] proporciona secuencias de escape que se pueden incluir en cadenas para crear caracteres que no es posible escribir directamente.  
  
## <a name="remarks"></a>Comentarios  
 Un valor de cadena es una serie de cero o más caracteres Unicode (letras, dígitos y otros caracteres). Los literales de cadena se incluyen entre pares de comillas simples o dobles. Una cadena incluida entre comillas simples puede contener comillas dobles. Una cadena incluida entre comillas dobles puede contener comillas simples.  
  
 Cada carácter de un literal de cadena puede representarse mediante una secuencia de escape. Una secuencia de escape comienza con una barra diagonal inversa (\\) que informa al intérprete [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] de que el siguiente carácter es un carácter especial.  
  
 Puede especificar un carácter Unicode usando la secuencia de escape \u*hhhh*, donde *hhhh* es un número hexadecimal de cuatro dígitos. Una secuencia de escape Unicode puede representar cualquier carácter de 16 bits. Para más información, consulte [Secuencias de escape de punto de código Unicode](#CodePoint).  
  
 Puede usar una secuencia de escape de un solo carácter para algunos caracteres. Por ejemplo, \t especifica un carácter de tabulación.  
  
## <a name="escape-sequences"></a>Secuencias de escape  
 En la tabla siguiente se enumeran algunos ejemplos de secuencias de escape para caracteres comunes.  
  
|Valor de carácter Unicode|Secuencia de escape|Significado|Categoría|  
|-----------------------------|---------------------|-------------|--------------|  
|\u0008|\b|Retroceso||  
|\u0009|\t|Tab|Espacio en blanco|  
|\u000A|\n|Avance de línea (nueva línea)|Terminador de línea|  
|\u000B|\v<br /><br /> (Consulte la nota que sigue a esta tabla).|Tabulación vertical|Espacio en blanco|  
|\u000C|\f|Avance de página|Espacio en blanco|  
|\u000D|\r|Retorno de carro|Terminador de línea|  
|\u0020||Espacio|Espacio en blanco|  
|\u0022|\\"|Comillas dobles (")||  
|\u0027|\\'|Comilla simple (')||  
|\u005C|\\\|Barra diagonal inversa (\\)||  
|\u00A0||Espacio de no separación|Espacio en blanco|  
|\u2028||Separador de línea|Terminador de línea|  
|\u2029||Separador de párrafo|Terminador de línea|  
|\uFEFF||Marca de orden de bytes|Espacio en blanco|  
  
 La columna Categoría especifica si el carácter es un carácter de espacio en blanco o de terminador de línea. El método [trim (cadena)](../../javascript/reference/trim-method-string-javascript.md) quita los espacios en blanco iniciales y finales y los caracteres de terminador de línea de una cadena.  
  
 La barra diagonal inversa se usa como carácter de escape. Por lo tanto, no puede escribir una directamente en el script. Si quiere escribir una barra diagonal inversa, debe escribir dos (\\\\) juntas.  
  
> [!NOTE]
>  A partir de [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)], no se puede identificar el explorador como Internet Explorer comprobando la equivalencia de la tabulación vertical (\v) y "v". En versiones anteriores, la expresión `"\v" === "v"` devuelve `true`. En [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)], la expresión devuelve `false`.  
  
## <a name="example"></a>Ejemplo  
  
### <a name="description"></a>Descripción  
 En el siguiente ejemplo se muestran las secuencias de escape \\\ y \\'.  
  
### <a name="code"></a>Código  
  
```JavaScript  
document.write('The image path is C:\\webstuff\\mypage\\gifs\\garden.gif.');  
document.write ("<br />");  
document.write('The caption reads, "After the snow of \'97. Grandma\'s house is covered."');  
```  
  
<a name="CodePoint"></a>   
## <a name="unicode-code-point-escape-sequences"></a>Secuencias de escape de punto de código Unicode  
 Unicode es totalmente compatible con [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)]. Los puntos de código Unicode más comunes se representan mediante cuatro dígitos hexadecimales, como /u0009 para un carácter de tabulación. Los puntos de código astral, que incluyen todos los símbolos que requieren más de cuatro dígitos hexadecimales, ahora se admiten en un formato simplificado. Con el formato "\u {*codepoint*}", es posible representar en un formato literal el conjunto de caracteres Unicode. Por ejemplo, para representar el símbolo "𠮷", puede usar el siguiente formato: "\u{20BB7}".  
  
 En el ejemplo de código siguiente, las cadenas son equivalentes. (\uD842\uDFB7 es el método alternativo para especificar este símbolo en versiones anteriores).  
  
```JavaScript  
"\u{20BB7}"=="𠮷"=="\uD842\uDFB7"  
```  
  
 RegExp ahora incluye una marca /u para habilitar la plena compatibilidad con puntos de código astral. Por ejemplo, en el ejemplo de código siguiente, la marca /u de la expresión regular permite la coincidencia de puntos de código astral (el carácter de punto coincide con cualquier carácter de la cadena proporcionada).  
  
```JavaScript  
"𠮷".match(/./u)[0].length == 2  
```  
  
 La marca /u permite analizar el formato nuevo, \u{codepoint}, como una secuencia de escape Unicode. Esto es necesario porque \u{xxxxx} sin la marca /u tiene un significado diferente en una expresión regular.  
  
> [!NOTE]
>  En el caso de los puntos de código astral, la longitud siempre es 2. Esto coincide con el comportamiento de las versiones anteriores.  
  
 El objeto String ahora incluye dos métodos nuevos, String.codePointAt y String.fromCodePoint, para admitir puntos de código astral. Por ejemplo, puede usar codePointAt para devolver el punto de código equivalente para e símbolo "𠮷".  
  
```JavaScript  
"𠮷".codePointAt(0) == 0x20BB7  
  
```  
  
 También puede iterar puntos de código mediante la instrucción `for...of`.  
  
```JavaScript  
for(var c of "𠮷") {  
    console.log(c);  
}  
  
```  
  
## <a name="see-also"></a>Vea también  
 [String.fromCharCode (Función)](../../javascript/reference/string-fromcharcode-function-javascript.md)