---
title: "Edición de suscripciones en el Portal de administradores | Visual Studio Marketplace"
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 10/3/2017
Ms.topic: Get-Started-Article
Description: Learn how administrators can edit subscription assignments.
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
ms.openlocfilehash: c561e7a56f2e70cae1addd32902f68a582b49a02
ms.sourcegitcommit: b7d3b90d0be597c9d01879338dd2678c881087ce
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/01/2017
---
# <a name="editing-visual-studio-subscription-assignments"></a>Edición de las asignaciones de suscripción de Visual Studio

## <a name="making-changes-to-subscriber-information"></a>Aplicación de cambios en la información del suscriptor
Puede editar la información del suscriptor para corregir los errores o actualizarla. 
**Tenga en cuenta que, si edita la dirección de correo electrónico de un suscriptor, se restablecerán las ventajas existentes.**

Para editar un suscriptor, seleccione los puntos suspensivos (...) que aparecen junto a la dirección de correo electrónico del suscriptor al mantener el mouse sobre él. Aparecerá una lista desplegable.  Seleccione **Editar** para modificar los detalles del suscriptor. También puede hacer doble clic en la fila del suscriptor en la cuadrícula para abrir la ventana de edición.

   ![Selección de un suscriptor para editarlo](_img\edit-license\select-subscriber.png)

Puede actualizar nombre del suscriptor, los apellidos, el país, el idioma y las descargas. Edite la información del suscriptor y haga clic en **Guardar**.

   ![Edición de los detalles del suscriptor](_img\edit-license\edit-subscriber.png)

Nota: Si tiene que cambiar el nivel de suscripción de un suscriptor, primero debe eliminar el usuario del portal y volverlo a agregar. Los niveles de suscripción no son editables.

## <a name="editing-multiple-subscribers-by-using-bulk-edit"></a>Edición en masa de varios suscriptores

Puede editar varios suscriptores a la vez mediante el proceso de edición en masa. Esta característica se usa principalmente en organizaciones que están efectuando cambios en la dirección de correo electrónico corporativa o cuando una organización ha decidido restringir el acceso a las descargas. 

**IMPORTANTE:** Los niveles de suscripción, es decir, Enterprise, Professional, etc., y los GUID de suscripción no se pueden modificar.  Si intenta realizar una carga con estos elementos cambiados, no podrá hacerla.  

1.  Para editar varios suscriptores a la vez, navegue hasta la pestaña Suscriptores. En la cinta de la parte superior, haga clic en **Edición en masa**. 

    ![Edición de una licencia: edición en masa](_img\edit-license\edit-license-bulk-edit.png)

2.  La edición en masa usa una plantilla de Excel para realizar modificaciones en la información de los suscriptores. En el cuadro Edición en masa, haga clic en **Export this Excel** (Exportar este Excel) para descargar la lista actual de los suscriptores con toda su información. 

    ![Edición de una licencia: exportación en masa de la lista de ediciones](_img\edit-license\edit-license-bulk-edit-export.png)

3.  Después, guarde el archivo localmente de modo que pueda encontrarlo fácilmente y realizar los cambios necesarios antes de cargarlo. Para garantizar una carga correcta, **no edite el nivel de suscripción ni el GUID de suscripción**, ya que si lo hace la carga no se podrá efectuar. 

4.  Vuelva al Portal de administradores de suscripciones de Visual Studio y, en el cuadro de diálogo Edición en masa, haga clic en **Examinar**. Seleccione el archivo de Excel que ha guardado y haga clic en **Aceptar**. Verá el progreso de la carga en la pantalla.

    ![Edición de una licencia: carga de archivos de ediciones en masa](_img\edit-license\edit-license-bulk-file-upload1.png)

5.  Cuando haya cargado el archivo, verá una notificación en la que se le indicará que se ha realizado correctamente. 

    ![Edición de una licencia: carga de archivos de ediciones en masa completada](_img\edit-license\edit-license-bulk-upload-complete.png)


