---
title: "CA2112: Los tipos seguros no deberían exponer campos | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- CA2112
- SecuredTypesShouldNotExposeFields
helpviewer_keywords:
- SecuredTypesShouldNotExposeFields
- CA2112
ms.assetid: 9eb13a78-3487-49f2-81d1-3c3866db132f
caps.latest.revision: "15"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: e3959540d00a74d99095a3facf824d822827a00d
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca2112-secured-types-should-not-expose-fields"></a>CA2112: Los tipos seguros no deberían exponer campos
|||  
|-|-|  
|TypeName|SecuredTypesShouldNotExposeFields|  
|Identificador de comprobación|CA2112|  
|Categoría|Microsoft.Security|  
|Cambio problemático|Problemático|  
  
## <a name="cause"></a>Motivo  
 Un tipo público o protegido contiene campos públicos y está protegido por un [peticiones de vínculo](/dotnet/framework/misc/link-demands).  
  
## <a name="rule-description"></a>Descripción de la regla  
 Si el código tiene acceso a una instancia de tipo que está protegida por una solicitud de vínculo, el código no cumplirá la solicitud para obtener acceso a los campos del tipo.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, hacer que los campos no públicos y agregue propiedades o métodos que devuelven los datos del campo públicos. Comprobaciones de seguridad de LinkDemand en tipos de protegen el acceso a las propiedades y métodos del tipo. Sin embargo, la seguridad de acceso del código no se aplica a los campos.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Para problemas de seguridad y para un buen diseño, debe corregir las infracciones estableciendo el nonpublic campos públicos. Puede suprimir una advertencia de esta regla si los campos no contienen información que deba permanecer segura y no se debe confiar en el contenido del campo.  
  
## <a name="example"></a>Ejemplo  
 En el siguiente ejemplo se compone de un tipo de biblioteca (`SecuredTypeWithFields`) con campos no seguros, un tipo (`Distributor`) que pueden crear instancias del tipo de biblioteca y pasa erróneamente instancias a tipos no tiene permiso para crearlas y que el código de aplicación puede leer los campos de la instancia incluso aunque no tenga el permiso que protege el tipo.  
  
 El código de biblioteca siguiente infringe la regla.  
  
 [!code-csharp[FxCop.Security.LinkDemandOnField#1](../code-quality/codesnippet/CSharp/ca2112-secured-types-should-not-expose-fields_1.cs)]  
  
## <a name="example"></a>Ejemplo  
 La aplicación no puede crear una instancia debido a la petición de vínculo que protege el tipo. La siguiente clase habilita la aplicación para obtener una instancia del tipo protegido.  
  
 [!code-csharp[FxCop.Security.LDOnFieldsDistributor#1](../code-quality/codesnippet/CSharp/ca2112-secured-types-should-not-expose-fields_2.cs)]  
  
## <a name="example"></a>Ejemplo  
 La aplicación siguiente muestra cómo hacerlo, sin permiso para tener acceso a los métodos de un tipo seguro, código puede tener acceso a sus campos.  
  
 [!code-csharp[FxCop.Security.TestLinkDemandOnFields#1](../code-quality/codesnippet/CSharp/ca2112-secured-types-should-not-expose-fields_3.cs)]  
  
 Este ejemplo produce el siguiente resultado:  
  
 **Crear una instancia de SecuredTypeWithFields.**  
**Campos de tipo protegidos: 22, 33**  
**Cambiar el campo de tipo protegido...**  
**Almacena en caché los campos de objeto: 99, 33**   
## <a name="related-rules"></a>Reglas relacionadas  
 [CA1051: No declarar campos de instancia visibles](../code-quality/ca1051-do-not-declare-visible-instance-fields.md)  
  
## <a name="see-also"></a>Vea también  
 [Peticiones de vínculo](/dotnet/framework/misc/link-demands)   
 [Datos y modelado](/dotnet/framework/data/index)