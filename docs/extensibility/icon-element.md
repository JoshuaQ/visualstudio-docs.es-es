---
title: Icon (elemento) | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- VSCT XML schema elements, Icon
- Icon element (VSCT XML schema)
ms.assetid: 73c58fe3-d53c-4f4e-b025-29567c6cbb7c
caps.latest.revision: "5"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 2787798afe9554601d44a965ae3f12d5ebeab8bb
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="icon-element"></a>Icon (elemento)
El atributo guid de la etiqueta de icono es el guid de un mapa de bits definido.  El atributo id, selecciona la ranura en la franja de mapa de bits. Este elemento es opcional.  Si este elemento se omite el valor de **guidOfficeIcon:msotcidNoIcon** se se implícito.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
<Icon guid="guidImages" id="bmpPic1" />  
```  
  
## <a name="attributes-and-elements"></a>Atributos y elementos  
 En las siguientes secciones se describen los atributos, los elementos secundarios y los elementos primarios.  
  
### <a name="attributes"></a>Atributos  
  
|Atributo|Descripción|  
|---------------|-----------------|  
|guid|Requerido. El guid de un mapa de bits definido.|  
|id|Requerido. Selecciona la ranura en la franja de mapa de bits.|  
  
### <a name="child-elements"></a>Elementos secundarios  
  
|Elemento|Descripción|  
|-------------|-----------------|  
|Ninguno.|Ninguno.|  
  
### <a name="parent-elements"></a>Elementos primarios  
  
|Elemento|Descripción|  
|-------------|-----------------|  
|[Buttons (Elemento)](../extensibility/buttons-element.md)||  
  
## <a name="see-also"></a>Vea también  
 [Archivos de tabla de comandos de Visual Studio (.Vsct)](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)