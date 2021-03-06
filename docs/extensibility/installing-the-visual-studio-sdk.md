---
title: Instalar el SDK de Visual Studio | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: visual-studio-sdk
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: c730edb6-5099-4c16-85a8-08def09f1455
caps.latest.revision: "3"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 13ce2a839c09aa65c2bed2d87aec63827ec6583c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="installing-the-visual-studio-sdk"></a>Instalar el SDK de Visual Studio
El SDK de Visual Studio es una característica opcional en el programa de instalación de Visual Studio. También puede instalar el SDK de VS más adelante.  
  
## <a name="installing-the-visual-studio-sdk-as-part-of-a-visual-studio-installation"></a>Instalar el SDK de Visual Studio como parte de una instalación de Visual Studio  
 Si desea incluir el VSSDK en la instalación de Visual Studio, debe instalar la **desarrollo de extensión de Visual Studio** cargas de trabajo en **otros conjuntos de herramientas**. Este modo se instalará el SDK de Visual Studio, así como los requisitos previos necesarios. Puede ajustar aún más la instalación, seleccione o anule su selección de componentes desde el resumen de la vista. 
  
## <a name="installing-the-visual-studio-sdk-after-installing-visual-studio"></a>Instalar el SDK de Visual Studio después de instalar Visual Studio  
 Si decide instalar el SDK de Visual Studio después de completar la instalación de Visual Studio, vuelva a ejecutar el programa de instalación de Visual Studio y seleccione la **desarrollo de extensión de Visual Studio** carga de trabajo.  
  
## <a name="installing-the-visual-studio-sdk-from-a-solution"></a>Instalar el SDK de Visual Studio desde una solución  
 Si abre una solución con un proyecto de extensibilidad sin instalar primero el VSSDK, se le pedirá por una barra de información resaltada sobre el Explorador de soluciones. Debe tener un aspecto similar al siguiente:  
  
 ![SolutionExplorerInstall](../extensibility/media/solutionexplorerinstall.png "SolutionExplorerInstall")  
  
## <a name="installing-the-visual-studio-sdk-from-the-command-line"></a>Instalar el SDK de Visual Studio desde la línea de comandos  
Al igual que con cualquier carga de trabajo de Visual Studio o un componente, también puede instalar el elemento desde la línea de comandos. Vea [usar parámetros de línea de comandos para instalar Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) para obtener más información sobre los modificadores de línea de comandos adecuada y cómo determinar los identificadores de carga de trabajo o un componente.
  
 Tenga en cuenta que debe usar al instalador de Visual Studio que coincida con la versión instalada de Visual Studio. Por ejemplo, si tiene instalado en el equipo de Visual Studio Enterprise, debe ejecutar el programa de instalación de Visual Studio Enterprise (vs_enterprise.exe).