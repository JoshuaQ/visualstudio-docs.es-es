---
title: Propiedades de clases de dominio | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: Domain-Specific Language, domain class
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: a05c63cdfe3fba48f4a26198dd1698691671750b
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="properties-of-domain-classes"></a>Propiedades de las clases de dominio
Clases de dominio tienen las propiedades en la tabla siguiente. Para obtener información acerca de las clases de dominio, consulte [descripción de los modelos, las clases y relaciones](../modeling/understanding-models-classes-and-relationships.md). Para obtener más información acerca de cómo utilizar estas propiedades, vea [personalizar y ampliar un lenguaje específico de dominio](../modeling/customizing-and-extending-a-domain-specific-language.md).  
  
|Property|Descripción|Default|  
|--------------|-----------------|-------------|  
|Modificador de acceso|Nivel de acceso de la clase de dominio (`public` o `internal`).|`public`|  
|Atributos personalizados|Se utiliza para agregar atributos a la clase de código de origen que se genera a partir de esta clase de dominio.|\<Ninguno >|  
|Genera doble derivadas|Si `True`, se generará una clase base y una clase parcial (para admitir la personalización mediante invalidaciones). Para obtener más información, consulte [reemplazar y ampliar las clases generadas](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|  
|Tiene un Constructor personalizado|Si `True`, se proporciona un constructor personalizado en el código fuente. Para obtener más información, consulte [reemplazar y ampliar las clases generadas](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|  
|Modificador de herencia|Describe el tipo de herencia de la clase de código de origen que se genera a partir de la clase de dominio (`none`, `abstract` o `sealed`).|`none`|  
|Clase base|Si se deriva esta clase de dominio, el nombre de la clase base.|\<Ninguno >|  
|nombre|El nombre de esta clase de dominio.|Nombre actual|  
|Espacio de nombres|El espacio de nombres de esta clase de dominio.|Espacio de nombres actual|  
|Notas|Notas informales que están asociadas a esta clase de dominio.|\<Ninguno >|  
|Descripción|La descripción que se utiliza para documentar la interfaz de usuario del diseñador generado.|\<Ninguno >|  
|Nombre para mostrar|El nombre que se mostrará en el diseñador generado para esta clase de dominio.|\<Ninguno >|  
|Help Keyword|La palabra clave opcional que se utiliza para indizar la Ayuda F1 para esta clase de dominio.|\<Ninguno >|  
  
## <a name="see-also"></a>Vea también  
 [Glosario de herramientas de lenguaje específico de dominio](http://msdn.microsoft.com/en-us/ca5e84cb-a315-465c-be24-76aa3df276aa)