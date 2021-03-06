---
title: "Mediante el Diseñador de flujo de trabajo heredado | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: reference
helpviewer_keywords: Visual Studio 2005 Extensions for Windows Workflow Foundation, about
ms.assetid: 7af53077-afd7-465f-9c1d-b387e9d4f216
caps.latest.revision: "10"
author: ErikRe
ms.author: erikre
manager: erikre
ms.workload: multiple
ms.openlocfilehash: 7faec3b7a6bf33886928034e1f68ab31c7a60b03
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="using-the-legacy-workflow-designer"></a>Usar el Diseñador de flujo de trabajo heredado
El [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] heredado proporcionado por [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] se puede usar para tener como destino [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] o [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 Se tiene acceso seleccionando la opción el **.NET Framework 3.0** opción o **.NET Framework 3.5** opción en la lista desplegable lista en la parte superior de la **nuevo proyecto** ventana. La opción predeterminada de [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] es **.NET Framework 4** que se usa para crear [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] las aplicaciones que tienen como destino el [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)].  
  
 [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] proporciona una manera de crear gráficamente aplicaciones de [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] mediante la conocida interfaz de usuario de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] las aplicaciones de flujo de trabajo están formadas por pasos de proceso de flujo de trabajo denominados actividades. Para crear un flujo de trabajo, cree actividades en la superficie de diseño arrastrando sus diseñadores de actividad correspondientes desde **cuadro de herramientas** a la superficie de diseño.  
  
 En la siguiente tabla se enumeran las características clave de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] para Windows Workflow Foundation.  
  
|Característica|Descripción|  
|-------------|-----------------|  
|Arrastrar y colocar actividad|Arrastre las actividades desde el **cuadro de herramientas** a la superficie de diseño para crear un flujo de trabajo.|  
|Examinador de propiedades|El estándar **propiedades** ventana en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] se utiliza para configurar las propiedades de una actividad.|  
|Zoom|Los prismáticos **nivel de Zoom** se encuentra debajo de la barra de desplazamiento vertical en el lado derecho de la superficie de diseño. Haga clic en los prismáticos y seleccione un porcentaje de zoom para ampliar o reducir el gráfico del flujo de trabajo. También puede usar el **Pan** opciones de cursor de icono de lupa para acercar y alejar.|  
|Movimiento panorámico|El **Pan** , un círculo con cuatro flechas cruzadas que señalan cuatro direcciones, que se encuentra debajo de la barra de desplazamiento vertical en el lado derecho de la superficie de diseño, debajo del icono de zoom de prismáticos. Si hace clic en el icono de panorámica, aparece un menú emergente con las opciones de cursor siguientes:<br /><br /> -El **acercar** cursor de lupa le permite acercar haciendo clic en la superficie de diseño.<br />-El **alejar** cursor de lupa le permite alejar haciendo clic en la superficie de diseño.<br />-El **herramienta de exploración** cursor de mano que le permite "agarrar" y desplazar la vista de un flujo de trabajo en la superficie de diseño.<br />-El **predeterminado** cursor de flecha permite cambiar de los demás cursores al cursor de flecha predeterminado.|  
|Desplazamiento automático|Si tiene un flujo de trabajo grande, podría desear colocar una actividad más allá de la presentación visible del área de superficie de diseño. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] le permite arrastrar una actividad hacia el borde de la superficie de diseño más cercano al lugar donde desea colocar la actividad. La vista de superficie de diseño se desplaza automáticamente en esa dirección.|  
|Etiquetas inteligentes|Las actividades que no se configuran totalmente o cuya configuración no sea válida se marcan con un icono de signo de exclamación. Puede hacer clic en el icono y ver una lista desplegable con las necesidades de configuración de la actividad. A continuación, puede usar el **propiedades** ventana para configurar adecuadamente la actividad. Cuando todas las propiedades son válidas para la actividad, el icono de signo de exclamación desaparece.|  
  
## <a name="in-this-section"></a>En esta sección  
 [Ventanas de flujo de trabajo de Visual Studio (heredado)](../workflow-designer/visual-studio-workflow-windows-legacy.md)  
  
 [Crear proyectos de flujo de trabajo heredados](../workflow-designer/creating-legacy-workflow-projects.md)  
  
 [Vistas de flujos de trabajo secuenciales (heredado)](../workflow-designer/sequential-workflow-views-legacy.md)  
  
 [Actividades de flujo de trabajo heredadas](../workflow-designer/legacy-workflow-activities.md)  
  
 [Usar temas en los flujos de trabajo (heredado)](../workflow-designer/using-themes-in-workflows-legacy.md)  
  
 [Usar el diseñador de flujo de trabajo de máquina de estados heredado](../workflow-designer/using-the-legacy-state-machine-workflow-designer.md)  
  
 [Usar el diseñador de actividad Legacy](../workflow-designer/using-the-legacy-activity-designer.md)  
  
 [Ayuda de la interfaz de usuario del diseñador heredado para Windows Workflow Foundation](../workflow-designer/legacy-designer-for-windows-workflow-foundation-ui-help.md)  
  
## <a name="see-also"></a>Vea también  
 [Desarrollo de flujos de trabajo](http://go.microsoft.com/fwlink?LinkID=65010)