---
title: "XmlPeek (Tarea) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, XmlPeek (tarea)"
  - "XmlPeek (tarea) [MSBuild]"
ms.assetid: 19196031-a3bc-41b5-9c4a-f2572630e179
caps.latest.revision: 4
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
caps.handback.revision: 4
---
# XmlPeek (Tarea)
[!INCLUDE[vs2017banner](../code-quality/includes/vs2017banner.md)]

Devuelve valores según especifica una consulta XPath de un archivo XML.  
  
## Parámetros  
 En la siguiente tabla se describen los parámetros de la tarea `XmlPeek`.  
  
|Parámetro|Descripción|  
|---------------|-----------------|  
|`Namespaces`|Parámetro `String` opcional.<br /><br /> Especifica los espacios de nombres de los prefijos de consulta XPath.|  
|`Query`|Parámetro `String` opcional.<br /><br /> Especifica la consulta XPath.|  
|`Result`|Parámetro de salida <xref:Microsoft.Build.Framework.ITaskItem>`[]` opcional.<br /><br /> Contiene los resultados devueltos por esta tarea.|  
|`XmlContent`|Parámetro `String` opcional.<br /><br /> Especifica la entrada XML como una cadena.|  
|`XmlInputPath`|Parámetro <xref:Microsoft.Build.Framework.ITaskItem> opcional.<br /><br /> Especifica la entrada XML como una ruta de archivo.|  
  
## Comentarios  
 Además de tener los parámetros que se enumeran en la tabla, esta tarea hereda los parámetros de la clase <xref:Microsoft.Build.Tasks.TaskExtension>, que hereda de la clase <xref:Microsoft.Build.Utilities.Task>.  Para obtener una lista de estos parámetros adicionales y sus descripciones, vea [TaskExtension \(Clase base\)](../msbuild/taskextension-base-class.md).  
  
## Vea también  
 [Tareas](../msbuild/msbuild-tasks.md)   
 [Referencia de tareas](../msbuild/msbuild-task-reference.md)