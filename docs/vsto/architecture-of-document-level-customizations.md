---
title: Arquitectura de las personalizaciones de nivel de documento | Documentos de Microsoft
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
- VSTOLoader.dll
- formats [Office development in Visual Studio]
- file formats [Office development in Visual Studio]
- vstoee.dll
- managed code extensions [Office development in Visual Studio], definition
- document-level customizations [Office development in Visual Studio]
- AddInLoader.dll
- architecture [Office development in Visual Studio], document-level customizations
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 09a8700086ec8a718e14764f807e57fcb1f882f7
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="architecture-of-document-level-customizations"></a>Arquitectura de las personalizaciones de nivel de documento
  [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)] incluye proyectos para la creación de personalizaciones de nivel de documento de Microsoft Office Word y Microsoft Office Excel. En este tema se describen los siguientes aspectos de las personalizaciones de nivel de documento:  
  
-   [Descripción de las personalizaciones](#UnderstandingCustomizations)  
  
-   [Componentes de las personalizaciones](#Components)  
  
-   [Cómo funcionan las personalizaciones con aplicaciones de Microsoft Office](#HowCustomizationsWork)  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
 Para obtener información general acerca de cómo crear personalizaciones de nivel de documento, consulte [información general sobre el desarrollo de soluciones de Office &#40; VSTO &#41; ](../vsto/office-solutions-development-overview-vsto.md), [Introducción a la programación de personalizaciones de nivel de documento para Word](../vsto/getting-started-programming-document-level-customizations-for-word.md), y [Introducción a la programación de personalizaciones de nivel de documento para Excel](../vsto/getting-started-programming-document-level-customizations-for-excel.md).  
  
##  <a name="UnderstandingCustomizations"></a> Understanding Customizations  
 Si usa Office Developer Tools en Visual Studio para compilar una personalización de nivel de documento, se crea un ensamblado de código administrado que se asocia con un documento concreto. Se dice que un documento o un libro con un ensamblado vinculado dispone de extensiones de código administrado. Para obtener más información, consulta [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
 Cuando un usuario abre el documento, la aplicación de Microsoft Office carga el ensamblado. Cuando se carga el ensamblado, la personalización puede responder a eventos mientras el documento está abierto. La personalización también puede hacer llamadas al modelo de objetos para automatizar y extender la aplicación mientras el documento está abierto, y puede usar cualquiera de las clases de [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)].  
  
 El ensamblado se comunica con los componentes COM de la aplicación a través del ensamblado de interoperabilidad primario de la aplicación. Para obtener más información, consulte [ensamblados de interoperabilidad primarios de Office](../vsto/office-primary-interop-assemblies.md) y [información general sobre el desarrollo de soluciones de Office &#40; VSTO &#41; ](../vsto/office-solutions-development-overview-vsto.md).  
  
 Si un usuario abre varias personalizaciones de nivel de documento a la vez, cada ensamblado se carga en un dominio de aplicación distinto. Esto significa que una solución que se comporta incorrectamente no puede hacer que otras generen un error. Las personalizaciones de nivel de documento están diseñadas para trabajar con un único documento en un dominio de aplicación único. No están diseñados para una comunicación entre documentos. Para obtener más información acerca de los dominios de aplicación, consulte [dominios de aplicación](/dotnet/framework/app-domains/application-domains).  
  
> [!NOTE]  
>  Las personalizaciones de nivel de documento que se crean con Office Developer Tools en Visual Studio están diseñadas para usarse solo cuando un usuario final inicia la aplicación. Si la aplicación se inicia mediante programación, por ejemplo, mediante Automatización, la personalización podría no funcionar según lo esperado.  
  
### <a name="design-time-and-run-time-experiences"></a>Experiencias en tiempo de diseño y tiempo de ejecución  
 Para entender la arquitectura de las personalizaciones de nivel de documento, resulta útil comprender las experiencias de diseño y de ejecución de una solución.  
  
#### <a name="design-time"></a>Tiempo de diseño  
 En la experiencia en tiempo de diseño se incluyen los pasos siguientes:  
  
1.  El desarrollador crea un proyecto de nivel de documento en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. El proyecto incluye el documento y el ensamblado que se ejecuta detrás del documento. Es posible que el documento ya exista (posiblemente creado por un diseñador) o se puede crear un nuevo documento junto con el proyecto.  
  
2.  El diseñador, ya sea el desarrollador que crea el proyecto u otra persona, crea la apariencia final del documento para el usuario final.  
  
#### <a name="run-time"></a>Tiempo de ejecución  
 En la experiencia en tiempo de ejecución se incluyen los pasos siguientes:  
  
1.  El usuario final abre un documento o un libro que tiene extensiones de código administrado.  
  
2.  El documento o el libro carga el ensamblado compilado.  
  
3.  El ensamblado responde a los eventos mientras el usuario trabaja en el documento o el libro.  
  
#### <a name="developer-and-end-user-perspective-compared"></a>Comparativa de las perspectivas del desarrollador y el usuario final  
 Como el desarrollador trabaja principalmente en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]y el usuario final trabaja en Word o Excel, hay dos maneras de entender las personalizaciones de nivel de documento.  
  
|Perspectiva del desarrollador|Perspectiva del usuario final|  
|-----------------------------|----------------------------|  
|Con [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], el desarrollador escribe código que es accesible para Word y Excel.<br /><br /> Aunque pueda parecer que el programador crea un archivo ejecutable que ejecuta Word o Excel, en realidad el proceso funciona al revés. El documento se asocia a un ensamblado y contiene un puntero a ese ensamblado. Cuando se abre el documento, Word o Excel localiza el ensamblado y ejecuta el código en respuesta a todos los eventos controlados.|Los que usan la solución simplemente abren el documento o el libro (o crean un nuevo documento desde una plantilla) de la misma forma que abrirían cualquier otro archivo de Microsoft Office.<br /><br /> El ensamblado ofrece personalizaciones en el documento o el libro, como rellenarlos automáticamente con datos actuales o mostrar un cuadro de diálogo para solicitar información.|  
  
### <a name="supported-document-formats-for-document-level-customizations"></a>Formatos de documento admitidos para las personalizaciones de nivel de documento  
 Cuando crea un proyecto de personalización, puede elegir el formato del documento que desea utilizar en el proyecto. Para obtener más información, consulta [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
 En la tabla siguiente se enumeran los formatos de documento que se pueden utilizar en las personalizaciones de nivel de documento para Excel y Word.  
  
|Excel|Palabra|  
|-----------|----------|  
|Libro de Excel (.xlsx)<br /><br /> Libro de Excel habilitado para macros (.xlsm)<br /><br /> Libro binario de Excel (.xlsb)<br /><br /> Libro de Excel 97-2003 (.xls)<br /><br /> Plantilla de Excel (.xltx)<br /><br /> Plantilla de Excel habilitada para macros (.xltm)<br /><br /> Plantilla de Excel 97-2003 (.xlt)|Documento de Word (.docx)<br /><br /> Documento de Word habilitado para macros (.docm)<br /><br /> Documento de Word 97-2003 (.doc)<br /><br /> Plantilla de Word (.dotx)<br /><br /> Plantilla de Word habilitada para macros (.dotm)<br /><br /> Plantilla de Word 97-2003 (.dot)|  
  
 Debe diseñar extensiones de código administrado únicamente para los documentos en los formatos que se admiten. De lo contrario, es posible que no se generen determinados eventos si el documento se abre en la aplicación. Por ejemplo, el evento <xref:Microsoft.Office.Tools.Excel.Workbook.Open> no se genera si se utilizan extensiones de código administrado con libros guardados en el formato de hoja de cálculo XML de Excel o en el formato de página web (.htm; .html).  
  
### <a name="support-for-word-documents-that-have-xml-file-name-extensions"></a>Compatibilidad con documentos de Word que tienen extensiones de nombre de archivo .xml  
 Las plantillas de proyecto de nivel de documento no permiten crear proyectos basados en los siguientes formatos de archivo:  
  
-   Documento XML de Word (*xml).  
  
-   Documento XML de Word 2003 (*xml).  
  
 Si desea que los usuarios finales utilicen las personalizaciones en estos formatos de archivo, compile e implemente una personalización que use uno de los formatos de archivo compatibles que se especifican en la tabla anterior. Después de instalar la personalización, los usuarios finales pueden guardar el documento en el documento XML de Word (* xml) formato o el documento XML de Word 2003 (\*xml) formato y la personalización continuará funcionando según lo previsto.  
  
##  <a name="Components"></a> Components of Customizations  
 Los componentes principales de una personalización son el documento y el ensamblado. Además de estos componentes, existen otras partes que desempeñan un papel importante en la forma en que las aplicaciones de Microsoft Office detectan y cargan personalizaciones.  
  
### <a name="deployment-manifest-and-application-manifest"></a>Manifiesto de implementación y manifiesto de aplicación  
 Las personalizaciones usan manifiestos de implementación y manifiestos de aplicación para identificar y cargar la versión más reciente del ensamblado de personalización. El manifiesto de implementación apunta al manifiesto de aplicación actual. El manifiesto de aplicación apunta al ensamblado de personalización y especifica la clase (o clases) de punto de entrada que se ejecutará en el ensamblado. Para obtener más información, consulta [Application and Deployment Manifests in Office Solutions](../vsto/application-and-deployment-manifests-in-office-solutions.md).  
  
### <a name="visual-studio-tools-for-office-runtime"></a>Visual Studio Tools para Office Runtime  
 Para ejecutar personalizaciones de nivel de documento que se creen mediante Office Developer Tools en Visual Studio, los equipos de los usuarios finales deben tener instalado [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] . [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] incluye componentes no administrados que cargan el ensamblado de personalización y también un conjunto de ensamblados administrados. Estos ensamblados administrados proporcionan el modelo de objetos que el código de personalización usa para automatizar y extender la aplicación host.  
  
 Para obtener más información, consulta [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).  
  
##  <a name="HowCustomizationsWork"></a> How Customizations Work with Microsoft Office Applications  
 Cuando un usuario abre un documento que forma parte de una personalización de Microsoft Office, la aplicación utiliza el manifiesto de implementación que está vinculado al documento para buscar y cargar la versión más reciente del ensamblado de personalización. La ubicación del manifiesto de implementación se almacena en una propiedad de documento personalizada denominada _AssemblyLocation. La cadena que identifica esta ubicación se inserta en la propiedad cuando se compila la solución.  
  
 El manifiesto de implementación apunta al manifiesto de aplicación, que a su vez apunta al ensamblado más actual. Para obtener más información, consulta [Application and Deployment Manifests in Office Solutions](../vsto/application-and-deployment-manifests-in-office-solutions.md).  
  
 En la ilustración siguiente se muestra la arquitectura básica de una personalización de nivel de documento.  
  
 ![Arquitectura de personalización de office 2007](../vsto/media/office07-custom.png "arquitectura de personalización de Office 2007")  
  
> [!NOTE]  
>  En soluciones de Office destinadas a [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)], las soluciones llaman al modelo de objetos de la aplicación host mediante la información de tipo de ensamblado de interoperabilidad primario (PIA) que está insertada en el ensamblado de la solución, en lugar de llamar directamente a los PIA. Para obtener más información, consulta [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
### <a name="loading-process"></a>Proceso de carga  
 Los pasos siguientes se producen cuando un usuario abre un documento que forma parte de una solución de Microsoft Office.  
  
1.  La aplicación de Microsoft Office comprueba las propiedades de documento personalizadas para ver si hay extensiones de código administrado asociadas con el documento. Para obtener más información, consulta [Custom Document Properties Overview](../vsto/custom-document-properties-overview.md).  
  
2.  Si hay extensiones de código administrado, la aplicación carga VSTOEE.dll, que a su vez carga VSTOLoader.dll. Se trata de DLL no administradas que son los componentes de carga para Visual Studio 2010 Tools para Office Runtime. Para obtener más información, consulta [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).  
  
3.  VSTOLoader.dll carga [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)] e inicia la parte administrada de [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)].  
  
4.  Si el documento se abre desde una ubicación distinta del equipo local, [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] comprueba que la ubicación del documento está en la lista **Ubicaciones de confianza** de la **Configuración del Centro de confianza** de esa aplicación de Office concreta. Si la ubicación del documento no está en una ubicación de confianza, la personalización no es de confianza y el proceso de carga se detiene ahí.  
  
5.  [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] instala la solución si aún no lo está, descarga los manifiestos de aplicación e implementación más recientes y realiza una serie de comprobaciones de seguridad. Para obtener más información, consulta [Securing Office Solutions](../vsto/securing-office-solutions.md).  
  
6.  Si se confía en la personalización para que se ejecute, [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] usa el manifiesto de implementación y el manifiesto de aplicación para comprobar si hay actualizaciones del ensamblado. Si está disponible una nueva versión del ensamblado, el runtime descarga la nueva versión del ensamblado en la memoria caché de [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] del equipo cliente. Para obtener más información, consulte [implementar una solución de Office](../vsto/deploying-an-office-solution.md).  
  
7.  [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] crea un nuevo dominio de aplicación en el que se cargará el ensamblado de personalización.  
  
8.  [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] carga el ensamblado de personalización en el dominio de aplicación.  
  
9. El [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] llamadas el **inicio** controlador de eventos en el ensamblado de personalización. Para obtener más información, vea [Events in Office Projects](../vsto/events-in-office-projects.md)  
  
## <a name="see-also"></a>Vea también  
 [Arquitectura de soluciones de Office en Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md)   
 [Arquitectura de complementos VSTO](../vsto/architecture-of-vsto-add-ins.md)   
 [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)   
 [Asegurar las soluciones de Office](../vsto/securing-office-solutions.md)   
 [Diseñar y crear soluciones de Office](../vsto/designing-and-creating-office-solutions.md)   
 [Información general sobre propiedades de documento personalizadas](../vsto/custom-document-properties-overview.md)   
 [Datos almacenados en caché en las personalizaciones de nivel de documento](../vsto/cached-data-in-document-level-customizations.md)  
  
  