---
title: "Cómo: editar archivos XML | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 07fa3ecf-6345-4d30-9d85-d5ef5b083319
caps.latest.revision: "2"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 8720fe94797e212cb332368572b291ce7fb40a26
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-edit-xml-files"></a>Cómo: Editar archivos XML
El Editor XML es el nuevo editor de archivos XML. Se puede utilizar en un archivo XML independiente o en uno asociado con un proyecto de Visual Studio. El Editor XML está asociado con las siguientes extensiones de archivo: .config, .dtd, .xml, .xsd, .xdr, .xsl, .xslt y .vssettings. También está asociado con otros tipos de archivos que no tengan registrado un editor específico y que incluyan contenido XML o DTD.  
  
> [!NOTE]
>  Los documentos XHTML son manejados con el Editor HTML.  
  
### <a name="to-edit-an-xml-file"></a>Para editar un archivo XML  
  
1.  Haga doble clic en el archivo que desea editar.  
  
### <a name="to-add-a-new-xml-file-to-a-project"></a>Para agregar un nuevo archivo XML a un proyecto  
  
1.  Desde el **proyecto** menú, seleccione **Agregar nuevo elemento**.  
  
2.  Seleccione **archivo XML** desde el **plantillas** panel.  
  
3.  Escriba el nombre de archivo en el **nombre** campo y presione **agregar**.  
  
     Se agrega el archivo XML al proyecto y se abre en el Editor XML. El archivo contiene la declaración XML predeterminada, `<?xml version="1.0" encoding="utf-8" ?>`.  
  
### <a name="to-add-an-existing-xml-file-to-a-project"></a>Para agregar un archivo XML existente a un proyecto  
  
1.  Desde el **proyecto** menú, seleccione **Agregar elemento existente**.  
  
     El **Agregar elemento existente** aparece el cuadro de diálogo.  
  
2.  Seleccione un archivo XML y presione **agregar**.  
  
### <a name="to-create-a-new-xml-or-xslt-file"></a>Para crear un nuevo archivo XML o XSLT  
  
1.  Desde el **archivo** menú, seleccione **nuevo**.  
  
     El **nuevo archivo** aparece el cuadro de diálogo.  
  
2.  Seleccione **archivo XML** para crear un nuevo archivo XML, o bien, seleccione **archivo XSLT** para crear una nueva hoja de estilos XSLT.  
  
3.  Haga clic en **abiertos**.  
  
### <a name="to-create-a-project-for-xml-files"></a>Para crear un proyecto de archivos XML  
  
1.  Desde el **archivo** menú, seleccione **New**y, a continuación, seleccione **proyecto**.  
  
     Aparecerá el cuadro de diálogo **Nuevo proyecto** .  
  
2.  Seleccione el lenguaje de código de su elección, seleccione **proyecto vacío**y haga clic en **Aceptar**.  
  
3.  Agregue archivos XML al proyecto.  
  
     El Editor XML busca los esquemas que agregue a este proyecto y los utiliza para la validación e IntelliSense en cualquier archivo XML, de esquema o XSLT que edite mientras este proyecto está abierto.  
  
## <a name="see-also"></a>Vea también  
 [Editor XML](../xml-tools/xml-editor.md)   
 [Propiedades del documento XML, ventana Propiedades](../xml-tools/xml-document-properties-properties-window.md)   
 [Cómo: Crear un esquema XML a partir de un documento XML](../xml-tools/how-to-create-an-xml-schema-from-an-xml-document.md)