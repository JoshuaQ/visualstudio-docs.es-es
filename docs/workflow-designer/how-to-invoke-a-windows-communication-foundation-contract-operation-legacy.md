---
title: "Cómo: invocar una operación de contrato de Windows Communication Foundation (heredado) | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: reference
ms.assetid: a9058345-708f-4fcf-8739-2a43e5285b7a
caps.latest.revision: "8"
author: ErikRe
ms.author: erikre
manager: erikre
ms.workload: multiple
ms.openlocfilehash: fdc27d34efef818dae30d1f54f5f3a67e7408d7d
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-invoke-a-windows-communication-foundation-contract-operation-legacy"></a>Cómo: Invocar una operación de contrato de Windows Communication Foundation (Heredado)
En este tema se describe cómo invocar una operación de contrato de [!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] usando [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] heredado que tiene como destino [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] o [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 Después de arrastrar un **SendActivity** actividad en el cuadro de herramientas a la superficie de diseño de flujo de trabajo, debe importar un contrato existente y determinar qué operación se invocará desde que **SendActivity** actividad. Seleccione el contrato y sus operaciones a través de la [elija el cuadro de diálogo de operación (heredado)](../workflow-designer/choose-operation-dialog-box-legacy.md).  
  
 Además, si se utiliza un archivo de configuración con el servicio, es necesario especificar un <xref:System.Workflow.Activities.ChannelToken>. <xref:System.Workflow.Activities.ChannelToken> identifica la configuración del extremo que la actividad de envío va a utilizar para conectar con el servicio de flujo de trabajo.  
  
### <a name="to-invoke-a-wcf-contract-operation-from-a-sendactivity-activity"></a>Invocar una operación de contrato WCF desde una actividad SendActivity  
  
1.  Haga doble clic en el **SendActivity** actividad en el diseñador o haga clic en los puntos suspensivos junto a la **ServiceOperationInfo** propiedad en el **propiedades** panel.  
  
2.  Cuando el **elegir operación** abre el cuadro de diálogo, haga clic en **importación** en la esquina superior derecha del cuadro de diálogo.  
  
     El [examinar y seleccionar un cuadro de diálogo de tipo de .NET (heredado)](../workflow-designer/browse-and-select-a-dotnet-type-dialog-box-legacy.md) se abre.  
  
3.  Busque un ensamblado o proyecto que contenga el contrato deseado.  
  
4.  Seleccione el contrato y haga clic en **Aceptar**.  
  
5.  En **operaciones disponibles**, seleccione la operación que desea invocar y haga clic en **Aceptar**.  
  
### <a name="to-specify-a-channel-token"></a>Para especificar un token de canal  
  
1.  Seleccione la actividad <xref:System.Workflow.Activities.SendActivity> en el diseñador.  
  
2.  En el **propiedades** panel, especifique un nombre para el <xref:System.Workflow.Activities.ChannelToken>. Este nombre únicamente identifica el token de canal.  
  
3.  Expanda el nodo del token de canal y especifique un nombre para el extremo de cliente que va a utilizar en el campo <xref:System.Workflow.Activities.ChannelToken.EndpointName%2A>. La configuración del extremo del mismo nombre en el archivo de configuración se utilizará para configurar el canal.  
  
4.  Cree la configuración del punto de conexión en el archivo de configuración, si aún no existe. Para obtener más información acerca de cómo configurar el cliente, consulte [información general sobre el cliente de WCF](/dotnet/framework/wcf/wcf-client-overview).  
  
## <a name="see-also"></a>Vea también  
 [Elija el cuadro de diálogo de operación (heredado)](../workflow-designer/choose-operation-dialog-box-legacy.md)   
 [Cómo: implementar una operación de contrato WCF (heredado)](../workflow-designer/how-to-implement-a-windows-communication-foundation-contract-operation-legacy.md)   
 [Actividades de flujo de trabajo heredadas](../workflow-designer/legacy-workflow-activities.md)