---
title: "Tutorial: Importar una página maestra personalizada y página de sitio con una imagen | Documentos de Microsoft"
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
helpviewer_keywords:
- SharePoint development in Visual Studio, importing items
- importing items [SharePoint development in Visual Studio]
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 544c3c727046fdcabcde90f221f4b630c11cf29f
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="walkthrough-import-a-custom-master-page-and-site-page-with-an-image"></a>Tutorial: Importar una página maestra personalizada y una página de sitio con una imagen
  Este tutorial muestra cómo importar una página maestra personalizada de SharePoint y una página del sitio que tiene una imagen en un [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] proyecto de SharePoint.  
  
 En este tutorial se muestra cómo llevar a cabo las tareas siguientes:  
  
-   Crear una página maestra personalizada y una página del sitio mediante una imagen en SharePoint Designer.  
  
-   Exportar una página maestra personalizada, la imagen y la página del sitio a un archivo de solución (.wsp) de SharePoint.  
  
-   Importe e implemente el archivo .wsp en un [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] proyecto de SharePoint usando el proyecto Importar paquete de solución de SharePoint.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## <a name="prerequisites"></a>Requisitos previos  
 Debe tener los componentes siguientes para completar este tutorial:  
  
-   Ediciones compatibles de [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] y SharePoint. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)][Requisitos para desarrollar soluciones de SharePoint](../sharepoint/requirements-for-developing-sharepoint-solutions.md).  
  
-   Visual Studio.  
  
-   SharePoint Designer 2010.  
  
## <a name="create-items-in-sharepoint-designer"></a>Crear elementos en SharePoint Designer  
 Este ejemplo muestra cómo crear tres elementos en SharePoint Designer para la exportación: una página maestra personalizada, una página del sitio que hace referencia a la página maestra personalizada y un archivo de imagen que aparecerá en la página del sitio. La imagen se agrega a la carpeta/Images / en SharePoint.  
  
#### <a name="to-create-a-custom-master-page-in-sharepoint-designer"></a>Para crear una página maestra personalizada en SharePoint Designer  
  
1.  En SharePoint Designer, en el panel de navegación, elija la **páginas maestras** objeto de sitio.  
  
2.  En el **páginas maestras** la cinta de opciones, elija **página principal en blanco**.  
  
3.  Elija la nueva página maestra y, a continuación, en la **páginas maestras** la cinta de opciones, elija **Editar archivo**.  
  
4.  En la parte inferior del Diseñador de SharePoint, elija el **código** ficha.  
  
5.  Reemplace el marcado existente con el siguiente marcado.  
  
    ```  
    <%@ Master Language="C#" %>  
    <%@ Register tagprefix="SharePoint" namespace="Microsoft.SharePoint.WebControls" assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>  
    <html dir="ltr">  
    <head runat="server">  
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">  
    <SharePoint:RobotsMetaTag runat="server" __designer:Preview="" __designer:Values="<P N='InDesign' T='False' /><P N='ID' T='ctl00' /><P N='Page' ID='1' /><P N='TemplateControl' ID='2' /><P N='AppRelativeTemplateSourceDirectory' R='-1' />"></SharePoint:RobotsMetaTag>  
    <title>Web Page</title>  
    </head>  
    <body>  
    <form id="form1" runat="server">  
    <asp:ContentPlaceHolder id="ContentPlaceHolderMain"   
            runat="server">  
          </asp:ContentPlaceHolder>  
    </form>  
    </body>  
    </html>  
    ```  
  
6.  Guarde la página, elija la **páginas maestras** pestaña y cambie el nombre de la página maestra como **mybasic1.master**.  
  
## <a name="add-an-image-to-the-content-database-in-sharepoint-designer"></a>Agregar una imagen a la base de datos de contenido en SharePoint Designer  
 Ahora puede agregar una imagen que se muestra en la página del sitio. La imagen se implementa en la base de datos de contenido de SharePoint.  
  
#### <a name="to-add-an-image-to-the-content-database-in-sharepoint-designer"></a>Para agregar una imagen a la base de datos de contenido en SharePoint Designer  
  
1.  En el panel de navegación, elija la **todos los archivos** objeto de sitio y, a continuación, en la vista de árbol, elija la **imágenes** carpeta.  
  
2.  En el **todos los archivos** la cinta de opciones, elija **importar archivos**, elija un archivo de su elección y, a continuación, elija la **Aceptar** botón. En este ejemplo, el archivo se denomina **myimg1.png**.  
  
     Si lo desea, puede crear una subcarpeta para ayudar a organizar las imágenes.  
  
3.  Cerrar la **importación** cuadro de diálogo.  
  
## <a name="create-a-site-page"></a>Crear una página del sitio  
 Esta página del sitio de básico usa la página maestra personalizada y muestra la imagen que agregó en el paso anterior.  
  
#### <a name="to-create-a-site-page"></a>Para crear una página de sitio  
  
1.  En el panel de navegación, elija la **páginas del sitio** objeto.  
  
2.  En el **páginas** la cinta de opciones, elija la **página** botón, elija la **ASPX** página escriba y, a continuación, asigne al nuevo archivo **mycontentpage1.aspx**.  
  
     Si lo desea, puede crear una subcarpeta para ayudar a organizar las páginas del sitio.  
  
