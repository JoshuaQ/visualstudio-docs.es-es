---
title: Promise (objeto de JavaScript) | Documentos de Microsoft
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
ms.assetid: 358ad98b-f7fa-448c-9ee0-ef1e2a45e9c6
caps.latest.revision: "9"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.openlocfilehash: 61e5611dd0d455c7e7b704777cc2341ca43a2404
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="promise-object-javascript"></a>Objeto Promise (JavaScript)
Proporciona un mecanismo para programar el trabajo de modo que se lleve a cabo en un valor que todavía no se calculó. Es una abstracción para administrar las interacciones con las API asincrónicas.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
var promise = new Promise(function(resolve, reject) { ... });  
```  
  
#### <a name="parameters"></a>Parámetros  
 `promise`  
 Obligatorio. Nombre de variable a la que se asigna la promesa.  
  
 `resolve`  
 Obligatorio. Función que se ejecuta para indicar que la promesa se completó correctamente.  
  
 `reject`  
 Opcional. Función que se ejecuta para indicar que la promesa se rechazó con un error.  
  
## <a name="remarks"></a>Comentarios  
 Una promesa debe completarse con un valor o debe rechazarse con un motivo. El método `then` del objeto Promise se ejecuta cuando la promesa se completa o se rechaza, lo que ocurra primero. Si la promesa se completa correctamente, se ejecuta la función de controlador de cumplimiento del método `then`. Si la promesa se rechaza, se ejecuta la función de controlador de errores del método `then` (o el método `catch`).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra cómo llamar a una función (`timeout`) que devuelve una promesa. El controlador de cumplimiento del método `then` se ejecuta después de que expire el período de tiempo de espera de 5.000 ms.  
  
```JavaScript  
function timeout(duration) {  
    return new Promise(function(resolve, reject) {  
        setTimeout(resolve, duration);  
    });  
}  
  
// Note: This code uses arrow function syntax  
var m = timeout(5000).then(() => {  
    console.log("done!");  
})  
  
// Output (after 5 seconds):  
// done!  
```  
  
## <a name="example"></a>Ejemplo  
 También se pueden encadenar llamadas al método `then`, tal como se muestra en el código siguiente. Cada controlador de finalización debe devolver una promesa para admitir el encadenamiento. En este código, que llama a la misma función `timeout`, la primera llamada a tiempo de espera se devuelve después de 1.000 ms. El primer controlador de finalización llama a `timeout` de nuevo, y esta promesa devuelve después de 2.000 ms. Después, su controlador de finalización produce un error. El controlador de error llama a `Promise.all`, que lleva a cabo la devolución solo cuando ambas llamadas al tiempo de espera se completan o se rechazan.  
  
```JavaScript  
var p = timeout(1000).then(() => {  
    return timeout(2000);  
}).then(() => {  
    throw new Error("error");  
}).catch(err => {  
    return Promise.all([timeout(100), timeout(200)]);  
})  
```  
  
## <a name="requirements"></a>Requisitos  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## <a name="functions"></a>Funciones  
 En la tabla siguiente se describen las funciones del objeto `Promise`.  
  
|Función|Descripción|  
|--------------|-----------------|  
|[Función Promise.All](../../javascript/reference/promise-all-function-promise.md)|Combina dos o más promesas y realiza la devolución solo cuando todas las promesas especificadas se completan o se rechazan.|  
|[Función Promise.race](../../javascript/reference/promise-race-function-promise.md)|Crea una nueva promesa que resolverá o rechazará con el mismo valor de resultado que la primera promesa que se va resolver o rechazar entre los argumentos pasados.|  
|[Función Promise.Reject](../../javascript/reference/promise-reject-function-promise.md)|Crea una promesa rechazada nueva cuyo resultado es igual que el argumento pasado.|  
|[Función Promise.Resolve](../../javascript/reference/promise-resolve-function-promise.md)|Crea una promesa resuelta nueva cuyo resultado es igual que su argumento.|  
  
## <a name="methods"></a>Métodos  
 En la tabla siguiente se describen los métodos del objeto `Promise`.  
  
|Método|Descripción|  
|------------|-----------------|  
|[catch (método)](../../javascript/reference/catch-method-promise.md)|Permite especificar el trabajo que se va a realizar al rechazar una promesa.|  
|[a continuación, método](../../javascript/reference/then-method-promise.md)|Permite especificar el trabajo que se va a realizar al cumplir una promesa.|