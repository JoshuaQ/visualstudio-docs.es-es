---
title: Implementar generadores de un solo archivo | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- custom tools, implementing
- projects [Visual Studio SDK], extensibility
- projects [Visual Studio SDK], managed custom tools
ms.assetid: fe9ef6b6-4690-4c2c-872c-301c980d17fe
caps.latest.revision: "14"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: b9fed2f4118600c48ad6cb769c8e697b06ae77d1
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="implementing-single-file-generators"></a>Implementar generadores de un solo archivo
Una herramienta personalizada: conoce a veces como un generador de archivos únicos, puede utilizarse para extender el [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] y [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] proyecto sistemas en [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. Una herramienta personalizada es un componente COM que implementa el <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interfaz. Uso de esta interfaz, una herramienta personalizada transforma un único archivo de entrada en un único archivo de salida. El resultado de la transformación puede ser código fuente o cualquier otro de salida que resulta útil. Dos ejemplos de archivos de código generados por la herramienta personalizada son código generado en respuesta a los cambios en un diseñador visual y archivos que se generan mediante el lenguaje de descripción de servicios Web (WSDL).  
  
 Cuando se carga una herramienta personalizada, o se guarda el archivo de entrada, el sistema de proyectos llama el <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.Generate%2A> (método) y pasa una referencia a un <xref:Microsoft.VisualStudio.Shell.Interop.IVsGeneratorProgress> interfaz de devolución de llamada, mediante el cual la herramienta puede notificar su progreso al usuario.  
  
 El archivo de salida que genera la herramienta personalizada se agrega al proyecto con una dependencia en el archivo de entrada. El sistema del proyecto determina automáticamente el nombre del archivo de salida, en función de la cadena devuelta por la implementación de la herramienta personalizada de <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.DefaultExtension%2A>.  
  
 Una herramienta personalizada debe implementar la <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interfaz. Opcionalmente, herramientas personalizadas para admiten la <xref:Microsoft.VisualStudio.OLE.Interop.IObjectWithSite> interfaz para recuperar información de orígenes que no sea el archivo de entrada. En cualquier caso, para poder usar una herramienta personalizada, debe registrarlo con el sistema o en la [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] registro local. Para obtener más información sobre cómo registrar herramientas personalizadas, vea [registrar generadores de único archivo](../../extensibility/internals/registering-single-file-generators.md).  
  
## <a name="see-also"></a>Vea también  
 [Exposición de tipos a diseñadores visuales](../../extensibility/internals/exposing-types-to-visual-designers.md)