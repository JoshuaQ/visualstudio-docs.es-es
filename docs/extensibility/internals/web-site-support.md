---
title: Compatibilidad con sitios Web | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: web site projects
ms.assetid: ce9f4266-bb64-4c09-be88-4bd6413f60d0
caps.latest.revision: "17"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 09b43963d657e8d1fe7aa24e98632d2ca46240c6
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="web-site-support"></a>Compatibilidad con sitios Web
Un sistema de proyectos de sitio Web es un sistema de proyecto que crea proyectos Web. Proyectos Web a su vez crean aplicaciones Web. Un proyecto de sitio Web genera un archivo ejecutable para cada página Web que está asociado el código. Archivos ejecutables adicionales se generan a partir de los archivos de código fuente en la carpeta.  
  
 Sistemas del proyecto de sitio Web se crean mediante la adición de plantillas y los atributos de registro en un sistema de proyecto existente. Uno de estos atributos selecciona el proveedor de IntelliSense para el lenguaje. La implementación del proveedor de IntelliSense controla las referencias y llama al compilador del lenguaje cuando se solicita una página Web inteligente que no se almacena en caché.  
  
 El compilador de lenguaje que se utiliza para compilar páginas Web debe estar registrado en [!INCLUDE[vstecasp](../../code-quality/includes/vstecasp_md.md)]. Puede usar el [ \<compilador > elemento](/dotnet/framework/configure-apps/file-schema/compiler/compiler-element) en un archivo Web.config para registrar el compilador, como en el ejemplo siguiente:  
  
```  
<system.codedom>  <compilers>    <compiler language="py;IronPython" extension=".py"       type="IronPython.CodeDom.PythonProvider, IronPython,       Version=1.0.2391.18146, Culture=neutral,       PublicKeyToken=b03f5f7f11d50a3a" />  </compilers></system.codedom>  
```  
  
## <a name="in-this-section"></a>En esta sección  
 [Plantillas de compatibilidad del sitio web](../../extensibility/internals/web-site-support-templates.md)  
 Enumera las plantillas que puede usar para crear nuevos proyectos de sitios Web y los elementos asociados.  
  
 [Atributos de compatibilidad del sitio web](../../extensibility/internals/web-site-support-attributes.md)  
 Presenta los atributos de registro que se conectan a un proyecto de sitio Web [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] y [!INCLUDE[vstecasp](../../code-quality/includes/vstecasp_md.md)].  
  
## <a name="related-sections"></a>Secciones relacionadas  
 [Proyectos web](../../extensibility/internals/web-projects.md)  
 Presenta una visión general de los dos tipos de proyectos Web, proyectos de sitios Web y proyectos de aplicación Web.