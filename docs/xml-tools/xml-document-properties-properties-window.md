---
title: Propiedades de documento XML, ventana Propiedades | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9dbb34d9-02ea-4201-b445-c98a0eb0d6db
caps.latest.revision: "2"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: ceabc30399871c7bbe7fef737e7ecbd87187257d
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="xml-document-properties-properties-window"></a>Propiedades de documentos XML, Ventana Propiedades
El **propiedades** ventana proporciona información básica sobre el documento que está activo en el Editor XML. Las propiedades disponibles pueden variar según el tipo de documento XML que esté actualmente activo.  
  
> [!NOTE]
>  Todas las propiedades del documento XML se guardan en la solución. Por tanto, no es necesario que vuelva a escribir estos valores la próxima vez que abra la solución.  
  
 **Codificación**  
 La codificación de caracteres del archivo. Si cambia esta propiedad también cambia el atributo de codificación de la declaración XML, y viceversa. La nueva codificación se utilizará para codificar el archivo cuando lo guarde.  
  
 **Entrada**  
 El documento de entrada asociado con la hoja de estilos XSLT. Lo utiliza el **ShowXSLT salida** comando. Un documento se puede seleccionar mediante el botón Examinar (**...** ) botón.  
  
 Esta propiedad solo está visible cuando hay un archivo XSLT activo en ese momento en la ventana del editor.  
  
 **Salida**  
 El archivo que se genera al transformar un documento XML.  
  
 Si no se especifica un archivo, se genera un nombre de archivo predeterminado basado en el atributo `method` del elemento `xsl:output` que determina la extensión de archivo. El archivo predeterminado está ubicado en el directorio temporal del usuario actual.  
  
 **Esquemas**  
 Los esquemas que se utilizan en la validación. El botón abre la **esquemas XSD** cuadro de diálogo, que se puede usar para seleccionar los esquemas que se va a usar.  
  
 También puede introducir la ruta a los esquemas. Si se especifican varios esquemas, cada una de las rutas debe ir entre comillas dobles.  
  
 **Hoja de estilos**  
 El archivo XSLT que se utiliza para transformar el documento cuando el **Mostrar resultado XSLT** se utiliza el comando. Si este campo está en blanco cuando la **Mostrar resultado XSLT** es utilizar el comando, el editor utiliza el valor proporcionado en el `xml-stylesheet` procesar instrucciones del documento, o se le pide el nombre de archivo.  
  
 Al editar un archivo XSLT, esta propiedad puede utilizarse para especificar que debe ser una hoja de estilos diferente cuando usa el **Mostrar resultado XSLT** o **depurar XSLT** comando está seleccionado. Por ejemplo, podría hacer esto cuando edita una hoja de estilos que se incluye en una hoja de estilos principal.  
  
## <a name="see-also"></a>Vea también  
 [Editor XML](../xml-tools/xml-editor.md)   
 [Componentes del Editor XML](../xml-tools/xml-editor-components.md)