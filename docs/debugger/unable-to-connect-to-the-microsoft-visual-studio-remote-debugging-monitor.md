---
title: "No se puede conectar a Microsoft Visual Studio Monitor de depuración remota | Documentos de Microsoft"
ms.custom: 
ms.date: 08/24/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- vs.debug.error.remote_debug
- vs.debug.error.firewall.remotemachine
dev_langs:
- CSharp
- VB
- FSharp
- C++
ms.assetid: a1d959fc-3817-491c-831b-e6b768a3877a
caps.latest.revision: "14"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 345dbfd982c2e80fadc0f4c3d9484c662b6090ac
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="unable-to-connect-to-the-microsoft-visual-studio-remote-debugging-monitor"></a>No se puede conectar al Monitor de depuración remota de Microsoft Visual Studio
Este mensaje puede aparecer debido a que el monitor de depuración remota no es configurado correctamente en el equipo remoto o el equipo remoto es accesible debido a problemas de red o la presencia de un firewall.
  
> [!IMPORTANT]
>  Si cree que ha recibido este mensaje debido a un error en el producto, inicie [el problema](../ide/how-to-report-a-problem-with-visual-studio-2017.md) a Visual Studio. Si necesita más ayuda, vea [Talk to Us](../ide/talk-to-us.md) para obtener información sobre las distintas formas de ponerse en contacto con Microsoft.

## <a name="specificerrors"></a>¿Qué es el mensaje de error detallado?

El `Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor` mensaje es genérico. Normalmente, un mensaje más específico se incluye en la cadena de error y que puede ayudar a identificar la causa del problema o busque una corrección más exacta. Estos son algunos de los mensajes de error más comunes que se anexan al mensaje de error principales:

