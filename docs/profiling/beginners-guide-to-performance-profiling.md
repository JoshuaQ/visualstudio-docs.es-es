---
title: "Guía básica para la generación de perfiles de rendimiento en Visual Studio | Microsoft Docs"
ms.custom: H1Hack27Feb2017
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology:
- vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: get-started-article
f1_keywords:
- vs.performance.wizard.intropage
helpviewer_keywords:
- Profiling Tools, quick start
- Diagnostics Tools, CPU Usage
- CPU Usage
- Diagnostics Tools
ms.assetid: da2fbf8a-2d41-4654-a509-dd238532d25a
caps.latest.revision: 45
author: mikejo5000
ms.author: mikejo
manager: ghogen
translation.priority.ht:
- cs-cz
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- pl-pl
- pt-br
- ru-ru
- tr-tr
- zh-cn
- zh-tw
translationtype: Human Translation
ms.sourcegitcommit: a42f5a30375192c89c9984e40ba0104da98d7253
ms.openlocfilehash: fe329cd5395db3afae1c3f3e98bb6e480323e21f
ms.lasthandoff: 03/07/2017

---
# <a name="beginners-guide-to-performance-profiling"></a>Guía básica para la generación de perfiles de rendimiento
Puede utilizar las herramientas de generación de perfiles de Visual Studio para analizar problemas de rendimiento en su aplicación. Este procedimiento muestra cómo utilizar la pestaña **Uso de CPU** de las herramientas de diagnóstico para obtener datos de rendimiento para la aplicación. Se admiten las herramientas de diagnóstico para el desarrollo de .NET en Visual Studio, incluido ASP.NET, y para el desarrollo nativo de C++.
  
Cuando el depurador se detiene, la herramienta **Uso de CPU** recopila información sobre las funciones que se ejecutan en la aplicación. La herramienta enumera las funciones que realizaron trabajo y proporciona un gráfico de escala de tiempo que se puede utilizar para centrarse en segmentos específicos de la sesión de muestreo.

El concentrador de diagnósticos le ofrece muchas otras opciones para ejecutar y administrar la sesión de diagnóstico. Si **Uso de CPU** no le proporciona los datos que necesita, las [demás herramientas de generación de perfiles](../profiling/Profiling-Tools.md) proporcionan diferentes tipos de información que pueden resultarle útiles. En muchos casos, el cuello de botella de rendimiento de la aplicación puede no ser debido a la CPU, sino a la memoria, la representación de interfaz de usuario o el tiempo de solicitud de red. El concentrador de diagnósticos le ofrece muchas más opciones para registrar y analizar este tipo de datos.

En este tema, trataremos de analizar el uso de CPU en el flujo de trabajo de depuración normal. También puede analizar el uso de CPU sin un depurador adjunto o tomando una aplicación en ejecución como destino. Para obtener más información, consulte [Ejecutar herramientas de generación de perfiles sin depuración](../profiling/running-profiling-tools-with-or-without-the-debugger.md).
  
##  <a name="BKMK_Quick_start__Collect_diagnostic_data"></a> Paso 1: Recopilar datos de generación de perfiles 
  
1.  Abra el proyecto que desee depurar en Visual Studio y establezca un punto de interrupción de la aplicación en el punto en que quiera examinar el uso de CPU.

2.  Establezca un segundo punto de interrupción al final de la función o la región de código que quiera analizar.

    > [!TIP]
    > Al establecer dos puntos de interrupción, puede limitar la recopilación de datos a las partes del código que quiere analizar.
  
3.  La ventana **Herramientas de diagnóstico** aparece automáticamente a no ser que la desactive. Para que la ventana se vuelva a mostrar, haga clic en **Depurar / Windows / Mostrar herramientas de diagnóstico**.

4.  Puede elegir si ve **Uso de CPU**, [Uso de memoria](../profiling/Memory-Usage.md) o ambos con el ajuste **Seleccionar herramientas** en la barra de herramientas. Si ejecuta Visual Studio Enterprise, también puede habilitar o desactivar IntelliTrace en **Herramientas / Opciones / IntelliTrace**.

     ![Mostrar herramientas de diagnóstico](../profiling/media/DiagToolsSelectTool.png "DiagToolsSelectTool")

     Nos fijaremos principalmente en el uso de CPU, así que asegúrese de que **Uso de CPU** está habilitado (lo está de forma predeterminada).

