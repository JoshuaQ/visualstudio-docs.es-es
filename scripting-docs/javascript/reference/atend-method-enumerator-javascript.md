---
title: "atEnd (método, Enumerator) (JavaScript) | Documentos de Microsoft"
ms.custom: 
ms.date: 01/18/2017
ms.prod: windows-client-threshold
ms.reviewer: 
ms.suite: 
ms.technology: devlang-javascript
ms.tgt_pltfrm: 
ms.topic: language-reference
f1_keywords: atEnd
dev_langs:
- JavaScript
- TypeScript
- DHTML
helpviewer_keywords: atEnd method
ms.assetid: 326808fb-9a0f-428e-aff1-b11b237913f1
caps.latest.revision: "17"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.openlocfilehash: 7b5097d00c11ffafc314264f134aedda3981c8e2
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="atend-method-enumerator-javascript"></a>atEnd (Método, Enumerator de JavaScript)
Devuelve un valor booleano que indica si el enumerador está al final de la colección.  
  
> [!WARNING]
>  Este objeto solo es compatible con Internet Explorer.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
  
myEnum.atEnd()  
```  
  
## <a name="remarks"></a>Comentarios  
 La referencia *myEnum* necesaria es cualquier objeto `Enumerator` .  
  
 El método `atEnd` devuelve **true** si el elemento actual es el último de la colección, si la colección está vacía o si el elemento actual está sin definir. En caso contrario, devuelve **false**.  
  
## <a name="example"></a>Ejemplo  
 En el siguiente código, el método `atEnd` se usa para determinar si se ha alcanzado el final de una lista de unidades:  
  
```JavaScript  
function ShowDrives()  
{  
    var s = "";  
    var bytesPerGB = 1024 * 1024 * 1024;  
  
    var fso = new ActiveXObject("Scripting.FileSystemObject");  
    var e = new Enumerator(fso.Drives);  
  
    e.moveFirst();  
    while (e.atEnd() == false)  
    {  
        var drv = e.item();  
  
        s += drv.Path + " - ";  
  
        if (drv.IsReady)  
        {  
            var freeGB = drv.FreeSpace / bytesPerGB;  
            var totalGB = drv.TotalSize / bytesPerGB;  
  
            s += freeGB.toFixed(3) + " GB free of ";  
            s += totalGB.toFixed(3) + " GB";  
        }  
        else  
        {  
            s += "Not Ready";  
        }  
  
        s += "<br />";  
  
        e.moveNext();  
    }  
    return(s);  
}  
```  
  
## <a name="requirements"></a>Requisitos  
 Se admite en los siguientes modos de documento: Modo de interpretación, estándar de Internet Explorer 6, estándar de Internet Explorer 7, estándar de Internet Explorer 8, estándar de Internet Explorer 9 y estándar de Internet Explorer 10. No se admite en aplicaciones de [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] . Consulte [Información de versión](../../javascript/reference/javascript-version-information.md).  
  
 **Se aplica a**: [Enumerator Object](../../javascript/reference/enumerator-object-javascript.md)  
  
## <a name="see-also"></a>Vea también  
 [Item (método, Enumerator)](../../javascript/reference/item-method-enumerator-javascript.md)   
 [moveFirst (método, Enumerator)](../../javascript/reference/movefirst-method-enumerator-javascript.md)   
 [moveNext (método, Enumerator)](../../javascript/reference/movenext-method-enumerator-javascript.md)   
 [Enumerator (Objeto)](../../javascript/reference/enumerator-object-javascript.md)