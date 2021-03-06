---
title: "Cómo: usar el Diseñador de variables | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: reference
f1_keywords: System.Activities.Presentation.View.DesignTimeVariable.UI
ms.assetid: 0318dfb0-bf8f-4f92-9b86-ae4c1b2161ad
caps.latest.revision: "14"
author: ErikRe
ms.author: erikre
manager: erikre
ms.workload: multiple
ms.openlocfilehash: c9bf63222f16e29044a9a07078096b765421fbb3
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-use-the-variable-designer"></a>Utilizar el diseñador de variables
El diseñador variables se utiliza para crear variables con el fin de utilizarlas en escenarios de enlace de datos e instrucciones condicionales. El diseñador se tiene acceso haciendo clic en el **Variables** situado en la esquina inferior izquierda del lienzo de diseño. El diseñador contiene una lista de variables que aparecen en un formato tabular y pueden ordenarse por cada uno de los encabezados de columna, excepto para la **predeterminado** columna. Cada variable contiene un nombre, tipo de variable, ámbito y valor predeterminado (en su caso). El nombre y valor predeterminado son campos de texto editable, y el tipo y ámbito son listas desplegables. El ámbito es la actividad que se seleccionó cuando se invocó el diseñador de variables. Si no se puede crear una variable en el ámbito de la selección, el ámbito tendrá como valor predeterminado la actividad antecesora más próxima de la selección que permita la creación de variables en su ámbito. [! INCLUIR[crabout](/dotnet/framework/windows-workflow-foundation/variables-and-arguments).  
  
 El criterio de ordenación no se aplica hasta que el usuario utilice explícitamente uno de los controles de ordenación, cierre y vuelva a abrir el diseñador de variables o bien, cree otra variable.  
  
### <a name="to-create-a-new-variable"></a>Para crear una nueva variable  
  
1.  Abra un flujo de trabajo o solución de actividades en [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)].  
  
2.  En el lienzo de diseño, seleccione una actividad en su flujo de trabajo.  
  
3.  Abra el Diseñador de variables haciendo clic en el **Variables** situado en la esquina inferior izquierda del lienzo de diseño. Aparecerá el diseñador de variables.  
  
4.  Haga clic en la fila vacía con la etiqueta **crear Variable**. Esto agregará una nueva fila con una variable nueva con los siguientes valores predeterminados: variablex para el **nombre** donde x es un entero con un valor inicial de 1 que se incrementa automáticamente para crear nombres de variable únicos,  **Cadena** para el **tipo de Variable**, y **secuencia** para el **ámbito**. No se agrega ningún valor para **predeterminado**. Podrá cambiar estos valores en cualquier momento durante el proceso de diseño del flujo de trabajo.  
  
    > [!NOTE]
    >  Para eliminar una variable, seleccione la variable haciendo clic en él y, a continuación, presione la **eliminar** clave.  
  
## <a name="see-also"></a>Vea también  
 [Mediante el Diseñador de flujo de trabajo](../workflow-designer/using-the-workflow-designer.md)   
 [Las variables y argumentos](/dotnet/framework/windows-workflow-foundation/variables-and-arguments)   
 [Cómo: Usar el diseñador de argumentos](../workflow-designer/how-to-use-the-argument-designer.md)