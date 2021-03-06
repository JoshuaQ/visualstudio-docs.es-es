---
title: "Inicio rápido: usar Visual Studio para crear su primera aplicación de Node.js | Microsoft Docs"
ms.custom: 
ms.date: 11/15/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-acquisition
ms.tgt_pltfrm: 
ms.topic: quickstart
ms.devlang: javascript
ms.assetid: b0e4ebed-1a01-41ef-aad1-4d8465ce5322
author: mikejo5000
ms.author: mikejo
manager: ghogen
dev_langs: JavaScript
ms.workload: nodejs
ms.openlocfilehash: 12c848797b167038b02106ca3392cac50171f699
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="quickstart-use-visual-studio-to-create-your-first-nodejs-app"></a>Inicio rápido: usar Visual Studio para crear su primera aplicación de Node.js
En esta introducción al entorno de desarrollo integrado (IDE) de Visual Studio, con una duración de entre 5 y 10 minutos, creará una sencilla aplicación web de Node.js. Si todavía no tiene instalado Visual Studio, puede descargarlo de forma gratuita en [esta página](http://www.visualstudio.com).  

## <a name="create-a-project"></a>Crear un proyecto
En primer lugar, creará un proyecto de aplicación web de Node.js.

1. Abra Visual Studio 2017.  

2. En la barra de menús superior, seleccione **Archivo** > **Nuevo** > **Proyecto...**  

3. En el panel de la izquierda del cuadro de diálogo **Nuevo proyecto**, expanda **JavaScript** y después seleccione **Node.js**. En el panel central, elija **Aplicación web en blanco de Node.js** y después haga clic en **Aceptar**.   

     Si no ve la plantilla de proyecto **Aplicación web en blanco de Node.js**, haga clic en el vínculo **Abrir el instalador de Visual Studio** en el panel izquierdo del cuadro de diálogo **Nuevo proyecto**. Se iniciará el Instalador de Visual Studio. Elija la carga de trabajo **Desarrollo de Node.js** y, después, haga clic en **Modificar**.  

     ![Carga de trabajo Node.js en el instalador de Visual Studio](../ide/media/quickstart-nodejs-workload.png)  

    Visual Studio crea y la nueva solución y abre el proyecto. **server.js** abierto en el editor.

## <a name="explore-the-ide"></a>Explorar el IDE  

1. Eche un vistazo al panel de la derecha del **Explorador de soluciones**.

   ![Explorador de soluciones](../ide/media/quickstart-nodejs-solution-explorer.png)  

  - El proyecto está resaltado en negrita. Tiene el nombre que le asignó en el cuadro de diálogo **Nuevo proyecto**. En el disco, este proyecto se representa mediante un archivo .njspro en la carpeta del proyecto.

  - En el nivel superior se encuentra una solución, que de forma predeterminada tiene el mismo nombre que el proyecto. Una solución, representada por un archivo .sln en el disco, es un contenedor para uno o más proyectos relacionados.

  - En el nodo npm se muestran todos los paquetes npm instalados. Puede hacer clic con el botón derecho en el nodo npm para buscar e instalar paquetes npm mediante un cuadro de diálogo.

1. Si quiere instalar paquetes npm o comandos de node.js desde un símbolo del sistema, haga clic con el botón derecho en el nodo del proyecto y seleccione **Abrir símbolo del sistema aquí**.

   ![Símbolo del sistema de Node.js](../ide/media/quickstart-nodejs-command-prompt.png) 

1. En el archivo **server.js** en el editor (panel de la izquierda), elija `http.createServer` y, después, presione **F12** o seleccione **Ir a definición** en el menú contextual (clic con el botón derecho). Este comando le lleva a la definición de la función `createServer` en index.d.ts.  

   ![Menú contextual Ir a definición](../ide/media/quickstart-nodejs-gotodefinition.png)  

1. Coloque el cursor al final de la cadena en esta línea de código, `res.end('Hello World\n');`, y modifíquela para que tenga el aspecto siguiente:

    `res.end('Hello World\n' + res.connection.`

    Donde escribe `connection.`, IntelliSense proporciona opciones para autocompletar la entrada de código.

   ![Autocompletar de IntelliSense](../ide/media/quickstart-nodejs-intellisense.png)  

1. Seleccione **localPort** y, después, escriba `);` para completar la instrucción para que tenga el aspecto siguiente:

    `res.end('Hello World\n' + res.connection.localPort);`

## <a name="run-the-application"></a>Ejecutar la aplicación
1. Presione **Ctrl+F5** (o seleccione **Depurar > Iniciar sin depurar**) para ejecutar la aplicación. La aplicación se abre en un explorador.  

1. En la ventana del explorador, verá "Hello World" más el número de puerto local.

1. Cierre el explorador web.  

¡Enhorabuena por completar este tutorial de inicio rápido! Esperamos que haya aprendido un poco sobre el IDE de Visual Studio. Si quiere profundizar más en sus capacidades, continúe con el tutorial que encontrará en la sección **Tutoriales** de la tabla de contenido.  

## <a name="next-steps"></a>Pasos siguientes 

- Repasar el [Tutorial para Node.js](../nodejs/tutorial-nodejs.md)  
- Más información sobre el [IDE de Visual Studio](../ide/visual-studio-ide.md)  
- Obtener más información sobre [Herramientas de Node.js para Visual Studio](https://github.com/Microsoft/nodejstools/wiki)