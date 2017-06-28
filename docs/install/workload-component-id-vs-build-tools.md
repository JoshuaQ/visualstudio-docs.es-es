---
title: Identificadores de componente y carga de trabajo de Visual Studio Build Tools 2017 | Microsoft Docs
description: "Uso de identificadores de componente y carga de trabajo de Visual Studio para crear aplicaciones clásicas basadas en Windows"
keywords: 
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.date: 05/10/2017
ms.topic: article
helpviewer_keywords:
- workload ID, Visual Studio
- component ID, Visual Studio
- install Visual Studio, administrator guide
ms.prod: visual-studio-dev15
ms.service: 
ms.technology:
- vs-ide-install
ms.assetid: b99298df-0280-47fc-af73-44cd7a8ac553
translation.priority.ht:
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- ru-ru
- zh-cn
- zh-tw
translation.priority.mt:
- cs-cz
- pl-pl
- pt-br
- tr-tr
ms.translationtype: Human Translation
ms.sourcegitcommit: 054126ddbdc9f0144983a1ef21fa43875699cbee
ms.openlocfilehash: 1147438d12d754233f6205de4a5d37920cb5b66a
ms.contentlocale: es-es
ms.lasthandoff: 05/10/2017

---

# <a name="visual-studio-build-tools-2017-component-directory"></a>Directorio de componentes de Visual Studio Build Tools 2017

Las tablas de esta página presentan los identificadores que puede usar para instalar Visual Studio mediante la línea de comandos. Tenga en cuenta que agregaremos componentes adicionales a medida que se publiquen actualizaciones de Visual Studio.

Tenga en cuenta también lo siguiente sobre esta página:

* Cada carga de trabajo tiene su propia sección, seguida por el identificador de la carga de trabajo y una tabla de los componentes que están disponibles para la carga de trabajo.
* De forma predeterminada, los componentes con carácter **Obligatorio** se instalarán cuando se instala la carga de trabajo. Si lo desea, también puede instalar los componentes con la marca **Recomendado** y **Opcional**.
* También hemos agregado una sección que muestra los componentes adicionales que no están asociados a ninguna carga de trabajo.

Para obtener más información acerca de cómo utilizar estos identificadores, vea [Usar parámetros de la línea de comandos para instalar Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md). Y, para obtener una lista de los identificadores de componente y carga de trabajo para otros productos, consulte la página [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) (Identificadores de componente y carga de trabajo de Visual Studio 2017).

## <a name="msbuild-tools"></a>Herramientas de MSBuild

**Id.:** Microsoft.VisualStudio.Workload.MSBuildTools

**Descripción:** proporciona las herramientas necesarias para crear aplicaciones basadas en MSBuild.

### <a name="components-included-by-this-workload"></a>Componentes incluidos en esta carga de trabajo

Id. de componente | Nombre | Versión | Tipo de dependencia
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.0.26208.0 | Obligatorio
Microsoft.VisualStudio.Component.CoreBuildTools | Visual Studio Build Tools Core | 15.0.26228.0 | Obligatorio
Microsoft.VisualStudio.Component.Roslyn.Compiler | Compiladores de C# y Visual Basic Roslyn | 15.0.26208.0 | Obligatorio


## <a name="visual-c-build-tools"></a>Herramientas de compilación de Visual C++

**Id.:** Microsoft.VisualStudio.Workload.VCTools

**Descripción:** compile aplicaciones clásicas basadas en Windows con la tecnología del conjunto de herramientas de Visual C++, ATL y características opcionales como MFC y C++/CLI.

### <a name="components-included-by-this-workload"></a>Componentes incluidos en esta carga de trabajo

Id. de componente | Nombre | Versión | Tipo de dependencia
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreBuildTools | Características principales de Visual C++ Build Tools | 15.0.26208.0 | Obligatorio
Microsoft.VisualStudio.Component.Windows10SDK | Entorno de tiempo de ejecución de C de Windows Universal | 15.0.26208.0 | Obligatorio
Microsoft.VisualStudio.Component.VC.CMake.Project | Herramientas de Visual C++ para CMake | 15.0.26208.0 | Se recomienda
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | SDK de Windows 10 SDK (10.0.15063.0) para escritorio C++ x86 y x64 | 15.0.26403.0 | Se recomienda
Microsoft.Component.VC.Runtime.UCRTSDK | SDK de Windows Universal CRT | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | Paquete de compatibilidad de .NET Framework 4.6.1 | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Herramientas de análisis estático | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Compatibilidad con ATL para Visual C++ | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | Compatibilidad con MFC y ATL (x86 y x64) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | Compatibilidad con C++/CLI | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Características principales de Visual Studio C++ | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Módulos de bibliotecas estándar | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | Conjunto de herramientas de VC++ 2017 v141 (x86,x64) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | SDK de Windows 10 (10.0.10240.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | SDK de Windows 10 (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | SDK de Windows 10 (10.0.14393.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | SDK de Windows 8.1 | 15.0.26208.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | SDK de Windows 8.1 y SDK de UCRT | 15.0.26208.0 | Optional


## <a name="web-development-build-tools"></a>Herramientas de compilación de desarrollo web

**Id.:** Microsoft.VisualStudio.Workload.WebBuildTools

**Descripción:** tareas y objetivos de MSBuild para la creación de aplicaciones web.

### <a name="components-included-by-this-workload"></a>Componentes incluidos en esta carga de trabajo

Id. de componente | Nombre | Versión | Tipo de dependencia
--- | --- | --- | ---
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Herramientas de compilación de desarrollo web | 15.0.26323.1 | Obligatorio
## <a name="unaffiliated-components"></a>Componentes no afiliados

Estos son componentes que no están incluidos en ninguna carga de trabajo, pero que pueden seleccionarse como un componente individual.

Id. de componente | Nombre | Versión
--- | --- | ---
no disponible | no disponible | no disponible


## <a name="see-also"></a>Vea también

* [Identificadores de cargas de trabajo y componentes de Visual Studio](workload-and-component-ids.md)
* [Guía del administrador de Visual Studio](visual-studio-administrator-guide.md)
* [Usar parámetros de la línea de comandos para instalar Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Ejemplos de parámetros de línea de comandos](command-line-parameter-examples.md)
* [Crear una instalación sin conexión de Visual Studio](create-an-offline-installation-of-visual-studio.md)
