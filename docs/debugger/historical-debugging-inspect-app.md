---
title: "Inspeccionar la aplicación con depuración histórica | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 629b5d93-39b2-430a-b8ba-d2a47fdf2584
caps.latest.revision: "3"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 91cef7c8c037421b69cd13e69ab21543aaf89839
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="inspect-your-app-with-intellitrace-historical-debugging-in-visual-studio"></a>Inspeccionar la aplicación con depuración en Visual Studio de historial de IntelliTrace
Puede usar [depuración histórica](../debugger/historical-debugging.md) para desplazarse hacia atrás y hacia delante a través de la ejecución de la aplicación e inspeccionar su estado.  
  
Puede usar IntelliTrace en Visual Studio Enterprise, pero no en las ediciones Professional o Community.  
  
## <a name="navigate-your-code-with-historical-debugging"></a>Navegar por el código con depuración histórica  
 Comencemos con un programa simple que tiene un error. En una aplicación de consola C#, agregue el código siguiente:  
  
```CSharp  
static void Main(string[] args)  
{  
    int testInt = 0;  
    int resultInt = AddAll(testInt);  
    Console.WriteLine(resultInt);  
}  
private static int AddAll(int j)  
{  
    for (int i = 0; i < 20; i++)  
    {  
        j = AddInt(j);  
    }  
    return j;  
}  
  
private static int AddInt(int add)  
{  
    if (add == 10)  
    {  
        return add += 25;  
    }  
    return ++add;  
}  
```  
  
 Supondremos que el valor esperado de `resultInt` después de llamar a `AddAll()` es 20 (el resultado de incrementar `testInt` 20 veces). (También supondremos que no se puede ver el error en `AddInt()`). Pero el resultado es 44. ¿Cómo podemos encontrar el error sin pasar por `AddAll()` 10 veces? Podemos usar depuración histórica para encontrar el error más rápida y fácilmente. Esta es la manera de hacerlo:  
  
1.  En **Herramientas > Opciones > IntelliTrace > General**, asegúrese de que IntelliTrace está habilitado y seleccione **eventos de IntelliTrace e información de llamadas**. Si no selecciona esta opción, no podrá ver el medianil de navegación (tal y como se explica más adelante).  
  
2.  Establezca un punto de interrupción en la línea `Console.WriteLine(resultInt);`.  
  
3.  Inicie la depuración. El código se ejecuta hasta el punto de interrupción. En el **locales** ventana, puede ver que el valor de `resultInt` es 44.  
  
4.  Abra la **herramientas de diagnóstico** ventana (**Depurar > Mostrar herramientas de diagnóstico**). La ventana de código debe ser similar a la que se muestra a continuación:  
  
     ![Ventana de código en el punto de interrupción](../debugger/media/historicaldebuggingbreakpoint.png "HistoricalDebuggingBreakpoint")  
  
5.  Debería ver una flecha doble junto al margen izquierdo, justo encima del punto de interrupción. Esta área se denomina el medianil de navegación y se utiliza para depuración histórica. Haga clic en la flecha.  
  
     En la ventana de código, debería ver que la línea de código anterior (`int resultInt = AddIterative(testInt);`) es de color rosa. Por encima de la ventana, debería ver un mensaje que ya está en depuración histórica.  
  
     La ventana de código ahora tiene el siguiente aspecto:  
  
     ![ventana de código en modo de depuración histórica](../debugger/media/historicaldebuggingback.png "HistoricalDebuggingBack")  
  
6.  Ahora puede ir a la `AddAll()` método (**F11**, o la **paso a paso** botón en el medianil de navegación. Avanzar paso a paso (**F10**, o **ir a llamada siguiente** en el medianil de navegación. La línea rosa se encuentra ahora en la línea `j = AddInt(j);`. **F10** en este caso no avanza a la siguiente línea de código. sino a la siguiente llamada de función. Depuración histórica va de una llamada a otra y omite las líneas de código que no incluyen una llamada de función.  
  
7.  Ahora, depure paso a paso por instrucciones el método `AddInt()`. Debería ver el error en este código inmediatamente.  

## <a name="next-steps"></a>Pasos siguientes

Este procedimiento solo había arañado la superficie de lo que puede hacer con depuración histórica.

- Para ver las instantáneas durante la depuración, vea [ver instantáneas mediante la devolución de IntelliTrace paso](../debugger/how-to-use-intellitrace-step-back.md).
- Para obtener más información sobre las distintas configuraciones y los efectos de los botones diferentes en el medianil de navegación, consulte [características de IntelliTrace](../debugger/intellitrace-features.md).