---
title: Remoto depurar en un equipo remoto de IIS, ASP.NET | Documentos de Microsoft
ms.custom: remotedebugging
ms.date: 07/26/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9cb339b5-3caf-4755-aad1-4a5da54b2a23
caps.latest.revision: "6"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: aspnet
ms.openlocfilehash: 6f11ec81c740a6930ce4eaef16d4e4e389aaca47
ms.sourcegitcommit: 65f85389047c5a1938b6d5243ccba8d4f14362ba
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/23/2018
---
# <a name="remote-debug-aspnet-on-a-remote-iis-computer"></a>Depuración remota en un equipo remoto de IIS, ASP.NET
Para depurar una aplicación ASP.NET que se ha implementado en IIS, instalar y ejecutar las herramientas remotas en el equipo donde se implementa la aplicación y, a continuación, adjunte a su aplicación en ejecución desde Visual Studio.

![Los componentes del depurador remoto](../debugger/media/remote-debugger-aspnet.png "Remote_debugger_components")

Esta guía explica cómo instalar y configurar una aplicación de Visual Studio de 2017 ASP.NET MVC 4.5.2, implementarla en IIS y adjuntar al depurador remoto de Visual Studio. Realizar la depuración remota ASP.NET Core, vea [remoto depurar ASP.NET Core en un equipo con IIS](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md). Para el servicio de aplicación de Azure, facilidad puede implementar y depurar en una instancia preconfigurada de IIS mediante el [depurador instantánea](../debugger/debug-live-azure-applications.md) (.NET 4.6.1 necesario) o por [para asociar el depurador del explorador de servidores](../debugger/remote-debugging-azure.md).

Estos procedimientos se han probado en estas configuraciones de servidor:
* Windows Server 2012 R2 y IIS 8 (para Windows Server 2008 R2, los pasos del servidor son diferentes)

## <a name="requirements"></a>Requisitos

