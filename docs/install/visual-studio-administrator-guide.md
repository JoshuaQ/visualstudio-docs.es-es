---
title: "Guía del administrador de Visual Studio | Microsoft Docs"
ms.custom: 
ms.date: 05/06/2017
ms.prod: visual-studio-dev15
ms.reviewer: 
ms.suite: 
ms.technology:
- vs-ide-install
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
author: TerryGLee
ms.author: tglee
manager: ghogen
translation.priority.ht:
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- ru-ru
- zh-cn
- zh-tw
translation.priority.mt:
- cs-cz
- pl-pl
- pt-br
- tr-tr
ms.translationtype: Human Translation
ms.sourcegitcommit: b5b496e0de0a12c9f52c944ef9e768c82d9be783
ms.openlocfilehash: c88a932beac964117ac2fd6ffe171bf4256ac706
ms.contentlocale: es-es
ms.lasthandoff: 05/08/2017

---
# <a name="visual-studio-2017-administrator-guide"></a>Guía del administrador de Visual Studio 2017

En entornos empresariales, es habitual que los administradores del sistema implementen instalaciones en los usuarios finales desde un recurso compartido de red o mediante software de administración de sistemas. El motor de instalación de Visual Studio se ha diseñado para admitir implementaciones empresariales, lo que otorga a los administradores del sistema la posibilidad de crear una ubicación de instalación de red, configurar previamente los valores predeterminados de instalación, implementar claves de producto durante el proceso de instalación y administrar actualizaciones de producto después de un lanzamiento satisfactorio. Esta guía de administrador proporciona instrucciones basadas en escenarios para la implementación empresarial en entornos de red comunes.

## <a name="steps-for-deploying-visual-studio-2017-in-an-enterprise-environment"></a>Pasos para implementar Visual Studio 2017 en un entorno empresarial

Puede implementar Visual Studio 2017 en estaciones de trabajo cliente siempre y cuando cada equipo de destino cumpla los [requisitos mínimos de instalación](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs). Tanto si va a realizar la implementación a través de software como System Center o mediante un archivo por lotes, normalmente deberá seguir los pasos siguientes:

1. [Crear un recurso compartido de red que contenga los archivos de producto de Visual Studio](create-a-network-installation-of-visual-studio.md) en una ubicación de red.

2. [Seleccionar las cargas de trabajo y los componentes](workload-and-component-ids.md) que quiere instalar.

3. [Crear un archivo de respuesta](automated-installation-with-response-file.md) que contenga las opciones de instalación predeterminadas. O, como alternativa, [compilar un script de instalación](use-command-line-parameters-to-install-visual-studio.md) mediante parámetros de la línea de comandos para controlar la instalación.

4. Opcionalmente, [aplicar una clave de producto de licencia por volumen](automatically-apply-product-keys-when-deploying-visual-studio.md) como parte del script de instalación para que los usuarios no tengan que activar el software por separado.

5. Actualizar el diseño de red para [controlar cuándo se entregan actualizaciones del producto a los usuarios finales](controlling-updates-to-visual-studio-deployments.md).

6. Opcionalmente, establecer las claves del Registro para [controlar lo que se almacena en caché en las estaciones de trabajo cliente](set-defaults-for-enterprise-deployments.md).

7. Usar la tecnología de implementación de su elección para ejecutar el script generado en los pasos anteriores en las estaciones de trabajo de destino de los desarrolladores.

8. [Actualizar la ubicación de red con las actualizaciones más recientes](update-a-network-installation-of-visual-studio.md) para Visual Studio mediante la ejecución del comando usado en el paso 1 de forma periódica para agregar componentes actualizados.

> [!IMPORTANT]
> Tenga en cuenta que las instalaciones que se realizan desde un recurso compartido de red "recordarán" la ubicación de la que proceden. Esto significa que, para reparar un equipo cliente, quizás sea necesario volver al recurso compartido de red desde el que se instaló el cliente. Elija cuidadosamente la ubicación de red para que esté disponible durante el tiempo que espera que los clientes de Visual Studio 2017 se ejecuten en su organización.

## <a name="tools"></a>Herramientas
Dispone de varias herramientas que le ayudarán a [detectar y administrar las instancias de Visual Studio instaladas](tools-for-managing-visual-studio-instances.md) en los equipos cliente.

> [!TIP]
> Además de la documentación de la guía del administrador, una buena fuente de información sobre la instalación de Visual Studio 2017 es el [blog de Heath Stewart](https://blogs.msdn.microsoft.com/heaths/tag/vs2017/).

## <a name="see-also"></a>Vea también
* [Instalación de Visual Studio 2017](install-visual-studio.md)
* [Instalación de Visual Studio en entornos sin conexión](install-visual-studio-in-offline-environment.md)
* [Usar parámetros de la línea de comandos para instalar Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
  * [Ejemplos de parámetros de línea de comandos](command-line-parameter-examples.md)
* [Notificar un problema con Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
