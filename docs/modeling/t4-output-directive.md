---
title: T4 Directiva de salida | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: d9e8a1f51d7b3ba131618d613255436c3127fa67
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="t4-output-directive"></a>Directiva de salida T4
En las plantillas de texto de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], la directiva `output` sirve para definir la extensión de nombre de archivo y codificación del archivo transformado.  
  
 Por ejemplo, si su [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] proyecto incluye un archivo de plantilla denominado **MyTemplate.tt** que contiene la siguiente directiva:  
  
 `<#@output extension=".cs"#>`  
  
 a continuación, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] generará un archivo denominado **MyTemplate.cs**  
  
 La directiva de `output` no es necesaria en una plantilla de texto en tiempo de ejecución (preprocesada), ya que, en su lugar, la aplicación obtiene la cadena generada llamando a `TextTransform()`. Para obtener más información, consulte [tiempo de ejecución de generación de texto con plantillas de texto T4](../modeling/run-time-text-generation-with-t4-text-templates.md).  
  
## <a name="using-the-output-directive"></a>Uso de la directiva de salida  
  
```  
<#@ output extension=".fileNameExtension" [encoding="encoding"] #>  
```  
  
 No debe haber más de una directiva de `output` en cada plantilla de texto.  
  
## <a name="extension-attribute"></a>atributo de extensión  
 Especifica la extensión de nombre del archivo de salida de texto generado.  
  
 El valor predeterminado es **. cs**  
  
 Ejemplos:  
 `<#@ output extension=".txt" #>`  
  
 `<#@ output extension=".htm" #>`  
  
 `<#@ output extension=".cs" #>`  
  
 `<#@ output extension=".vb" #>`  
  
 Valores aceptables:  
 Cualquier extensión de nombre de archivo válida.  
  
## <a name="encoding-attribute"></a>atributo de codificación  
 Especifica la codificación que se va a usar cuando el archivo de salida se genera. Por ejemplo:  
  
 `<#@ output encoding="utf-8"#>`  
  
 El valor predeterminado es la codificación que el archivo de plantilla de texto utiliza.  
  
 Valores aceptables:  
 `us-ascii`  
  
 `utf-16BE`  
  
 `utf-16`  
  
 `utf-8`  
  
 `utf-7`  
  
 `utf-32`  
  
 `0` (valor predeterminado del sistema)  
  
 Por lo general, se puede usar la cadena WebName o el número de CodePage de cualquiera de las codificaciones devueltas por <xref:System.Text.Encoding.GetEncodings%2A?displayProperty=fullName>.