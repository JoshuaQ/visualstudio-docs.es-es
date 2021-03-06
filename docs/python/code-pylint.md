---
title: Uso de PyLint en Visual Studio | Microsoft Docs
ms.custom: 
ms.date: 07/12/2017
ms.reviewer: 
ms.suite: 
ms.technology: devlang-python
ms.devlang: python
ms.tgt_pltfrm: 
ms.topic: article
caps.latest.revision: "1"
author: kraigb
ms.author: kraigb
manager: ghogen
ms.workload:
- python
- data-science
ms.openlocfilehash: f5e915e5f1ba642449cb1232d94699069996f6b7
ms.sourcegitcommit: 11740fed01cc602252ef698aaa11c07987b00570
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 01/12/2018
---
# <a name="using-pylint-to-check-python-code"></a>Uso de PyLint para comprobar el código de Python

[PyLint](https://www.pylint.org/), una herramienta ampliamente usada que busca errores en el código de Python y promueve patrones correctos de codificación en Python, se integra en proyectos de Visual Studio para Python.

Simplemente haga clic con el botón derecho en un proyecto de Python en el Explorador de soluciones y seleccione **Python > Run PyLint... (Ejecutar PyLint...)** :

![Comando PyLint en el menú contextual para proyectos de Python](media/code-pylint-command.png)

Al usar este comando se le pide que instale PyLint en su entorno activo si todavía no está presente.

Aparecen errores y advertencias de PyLint en la ventana de lista de errores:

![Lista de errores de PyLint](media/code-pylint-error-list.png)

Al hacer doble clic en un error se le dirigirá directamente al código fuente que ha generado el problema.

> [!Tip]
> Consulte la [referencia de características de PyLint](https://pylint.readthedocs.io/en/latest/technical_reference/features.html) para obtener una lista detallada de todos los mensajes de salida de PyLint.

## <a name="setting-pylint-command-line-options"></a>Configuración de las opciones de línea de comandos de PyLint

En la sección de [opciones de línea de comandos](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) de la documentación de PyLint se describe cómo controlar el comportamiento de PyLint mediante un archivo de configuración `.pylintrc`. Este archivo se puede colocar en la raíz de un proyecto de Python en Visual Studio, o bien en alguna otra parte, según cuán extensamente se quiera aplicar esa configuración (vea las [opciones de línea de comandos](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) para obtener más información).

Por ejemplo, para suprimir las advertencias "falta docstring" que se muestran en la imagen anterior con un archivo `.pylintrc` en un proyecto, realice los pasos:

1. En la línea de comandos, vaya a la raíz del proyecto (que contiene su archivo `.pyproj`) y ejecute el siguiente comando para generar un archivo de configuración comentado:

   ```command
   pylint --generate-rcfile > .pylintrc
   ```

1. En el Explorador de soluciones de Visual Studio, haga clic con el botón derecho en el proyecto, seleccione **Agregar > Elemento existente...** , vaya al nuevo archivo `.pylintrc`, selecciónelo y haga clic en **Agregar**.

1. Abra el archivo para editarlo; que contiene una variedad de opciones de configuración con las que puede trabajar. Para deshabilitar una advertencia, busque la sección `[MESSAGES CONTROL]` y luego el valor `disable` en esa sección. Existe una cadena larga de mensajes concretos, a la que se puede anexar cualquier advertencia que quiera. En este ejemplo, anexe `,missing-docstring` (incluida la coma de delimitación).

1. Guarde el archivo `.pylintrc` y ejecute PyLint de nuevo para ver que ahora las advertencias se han suprimido.

> [!Tip]
> Para usar un archivo `.pylintrc` desde un recurso compartido de red, cree una variable de entorno denominada `PYLINTRC` con el valor del nombre de archivo en el recurso compartido de red con una ruta de acceso UNC o una letra de unidad asignada. Por ejemplo: `PYLINTRC=\\myshare\python\.pylintrc`.
