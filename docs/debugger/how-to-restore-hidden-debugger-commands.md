---
title: "C&#243;mo: Restaurar los comandos ocultos del depurador | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "comandos, depurador"
  - "depurador, restaurar comandos"
  - "depurar [Visual Studio], restaurar comandos"
ms.assetid: 76ac9b77-f536-43b5-a9fc-984854b1c566
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
caps.handback.revision: 11
---
# C&#243;mo: Restaurar los comandos ocultos del depurador
[!INCLUDE[vs2017banner](../code-quality/includes/vs2017banner.md)]

Cuando se configura Visual Studio, se solicita la elección de un conjunto de configuraciones IDE predeterminadas para el lenguaje de programación principal.  Las configuraciones IDE predeterminadas para algunos lenguajes pueden ocultar ciertos comandos del depurador.  
  
 Si desea utilizar una característica del depurador oculta por la configuración de IDE predeterminada, puede agregar de nuevo el comando al menú utilizando el procedimiento siguiente.  
  
### Restablecer comandos ocultos del depurador  
  
1.  Con un proyecto abierto, en el menú **Herramientas**, haga clic en **Personalizar**.  
  
2.  En el cuadro de diálogo **Personalizar**, haga clic en la ficha **Comandos**.  
  
3.  En el desplegable **Barra de menús:**, seleccione el menú **Depurar** que desea que contenga el comando restaurado.  
  
4.  Haga clic en el botón **Agregar comando...**.  
  
5.  En el cuadro **Agregar comando**, seleccione el comando que desee agregar y, a continuación, haga clic en **Aceptar**.  
  
6.  Repita el paso anterior para agregar otro comando.  
  
7.  Haga clic en **Cerrar** cuando termine de agregar comandos al menú.  
  
    > [!WARNING]
    >  Algunos elementos de menú sólo aparecen cuando el depurador se encuentra en modos concretos, como el modo de ejecución o el modo de interrupción.  Por consiguiente, es posible que un elemento agregado no sea visible inmediatamente después de realizar estos pasos.  
  
## Restablecer los comandos no disponibles en el cuadro de diálogo Personalizar  
 Algunos comandos, sobre todo los que se encuentran en los menús jerárquicos, no se pueden restaurar en el cuadro de diálogo **Personalizar**.  Para restaurarlos, debe importar una nueva colección de configuraciones IDE.  
  
#### Para importar nuevas configuraciones IDE  
  
1.  En el menú **Herramientas**, haga clic en **Importar y exportar configuraciones**.  
  
2.  En la página **Asistente para importar y exportar configuraciones**, haga clic en **Importar la configuración de entorno seleccionada** y, a continuación, haga clic en **Siguiente**.  
  
3.  En la página **Guardar configuración actual**, guarde la configuración actual si lo desea y, a continuación, haga clic en **Siguiente**.  
  
4.  En la página **Elija una colección de configuraciones para importar**, bajo la carpeta **Configuración predeterminada**, seleccione la colección de configuraciones de desarrollo que incluya los comandos que desee utilizar.  Si no sabe qué colección utilizar, pruebe con **Configuración general de desarrollo** o **Configuración de desarrollo de Visual C\+\+**, que ofrecen los comandos de depuración más comunes.  
  
5.  Haga clic en **Siguiente**.  
  
6.  En la página **Elija la configuración que desee importar**, bajo **Opciones**, asegúrese de que la opción **Depuración** está seleccionada.  Desactive las otras casillas, a menos que también desee importar dicha configuración.  
  
7.  Haga clic en **Finalizar**.  
  
8.  En la página **Importación completada**, revise cualquier error asociado con el restablecimiento de la configuración bajo **Detalles**.  
  
9. Haga clic en **Cerrar**.  
  
## Vea también  
 [Seguridad del depurador](../debugger/debugger-security.md)   
 [Conceptos básicos del depurador](../debugger/debugger-basics.md)