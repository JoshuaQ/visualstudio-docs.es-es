---
title: "Cómo: agregar elementos XML personalizados a documentos mediante complementos VSTO | Documentos de Microsoft"
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
- add-ins [Office development in Visual Studio], custom XML parts
- Office documents [Office development in Visual Studio, custom XML parts
- Word [Office development in Visual Studio], custom XML parts
- PowerPoint [Office development in Visual Studio], custom XML parts
- Excel [Office development in Visual Studio], custom XML parts
- custom XML parts [Office development in Visual Studio], adding
- documents [Office development in Visual Studio], custom XML parts
- application-level add-ins [Office development in Visual Studio], custom XML parts
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: b2c9fec7370e5b4f9bab8ac7773ba1a18f36d261
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins"></a>Cómo: Agregar elementos XML personalizados a documentos mediante complementos de VSTO
  Puede almacenar datos XML en los siguientes tipos de documentos creando un elemento XML personalizado en un complemento de VSTO:  
  
-   Un libro de Microsoft Office Excel.  
  
-   Un documento de Microsoft Office Word.  
  
-   Una presentación de Microsoft Office PowerPoint.  
  
 Para obtener más información, consulta [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md).  
  
 **Aplicación:** la información de este tema se aplica a los proyectos de nivel de aplicación de Excel, PowerPoint y Word. Para obtener más información, consulta [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).  
  
### <a name="to-add-a-custom-xml-part-to-an-excel-workbook"></a>Para agregar un elemento XML personalizado a un libro de Excel  
  
1.  Agregue un nuevo objeto <xref:Microsoft.Office.Core.CustomXMLPart> a la colección <xref:Microsoft.Office.Interop.Excel._Workbook.CustomXMLParts%2A> del libro. <xref:Microsoft.Office.Core.CustomXMLPart> contiene la cadena XML que desea almacenar en el libro.  
  
     En el ejemplo de código siguiente se agrega un elemento XML personalizado al libro especificado.  
  
     [!code-vb[Trin_AddCustomXmlPartExcelAppLevel#1](../vsto/codesnippet/VisualBasic/trin_addcustomxmlpartexcelapplevel/ThisAddIn.vb#1)]
     [!code-csharp[Trin_AddCustomXmlPartExcelAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartExcelAppLevel/ThisAddIn.cs#1)]  
  
2.  Agregue el método `AddCustomXmlPartToWorkbook` a la clase `ThisAddIn` en un proyecto de complemento VSTO para Excel.  
  
3.  Llame al método desde otro código del proyecto. Por ejemplo, para crear el elemento XML personalizado cuando el usuario abre un libro, llame al método desde un controlador de eventos para el evento <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookOpen> .  
  
### <a name="to-add-a-custom-xml-part-to-a-word-document"></a>Para agregar un elemento XML personalizado a un documento de Word  
  
1.  Agregue un nuevo objeto <xref:Microsoft.Office.Core.CustomXMLPart> a la colección <xref:Microsoft.Office.Interop.Word._Document.CustomXMLParts%2A> del documento. <xref:Microsoft.Office.Core.CustomXMLPart> contiene la cadena XML que desea almacenar en el documento.  
  
     En el ejemplo de código siguiente se agrega un elemento XML personalizado al documento especificado.  
  
     [!code-vb[Trin_AddCustomXmlPartWordAppLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.vb#1)]
     [!code-csharp[Trin_AddCustomXmlPartWordAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.cs#1)]  
  
2.  Agregue el método `AddCustomXmlPartToDocument` a la clase `ThisAddIn` en un proyecto de complemento VSTO para Word.  
  
3.  Llame al método desde otro código del proyecto. Por ejemplo, para crear el elemento XML personalizado cuando el usuario abre un documento, llame al método desde un controlador de eventos para el evento <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> .  
  
### <a name="to-add-a-custom-xml-part-to-a-powerpoint-presentation"></a>Para agregar un elemento XML personalizado a una presentación de PowerPoint  
  
1.  Agregue un nuevo objeto <xref:Microsoft.Office.Core.CustomXMLPart> a la colección <xref:Microsoft.Office.Interop.PowerPoint._Presentation.CustomXMLParts%2A> de la presentación. <xref:Microsoft.Office.Core.CustomXMLPart> contiene la cadena XML que desea almacenar en la presentación.  
  
     En el ejemplo de código siguiente se agrega un elemento XML personalizado a la presentación especificada.  
  
     [!code-csharp[Trin_AddCustomXmlPartPowerPointAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.cs#1)]
     [!code-vb[Trin_AddCustomXmlPartPowerPointAppLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.vb#1)]  
  
2.  Agregue el método `AddCustomXmlPartToPresentation` a la clase `ThisAddIn` en un proyecto de complemento VSTO para PowerPoint.  
  
3.  Llame al método desde otro código del proyecto. Por ejemplo, para crear el elemento XML personalizado cuando el usuario abre una presentación, llame al método desde un controlador de eventos para el evento <xref:Microsoft.Office.Interop.PowerPoint.EApplication_Event.AfterPresentationOpen> .  
  
## <a name="robust-programming"></a>Programación sólida  
 Para simplificar, este ejemplo usa una cadena XML que se define como una variable local en el método. Normalmente, debe obtener el XML desde un origen externo, como un archivo o una base de datos.  
  
## <a name="see-also"></a>Vea también  
 [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md)   
 [Cómo: Agregar elementos XML personalizados a personalizaciones de nivel de documento](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)  
  
  