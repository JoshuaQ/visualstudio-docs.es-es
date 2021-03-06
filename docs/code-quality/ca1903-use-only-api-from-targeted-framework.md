---
title: 'CA1903: Usar solo API de .NET framework de destino | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- UseOnlyAPIFromTargetedFramework
- CA1903
helpviewer_keywords:
- UseOnlyApiFromTargetedFramework
- CA1903
ms.assetid: efdb5cc7-bbd8-4fa7-9fff-02b91e59350e
caps.latest.revision: "8"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: d20496fae54b0fdf2b0f0d17de0590c325bab0ee
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca1903-use-only-api-from-targeted-framework"></a>CA1903: Usar solo API de la versión de .NET Framework de destino
|||  
|-|-|  
|TypeName|UseOnlyApiFromTargetedFramework|  
|Identificador de comprobación|CA1903|  
|Categoría|Microsoft.Portability|  
|Cambio problemático|Problemático: cuando se activa con la firma de un miembro visible externamente o tipo.<br /><br /> No problemático: cuando se desencadena en el cuerpo de un método.|  
  
## <a name="cause"></a>Motivo  
 Un miembro o tipo utiliza un miembro o tipo que se introdujo en un service pack que no se incluye con .NET framework de destino del proyecto.  
  
## <a name="rule-description"></a>Descripción de la regla  
 Tipos y miembros nuevos se han incluido en .NET Framework 2.0 Service Pack 1 y 2, .NET Framework 3.0 Service Pack 1 y 2 y .NET Framework 3.5 Service Pack 1. Los proyectos que tienen como destino las versiones principales de .NET Framework pueden tomar dependencias involuntariamente en estas nuevas API. Para evitar esta dependencia, esta regla se desencadena en los usos de los nuevos miembros y tipos que no se incluyen con .NET framework de destino del proyecto de forma predeterminada.  
  
 **.NET Framework de destino y las dependencias del módulo de servicio**  
  
|||  
|-|-|  
|Cuando es .NET framework de destino|Se desencadena cuando se usan miembros presentados en|  
|.NET Framework 2.0|.NET framework 2.0 SP1, .NET Framework 2.0 SP2|  
|.NET Framework 3.0|.NET framework 2.0 SP1, Service Pack 2 de .NET Framework 2.0, .NET Framework 3.0 SP1, .NET Framework 3.0 SP2|  
|.NET Framework 3,5|.NET Framework 3.5 SP1|  
|.NET Framework 4|N/D|  
  
 Para cambiar la plataforma de destino del proyecto, consulte [como destino una versión específica de .NET Framework](../ide/targeting-a-specific-dotnet-framework-version.md).  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para quitar la dependencia en el service pack, quite todos los usos del nuevo miembro o tipo. Si se trata de una dependencia deliberada, suprimir la advertencia o desactivar esta regla.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 No suprima las advertencias de esta regla si no se trata de una dependencia deliberada en el módulo de servicio especificado. En esta situación, la aplicación podría no ejecutarse en sistemas sin este service pack instalado. Suprimir la advertencia o desactivar esta regla si se trata de una dependencia deliberada.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra una clase que utiliza el tipo DateTimeOffset que solo está disponible en .NET 2.0 Service Pack 1. Este ejemplo requiere que .NET Framework 2.0 se ha seleccionado en la lista desplegable de .NET Framework de destino en las propiedades del proyecto.  
  
 [!code-csharp[FxCop.Portability.UseOnlyApiFromTargetedFramework#1](../code-quality/codesnippet/CSharp/ca1903-use-only-api-from-targeted-framework_1.cs)]  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se corrige la infracción descrita previamente reemplazando los usos del tipo DateTimeOffset con el tipo de fecha y hora.  
  
 [!code-csharp[FxCop.Portability.UseOnlyApiFromTargetedFramework2#1](../code-quality/codesnippet/CSharp/ca1903-use-only-api-from-targeted-framework_2.cs)]  
  
## <a name="see-also"></a>Vea también  
 [Advertencias de portabilidad](../code-quality/portability-warnings.md)   
 [Elegir una versión específica de .NET Framework](../ide/targeting-a-specific-dotnet-framework-version.md)