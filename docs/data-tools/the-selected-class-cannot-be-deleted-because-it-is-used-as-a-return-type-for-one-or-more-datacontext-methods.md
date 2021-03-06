---
title: "La clase seleccionada no se puede eliminar porque se utiliza como un tipo de valor devuelto de uno o más métodos de DataContext | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: d68254a0-f3a1-47e2-aed3-a83471e1d711
caps.latest.revision: "3"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: 78107218af8c4b32e1cace3137fa15fe31fcbc52
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="the-selected-class-cannot-be-deleted-because-it-is-used-as-a-return-type-for-one-or-more-datacontext-methods"></a>No se puede eliminar la clase seleccionada porque se usa como tipo devuelto de uno o varios métodos DataContext
El tipo de valor devuelto de uno o varios métodos de <xref:System.Data.Linq.DataContext> es la clase de entidad seleccionada. Cuando se elimina una clase de entidad que se usa como tipo de valor devuelto para un método de <xref:System.Data.Linq.DataContext>, se pueden producir errores en la compilación del proyecto. Para eliminar la clase de entidad seleccionada, identifique los métodos de <xref:System.Data.Linq.DataContext> que la usan y establezca sus tipos de valor devuelto en otra clase de entidad.  
  
 Para revertir los tipos de valor devueltos de <xref:System.Data.Linq.DataContext> métodos a sus tipos originales generados automáticamente, primero debe eliminar el <xref:System.Data.Linq.DataContext> método desde el panel de métodos y, a continuación, arrastre el objeto desde **Explorador de servidores** / **El Explorador de base de datos** hasta Object Relational Designer.  
  
### <a name="to-correct-this-error"></a>Para corregir este error  
  
1.  Identificar <xref:System.Data.Linq.DataContext> métodos que usan la clase de entidad como un tipo de valor devuelto, seleccione un <xref:System.Data.Linq.DataContext> método en los métodos de panel e inspeccionando el **tipo de valor devuelto** propiedad en el **propiedades** ventana .  
  
2.  Establecer el **tipo de valor devuelto** en otra clase de entidad o elimine la <xref:System.Data.Linq.DataContext> método desde el panel de métodos.  
  
## <a name="see-also"></a>Vea también
[Mensajes de Object Relational Designer](../data-tools/o-r-designer-messages.md)  
[LINQ to SQL de las herramientas en Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)