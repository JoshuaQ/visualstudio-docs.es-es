---
title: "Descripción de las configuraciones de compilación"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 78107CFA-9308-4293-A92A-9B552A259E15
ms.openlocfilehash: e435418c0c77f1577e9db8ab35d76d6bd54f8447
ms.sourcegitcommit: aadb9588877418b8b55a5612c1d3842d4520ca4c
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 10/27/2017
---
# <a name="understanding-build-configurations"></a>Descripción de las configuraciones de compilación

## <a name="project-build-configurations"></a>Configuraciones de compilación del proyecto 

Los proyectos pueden tener varias configuraciones; cambiar entre ellas permite diferentes salidas en tiempo de compilación. Por ejemplo, cuando se usa una configuración de depuración, la salida incluye símbolos de depuración, lo que permite al depurador resolver nombres de función, parámetros o variables del seguimiento de la pila de una aplicación bloqueada. Aunque el empleo de una configuración de depuración se traduce en un tamaño de archivo inflado, lo que no sería ideal para una aplicación diseñada para su distribución.

Cada plataforma tiene configuraciones específicas para su compilación. El desarrollo de Xamarin.Android siempre tiene solo una configuración de lanzamiento o depuración. Xamarin.iOS tiene más configuraciones. Los proyectos de iOS más recientes solo tienen configuraciones de depuración o lanzamiento, pero pueden configurarse para un dispositivo o cualquier simulador instalado.

## <a name="solution-configurations"></a>Configuraciones de solución

Del mismo modo que las configuraciones de proyecto, las configuraciones de solución se usan para crear configuraciones personalizadas para un proyecto completo. Con la pestaña **Asignaciones de configuración** del elemento **Compilar > Configuraciones**, puede asignar una configuración de destino para cada elemento de la solución, como se muestra a continuación:


 ![Opciones de asignación de configuración](media/projects-and-solutions-image3.png)

Para más información, vea el vídeo [Configuration Manager (Administrador de configuración)](https://www.youtube.com/watch?v=tjSdkqYh5Vg) de James Montemagno.

## <a name="run-configuration"></a>Configuración de ejecución

En versiones anteriores de Xamarin Studio se podía seleccionar la opción para establecer un proyecto como **proyecto de inicio**, que es el que se ejecuta o depura al usar el comando Ejecutar o Depurar global. Esto se indicaba mediante un tipo de letra negrita para el nombre del proyecto en el panel de este.

En Visual Studio para Mac, en lugar de establecer un proyecto de inicio, se puede establecer una _configuración de ejecución_. Las configuraciones de ejecución se presentan en una lista desplegable de la barra de herramientas, junto al selector de la configuración de compilación, como se muestra a continuación:

 ![Desplegable de configuración de ejecución](media/projects-and-solutions-image8.png)

Una configuración de ejecución es un conjunto de opciones de ejecución con un nombre y varias configuraciones que se definen en un proyecto para diferentes fines. Las configuraciones de ejecución se definen en el nivel de proyecto, y para cada proyecto ejecutable se crea automáticamente una predeterminada, aunque es posible agregar tantas como sea necesario. Determinados tipos de proyecto generan automáticamente configuraciones de ejecución adicionales. Por ejemplo, los proyectos de watchOS pueden generar _configuraciones de vista rápida y notificación_. 
 
Las configuraciones se pueden compartir con otros desarrolladores (en cuyo caso se almacenarán en el archivo .csproj) o conservarse localmente (en cuyo caso se almacenarán en un archivo .user).

### <a name="android-run-configurations"></a>Configuraciones de ejecución de Android
 
Las configuraciones de ejecución para proyectos de Android permiten especificar qué actividad, servicio o receptor de difusión iniciar al ejecutar o depurar el proyecto. Puede pasar datos adicionales de intención y establecer marcas de intención para poder probar los componentes con diferentes condiciones de inicio.

Aquellas actividades distintas a `MainLauncher` deberán tener `Exported=true` agregado al atributo Actividad para la depuración en un dispositivo físico o tener filtros de intención definidos.

## <a name="examples-of-data-that-might-be-included-in-run-configurations"></a>Ejemplos de datos que se podrían incluir en configuraciones de ejecución

En la siguiente lista, se proporcionan algunos ejemplos de datos que se podrían incluir en configuraciones de ejecución:

* Proyecto de .NET normal
    * Aplicación de inicio alternativa
    * Argumentos de inicio
    * Directorio de trabajo
    * Variables de entorno
    * Opciones del entorno de ejecución Mono (para usarse solo al ejecutar en Mono)
* Proyecto de Android
    * Punto de entrada (actividad, servicio, receptor)
    * Datos y argumentos de intención
* Proyecto de iOS
    * Modo (Normal, Recuperación de cambios)
* Proyecto de extensión de iOS
    * Aplicación de inicio: predeterminada o personalizada
* Proyecto de WatchKit
    * Modo (Vista rápida, Notificación)
    * Carga de notificaciones
