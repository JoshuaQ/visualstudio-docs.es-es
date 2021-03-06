---
title: 'CA2232: Puntos de entrada marcar Windows Forms con STAThread | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- MarkWindowsFormsEntryPointsWithStaThread
- CA2232
helpviewer_keywords:
- CA2232
- MarkWindowsFormsEntryPointsWithStaThread
ms.assetid: a3c95130-8e7f-4419-9fcd-b67d077e8efb
caps.latest.revision: "16"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: fe12ce5947a22414aaf07c59945fd667b106101f
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca2232-mark-windows-forms-entry-points-with-stathread"></a>CA2232: Marcar puntos de entrada de Windows Forms con STAThread
|||  
|-|-|  
|TypeName|MarkWindowsFormsEntryPointsWithStaThread|  
|Identificador de comprobación|CA2232|  
|Categoría|Microsoft.Usage|  
|Cambio problemático|No trascendental|  
  
## <a name="cause"></a>Motivo  
 Un ensamblado que hace referencia el <xref:System.Windows.Forms> espacio de nombres y su punto de entrada no está marcado con el <xref:System.STAThreadAttribute?displayProperty=fullName> atributo.  
  
## <a name="rule-description"></a>Descripción de la regla  
 <xref:System.STAThreadAttribute>indica que el modelo de la aplicación de subprocesos de COM es un contenedor uniproceso. Este atributo debe estar presente en el punto de entrada de cualquier aplicación que utilice Formularios Windows Forms; si se omite, los componentes de Windows podrían no funcionar correctamente. Si el atributo no está presente, la aplicación utiliza el modelo de apartamento multiproceso, que no es compatible con formularios Windows Forms.  
  
> [!NOTE]
>  [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]los proyectos que usan el marco de aplicación no es necesario marcar la **Main** método con STAThread. El [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] compilador lo hace automáticamente.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Para corregir una infracción de esta regla, agregue el <xref:System.STAThreadAttribute> atributo al punto de entrada. Si el <xref:System.MTAThreadAttribute?displayProperty=fullName> atributo está presente, elimínelo.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 Es seguro suprimir una advertencia de esta regla si está desarrollando para .NET Compact Framework, para que la <xref:System.STAThreadAttribute> atributo es necesario y no se admite.  
  
## <a name="example"></a>Ejemplo  
 Los ejemplos siguientes muestran el uso correcto de <xref:System.STAThreadAttribute>.  
  
 [!code-csharp[FxCop.Usage.StaThread#1](../code-quality/codesnippet/CSharp/ca2232-mark-windows-forms-entry-points-with-stathread_1.cs)]
 [!code-vb[FxCop.Usage.StaThread#1](../code-quality/codesnippet/VisualBasic/ca2232-mark-windows-forms-entry-points-with-stathread_1.vb)]