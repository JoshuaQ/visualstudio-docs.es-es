---
title: Uso de varios procesadores para compilar proyectos | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- multiple processors
- MSBuild, multiple processor systems
ms.assetid: 49fa36c9-8e14-44f5-8a2b-34146cf6807b
caps.latest.revision: "13"
author: kempb
ms.author: kempb
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: c2879b753ecdf06779403b01bbeb0681448759fa
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="using-multiple-processors-to-build-projects"></a>Uso de varios procesadores para compilar proyectos
MSBuild puede aprovechar las ventajas de los sistemas que tienen varios procesadores o varios núcleos. Se crea un proceso de compilación independiente para cada procesador disponible. Por ejemplo, si el sistema tiene cuatro procesadores, se crean cuatro procesos de compilación. [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] puede procesar estas compilaciones simultáneamente y, por tanto, el tiempo de compilación se reduce. Sin embargo, la compilación en paralelo presenta algunos cambios en la forma en la que tienen lugar los procesos de compilación. En este tema se analizan estos cambios.  
  
## <a name="project-to-project-references"></a>Referencias entre proyectos  
 Cuando [!INCLUDE[vstecmsbuildengine](../msbuild/includes/vstecmsbuildengine_md.md)] encuentra una referencia entre proyectos mientras está utilizando compilaciones en paralelo para compilar un proyecto, solo compila la referencia una vez. Si dos proyectos tienen la misma referencia entre proyectos, la referencia no se recompila para cada proyecto. En su lugar, el motor de compilación devuelve la misma referencia entre proyectos a los dos proyectos que dependen de él. En la misma referencia entre proyectos se proporcionan las solicitudes futuras para el mismo destino en la sesión.  
  
## <a name="cycle-detection"></a>Detección de ciclos  
 La detección de ciclos funciona igual que en [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] 2.0, solo que ahora [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] puede notificar la detección del ciclo en un momento diferente o en la compilación.  
  
## <a name="errors-and-exceptions-during-parallel-builds"></a>Errores y excepciones durante las compilaciones en paralelo  
 En las compilaciones en paralelo, los errores y excepciones pueden producirse en momentos diferentes que en una compilación no paralela, y cuando un proyecto no se compila, las demás compilaciones de proyectos continúan. Si se producen errores en un proyecto, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] no detendrá la compilación de proyectos que se está ejecutando en paralelo. Los demás proyectos seguirán compilándose hasta que terminen correctamente o con errores. Sin embargo, si se ha habilitado <xref:Microsoft.Build.Framework.IBuildEngine.ContinueOnError%2A>, no se detendrá ninguna compilación aunque se produzca un error.  
  
## <a name="visual-c-project-vcproj-and-solution-sln-files"></a>Archivos de proyecto (.vcproj) y solución (.sln) de Visual C++  
 Los archivos de proyecto (.vcproj) y los archivos de solución (.sln) de [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] se pueden pasar a [MSBuild Task](../msbuild/msbuild-task.md). Para los proyectos de [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)], se llama a VCWrapperProject y, a continuación, se crea el proyecto de [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] interno. Para las soluciones de [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)], se crea un SolutionWrapperProject y, a continuación, se crea el proyecto de [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] interno. En ambos casos, el proyecto resultante se trata igual que cualquier otro proyecto de [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)].  
  
## <a name="multi-process-execution"></a>Ejecución con varios procesos  
 Casi todas las actividades relacionadas con la compilación requieren que el directorio actual permanezca constante a lo largo del proceso de compilación para evitar errores relacionados con la ruta de acceso. Por consiguiente, los proyectos no se pueden ejecutar en subprocesos diferentes de [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] porque haría que se crearan varios directorios.  
  
 Para evitar este problema y habilitar al mismo tiempo las compilaciones para varios procesadores, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] utiliza el "aislamiento de procesos". Mediante el aislamiento de procesos, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] pueden crear un máximo de `n` procesos, donde `n` es el número de procesadores disponibles en el sistema. Por ejemplo, si [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] compila una solución en un sistema que tiene dos procesadores de impresión, sólo se crean dos procesos de compilación. Estos procesos se reutilizan para compilar todos los proyectos de la solución.  
  
## <a name="see-also"></a>Vea también  
 [Compilar varios proyectos en paralelo](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)   
 [Tareas](../msbuild/msbuild-tasks.md)