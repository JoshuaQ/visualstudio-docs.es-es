---
title: "Cómo: imprimir documentos mediante programación | Documentos de Microsoft"
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
- Word [Office development in Visual Studio], printing documents
- documents [Office development in Visual Studio], printing
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 9aa3e4b21aedff239aabde616b12a4f59281ec0a
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-programmatically-print-documents"></a>Cómo: Imprimir documentos mediante programación
  Puede imprimir la totalidad o parte de un documento de Microsoft Office Word en la impresora predeterminada.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
## <a name="printing-a-document-that-is-part-of-a-document-level-customization"></a>Imprimir un documento que forma parte de una personalización de nivel de documento  
  
#### <a name="to-print-the-entire-document"></a>Para imprimir todo el documento  
  
1.  Llame al método <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> de la clase `ThisDocument` en el proyecto para imprimir todo el documento. Para usar este ejemplo, ejecute el código desde la clase `ThisDocument` .  
  
     [!code-vb[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#11)]  
  
#### <a name="to-print-the-current-page-of-the-document"></a>Para imprimir la página actual del documento  
  
1.  Llame al método <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> de la clase `ThisDocument` en el proyecto e indique que se va a imprimir una copia de la página actual. Para usar este ejemplo, ejecute el código desde la clase `ThisDocument` .  
  
     [!code-vb[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#12)]  
  
## <a name="printing-a-document-by-using-an-vsto-add-in"></a>Imprimir un documento mediante un complemento de VSTO  
  
#### <a name="to-print-an-entire-document"></a>Para imprimir un documento completo  
  
1.  Llame al método <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> del objeto <xref:Microsoft.Office.Interop.Word.Document> que quiere imprimir. En el siguiente ejemplo de código se imprime el documento activo. Para usar este ejemplo, ejecute el código desde la clase `ThisAddIn` del proyecto.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#11)]  
  
#### <a name="to-print-the-current-page-of-a-document"></a>Para imprimir la página actual de un documento  
  
1.  Llame al método <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> del objeto <xref:Microsoft.Office.Interop.Word.Document> que quiere imprimir e indique que se va a imprimir una copia de la página actual. En el siguiente ejemplo de código se imprime el documento activo. Para usar este ejemplo, ejecute el código desde la clase `ThisAddIn` del proyecto.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#12)]  
  
## <a name="see-also"></a>Vea también  
 [Parámetros opcionales en las soluciones de Office](../vsto/optional-parameters-in-office-solutions.md)  
  
  