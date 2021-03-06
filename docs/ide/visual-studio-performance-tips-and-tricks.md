---
title: Sugerencias y trucos de rendimiento de Visual Studio | Microsoft Docs
ms.date: 08/31/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: debugger
ms.assetid: 2fbcb59e-e981-4b40-8b7a-c1140d31ec4b
caps.latest.revision: "1"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: b703fd45732e3fd083a5c95b68647f67dce57b3a
ms.sourcegitcommit: 9357209350167e1eb7e50b483e44893735d90589
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 01/05/2018
---
# <a name="visual-studio-performance-tips-and-tricks"></a>Sugerencias y trucos de rendimiento de Visual Studio

Las recomendaciones de rendimiento de Visual Studio están previstas para situaciones de memoria insuficiente, que se pueden plantear en algunos casos. En estas situaciones, puede optimizar determinadas características de Visual Studio que puede que no esté usando. Las sugerencias siguientes no están planteadas como recomendaciones generales.

> [!NOTE]
> Si tiene dificultades para usar el producto debido a problemas de memoria, háganoslo saber a través de la herramienta de comentarios.

## <a name="optimize-your-environment"></a>Optimización del entorno

- **Use un sistema operativo de 64 bits**

    Si actualiza el sistema desde una versión de Windows de 32 bits a una de 64 bits, se amplía la cantidad de memoria virtual disponible para Visual Studio de 2 GB a 4 GB. Esto permite que Visual Studio gestione cargas de trabajo considerablemente mayores aunque sea un proceso de 32 bits.

    Para más información, vea [Memory limits (Límites de memoria)](https://msdn.microsoft.com/en-us/library/windows/desktop/aa366778(v=vs.85).aspx#memory_limits) y [Using /LARGEADDRESSAWARE on 64-bit Windows (Uso de /LARGEADDRESSAWARE en Windows de 64 bits)](https://blogs.msdn.microsoft.com/oldnewthing/20050601-24/?p=35483/).

## <a name="configure-solution-and-projects"></a>Configuración de solución y proyectos

Si tiene una solución muy grande con muchos proyectos, le puede resultar beneficioso realizar las siguientes optimizaciones:

- **Descargue proyectos**

    Puede descargar manualmente aquellos proyectos individuales usados raras veces desde el Explorador de soluciones si hace clic con el botón derecho en el menú contextual.

- **Refactorice la solución**

    Puede dividir la solución en varios archivos de solución más pequeños con proyectos de uso frecuente. Esta refactorización debería reducir considerablemente el uso de memoria del flujo de trabajo. Además, las soluciones más pequeñas se cargan más rápido.

## <a name="configure-debugging-options"></a>Configuración de opciones de depuración
Si es habitual que se quede sin memoria durante las sesiones de depuración, puede optimizar el rendimiento si realiza uno o más cambios de configuración.

- **Habilite Solo mi código**

    La optimización más sencilla consiste en habilitar la característica **Solo mi código**, que solo carga los símbolos del proyecto. La habilitación de esta característica puede traducirse en un considerable ahorro de memoria para depurar aplicaciones administradas (.NET). Esta opción ya está habilitada de forma predeterminada en algunos tipos de proyecto.

    Para habilitar **Solo mi código**, elija **Herramientas > Opciones > Depuración > General** y luego seleccione **Habilitar Solo mi código**.

- **Especifique los símbolos que se van a cargar**

    En la depuración nativa, la carga de archivos de símbolos (.pdb) resulta costosa en términos de recursos de memoria. Puede establecer la configuración de símbolos del depurador de modo que se ahorre memoria. Por lo general, la solución se configura para cargar únicamente los módulos del proyecto.

    Para especificar la carga de símbolos, elija **Herramientas > Opciones > Depuración > Símbolos**.

    Establezca las opciones en **Solo los módulos especificados** en lugar de **Todos los módulos** y luego especifique qué módulos quiere cargar. Durante la depuración, también puede hacer clic con el botón derecho en módulos concretos de la ventana **Módulos** para incluir explícitamente un módulo en la carga de símbolos. (Para abrir la ventana durante la depuración, elija **Depurar > Ventanas > Módulos**).

    Para más información, vea [Understanding symbol files (Introducción a los archivos de símbolos)](https://blogs.msdn.microsoft.com/visualstudioalm/2015/01/05/understanding-symbol-files-and-visual-studios-symbol-settings/).

- **Deshabilite las herramientas de diagnóstico**

    Se recomienda deshabilitar la generación de perfiles de CPU después de su uso. Esta característica puede consumir grandes cantidades de recursos. Una vez habilitada la generación de perfiles de CPU, este estado se mantiene en las sesiones de depuración posteriores, por lo que merece la pena desactivarla de forma explícita al terminar. Puede ahorrar algunos recursos si deshabilita las herramientas de diagnóstico durante la depuración si no necesita las características proporcionadas.

    Para deshabilitar las herramientas de diagnóstico, inicie una sesión de depuración, elija **Herramientas > Opciones > Habilitar herramientas de diagnóstico** y anule la selección de la opción.

    Para más información, vea [Herramientas de generación de perfiles](../profiling/profiling-tools.md).

## <a name="disable-tools-and-extensions"></a>Deshabilitación de herramientas y extensiones
Algunas herramientas o extensiones se pueden desactivar para mejorar el rendimiento.

> [!TIP]
> A menudo se pueden aislar los problemas de rendimiento si se desactivan las extensiones de una en una y se vuelve a comprobar el rendimiento.

### <a name="managed-language-services-roslyn"></a>Servicios de lenguaje administrados (Roslyn)

Para más información sobre las consideraciones de rendimiento de Roslyn, vea [Performance considerations for large solutions (Consideraciones de rendimiento para soluciones de gran tamaño)] (https://github.com/dotnet/roslyn/wiki/Performance-considerations-for-large-solutions).

- **Deshabilite el análisis completo de la solución**

    Visual Studio realiza un análisis de toda la solución con el fin de proporcionar una experiencia completa sobre errores antes de invocar una compilación. Esta característica es útil para identificar los errores lo antes posible. Pero en el caso de las soluciones muy grandes, esta característica puede consumir recursos de memoria considerables. Si experimenta problemas de memoria o similares, puede deshabilitar esta experiencia para liberar estos recursos. De forma predeterminada, esta opción está habilitada para Visual Basic y deshabilitada para C#.

    Para deshabilitar **Análisis completo de la solución**, elija **Herramientas > Opciones > Editor de texto > <Visual Basic o C#>**. Luego elija **Avanzadas** y anule la selección de **Habilitar análisis de la solución completa**.

- **Deshabilite CodeLens**

    Visual Studio realiza una tarea **Buscar todas las referencias** en cada método cuando este se muestra. CodeLens proporciona características como la presentación en línea del número de referencias. El trabajo se realiza en un proceso independiente (por ejemplo, ServiceHub.RoslynCodeAnalysisService32). En soluciones muy grandes o en sistemas limitados por recursos, esta característica puede tener un impacto considerable sobre el rendimiento, aunque se ejecute con una prioridad baja. Si experimenta un uso elevado de la CPU en este proceso o problemas de memoria (por ejemplo, al cargar una solución grande en un equipo de 4 GB), puede intentar deshabilitar esta característica para liberar recursos.

    Para deshabilitar CodeLens, elija **Herramientas > Opciones > Editor de texto > Todos los lenguajes > CodeLens** y anule la selección de la característica.

    Esta característica está disponible en Visual Studio Professional y Visual Studio Enterprise.

### <a name="other-tools-and-extensions"></a>Otras herramientas y extensiones

- **Deshabilite extensiones**

    Las extensiones son componentes de software adicionales agregados a Visual Studio para proporcionar nueva funcionalidad o extender la funcionalidad existente. Las extensiones suelen ser una fuente de problemas de recursos de memoria. Si experimenta problemas de recursos de memoria, intente deshabilitar extensiones de una en una para ver cómo repercuten en el escenario o el flujo de trabajo.

    Para deshabilitar extensiones, vaya a **Herramientas | Extensiones y actualizaciones** y deshabilite una extensión determinada.

- **Deshabilite el diseñador XAML**

    El diseñador XAML está habilitado de forma predeterminada, pero solo consume recursos si se abre un archivo .XAML. Si trabaja con archivos XAML pero no quiere usar la funcionalidad del diseñador, deshabilite esta característica para liberar memoria.

    Para deshabilitar el diseñador XAML, vaya a **Herramientas > Opciones > Diseñador XAML > Habilitar diseñador XAML** y anule la selección de la opción.

- **Quite cargas de trabajo**

    Puede usar el instalador de Visual Studio para quitar las cargas de trabajo que ya no se usen. Esta acción puede simplificar el costo de inicio y en tiempo de ejecución al omitir paquetes y ensamblados que ya no se necesitan.

## <a name="force-a-garbage-collection"></a>Aplicación de recolección de elementos no utilizados

CLR usa un sistema de administración de memoria de recopilación de elementos no utilizados. En este sistema, a veces hay objetos que ya no son necesarios pero que usan memoria. Este estado es temporal; el recolector de elementos no utilizados libera esta memoria en función de su rendimiento y heurística de uso de recursos. Puede forzar a CLR a que recopile la memoria sin usar mediante una tecla de acceso rápido en Visual Studio. Si hay una cantidad considerable de elementos no utilizados en espera de recolección y se fuerza esta, debería ver cómo se reduce el uso de memoria del proceso devenv.exe en el Administrador de tareas. Es raro tener que recurrir a este método. Pero después de que se haya completado una operación costosa (por ejemplo, una compilación completa, una sesión de depuración o un evento de apertura de solución), puede ayudar a determinar cuánta memoria está usando realmente el proceso. Dado que Visual Studio es mixto (administrado y nativo), a veces es posible que el asignador nativo y el recolector de elementos no utilizados compitan por recursos de memoria limitados. En condiciones de elevado uso de memoria, puede ser útil forzar la ejecución del recolector de elementos no utilizados.

Para forzar una recolección de elementos no utilizados, use la tecla de acceso rápido: **Ctrl + Alt + Mayús + F12**, **Ctrl + Alt + Mayús + F12** (presione dos veces).

Si la aplicación de la recolección de elementos no utilizados hace que el escenario funcione mejor, rellene un informe a través de la herramienta de comentarios de Visual Studio, ya que este comportamiento probablemente sea un error.

Para obtener una descripción detallada del recolector de elementos no utilizados de CLR, vea [Fundamentals of Garbage Collection (Aspectos básicos de la recolección de elementos no utilizados)](https://msdn.microsoft.com/en-us/library/ee787088(v=vs.110).aspx).

## <a name="see-also"></a>Vea también  
 [IDE de Visual Studio](../ide/index.md)
