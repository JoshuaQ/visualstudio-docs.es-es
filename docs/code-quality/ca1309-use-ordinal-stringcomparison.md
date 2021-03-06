---
title: 'CA1309: Utilizar StringComparison ordinal | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- UseOrdinalStringComparison
- CA1309
helpviewer_keywords:
- UseOrdinalStringComparison
- CA1309
ms.assetid: 19be0854-cb6e-4efd-a4c8-a5c1fc6f7a71
caps.latest.revision: "15"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: cf913eea3f156595c9b9194b3d8a74e71b848367
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1309-use-ordinal-stringcomparison"></a>CA1309: Utilizar StringComparison ordinal
|||  
|-|-|  
|TypeName|UseOrdinalStringComparison|  
|Identificador de comprobación|CA1309|  
|Categoría|Microsoft.Globalization|  
|Cambio problemático|Poco problemático|  
  
## <a name="cause"></a>Motivo  
 Una operación de comparación de cadenas que lingüística no establece la <xref:System.StringComparison> parámetro a **Ordinal** o **OrdinalIgnoreCase**.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Muchas operaciones de cadenas, más importante la <xref:System.String.Compare%2A?displayProperty=fullName> y <xref:System.String.Equals%2A?displayProperty=fullName> métodos, proporcionan ahora una sobrecarga que acepta un <xref:System.StringComparison?displayProperty=fullName> valor de enumeración como parámetro.  
  
 Al especificarlas **StringComparison.Ordinal** o **StringComparison.OrdinalIgnoreCase**, la comparación de cadenas será lingüística. Es decir, se omiten las características que son específicas del lenguaje natural cuando se toman decisiones de comparación. Esto significa que las decisiones se basan en simples comparaciones de bytes y omitir mayúsculas y minúsculas o tablas de equivalencia parametrizadas por referencia cultural. Como resultado, estableciendo el parámetro explícitamente, en el **StringComparison.Ordinal** o **StringComparison.OrdinalIgnoreCase**, el código a menudo gana velocidad, aumenta la exactitud y se convierte en más confiable.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, cambie el método de comparación de cadenas a una sobrecarga que acepta el <xref:System.StringComparison?displayProperty=fullName> enumeración como parámetro y especifique **Ordinal** o **OrdinalIgnoreCase**. Por ejemplo, cambie `String.Compare(str1, str2)` a `String.Compare(str1, str2, StringComparison.Ordinal)`.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de esta regla cuando la biblioteca o la aplicación está diseñada para un público local limitado o cuándo se debe usar la semántica de la referencia cultural actual.  
  
## <a name="see-also"></a>Vea también  
 [Advertencias de globalización](../code-quality/globalization-warnings.md)   
 [CA1307: Especificar StringComparison](../code-quality/ca1307-specify-stringcomparison.md)