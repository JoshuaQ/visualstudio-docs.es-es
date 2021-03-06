---
title: "El proceso de transformación de plantillas de texto | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: text templates, transformation process
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 469d2460bab93c73c227b08aeb763e6bfe18261e
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="the-text-template-transformation-process"></a>El proceso de transformación de las plantillas de texto
El proceso de transformación de plantillas de texto toma un archivo de plantilla de texto como entrada y genera un nuevo archivo de texto como salida. Por ejemplo, puede usar plantillas de texto para generar código de Visual Basic o C# o puede generar un informe HTML.  
  
 Tres componentes forman parte de este proceso: el motor, el host y los procesadores de directivas. El motor controla el proceso; interactúa con el host y el procesador de directivas para generar el archivo de salida. El host proporciona la interacción con el entorno, como buscar archivos y ensamblados. El procesador de directivas agrega funcionalidad, como la lectura de datos desde un archivo XML o una base de datos.  
  
 El proceso de transformación de plantillas de texto se realiza en dos pasos. En primer lugar, el motor crea una clase temporal, que se conoce como la clase de transformación generada. Esta clase contiene el código generado por las directivas y los bloques de control. Después de eso, el motor compila y ejecuta la clase de transformación generada para generar el archivo de salida.  
  
## <a name="components"></a>Componentes  
  
|Componente|Descripción|Puede personalizar (Sí/No)|  
|---------------|-----------------|------------------------------|  
|Motor de|El componente de motor controla el proceso de transformación de plantillas de texto|No.|  
|Host|El host es la interfaz entre el motor y el entorno del usuario. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]es un host del proceso de transformación de texto.|Sí. Puede escribir un host personalizado.|  
|Procesadores de directivas|Procesadores de directivas son clases que controlan las directivas en plantillas de texto. Puede usar las directivas para proporcionar datos a una plantilla de texto desde un origen de entrada.|Sí. Puede escribir procesadores de directivas personalizadas|  
  
## <a name="the-engine"></a>El motor de  
 El motor recibe la plantilla como una cadena desde el host, que controla todos los archivos que se utilizan en el proceso de transformación. El motor, a continuación, pide al host para localizar los procesadores de directivas personalizadas y otros aspectos del entorno. A continuación, el motor compila y ejecuta la clase de transformación generada. El motor devuelve el texto generado al host, que normalmente se guarda el texto en un archivo.  
  
## <a name="the-host"></a>El Host  
 El host es responsable de todo lo que se relaciona con el entorno fuera del proceso de transformación, incluidos los siguientes:  
  
-   Buscar archivos de texto y binarios solicitados por el motor o un procesador de directivas. El host puede buscar directorios y la caché global de ensamblados para buscar ensamblados. El host puede localizar código de procesador de directivas personalizado para el motor. El host también puede buscar y leer archivos de texto y devolver su contenido como cadenas.  
  
-   Proporcionar listas de ensamblados estándar y espacios de nombres utilizados por el motor para crear la clase de transformación generada.  
  
-   Proporciona el dominio de aplicación que se utiliza cuando el motor compila y ejecuta la clase de transformación generada. Un dominio de aplicación independiente se utiliza para proteger la aplicación host frente a errores en el código de plantilla.  
  
-   Escribir el archivo de salida generado.  
  
-   Configuración de la extensión predeterminada para el archivo de salida generado.  
  
-   Control de errores de transformación de plantilla de texto. Por ejemplo, el host puede mostrar los errores en la interfaz de usuario o escribirlos en un archivo. (En [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], los errores se muestran en la ventana de mensaje de Error.)  
  
-   Al proporcionar un valor de parámetro necesario si un usuario ha llamado a una directiva sin proporcionar un valor. El procesador de directivas puede especificar el nombre de la directiva y el parámetro y pedir al host proporcionar un valor predeterminado si lo tiene.  
  
## <a name="directives-and-directive-processors"></a>Directivas y procesadores de directivas  
 Una directiva es un comando en la plantilla de texto. Proporciona parámetros para el proceso de generación. Normalmente, las directivas definen el origen y el tipo del modelo u otra entrada y la extensión de nombre de archivo del archivo de salida.  
  
 Un procesador de directivas puede procesar uno o más directivas. Al transformar una plantilla, debe tener instalado un procesador de directivas que se ocupen de las directivas de la plantilla.  
  
 Las directivas funcionan agregando código en la clase de transformación generada. Llamar a las directivas desde una plantilla de texto y el motor procesa todas las llamadas de la directiva cuando crea la clase de transformación generada. Después de llamar correctamente a una directiva, el resto del código que escribe en la plantilla de texto puede basarse en la funcionalidad que proporciona la directiva. Por ejemplo, puede realizar la siguiente llamada a la `import` la directiva en la plantilla:  
  
 `<#@ import namespace="System.Text" #>`  
  
 El procesador de directivas estándar convierte esta opción para un `using` instrucción en la clase de transformación generada. A continuación, puede usar el `StringBuilder` clase en el resto del código de plantilla sin calificar como `System.Text.StringBuilder`.