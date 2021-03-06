---
title: "Linting de código de R con Herramientas de R para Visual Studio | Microsoft Docs"
ms.custom: 
ms.date: 12/04/2017
ms.reviewer: 
ms.suite: 
ms.technology: devlang-r
ms.devlang: r
ms.tgt_pltfrm: 
f1_keywords: vs.toolsoptionspages.text_editor.r.lint
ms.topic: article
caps.latest.revision: "1"
author: kraigb
ms.author: kraigb
manager: ghogen
ms.workload: data-science
ms.openlocfilehash: 76f4ceb040e62e4ebac46e8a791f5dac0d73aff5
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="linting-r-code-in-visual-studio"></a>Linting de código de R en Visual Studio

Linting es un proceso que analiza el código para mostrar posibles errores, así como problemas de formato y otros ruidos en archivos de código (por ejemplo, espacio en blanco falso). El linting también ayuda a promover ciertas convenciones de codificación (por ejemplo, cómo se denominan los identificadores) lo que es muy útil en equipos y otras situaciones de colaboración.

Las herramientas de R para Visual Studio (RTVS) proporcionan linting integrado para R, cuyo comportamiento se controla a través de una serie de opciones. Estas opciones se encuentran en **Herramientas > Opciones > Editor de texto > R > Lint**.

El linting está deshabilitado de manera predeterminada. Para habilitar el linting, establezca la opción **Todos > Habilitar lint** en true. En las secciones siguientes de este tema se describen todas las demás opciones de linting:

Cuando se habilita, el linting se aplica en el editor mientras se escribe. Los problemas aparecen como líneas onduladas de color verde. En el gráfico siguiente, por ejemplo, RTVS ha identificado seis problemas de linting, incluido el uso de `=` en lugar de `<-` para una asignación, la falta de espacio alrededor de los argumentos de función, el uso de identificadores en Pascal Case y mayúsculas, y el uso de punto y coma. Al mantener el puntero sobre un problema, se proporciona una descripción.

![Ejemplos de linting para código de R](media/linting-01.png)

## <a name="assignment-group"></a>Grupo de asignación

| Opción | Valor predeterminado | Efecto del linting |
| --- | --- | --- |
| Exigir \<- | `True` | Identifica cuándo no se usa `<-` para la asignación. |

## <a name="naming-group"></a>Grupo de nomenclatura

Estas opciones marcan los identificadores que usan convenciones de nomenclatura diferentes:

| Opción | Valor predeterminado | Efecto del linting |
| --- | --- | --- |
| Marcar camelCase | `False` | Marca los identificadores que usan camelCase. |
| Marcar nombres largos | `False` | Marca los identificadores cuyo nombre supera el valor "Longitud de nombre máxima". |
| Marcar varios puntos | `True` | Marca los identificadores que usan varios puntos. |
| Marcar PascalCase | `True` | Marca los identificadores que usan PascalCase. |
| Marcar snake_case | `False` | Marca los identificadores que usan caracteres de subrayado. |
| Marcar mayúsculas | `True` | Marca los identificadores que usan todo mayúsculas. |
| Longitud máxima de nombre | 32 | La longitud que se aplica con el valor "Marcar nombres largos". |

## <a name="spacing-group"></a>Grupo de espaciado

Estas opciones, que todas se establecen en `True` de forma predeterminada, controlan dónde identifica el linter los problemas de espaciado: después de los nombres de función, alrededor de comas y operadores, posiciones de llaves de apertura y cierre, espacio antes de ( y espacio dentro de ().

## <a name="statements-group"></a>Grupo de instrucciones

| Opción | Valor predeterminado | Efecto del linting |
| --- | --- | --- |
| Múltiple | `True` | Identifica cuándo hay varias instrucciones en la misma línea. |
| Puntos y coma | `True` | Identifica los usos de puntos y coma. |

## <a name="text-group"></a>Grupo de texto

| Opción | Valor predeterminado | Efecto del linting |
| --- | --- | --- |
| Límite de longitud de línea | `False` | Establece si el linter marcas líneas más largas que la opción "Longitud máxima de línea". |
| Longitud máxima de línea | 80 | Establece la longitud de línea que se aplica con la opción "Límite de longitud de línea". |

## <a name="whitespace-group"></a>Grupo de espacio en blanco

Estas opciones, que todas se establecen en `True` de forma predeterminada, controlan dónde identifica el linter los problemas de espacio en blanco: uso de tabulaciones, uso de comillas dobles, líneas vacías al final y espacios en blanco al final.