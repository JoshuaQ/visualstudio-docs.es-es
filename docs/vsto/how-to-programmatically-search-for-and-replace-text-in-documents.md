---
title: "C&#243;mo: Buscar y reemplazar texto en documentos mediante programaci&#243;n"
ms.custom: ""
ms.date: "02/02/2017"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documentos [desarrollo de Office en Visual Studio], buscar"
  - "texto [desarrollo de Office en Visual Studio], buscar en documentos"
  - "texto [desarrollo de Office en Visual Studio], búsquedas de texto"
  - "búsquedas de texto, documentos"
  - "búsquedas de texto, reemplazar texto"
ms.assetid: a66962f5-eeb9-4dc6-a70f-9039ab437a63
caps.latest.revision: 51
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
caps.handback.revision: 50
---
# C&#243;mo: Buscar y reemplazar texto en documentos mediante programaci&#243;n
  El objeto <xref:Microsoft.Office.Interop.Word.Find> es miembro de los objetos <xref:Microsoft.Office.Interop.Word.Selection> y <xref:Microsoft.Office.Interop.Word.Range> y puede usar cualquiera de ellos para buscar texto en documentos de Microsoft Office Word.  El comando replace es una extensión del comando find.  
  
 Use un objeto <xref:Microsoft.Office.Interop.Word.Find> para recorrer un documento de Microsoft Office Word y buscar un determinado texto, formato o estilo y use la propiedad <xref:Microsoft.Office.Interop.Word.Find.Replacement%2A> para reemplazar cualquiera de los elementos encontrados.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
## Usar un objeto de selección  
 Cuando se usa un objeto <xref:Microsoft.Office.Interop.Word.Selection> para buscar texto, los criterios de búsqueda que especifique se aplicarán únicamente al texto actualmente seleccionado.  Si la <xref:Microsoft.Office.Interop.Word.Selection> es un punto de inserción, se buscará en el documento.  Cuando se encuentra el elemento que coincide con los criterios de búsqueda, se selecciona automáticamente.  
  
 Es importante tener en cuenta que los criterios <xref:Microsoft.Office.Interop.Word.Find> son acumulativos, lo que significa que se agregan a los criterios de búsqueda anteriores.  Borre el formato de las búsquedas anteriores mediante el método <xref:Microsoft.Office.Interop.Word.Find.ClearFormatting%2A> antes de hacer la búsqueda.  
  
#### Para buscar texto mediante un objeto de selección  
  