- [El depurador no se puede conectar al equipo remoto. El depurador no pudo resolver el nombre de equipo especificado](#cannot_connect)
- [El depurador remoto rechazó la solicitud de conexión](#rejected)
- [Acceso no válido a la ubicación de memoria](#invalid_access)
- [No hay ningún servidor con el nombre especificado que se ejecuta en el equipo remoto](#no_server)
- [El nombre solicitado es válido, pero no se encontró ningún dato del tipo solicitado](#valid_name)
- [El depurador remoto de Visual Studio en el equipo de destino no se puede conectar a este equipo](#cant_connect_back)
- [Acceso denegado](#access_denied)
- [Se produjo un error específico del paquete de seguridad](#security_package)

## <a name="cannot_connect"></a>El depurador no se puede conectar al equipo remoto. El depurador no pudo resolver el nombre de equipo especificado

Siga estos pasos:

1. Asegúrese de que se escriba un nombre de equipo válido y número de puerto en el **adjuntar al proceso** cuadro de diálogo o en las propiedades del proyecto (para establecer las propiedades, vea [estos pasos](#server_incorrect)). El nombre de equipo debe tener el formato siguiente:

    `computername:port`

    > [!NOTE]
    > El número de puerto debe coincidir con el [número del depurador remoto de puerto](../debugger/remote-debugger-port-assignments.md), que *debe estar en ejecución* en el equipo de destino.

2. Si el nombre del equipo no funciona, pruebe la dirección IP y el número de puerto en su lugar.

3. Asegúrese de que la versión del depurador remoto que se ejecuta en el equipo de destino coincide con su versión de Visual Studio. Para obtener la versión correcta del depurador remoto, consulte [depuración remota](../debugger/remote-debugging.md).

    > [!TIP]
    > Si va a adjuntar al proceso y la conexión funciona correctamente, pero no ve el proceso que desea, seleccione la **Mostrar procesos de todos los usuarios de casilla**. Esto mostrará los procesos si están conectados con una cuenta de usuario diferente.

4. Si estos pasos no resuelven este error, consulte [el equipo remoto no está accesible](#dns).

## <a name="rejected"></a>El depurador remoto rechazó la solicitud de conexión

En el **adjuntar al proceso** diálogo cuadro o en las propiedades del proyecto, asegúrese de que el nombre del equipo remoto y el número de puerto coincide con el número de puerto y nombre se muestra en la ventana del depurador remoto. Si son incorrectos, corrija y vuelva a intentarlo.

Si estos valores son correctos y el mensaje menciona **autenticación de Windows** modo, compruebe que el depurador remoto se encuentra en el modo de autenticación correctos (**Herramientas > opciones**).

## <a name="invalid_access"></a>Acceso no válido a la ubicación de memoria

Se produjo un error interno. Reinicie Visual Studio e inténtelo de nuevo.

## <a name="no_server"></a>No hay ningún servidor con el nombre especificado que se ejecuta en el equipo remoto

Visual Studio no pudo conectarse al depurador remoto. Este mensaje puede aparecer por varias razones:

- Puede ejecutar el depurador remoto bajo una cuenta de usuario diferente. Vea [estos pasos](#user_accounts)

- El puerto está bloqueado en el servidor de seguridad. Asegúrese de que el firewall está [no bloquea la solicitud](#firewall), especialmente si está usando un firewall de terceros.

- La versión del depurador remoto no coincide con Visual Studio. Para obtener la versión correcta del depurador remoto, consulte [depuración remota](../debugger/remote-debugging.md)


## <a name="#valid_name"></a>El nombre solicitado es válido, pero no se encontró ningún dato del tipo solicitado

El equipo remoto existe, pero Visual Studio no pudo conectar con el depurador remoto. Este mensaje puede aparecer por varias razones:

- Un problema de DNS está impidiendo la conexión. Vea [estos pasos](#dns).

- Puede ejecutar el depurador remoto bajo una cuenta de usuario diferente. Siga [estos pasos](#user_accounts).

- El puerto está bloqueado en el servidor de seguridad. Asegúrese de que el firewall está [no bloquea la solicitud](#firewall), especialmente si está usando un firewall de terceros.

- La versión del depurador remoto no coincide con Visual Studio. Para obtener la versión correcta del depurador remoto, consulte [depuración remota](../debugger/remote-debugging.md).

## <a name="cant_connect_back"></a>El depurador remoto de Visual Studio en el equipo de destino no se puede conectar a este equipo

Puede ejecutar el depurador remoto bajo una cuenta de usuario diferente. En el depurador remoto, abra **Herramientas > permisos** para agregar el usuario a los permisos del depurador remoto. Para obtener más información, consulte [el depurador remoto se ejecuta bajo una cuenta de usuario diferente](#user_accounts).

Si el mensaje de error también hace referencia a un servidor de seguridad, el firewall en el equipo local puede ser impide la comunicación desde el equipo remoto vuelve a Visual Studio. Vea [estos pasos](#firewall).

## <a name="access_denied"></a>Acceso denegado

Puede ver este error si se intenta depurar en un equipo remoto de 64 bits desde un equipo de 32 bits (no compatible).

## <a name="security_package"></a>Se produjo un error específico del paquete de seguridad

Esto puede ser un problema heredado específico de Windows XP y Windows 7. Consulte esta [información](https://stackoverflow.com/questions/4786016/unable-to-connect-to-the-microsoft-remote-debugging-monitor-a-security-package). 

## <a name="causes-and-recommendations"></a>Causas y recomendaciones

### <a name="dns"></a>El equipo remoto no está accesible 

Si no se puede conectar con el nombre del equipo remoto, pruebe a usar la dirección IP en su lugar. Puede usar `ipconfig` en una línea de comandos en el equipo remoto para obtener la dirección IPv4. Si está utilizando un archivo de HOSTS, compruebe que está configurado correctamente.

Si se produce un error, compruebe que el equipo remoto es accesible en la red ([ping](https://technet.microsoft.com/en-us/library/cc732509(v=ws.10).aspx) el equipo remoto). No se admite la depuración remota a través de Internet, excepto en algunos escenarios de Microsoft Azure.
  
### <a name="server_incorrect"></a>El nombre del servidor es incorrecto o software de terceros está interfiriendo con el depurador remoto

En Visual Studio, examine las propiedades del proyecto y asegúrese de que el nombre del servidor es correcto. Consulte los temas para [C# y Visual Basic](../debugger/remote-debugging-csharp.md#remote_csharp) y [C++](../debugger/remote-debugging-cpp.md#remote_cplusplus). ASP.NET, abra **propiedades / Web / servidores** o **propiedades / Debug** según el tipo de proyecto.

> [!NOTE]
> Si va a adjuntar al proceso, no se usa la configuración remota en las propiedades del proyecto.

Si el nombre del servidor es correcto, el software antivirus o un firewall de terceros puede estar bloqueando al depurador remoto. Cuando se depura localmente, esto puede deberse a que Visual Studio es una aplicación de 32 bits, por lo que utiliza la versión de 64 bits del depurador remoto para depurar aplicaciones de 64 bits. Los procesos de 32 bits y 64 bits se comunican con la red local en el equipo local. Nada de tráfico de red sale del equipo, pero es posible que el software de seguridad de terceros bloquee la comunicación.

### <a name="user_accounts"></a>El depurador remoto se ejecuta bajo una cuenta de usuario diferente 

El depurador remoto, de forma predeterminada, sólo aceptará las conexiones de usuario que inició el depurador remoto y los miembros del grupo Administradores. Deben conceder permisos a usuarios adicionales de forma explícita. 
 
Puede resolver este problema de una de las siguientes formas:  

-   Agregue el usuario de Visual Studio para los permisos del depurador remoto (en la ventana del depurador remoto, elija **Herramientas > permisos**).

-   En el equipo remoto, reinicie al depurador remoto con la misma cuenta de usuario y la contraseña que utilizas en el equipo de Visual Studio.

    > [!NOTE]
    > Si está ejecutando el depurador remoto en un servidor remoto, haga clic en la aplicación del depurador remoto y elija **ejecutar como administrador** (o bien, puede ejecutar el depurador remoto como un servicio). Si no lo está ejecutando en un servidor remoto, simplemente empiece a él normalmente.
  
-   Puede iniciar el depurador remoto desde la línea de comandos con el **/ allow \<nombre de usuario >** parámetro: `msvsmon /allow <username@computer>`. 
  
-   Como alternativa, puede permitir que cualquier usuario al realizar la depuración remota. En la ventana del depurador remoto, vaya a la **Herramientas > opciones** cuadro de diálogo. Al seleccionar   **Sin autenticación**, podrá activar **Permitir que cualquier usuario depure**. Sin embargo, debe intentar esta opción solo si las opciones de otras errores, o si se encuentra en una red privada.

### <a name="firewall"></a>El firewall en el equipo remoto no permite conexiones entrantes al depurador remoto  
 El firewall del equipo de Visual Studio y el firewall del equipo remoto deben configurarse para permitir la comunicación entre Visual Studio y el depurador remoto. Para obtener información sobre los puertos que usa el depurador remoto, vea [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md). Para obtener información sobre de cómo configurar el firewall de Windows, vea [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).
  
### <a name="the-version-of-the-remote-debugger-doesnt-match-the-version-of-visual-studio"></a>La versión del depurador remoto no coincide con la versión de Visual Studio  
 La versión de Visual Studio que se ejecuta localmente debe coincidir con la versión del monitor de depuración remota que se ejecuta en el equipo remoto. Para solucionar este problema, descargue e instale la versión correspondiente del monitor de depuración remota. Para obtener la versión correcta del depurador remoto, consulte [depuración remota](../debugger/remote-debugging.md).
  
### <a name="the-local-and-remote-machines-have-different-authentication-modes"></a>Los equipos locales y remotos tienen distintos modos de autenticación  
 Los equipos locales y remotos deben usar el mismo modo de autenticación. Para solucionar este problema, asegúrese de que ambos equipos usan el mismo modo de autenticación. Puede cambiar el modo de autenticación. En la ventana del depurador remoto, vaya a la **Herramientas > opciones** cuadro de diálogo.
  
 Para más información sobre la autenticación, vea [Información general de la autenticación de Windows](https://technet.microsoft.com/en-us/library/hh831472.aspx).   
  
### <a name="anti-virus-software-is-blocking-the-connections"></a>El software antivirus está bloqueando las conexiones  
 Software antivirus de Windows permite las conexiones del depurador remoto, pero algunos programas antivirus de terceros pueden bloquearlas. Consulte la documentación de su software antivirus para averiguar cómo permitir estas conexiones.  
  
### <a name="network-security-policy-is-blocking-communication-between-the-remote-machine-and-visual-studio"></a>La directiva de seguridad de red está bloqueando la comunicación entre el equipo remoto y Visual Studio  
 Revise la seguridad de la red para asegurarse de que no está bloqueando la comunicación. Para obtener más información acerca de la directiva de seguridad de red de Windows, vea [configuración de la directiva de seguridad](/windows/device-security/security-policy-settings/security-policy-settings).  
  
### <a name="the-network-is-too-busy-to-support-remote-debugging"></a>La red está demasiado ocupada para admitir la depuración remota  
 Puede que necesite realizar la depuración remota en otro momento o volver a programar un trabajo de la red correspondiente a otra hora distinta.  
  
## <a name="more-help"></a>Más ayuda  
 Para obtener ayuda sobre el depurador remoto, abra la página de Ayuda del depurador remoto (**Ayuda > uso de** en el depurador remoto).
  
## <a name="see-also"></a>Vea también  
 [Depuración remota](../debugger/remote-debugging.md)