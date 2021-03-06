---
title: Propiedades de las relaciones de dominio | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: Domain-Specific Language, domain relationships
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 3f81f4bca6d268cd9fd32a6edf44cbde40d7c357
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="properties-of-domain-relationships"></a>Propiedades de las relaciones de dominio
Las propiedades en la siguiente tabla están asociadas con una relación de dominio. Para obtener información acerca de las relaciones de dominio, consulte [descripción de los modelos, las clases y relaciones](../modeling/understanding-models-classes-and-relationships.md). Para obtener más información acerca de cómo utilizar estas propiedades, vea [personalizar y ampliar un lenguaje específico de dominio](../modeling/customizing-and-extending-a-domain-specific-language.md).  
  
|Property|Descripción|Default|  
|--------------|-----------------|-------------|  
|Modificador de acceso|El nivel de acceso de la relación de dominio (`public` o `internal`).|`public`|  
|Atributos personalizados|Se utiliza para agregar atributos a la clase de código de origen que se genera a partir de la relación de dominio.|\<Ninguno >|  
|Genera doble derivadas|Si `True`, se genera una clase base y una clase parcial (para admitir la personalización mediante invalidaciones). Para obtener más información, consulte [reemplazar y ampliar las clases generadas](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|  
|Tiene un Constructor personalizado|Si `True`, indica que se proporciona un constructor personalizado en el código fuente. Para obtener más información, consulte [reemplazar y ampliar las clases generadas](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|  
|Modificador de herencia|Describe el tipo de herencia de la clase de código de origen que se genera a partir de la relación de dominio (`none`, `abstract` o `sealed`).|\<Ninguno >|  
|Permite duplicados|Si `True`, se crearán vínculos duplicados de la relación de dominio entre los dos mismos elementos.|`False`|  
|Relaciones de base|Si se deriva la relación de dominio, la relación de base de la relación de dominio.|\<Ninguno >|  
|Es incrustar|Si `True`, la relación de dominio es una relación de incrustación. Si `False`, la relación es una relación de referencia.|\<ambos >|  
|nombre|El nombre de la relación de dominio.|Nombre actual|  
|Espacio de nombres|El espacio de nombres que está afiliado a la relación de dominio.|Espacio de nombres actual|  
|Notas|Notas informales que están asociadas a la relación de dominio.|\<Ninguno >|  
|Descripción|La descripción que se usa para documentar código y se usa en la interfaz de usuario del diseñador generado.|\<Ninguno >|  
|Nombre para mostrar|El nombre que se muestra en el diseñador generado para la relación de dominio.|\<Ninguno >|  
|Help Keyword|La palabra clave opcional que se utiliza para indizar la Ayuda de F1 para la relación de dominio.|\<Ninguno >|  
  
## <a name="see-also"></a>Vea también  
 [Glosario de herramientas de lenguaje específico de dominio](http://msdn.microsoft.com/en-us/ca5e84cb-a315-465c-be24-76aa3df276aa)