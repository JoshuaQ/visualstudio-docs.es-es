---
title: 'Tutorial: Crear un elemento Web para SharePoint | Documentos de Microsoft'
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
- VB
- CSharp
helpviewer_keywords:
- Web Parts [SharePoint development in Visual Studio], developing
- Web Parts [SharePoint development in Visual Studio], creating
- Web Parts [SharePoint development in Visual Studio], designing
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: c4701cf7509b368c1264436d97d9fc95722e4aff
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="walkthrough-creating-a-web-part-for-sharepoint"></a>Tutorial: Crear un elemento web para SharePoint
  Los elementos web permiten a los usuarios modificar directamente el contenido, el aspecto y el comportamiento de las páginas de sitios de SharePoint mediante un explorador. En este tutorial se muestra cómo crear un elemento Web mediante el uso de la **elemento Web** plantilla de elemento en Visual Studio 2010.  
  
 El elemento web muestra los empleados en una cuadrícula de datos. El usuario especifica la ubicación del archivo que contiene los datos de los empleados. El usuario también puede filtrar la cuadrícula de datos para que en la lista solo aparezcan los empleados que son administradores.  
  
 En este tutorial se muestran las tareas siguientes:  
  
-   Crear un elemento Web mediante Visual Studio **elemento Web** plantilla de elemento.  
  
-   Crear una propiedad que puede establecer el usuario del elemento web. Esta propiedad especifica la ubicación del archivo de datos de los empleados.  
  
-   Presentar el contenido de un elemento web agregando controles a la colección de controles del elemento web.  
  
-   Crear un nuevo elemento de menú, hace referencia como un *verbo,* que aparece en el menú de verbos del elemento Web presentado. Los verbos permiten al usuario modificar los datos que aparecen en el elemento web.  
  
-   Probar el elemento web en SharePoint.  
  
    > [!NOTE]  
    >  Es posible que el equipo muestre nombres o ubicaciones diferentes para algunos de los elementos de la interfaz de usuario de Visual Studio en las siguientes instrucciones. La edición de Visual Studio que se tenga y la configuración que se utilice determinan estos elementos. Para más información, vea [Personalizar el IDE de Visual Studio](../ide/personalizing-the-visual-studio-ide.md).  
  
## <a name="prerequisites"></a>Requisitos previos  
 Necesita los componentes siguientes para completar este tutorial:  
  
-   Ediciones compatibles de Microsoft Windows y SharePoint. Para obtener más información, consulte [requisitos para desarrollar soluciones de SharePoint](../sharepoint/requirements-for-developing-sharepoint-solutions.md).  
  
-   [!INCLUDE[vs_pro_current_short](../sharepoint/includes/vs-pro-current-short-md.md)]o una edición de Visual Studio Application Lifecycle Management (ALM).  
  
## <a name="creating-an-empty-sharepoint-project"></a>Crear un proyecto vacío de SharePoint  
 Primero, cree un proyecto de SharePoint vacío. Más adelante, agregará un elemento Web al proyecto mediante el uso de la **elemento Web** plantilla de elemento.  
  
#### <a name="to-create-an-empty-sharepoint-project"></a>Para crear un proyecto vacío de SharePoint  
  
1.  Iniciar [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] mediante el uso de la **ejecutar como administrador** opción.  
  
2.  En la barra de menús, elija **archivo**, **New**, **proyecto**.  
  
3.  En el **nuevo proyecto** cuadro de diálogo, expanda el **SharePoint** nodo bajo el lenguaje que desea usar y, a continuación, elija la **2010** nodo.  
  
4.  En el **plantillas** panel, elija **proyecto de SharePoint 2010**y, a continuación, elija la **Aceptar** botón.  
  
     El **Asistente para personalización de SharePoint** aparece. Este asistente permite seleccionar el sitio que se va a usar para depurar el proyecto, así como el nivel de confianza de la solución.  
  
5.  Elija la **implementar como solución de granja de servidores** botón de opción y, a continuación, elija la **finalizar** botón para aceptar el sitio local predeterminado de SharePoint.  
  
## <a name="adding-a-web-part-to-the-project"></a>Agregar un elemento web al proyecto  
 Agregar un **elemento Web** elemento al proyecto. El **elemento Web** agrega el archivo de código del elemento Web. Después, agregará código al archivo de código para presentar el contenido del elemento web.  
  
