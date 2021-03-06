---
title: "Tutorial: Depurar una aplicación paralela | Documentos de Microsoft"
ms.custom: H1HackMay2017
ms.date: 05/18/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- CSharp
- VB
- FSharp
- C++
helpviewer_keywords:
- debugger, parallel tasks walkthrough
- parallel stacks toolwindow
- parallel tasks toolwindow
- parallel applications, debugging [C++]
- debugging, parallel applications
- parallel applications, debugging [Visual Basic]
- parallel applications, debugging [C#]
ms.assetid: 2820ac4c-c893-4d87-8c62-83981d561493
caps.latest.revision: "28"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: b05192c2d57c280cef970d4b8887ff7eadbb27b9
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="walkthrough-debugging-a-parallel-application-in-visual-studio"></a>Tutorial: Depurar una aplicación paralela en Visual Studio
Este tutorial muestra cómo utilizar el **tareas paralelas** y **pilas paralelas** windows para depurar una aplicación paralela. Estas ventanas ayudan a entender y comprobar el comportamiento en tiempo de ejecución del código que usa el [tarea Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl) o [Runtime de simultaneidad](/cpp/parallel/concrt/concurrency-runtime). En este tutorial se proporciona código de muestra con puntos de interrupción integrados. Después de que el código se interrumpe, se muestra cómo utilizar el **tareas paralelas** y **pilas paralelas** windows para examinarlo.  
  
 Se enseñan estas tareas:  
  
-   Cómo ver las pilas de llamadas de todos los subprocesos en una vista.  
  
-   Cómo ver la lista de instancias de `System.Threading.Tasks.Task` que se crean en la aplicación.  
  
-   Cómo ver las pilas de llamadas reales de las tareas en lugar de los subprocesos.  
  
-   Cómo navegar al código desde el **tareas paralelas** y **pilas paralelas** windows.  
  
-   Cómo trabajan las ventanas con la escala de tamaño mediante la agrupación, el zoom y otras características relacionadas.  
  
## <a name="prerequisites"></a>Requisitos previos  
 En este tutorial se da por supuesto que **solo mi código** está habilitada (está habilitada de forma predeterminada en las versiones más recientes de Visual Studio). En el **herramientas** menú, haga clic en **opciones**, expanda la **depuración** nodo, seleccione **General**y, a continuación, seleccione **habilitar Solo mi código (solo administrado)**. Si no configura esta característica, puede utilizar este tutorial, pero los resultados pueden diferir de las ilustraciones.  
  
## <a name="c-sample"></a>Ejemplo de C#  
 Si utiliza el ejemplo de C#, también se supone que Código externo está oculto. Para alternar si se muestra el código externo, haga clic en el **nombre** encabezado de la tabla de la **pila de llamadas** ventana y luego active o desactive **mostrar código externo**. Si no configura esta característica, puede utilizar este tutorial, pero los resultados pueden diferir de las ilustraciones.  
  
## <a name="c-sample"></a>Ejemplo de C++  
 Si utiliza el ejemplo C++, puede omitir las referencias a Código externo de este tema. El código externo solo se aplica en el ejemplo de C#.  
  
## <a name="illustrations"></a>Ilustraciones  
 Las ilustraciones de este tema se grabaron en un equipo básico quad core que ejecuta el ejemplo de C#. Aunque puede utilizar otras configuraciones para completar este tutorial, las ilustraciones pueden diferir de lo que se muestra en su equipo.  
  
## <a name="creating-the-sample-project"></a>Crear el proyecto de muestra  
 El código de ejemplo de este tutorial es para una aplicación que no hace nada. El objetivo es entender cómo utilizar las ventanas de herramientas para depurar una aplicación paralela.  
  
#### <a name="to-create-the-sample-project"></a>Para crear el proyecto de ejemplo  
  
1.  En el menú **Archivo** de Visual Studio, apunte a **Nuevo** y haga clic en **Proyecto**.  
  
2.  En el **plantillas instaladas** panel, seleccione Visual C#, Visual Basic o Visual C++. En los lenguajes administrados, asegúrese de que aparece [!INCLUDE[net_v40_short](../code-quality/includes/net_v40_short_md.md)] en el cuadro del marco.  
  
3.  Seleccione **aplicación de consola** y, a continuación, haga clic en **Aceptar**. Mantenga la configuración Debug, que es el valor predeterminado.  
  
4.  Abra el archivo de código .cpp, .cs o .vb del proyecto. Elimine su contenido para crear un archivo de código vacío.  
  
5.  En el archivo de código vacío, pegue el siguiente código en el lenguaje elegido.  
  
 [!code-csharp[Debugger#1](../debugger/codesnippet/CSharp/walkthrough-debugging-a-parallel-application_1.cs)]
 [!code-cpp[Debugger#1](../debugger/codesnippet/CPP/walkthrough-debugging-a-parallel-application_1.cpp)]
 [!code-vb[Debugger#1](../debugger/codesnippet/VisualBasic/walkthrough-debugging-a-parallel-application_1.vb)]  
  
1.  En el **archivo** menú, haga clic en **guardar todo**.  
  
2.  En el **generar** menú, haga clic en **volver a generar solución**.  
  
     Observe que hay cuatro llamadas a `Debugger.Break` (`DebugBreak` en el ejemplo de C++). Por tanto, no tiene que insertar puntos de interrupción; simplemente ejecutando la aplicación, el depurador se interrumpirá cuatro veces.  
  
## <a name="using-the-parallel-stacks-window-threads-view"></a>Utilizar la ventana Pilas paralelas: vista de subprocesos  
 En el menú **Depurar**, haga clic en **Iniciar depuración**. Espere a que se alcance el primer punto de interrupción.  
  
#### <a name="to-view-the-call-stack-of-a-single-thread"></a>Para ver la pila de llamadas de un subproceso  
  
1.  En el **depurar** menú, elija **Windows** y, a continuación, haga clic en **subprocesos**. Acoplar el **subprocesos** ventana en la parte inferior de Visual Studio.  
  
2.  En el **depurar** menú, elija **Windows** y, a continuación, haga clic en **pila de llamadas**. Acoplar el **pila de llamadas** ventana en la parte inferior de Visual Studio.  
  
3.  Haga doble clic en un subproceso en el **subprocesos** ventana para que sea el actual. Los subprocesos actuales tienen una flecha amarilla. Al cambiar el subproceso actual, la pila de llamadas se muestra en el **pila de llamadas** ventana.  
  
#### <a name="to-examine-the-parallel-stacks-window"></a>Para examinar la ventana Pilas paralelas  
  
1.  En el **depurar** menú, elija **Windows** y, a continuación, haga clic en **pilas paralelas**. Asegúrese de que **subprocesos** está seleccionado en el cuadro situado en la esquina superior izquierda.  
  
     Mediante el uso de la **pilas paralelas** ventana, puede ver varias pilas de llamadas al mismo tiempo en una vista. La siguiente ilustración muestra la **pilas paralelas** ventana anterior la **pila de llamadas** ventana.  
  
     ![Vista en la ventana Pilas paralelas de subprocesos](../debugger/media/pdb_walkthrough_1.png "PDB_Walkthrough_1")  
  
     La pila de llamadas del subproceso principal aparece en un cuadro y las pilas de llamadas de los otros cuatro subprocesos están agrupadas en otro cuadro. Se agrupan cuatro subprocesos porque sus marcos de pila comparten los mismos contextos de método, es decir, están en los mismos métodos: `A`, `B` y `C`. Para ver los identificadores y los nombres de los subprocesos que comparten el mismo cuadro, mantenga el mouse sobre el encabezado (**4 subprocesos**). El subproceso actual se muestra en negrita, como en la siguiente ilustración.  
  
     ![Información sobre herramientas que muestra los nombres e identificadores de subproceso](../debugger/media/pdb_walkthrough_1a.png "PDB_Walkthrough_1A")  
  
     La flecha amarilla indica el marco de pila activo del subproceso actual. Para obtener más información, desplace el puntero del mouse sobre él  
  
     ![Información sobre herramientas en marco de pila activo](../debugger/media/pdb_walkthrough_1b.png "PDB_Walkthrough_1B")  
  
     Puede establecer el grado de detalle desea mostrar para los marcos de pila (**nombres de módulo**, **tipos de parámetro**, **nombres de parámetro**, **valores de parámetro**, **Números de línea** y **desplazamientos de bytes**) con el botón secundario en el **pila de llamadas** ventana.  
  
     Un resaltado azul alrededor de un cuadro indica que el subproceso actual forma parte de ese cuadro. El subproceso actual también está indicado por el marco de pila en negrita de la información sobre herramientas. Si hace doble clic en el subproceso principal en la ventana subprocesos, puede observar que el resaltado azul de la **pilas paralelas** ventana se moverá en consecuencia.  
  
     ![Subproceso principal resaltado en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_1c.png "PDB_Walkthrough_1C")  
  
#### <a name="to-resume-execution-until-the-second-breakpoint"></a>Para reanudar la ejecución hasta el segundo punto de interrupción  
  
1.  Para reanudar la ejecución hasta el segundo punto de interrupción en la **depurar** menú, haga clic en **continuar**. La siguiente ilustración muestra el árbol de subproceso en el segundo punto de interrupción.  
  
     ![Ventana Pilas paralelas muchas bifurcaciones](../debugger/media/pdb_walkthrough_2.png "PDB_Walkthrough_2")  
  
     En el primer punto de interrupción, cuatro subprocesos fueron de S.A a S.B a los métodos S.C. Que información todavía está visible en el **pilas paralelas** ventana, pero los cuatro subprocesos han progresado más. Uno de ellos continuó a S.D y a S.E. Otro continuó hasta S.F, S.G y S.H. Los otros dos continuaron a S.I y S.J, y de allí uno fue a S.K y el otro continuó a código externo de no usuario.  
  
     Puede mantener el mouse sobre el encabezado del cuadro, por ejemplo, **1 subproceso** o **2 subprocesos**, para ver los identificadores de los subprocesos de subproceso. Puede desplazar el puntero del mouse sobre los marcos de pila para ver identificadores de subproceso y otros detalles del marco. El resaltado azul indica el subproceso actual y la flecha amarilla indica el marco de pila activo del subproceso actual.  
  
     El icono de los subprocesos (las líneas onduladas azules y rojas superpuestas) indica los marcos de pila activos de los subprocesos que no son el actual. En el **pila de llamadas** ventana, haga doble clic en S.B para intercambiar los marcos. El **pilas paralelas** ventana indica que el marco de pila actual del subproceso actual utilizando un icono de flecha verde y curvada.  
  
     En el **subprocesos** ventana, intercambie entre los subprocesos y observe que la vista en la **pilas paralelas** se actualiza la ventana.  
  
     Puede cambiar a otro subproceso o a otro marco de otro subproceso, utilizando el menú contextual de la **pilas paralelas** ventana. Por ejemplo, haga clic en S.J, apunte a **cambiar a marco**y, a continuación, haga clic en un comando.  
  
     ![Ruta de acceso de ejecución de pilas paralelas](../debugger/media/pdb_walkthrough_2b.png "PDB_Walkthrough_2B")  
  
     Haga clic en S.C y señale a **cambiar a marco**. Uno de los comandos tiene una marca de verificación que indica el marco de pila del subproceso actual. Puede cambiar a ese marco del mismo subproceso (la flecha verde se moverá) o puede cambiar al otro subproceso (el resaltado azul también moverá). La ilustración siguiente muestra los submenús.  
  
     ![Menú pilas con 2 opciones en C mientras actual es el J](../debugger/media/pdb_walkthrough_3.png "PDB_Walkthrough_3")  
  
     Cuando un contexto de método está asociado a un solo marco de pila, se muestra el encabezado del cuadro **1 subproceso** y puede cambiar a él haciendo doble clic en. Si hace doble clic en un contexto de método que tiene más que un marco asociado, el menú se abre automáticamente. Cuando desplace el puntero del mouse sobre los contextos de método, observe el triángulo negro a la derecha. Al hacer clic en ese triángulo, también se muestra el menú contextual.  
  
     Con aplicaciones grandes que tienen muchos subprocesos, le interesa centrarse en un subconjunto de subprocesos. El **pilas paralelas** ventana puede mostrar las pilas de llamadas solo para los subprocesos marcados. En la barra de herramientas, haga clic en el **mostrar marcadas únicamente** situado junto al cuadro de lista.  
  
     ![Vaciar la ventana Pilas paralelas y la información sobre herramientas](../debugger/media/pdb_walkthrough_3a.png "PDB_Walkthrough_3A")  
  
     Después, en la **subprocesos** ventana, marque los subprocesos uno por uno para ver cómo sus pilas de llamadas aparecen en la **pilas paralelas** ventana. Para marcar subprocesos, utilice el menú contextual o la primera celda de un subproceso. Haga clic en el **mostrar marcadas únicamente** botón de barra de herramientas para mostrar todos los subprocesos.  
  
#### <a name="to-resume-execution-until-the-third-breakpoint"></a>Para reanudar la ejecución hasta el tercer punto de interrupción  
  
1.  Para reanudar la ejecución hasta el tercer punto de interrupción en la **depurar** menú, haga clic en **continuar**.  
  
     Cuando varios subprocesos están en el mismo método pero el método no estaba al principio de la pila de llamadas, el método aparece en cuadros diferentes. Un ejemplo en el punto de interrupción actual es S.L, que tiene tres subprocesos y aparece en tres cuadros. Haga doble clic en S.L.  
  
     ![Ruta de acceso de ejecución en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_3b.png "PDB_Walkthrough_3B")  
  
     Observe que S.L está en negrita en los otros dos cuadros para que pueda ver dónde más aparece. Si desea ver qué marcos llaman a S.L y a qué marcos llama, haga clic en el **Alternar vista de método** botón en la barra de herramientas. En la siguiente ilustración muestra la vista de método de la **pilas paralelas** ventana.  
  
     ![Vista de método en la ventana Pilas paralelas](../debugger/media/pdw_walkthrough_4.png "PDW_Walkthrough_4")  
  
     Observe cómo el diagrama se monta en el método seleccionado y lo coloca en su propio cuadro en el medio de la vista. Los destinatarios y llamadores aparecen en la parte superior e inferior. Haga clic en el **Alternar vista de método** botón nuevo para dejar este modo.  
  
     El menú contextual de la **pilas paralelas** ventana también tiene los siguientes otros elementos.  
  
    -   **Presentación hexadecimal** alterna los números de la información sobre herramientas entre decimal y hexadecimal.  
  
    -   **Cargar la información de símbolos** y **configuración de símbolos** abrir los cuadros de diálogo respectivos.  
  
    -   **Ir al código fuente** y **ir al desensamblado** navegan en el editor hasta el método seleccionado.  
  
    -   **Mostrar código externo** muestra todos los marcos aun cuando no estén en código de usuario. Pruébelo para ver el diagrama expandirse para alojar los marcos adicionales (que pueden estar atenuados porque no tiene símbolos para ellos).  
  
     Si tiene diagramas grandes y pasa al punto de interrupción siguiente, tal vez le interese la vista para desplazarse de forma automática al marco de pila activo del subproceso actual, es decir, el subproceso que alcanzó primero el punto de interrupción. En el **pilas paralelas** ventana, asegúrese de que el **desplazar automáticamente a marco de pila actual** botón de la barra de herramientas.  
  
     ![Desplazamiento automático en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_4a.png "PDB_Walkthrough_4A")  
  
2.  Antes de continuar, en la **pilas paralelas** ventana, desplácese completamente hacia a la izquierda o hacia abajo.  
  
#### <a name="to-resume-execution-until-the-fourth-breakpoint"></a>Para reanudar la ejecución hasta el cuarto punto de interrupción  
  
1.  Para reanudar la ejecución hasta el cuarto punto de interrupción en la **depurar** menú, haga clic en **continuar**.  
  
     Observe cómo la vista se desplaza automáticamente para ocupar su lugar. Alterne los subprocesos en la **subprocesos** marcos de pila de conmutador o ventana en la **pila de llamadas** ventana y observe cómo la vista siempre se desplaza automáticamente hasta el marco correcto. Desactivar **desplazar automáticamente a marco de pila actual** opción y ver la diferencia.  
  
     El **vista aérea** también ayuda a diagramas grandes en la **pilas paralelas** ventana. Puede ver el **vista aérea** haciendo clic en el botón situado entre las barras de desplazamiento en la esquina inferior derecha de la ventana, tal como se muestra en la siguiente ilustración.  
  
     ![De pájaro &#45; ojo ver en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_5.png "PDB_Walkthrough_5")  
  
     Puede mover el rectángulo para hacer una rápida panorámica del diagrama.  
  
     Otra manera de mover el diagrama en cualquier dirección es haciendo clic en un área en blanco del diagrama y arrastrando al lugar deseado.  
  
     Para acercar y alejar, mantenga presionada la tecla CTRL mientras mueve la rueda del mouse. Alternativamente, haga clic en el botón Zoom en la barra de herramientas y utilice la herramienta Zoom.  
  
     ![Ampliada pilas en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_5a.png "PDB_Walkthrough_5A")  
  
     También puede ver las pilas en dirección descendente en lugar de abajo arriba, haciendo clic en el **herramientas** menú, haga clic en **opciones**y, a continuación, active o desactive la opción situada debajo del **depuración** nodo.  
  
2.  Antes de continuar, en la **depurar** menú, haga clic en **Detener depuración** para finalizar la ejecución.  
  
## <a name="using-the-parallel-tasks-window-and-the-tasks-view-of-the-parallel-stacks-window"></a>Utilizar la ventana Tareas paralelas y la vista Tareas de la ventana Pilas paralelas  
 Recomendamos completar los procedimientos anteriores antes de continuar.  
  
#### <a name="to-restart-the-application-until-the-first-breakpoint-is-hit"></a>Para reiniciar la aplicación hasta que alcance el primer punto de interrupción  
  
1.  En el **depurar** menú, haga clic en **Iniciar depuración** y espere a que el primer punto de interrupción se va a alcanzar.  
  
2.  En el **depurar** menú, elija **Windows** y, a continuación, haga clic en **subprocesos**. Acoplar el **subprocesos** ventana en la parte inferior de Visual Studio.  
  
3.  En el **depurar** menú, elija **Windows** y haga clic en **pila de llamadas**. Acoplar el **pila de llamadas** ventana en la parte inferior de Visual Studio.  
  
4.  Haga doble clic en un subproceso en el **subprocesos** ventana para que sea el actual. Los subprocesos actuales tienen la flecha amarilla. Al cambiar el subproceso actual, las otras ventanas se actualizan. A continuación, examinaremos las tareas.  
  
5.  En el **depurar** menú, elija **Windows** y, a continuación, haga clic en **tareas paralelas**. La siguiente ilustración muestra la **tareas** ventana.  
  
     ![Cuatro ejecuta las tareas en la ventana tareas](../debugger/media/pdw_walkthrough_6.png "PDW_Walkthrough_6")  
  
     Por cada tarea que se esté ejecutando, puede leer su identificador, que devuelve la propiedad del mismo nombre, el identificador y nombre del subproceso que lo ejecuta, su ubicación (desplazando el puntero del mouse para mostrar una información sobre herramientas con la pila de llamadas completa). Asimismo, en la **tarea** columna, puede ver el método que se pasó a la tarea; en otras palabras, el punto inicial.  
  
     Puede ordenar cualquier columna. Observe el glifo de ordenación que indica la columna y la dirección de ordenación. También puede reordenar las columnas arrastrándolas a izquierda o derecha.  
  
     La flecha amarilla indica la tarea actual. Puede intercambiar las tareas haciendo doble clic en una tarea o utilizando el menú contextual. Al intercambiar las tareas, el subproceso subyacente pasa a ser el actual y las demás ventanas se actualizan.  
  
     Cuando pasa manualmente de una tarea a otra, la flecha amarilla se mueve, pero una flecha blanca sigue mostrando la tarea que hizo que el depurador se interrumpiera.  
  
#### <a name="to-resume-execution-until-the-second-breakpoint"></a>Para reanudar la ejecución hasta el segundo punto de interrupción  
  
1.  Para reanudar la ejecución hasta el segundo punto de interrupción en la **depurar** menú, haga clic en **continuar**.  
  
     Anteriormente, el **estado** columna mostraba todas las tareas como en ejecución, pero ahora dos de las tareas están en espera. Las tareas se pueden bloquear por muchas razones diferentes. En el **estado** columna, mantenga el mouse sobre una tarea en espera para saber por qué está bloqueada. Por ejemplo, en la siguiente ilustración, la tarea 3 está esperando a la tarea 4.  
  
     ![Dos tareas en espera en la ventana tareas](../debugger/media/pdb_walkthrough_7.png "PDB_Walkthrough_7")  
  
     La tarea 4, a su vez, está esperando a un monitor que pertenece al subproceso asignado a la tarea 2.  
  
     ![Tarea en espera e información sobre herramientas en la ventana tareas](../debugger/media/pdb_walkthrough_7a.png "PDB_Walkthrough_7A")  
  
     También puede marcar una tarea haciendo clic en la marca de la primera columna de la **tareas** ventana.  
  
     Puede utilizar las marcas para realizar el seguimiento de las tareas entre los puntos de interrupción diferentes en la misma sesión de depuración o filtrar por las tareas cuyas pilas de llamadas se muestren en la **pilas paralelas** ventana.  
  
     Cuando usa el **pilas paralelas** ventana anteriormente, vio los subprocesos de la aplicación. Ver el **pilas paralelas** ventana nuevo, pero esta vez observe las tareas de la aplicación. Haga esto seleccionando **tareas** en el cuadro en la parte superior izquierda. En la siguiente ilustración se muestra la vista Tareas.  
  
     ![Vista en la ventana Pilas paralelas de subprocesos](../debugger/media/pdb_walkthrough_8.png "PDB_Walkthrough_8")  
  
     Subprocesos que no están ejecutando tareas actualmente no se muestran en la vista tareas de la **pilas paralelas** ventana. Asimismo, con los subprocesos que ejecutan tareas, algunos de los marcos de pila que no son pertinentes para las tareas se filtran de la parte superior e inferior de la pila.  
  
     Ver el **tareas** ventana de nuevo. Haga clic con el botón secundario en cualquier encabezado de columna para ver un menú contextual de la columna.  
  
     ![Menú de vista contextual en la ventana tareas](../debugger/media/pdb_walkthrough_8a.png "PDB_Walkthrough_8A")  
  
     Puede utilizar el menú contextual para agregar o quitar las columnas. Por ejemplo, la columna AppDomain no está seleccionada; por consiguiente, no se muestra en la lista. Haga clic en **primario**. El **primario** columna aparece sin valores para las cuatro tareas.  
  
#### <a name="to-resume-execution-until-the-third-breakpoint"></a>Para reanudar la ejecución hasta el tercer punto de interrupción  
  
1.  Para reanudar la ejecución hasta el tercer punto de interrupción en la **depurar** menú, haga clic en **continuar**.  
  
     Ahora se está ejecutando una nueva tarea, la tarea 5, y la tarea 4 está en espera. Puede ver por qué desplazando el puntero sobre la tarea en espera la **estado** ventana. En el **primario** columna, observe que la tarea 4 es el elemento primario de la tarea 5.  
  
     Para ver mejor la relación de elementos primarios y secundarios, haga clic en el **primario** encabezado de columna y, a continuación, haga clic en **vista de elemento primario**. Vea la ilustración siguiente:  
  
     ![Elemento primario &#45; secundarios ver en la ventana tareas](../debugger/media/pdb_walkthrough_9.png "PDB_Walkthrough_9")  
  
     Observe que la tarea 4 y 5 se están ejecutando en el mismo subproceso. Esta información no se muestra en el **subprocesos** ventana; poder verlo aquí es otra ventaja de la **tareas** ventana. Para confirmar esto, vea la **pilas paralelas** ventana. Asegúrese de que está viendo **tareas**. Busque las tareas 4 y 5 haciendo doble clic en ellos en el **tareas** ventana. Al hacerlo, el resaltado azul el **pilas paralelas** se actualiza la ventana. También puede buscar las tareas 4 y 5 examinando la información sobre herramientas en el **pilas paralelas** ventana.  
  
     ![Vista en la ventana Pilas paralelas de tareas](../debugger/media/pdb_walkthrough_9a.png "PDB_Walkthrough_9A")  
  
     En el **pilas paralelas** ventana, haga clic en S.P y, a continuación, haga clic en **ir al subproceso**. La ventana cambia a la vista de subprocesos y el marco correspondiente está a la vista. Puede ver ambas tareas en el mismo subproceso.  
  
     ![Resalta el subproceso en la vista de subprocesos](../debugger/media/pdb_walkthrough_9b.png "PDB_Walkthrough_9B")  
  
     Esta es otra ventaja de la vista de tareas en el **pilas paralelas** ventana, en comparación con el **subprocesos** ventana.  
  
#### <a name="to-resume-execution-until-the-fourth-breakpoint"></a>Para reanudar la ejecución hasta el cuarto punto de interrupción  
  
1.  Para reanudar la ejecución hasta el tercer punto de interrupción en la **depurar** menú, haga clic en **continuar**. Haga clic en el **identificador** encabezado de columna para ordenar por identificador. Vea la ilustración siguiente:  
  
     ![Cuatro estados de tarea en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_10.png "PDB_Walkthrough_10")  
  
     Como la tarea 5 se ha completado, ya no se muestra. Si no es el caso en su equipo y no se muestra el interbloqueo, avance un paso presionando F11.  
  
     Las tareas 3 y 4 se están esperando mutuamente y están interbloqueadas. Hay también 5 nuevas tareas que son elementos secundarios de la tarea 2 y se programan ahora. Las tareas programadas son tareas que se han iniciado en código pero no se han ejecutado todavía. Por lo tanto, sus **ubicación** y **asignación de subproceso** columnas están vacías.  
  
     Ver el **pilas paralelas** ventana de nuevo. El encabezado de cada cuadro tiene una información sobre herramientas que muestra los identificadores y los nombres de los subprocesos. Cambie a la vista de tareas en el **pilas paralelas** ventana. Desplace el puntero del mouse sobre un encabezado para ver el identificador, el nombre y el estado de la tarea, como se muestra en la siguiente ilustración.  
  
     ![Información sobre herramientas de encabezado en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_11.png "PDB_Walkthrough_11")  
  
     Puede agrupar las tareas por columna. En el **tareas** ventana, haga clic en el **estado** encabezado de columna y, a continuación, haga clic en **Agrupar por estado**. La siguiente ilustración muestra la **tareas** ventana agrupados por estado.  
  
     ![Agrupar tareas en la ventana tareas](../debugger/media/pdb_walkthrough_12.png "PDB_Walkthrough_12")  
  
     También puede agrupar por cualquier otra columna. Agrupando las tareas, se puede concentrar en un subconjunto de tareas. Cada grupo contraíble tiene un recuento de los elementos que están agrupados. También puede marcar rápidamente todos los elementos en el grupo, haga clic en el **marca** situado a la derecha de la **contraer** botón.  
  
     ![Agrupan pilas en la ventana Pilas paralelas](../debugger/media/pdb_walkthrough_12a.png "PDB_Walkthrough_12A")  
  
     La última característica de la **tareas** ventana para examinar es el menú contextual que aparece cuando hace clic en una tarea.  
  
     ![Menú contextual en la ventana tareas](../debugger/media/pdb_walkthrough_12b.png "PDB_Walkthrough_12B")  
  
     El menú contextual muestra comandos diferentes, dependiendo del estado de la tarea. Los comandos pueden incluir **copia**, **seleccionar todo**, **presentación Hexadecimal**, **pasar a la tarea**, **inmovilizar asignado Subprocesos**, **inmovilizar todos los subprocesos, pero esto**, y **Reanudar subproceso asignado**, y **marca**.  
  
     Puede inmovilizar el subproceso subyacente de una o varias tareas, y puede inmovilizar todos los subprocesos exceptuando el asignado. Un subproceso inmovilizado se representa en el **tareas** ventana tal y como está en el **subprocesos** ventana por un azul *pausar* icono.  
  
## <a name="summary"></a>Resumen  
 Este tutorial se han mostrado las **tareas paralelas** y **pilas paralelas** ventanas del depurador. Utilice estas ventanas en los proyectos reales que utilizan código multithreading. Puede examinar código paralelo escrito en C++, C# o Visual Basic.  
  
## <a name="see-also"></a>Vea también  
 [Depurar aplicaciones multiproceso](../debugger/walkthrough-debugging-a-parallel-application.md)   
 [Conceptos básicos del depurador](../debugger/debugger-basics.md)   
 [Depurar código administrado](../debugger/debugging-managed-code.md)   
 [Parallel Programming](/dotnet/standard/parallel-programming/index)  (Programación en paralelo)  
 [Runtime de simultaneidad](/cpp/parallel/concrt/concurrency-runtime)   
 [Mediante la ventana Pilas paralelas](../debugger/using-the-parallel-stacks-window.md)   
 [Usar la ventana Tareas](../debugger/using-the-tasks-window.md)