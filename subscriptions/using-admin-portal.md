---
title: Uso del Portal de administradores | Visual Studio Marketplace
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 10/3/2017
Ms.topic: Get-Started-Article
Description: Learn how to manage your organization's Visual Studio subscriptions with the Administrator Portal.
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
ms.openlocfilehash: cf44f74b32bd830c613adcc1ee35a95b97636772
ms.sourcegitcommit: b7d3b90d0be597c9d01879338dd2678c881087ce
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/01/2017
---
#  <a name="using-the-visual-studio-subscriptions-administrator-portal"></a>Uso del Portal de administradores para las suscripciones de Visual Studio

Tenga esto en cuenta al usar el Portal de administradores de suscripciones de Visual Studio:
 
- **Para las suscripciones de Visual Studio se concede una licencia por usuario.** Cada suscriptor puede usar el software en todos los equipos necesarios para realizar actividades de desarrollo y pruebas. 
- **Asigne solo un nivel de suscripción para cada suscriptor**, el que corresponda a la suscripción de Visual Studio que haya adquirido su organización. Si algún usuario tiene asignados varios niveles de suscripción, modifique su configuración para que solo tenga uno. 
- **El nivel de suscripción de un suscriptor tendrá que actualizarse** cuando se actualice la suscripción (después de la adquisición de una licencia de "actualización a edición superior") o se renueve en un nivel inferior. 
- **No comparta las suscripciones entre suscriptores.** Debe asignar una suscripción a cualquier usuario que use total o parcialmente las ventajas de la suscripción (software de desarrollo y pruebas, Microsoft Azure, aprendizaje electrónico, etc.). 

## <a name="adminstrator-roles"></a>Roles de administrador
En el nuevo Portal de administradores de suscripciones de Visual Studio para clientes del programa de licencias por volumen hay dos roles distintos. Estos roles se asemejan al rol de contacto principal y los encargados de los avisos y al rol de administrador de suscripciones en la versión actual de VLSC. 

**Superadministradores:** al configurar una organización por primera vez, el contacto principal o el encargado de los avisos es de forma predeterminada el superadministrador. El contacto principal o el encargado de los avisos puede asignar superadministradores o administradores adicionales. Un superadministrador puede agregar y quitar otros administradores, así como suscriptores. Si hay más de dos superadministradores en el sistema, un superadministrador puede eliminarlos a todos menos a los dos últimos por razones de seguridad. 

**Administradores:** solo un superadministrador puede configurar administradores. Un administrador puede administrar los suscriptores de los contratos que el superadministrador les asigne. 

## <a name="getting-started"></a>Introducción
### <a name="onboarding"></a>Incorporación
Cuando la organización esté preparada para incorporarse al Portal de administradores de suscripciones de Visual Studio, se enviará un correo electrónico a los contactos principales y los encargados de los avisos invitándolos a completar el proceso de incorporación. Los detalles siguientes corresponden a los pasos que hay que seguir para incorporarse al nuevo portal. Si quiere acceder a un tutorial sobre el proceso, consulte este [vídeo de incorporación de administradores](https://channel9.msdn.com/Series/Visual-Studio-Subscriptions-Administration/Onboarding-your-organization-to-the-new-Visual-Studio-Subscription-Administration-Portal-and-setting) o este [artículo de soporte técnico](https://support.microsoft.com/help/4013931/visual-studio-subscriptions-administrator-migration-process "Visual Studio Subscriptions Administrator Migration Process") (Proceso de migración de administradores de suscripciones de Visual Studio).   
1.  **Búsqueda de PCN e inicio de sesión:**
    - En el correo electrónico, los contactos principales o los encargados de los avisos encontrarán un vínculo único y los tres últimos dígitos de su número de cliente público (PCN). * 
    - Para obtener el PCN entero, el contacto principal deberá iniciar sesión en VLSC. Aquí encontrará instrucciones para buscar el PCN. 
    - Tras obtener el PCN, tendrá que seleccionar su vínculo único. Seguidamente, se le pedirá que inicie sesión. Podrá iniciar sesión con una cuenta profesional o educativa, si la organización se encuentra en AAD, o una cuenta Microsoft (MSA), si la organización no está en AAD. 
    - Después, tendrá que especificar el PCN. 
2.  **Configuración de los administradores.** Después de especificar el PCN, se registrará como superadministrador en el nuevo sistema y podrá agregar a otros superadministradores y administradores, lo que anteriormente se conocía como administradores de suscripciones. Para evitar perder el acceso, este procedimiento deberá realizarse antes de la fecha de la migración de su organización. 
3.  **Acceso al nuevo portal de administración de suscripciones.**  Cuando se haya migrado la organización, se enviarán correos electrónicos a los superadministradores y administradores recién agregados en los que se les invitará a acceder al nuevo portal y comenzar a administrar suscripciones.  

* *Nota: Si los contactos principales o encargados de los avisos reciben más de un correo electrónico, significa que tienen más de un PCN. Tendrán que completar el proceso mediante el vínculo único del PCN al que se haga referencia en cada correo electrónico.*

Si necesita que le agreguen al nuevo Portal de administradores de suscripciones de Visual Studio y no sabe quién es su contacto principal o el encargado de los avisos, puede encontrar esta información después de iniciar sesión en [VLSC](https://www.microsoft.com/Licensing/servicecenter/default.aspx). Eche un vistazo a [este artículo](https://www.visualstudio.com/subscriptions/support/locate-primary-contact/ "¿Cómo puedo encontrar mi contacto principal?") para ver los pasos necesarios para buscar su contacto principal o el encargado de los avisos en VLSC.
Si ya le han hecho administrador, puede ir directamente al [Portal de administradores de suscripciones de Visual Studio](https://manage.visualstudio.com).

### <a name="understanding-the-subscribers-page"></a>Descripción de la página Suscriptores
Una vez que haya asignado las suscripciones, la pestaña Suscriptores ofrecerá información detallada sobre los suscriptores, incluida la información siguiente:
- Nombre y apellidos de cada suscriptor.
- Dirección de correo electrónico del usuario.
- Nivel de suscripción que se le ha asignado.
- Fecha de asignación de la suscripción. 
- Fecha de expiración de la suscripción.
- Descripción de texto opcional.
- Indicación de si se han habilitado o deshabilitado las descargas para suscriptores. 
- País en el que se encuentran.
- Preferencia de idioma para el correo electrónico de comunicación de asignación desde el portal de administración.
- Campo opcional para otra dirección de correo electrónico para las comunicaciones de inicio de sesión. 

En el lado izquierdo de esta página puede ver información adicional sobre el número de licencias de suscripción adquiridas, asignadas y todavía disponibles en su organización para cada contrato.

![Página Suscriptores del Portal de administradores de suscripciones de Visual Studio](_img/using-admin-portal/subscribers-page.png)

### <a name="understanding-the-details-page"></a>Descripción de la página Detalles
Para obtener más información sobre el contrato que está consultando, seleccione la pestaña Detalles. Aquí se muestra el estado del contrato, la cuenta de compras, los detalles de la organización, los contactos principales (VLSC), los superadministradores (si están disponibles) y otra información pertinente.

![Página Detalles del Portal de administradores de suscripciones de Visual Studio](_img/using-admin-portal/details-page.png)

