---
title: "Cómo: abrir documentos existentes mediante programación | Documentos de Microsoft"
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
- documents [Office development in Visual Studio], opening
- Word [Office development in Visual Studio], opening documents
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 151571ace6790f05c067f8dff641988301bc1b0e
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-programmatically-open-existing-documents"></a>Cómo: Abrir documentos existentes mediante programación
  El <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> método abre el documento de Microsoft Office Word existente especificado por un nombre de ruta de acceso y nombre completo. Este método devuelve un <xref:Microsoft.Office.Interop.Word.Document> que representa el documento abierto.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
### <a name="to-open-a-document"></a>Para abrir un documento  
  
-   Llame a la <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> método de la <xref:Microsoft.Office.Interop.Word.Documents> colección y proporcionar una ruta de acceso al documento.  
  
     [!code-vb[Trin_VstcoreWordAutomation#5](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#5)]
     [!code-csharp[Trin_VstcoreWordAutomation#5](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#5)]  
  
### <a name="to-open-a-document-as-read-only"></a>Para abrir un documento como de solo lectura  
  
-   Llame a la <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> método, proporcione una ruta de acceso al documento y establecer el *ReadOnly* argumento pasado a **True** en la llamada al método.  
  
     [!code-vb[Trin_VstcoreWordAutomation#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#6)]
     [!code-csharp[Trin_VstcoreWordAutomation#6](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#6)]  
  
## <a name="compiling-the-code"></a>Compilar el código  
 Para este ejemplo de código se necesita lo siguiente:  
  
-   Debe existir un documento denominado NewDocument.doc en un directorio denominado Test en la unidad C.  
  
## <a name="see-also"></a>Vea también  
 [Cómo: crear nuevos documentos mediante programación](../vsto/how-to-programmatically-create-new-documents.md)   
 [Cómo: cerrar documentos mediante programación](../vsto/how-to-programmatically-close-documents.md)   
 [Parámetros opcionales en las soluciones de Office](../vsto/optional-parameters-in-office-solutions.md)  
  
  