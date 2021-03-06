---
title: "Utilizar módulos para incluir archivos en la solución | Documentos de Microsoft"
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
- SharePoint development in Visual Studio, deployment modules
- SharePoint development in Visual Studio, modules
- modules [SharePoint development in Visual Studio]
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: c7f0fff081215e1bf1a9e2c5320668f2c698b2e6
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="using-modules-to-include-files-in-the-solution"></a>Utilizar módulos para incluir archivos en la solución
  Puede haber ocasiones cuándo es conveniente para implementar los archivos en el servidor de SharePoint, independientemente de su tipo de archivo, como nuevas páginas maestras. Para ello, puede usar *módulos* (no se deben confundir con [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] los módulos de código). Los módulos son contenedores de archivos en una solución de SharePoint. Cuando se implementa la solución, los archivos del módulo se copian en las carpetas especificadas en el servidor de SharePoint.  
  
## <a name="module-items-and-elements"></a>Elementos y los elementos de módulo  
 Para crear un módulo, agregarlo a un proyecto eligiendo en la **Agregar nuevo elemento** cuadro de diálogo. A continuación, modifique un archivo Elements.xml para incluir los nombres de los archivos que desea implementar, dónde se encuentran en el sistema, y donde se deben copiar en el servidor de SharePoint.  
  
 Este es un ejemplo del archivo Elements.xml de un módulo:  
  
```  
<?xml version="1.0" encoding="utf-8"?>  
<Elements xmlns="http://schemas.microsoft.com/sharepoint/">  
    <Module Name="Module1">  
        <File Path="Module1\Sample.txt" Url="Module1/Sample.txt" />  
    </Module>  
</Elements>  
  
```  
  
 Acaba de crear módulos contienen los archivos predeterminados siguientes:  
  
|Nombre de archivo|Descripción|  
|---------------|-----------------|  
|Elements.xml|El archivo de definición para el módulo.|  
|Sample.txt|Un archivo de marcador de posición que actúa como un ejemplo de un archivo en el módulo.|  
  
 El archivo Elements.xml contiene los elementos siguientes:  
  
|Nombre del elemento|Descripción|  
|------------------|-----------------|  
|Elementos|Contiene todos los elementos definidos en el módulo.|  
|Module|El elemento de módulo tiene un único atributo, *nombre*, que especifica el nombre del módulo en el formato `<Module Name="Module1">`.<br /><br /> Tenga en cuenta que si cambia el nombre del módulo (o su *nombre de la carpeta* propiedad), debe actualizar manualmente el nombre en el elemento de módulo.<br /><br /> Si especifica un subdirectorio para los archivos en el elemento de módulo, [!INCLUDE[sharepointShort](../sharepoint/includes/sharepointshort-md.md)] (WSS) creará automáticamente una estructura de directorios correspondiente para ellos.|  
|Archivo|El elemento de archivo tiene dos parámetros, *ruta de acceso* y *Url*.<br /><br /> -Path: El nombre y la ubicación del archivo en la solución de SharePoint. El formato es, `Path="Module1\Sample.txt"`.<br /><br /> -Dirección Url: La ubicación donde se implementará el archivo en el servidor de SharePoint. El formato es, `Url="Module1/Sample.txt"`.<br /><br /> -Type: Un atributo opcional que tiene dos configuraciones: *GhostableInLibrary* y *Ghostable*. El formato es, `Type="GhostableInLibrary"`. Especificar *GhostableInLibrary* significa que el archivo se agregará a una biblioteca de documentos de SharePoint junto con un elemento de lista para acompañar el archivo cuando se agrega a la biblioteca. Especificar *Ghostable* hace que el archivo se agrega a SharePoint fuera de la biblioteca de documentos.|  
  
 Cada archivo que desee implementar requiere otro `<File>` entrada de elemento en Elements.xml.  
  
## <a name="see-also"></a>Vea también  
 [Cómo: incluir archivos mediante un módulo](../sharepoint/how-to-include-files-by-using-a-module.md)   
 [Cómo: proporcionar un archivo](http://go.microsoft.com/fwlink/?LinkID=144271)   
 [Desarrollar soluciones de SharePoint](../sharepoint/developing-sharepoint-solutions.md)   
 [Crear elementos Web para SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)   
 [Empaquetar e implementar soluciones de SharePoint](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)  
  
  