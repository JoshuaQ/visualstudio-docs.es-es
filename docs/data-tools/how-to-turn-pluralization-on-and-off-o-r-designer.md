---
title: "Cómo: activar y desactivar (Object Relational Designer) pluralización | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9b693bc3-303a-40a9-97ee-9cef5ca3ae81
caps.latest.revision: "2"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: a78f38d4b02311a164e0858744b70fbc5fb0ddaa
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-turn-pluralization-on-and-off-or-designer"></a>Cómo: activar y desactivar (Object Relational Designer) la pluralización
De forma predeterminada, al arrastrar objetos de base de datos cuyos nombres terminan s o propiedades de **Explorador de servidores**/**el Explorador de base de datos** en el [LINQ to SQL Tools en Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md), se cambian los nombres de las clases de entidad generadas desde plural en singular. Este cambio se produce para representar con mayor precisión la asignación de la clase de entidad con instancias a un solo registro de datos. Por ejemplo, al agregar una tabla Customers al [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)], se genera una clase de entidad denominada Customer debido a que la clase contendrá los datos de un solo cliente.  
  
> [!NOTE]
>  La pluralización está activada de forma predeterminada solamente en la versión en inglés de Visual Studio.  
  
[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
### <a name="to-turn-pluralization-on-and-off"></a>Para activar y desactivar la pluralización  
  
1.  En el menú **Herramientas** , haga clic en **Opciones**.  
  
2.  En el **opciones** cuadro de diálogo, expanda **herramientas de base de datos**.  
  
    > [!NOTE]
    >  Seleccione **mostrar todas las configuraciones** si la **herramientas de base de datos** nodo no está visible.  
  
3.  Haga clic en **Object Relational Designer**.  
  
4.  Establecer **Pluralización de nombres** a **habilitado** = **False** para establecer el [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] para que no cambie los nombres de clase.  
  
5.  Establecer **Pluralización de nombres** a **habilitado** = **True** para aplicar las reglas de pluralización a los nombres de clase de los objetos agregados a la [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
## <a name="see-also"></a>Vea también  
[LINQ to SQL herramientas en Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
[LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)   
[Obtener acceso a los datos en Visual Studio](../data-tools/accessing-data-in-visual-studio.md)