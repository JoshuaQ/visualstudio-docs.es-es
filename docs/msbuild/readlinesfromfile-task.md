---
title: ReadLinesFromFile (Tarea) | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: http://schemas.microsoft.com/developer/msbuild/2003#ReadLinesFromFile
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, ReadLinesFromFile task
- ReadLinesFromFile task [MSBuild]
ms.assetid: a18af929-b53a-4d9e-b7bf-e3d3737ee85f
caps.latest.revision: "10"
author: kempb
ms.author: kempb
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 8db8c8414e4ce347ca8dbb59bec0f682911cf777
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="readlinesfromfile-task"></a>ReadLinesFromFile (Tarea)
Lee una lista de elementos de un archivo de texto.  
  
## <a name="parameters"></a>Parámetros  
 En la siguiente tabla se describen los parámetros de la tarea `ReadLinesFromFile` .  
  
|Parámetro|Description|  
|---------------|-----------------|  
|`File`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem> requerido.<br /><br /> Especifica el archivo que se va a leer. El archivo debe tener un elemento en cada línea.|  
|`Lines`|Parámetro de salida <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Contiene las líneas leídas del archivo.|  
  
## <a name="remarks"></a>Comentarios  
 Además de los parámetros mencionados anteriormente, esta tarea hereda los parámetros de la clase <xref:Microsoft.Build.Tasks.TaskExtension>, que a su vez hereda de la clase <xref:Microsoft.Build.Utilities.Task>. Para obtener una lista de estos parámetros adicionales y sus descripciones, vea [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se usa la tarea `ReadLinesFromFile` para crear elementos de una lista de un archivo de texto. Los elementos leídos del archivo se almacenan en la colección de elementos `ItemsFromFile`.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyTextFile Include="Items.txt"/>  
    </ItemGroup>  
  
    <Target Name="ReadFromFile">  
        <ReadLinesFromFile  
            File="@(MyTextFile)" >  
            <Output  
                TaskParameter="Lines"  
                ItemName="ItemsFromFile"/>  
        </ReadLinesFromFile>  
    </Target>  
  
</Project>  
```  
  
## <a name="see-also"></a>Vea también  
 [Referencia de tareas](../msbuild/msbuild-task-reference.md)   
 [Conceptos de MSBuild](../msbuild/msbuild-concepts.md)   
 [Tareas](../msbuild/msbuild-tasks.md)