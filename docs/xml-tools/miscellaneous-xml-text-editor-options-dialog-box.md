---
title: "Varios, XML, Editor de texto, cuadro de diálogo Opciones | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: fd3fff31-cddc-422d-a2f0-a5a1ef492afd
caps.latest.revision: "2"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 4773bf87e89bd504b477d9a1a31dfe961a3f29ff
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="miscellaneous-xml-text-editor-options-dialog-box"></a>Varios, XML, Editor de texto, Cuadro de diálogo Opciones
Este cuadro de diálogo permite cambiar las opciones de finalización automática y esquema del Editor XML. Puede tener acceso a la **opciones** cuadro de diálogo desde el **herramientas** menú.  
  
> [!NOTE]
>  Estas opciones están disponibles cuando se selecciona el **Editor de texto** carpeta, el **XML** carpeta y, a continuación, el **varios** opción desde el **opciones** cuadro de diálogo.  
  
## <a name="auto-insert"></a>Inserción automática  
 **Etiquetas de cierre**  
 Si se activa la configuración de autocompletar, el editor agrega automáticamente una etiqueta de cierre al escribir un corchete derecho (>) para cerrar una etiqueta inicial, si la etiqueta aún no está cerrada. Éste es el comportamiento predeterminado.  
  
 La finalización de un elemento vacío no depende de la configuración de autocompletar. Siempre puede autocompletar un elemento vacío escribiendo una barra diagonal inversa (/).  
  
 **Comillas de atributo**  
 Al crear atributos XML, el editor inserta los caracteres `=" "` y coloca el carácter de intercalación (^) dentro de las comillas dobles.  
  
 Esta opción está seleccionada de forma predeterminada.  
  
 **Declaraciones de espacio de nombres**  
 El editor inserta automáticamente declaraciones de espacio de nombres siempre que se necesitan.  
  
 Esta opción está seleccionada de forma predeterminada.  
  
 **Otro marcado (comentarios, CDATA)**  
 Se completan automáticamente comentarios, CDATA, DOCTYPE, instrucciones de procesamiento y otro marcado.  
  
 Esta opción está seleccionada de forma predeterminada.  
  
## <a name="network"></a>Red  
 **Descargar automáticamente DTD y esquemas**  
 Los esquemas y las definiciones de tipo de documento (DTD) se descargan automáticamente desde ubicaciones HTTP. Esta característica utiliza System.Net con la detección automática del servidor proxy habilitada.  
  
 Esta opción está seleccionada de forma predeterminada.  
  
## <a name="outlining"></a>esquematizar  
 **Especificar el modo de esquematización al abrir los archivos**  
 Activa la característica de esquematización cuando se abre un archivo.  
  
 Esta opción está seleccionada de forma predeterminada.  
  
## <a name="caching"></a>Almacenamiento en memoria caché  
 **Esquemas**  
 Especifica la ubicación de la caché de esquema. El botón Examinar (**...** ) se abre el **mostrar directorios** cuadro de diálogo en la ubicación de caché de esquema actual. Puede seleccionar un directorio diferente, o puede seleccionar una carpeta en el cuadro de diálogo secundario y elija **abiertos** para ver las novedades en el directorio.  
  
## <a name="see-also"></a>Vea también  
 [Propiedades del documento XML, ventana Propiedades](../xml-tools/xml-document-properties-properties-window.md)   
 [Componentes del Editor XML](../xml-tools/xml-editor-components.md)