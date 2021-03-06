---
title: "Variante de tamaño de la ventanilla de 1 x 1 | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 3dbc3247-00f5-4644-8ff9-72e9febcf09a
caps.latest.revision: "6"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: ab9f8be1d202f21147afaf9f4f52a3c90c403ed8
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="1x1-viewport-size-variant"></a>1x1 Viewport (Variante de tamaño)
Reduce las dimensiones de la ventanilla de todos los objetivos de presentación a 1x1 píxeles.  
  
## <a name="interpretation"></a>Interpretación  
 Una ventanilla más pequeña reduce el número de píxeles que deben sombrearse, pero no reduce el número de vértices que deben procesarse. Establecer las dimensiones de la ventanilla a 1x1 píxeles elimina eficazmente el sombreado de píxeles de la aplicación.  
  
 Si esta variante muestra un gran aumento del rendimiento, puede indicar que la aplicación consume demasiada tasa de relleno. Esto puede indicar que la resolución que ha elegido es demasiado elevada para la plataforma de destino o que la aplicación invierte demasiado tiempo en sombrear píxeles que más adelante se sobrescriben (sobredibujan). Este resultado sugiere que disminuir el tamaño del búfer de fotogramas o reducir la cantidad de sobredibujo mejorará el rendimiento de la aplicación.  
  
## <a name="remarks"></a>Comentarios  
 Las dimensiones de la ventanilla se restablecen a 1x1 píxeles después de todas las llamadas a `ID3D11DeviceContext::OMSetRenderTargets` o `ID3D11DeviceContext::RSSetViewports`.  
  
## <a name="example"></a>Ejemplo  
 Esta variante se puede reproducir con código como el siguiente:  
  
```  
D3D11_VIEWPORT viewport;  
viewport.TopLeftX = 0;  
viewport.TopLeftY = 0;  
viewport.Width = 1;  
viewport.Height = 1;  
d3d_context->RSSetViewports(1, &viewport);  
```