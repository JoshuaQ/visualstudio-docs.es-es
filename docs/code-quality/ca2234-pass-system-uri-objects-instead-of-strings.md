---
title: 'CA2234: Pase objetos System.Uri en lugar de cadenas | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- PassSystemUriObjectsInsteadOfStrings
- CA2234
helpviewer_keywords:
- CA2234
- PassSystemUriObjectsInsteadOfStrings
ms.assetid: 14616b37-74c4-4286-b051-115d00aceb5f
caps.latest.revision: "14"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: fbafbcdf8750a31fc7fc7a142961e67182c4bbc7
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca2234-pass-systemuri-objects-instead-of-strings"></a>CA2234: Pase objetos System.Uri en lugar de cadenas
|||  
|-|-|  
|TypeName|PassSystemUriObjectsInsteadOfStrings|  
|Identificador de comprobación|CA2234|  
|Categoría|Microsoft.Usage|  
|Cambio problemático|No trascendental|  
  
## <a name="cause"></a>Motivo  
 Se realiza una llamada a un método que tiene un parámetro de cadena cuyo nombre contiene "uri", "Uri", "urn", "Urn", "url" o "Url"; y el tipo declarativo del método contiene una sobrecarga de método correspondiente que tiene un <xref:System.Uri?displayProperty=fullName> parámetro.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Un nombre de parámetro se divide en tokens basándose en la convención camel de mayúsculas y minúsculas, y, a continuación, cada token se comprueba para ver si es igual "uri", "Uri", "urn", "Urn", "url" o "Url". Si hay una coincidencia, se supone que el parámetro representa un identificador uniforme de recursos (URI). Las representaciones de cadena de identificadores URI tienen tendencia a analizar y codificar errores, por lo que pueden crear puntos vulnerables en la seguridad. La <xref:System.Uri> clase proporciona estos servicios de una manera segura. Cuando hay que elegir entre dos sobrecargas que difieren solo relativas a la representación de un identificador URI, el usuario debe elegir la sobrecarga que toma un <xref:System.Uri> argumento.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, llame a la sobrecarga que toma el <xref:System.Uri> argumento.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de esta regla si el parámetro de cadena no representa un URI.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra un método, `ErrorProne`, lo que infringe la regla y un método, `SaferWay`, que llama correctamente a la <xref:System.Uri> de sobrecarga.  
  
 [!code-vb[FxCop.Usage.PassUri#1](../code-quality/codesnippet/VisualBasic/ca2234-pass-system-uri-objects-instead-of-strings_1.vb)]
 [!code-cpp[FxCop.Usage.PassUri#1](../code-quality/codesnippet/CPP/ca2234-pass-system-uri-objects-instead-of-strings_1.cpp)]
 [!code-csharp[FxCop.Usage.PassUri#1](../code-quality/codesnippet/CSharp/ca2234-pass-system-uri-objects-instead-of-strings_1.cs)]  
  
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1057: Las sobrecargas URI de cadena llaman a sobrecargas System.Uri](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)  
  
 [CA1056: Las propiedades URI no deben ser cadenas](../code-quality/ca1056-uri-properties-should-not-be-strings.md)  
  
 [CA1054: Los parámetros de URI no deben ser cadenas](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)  
  
 [CA1055: Los valores devueltos URI no deben ser cadenas](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)