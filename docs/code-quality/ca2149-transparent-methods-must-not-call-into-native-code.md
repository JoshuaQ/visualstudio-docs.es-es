---
title: "CA2149: Los métodos transparentes no deben llamar a código nativo | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: CA2149
ms.assetid: 28951bd7-f3db-4871-99aa-bad68d1ead80
caps.latest.revision: "11"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: cplusplus
ms.openlocfilehash: 9377a30d2fc56c8acef16b6bcf1187d0e9fa8741
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca2149-transparent-methods-must-not-call-into-native-code"></a>CA2149: Los métodos transparentes no deben llamar a código nativo
|||  
|-|-|  
|TypeName|TransparentMethodsMustNotCallNativeCode|  
|Identificador de comprobación|CA2149|  
|Categoría|Microsoft.Security|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 Un método llama a una función nativa a través de un código auxiliar del método como P/Invoke.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Esta regla se desencadena en cualquier método transparente que llame directamente a código nativo, por ejemplo, a través de P/Invoke. Las infracciones de esta regla conducen a una <xref:System.MethodAccessException> en el modelo de transparencia de nivel 2 y una demanda completa para <xref:System.Security.Permissions.SecurityPermissionAttribute.UnmanagedCode%2A> en el modelo de transparencia de nivel 1.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, marque el método que llama al código nativo con el <xref:System.Security.SecurityCriticalAttribute> o <xref:System.Security.SecuritySafeCriticalAttribute> atributo.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 No suprima las advertencias de esta regla.  
  
## <a name="example"></a>Ejemplo  
 [!code-csharp[FxCop.Security.CA2149.TransparentMethodsMustNotCallNativeCode#1](../code-quality/codesnippet/CSharp/ca2149-transparent-methods-must-not-call-into-native-code_1.cs)]