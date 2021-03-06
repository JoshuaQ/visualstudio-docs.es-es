---
title: "CA1820: Comprobar si las cadenas están vacías mediante la longitud de cadena | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- TestForEmptyStringsUsingStringLength
- CA1820
helpviewer_keywords:
- TestForEmptyStringsUsingStringLength
- CA1820
ms.assetid: da1e70c8-b1dc-46b9-8b8f-4e6e48339681
caps.latest.revision: "21"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: d044f09ca26b65506bcfb7466f59da73acfad1e4
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1820-test-for-empty-strings-using-string-length"></a>CA1820: Comprobar si las cadenas están vacías mediante la longitud de cadena
|||  
|-|-|  
|TypeName|TestForEmptyStringsUsingStringLength|  
|Identificador de comprobación|CA1820|  
|Categoría|Microsoft.Performance|  
|Cambio problemático|Poco problemático|  
  
## <a name="cause"></a>Motivo  
 Una cadena se compara con la cadena vacía utilizando <xref:System.Object.Equals%2A?displayProperty=fullName>.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Comparación de cadenas que usan la <xref:System.String.Length%2A?displayProperty=fullName> propiedad o el <xref:System.String.IsNullOrEmpty%2A?displayProperty=fullName> método es significativamente más rápido que utilizar <xref:System.Object.Equals%2A>. Esto es porque <xref:System.Object.Equals%2A> ejecuta significativamente más instrucciones de MSIL que <xref:System.String.IsNullOrEmpty%2A> o el número de instrucciones ejecutado para recuperar el <xref:System.String.Length%2A> propiedad valor y compararlo con cero.  
  
 Debe tener en cuenta que <xref:System.Object.Equals%2A> y <xref:System.String.Length%2A> == 0 se comportan de forma diferente para las cadenas nulas. Si se intenta obtener el valor de la <xref:System.String.Length%2A> propiedad en una cadena nula, common language runtime produce una <xref:System.NullReferenceException?displayProperty=fullName>. Si se efectúa una comparación entre una cadena nula y una cadena vacía, common language runtime no inicia una excepción; la comparación devuelve `false`. Comprobación de cadenas nulas no afecta significativamente el rendimiento relativo de estos dos enfoques. Cuando el destino es [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)], use el <xref:System.String.IsNullOrEmpty%2A> método. De lo contrario, utilice la <xref:System.String.Length%2A> == comparación siempre que sea posible.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, cambie la comparación se debe utilizar el <xref:System.String.Length%2A> propiedad y pruebas para la cadena nula. Si el destino es [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)], use el <xref:System.String.IsNullOrEmpty%2A> método.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de esta regla si el rendimiento no es un problema.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra las distintas técnicas que se utilizan para buscar una cadena vacía.  
  
 [!code-csharp[FxCop.Performance.StringTest#1](../code-quality/codesnippet/CSharp/ca1820-test-for-empty-strings-using-string-length_1.cs)]