---
title: "Cómo: usar la administración de la acción de deshacer vinculada | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: editors [Visual Studio SDK], legacy - linked undo management
ms.assetid: af5cc22a-c9cf-45b1-a894-1022d563f3ca
caps.latest.revision: "10"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 7a025cdfc14eb39dad7ea2bc72a69f1f260fb583
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-use-linked-undo-management"></a>Cómo: usar la administración de la acción de deshacer vinculada
Acción de deshacer vinculada permite al usuario deshacer simultáneamente las mismas modificaciones en varios archivos. Por ejemplo, cambios de texto simultáneos en varios archivos de programa, como un archivo de encabezado y un archivo de Visual C++, es una transacción de la acción de deshacer vinculada. Acción de deshacer vinculada capacidad está integrada en la implementación del entorno del Administrador de deshacer y <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager> permite manipular esta capacidad. Acción de deshacer vinculada se implementa mediante una unidad de deshacer principal que puede vincular pilas de deshacer independiente para tratar como una unidad de deshacer única. En la siguiente sección se detalla el procedimiento para utilizar la acción de deshacer vinculada.  
  
### <a name="to-use-linked-undo"></a>Para usar la acción de deshacer vinculada  
  
1.  Llame a `QueryService` en `SVsLinkedUndoManager` para obtener un puntero a `IVsLinkedUndoTransactionManager`.  
  
2.  Crear la unidad de deshacer vinculada primario inicial mediante una llamada a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager.OpenLinkedUndo%2A>. Esto establece el punto de partida para un conjunto de pilas de deshacer que se desea agrupar en pilas de acción de deshacer vinculada. En el `OpenLinkedUndo` método también debe especificar si desea que la acción de deshacer vinculada estricta o no estricta. Comportamiento de la acción de deshacer vinculada no estricta significa que algunos de los documentos con la acción de deshacer vinculada elementos del mismo nivel pueden cierre y deje que el otro vinculado Deshacer elementos del mismo nivel en sus pilas de. Comportamiento de la acción de deshacer vinculada estricta especifica que todas las pilas de mismo nivel de acción de deshacer vinculada tienen que revertirse conjuntamente o no. Agregar la subsiguiente vinculado deshacer pilas mediante una llamada a [IOleUndoManager::Add](http://msdn.microsoft.com/library/windows/desktop/ms680135) método.  
  
3.  Llame a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager.CloseLinkedUndo%2A> poner todas las unidades de la acción de deshacer vinculada como uno.  
  
    > [!NOTE]
    >  Para implementar la administración de la acción de deshacer vinculada en un editor, agregue administración de deshacer. Para obtener más información sobre la implementación de administración de la acción de deshacer vinculada, consulte [Cómo: implementar la administración de deshacer](../extensibility/how-to-implement-undo-management.md).  
  
## <a name="see-also"></a>Vea también  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction>   
 [IOleParentUndoUnit](http://msdn.microsoft.com/library/windows/desktop/ms682151)   
 [IOleUndoUnit](http://msdn.microsoft.com/library/windows/desktop/ms678476)   
 [Cómo: implementar la administración de deshacer](../extensibility/how-to-implement-undo-management.md)