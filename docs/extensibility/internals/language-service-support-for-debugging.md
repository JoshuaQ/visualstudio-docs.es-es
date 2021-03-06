---
title: Compatibilidad de servicio de lenguaje para depurar | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- debugger, language support
- language services, debugging support
ms.assetid: 7a44067f-a410-4a6a-84d2-bda5184140bc
caps.latest.revision: "15"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 955c8fd4e9499fbacfc0f97ba6112803ef1e6d4a
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="language-service-support-for-debugging"></a>Soporte de servicio de lenguaje para la depuración
Un servicio de lenguaje puede incluir características que admiten un depurador a través de la <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageDebugInfo> interfaz. Estas características incluyen la validación de los puntos de interrupción y proporcionar una lista de expresiones para la **automático** ventana.  
  
 Sin embargo, debe tener un evaluador de expresiones para depurar su idioma. El evaluador de expresiones es responsable de evaluar expresiones para generar valores durante la depuración. Para obtener información acerca de cómo implementar los evaluadores de expresión de CLR, vea:  
  
-   [Evaluadores de expresión de CLR](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators)  
  
-   [Ejemplo de evaluador de expresiones administradas](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample)  
  
## <a name="compiler-output"></a>Resultado de compilación  
 El tipo de compilador determina lo que necesita hacer para implementar la depuración en su idioma. Si el compilador tiene como destino el sistema operativo Windows y escribe un archivo .pdb, puede depurar programas con el motor que está integrado en Visual Studio de depuración de código nativo. Si el compilador genera el lenguaje intermedio de Microsoft (MSIL), puede depurar programas con el motor, que también está integrada en Visual Studio de depuración de código administrado. Si el compilador tiene como destino un sistema operativo patentado o un entorno de tiempo de ejecución diferente, tiene que escribir su propio motor de depuración.  
  
 Para obtener más información sobre cómo implementar la depuración en su idioma, consulte [Introducción](../../extensibility/debugger/getting-started-with-debugger-extensibility.md) en el SDK de depuración de Visual Studio.