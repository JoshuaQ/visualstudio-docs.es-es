---
title: "Cómo: eliminar hojas de cálculo mediante programación de los libros | Documentos de Microsoft"
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
- workbooks, deleting worksheets
- worksheets, deleting
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 05910578569399534f2377c0960f3af8e0054625
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-programmatically-delete-worksheets-from-workbooks"></a>Cómo: Eliminar hojas de cálculo de libros mediante programación
  Puede eliminar cualquier hoja de cálculo de un libro. Para eliminar una hoja de cálculo, use el elemento host worksheet o acceda a la hoja de cálculo mediante la colección Sheets del libro.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## <a name="using-the-worksheet-host-item"></a>Usar el elemento host Worksheet  
 Si la hoja de cálculo se agregó en tiempo de diseño en una personalización de nivel de documento, use el método <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> para eliminar una hoja de cálculo especificada. El siguiente código elimina una hoja de cálculo de un libro haciendo referencia directamente al elemento host worksheet.  
  
> [!IMPORTANT]  
>  Este código solo se ejecuta en proyectos creados mediante cualquiera de las siguientes plantillas de proyecto:  
>   
>  -   Libro de Excel 2013  
> -   Plantilla de Excel 2013  
> -   Libro de Excel 2010  
> -   Plantilla de Excel 2010  
>   
>  Si desea realizar esta tarea en cualquier otro tipo de proyecto, debe agregar una referencia a la **Microsoft.Office.Interop.Excel** ensamblado y, a continuación, debe usar las clases de dicho ensamblado para abrir un libro y eliminar una hoja de cálculo. Para obtener más información, consulte [Cómo: apuntar a las aplicaciones de Office mediante los ensamblados de interoperabilidad principal](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md) y [referencia de ensamblado de interoperabilidad primario de Excel 2010](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### <a name="to-delete-a-worksheet-by-using-a-worksheet-host-item"></a>Para eliminar una hoja de cálculo mediante un elemento host worksheet  
  
1.  Llame al método <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> de `Sheet1`.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#17](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#17)]
     [!code-vb[Trin_VstcoreExcelAutomation#17](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#17)]  
  
## <a name="using-the-sheets-collection-of-the-excel-workbook"></a>Usar la colección Sheets del libro de Excel  
 Acceda a las hojas de cálculo a través de la colección <xref:Microsoft.Office.Interop.Excel.Sheets> de Microsoft Office Excel en los siguientes casos:  
  
-   Desea eliminar una hoja de cálculo de un complemento de VSTO.  
  
-   La hoja de cálculo que desea eliminar se creó en tiempo de ejecución en una personalización de nivel de documento.  
  
 El siguiente código elimina una hoja de cálculo de un libro haciendo referencia a la hoja a través del número de índice de la **hojas** colección. Este código supone que se ha creado una nueva hoja de cálculo mediante programación.  
  
> [!IMPORTANT]  
>  Si desea realizar esta tarea en cualquier otro tipo de proyecto, debe agregar una referencia a la **Microsoft.Office.Interop.Excel** ensamblado y, a continuación, debe usar las clases de dicho ensamblado para abrir un libro y eliminar una hoja de cálculo. Para obtener más información, consulte [Cómo: apuntar a las aplicaciones de Office mediante los ensamblados de interoperabilidad principal](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md) y [referencia de ensamblado de interoperabilidad primario de Excel 2010](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### <a name="to-delete-a-worksheet-by-using-the-sheets-collection-of-the-excel-workbook"></a>Para eliminar una hoja de cálculo mediante la colección Sheets del libro de Excel  
  
1.  Llame al método <xref:Microsoft.Office.Interop.Excel._Worksheet.Delete%2A> de la colección <xref:Microsoft.Office.Interop.Excel.Sheets>.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#18](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#18)]
     [!code-vb[Trin_VstcoreExcelAutomation#18](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#18)]  
  
## <a name="see-also"></a>Vea también  
 [Trabajar con hojas de cálculo](../vsto/working-with-worksheets.md)   
 [Cómo: ocultar hojas de cálculo de mediante programación](../vsto/how-to-programmatically-hide-worksheets.md)   
 [Cómo: mover hojas de cálculo dentro de los libros de programación](../vsto/how-to-programmatically-move-worksheets-within-workbooks.md)   
 [Cómo: seleccionar hojas de cálculo de mediante programación](../vsto/how-to-programmatically-select-worksheets.md)   
 [Cómo: agregar nuevas hojas de cálculo a libros mediante programación](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)   
 [Elemento Host Worksheet](../vsto/worksheet-host-item.md)   
 [Acceso global a objetos en los proyectos de Office](../vsto/global-access-to-objects-in-office-projects.md)   
 [Limitaciones de programación de elementos y controles Host](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  