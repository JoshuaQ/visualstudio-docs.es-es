---
title: "Cuadro de diálogo de páginas de propiedades de origen archivos, propiedades comunes, solución de depurar | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: reference
f1_keywords: vs.debug.options.FindSource
dev_langs:
- CSharp
- VB
- FSharp
- C++
- JScript
- SQL
helpviewer_keywords:
- Debug Source Files property page
- debugging [Visual Studio], specifying source and symbol files
- source files, specifying in debugger
- debugger, source files
ms.assetid: 0af11464-eeb1-4d0b-87a6-0cc96779afb1
caps.latest.revision: "10"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: aa83025b15fe3773220a2b27394890318d60c850
ms.sourcegitcommit: 9e6ff74da1afd8bd2f0e69387ce81f2a74619182
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/04/2018
---
# <a name="debug-source-files-common-properties-solution-property-pages-dialog-box"></a>Depurar archivos de código fuente, Propiedades comunes, Páginas de propiedades de Solución (Cuadro de diálogo)
Esta página de propiedades especifica si el depurador buscará archivos de código fuente al depurar la solución.  
  
 Para tener acceso a la **depurar archivos de código fuente** página de propiedades, el botón secundario en la solución en **el Explorador de soluciones** y seleccione **propiedades** en el menú contextual. Expanda el **propiedades comunes** carpeta y haga clic en el **depurar archivos de código fuente** página.  
  
 **Directorios que contienen código fuente**  
 Contiene una lista de directorios en los que el depurador busca archivos de código fuente al depurar la solución. Los subdirectorios de los directorios especificados también se incluyen en la búsqueda.  
  
 **No busque estos archivos de origen**  
 Especifique los nombres de los archivos que no desea que lea el depurador. Si el depurador encuentra uno de estos archivos en uno de los directorios especificados anteriormente, lo omitirá. Si el **Buscar código fuente** cuadro de diálogo aparece mientras se está depurando y, al hacer clic en **cancelar**, el archivo que buscaba se agregará a esta lista para que el depurador no seguirá buscándolo.  
  
## <a name="see-also"></a>Vea también  
 [Seguridad del depurador](../debugger/debugger-security.md)   
 [Configuración y preparación de la depuración](../debugger/debugger-settings-and-preparation.md)