---
title: "Cómo: crear un comando de SharePoint | Documentos de Microsoft"
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
helpviewer_keywords: SharePoint commands [SharePoint development in Visual Studio], creating
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 9afdf3c26d059a7593d21eb7844f8a1b45cc9d01
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-create-a-sharepoint-command"></a>Cómo: Crear un comando de SharePoint
  Si desea utilizar el modelo de objetos de servidor en una extensión de herramientas de SharePoint, debe crear una personalizada *comando de SharePoint* para llamar a la API. Defina el comando de SharePoint en un ensamblado que se puede llamar directamente al modelo de objetos de servidor.  
  
 Para obtener más información sobre la finalidad de los comandos de SharePoint, vea [llamar a los modelos de objetos de SharePoint](../sharepoint/calling-into-the-sharepoint-object-models.md).  
  
### <a name="to-create-a-sharepoint-command"></a>Para crear un comando de SharePoint  
  
1.  Cree un proyecto de biblioteca de clases que tenga la siguiente configuración:  
  
    -   Tiene como destino .NET Framework 3.5. Para obtener más información acerca de cómo seleccionar la plataforma de destino, vea [Cómo: elegir como destino una versión de .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).  
  
    -   Tiene como destino AnyCPU o x64 plataforma. De forma predeterminada, la plataforma de destino para los proyectos de biblioteca de clases es AnyCPU. Para obtener más información acerca de cómo seleccionar la plataforma de destino, vea [Cómo: configurar proyectos para plataformas de destino](../ide/how-to-configure-projects-to-target-platforms.md).  
  
    > [!NOTE]  
    >  No se puede implementar un comando de SharePoint en el mismo proyecto que define una extensión de herramientas de SharePoint, ya que los comandos de SharePoint como destino el destino de las extensiones de herramientas de .NET Framework 3.5 y SharePoint el [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. Debe definir los comandos de SharePoint que utilizan la extensión en un proyecto independiente. Para obtener más información, consulte [extensiones de implementación para las herramientas de SharePoint en Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
2.  Agregue referencias a los siguientes ensamblados:  
  
    -   Microsoft.VisualStudio.SharePoint.Commands  
  
    -   Microsoft.SharePoint  
  
3.  En una clase en el proyecto, cree un método que define el comando de SharePoint. El método debe ajustarse a las siguientes directrices:  
  
    -   Puede tener uno o dos parámetros.  
  
         El primer parámetro debe ser un <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> objeto. Este objeto proporciona la Microsoft.SharePoint.SPSite o Microsoft.SharePoint.SPWeb en el que se ejecuta el comando. También proporciona un <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandLogger> objeto que puede utilizarse para escribir mensajes en el **salida** ventana o **lista de errores** ventana de Visual Studio.  
  
         El segundo parámetro puede ser un tipo de su elección, pero este parámetro es opcional. Puede agregar este parámetro al comando de SharePoint si necesita pasar datos de la extensión de herramientas de SharePoint al comando.  
  
    -   Puede tener un valor devuelto, pero esto es opcional.  
  
    -   El segundo parámetro y el valor devuelto debe ser un tipo que se pueda serializar mediante Windows Communication Foundation (WCF). Para obtener más información, consulte [tipos admitidos por el serializador de contratos de datos](/dotnet/framework/wcf/feature-details/types-supported-by-the-data-contract-serializer) y [mediante la clase XmlSerializer](/dotnet/framework/wcf/feature-details/using-the-xmlserializer-class).  
  
    -   El método puede tener cualquier visibilidad (**público**, **interno**, o **privada**), y pueden ser estáticos o no estáticos.  
  
4.  Aplicar el <xref:Microsoft.VisualStudio.SharePoint.Commands.SharePointCommandAttribute> al método. Este atributo especifica un identificador único para el comando; Este identificador no es necesario para que coincida con el nombre del método.  
  
     Debe especificar el mismo identificador único al llamar al comando desde la extensión de herramientas de SharePoint. Para obtener más información, consulte [Cómo: ejecutar un comando de SharePoint](../sharepoint/how-to-execute-a-sharepoint-command.md).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo de código siguiente se muestra un comando de SharePoint que tiene el identificador `Contoso.Commands.UpgradeSolution`. Este comando usa las API en el modelo de objetos de servidor para actualizar a una solución implementada.  
  
 [!code-csharp[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#5](../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/SharePointCommands/Commands.cs#5)]
 [!code-vb[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#5](../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/sharepointcommands/commands.vb#5)]  
  
 Además de la primera implícita <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parámetro, este comando también tiene un parámetro de cadena personalizado que contiene la ruta de acceso completa del archivo .wsp que se actualiza en el sitio de SharePoint. Para ver este código en el contexto de un ejemplo más extenso, vea [Tutorial: crear un paso de implementación personalizado para proyectos de SharePoint de](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
## <a name="compiling-the-code"></a>Compilar el código  
 Este ejemplo requiere referencias a los siguientes ensamblados:  
  
-   Microsoft.VisualStudio.SharePoint.Commands  
  
-   Microsoft.SharePoint  
  
## <a name="deploying-the-command"></a>Implementar el comando  
 Para implementar el comando, incluya el ensamblado del comando en la misma [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] paquete de extensión (VSIX) con el ensamblado de extensión que se utiliza el comando. También debe agregar una entrada para el ensamblado de comando en el archivo extension.vsixmanifest. Para obtener más información, consulte [extensiones de implementación para las herramientas de SharePoint en Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## <a name="see-also"></a>Vea también  
 [Llamar a los modelos de objetos de SharePoint](../sharepoint/calling-into-the-sharepoint-object-models.md)   
 [Cómo: ejecutar un comando de SharePoint](../sharepoint/how-to-execute-a-sharepoint-command.md)   
 [Tutorial: Extender el Explorador de servidores para mostrar elementos web](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)  
  
  