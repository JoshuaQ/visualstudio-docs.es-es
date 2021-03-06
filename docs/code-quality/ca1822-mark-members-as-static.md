---
title: "CA1822: Marcar el miembro como estático | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- MarkMembersAsStatic
- CA1822
helpviewer_keywords:
- MarkMembersAsStatic
- CA1822
ms.assetid: 743f0af7-41d1-4852-8d97-af0688b31118
caps.latest.revision: "18"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: d1f3c20f39fe863925d46c1f86f2f6a821e8489a
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1822-mark-members-as-static"></a>CA1822: Marcar el miembro como estático
|||  
|-|-|  
|TypeName|MarkMethodsAsStatic|  
|Identificador de comprobación|CA1822|  
|Categoría|Microsoft.Performance|  
|Cambio problemático|Poco problemático: si el miembro no es visible fuera del ensamblado, con independencia de los cambios que realice. No problemático: si simplemente cambia el miembro a un miembro de instancia con el `this` palabra clave.<br /><br /> Problemático: si cambia al miembro de un miembro de instancia a un miembro estático y está visible fuera del ensamblado.|  
  
## <a name="cause"></a>Motivo  
 Un miembro que no tiene acceso a datos de la instancia no está marcado como static (Shared en [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]).  
  
## <a name="rule-description"></a>Descripción de la regla  
 Los miembros que no tienen acceso a datos de instancia o que llaman a métodos de instancia se pueden marcar como static (Shared en [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]). Después de marcar los métodos como static, el compilador emite los sitios de llamada no virtuales para estos miembros. Emisión de sitios de llamada no virtuales evitará que una comprobación en tiempo de ejecución para cada llamada que se asegura de que el puntero de objeto actual es distinto de null. Esto puede lograr una mejora del rendimiento puede medir para código sensibles al rendimiento. En algunos casos, no se ha podido tener acceso a la instancia actual del objeto representa un problema de corrección.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Marque el miembro como estático (o compartido en [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]) o utilizar 'this' / '' en el método del cuerpo, si procede.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de esta regla de código previamente distribuido para que la corrección supondría un cambio importante.  
  
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1811: Evitar código privado al que no se llama](../code-quality/ca1811-avoid-uncalled-private-code.md)  
  
 [CA1812: Evitar las clases internas sin instancia](../code-quality/ca1812-avoid-uninstantiated-internal-classes.md)  
  
 [CA1804: Quitar variables locales no utilizadas](../code-quality/ca1804-remove-unused-locals.md)