5.  Haga clic en **Depurar / Iniciar depuración** (o **Inicio** en la barra de herramientas o **F5**).

     Cuando la aplicación finaliza la carga, se muestra la vista Resumen de las herramientas de diagnóstico.

     ![Pestaña Resumen de herramientas de diagnóstico](../profiling/media/DiagToolsSummaryTab.png "DiagToolsSummaryTab")

     Para obtener más información sobre los eventos, consulte [Búsqueda y filtrado de la pestaña Eventos de la ventana de herramientas de diagnóstico](http://blogs.msdn.com/b/visualstudioalm/archive/2015/11/12/searching-and-filtering-the-events-tab-of-the-diagnostic-tools-window.aspx)

6.  Ejecute el escenario que hará que se alcance el primer punto de interrupción.

7.  Mientras el depurador está en pausa, habilite la recopilación de datos de uso de CPU y, a continuación, abra la pestaña **Uso de CPU**.

     ![Herramientas de diagnóstico para habilitar la generación de perfiles de CPU](../profiling/media/DiagToolsEnableCPUProfiling.png "DiagToolsEnableCPUProfiling")

     Cuando se elige **Habilitar generación de perfiles de CPU**, Visual Studio empezará a registrar sus funciones y cuánto tiempo tardan en ejecutarse. Solo puede ver los datos recopilados cuando la aplicación se detiene en un punto de interrupción.

8.  Presione F5 para ejecutar la aplicación hasta el segundo punto de interrupción.

     Ahora tiene los datos de rendimiento de la aplicación específicamente para la región de código que se ejecuta entre los dos puntos de interrupción.

9.  Seleccione la región que le interese analizar de la escala de tiempo de CPU (debe ser una región en que se muestren datos de generación de perfiles).

     ![Herramientas de diagnóstico para seleccionar un segmento de tiempo](../profiling/media/DiagToolsSelectTimeSegment.png "DiagToolsSelectTimeSegment")

     El generador de perfiles empieza a preparar los datos de subproceso. Espere a que finalice.

     ![Herramientas de diagnóstico para preparar subprocesos](../profiling/media/DiagToolsPreparingThreads.png "DiagToolsPreparingThreads")
  
     La herramienta Uso de CPU muestra el informe en la pestaña **Uso de CPU**.
  
     ![Herramientas de diagnóstico para la pestaña Uso de CPU](../profiling/media/DiagToolsCPUUsageTab.png "DiagToolsCPUUsageTab")

     En este punto, puede empezar a analizar los datos.

## <a name="Step2"></a> Paso 2: Analizar datos de uso de CPU

Se recomienda que, para empezar a analizar los datos, examine la lista de funciones de Uso de CPU, identifique las funciones que realizan la mayor parte del trabajo y, a continuación, observe detenidamente cada una de ellas.

1. En la lista de funciones, examine las funciones que realizan la mayor parte del trabajo.

    ![Herramientas de diagnóstico para la lista de funciones de Uso de CPU](../profiling/media/DiagToolsCPUUsageFunctionList.png "DiagToolsCPUUsageFunctionList")

    > [!TIP]
    > Las funciones aparecen en orden, comenzando por las que realizan la mayor parte del trabajo (no están en orden de llamada). Esto ayuda a identificar rápidamente las funciones que se ejecutan durante más tiempo.

2. En la lista de funciones, haga doble clic en una de las funciones de aplicación que realice mucho trabajo.

    Al hacer doble clic en una función, la vista **Llamador y destinatario** se abre en el panel izquierdo. 

    ![Herramientas de diagnóstico para la vista Llamador y destinatario](../profiling/media/DiagToolsCallerCallee.png "DiagToolsCallerCallee")

    En esta vista, la función seleccionada se muestra en el encabezado y en el cuadro **Función actual** (en este ejemplo, GetNumber). La función que llamó a la función actual se muestra a la izquierda en **Función llamadora**, y las funciones llamadas por la función actual se muestran a la derecha en el cuadro **Funciones llamadas**. (Puede seleccionar cualquiera de los cuadros para cambiar la función actual).

    En esta vista se muestra el tiempo total (ms) y el porcentaje del tiempo de ejecución global de la aplicación que la función ha tardado en completarlo.

    **Cuerpo de la función** también muestra la cantidad total de tiempo (y el porcentaje de tiempo) empleado en el cuerpo de la función, excluido el tiempo invertido en las funciones llamadoras y llamadas. (En este ejemplo, 3713 de 3729 ms se dedicaron al cuerpo de la función y los 16 ms restantes se dedicaron al código externo al que esta función llama).

    > [!TIP]
    > Los valores altos en **Cuerpo de la función** pueden indicar un cuello de botella de rendimiento dentro de la propia función.

3. Si quiere obtener una vista de nivel superior en que se muestre el orden en que las funciones se llaman, seleccione **Árbol de llamadas** en la lista desplegable en la parte superior del panel.
 
    Cada área numerada de la ilustración se corresponde con un paso del procedimiento.
  
    ![Herramientas de diagnóstico para el árbol de llamadas](../profiling/media/DiagToolsCallTree.png "DiagToolsCallTree")
  
|||
|-|-|
|![Paso 1](../profiling/media/ProcGuid_1.png "ProcGuid_1")|El nodo de nivel superior de los árboles de llamadas de Uso de CPU es un pseudonodo|  
|![Paso 2](../profiling/media/ProcGuid_2.png "ProcGuid_2")|En la mayoría de las aplicaciones, si la opción [Mostrar código externo](#BKMK_External_Code) está deshabilitada, el nodo de segundo nivel es un nodo **[Código externo]** que contiene el código del sistema y Framework que inicia y detiene la aplicación, dibuja la IU, controla la programación de subprocesos y ofrece otros servicios de bajo nivel a la aplicación.|  
|![Paso 3](../profiling/media/ProcGuid_3.png "ProcGuid_3")|Los elementos secundarios del nodo de segundo nivel son los métodos de código de usuario y las rutinas asíncronas llamados o creados por el sistema de segundo nivel y el código de Framework.|
|![Paso 4](../profiling/media/ProcGuid_4.png "ProcGuid_4")|Los nodos secundarios de un método contienen datos únicamente de las llamadas del método principal. Cuando está deshabilitada la opción **Mostrar código externo** , los métodos de aplicación también pueden contener un nodo **[Código externo]** .|

Aquí encontrará más información sobre los valores de columna:

- **CPU total** indica cuánto trabajo realizaron la función y las funciones llamadas por ella. Los valores altos de CPU total señalan las funciones que consumen más en general.
  
- **Solo CPU** indica cuánto trabajo realizó el código del cuerpo de la función, sin incluir el trabajo de las funciones llamadas por dicha función. Los valores altos de **Solo CPU** pueden indicar un cuello de botella de rendimiento dentro de la propia función.

- **Módulos** El nombre del módulo que contiene la función o el número de módulos que contienen las funciones en un nodo [Código externo].

## <a name="BKMK_External_Code"></a>Ver código externo

Código externo son funciones de los componentes del sistema y del marco que son ejecutadas por el código que usted escribe. El código externo incluye funciones que inician y detienen la aplicación, dibujan la UI, controlan los subprocesos y proporcionan otros servicios de bajo nivel a la aplicación. En la mayoría de los casos, no le interesará el código externo, por lo que la herramienta Uso de CPU reúne las funciones externas de un método de usuario en un nodo **[Código externo]** .
  
Si quiere ver las rutas de acceso a las llamadas de código externo, elija **Mostrar código externo** en la lista **Vista de filtro** y luego **Aplicar**.  
  
![Elija Vista de filtro y, después, Mostrar código externo](../profiling/media/DiagToolsShowExternalCode.png "DiagToolsShowExternalCode")  
  
Tenga en cuenta que muchas cadenas de llamadas de código externo están profundamente anidadas, así que el ancho de la columna Nombre de la función puede superar el ancho de pantalla de todos los monitores, excepto de los más grandes. Si ese es el caso, los nombres de función se muestran como **[…]**.
  
Utilice el cuadro de búsqueda para localizar un nodo que esté buscando y, luego, utilice la barra de desplazamiento horizontal para visualizar los datos.

> [!TIP]
> Si genera perfiles de un código externo que llama a funciones de Windows, asegúrese de que dispone de los archivos .pdb más recientes. Sin estos archivos, las vistas de informe mostrarán nombres de funciones de Windows crípticos y difíciles de entender. Para obtener más información sobre cómo asegurarse de que tiene los archivos necesarios, consulte [Especificar archivos de símbolos (.pdb) y de origen en el depurador](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).
  
## <a name="see-also"></a>Vea también  
 [[Uso de memoria](../profiling/memory-usage.md)
 [Uso de CPU](../profiling/cpu-usage.md)
 [Herramientas de generación de perfiles](../profiling/profiling-tools.md)