El depurador remoto es compatible con Windows Server a partir de Windows Server 2008 Service Pack 2. Para obtener una lista completa de requisitos, consulte [requisitos](../debugger/remote-debugging.md#requirements_msvsmon).

> [!NOTE]
> No se admite la depuración entre dos equipos conectados a través de un servidor proxy. Depuración mediante una conexión de poco ancho de banda, como acceso telefónico a Internet, o una latencia alta o a través de Internet a través de países no se recomienda y puede ser un error o inaceptablemente bajo.

## <a name="create-the-aspnet-452-application-on-the-visual-studio-computer"></a>Crear ASP.NET 4.5.2 aplicación en el equipo de Visual Studio
  
1. Cree una nueva aplicación de MVC ASP.NET (**Archivo > Nuevo > proyecto**, a continuación, seleccione ** Visual C# > Web > aplicación Web ASP.NET. En la sección de plantillas **ASP.NET 4.5.2** , seleccione **MVC**. Asegúrese de que **habilitar la compatibilidad con Docker** no está seleccionada y que **autenticación** está establecido en **sin autenticación**. Denomine el proyecto **MyASPApp**.)

2. Abra el archivo HomeController.cs y establezca un punto de interrupción en el método `About()` .

## <a name="bkmk_configureIIS"></a>Instalar y configurar IIS en Windows Server

[!INCLUDE [remote-debugger-install-iis-role](../debugger/includes/remote-debugger-install-iis-role.md)]

## <a name="update-browser-security-settings-on-windows-server"></a>Actualizar la configuración de seguridad del explorador en Windows Server

Según la configuración de seguridad, puede ahorrar tiempo para agregar los siguientes sitios de confianza en el explorador, por lo que puede descargar fácilmente el software descrito en este tutorial. Puede ser necesario tener acceso a estos sitios:

- microsoft.com
- go.microsoft.com
- download.microsoft.com
- visualstudio.com

Si está usando Internet Explorer, puede agregar los sitios de confianza, vaya a **opciones de Internet > seguridad > sitios de confianza > sitios**. Estos pasos son diferentes para otros exploradores. (Si tiene que descargar una versión anterior del depurador remoto de my.visualstudio.com, algunos sitios de confianza adicionales son necesarios para iniciar sesión).

Al descargar el software, puede obtener las solicitudes para conceder permiso para cargar varias secuencias de comandos del sitio web y recursos. En la mayoría de los casos, estos recursos adicionales no son necesarios para instalar el software.

## <a name="BKMK_deploy_asp_net"></a>Instalar ASP.NET 4.5 en Windows Server

Si desea información más detallada para instalar ASP.NET en IIS, consulte [IIS 8.0 utilizando ASP.NET 3.5 y 4.5 de ASP.NET](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45).

1. Utilice el instalador de plataforma Web (WPI) para instalar ASP.NET 4.5 (en el nodo del servidor en Windows Server 2012 R2, elija **obtener nuevos componentes de plataforma de Web** y, a continuación, busque ASP.NET)

    ![RemoteDBG_IIS_AspNet_45](../debugger/media/remotedbg_iis_aspnet_45.png "RemoteDBG_IIS_AspNet_45")

    > [!NOTE]
    > Si está utilizando Windows Server 2008 R2, instale ASP.NET 4 en lugar de utilizar este comando:

     **C:\Windows\Microsoft.NET\Framework64\v4.0.30319\aspnet_regiis.exe -ir**

2. Reiniciar el sistema (o ejecutar **net stop era /y** seguido **del comando net start w3svc** desde un símbolo del sistema para recoger un cambio en la ruta de acceso del sistema).

## <a name="BKMK_install_webdeploy"></a>(Opcional) Instale WebDeploy 3.6 en Windows Server

[!INCLUDE [remote-debugger-install-web-deploy](../debugger/includes/remote-debugger-install-web-deploy.md)]

## <a name="BKMK_deploy_asp_net"></a>Configurar el sitio Web de ASP.NET en el equipo de Windows Server

1. Abra el Explorador de Windows y cree una nueva carpeta, **C:\Publish**, donde va a implementar el proyecto ASP.NET más adelante.

2. Abra la **de Internet Information Services (IIS) Manager**. (En el panel izquierdo del administrador del servidor, seleccione **IIS**. Haga clic en el servidor y seleccione **Internet Information Services (IIS) Manager**.)

3. En **conexiones** en el panel izquierdo, vaya a **sitios**.

4. Seleccione el **sitio Web predeterminado**, elija **configuración básica**y establezca el **ruta de acceso física** a **C:\Publish**.

5. Haga clic con el botón secundario en el nodo **Sitio web predeterminado** y seleccione **Agregar aplicación**.

6. Establecer el **Alias** campo **MyASPApp**, acepte el valor predeterminado de grupo de aplicaciones (**DefaultAppPool**) y establezca el **ruta de acceso física** a  **C:\Publish**.

7. En **conexiones**, seleccione **grupos de aplicaciones**. Abra **DefaultAppPool** y establezca el campo de grupo de aplicaciones en **ASP.NET v4.0** (ASP.NET 4.5 no es una opción para el grupo de aplicaciones).

8. Con el sitio seleccionado en el Administrador de IIS, elija **Editar permisos**y asegúrese de que ese IUSR, IIS_IUSRS o el usuario configurado para el grupo de aplicaciones es un usuario autorizado con permisos de lectura y ejecución. Si ninguno de estos usuarios están presente, agregue IUSR como un usuario con derechos de lectura y ejecución.

## <a name="bkmk_webdeploy"></a>(Opcional) Publique e implemente la aplicación mediante Web Deploy desde Visual Studio

[!INCLUDE [remote-debugger-deploy-app-web-deploy](../debugger/includes/remote-debugger-deploy-app-web-deploy.md)]

Además, puede que necesite leer la sección en [solución de problemas de puertos](#bkmk_openports).

## <a name="optional-publish-and-deploy-the-app-by-publishing-to-a-local-folder-from-visual-studio"></a>(Opcional) Publique e implemente la aplicación al realizar la publicación en una carpeta local de Visual Studio

También puede publicar e implementar la aplicación mediante el sistema de archivos u otras herramientas.

1. (ASP.NET 4.5.2) Asegúrese de que el archivo web.config muestra la versión correcta de .NET Framework.  Por ejemplo, si desea usar ASP.NET 4.5.2, asegúrese de que esta versión se muestra en el archivo web.config.
  
    ```xml
    <system.web>
      <compilation debug="true" targetFramework="4.5.2" />
      <httpRuntime targetFramework="4.5.2" />
      <httpModules>
        <add name="ApplicationInsightsWebTracking" type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web" />
      </httpModules>
    </system.web>
  
    ```

    Por ejemplo, la versión debe ser 4.0 si instala ASP.NET 4 en lugar de 4.5.2.

[!INCLUDE [remote-debugger-deploy-app-local](../debugger/includes/remote-debugger-deploy-app-local.md)]

## <a name="BKMK_msvsmon"></a>Descargue e instale las herramientas remotas en Windows Server

En este tutorial, estamos utilizando Visual Studio de 2017.

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]

> [!TIP]
> En algunos casos, puede ser más eficaz para ejecutar al depurador remoto desde un recurso compartido de archivos. Para obtener más información, consulte [ejecutar el depurador remoto desde un recurso compartido de archivos](../debugger/remote-debugging.md#fileshare_msvsmon).
  
## <a name="BKMK_setup"></a>Configurar el depurador remoto en Windows Server

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]

> [!NOTE]
> Si necesita agregar permisos para los usuarios adicionales, cambiar el modo de autenticación o número de puerto para el depurador remoto, consulte [configurar el depurador remoto](../debugger/remote-debugging.md#configure_msvsmon).

Para obtener información acerca de cómo ejecutar el depurador remoto como un servicio, consulte [ejecutar el depurador remoto como un servicio](../debugger/remote-debugging.md#bkmk_configureService).

## <a name="BKMK_attach"></a> Adjuntar elementos a la aplicación ASP.NET desde el equipo de Visual Studio

1. En el equipo de Visual Studio, abra el **MyASPApp** solución.
2. En Visual Studio, haga clic en **Depurar > asociar al proceso** (Ctrl + Alt + P).

    > [!TIP]
    > En Visual Studio de 2017, puede volver a adjuntar al mismo proceso que ha asociado previamente a mediante el uso de **Depurar > volver a adjuntar al proceso...** (Mayús + Alt + P). 

3. Establezca el campo calificador en  **\<nombre del equipo remoto >: 4022**.
4. Haga clic en **Actualizar**.
    Debería ver que algunos procesos aparecen en la ventana **Procesos disponibles** .

    Si no ve todos los procesos, pruebe a usar la dirección IP en lugar del nombre del equipo remoto (el puerto es necesario). Puede usar `ipconfig` en una línea de comandos para obtener la dirección IPv4.

5. Active  **Mostrar los procesos de todos los usuarios**.
6. Escriba la primera letra de un nombre de proceso para encontrar rápidamente **w3wp.exe** para ASP.NET 4.5.

    ![RemoteDBG_AttachToProcess](../debugger/media/remotedbg_attachtoprocess.png "RemoteDBG_AttachToProcess")

7. Haga clic en **adjuntar**

8. Abra el sitio web del equipo remoto. En un explorador, vaya a **http://\<nombre del equipo remoto >**.
    
    Debería ver la página web de ASP.NET.
9. En la aplicación ASP.NET en ejecución, haga clic en el vínculo a la **sobre** página.

    Se alcanzará el punto de interrupción en Visual Studio.

## <a name="bkmk_openports"></a>Solución de problemas: Abra los puertos necesarios en Windows Server

En la mayoría de las instalaciones, se abren los puertos necesarios por la instalación de ASP.NET y el depurador remoto. Sin embargo, debe comprobar que los puertos estén abiertos.

> [!NOTE]
> En una máquina virtual de Azure, debe abrir puertos a través de la [grupo de seguridad de red](/azure/virtual-machines/virtual-machines-windows-hero-role#open-port-80). 

Puertos necesarios:

- 80 - necesarias para IIS
- 8172 - (opcional) necesarios para que Web Deploy implementar la aplicación desde Visual Studio
- 4022 - necesarios para la depuración remota de Visual Studio de 2017 (vea [asignaciones de puerto de depurador remoto](../debugger/remote-debugger-port-assignments.md) para obtener información detallada.
- UDP 3702 - puerto de detección (opcional) permite la **buscar** botón al adjuntar el depurador remoto en Visual Studio.

1. Para abrir un puerto de servidor de Windows, abra la **iniciar** menú, busque **Firewall de Windows con seguridad avanzada**.

2. A continuación, elija **reglas de entrada > nueva regla > puerto**. Elija **siguiente** y en **puertos locales específicos**, escriba el número de puerto, haga clic en **siguiente**, a continuación, **permitir la conexión**, haga clic en siguiente, y Agregue el nombre (**IIS**, **Web Deploy**, o **msvsmon**) para la regla de entrada.

    Si desea obtener más información acerca de cómo configurar Firewall de Windows, vea [configurar Firewall de Windows para la depuración remota](../debugger/configure-the-windows-firewall-for-remote-debugging.md).

3. Cree reglas adicionales para los otros puertos necesarios.