#### <a name="to-add-a-web-part-to-the-project"></a>Para agregar un elemento web al proyecto  
  
1.  En la barra de menús, elija **proyecto**, **Agregar nuevo elemento**.  
  
2.  En el **Agregar nuevo elemento** cuadro de diálogo, en la **plantillas instaladas** panel, expanda el **SharePoint** nodo y, a continuación, elija la **2010** nodo.  
  
3.  En la lista de plantillas de SharePoint, elija el **elemento Web** plantilla y, a continuación, elija la **agregar** botón.  
  
     El **elemento Web** elemento aparece en **el Explorador de soluciones**.  
  
## <a name="rendering-content-in-the-web-part"></a>Presentar contenido en el elemento web  
 Puede especificar los controles que desea que aparezcan en el elemento web agregándolos a la colección de controles de la clase Web Part.  
  
#### <a name="to-render-content-in-the-web-part"></a>Para presentar contenido en el elemento web  
  
1.  En **el Explorador de soluciones**, abra WebPart1.vb (en Visual Basic) o WebPart1.cs (en C#).  
  
     Se abre el archivo de código del elemento web en el editor de código.  
  
2.  Agregue las siguientes instrucciones en la parte superior del archivo de código del elemento web.  
  
     [!code-csharp[SP_WebPart#1](../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs#1)]
     [!code-vb[SP_WebPart#1](../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb#1)]  
  
3.  Agregue el código siguiente a la clase `WebPart1`. Este código declara los siguientes campos:  
  
    -   Una cuadrícula de datos para mostrar los empleados en el elemento web.  
  
    -   Texto que aparece en el control que se utiliza para filtrar la cuadrícula de datos.  
  
    -   Una etiqueta que presenta un error si la cuadrícula de datos no puede mostrar los datos.  
  
    -   Una cadena que contiene la ruta del archivo de datos de los empleados.  
  
     [!code-csharp[SP_WebPart#2](../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs#2)]
     [!code-vb[SP_WebPart#2](../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb#2)]  
  
4.  Agregue el código siguiente a la clase `WebPart1`. Este código agrega una propiedad personalizada denominada `DataFilePath` al elemento web. Una propiedad personalizada es una propiedad que el usuario puede establecer en SharePoint. Esta propiedad obtiene y establece la ubicación de un archivo de datos XML que se utiliza para rellenar la cuadrícula de datos.  
  
     [!code-csharp[SP_WebPart#3](../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs#3)]
     [!code-vb[SP_WebPart#3](../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb#3)]  
  
5.  Reemplace el método `CreateChildControls` por el código siguiente. Este código realiza las tareas siguientes:  
  
    -   Agrega la cuadrícula de datos y la etiqueta que declaró en el paso anterior.  
  
    -   Enlaza la cuadrícula de datos a un archivo XML que contiene los datos de los empleados.  
  
     [!code-csharp[SP_WebPart#4](../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs#4)]
     [!code-vb[SP_WebPart#4](../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb#4)]  
  
6.  Agregue el método siguiente a la clase `WebPart1`. Este código realiza las tareas siguientes:  
  
    -   Crea un verbo que aparece en el menú de verbos de elemento web del elemento web presentado.  
  
    -   Controla el evento que se genera cuando el usuario elige el verbo del menú de verbos. Este código filtra la lista de empleados que aparece en la cuadrícula de datos.  
  
     [!code-csharp[SP_WebPart#5](../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs#5)]
     [!code-vb[SP_WebPart#5](../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb#5)]  
  
## <a name="testing-the-web-part"></a>Prueba del elemento web  
 Cuando se ejecuta el proyecto, se abre el sitio de SharePoint. El elemento web se agrega automáticamente a la Galería de elementos web de SharePoint. Puede agregar el elemento web a cualquier página de elementos web.  
  
#### <a name="to-test-the-web-part"></a>Para probar el elemento web  
  
1.  Pegue el código siguiente en un archivo de Bloc de notas. Este archivo XML contiene los datos de ejemplo que aparecerán en el elemento web.  
  
    ```  
    <?xml version="1.0" encoding="utf-8" ?>  
        <employees xmlns="http://schemas.microsoft.com/vsto/samples">  
           <employee>  
               <name>David Hamilton</name>  
               <hireDate>2001-05-11</hireDate>  
               <title>Sales Associate</title>  
           </employee>  
           <employee>  
               <name>Karina Leal</name>  
               <hireDate>1999-04-01</hireDate>  
               <title>Manager</title>  
           </employee>  
           <employee>  
               <name>Nancy Davolio</name>  
               <hireDate>1992-05-01</hireDate>  
               <title>Sales Associate</title>  
           </employee>  
           <employee>  
               <name>Steven Buchanan</name>  
               <hireDate>1955-03-04</hireDate>  
               <title>Manager</title>  
           </employee>  
           <employee>  
               <name>Suyama Michael</name>  
               <hireDate>1963-07-02</hireDate>  
               <title>Sales Associate</title>  
           </employee>  
        </employees>  
    ```  
  
2.  En el Bloc de notas, en la barra de menús, elija **archivo**, **Guardar como**.  
  
3.  En el **Guardar como** cuadro de diálogo, en la **Guardar como tipo** elija **todos los archivos**.  
  
4.  En el **nombre de archivo** cuadro, escriba **data.xml**.  
  
5.  Elija una carpeta mediante el uso de la **examinar carpetas** botón y, a continuación, elija la **guardar** botón.  
  
6.  En Visual Studio, elija la **F5** clave.  
  
     Se abre el sitio de SharePoint.  
  
7.  En el **acciones del sitio** menú, elija **más opciones**.  
  
8.  En el **crear** página, elija la **página de elementos Web** escriba, a continuación, elija la **crear** botón.  
  
9. En el **nueva página de elementos Web** página, asigne el nombre de la página **SampleWebPartPage.aspx**y, a continuación, elija la **crear** botón.  
  
     Aparece la página de elementos web .  
  
10. Seleccione cualquier zona de la página de elementos web.  
  
11. En la parte superior de la página, elija la **insertar** ficha y, a continuación, elija la **elemento Web** botón.  
  
12. En el **categorías** panel, elija la **personalizado** carpeta, elija la **WebPart1** elemento Web y, a continuación, elija la **agregar** botón.  
  
     El elemento web aparece en la página.  
  
## <a name="testing-the-custom-property"></a>Probar la propiedad personalizada  
 Para rellenar la cuadrícula de datos que aparece en el elemento web, especifique la ruta de acceso del archivo XML que contiene los datos sobre cada empleado.  
  
#### <a name="to-test-the-custom-property"></a>Para probar la propiedad personalizada  
  
1.  Elija la flecha que aparece en el lado derecho del elemento Web y, a continuación, elija **Editar elemento Web** en el menú que aparece.  
  
     Un panel con las propiedades del elemento web aparece en el lado derecho de la página.  
  
2.  En el panel, expanda el **varios** nodo, escriba la ruta de acceso del archivo XML que creó anteriormente, elija la **aplicar** botón y, a continuación, elija la **Aceptar** botón.  
  
     Compruebe que en el elemento web aparece una lista de empleados.  
  
## <a name="testing-the-web-part-verb"></a>Probar el verbo de elemento web  
 Muestra y oculta a los empleados que no son administradores cuando se hace clic en un elemento que aparece en el menú de verbos del elemento web.  
  
#### <a name="to-test-the-web-part-verb"></a>Para probar el verbo del elemento web  
  
1.  Elija la flecha que aparece en el lado derecho del elemento Web y, a continuación, elija **mostrar solo a los administradores** en el menú que aparece.  
  
     Solo los empleados que son administradores aparecen en el elemento web.  
  
2.  Vuelva a elegir la flecha y, a continuación, elija **muestra todos los empleados** en el menú que aparece.  
  
     Todos los empleados aparecen en el elemento web.  
  
## <a name="see-also"></a>Vea también  
 [Crear elementos Web para SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)   
 [Cómo: crear un elemento Web de SharePoint](../sharepoint/how-to-create-a-sharepoint-web-part.md)   
 [Cómo: crear un elemento Web de SharePoint utilizando un diseñador](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md)   
 [Tutorial: Crear un elemento web para SharePoint mediante un diseñador](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md)  
  
  