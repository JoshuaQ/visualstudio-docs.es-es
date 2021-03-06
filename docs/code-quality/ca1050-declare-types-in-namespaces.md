---
title: 'CA1050: Declare tipos en espacios de nombres | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- CA1050
- DeclareTypesInNamespaces
helpviewer_keywords:
- DeclareTypesInNamespaces
- CA1050
ms.assetid: 1002748d-ac8d-404f-85dd-7a12d1ad3e05
caps.latest.revision: "15"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 297491e6f3bdaef2b0d460bfe37716f6cae0dbd3
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1050-declare-types-in-namespaces"></a>CA1050: Declare tipos en espacios de nombres
|||  
|-|-|  
|TypeName|DeclareTypesInNamespaces|  
|Identificador de comprobación|CA1050|  
|Categoría|Microsoft.Design|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 Un tipo público o protegido se define fuera del ámbito de un espacio de nombres.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Los tipos se declaran en los espacios de nombres para evitar conflictos de nombres y como una manera de organizar los tipos relacionados en una jerarquía de objetos. Tipos que se encuentran fuera de cualquier espacio de nombres están en un espacio de nombres global que no se puede hacer referencia en el código.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, coloque el tipo en un espacio de nombres.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Aunque nunca tienen que suprimir una advertencia de esta regla, es seguro hacerlo cuando el ensamblado nunca se usará junto con otros ensamblados.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra una biblioteca que tiene un tipo declarado incorrectamente fuera de un espacio de nombres y un tipo que tiene el mismo nombre declarado en un espacio de nombres.  
  
 [!code-csharp[FxCop.Design.TypesLiveInNamespaces#1](../code-quality/codesnippet/CSharp/ca1050-declare-types-in-namespaces_1.cs)]
 [!code-vb[FxCop.Design.TypesLiveInNamespaces#1](../code-quality/codesnippet/VisualBasic/ca1050-declare-types-in-namespaces_1.vb)]  
  
## <a name="example"></a>Ejemplo  
 La aplicación siguiente utiliza la biblioteca que se definió anteriormente. Tenga en cuenta que el tipo que se declara fuera de un espacio de nombres se crea cuando el nombre `Test` no está calificado por un espacio de nombres. Tenga en cuenta también que para tener acceso a la `Test` escriba en `Goodspace`, el nombre de espacio de nombres es obligatorio.  
  
 [!code-csharp[FxCop.Design.TestTypesLive#1](../code-quality/codesnippet/CSharp/ca1050-declare-types-in-namespaces_2.cs)]
 [!code-vb[FxCop.Design.TestTypesLive#1](../code-quality/codesnippet/VisualBasic/ca1050-declare-types-in-namespaces_2.vb)]