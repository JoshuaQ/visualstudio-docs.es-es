---
title: GetAssemblyIdentity (Tarea) | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: http://schemas.microsoft.com/developer/msbuild/2003#GetAssemblyIdentity
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, GetAssemblyIdentity task
- GetAssemblyIdentity task [MSBuild]
ms.assetid: a977e072-37ad-4941-84a6-32a4483be55d
caps.latest.revision: "8"
author: kempb
ms.author: kempb
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 962217f4093b871a4256b1e7dff8853615a1527d
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="getassemblyidentity-task"></a>GetAssemblyIdentity (Tarea)
Recupera las identidades de ensamblado de los archivos especificados y genera la información de identidad.  
  
## <a name="task-parameters"></a>Parámetros de tareas  
 En la siguiente tabla se describen los parámetros de la tarea `GetAssemblyIdentity`.  
  
|Parámetro|Description|  
|---------------|-----------------|  
|`Assemblies`|Parámetro de salida <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Contiene las identidades de ensamblado recuperadas.|  
|`AssemblyFiles`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem>`[]` requerido.<br /><br /> Especifica los archivos de los que se recuperarán las identidades.|  
  
## <a name="remarks"></a>Comentarios  
 Los elementos generados por el parámetro `Assemblies` contienen entradas de metadatos de elementos denominadas `Version`, `PublicKeyToken` y `Culture`.  
  
 Además de los parámetros mencionados anteriormente, esta tarea hereda los parámetros de la clase <xref:Microsoft.Build.Tasks.TaskExtension>, que a su vez hereda de la clase <xref:Microsoft.Build.Utilities.Task>. Para obtener una lista de estos parámetros adicionales y sus descripciones, vea [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se recupera la identidad de los archivos especificados en el elemento `MyAssemblies` y se generan en el elemento `MyAssemblyIdentities`.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyAssemblies Include="File1.dll;File2.dll" />  
    </ItemGroup>  
  
    <Target Name="RetrieveIdentities>  
        <GetAssemblyIdentity  
            AssemblyFiles="@(MyAssemblies)"  
            <Output  
                TaskParameter="Assemblies"  
                ItemName="MyAssemblyIdentities"  
    </Target>  
  
</Project>  
```  
  
## <a name="see-also"></a>Vea también  
 [Tareas](../msbuild/msbuild-tasks.md)   
 [Referencia de tareas](../msbuild/msbuild-task-reference.md)