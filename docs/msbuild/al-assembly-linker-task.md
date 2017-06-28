---
title: AL (Assembly Linker, Tarea) | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology:
- vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#AL
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- AL task [MSBuild]
- MSBuild, AL task
ms.assetid: 2ddefbf2-5662-4d55-99a6-ac383bf44560
caps.latest.revision: 22
author: kempb
ms.author: kempb
manager: ghogen
translation.priority.ht:
- cs-cz
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- pl-pl
- pt-br
- ru-ru
- tr-tr
- zh-cn
- zh-tw
translationtype: Human Translation
ms.sourcegitcommit: 79460291e91f0659df0a4241e17616e55187a0e2
ms.openlocfilehash: f3f7d61bf46f318249dd3b54caee27998d7fd105
ms.lasthandoff: 02/22/2017

---
# <a name="al-assembly-linker-task"></a>AL (Assembly Linker, Tarea)
La tarea AL contiene AL.exe, una herramienta que se distribuye con [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)]. La herramienta Assembly Linker se utiliza para crear un ensamblado con un manifiesto a partir de uno o varios archivos que pueden ser módulos o archivos de recursos. Los compiladores y los entornos de desarrollo pueden proporcionar estas capacidades, por lo que a menudo no hace falta utilizar esta tarea directamente. Assembly Linker resulta de más utilidad para los programadores que necesitan crear un único ensamblado a partir de varios archivos de componentes, como los que se pueden producir en desarrollos de lenguajes combinados. Esta tarea no combina los módulos en un único archivo de ensamblado; los módulos individuales deben distribuirse y estar disponibles para que el ensamblado resultante se cargue correctamente. Para obtener más información sobre AL.exe, vea [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).  
  
## <a name="parameters"></a>Parámetros  
 En la siguiente tabla se describen los parámetros de la tarea `AL`.  
  
