---
title: "CA1403: Los tipos de diseño automático no deben ser visibles para COM | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- AutoLayoutTypesShouldNotBeComVisible
- CA1403
helpviewer_keywords:
- CA1403
- AutoLayoutTypesShouldNotBeComVisible
ms.assetid: a7007714-f9b4-4730-94e0-67d3dc68991f
caps.latest.revision: "17"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 7da04d7ecda3e47239bd865812c6fbd05428ac09
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1403-auto-layout-types-should-not-be-com-visible"></a>CA1403: Los tipos de diseño automático no deben ser visibles para COM
|||  
|-|-|  
|TypeName|AutoLayoutTypesShouldNotBeComVisible|  
|Identificador de comprobación|CA1403|  
|Categoría|Microsoft.Interoperability|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 Un tipo de valor visible del modelo de objetos componentes (COM) se marca con la <xref:System.Runtime.InteropServices.StructLayoutAttribute?displayProperty=fullName> atributo establecido en <xref:System.Runtime.InteropServices.LayoutKind?displayProperty=fullName>.  
  
## <a name="rule-description"></a>Descripción de la regla  
 <xref:System.Runtime.InteropServices.LayoutKind>tipos de diseño se administran por common language runtime. El diseño de estos tipos puede cambiar entre las versiones de .NET Framework, lo que interrumpirá a los clientes COM que esperan un diseño concreto. Tenga en cuenta que si el <xref:System.Runtime.InteropServices.StructLayoutAttribute> no se especifica el atributo, C#, [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)], y los compiladores de C++ especifican el <xref:System.Runtime.InteropServices.LayoutKind> diseño para los tipos de valor.  
  
 A menos que marque lo contrario, todos los tipos no genéricos públicos son visibles para COM; todos los tipos no públicos y genéricos son invisibles para COM. Sin embargo, para reducir los falsos positivos, esta regla requiere que la visibilidad de COM del tipo que se establezca explícitamente; el ensamblado que lo contiene se debe marcar con el <xref:System.Runtime.InteropServices.ComVisibleAttribute?displayProperty=fullName> establecido en `false` y el tipo se debe marcar con el <xref:System.Runtime.InteropServices.ComVisibleAttribute> establecido en `true`.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, cambie el valor de la <xref:System.Runtime.InteropServices.StructLayoutAttribute> atribuir a <xref:System.Runtime.InteropServices.LayoutKind> o <xref:System.Runtime.InteropServices.LayoutKind>, o hacer que el tipo no visible para COM.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 No suprima las advertencias de esta regla.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra un tipo que infringe la regla y un tipo que infringe la regla.  
  
 [!code-csharp[FxCop.Interoperability.AutoLayout#1](../code-quality/codesnippet/CSharp/ca1403-auto-layout-types-should-not-be-com-visible_1.cs)]
 [!code-vb[FxCop.Interoperability.AutoLayout#1](../code-quality/codesnippet/VisualBasic/ca1403-auto-layout-types-should-not-be-com-visible_1.vb)]  
  
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1408: No utilizar AutoDual ClassInterfaceType](../code-quality/ca1408-do-not-use-autodual-classinterfacetype.md)  
  
## <a name="see-also"></a>Vea también  
 [Habilitar tipos de .NET para la interoperación](/dotnet/framework/interop/qualifying-net-types-for-interoperation)   
 [Interoperating with Unmanaged Code](/dotnet/framework/interop/index) (Interoperar con código no administrado)