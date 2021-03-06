---
title: Administrar propiedades de soluciones y proyectos | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 5315dd07ab0c791cc9a349c08431ceb4a9b5c797
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="managing-project-and-solution-properties"></a>Administración de propiedades de soluciones y proyectos

Los proyectos tienen propiedades que controlan muchos aspectos de la compilación, la depuración, las pruebas y la implementación. Algunas propiedades están presentes en todos los tipos de proyecto, mientras que otras son exclusivas de plataformas o idiomas específicos. Para acceder a las propiedades del proyecto, haga clic con el botón derecho en el nodo del proyecto en el Explorador de soluciones y seleccione **Propiedades**, o bien escriba "propiedades" en el cuadro de búsqueda **Inicio rápido** de la barra de menús.

![Menú contextual del proyecto](../ide/media/vs2015_proj_prop_menu.gif "vs2015_proj_prop_menu")

Los proyectos de .NET también pueden tener un nodo de propiedades en el propio árbol del proyecto.

![Nodo de propiedades en el árbol del Explorador de soluciones](../ide/media/vs2015_props_se.png "VS2015_Props_SE")

## <a name="project-properties"></a>Propiedades del proyecto

Las propiedades del proyecto se organizan en grupos y cada grupo tiene su propia página de propiedades. Es posible que las páginas varíen para lenguajes y tipos de proyecto diferentes.

### <a name="c-visual-basic-and-f-projects"></a>Proyectos de C#, Visual Basic y F#

En los proyectos de C#, F# y Visual Basic, las propiedades se exponen en el **Diseñador de proyectos**. En la siguiente ilustración se muestra la página Propiedad de compilación de un proyecto de WPF en C#:

![Diseñador de proyectos de Visual Studio](../ide/media/vs2015_proppage_build.png "VS2015_PropPage_Build")

Para obtener información sobre estas páginas de propiedades en el Diseñador de proyectos, vea [Referencia de propiedades del proyecto](../ide/reference/project-properties-reference.md).

> [!TIP]
> Las soluciones tienen algunas propiedades, al igual que los elementos de proyecto; estas propiedades son accesibles desde la [ventana Propiedades](../ide/reference/properties-window.md), no desde el **Diseñador de proyectos**.

### <a name="c-and-javascript-projects"></a>Proyectos de C++ y JavaScript

Los proyectos de C++ y JavaScript tienen una interfaz de usuario diferente para administrar las propiedades del proyecto. Esta ilustración muestra una página de propiedades de un proyecto de C++ (las páginas de JavaScript son similares):

![Propiedades de proyecto de Visual C&#43;&#43;](../ide/media/vs2015_projprops_cpp.png "VS2015_ProjProps_cpp")

Para obtener información sobre las propiedades de proyectos de C++, consulte [Working with Project Properties (C++)](/cpp/ide/working-with-project-properties) [Trabajo con propiedades de proyecto (C++)]. Para más información sobre las propiedades de JavaScript, vea [Página de propiedades, JavaScript](../ide/reference/property-pages-javascript.md).

## <a name="solution-properties"></a>Propiedades de la solución

Para obtener acceso a las propiedades de la solución, haga clic con el botón derecho en el nodo de la solución en el **Explorador de soluciones** y seleccione **Propiedades**. En el diálogo puede establecer configuraciones de proyecto para las compilaciones de depuración o de versión, elegir los proyectos que conformarán el proyecto de inicio al presionar F5 y establecer opciones de análisis de código.

## <a name="see-also"></a>Vea también

[Soluciones y proyectos en Visual Studio](../ide/solutions-and-projects-in-visual-studio.md)
