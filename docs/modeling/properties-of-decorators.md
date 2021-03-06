---
title: Propiedades de decoradores | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: Domain-Specific Language, decorators
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 7f5bd86a9fe8d67111886e7578187747b1ea3ec8
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="properties-of-decorators"></a>Propiedades de los decoradores
Decoradores son iconos, texto o comillas angulares de expandir o contraer que pueden aparecer en formas o conectores en el diagrama. Las siguientes tablas muestran las propiedades de los tres tipos de elemento decorator. Algunas de las propiedades aparecen solo en decoradores de forma o solo en decoradores de conector.  
  
 Para obtener más información, consulte [cómo definir un lenguaje específico de dominio](../modeling/how-to-define-a-domain-specific-language.md). Para obtener más información acerca de cómo utilizar estas propiedades, vea [personalizar y ampliar un lenguaje específico de dominio](../modeling/customizing-and-extending-a-domain-specific-language.md).  
  
## <a name="expandcollapse-decorator"></a>Expandir o contraer decorador  
  
|Property|Descripción|Default|  
|--------------|-----------------|-------------|  
|DisplayName|El nombre de la decorador que se mostrará en el diseñador generado.|Expanda contraer decorador|  
|nombre|El nombre de la decorador.|ExpandCollapseDecorator|  
|Notas|Notas informales que están asociadas a este decorador.|\<Ninguno >|  
|HorizontalOffset|El desplazamiento horizontal, con respecto a la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|VerticalOffset|El desplazamiento vertical, en relación con la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|OffsetFromLine|El desplazamiento de la decorador desde la línea, con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|OffsetFromShape|El desplazamiento de la decorador de la forma con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|Posición|La posición predeterminada de la decorador.|SourceTop|  
  
## <a name="icon-decorator"></a>Icono decorador  
  
|Property|Descripción|Default|  
|--------------|-----------------|-------------|  
|DefaultIcon|La ruta de acceso del archivo de icono o imagen que se mostrará.|\<Ninguno >|  
|DisplayName|El nombre del elemento decorator de la que se mostrará en el diseñador generado.|Icono decorador|  
|nombre|El nombre de la decorador.|IconDecorator|  
|Notas|Notas informales que están asociadas con el decorador.|\<Ninguno >|  
|HorizontalOffset|El desplazamiento horizontal, con respecto a la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|VerticalOffset|El desplazamiento vertical, en relación con la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|OffsetFromLine|El desplazamiento de la decorador desde la línea, con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|OffsetFromShape|El desplazamiento de la decorador de la forma con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|Posición|La posición predeterminada de la decorador.|SourceTop|  
  
## <a name="textdecorator"></a>TextDecorator  
  
|Property|Descripción|Default|  
|--------------|-----------------|-------------|  
|DefaultText|El texto predeterminado que se mostrará.|Etiqueta|  
|DisplayName|El nombre del elemento decorator de la que se mostrará en el diseñador generado.|Etiqueta|  
|FontSize|El tamaño de fuente para el texto que se muestra en el elemento decorator.|8|  
|FontStyle|El estilo de fuente para el texto que se muestra en el elemento decorator.|Estándar|  
|nombre|El nombre de la decorador.|Etiqueta|  
|Notas|Notas informales que están asociadas con el decorador.|\<Ninguno >|  
|HorizontalOffset|El desplazamiento horizontal, con respecto a la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|VerticalOffset|El desplazamiento vertical, en relación con la posición predeterminada de decorador, en pulgadas. (En formas sólo.)|0|  
|OffsetFromLine|El desplazamiento de la decorador desde la línea, con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|OffsetFromShape|El desplazamiento de la decorador de la forma con respecto a su posición de forma predeterminada, en pulgadas. (En los conectores sólo.)|0|  
|Posición|La posición predeterminada de la decorador.|TargetBottom|  
  
## <a name="see-also"></a>Vea también  
 [Glosario de herramientas de lenguaje específico de dominio](http://msdn.microsoft.com/en-us/ca5e84cb-a315-465c-be24-76aa3df276aa)