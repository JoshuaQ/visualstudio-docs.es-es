---
title: Usar IntelliSense | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vc.tools.intellisense
helpviewer_keywords:
- IntelliSense, Complete Word
- IntelliSense, completion mode
- parameter information
- IntelliSense, List Members
- Quick Info
- Parameter Info
- IntelliSense [Visual Studio]
- IntelliSense, suggestion mode
- IntelliSense, Parameter Info
- IntelliSense, customizing
- Complete Word
- IntelliSense
- List Members
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 1423e3db18a3849fdcbf93bf0a4299a0f743b242
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="using-intellisense"></a>Using IntelliSense

IntelliSense es el término general que se usa para describir varias características: Lista de miembros, Información de parámetros, Información rápida y Palabra completa. Estas características le permiten obtener más información acerca del código que utiliza, a realizar un seguimiento de los parámetros que escribe y a agregar llamadas a propiedades y a métodos con tan solo presionar unas teclas.

Muchos aspectos de IntelliSense son específicos del lenguaje. Para más información sobre IntelliSense para distintos lenguajes, vea los temas enumerados en la sección [Vea también](#see-also).

## <a name="list-members"></a>Lista de miembros

Después de escribir un carácter desencadenador (por ejemplo, un punto (`.`) en código administrado o `::` en C++), aparece una lista de los miembros válidos de un tipo (o espacio de nombres). Si sigue escribiendo caracteres, la lista se filtrará y solo incluirá los miembros que empiecen por esos caracteres o donde el principio de *cualquier* palabra del nombre empiece por esos caracteres. IntelliSense también efectúa búsquedas de coincidencias "camel case", por lo que puede escribir la primera letra de cada palabra con camel case del nombre del miembro para ver las coincidencias.

Después de seleccionar un elemento, puede insertarlo en el código presionando la tecla **TAB** o insertando un espacio. Si selecciona un elemento y escribe un punto, el elemento aparece seguido del punto, con lo que se muestra otra lista de miembros. Cuando seleccione un elemento, obtendrá la información rápida del mismo antes de insertarlo.

En la lista de miembros, el icono de la izquierda representa el tipo del miembro, como el espacio de nombres, la clase, la función o la variable. Para ver una lista de iconos, vea [Iconos de la vista de clases y del examinador de objetos](../ide/class-view-and-object-browser-icons.md). La lista puede ser bastante larga, así que presione **Re Pág** y **Av Pág** para subir o bajar en ella.

![Lista de miembros de Visual Studio](../ide/media/vs2015_intellisense.png "vs2015_Intellisense")

Puede invocar la característica **Lista de miembros** manualmente. Para ello, presione **CTRL** + **J** y elija **Edición** > **IntelliSense** > **Lista de miembros** o seleccione el botón **Lista de miembros** de la barra de herramientas del editor. Cuando se invoca en una línea en blanco o fuera de un ámbito reconocible, la lista muestra símbolos del espacio de nombres global.

Para desactivar la lista de miembros de forma predeterminada (de manera que no aparezca a menos que se invoque específicamente), vaya a **Herramientas** > **Opciones** > **Todos los lenguajes** y anule la selección de **Lista de miembros automática**. Si quiere desactivar la lista de miembros únicamente para un lenguaje concreto, vaya a la configuración **General** de ese lenguaje.

También puede cambiar al modo de sugerencias, en el que solo se inserta en el código el texto que se escribe. Por ejemplo, si escribe en un identificador que no está en la lista y presiona la tecla **TAB** en modo de finalización, la entrada reemplaza al identificador escrito. Para alternar entre el modo de finalización y el modo de sugerencias, presione **CTRL** + **Alt** + **BARRA ESPACIADORA** o seleccione **Edición** > **IntelliSense** > **Alternar el modo de finalización**.

## <a name="parameter-info"></a>Información de parámetros

La información de parámetros proporciona información acerca del número, los nombres y los tipos de parámetros que requiere un método, un parámetro de tipo genérico de atributo (en C#) o una plantilla (en C++).

El parámetro en negrita indica el siguiente parámetro requerido a medida que escribe la función. En el caso de funciones sobrecargadas, se puede utilizar las teclas de flecha ARRIBA y ABAJO para ver información de parámetros alternativos para las sobrecargas de funciones.

![Información de parámetros](../ide/media/vs2015_param_info.png "VS2015_param_Info")

Cuando se anotan funciones y parámetros con comentarios de documentación XML, los comentarios se muestran como Información de parámetros. Para obtener más información, vea [Proporcionar comentarios del código XML](../ide/supplying-xml-code-comments.md).

Para invocar manualmente la información de parámetros, elija **Edición** > **IntelliSense** > **Información de parámetros**, presione **CTRL** + **MAYÚS** + **BARRA ESPACIADORA** o seleccione el botón **Información de parámetros** de la barra de herramientas del editor.

## <a name="quick-info"></a>Información rápida

La opción Información rápida muestra la declaración completa de cualquier identificador del código.

![Información rápida de Visual Studio](../ide/media/vs2015_quick_info.png "VS2015_Quick_info")

Cuando se selecciona un miembro en el cuadro **Lista de miembros**, también aparece la información rápida.

![Información de parámetros en un archivo de código de C&#35;](../ide/media/vs2015_paraminfo.png "VS2015_ParamInfo")

Para invocar manualmente la información rápida, elija **Edición** > **IntelliSense** > **Información rápida**, presione **CTRL** + **I** o seleccione el botón **Información rápida** de la barra de herramientas del editor.

Si una función está sobrecargada, es posible que IntelliSense no muestre información para todas las formas de la sobrecarga.

Para desactivar información rápida del código de C++, vaya a **Herramientas** > **Opciones** > **Editor de texto** > **C/C++** > **Avanzadas** y establezca **Información rápida automática** en `false`.

## <a name="complete-word"></a>Palabra completa

La opción Palabra completa escribe el resto del nombre de una variable, un comando o una función después de que haya escrito suficientes caracteres como para reconocerlo. Para invocar la función de palabra completa, elija **Edición** > **IntelliSense** > **Palabra completa**, presione **CTRL** +  **BARRA ESPACIADORA** o seleccione el botón **Palabra completa** de la barra de herramientas del editor.

## <a name="intellisense-options"></a>Opciones de IntelliSense

Las opciones de IntelliSense están activadas de forma predeterminada. Para desactivarla, haga clic en **Herramientas** > **Opciones** > **Editor de texto** y anule la selección de **Información de parámetros** o de **Lista de miembros automática** si no quiere usar la característica Lista de miembros.

## <a name="troubleshooting-intellisense"></a>Solución de problemas de IntelliSense

En algunos casos, es posible que las opciones de IntelliSense no funcionen como esperaba.

**El cursor está debajo de un error de código.** Quizá no pueda usar IntelliSense si existe una función incompleta u otro error en el código encima del cursor, ya que IntelliSense no puede analizar los elementos del código. Puede resolver este problema marcando como comentario el código correspondiente.

**El cursor está en un comentario de código.** No puede usar IntelliSense si el cursor está en un comentario del archivo de código fuente.

**El cursor está en un literal de cadena.** No puede usar IntelliSense si el cursor está en las comillas de un literal de cadena, como en el siguiente ejemplo:

```cpp
MessageBox( hWnd, "String literal|")
```

**Las opciones automáticas están desactivadas.** De forma predeterminada, IntelliSense funciona automáticamente, pero puede deshabilitarlo. También puede invocar una característica IntelliSense incluso cuando la finalización de instrucciones automática se encuentre deshabilitada.

## <a name="see-also"></a>Vea también

[Opciones de IntelliSense específicas de Visual Basic](../ide/visual-basic-specific-intellisense.md)  
[IntelliSense para Visual C#](../ide/visual-csharp-intellisense.md)  
[IntelliSense para JavaScript](../ide/javascript-intellisense.md)  
[Escribir y refactorizar código (C++)](/cpp/ide/writing-and-refactoring-code-cpp)  
[Proporcionar comentarios del código XML](../ide/supplying-xml-code-comments.md)
