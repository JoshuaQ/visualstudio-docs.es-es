---
title: "CA1056: Las propiedades URI no deben ser cadenas | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
helpviewer_keywords: 
  - "CA1056"
  - "UriPropertiesShouldNotBeStrings"
ms.assetid: fdc99d29-0904-4a65-baa8-4f76833c953e
caps.latest.revision: 12
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
caps.handback.revision: 12
---
# CA1056: Las propiedades URI no deben ser cadenas
[!INCLUDE[vs2017banner](../code-quality/includes/vs2017banner.md)]

|||  
|-|-|  
|TypeName|UriPropertiesShouldNotBeStrings|  
|Identificador de comprobación|CA1056|  
|Categoría|Microsoft.Design|  
|Cambio problemático|Problemático|  
  
## Motivo  
 Un tipo declara una propiedad de cadena cuyo nombre contiene "uri", "Uri", "urna", "Urna", "url" o "Url".  
  
## Descripción de la regla  
 Esta regla divide el nombre de la propiedad en símbolos \(token\) basándose en la convención Pascal de uso de mayúsculas y, a continuación, comprueba cada símbolo para ver si son iguales a "uri", "Uri", "urn", "Urn", "url" o "Url".  Si hay una coincidencia, la regla supone que la propiedad representa un identificador de recursos uniforme \(URI\).  Las representaciones de cadena de identificadores URI tienen tendencia a analizar y codificar errores, por lo que pueden crear puntos vulnerables en la seguridad.  La clase <xref:System.Uri?displayProperty=fullName> proporciona estos servicios de una manera segura.  
  
## Cómo corregir infracciones  
 Para corregir una infracción de esta regla, cambie la propiedad a un <xref:System.Uri>.  
  
## Cuándo suprimir advertencias  
 Puede suprimirse de forma segura una advertencia de esta regla si la propiedad no representa ningún URI.  
  
## Ejemplo  
 El ejemplo siguiente muestra un tipo, `ErrorProne`, que infringe esta regla, y un tipo, `SaferWay`, que la cumple.  
  
 [!code-cs[FxCop.Design.UriNotString#1](../code-quality/codesnippet/CSharp/ca1056-uri-properties-should-not-be-strings_1.cs)]
 [!code-vb[FxCop.Design.UriNotString#1](../code-quality/codesnippet/VisualBasic/ca1056-uri-properties-should-not-be-strings_1.vb)]
 [!code-cpp[FxCop.Design.UriNotString#1](../code-quality/codesnippet/CPP/ca1056-uri-properties-should-not-be-strings_1.cpp)]  
  
## Reglas relacionadas  
 [CA1054: Los parámetros de URI no deben ser cadenas](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)  
  
 [CA1055: Los valores devueltos URI no deben ser cadenas](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)  
  
 [CA2234: Pase objetos System.Uri en lugar de cadenas](../code-quality/ca2234-pass-system-uri-objects-instead-of-strings.md)  
  
 [CA1057: Las sobrecargas URI de cadena llaman a sobrecargas System.Uri](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)