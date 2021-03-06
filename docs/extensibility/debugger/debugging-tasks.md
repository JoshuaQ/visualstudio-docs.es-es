---
title: "Tareas de depuración | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: debugging [Debugging SDK], tasks
ms.assetid: 5d60e9e8-305e-4a48-829f-b9440fc8af7b
caps.latest.revision: "16"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: d1a6ffff4d3ac0410ca3de7e2cd595119763e88b
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="debugging-tasks"></a>Tareas de depuración
Para depurar un programa, debe iniciarse y un motor de depuración (Alemania) debe estar conectado a él, o bien el Alemania debe asociarse a un programa iniciado previamente. Una vez conectado, la DE debe generar determinados eventos de inicio. En respuesta, el paquete de depuración intenta enlazar los puntos de interrupción establecidos en el IDE. Cuando el programa llega a un punto de interrupción enlazado, se detiene y espera proporcionados por el usuario.  
  
## <a name="in-this-section"></a>En esta sección  
 [Problemas de seguridad](../../extensibility/debugger/security-issues.md)  
 Describe los pasos de seguridad que se necesitan para depurar un programa.  
  
 [Inicio de un programa](../../extensibility/debugger/launching-a-program.md)  
 Proporciona instrucciones paso a paso sobre cómo especificar un Alemania, que llama el sistema operativo para iniciar el programa.  
  
 [Asociación directamente a un programa](../../extensibility/debugger/attaching-directly-to-a-program.md)  
 Describe el proceso que se usa para depurar un programa en un proceso que ya se está ejecutando.  
  
 [Envío de eventos de inicio después de un lanzamiento](../../extensibility/debugger/sending-startup-events-after-a-launch.md)  
 Se enumeran los eventos que tienen lugar una vez que la DE está asociada al programa, hasta que el programa se encuentra en su punto de entrada principal y está listo para la depuración.  
  
 [Control de ejecución](../../extensibility/debugger/control-of-execution.md)  
 Explica cómo el Alemania normalmente envía un evento de punto de entrada, un evento de finalización de carga o un evento de detención, dependiendo de las circunstancias.  
  
 [Enlace de puntos de interrupción](../../extensibility/debugger/binding-breakpoints.md)  
 Describe cómo, si el usuario establece un punto de interrupción, el IDE formula la solicitud y le solicita la sesión de depuración para crear el punto de interrupción.  
  
 [Evaluación de expresiones](../../extensibility/debugger/evaluating-expressions.md)  
 Explica cómo se crean expresiones y qué ocurre cuando se evalúa una expresión.  
  
 [Visualización de datos](../../extensibility/debugger/visualizing-and-viewing-data.md)  
 Explica cómo se admiten los visualizadores de tipo y visores personalizados por el evaluador de expresiones (EE).  
  
## <a name="related-sections"></a>Secciones relacionadas  
 [Conceptos del depurador](../../extensibility/debugger/debugger-concepts.md)  
 Describe los principales conceptos de arquitectura de depuración.  
  
 [Componentes del depurador](../../extensibility/debugger/debugger-components.md)  
 Proporciona una visión general de los componentes de depuración de Visual Studio, que incluyen Alemania, EE y controlador de símbolos (SH).  
  
 [Contextos de depurador](../../extensibility/debugger/debugger-contexts.md)  
 Explica el funcionamiento de la DE forma simultánea dentro de código, documentación y los contextos de evaluación de expresión. Describe, para cada uno de los tres contextos, la ubicación, posición o evaluación pertinente a él.  
  
## <a name="see-also"></a>Vea también  
 [Introducción](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)