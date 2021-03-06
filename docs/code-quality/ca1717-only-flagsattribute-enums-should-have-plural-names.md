---
title: "CA1717: Solo las enumeraciones FlagsAttribute deberían tener nombres en plural | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- CA1717
- OnlyFlagsEnumsShouldHavePluralNames
helpviewer_keywords:
- OnlyFlagsEnumsShouldHavePluralNames
- CA1717
ms.assetid: a6855d8b-d78a-42c1-834e-61c31f5572ed
caps.latest.revision: "17"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 203ee8af0f28f272ece784f086f7aeba7341dfc4
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1717-only-flagsattribute-enums-should-have-plural-names"></a>CA1717: Solo las enumeraciones FlagsAttribute deberían tener nombres en plural
|||  
|-|-|  
|TypeName|OnlyFlagsEnumsShouldHavePluralNames|  
|Identificador de comprobación|CA1717|  
|Categoría|Microsoft.Naming|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 El nombre de una enumeración visible externamente termina en una palabra en plural y la enumeración no está marcada con el <xref:System.FlagsAttribute?displayProperty=fullName> atributo.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Convenciones de nomenclatura establecen que un nombre en plural para una enumeración indica que se puede especificar más de un valor de la enumeración al mismo tiempo. La <xref:System.FlagsAttribute> indica a los compiladores que la enumeración debe tratarse como un campo de bits que permite operaciones bit a bit en la enumeración.  
  
 Si solo puede especificarse un valor de una enumeración a la vez, el nombre de la enumeración debe ser una palabra en singular. Por ejemplo, una enumeración que define los días de la semana puede ser pensada para su uso en una aplicación donde puede especificar varios días. Esta enumeración debe tener la <xref:System.FlagsAttribute> y podría denominarse 'Días'. Una enumeración similar que permite sólo un día que se especifique el atributo no es necesario y podría ser denominada 'Day'.  
  
 Las convenciones de nomenclatura proporcionan una apariencia común para las bibliotecas destinadas a Common Language Runtime. Esto reduce el tiempo necesario para obtener información sobre una nueva biblioteca de software y aumenta la confianza del cliente que la biblioteca se haya desarrollado por alguien que tenga experiencia en desarrollo de código administrado.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Cambie el nombre de la enumeración en una palabra en singular o agregue el <xref:System.FlagsAttribute>.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de la regla si el nombre termina en una palabra en singular.  
  
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1714: Las enumeraciones Flags deberían tener nombres en plural](../code-quality/ca1714-flags-enums-should-have-plural-names.md)  
  
 [CA1027: Marcar enumeraciones con FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)  
  
 [CA2217: No marcar enumeraciones con FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)  
  
## <a name="see-also"></a>Vea también  
 <xref:System.FlagsAttribute?displayProperty=fullName>   
 [Diseño de enumeraciones](/dotnet/standard/design-guidelines/enum)