3.  En la lista de páginas del sitio, elija **MyContentPage1.aspx** para abrir su página de propiedades y, a continuación, en la parte inferior de la página, elija la **Editar archivo** vínculo.  
  
     Si aparece un mensaje e indica que esta página no contiene ninguna de las áreas que se pueden editar en modo seguro y le pregunta si desea abrir esta página en el modo avanzado, elija la **Sí** botón.  
  
4.  En la parte inferior de la página, elija la **código** botón.  
  
5.  Reemplace el marcado existente con el siguiente marcado.  
  
    ```  
    <%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>  
    <%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>  
    <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>  
    <%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>  
    <%@ Import Namespace="Microsoft.SharePoint" %>  
    <%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>  
    <%@ Page Language="C#" Inherits="Microsoft.SharePoint.WebControls.LayoutsPageBase" MasterPageFile="../_catalogs/masterpage/mybasic1.master" meta:progid="SharePoint.WebPartPage.Document" %>  
  
    <asp:Content ID="Main" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">  
    <img alt="My Image" longdesc="My image from images folder" src="../images/myimg1.png" />  
    </asp:Content>  
    ```  
  
6.  Guarde la página sitio actualizado.  
  
## <a name="export-the-items-from-sharepoint"></a>Exportar elementos de SharePoint  
 Exportar los elementos de SharePoint a un archivo de solución (.wsp) de SharePoint.  
  
#### <a name="to-export-items-from-sharepoint-designer"></a>Para exportar elementos de SharePoint Designer  
  
1.  En SharePoint Designer, en el panel de navegación, elija la **equipo sitio** objeto y, a continuación, en la **sitio** la cinta de opciones, elija **Guardar como plantilla**.  
  
2.  En el **Guardar como plantilla** diálogo cuadro, escriba un nombre de archivo y el nombre de la plantilla, seleccione la **incluir contenido** casilla de verificación y, a continuación, elija la **Aceptar** botón.  
  
     Esto guarda el contenido del sitio en el archivo .wsp.  
  
3.  Cuando se exporta la solución, elija la **Galería de soluciones** vínculo para mostrar la lista de archivos de las soluciones disponibles.  
  
4.  Abra el menú contextual para el nuevo archivo .wsp y, a continuación, elija **Guardar destino como** para guardar en el sistema.  
  
## <a name="import-the-items-into-visual-studio"></a>Importar los elementos en Visual Studio  
 Importar el archivo .wsp en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. Una vez importado el contenido, puede personalizarlo, agregar más elementos y, a continuación, implementarlo.  
  
#### <a name="to-import-items-from-the-wsp-file-into-visual-studio"></a>Para importar elementos desde el archivo .wsp en Visual Studio  
  
1.  En [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], cree un **Importar paquete de solución de SharePoint 2010** proyecto.  
  
2.  En el **seleccionar elementos para importar** página, en **módulo** en el **tipo** columna, seleccione las casillas de verificación para solo los archivos en la siguiente tabla para la importación.  
  
    |Nombre de archivo|Descripción|  
    |---------------|-----------------|  
    |_catalogsmasterpage\_|La página maestra personalizada.|  
    |images_|El archivo de imagen en el sistema de archivos de SharePoint.|  
    |SitePages_|La página del sitio.|  
  
3.  Elija la **finalizar** botón para importar los elementos seleccionados.  
  
4.  En **el Explorador de soluciones**, elija la _catalogsmasterpage\_ nodo y establezca el valor de su **Deployment Conflict Resolution** propiedad **automática**.  
  
     Esto ayuda a garantizar que los conflictos de implementación se resuelven automáticamente.  
  
5.  Si la nueva página principal tiene el mismo nombre que una página existente, asegúrese de que la página existente no está marcada como una página maestra predeterminada o una página maestra personalizada en SharePoint Designer.  
  
     Si una página maestra existente está marcada como página maestra predeterminada o página maestra personalizada, obtendrá un error de implementación que indica que no se puede eliminar la página maestra. Para evitar este problema, haga esto:  
  
    -   Si la página maestra existente se establece como página maestra predeterminada, establecer temporalmente otra página maestra como página maestra predeterminada. Después de implementar los archivos en SharePoint, establezca la nueva página principal como página maestra predeterminada.  
  
    -   Si la página maestra existente se establece como página principal personalizada, establezca temporalmente otra página maestra como página principal personalizada. Después de implementar los archivos en SharePoint, establezca la nueva página principal como página principal personalizada.  
  
6.  En la barra de menús, elija **generar**, **implementar solución**.  
  
7.  Abra el sitio de SharePoint para ver los elementos implementados.  
  
 Una manera alternativa para importar archivos en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] e implementarlos en SharePoint consiste en agregar los archivos en los módulos de [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)][Cómo: importar un tema o página maestra](../sharepoint/how-to-import-a-master-page-or-theme.md) y [utilizar módulos para incluir archivos en la solución](../sharepoint/using-modules-to-include-files-in-the-solution.md).  
  
## <a name="see-also"></a>Vea también  
 [Importar elementos de un sitio de SharePoint existente](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)   
 [Desarrollar soluciones de SharePoint](../sharepoint/developing-sharepoint-solutions.md)   
 [Crear controles reutilizables para elementos web o páginas de aplicación](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)  
  
  