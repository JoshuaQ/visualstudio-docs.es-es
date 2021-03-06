---
title: "Cómo: cambiar el tamaño de controles ListObject | Documentos de Microsoft"
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- controls [Office development in Visual Studio], resizing
- ListObject control, resizing
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: e018ed60e60c63dd47b5d56b599ea0f0499f561c
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-resize-listobject-controls"></a>Cómo: Cambiar el tamaño de los controles ListObject
  Aunque se puede establecer el tamaño de un control <xref:Microsoft.Office.Tools.Excel.ListObject> al agregarlo a un libro de Microsoft Office Excel, podrían ser necesarios cambios posteriores. Por ejemplo, conviene cambiar una lista de columnas de dos a tres columnas.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 En proyectos de nivel de documento, el tamaño de los controles <xref:Microsoft.Office.Tools.Excel.ListObject> se puede cambiar en tiempo de diseño o en tiempo de ejecución. Puede cambiar el tamaño de los controles <xref:Microsoft.Office.Tools.Excel.ListObject> en tiempo de ejecución a un proyecto de complemento VSTO.  
  
 En este tema se describen las tareas siguientes:  
  
-   [Cambiar el tamaño de controles ListObject en tiempo de diseño](#designtime)  
  
-   [Cambiar el tamaño de controles ListObject en tiempo de ejecución a un proyecto de nivel de documento](#runtimedoclevel)  
  
-   [Cambiar el tamaño de controles ListObject en tiempo de ejecución a un proyecto de complemento VSTO](#runtimeaddin)  
  
 Para obtener más información sobre los controles <xref:Microsoft.Office.Tools.Excel.ListObject> , consulte [ListObject Control](../vsto/listobject-control.md).  
  
 ![vínculo a vídeo](../vsto/media/playvideo.gif "vínculo a vídeo") para una demostración en vídeo relacionada, vea [cómo agregar columnas a un objeto de lista enlazado a datos en tiempo de ejecución?](http://go.microsoft.com/fwlink/?LinkID=130318).  
  
##  <a name="designtime"></a> Cambiar el tamaño de un control ListObject en tiempo de diseño  
 Para cambiar el tamaño de una lista, puede hacer clic y arrastrar uno de los controladores de tamaño, o puede volver a definir su tamaño en el cuadro de diálogo **Cambiar el tamaño de la lista** .  
  
#### <a name="to-resize-a-list-by-using-the-resize-list-dialog-box"></a>Para cambiar el tamaño de una lista mediante el cuadro de diálogo Cambiar el tamaño de la lista  
  
  
1.  Haga clic en cualquier lugar en el <xref:Microsoft.Office.Tools.Excel.ListObject> tabla. El **herramientas de tabla, el diseño** aparece la pestaña en la cinta de opciones.  
  
2.  En la sección de propiedades, haga clic en **cambiar el tamaño de tabla**.  

    ![VSTO_ResizeTable](../vsto/media/vsto-resizetable.png)
  
3.  Seleccione el nuevo rango de datos para la tabla.  
  
4.  Haga clic en **Aceptar**.  
  
##  <a name="runtimedoclevel"></a> Cambiar el tamaño de controles ListObject en tiempo de ejecución a un proyecto de nivel de documento  
 Puede cambiar el tamaño de un control <xref:Microsoft.Office.Tools.Excel.ListObject> en tiempo de ejecución usando el método <xref:Microsoft.Office.Tools.Excel.ListObject.Resize%2A> . No puede usar este método para mover el control <xref:Microsoft.Office.Tools.Excel.ListObject> a una nueva ubicación en la hoja de cálculo. Los encabezados deben permanecer en la misma fila y el cambio de tamaño del control <xref:Microsoft.Office.Tools.Excel.ListObject> debe superponerse sobre el objeto de lista original. El control <xref:Microsoft.Office.Tools.Excel.ListObject> con el tamaño cambiado debe contener una fila de encabezado y al menos una fila de datos.  
  
#### <a name="to-resize-a-list-object-programmatically"></a>Para cambiar el tamaño de un objeto de lista mediante programación  
  
1.  Cree un control <xref:Microsoft.Office.Tools.Excel.ListObject> que abarque de la celda **A1** a la **B3** en `Sheet1`.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#6](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#6)]
     [!code-vb[Trin_VstcoreHostControlsExcel#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#6)]  
  
2.  Cambie el tamaño de la lista para incluir las celdas de la **A1** a la **C5**.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#7](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#7)]
     [!code-vb[Trin_VstcoreHostControlsExcel#7](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#7)]  
  
##  <a name="runtimeaddin"></a> Cambiar el tamaño de ListObject en tiempo de ejecución a un proyecto de complemento VSTO  
 Se puede cambiar el tamaño de un control <xref:Microsoft.Office.Tools.Excel.ListObject> en tiempo de ejecución en cualquier hoja de cálculo abierta. Para obtener más información sobre cómo agregar un control <xref:Microsoft.Office.Tools.Excel.ListObject> a una hoja de cálculo mediante un complemento de VSTO, consulte [How to: Add ListObject Controls to Worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md).  
  
#### <a name="to-resize-a-list-object-programmatically"></a>Para cambiar el tamaño de un objeto de lista mediante programación  
  
1.  Cree un control <xref:Microsoft.Office.Tools.Excel.ListObject> que abarque de la celda **A1** a la **B3** en `Sheet1`.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#12](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#12)]
     [!code-vb[Trin_Excel_Dynamic_Controls#12](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#12)]  
  
2.  Cambie el tamaño de la lista para incluir las celdas de la **A1** a la **C5**.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#13](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#13)]
     [!code-vb[Trin_Excel_Dynamic_Controls#13](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#13)]  
  
## <a name="see-also"></a>Vea también  
 [Extender documentos de Word y libros de Excel en complementos VSTO en tiempo de ejecución](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controles en documentos de Office](../vsto/controls-on-office-documents.md)   
 [Agregar controles a documentos de Office en tiempo de ejecución](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Automatizar Excel usando objetos extendidos](../vsto/automating-excel-by-using-extended-objects.md)   
 [ListObject (Control)](../vsto/listobject-control.md)   
 [Cómo: agregar controles ListObject a hojas de cálculo](../vsto/how-to-add-listobject-controls-to-worksheets.md)   
 [Cómo: cambiar el tamaño de los controles Bookmark](../vsto/how-to-resize-bookmark-controls.md)   
 [Cómo: Cambiar el tamaño de los controles NamedRange](../vsto/how-to-resize-namedrange-controls.md)  
  
  