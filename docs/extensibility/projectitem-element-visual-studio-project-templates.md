---
title: ProjectItem (elemento) (plantillas de proyecto de Visual Studio) | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: http://schemas.microsoft.com/developer/vstemplate/2005#ProjectItem
helpviewer_keywords:
- ProjectItem element [Visual Studio project templates]
- <ProjectItem> element [Visual Studio project templates]
ms.assetid: 82879fbe-7756-42cd-9a07-c10edf5b4673
caps.latest.revision: "18"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: ca5143a3e5eaff488fee89b643a40adb60473bd8
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="projectitem-element-visual-studio-project-templates"></a>ProjectItem (Elemento, Plantillas de proyecto de Visual Studio)
Especifica un archivo que se incluye en la plantilla de proyecto.  
  
> [!NOTE]
>  El `ProjectItem` elemento acepta atributos diferentes dependiendo de si la plantilla es para un proyecto o un elemento. Este tema se explica la `ProjectItem` elemento plantillas de proyecto. Para obtener una explicación de la `ProjectItem` el elemento para plantillas de elementos, vea [ProjectItem (elemento) (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md).  
  
 \<VSTemplate >  
 \<TemplateContent >  
 \<Project>  
 \<ProjectItem >  
  
## <a name="syntax"></a>Sintaxis  
  
```  
<ProjectItem  
    TargetFileName="TargetFileName.ext"  
    ReplaceParameters="true/false"  
    OpenInEditor="true/false"  
    OpenInWebBrowser="true/false"  
    OpenInHelpBrowser="true/false"  
    OpenOrder="Value">  
        FileName.ext  
</ProjectItem>  
```  
  
## <a name="attributes-and-elements"></a>Atributos y elementos  
 En las siguientes secciones se describen los atributos, los elementos secundarios y los elementos primarios.  
  
### <a name="attributes"></a>Atributos  
  
|Atributo|Descripción|  
|---------------|-----------------|  
|`TargetFileName`|Atributo opcional.<br /><br /> Especifica el nombre y la ruta de acceso del elemento de proyecto cuando se crea un proyecto de la plantilla. Este atributo es útil para crear una estructura de directorios diferente de la estructura de directorios en el archivo .zip de plantilla, o para usar el reemplazo de parámetros para crear un nombre de elemento.|  
|`ReplaceParameters`|Atributo opcional.<br /><br /> Un valor booleano que especifica si el elemento tiene valores de parámetro que se deben reemplazar cuando se crea un proyecto de la plantilla. El valor predeterminado es `false`.|  
|`OpenInEditor`|Atributo opcional.<br /><br /> Un valor booleano que especifica si el elemento se debe abrir en su editor correspondiente en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] cuando se crea un proyecto de la plantilla.<br /><br /> El `OpenInWebBrowser` y `OpenInHelpBrowser` se omiten los atributos en un elemento con un `OpenInEditor` valo `true`.<br /><br /> El valor predeterminado es `false`.|  
|`OpenInWebBrowser`|Atributo opcional.<br /><br /> Un valor booleano que especifica si el elemento se debe abrir el explorador Web cuando se crea un proyecto de la plantilla.<br /><br /> En el explorador Web, se pueden abrir sólo archivos HTML y archivos de texto que son locales para el proyecto. Direcciones URL externas no se puede abrir con este atributo.<br /><br /> El valor predeterminado es `false`.|  
|`OpenInHelpBrowser`|Atributo opcional.<br /><br /> Un valor booleano que especifica si el elemento se debe abrir en el Visor de ayuda cuando se crea un proyecto de la plantilla.<br /><br /> Solo los archivos HTML y archivos de texto que son locales para el proyecto se pueden abrir en el Explorador de ayuda. Direcciones URL externas no se puede abrir con este atributo.<br /><br /> El valor predeterminado es `false`.|  
|`OpenOrder`|Atributo opcional.<br /><br /> Especifica un valor numérico que representa el orden en que los elementos se abrirá en sus editores respectivos. Todos los valores deben ser múltiplos de 10. Elementos con mayor `OpenOrder` valores se abran en primer lugar.|  
  
### <a name="child-elements"></a>Elementos secundarios  
 Ninguno.  
  
### <a name="parent-elements"></a>Elementos primarios  
  
