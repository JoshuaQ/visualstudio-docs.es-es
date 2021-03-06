---
title: "Cómo: cambiar a otro subproceso durante la depuración | Documentos de Microsoft"
ms.custom: 
ms.date: 04/27/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- CSharp
- VB
- FSharp
- C++
helpviewer_keywords: threads, switching [debugging]
ms.assetid: 5cd76c52-76fa-4fcc-b37e-e9f0ecac0e9e
caps.latest.revision: "26"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 0710bad95484ada62faa042edabf5b76ac459558
ms.sourcegitcommit: 9357209350167e1eb7e50b483e44893735d90589
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/05/2018
---
# <a name="how-to-switch-to-another-thread-while-debugging-in-visual-studio"></a>Cómo: cambiar a otro subproceso durante la depuración en Visual Studio
Cuando se depura una aplicación multiproceso, puede utilizar cualquiera de los diversos métodos para cambiar desde el subproceso que ha estado trabajando con a otro subproceso.

> [!NOTE]
> Si desea controlar el orden en el que ejecutan subprocesos, deberá [inmovilizar y reanudar subprocesos](../debugger/get-started-debugging-multithreaded-apps.md).

Al examinar los subprocesos en el editor de código y las distintas ventanas de depuración multiproceso, la flecha amarilla indica el subproceso actual. Una flecha verde con una cola rizada indica que un subproceso actual no tiene el contexto actual del depurador.
  
### <a name="to-switch-to-any-thread-that-appears"></a>Para cambiar a cualquier subproceso que aparece 
  
-   En el **subprocesos** o **inspección paralela** ventana, haga doble clic en el subproceso.  
  
### <a name="to-switch-to-a-thread-in-a-source-window"></a>Para cambiar a un subproceso en una ventana de código fuente  
  
-   En el margen interno izquierdo, haga clic en un icono de marcador de subproceso ![marcador de subproceso](../debugger/media/dbg-thread-marker.png "ThreadMarker"), seleccione **cambie a**y, a continuación, haga clic en el nombre del subproceso al que desea cambiar . El menú contextual muestra únicamente los subprocesos de esa ubicación concreta.  
  
     Si no aparece ningún marcador de subproceso, pulse el botón derecho en el **subprocesos** ventana y compruebe que **Mostrar subprocesos en código fuente** está seleccionada.  
  
### <a name="to-switch-to-a-thread-in-the-debug-location-toolbar"></a>Para cambiar a un subproceso en la barra de herramientas Ubicación de depuración  
  
1.  En el **ubicación de depuración** barra de herramientas, haga clic en el **subprocesos** lista.  
  
2.  En la lista, haga clic en el subproceso al que desee cambiar.  
  
## <a name="see-also"></a>Vea también  
 [Depurar aplicaciones multiproceso](../debugger/debug-multithreaded-applications-in-visual-studio.md)