|Parámetro|Descripción|  
|---------------|-----------------|  
|`AlgorithmID`|Parámetro `String` opcional.<br /><br /> Especifica un algoritmo que genera un valor hash para todos los archivos en un ensamblado de múltiples archivos, exceptuando el archivo que contiene el manifiesto del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/algid` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`BaseAddress`|Parámetro `String` opcional.<br /><br /> Especifica la dirección donde se cargará un archivo DLL en el equipo del usuario en tiempo de ejecución. Las aplicaciones se cargan con mayor rapidez si se especifica la dirección base de los archivos DLL, en lugar de dejar que el sistema operativo cambie la ubicación de los mismos en el espacio de procesos. Este parámetro corresponde a la opción /base[address] de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`CompanyName`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Company` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/comp[any]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Configuration`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Configuration` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/config[uration]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Copyright`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Copyright` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/copy[right]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Culture`|Parámetro `String` opcional.<br /><br /> Especifica la cadena de referencia cultural que se va a asociar al ensamblado. Para obtener más información, consulte la documentación sobre la opción `/c[ulture]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`DelaySign`|Parámetro `Boolean` opcional.<br /><br /> `true` para colocar solo la clave pública en el ensamblado; `false` para firmar completamente el ensamblado. Para obtener más información, consulte la documentación sobre la opción `/delay[sign]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Description`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Description` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/descr[iption]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`EmbedResources`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Inserta los recursos especificados en la imagen que contiene el manifiesto del ensamblado. Esta tarea copia el contenido del archivo de recursos en la imagen. Los elementos pasados a este parámetro pueden tener metadatos opcionales adjuntos a los mismos denominados `LogicalName` y `Access`. Los metadatos `LogicalName` se utilizan para especificar el identificador interno del recurso.  Los metadatos `Access` se pueden establecer en `private` para que el recurso no sea visible para otros ensamblados. Para obtener más información, consulte la documentación sobre la opción `/embed[resource]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`EvidenceFile`|Parámetro `String` opcional.<br /><br /> Inserta el archivo especificado en el ensamblado con el nombre de recurso `Security.Evidence`.<br /><br /> No se puede usar `Security.Evidence` para los recursos habituales. Este parámetro corresponde a la opción `/e[vidence]` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`ExitCode`|Parámetro de solo lectura de salida `Int32` opcional.<br /><br /> Especifica el código de salida proporcionado por el comando ejecutado.|  
|`FileVersion`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `File Version` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/fileversion` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Flags`|Parámetro `String` opcional.<br /><br /> Especifica un valor para el campo `Flags` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/flags` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`GenerateFullPaths`|Parámetro `Boolean` opcional.<br /><br /> Hace que la tarea use la ruta de acceso absoluta de los archivos que se enumeran en un mensaje de error. Este parámetro corresponde a la opción `/fullpaths` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`KeyContainer`|Parámetro `String` opcional.<br /><br /> Especifica un contenedor que contiene un par de claves. De este modo, el ensamblado se firmará (recibirá un nombre seguro) mediante la inserción de una clave pública en el manifiesto del ensamblado. La tarea firmará después el ensamblado final con la clave privada. Para obtener más información, consulte la documentación sobre la opción `/keyn[ame]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`KeyFile`|Parámetro `String` opcional.<br /><br /> Especifica un archivo que contiene un par de claves o simplemente una clave pública para firmar un ensamblado. El compilador inserta la clave pública en el manifiesto del ensamblado y firma después el ensamblado final con la clave privada. Para obtener más información, consulte la documentación sobre la opción `/keyf[ile]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`LinkResources`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Vincula los archivos de recursos especificados a un ensamblado. El recurso pasa a formar parte del ensamblado, pero el archivo no se copia. Los elementos pasados a este parámetro pueden tener metadatos opcionales adjuntos a los mismos denominados `LogicalName`, `Target` y `Access`. Los metadatos `LogicalName` se utilizan para especificar el identificador interno del recurso. Los metadatos `Target` pueden especificar el nombre de archivo y la ruta de acceso donde la tarea copia el archivo, tras lo cual compila este nuevo archivo en el ensamblado. Los metadatos `Access` se pueden establecer en `private` para que el recurso no sea visible para otros ensamblados. Para obtener más información, consulte la documentación sobre la opción `/link[resource]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`MainEntryPoint`|Parámetro `String` opcional.<br /><br /> Especifica el nombre completo (*class.method*) del método que se utilizará como punto de entrada al convertir un módulo en un archivo ejecutable. Este parámetro corresponde a la opción `/main` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`OutputAssembly`|Parámetro de salida <xref:Microsoft.Build.Framework.ITaskItem> requerido.<br /><br /> Especifica el nombre del archivo generado por esta tarea. Este parámetro corresponde a la opción `/out` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Platform`|Parámetro `String` opcional.<br /><br /> Limita en qué plataforma se puede ejecutar este código; debe ser `x86`, `Itanium`, `x64` o `anycpu`. De manera predeterminada, es `anycpu`. Este parámetro corresponde a la opción `/platform` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`ProductName`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Product` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/prod[uct]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`ProductVersion`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `ProductVersion` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/productv[ersion]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`ResponseFiles`|Parámetro `String[]` opcional.<br /><br /> Especifica los archivos de respuesta que contienen las opciones adicionales que deben pasarse a Assembly Linker.|  
|`SdkToolsPath`|Parámetro `String` opcional.<br /><br /> Especifica la ruta de acceso a las herramientas del SDK, tales como resgen.exe.|  
|`SourceModules`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Uno o varios módulos que se compilarán en un ensamblado. Los módulos aparecerán en una lista en el manifiesto del ensamblado resultante, y tendrán que distribuirse y estar disponibles para poder cargar el ensamblado. Los elementos que se pasan a este parámetro pueden tener metadatos adicionales denominados `Target`, que especifican la ruta y el nombre de archivo en el que la tarea copia el archivo, tras lo cual compilará este nuevo archivo en el ensamblado. Para obtener más información, consulte la documentación de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01). Este parámetro corresponde a la lista de módulos pasados a Al.exe sin un modificador concreto.|  
|`TargetType`|Parámetro `String` opcional.<br /><br /> Especifica el formato del archivo de salida: `library` (biblioteca de códigos), `exe` (aplicación de consola) o `win` (aplicación basada en Windows). De manera predeterminada, es `library`. Este parámetro corresponde a la opción `/t[arget]` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`TemplateFile`|Parámetro `String` opcional.<br /><br /> Especifica el ensamblado del que se heredarán todos los metadatos del ensamblado, salvo el campo correspondiente a la referencia cultural. El ensamblado especificado debe tener un nombre seguro.<br /><br /> El ensamblado creado con el parámetro `TemplateFile` será un ensamblado satélite. Este parámetro corresponde a la opción `/template` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Timeout`|Parámetro `Int32` opcional.<br /><br /> Especifica el tiempo en milisegundos después del cual se termina la tarea ejecutable. El valor predeterminado es `Int.MaxValue`, que indica que no hay período de tiempo de espera.|  
|`Title`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Title` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/title` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`ToolPath`|Parámetro `String` opcional.<br /><br /> Especifica la ubicación desde donde la tarea cargará el archivo ejecutable subyacente (Al.exe). Si no se especifica este parámetro, la tarea usa la ruta de instalación del SDK que se corresponde con la versión de la plataforma que está ejecutando [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)].|  
|`Trademark`|Parámetro `String` opcional.<br /><br /> Especifica una cadena para el campo `Trademark` del ensamblado. Para obtener más información, consulte la documentación sobre la opción `/trade[mark]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Version`|Parámetro `String` opcional.<br /><br /> Especifica la información de versión de este ensamblado. El formato de la cadena es *principal.secundaria.compilación.revisión*. El valor predeterminado es 0. Para obtener más información, consulte la documentación sobre la opción `/v[ersion]` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Win32Icon`|Parámetro `String` opcional.<br /><br /> Inserta un archivo .ico en el ensamblado. El archivo .ico proporciona al archivo de salida la apariencia deseada en el Explorador de archivos. Este parámetro corresponde a la opción `/win32icon` de [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
|`Win32Resource`|Parámetro `String` opcional.<br /><br /> Inserta un recurso de Win32 (archivo .res) en el archivo de salida. Para obtener más información, consulte la documentación sobre la opción `/win32res` en [Al.exe (Assembly Linker)](http://msdn.microsoft.com/Library/b5382965-0053-47cf-b92f-862860275a01).|  
  
## <a name="remarks"></a>Comentarios  
 Además de los parámetros mencionados anteriormente, esta tarea hereda los parámetros de la clase <xref:Microsoft.Build.Tasks.ToolTaskExtension>, que a su vez hereda de la clase <xref:Microsoft.Build.Utilities.ToolTask>. Para obtener una lista de estos parámetros adicionales y sus descripciones, consulte [ToolTaskExtension (Clase base)](../msbuild/tooltaskextension-base-class.md).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se crea un ensamblado con las opciones especificadas.  
  
```xml  
<AL  
    EmbedResources="@(EmbeddedResource)"  
    Culture="%(EmbeddedResource.Culture)"  
    TemplateFile="@(IntermediateAssembly)"  
    KeyContainer="$(KeyContainerName)"  
    KeyFile="$(KeyOriginatorFile)"  
    DelaySign="$(DelaySign)"  
  
    OutputAssembly=  
       "%(EmbeddedResource.Culture)\$(TargetName).resources.dll">  
  
    <Output TaskParameter="OutputAssembly"  
        ItemName="SatelliteAssemblies"/>  
</AL>  
```  
  
## <a name="see-also"></a>Vea también  
 [Referencia de tareas](../msbuild/msbuild-task-reference.md)   
 [Tareas](../msbuild/msbuild-tasks.md)