1.  Asigne una cadena de búsqueda a una variable.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#68](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#68)]
     [!code-vb[Trin_VstcoreWordAutomation#68](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#68)]  
  
2.  Borre el formato de las búsquedas anteriores.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#69](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#69)]
     [!code-vb[Trin_VstcoreWordAutomation#69](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#69)]  
  
3.  Ejecute la búsqueda y se mostrará un cuadro de mensaje con los resultados.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#70](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#70)]
     [!code-vb[Trin_VstcoreWordAutomation#70](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#70)]  
  
 En el siguiente ejemplo se muestra el método completo.  
  
 [!code-csharp[Trin_VstcoreWordAutomation#67](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#67)]
 [!code-vb[Trin_VstcoreWordAutomation#67](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#67)]  
  
## Usar un objeto Range  
 Los objetos <xref:Microsoft.Office.Interop.Word.Range> le permiten buscar texto sin mostrar nada en la interfaz de usuario.  El objeto <xref:Microsoft.Office.Interop.Word.Find> devuelve **True** si se encuentra algún texto que coincida con los criterios de búsqueda; de lo contrario, devuelve **False**.  También redefine el objeto <xref:Microsoft.Office.Interop.Word.Range> para que coincida con los criterios de búsqueda si se encuentra el texto.  
  
#### Para buscar texto con un objeto Range  
  
1.  Defina un objeto <xref:Microsoft.Office.Interop.Word.Range> formado por el segundo párrafo del documento.  
  
     El siguiente ejemplo de código se puede usar en una personalización de nivel de documento.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#72](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#72)]
     [!code-vb[Trin_VstcoreWordAutomation#72](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#72)]  
  
     El siguiente ejemplo de código se puede usar en un complemento de VSTO.  En este ejemplo se usa el documento activo.  
  
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#72](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomationAddIn/CS/ThisAddIn.cs#72)]
     [!code-vb[Trin_VstcoreWordAutomationAddIn#72](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomationAddIn/VB/ThisAddIn.vb#72)]  
  
2.  Use la propiedad <xref:Microsoft.Office.Interop.Word.Range.Find%2A> del objeto <xref:Microsoft.Office.Interop.Word.Range> para desactivar primero las opciones de formato existentes y buscar la cadena **find me**.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#73](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#73)]
     [!code-vb[Trin_VstcoreWordAutomation#73](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#73)]  
  
3.  Se mostrarán los resultados de la búsqueda en un cuadro de mensaje; seleccione <xref:Microsoft.Office.Interop.Word.Range> para que sea visible.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#74](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#74)]
     [!code-vb[Trin_VstcoreWordAutomation#74](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#74)]  
  
     Si se produce un error en la búsqueda, se seleccionará el segundo párrafo; si se hace correctamente, se mostrarán los criterios de búsqueda.  
  
 En el siguiente ejemplo se muestra el código completo de una personalización de nivel de documento.  Para usar este ejemplo, ejecute el código desde la clase `ThisDocument` del proyecto.  
  
 [!code-csharp[Trin_VstcoreWordAutomation#71](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#71)]
 [!code-vb[Trin_VstcoreWordAutomation#71](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#71)]  
  
 En el siguiente ejemplo se muestra el código completo de un complemento de VSTO.  Para usar este ejemplo, ejecute el código desde la clase `ThisAddIn` del proyecto.  
  
 [!code-csharp[Trin_VstcoreWordAutomationAddIn#71](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomationAddIn/CS/ThisAddIn.cs#71)]
 [!code-vb[Trin_VstcoreWordAutomationAddIn#71](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomationAddIn/VB/ThisAddIn.vb#71)]  
  
## Buscar y reemplazar texto en documentos  
 El siguiente código busca la selección actual y reemplaza todas las apariciones de la cadena **find me** por la cadena **Found**.  
  
#### Para buscar y reemplazar texto en documentos  
  
1.  Agregue el siguiente código de ejemplo a la clase `ThisDocument` o `ThisAddIn` del proyecto.  
  
     [!code-csharp[Trin_VstcoreWordAutomation#75](../snippets/csharp/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/CS/ThisDocument.cs#75)]
     [!code-vb[Trin_VstcoreWordAutomation#75](../snippets/visualbasic/VS_Snippets_OfficeSP/Trin_VstcoreWordAutomation/VB/ThisDocument.vb#75)]  
  
     La clase <xref:Microsoft.Office.Interop.Word.Find> tiene un método <xref:Microsoft.Office.Interop.Word.Find.ClearFormatting%2A> y la clase <xref:Microsoft.Office.Interop.Word.Replacement> también tiene su propio método <xref:Microsoft.Office.Interop.Word.Replacement.ClearFormatting%2A>.  Al efectuar operaciones de buscar y reemplazar, debe usar el método ClearFormatting de ambos objetos.  Si solo lo usa en el objeto <xref:Microsoft.Office.Interop.Word.Find>, podría obtener resultados imprevistos en el texto de reemplazo.  
  
2.  Use el método <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> del objeto <xref:Microsoft.Office.Interop.Word.Find> para reemplazar los elementos encontrados.  Use el parámetro *Replace* para especificar los elementos que se van a reemplazar.  Este parámetro puede ser uno de los siguientes valores <xref:Microsoft.Office.Interop.Word.WdReplace>:  
  
    -   <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll> reemplaza todos los elementos encontrados.  
  
    -   <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceNone> no reemplaza ninguno de los elementos encontrados.  
  
    -   <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne> reemplaza el primer elemento encontrado.  
  
## Vea también  
 [Cómo: Establecer opciones de búsqueda en Word mediante programación](../vsto/how-to-programmatically-set-search-options-in-word.md)   
 [Cómo: Recorrer los elementos encontrados en documentos mediante programación](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md)   
 [Cómo: Definir y seleccionar intervalos en documentos mediante programación](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)   
 [Cómo: Restaurar selecciones después de realizar búsquedas mediante programación](../vsto/how-to-programmatically-restore-selections-after-searches.md)   
 [Parámetros opcionales en las soluciones de Office](../vsto/optional-parameters-in-office-solutions.md)  
  
  