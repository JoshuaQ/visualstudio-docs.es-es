---
title: Usar archivos de volcado | Documentos de Microsoft
ms.custom: H1HackMay2017
ms.date: 03/08/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vs.debug.crashdump
dev_langs:
- CSharp
- VB
- FSharp
- C++
- JScript
helpviewer_keywords:
- dumps, about dumps
- crash dumps
- dump files
- dumps
ms.assetid: b71be6dc-57e0-4730-99d2-b540a0863e49
caps.latest.revision: "53"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 179d66b80676cf47bb12e82fcd8e4ac00503a492
ms.sourcegitcommit: 5d43e9590e2246084670b79269cc9d99124bb3df
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/19/2018
---
# <a name="use-dump-files-with-visual-studio"></a>Usar archivos de volcado de memoria con Visual Studio
Archivos de volcado de memoria con o sin montones; crear un archivo de volcado; abrir un archivo de volcado de memoria; buscar los archivos binarios, el del archivo pdb y el archivo de código fuente para un archivo de volcado.
  
##  <a name="BKMK_What_is_a_dump_file_"></a>¿Qué es un archivo de volcado de memoria?  
 A *archivo de volcado* es una instantánea de una aplicación en el punto en el tiempo que se realiza el volcado de memoria. Muestra qué proceso se ejecutaba y qué módulos se cargaron. Si el volcado de memoria se guardó con información de montón, el archivo de volcado de memoria contiene una instantánea de los datos que se encontraban en la memoria de la aplicación en ese momento. Abrir un archivo de volcado de memoria con un montón en Visual Studio es como detener en un punto de interrupción en una sesión de depuración. Aunque no puede continuar la ejecución, puede examinar las pilas, los subprocesos y los valores de las variables de la aplicación cuando se produjo el volcado de memoria.  
  
 Archivos de volcado se utilizan principalmente para depurar problemas que se producen en máquinas que el programador no tiene acceso a. Por ejemplo, puede usar un archivo de volcado de memoria del equipo de un cliente cuando no se puede reproducir el bloqueo del cliente o en su equipo. Los evaluadores también crean volcados de memoria para guardar datos sobre bloqueos y, de este modo, usar la máquina de pruebas para realizar más pruebas. El depurador de Visual Studio puede guardar archivos de volcado de memoria de código administrado o nativo. El depurador puede cargar archivos de volcado de memoria creados por Visual Studio u otros programas que guardan archivos en el *minivolcado* formato.  
  
##  <a name="BKMK_Dump_files__with_or_without_heaps"></a>Archivos de volcado de memoria, con o sin montones  
 Puede crear archivos de volcado de memoria con o sin información del montón.  
  
-   **Archivos con montones de volcado** contienen una instantánea de memoria de la aplicación. Esto incluye los valores de las variables en el momento en que se creó el volcado de memoria. Si carga un archivo de volcado de memoria que se guardó con un montón, Visual Studio puede cargar los símbolos incluso si no se encuentra el archivo binario de la aplicación. Visual Studio también guarda los archivos binarios de los módulos nativos cargados en el archivo de volcado de memoria, lo que puede facilitar mucho más la depuración.  
  
-   **Archivos sin montones de volcado** son mucho menores que los volcados de memoria con información del montón. Sin embargo, el depurador debe cargar los archivos binarios de aplicación para encontrar la información de símbolos. Los archivos binarios deben coincidir exactamente con los archivos binarios que se usaron al crear el volcado de memoria. Solo los valores de las variables de pila se guardan en los archivos de volcado de memoria sin datos de montón.  
  
##  <a name="BKMK_Requirements_and_limitations"></a>Requisitos y limitaciones  
  
-   La depuración de archivos de volcado de memoria de código optimizado puede resultar confusa. Por ejemplo, la inclusión en línea de funciones por parte del compilador puede dar lugar a pilas de llamadas inesperadas y otras optimizaciones podrían cambiar la duración de las variables.  
  
-   Los archivos de volcado de memoria de equipos de 64 bits deben depurarse en una instancia de Visual Studio que se ejecute en un equipo de 64 bits.  
  
-   En versiones de Visual Studio anteriores a VS 2013, los volcados de las aplicaciones de 32 bits que se ejecutaban en equipos de 64 bits recopilados por algunas herramientas (como el Administrador de tareas y WinDbg de 64 bits) no se podían abrir en Visual Studio. Esta limitación se ha eliminado en VS 2013.  
  
-   Visual Studio puede depurar archivos de volcado de memoria de aplicaciones nativas desde dispositivos ARM. Visual Studio también puede depurar archivos de volcado de memoria de aplicaciones administradas desde dispositivos ARM pero solo en el depurador nativo.  
  
