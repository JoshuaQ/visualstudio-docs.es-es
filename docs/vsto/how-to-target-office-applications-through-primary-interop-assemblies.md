---
title: "Cómo: apuntar a las aplicaciones de Office mediante los ensamblados de interoperabilidad primarios | Documentos de Microsoft"
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
- assemblies [Office development in Visual Studio], PIA references
- primary interop assemblies [Office development in Visual Studio], adding references to
- Office primary interop assemblies in Visual Studio, adding references to
- Office applications [Office development in Visual Studio], automating
- application development [Office development in Visual Studio], automating
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: f6634a8aa51c1c09180a249212752e440c5841e8
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-target-office-applications-through-primary-interop-assemblies"></a>Cómo: Apuntar a las aplicaciones de Office mediante los ensamblados de interoperabilidad primarios
  Cuando se crea un nuevo proyecto de Office, Visual Studio agrega automáticamente las referencias a los ensamblados de interoperabilidad primarios (PIA) de Microsoft Office necesarios para compilar el proyecto. Debe agregar referencias a otros PIA en los escenarios siguientes:  
  
-   Desea usar las características de otras aplicaciones de Microsoft Office en su proyecto. Por ejemplo, quizás le interese usar las características de Microsoft Office Excel en un proyecto de Microsoft Office Word.  
  
-   Desea automatizar las aplicaciones de Microsoft Office que no tienen proyectos dedicados en Visual Studio, como Microsoft Office Access.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
### <a name="to-add-a-reference-to-a-primary-interop-assembly"></a>Para agregar una referencia a un ensamblado de interoperabilidad primario  
  
1.  Abra el proyecto de Office y seleccione el nombre del proyecto en **el Explorador de soluciones**.  
  
2.  En el menú **Proyecto**, haga clic en **Agregar referencia**.  
  
3.  En el **Framework** ficha, seleccione el PIA que desee en el **nombre de componente** lista. Para obtener más información acerca de los ensamblados de interoperabilidad primarios disponibles de Microsoft Office, consulte [ensamblados de interoperabilidad primarios de Office](../vsto/office-primary-interop-assemblies.md).  
  
     Si el proyecto tiene como destino el [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] o una versión posterior, el **incrustar tipos de interoperabilidad** propiedad para la referencia de ensamblado se establece en **True** de forma predeterminada. Con esta configuración, la solución no requiere el PIA en los equipos de los usuarios finales. Para obtener más información, consulta [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
    > [!NOTE]  
    >  En los proyectos de Office, agregue siempre referencias a los PIA de Office mediante el uso de la **.NET** pestaña de la **Agregar referencia** cuadro de diálogo en lugar de la **COM** ficha. Para obtener más información, consulte [Ensamblados de interoperabilidad primarios de Office](../vsto/office-primary-interop-assemblies.md).  
  
4.  Haga clic en **Aceptar**.  
  
     El nombre del ensamblado aparece en la **referencias** carpeta de **el Explorador de soluciones**.  
  
## <a name="see-also"></a>Vea también  
 [Ensamblados de interoperabilidad primarios de Office](../vsto/office-primary-interop-assemblies.md)   
 [Escribir código en soluciones de Office](../vsto/writing-code-in-office-solutions.md)   
 [Desarrollar soluciones de Office](../vsto/developing-office-solutions.md)   
 [Cómo: Instalar ensamblados de interoperabilidad primarios de Office](../vsto/how-to-install-office-primary-interop-assemblies.md)  
  
  