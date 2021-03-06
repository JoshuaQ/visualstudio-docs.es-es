---
title: Migrar soluciones de Office para .NET Framework 4 o posterior | Documentos de Microsoft
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: VST.Project.TargetFrameworkWarning
dev_langs:
- VB
- CSharp
helpviewer_keywords: Office projects [Office development in Visual Studio], migrating to .NET Framework 4
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 8cb61186c7e8260578e9b69242c594c198f7e525
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="migrating-office-solutions-to-the-net-framework-4-or-later"></a>Migrar soluciones de Office a .NET Framework 4 o posterior
  Si el marco de trabajo de destino de un proyecto de Office se cambia a [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] o a una versión posterior desde una versión anterior de .NET Framework, puede que sea necesario realizar algunos pasos adicionales para seguir ejecutando la solución en equipos de desarrollo y de usuario final. Para obtener más información, consulte [cambios necesarios para la ejecución de proyectos de Office migrados a .NET Framework 4 o .NET Framework 4.5](../vsto/required-changes-to-run-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).  
  
 Además, puede que ya no se pueda compilar el proyecto. Algunas características de los proyectos de Office tienen diferentes modelos de programación para las distintas versiones de .NET Framework. Cuando se cambia el marco de trabajo de destino de un proyecto de Office a [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] o a una versión posterior desde una versión anterior de .NET Framework, se deben realizar los siguientes cambios de código en el proyecto:  
  
-   [Actualizar proyectos de Excel y Word para migrarlos a .NET Framework 4 o .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
-   [Actualizar las personalizaciones de la cinta de opciones en proyectos de Office migrados a .NET Framework 4 o .NET Framework 4.5](../vsto/updating-ribbon-customizations-in-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
-   [Actualizar las áreas de formulario en los proyectos de Outlook migrados a .NET Framework 4 o .NET Framework 4.5](../vsto/updating-form-regions-in-outlook-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
 El marco de destino de un proyecto de Office cambia al actualizar ese proyecto desde una versión anterior de Visual Studio. Para obtener más información, consulta [Upgrading and Migrating Office Solutions](../vsto/upgrading-and-migrating-office-solutions.md).  
  
 Para obtener más información acerca de por qué algunas características de proyectos de Office tienen un modelo de programación diferente cuando el destino es el [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] o una versión posterior, consulte [cambios en el diseño de proyectos de Office destinados a .NET Framework 4 o .NET Framework 4.5](../vsto/changes-to-the-design-of-office-projects-that-target-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md) y [Visual Studio Tools para Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).  
  
## <a name="see-also"></a>Vea también  
 [Diseñar y crear soluciones de Office](../vsto/designing-and-creating-office-solutions.md)   
 [Cómo: Usar como destino una versión de .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md)   
 [Solución de problemas de errores en las soluciones de Office](../vsto/troubleshooting-errors-in-office-solutions.md)   
 [Soporte técnico adicional para errores de soluciones de Office](../vsto/additional-support-for-errors-in-office-solutions.md)  
  
  