|Elemento|Descripción|  
|-------------|-----------------|  
|[Proyecto](../extensibility/project-element-visual-studio-templates.md)|Especifica los archivos o directorios que se agregarán al proyecto.|  
  
## <a name="text-value"></a>Valor de texto  
 Se requiere un valor de texto.  
  
 Un `string` que representa el nombre o la ruta de acceso a un archivo en el archivo .zip de plantilla.  
  
## <a name="remarks"></a>Comentarios  
 `ProjectItem`es un elemento secundario opcional de `Project`.  
  
 El `TargetFileName` atributo se puede usar para crear una estructura de directorios diferente de la estructura de directorios en el archivo .zip de plantilla. Por ejemplo, si el archivo `MyFile.vb` existe en la raíz del archivo .zip de plantilla, pero desea que el archivo se coloquen en un directorio denominado `CustomFiles` en todos los proyectos creados a partir de la plantilla, usaría el siguiente código XML:  
  
```  
<ProjectItem TargetFileName="CustomFiles\MyFile.vb">MyFile.vb</ProjectItem>  
```  
  
 El `TargetFileName` atributo también se puede usar para cambiar el nombre de los archivos que contienen caracteres internacionales en sus nombres de archivo. Por ejemplo, un archivo .zip de plantilla no puede contener nombres de archivo con caracteres Unicode, por lo que el archivo se debe cambiar el nombre antes de se puede comprimir en un archivo zip. El `TargetFileName` atributo se puede usar para establecer el nombre de archivo por el nombre de archivo Unicode original.  
  
 El `TargetFileName` atributo también se puede usar para cambiar el nombre de los archivos con parámetros. El siguiente procedimiento explica cómo cambiar el nombre del archivo `MyFile.vb`, que existe en el directorio raíz del archivo .zip de plantilla, para un nombre de archivo basado en el nombre del proyecto.  
  
### <a name="to-rename-files-with-parameters"></a>Para cambiar el nombre de los archivos con parámetros  
  
1.  Utilice el siguiente código XML en el archivo .vstemplate:  
  
    ```  
    <ProjectItem TargetFileName="$safeprojectname$.vb">MyFile.vb</ProjectItem>  
    ```  
  
2.  Abra el archivo de proyecto (.vbproj para un [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] proyecto) en un editor de texto o [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
3.  Busque la línea en el archivo de proyecto que tiene un aspecto similar al código XML siguiente:  
  
    ```  
    <Compile Include="MyFile.vb">  
    ```  
  
4.  Reemplace la línea de código por el siguiente código XML:  
  
    ```  
    <Compile Include="$safeprojectname$.vb">  
    ```  
  
     Cuando se crea un proyecto de esta plantilla, el nombre de archivo se basará en el nombre del usuario especificado en el **nuevo proyecto** cuadro de diálogo, todos los caracteres no seguros y quitados los espacios. Para obtener más información, consulte [parámetros de plantilla](../ide/template-parameters.md).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se muestra los metadatos de una plantilla de proyecto para una [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] aplicación.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic starter kit</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
    </TemplateData>  
    <TemplateContent>  
        <Project File="MyStarterKit.csproj">  
            <ProjectItem ReplaceParameters="true">Form1.cs<ProjectItem>  
            <ProjectItem>Form1.Designer.cs</ProjectItem>  
            <ProjectItem>Program.cs</ProjectItem>  
            <ProjectItem>Properties\AssemblyInfo.cs</ProjectItem>  
            <ProjectItem>Properties\Resources.resx</ProjectItem>  
            <ProjectItem>Properties\Resources.Designer.cs</ProjectItem>  
            <ProjectItem>Properties\Settings.settings</ProjectItem>  
            <ProjectItem>Properties\Settings.Designer.cs</ProjectItem>  
        </Project>  
    </TemplateContent>  
</VSTemplate>  
```  
  
## <a name="see-also"></a>Vea también  
 [Referencia de esquema de plantillas de Visual Studio](../extensibility/visual-studio-template-schema-reference.md)   
 [Crear plantillas para proyectos y elementos en Visual Studio](../ide/creating-project-and-item-templates.md)   
 [Parámetros de plantilla](../ide/template-parameters.md)   
 [ProjectItem (Elemento, Plantillas de elementos de Visual Studio)](../extensibility/projectitem-element-visual-studio-item-templates.md)