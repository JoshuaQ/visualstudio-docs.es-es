---
title: Plantilla de proyectos de servicios en la nube de Azure para Python | Microsoft Docs
ms.custom: 
ms.date: 4/10/2017
ms.prod: visual-studio-dev15
ms.reviewer: 
ms.suite: 
ms.technology:
- devlang-python
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: a2ce82ee-8c73-419a-bbd2-4c3513fd394d
caps.latest.revision: 11
author: kraigb
ms.author: kraigb
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
ms.sourcegitcommit: 9328c347d548a03a536cea16bd5851817c03d5a2
ms.openlocfilehash: 5dd1c40c925327c9494e3a334cdf348692a4981d
ms.lasthandoff: 04/10/2017

---

# <a name="azure-cloud-service-projects-for-python"></a>Proyectos de servicios en la nube de Azure para Python

Visual Studio proporciona plantillas para ayudarle a empezar a crear Azure Cloud Services con Python.

Un [servicio en la nube](http://go.microsoft.com/fwlink/?LinkId=306052) consta de cualquier número de *roles de trabajo* y *roles web*, cada uno de los cuales realiza una tarea conceptualmente independiente, pero se puede replicar por separado entre máquinas virtuales según sea necesario para escalar. Los roles web proporcionan hospedaje para aplicaciones web de front-end. En lo que se refiere a Python, cualquier marco web que admita WSGI se puede utilizar para escribir este tipo de aplicación (tal como admite la [plantilla de proyecto Web](template-web.md)). Los roles de trabajo están pensados para procesos de larga ejecución que no interactúan directamente con los usuarios. Dichos usuarios normalmente usan las bibliotecas de [datos](http://go.microsoft.com/fwlink/?LinkId=401571) y del [servicio de aplicaciones](http://go.microsoft.com/fwlink/?LinkId=401572), que se pueden instalar con `pip install`&nbsp;[`azure`](http://pypi.org/project/azure).

Este tema contiene detalles sobre la plantilla de proyecto y otra compatibilidad en Visual Studio 2017 (las versiones anteriores son similares, pero con algunas diferencias). Para más información sobre el trabajo con Azure desde Python, visite el [Centro para desarrolladores de Python para Azure](http://go.microsoft.com/fwlink/?linkid=254360).

## <a name="create-a-project"></a>Crear un proyecto

1. Instale el [SDK de .NET de Azure para Visual Studio](https://www.visualstudio.com/vs/azure-tools/), que se necesita para usar la plantilla de servicios en la nube.
1. En Visual Studio, seleccione **Archivo > Nuevo > Proyecto...**, busque "Azure Python" y seleccione **Servicio en la nube Azure** en la lista:

    ![Plantilla de proyectos en la nube de Azure para Python](media/template-azure-cloud-project.png)

1. Seleccione uno o varios roles para incluir. Los proyectos en la nube pueden combinar roles escritos en diferentes lenguajes, por lo que puede escribir fácilmente cada parte de la aplicación en el lenguaje más adecuado. Para agregar nuevos roles al proyecto después de completar este cuadro de diálogo, haga clic con el botón derecho en **Roles** en el Explorador de soluciones y seleccione uno de los elementos bajo **Agregar**.

    ![Incorporación de roles en la plantilla de proyectos en la nube de Azure](media/template-azure-cloud-service-project-wizard.png)

1. Cuando se crean los proyectos de rol individuales, es posible que se le pida instalar paquetes de Python adicionales, como los marcos de Django, Bottle o Flask si ha seleccionado un rol que utiliza uno de ellos.

1. Después de agregar un nuevo rol al proyecto, verá algunas instrucciones de configuración. Estas son normalmente innecesarias, pero pueden resultar útiles para futuras personalización de los proyectos. Tenga en cuenta que al agregar varios roles al mismo tiempo, solo permanecerán abiertas las instrucciones para el último rol. Sin embargo, puede encontrar las instrucciones y sugerencias para solucionar problemas en sus archivos `readme.mht` correspondientes, que se encuentran en la raíz del rol o en la carpeta `bin`.

1. Una carpeta `bin` de proyecto también contiene uno o dos scripts de PowerShell que se usan para configurar la máquina virtual remota, incluida la instalación de Python, cualquier archivo [requirements.txt](#dependencies) del proyecto y la configuración de IIS si es necesario. Puede editar estos archivos como desee para la implementación, aunque las opciones más comunes se pueden administrar de otras maneras (vea [Configuración de la implementación de roles](#configuring-role-deployment) a continuación). No se recomienda quitar estos archivos, ya que, en su lugar, se utilizará un script de configuración heredado si no están disponibles.

    ![Archivos de compatibilidad de rol de trabajo](media/template-azure-cloud-service-worker-role-support-files.png)

    Para agregar estos scripts de configuración a un nuevo proyecto, haga clic con el botón derecho en el proyecto, seleccione **Agregar > Nuevo elemento...** y seleccione **Web Role Support Files** (Archivos de compatibilidad de rol web) o **Worker Role Support Files** (Archivos de compatibilidad de rol de trabajo).
   

## <a name="configuring-role-deployment"></a>Configuración de la implementación de roles

Los scripts de PowerShell de una carpeta `bin` del proyecto de rol controlan la implementación de ese rol y se pueden editar para personalizar la configuración:

- `ConfigureCloudService.ps1` se utiliza para roles web y de trabajo, normalmente para instalar y configurar dependencias establecer la versión de Python.
- `LaunchWorker.ps1` se utiliza únicamente para roles de trabajo y se usa para cambiar el comportamiento de inicio, agregar argumentos de línea de comandos o agregar variables de entorno.

Ambos archivos contienen instrucciones para personalización. También puede instalar su propia versión de Python mediante la incorporación de otra tarea en el archivo `ServiceDefinition.csdef` del proyecto de servicios en la nube principal, estableciendo la variable `PYTHON` en su ruta de acceso `python.exe` instalada (o equivalente). Cuando `PYTHON` se haya establecido, Python no se instalará desde NuGet.

Se puede realizar una configuración adicional como se indica a continuación:

1. Instale paquetes con `pip` actualizando el archivo `requirements.txt` en el directorio raíz del proyecto. El script `ConfigureCloudService.ps1` instalará este archivo en la implementación.
1. Establezca variables de entorno modificando el archivo `web.config` (roles web) o la sección `Runtime` del archivo `ServiceDefinition.csdef` (roles de trabajo).
1. Especifique el script y los argumentos que se van a utilizar para un rol de trabajo mediante la modificación de la línea de comandos en la sección `Runtime/EntryPoint` del archivo `ServiceDefinitions.csdef`.
1. Establezca el script del controlador principal para un rol web a través del archivo `web.config`.

## <a name="testing-role-deployment"></a>Prueba de la implementación de roles

Mientras escribe los roles, puede probar el proyecto en la nube localmente usando el emulador de servicios en la nube. El emulador se incluye con las herramientas del SDK de Azure y es una versión limitada del entorno usado cuando el servicio en la nube se publica en Azure.

Para iniciar el emulador, asegúrese en primer lugar de que el proyecto en la nube es el proyecto de inicio de la solución haciendo clic con el botón derecho y seleccionando **Establecer como proyecto de inicio**. A continuación, seleccione **Depurar > Iniciar depuración** (F5) o **Depurar > Iniciar sin depurar** (Ctrl + F5).

Tenga en cuenta que, debido a las limitaciones del emulador, no es posible depurar el código Python. Por tanto, le recomendamos que depure los roles ejecutándolos independiente y, luego, use el emulador para las pruebas de integración antes de la publicación.


## <a name="deploying-a-role"></a>Implementación de un rol

Para abrir el asistente **Publicar**, seleccione el proyecto de rol en el Explorador de soluciones y seleccione **Compilar > Publicar** en el menú principal, o haga clic con el botón secundario en el proyecto y seleccione **Publicar**.

El proceso de publicación consta de dos fases. En primer lugar, Visual Studio crea un único paquete que contiene todos los roles del servicio en la nube. Este paquete es lo que se implementa en Azure, que inicializa una o varias máquinas virtuales para cada rol e implementa el origen.

A medida que cada máquina virtual se activa, ejecuta el script `ConfigureCloudService.ps1` e instala todas las dependencias. Este script instala de forma predeterminada una versión reciente de Python desde [nuget](https://www.nuget.org/packages?q=Tags%3A%22python%22+Authors%3A%22Python+Software+Foundation%22) y todos los paquetes especificados en un archivo `requirements.txt`. 

Por último, los roles de trabajo ejecutan `LaunchWorker.ps1`, que comienza a ejecutar el script de Python; los roles web inicializan IIS y empiezan a controlar las solicitudes web.


## <a name="dependencies"></a>Dependencias

Para el servicio en la nube, el script `ConfigureCloudService.ps1` usa `pip` para instalar un conjunto de dependencias de Python. Estas se deben especificar en un archivo denominado `requirements.txt` (personalizable modificando `ConfigureCloudService.ps1`). El archivo se ejecuta con `pip install -r requirements.txt` como parte de la inicialización.

Tenga en cuenta que las instancias del servicio en la nube no incluyen compiladores de C, por lo que todas las bibliotecas con extensiones de C deben proporcionar binarios previamente compilados.

pip y sus dependencias, así como los paquetes de `requirements.txt`, se descargarán automáticamente y pueden contar como uso de ancho de banda facturable. Consulte [Administración de paquetes necesarios](python-environments.md#managing-required-packages) para  información sobre cómo administrar archivos `requirements.txt`.

## <a name="troubleshooting"></a>Solución de problemas

Si el rol web o de trabajo no se comporta correctamente después de la implementación, compruebe lo siguiente:

- El proyecto de Python incluye una carpeta bin\ con (como mínimo):
    - `ConfigureCloudService.ps1`
    - `LaunchWorker.ps1` (para roles de trabajo)
    - `ps.cmd`

- El proyecto de Python incluye un archivo `requirements.txt` que enumera todas las dependencias (o como alternativa, una colección de archivos de rueda).
- Habilite Escritorio remoto en el servicio en la nube e investigue los archivos de registro.
- Los registros de `ConfigureCloudService.ps1` y `LaunchWorker.ps1` se almacenan en la carpeta `C:\Resources\Directory\%RoleId%.DiagnosticStore\LogFiles` en el equipo remoto.
- Los roles web pueden escribir registros adicionales en una ruta de acceso configurada en `web.config`, es decir, la ruta de acceso en la appSetting `WSGI_LOG`. El registro de IIS o FastCGI convencional Rost también funcionará.
- Actualmente, el archivo `LaunchWorker.ps1.log` es la única manera de ver la salida o los errores que muestra el rol de trabajo de Python.