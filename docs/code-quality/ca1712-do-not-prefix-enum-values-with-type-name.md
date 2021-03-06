---
title: "CA1712: No utilizar prefijos en valores de enumeración con el nombre de tipo | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- CA1712
- DoNotPrefixEnumValuesWithTypeName
helpviewer_keywords:
- CA1712
- DoNotPrefixEnumValuesWithTypeName
ms.assetid: df0e3a12-67bf-48f1-a10b-2ef60484a5c7
caps.latest.revision: "15"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 101aa7852b9c6b163e6f18268e5c9ebb6e691760
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1712-do-not-prefix-enum-values-with-type-name"></a>CA1712: No utilizar prefijos en valores de enumeración con el nombre del tipo
|||  
|-|-|  
|TypeName|DoNotPrefixEnumValuesWithTypeName|  
|Identificador de comprobación|CA1712|  
|Categoría|Microsoft.Naming|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 Una enumeración contiene a un miembro cuyo nombre empieza con el nombre de tipo de la enumeración.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Nombres de miembros de enumeración no tienen el prefijo con el nombre del tipo porque la información de tipo se espera que se proporcionan con las herramientas de desarrollo.  
  
 Las convenciones de nomenclatura proporcionan una apariencia común para las bibliotecas destinadas a Common Language Runtime. Esto reduce el tiempo que se requieren para obtener información sobre una nueva biblioteca de software y aumenta la confianza del cliente que la biblioteca se haya desarrollado por alguien que tenga experiencia en desarrollo de código administrado.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, quite el prefijo del nombre de tipo del miembro de enumeración.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 No suprima las advertencias de esta regla.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra una enumeración con nombre incorrecto seguida de la versión corregida.  
  
 [!code-csharp[FxCop.Naming.EnumValues#1](../code-quality/codesnippet/CSharp/ca1712-do-not-prefix-enum-values-with-type-name_1.cs)]
 [!code-cpp[FxCop.Naming.EnumValues#1](../code-quality/codesnippet/CPP/ca1712-do-not-prefix-enum-values-with-type-name_1.cpp)]
 [!code-vb[FxCop.Naming.EnumValues#1](../code-quality/codesnippet/VisualBasic/ca1712-do-not-prefix-enum-values-with-type-name_1.vb)]  
  
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1711: Los identificadores no deberían tener el sufijo incorrecto](../code-quality/ca1711-identifiers-should-not-have-incorrect-suffix.md)  
  
 [CA1027: Marcar enumeraciones con FlagsAttribute](../code-quality/ca1027-mark-enums-with-flagsattribute.md)  
  
 [CA2217: No marcar enumeraciones con FlagsAttribute](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)  
  
## <a name="see-also"></a>Vea también  
 <xref:System.Enum?displayProperty=fullName>