-   Para depurar [modo kernel](http://msdn.microsoft.com/library/windows/hardware/ff551880.aspx) archivos de volcado, descargue las herramientas de depuración para Windows que forma parte de la [Windows Driver Kit (WDK)](/windows/hardware/windows-driver-kit). 
  
-   Visual Studio no puede depurar archivos de volcado de memoria guardados en el formato de volcado de memoria anterior conocido como un [volcado completo en modo usuario](http://msdn.microsoft.com/library/windows/hardware/ff545506.aspx). Tenga en cuenta que un volcado de memoria completo en modo usuario no es igual que un volcado de memoria con montón.  
  
-   Para depurar con la [SOS.dll (extensión de depuración de SOS)](/dotnet/framework/tools/sos-dll-sos-debugging-extension) en Visual Studio, debe instalar las herramientas de depuración para Windows que forma parte de la [Windows Driver Kit (WDK)](/windows/hardware/windows-driver-kit) 
  
##  <a name="BKMK_Create_a_dump_file"></a>Crear un archivo de volcado de memoria  
 Para crear un archivo de volcado de memoria con Visual Studio:  
  
-   Mientras depura un proceso en Visual Studio, puede guardar un archivo de volcado de memoria cuando el depurador se ha detenido en una excepción o en un punto de interrupción. Elija **depurar**, a continuación, **Guardar volcado como**, a continuación, **depurar**. En el **Guardar volcado como** cuadro de diálogo, en la **Guardar como tipo** lista, puede seleccionar **minivolcado** o **minivolcado con montón** (valor predeterminado).  
  
-   Con [depuración Just](../debugger/just-in-time-debugging-in-visual-studio.md) habilitado, puede asociar el depurador a un proceso bloqueado que se ejecuta fuera del depurador y, a continuación, guardar un archivo de volcado. Vea [adjuntar a procesos en ejecución](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)  
  
 También puede crear archivos de volcado de memoria con cualquier programa que admita el formato de minivolcado de Windows. Por ejemplo, el **Procdump** utilidad de línea de comandos de [Windows Sysinternals](http://technet.microsoft.com/sysinternals/default) puede crear archivos de volcado de bloqueo de proceso basados en desencadenadores o a petición. Vea [requisitos y limitaciones](../debugger/using-dump-files.md#BKMK_Requirements_and_limitations) en este tema para obtener información adicional acerca del uso de otras herramientas para crear archivos de volcado de memoria. 
  
##  <a name="BKMK_Open_a_dump_file"></a>Abrir un archivo de volcado de memoria  
  
1.  En Visual Studio, elija **archivo**, **abiertos**, **archivo**.  
  
2.  En el **archivos abiertos** diálogo cuadro, busque y seleccione el archivo de volcado. Normalmente, tendrá la extensión .dmp. A continuación, elija **Aceptar**.  
  
3.  El **resumen del archivo de volcado de memoria** aparecerá la ventana. En esta ventana, puede ver información de resumen de depuración para el archivo de volcado de memoria, establecer la ruta de acceso de símbolos, iniciar la depuración y copiar la información de resumen en el portapapeles.  
  
     ![Página de resumen de minivolcado](../debugger/media/dbg_dump_summarypage.png "DBG_DUMP_SummaryPage")  
  
4.  Para iniciar la depuración, vaya a la **acciones** sección y elija **depurar con solo administrado**, **depurar con solo nativo** o **depurar con mixto**.  
  
##  <a name="BKMK_Find_binaries__symbol___pdb__files__and_source_files"></a>Buscar archivos binarios, archivos de símbolos (.pdb) y archivos de código fuente  
 Para utilizar todas las características de Visual Studio para depurar un archivo de volcado de memoria, necesita acceso a:  
  
-   El archivo .exe para el que se ha realizado el volcado de memoria y otros archivos binarios (archivos DLL, etc.) usados en el proceso de volcado de memoria.  
  
     Si está depurando un volcado de memoria con datos del montón, Visual Studio puede solventar el problema de que falten archivos binarios de algunos módulos, pero debe tener archivos binarios para suficientes módulos para poder generar pilas de llamadas válidas. Visual Studio incluye los módulos nativos en un archivo de volcado de memoria con el montón.  
  
-   Archivos de símbolos (.pdb) del archivo .exe y otros archivos binarios.  
  
-   Archivos de código fuente de los módulos que le interesan.  
  
     El archivo ejecutable y los archivos .pdb deben coincidir exactamente con la versión y la compilación de los archivos utilizados en el momento en el que se creó el volcado de memoria.  
  
     Puede depurar utilizando el desensamblado de los módulos si no se puede encontrar los archivos de origen,  
  
 **Rutas de búsqueda predeterminadas de los archivos ejecutables**  
  
 Visual Studio busca automáticamente en estas ubicaciones de los archivos ejecutables que no se incluyen en el archivo de volcado:  
  
1.  Directorio que contiene el archivo de volcado de memoria.  
  
2.  Ruta de acceso del módulo que se especifica en el archivo de volcado de memoria. Es la ruta de acceso del módulo en el equipo en el que se recopiló el volcado de memoria.  
  
3.  Las rutas de acceso de símbolos especificadas en el **depuración**, **opciones**, **símbolos** página de Visual Studio **herramientas**, **opciones**  cuadro de diálogo. Puede agregar más ubicaciones que desee buscar en esta página.  
  
 **Uso No binarias > Símbolo > páginas de origen**  
  
 Si Visual Studio no puede encontrar los archivos necesarios para depurar un módulo en el volcado de memoria, mostrará la página correspondiente (**se encontró ningún binario**, **No se encontraron símbolos**, o **se encontró ningún origen**). Estas páginas ofrecen información detallada acerca de la causa del problema y proporcionan vínculos de acción que pueden ayudarle a identificar la ubicación correcta de los archivos. Vea [especificar símbolos (.pdb) y archivos de código fuente](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).  
  
## <a name="see-also"></a>Vea también  
 [Depuración Just-In-Time](../debugger/just-in-time-debugging-in-visual-studio.md)   
 [Especificar los símbolos (.pdb) y archivos de código fuente](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)   
 [IntelliTrace](../debugger/intellitrace.md)