---
title: "Cuadro de diálogo Eventos de compilación (Visual Basic) | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vb.ProjectPropertiesBuildEvents
helpviewer_keywords:
- build events
- build events, specifying
- pre-build events
- Build Events dialog box
- post-build events
ms.assetid: 3a81a7c7-39f9-47a8-ba5a-b351227f380e
caps.latest.revision: "4"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: da28d0858784a8e71006c0ec072c3aea5110037e
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="build-events-dialog-box-visual-basic"></a>Eventos de compilación (Cuadro de diálogo) (Visual Basic)
Use el cuadro de diálogo **Eventos de compilación** para especificar las instrucciones de configuración de compilación. También puede especificar las condiciones en las que se ejecutan los eventos anteriores o posteriores a la compilación. Para obtener más información, vea [Cómo: Especificar eventos de compilación (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md).  
  
 **Línea de comandos del evento anterior a la compilación**  
 Especifica los comandos que se van a ejecutar antes de que empiece la compilación. Para escribir comandos largos, haga clic en **Edición anterior a la compilación** para mostrar el cuadro de diálogo [Línea de comandos del evento anterior a la compilación/Línea de comandos del evento posterior a la compilación](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md).  
  
> [!NOTE]
>  Los eventos anteriores a la compilación no se ejecutan si el proyecto está actualizado y no se desencadena ninguna compilación.  
  
 **Línea de comandos del evento posterior a la compilación**  
 Especifica los comandos que se van a ejecutar después de que finalice la compilación. Para escribir comandos largos, haga clic en **Edición posterior a la compilación** para mostrar el cuadro de diálogo **Línea de comandos del evento anterior a la compilación/Línea de comandos del evento posterior a la compilación**.  
  
> [!NOTE]
>  Agregue una instrucción `call` antes de todos los comandos posteriores a la compilación que ejecutan archivos .bat. Por ejemplo: `call C:\MyFile.bat` o `call C:\MyFile.bat call C:\MyFile2.bat`.  
  
 **Ejecutar el evento posterior a la compilación**  
 Especifica las condiciones para que se ejecute el evento posterior a la compilación, como se muestra en la tabla siguiente.  
  
|Opción|Resultado|  
|------------|------------|  
|**Siempre**|El evento posterior a la compilación se ejecuta independientemente de si la compilación se realiza correctamente.|  
|**Si la compilación es correcta**|El evento posterior a la compilación se ejecuta si la compilación se realiza correctamente. El evento se ejecutará incluso para un proyecto actualizado, siempre y cuando la compilación se realice correctamente. Ésta es la configuración predeterminada.|  
|**Cuando la compilación actualiza la salida del proyecto**|El evento posterior a la compilación solo se ejecuta si el archivo de salida del compilador (.exe o .dll) es diferente del anterior archivo de salida del compilador. Un evento posterior a la compilación no se ejecuta si un proyecto está actualizado.|  
  
## <a name="see-also"></a>Vea también  
 [Página Compilación, Diseñador de proyectos (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)   
 [Cómo: Especificar eventos de compilación (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)   
 [Cuadro de diálogo Línea de comandos del evento anterior/posterior a la compilación](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)