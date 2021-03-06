---
title: Elemento ItemMetadata (MSBuild) | Microsoft Docs
ms.custom: 
ms.date: 03/13/2017
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- ItemMetadata Element [MSBuild]
- <ItemMetadata> Element [MSBuild]
ms.assetid: e3db5122-202d-43a9-b2f4-3e0ec4ed3d08
caps.latest.revision: "17"
author: kempb
ms.author: kempb
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 72c6b65991eb90d71856b33398ff2b42f6fcb377
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="itemmetadata-element-msbuild"></a>Elemento ItemMetadata (MSBuild)
Contiene una clave de metadatos de elemento definida por el usuario que incluye el valor de metadatos del elemento. Un elemento puede tener cualquier número de pares clave-valor de metadatos.  

 \<Project>  
 \<ItemGroup>  
 \<Item>  

## <a name="syntax"></a>Sintaxis  

```  
<ItemMetadataName> Item Metadata value</ItemMetadataName>  
```  

## <a name="attributes-and-elements"></a>Atributos y elementos  
 En las siguientes secciones se describen los atributos, los elementos secundarios y los elementos primarios.  

### <a name="attributes"></a>Atributos  

|Atributo|Description|  
|---------------|-----------------|  
|`Condition`|Atributo opcional.<br /><br /> Condición que se va a evaluar. Para obtener más información, consulte [Condiciones](../msbuild/msbuild-conditions.md).|  

### <a name="child-elements"></a>Elementos secundarios  
 Ninguno.  

### <a name="parent-elements"></a>Elementos primarios  

|Elemento|Description|  
|-------------|-----------------|  
|[Item](../msbuild/item-element-msbuild.md)|Un elemento definido por el usuario que define las entradas para el proceso de compilación.|  

## <a name="text-value"></a>Valor de texto  
 El valor de texto es opcional.  

 Este texto especifica el valor de metadatos del elemento, que puede ser texto o XML.  

## <a name="remarks"></a>Comentarios  

## <a name="example"></a>Ejemplo  
 En el ejemplo de código siguiente se muestra cómo agregar los metadatos `Culture` con el valor `fr` al elemento `CSFile`.  

```xml  
<ItemGroup>  
    <CSFile Include="main.cs" >  
        <Culture>fr</Culture>  
    </CSFile>  
</ItemGroup>  
```  

## <a name="see-also"></a>Vea también  
 [Referencia de esquemas de archivo del proyecto](../msbuild/msbuild-project-file-schema-reference.md)   
 [Elementos](../msbuild/msbuild-items.md)
