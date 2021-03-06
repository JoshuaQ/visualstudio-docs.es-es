---
title: Plantillas predeterminadas XSLT | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 773dd34e-67d3-4997-8df9-b71e7f880d88
caps.latest.revision: "2"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 4fe1bf4dda6bed505f0892a18825e93f66e13e16
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="xslt-default-templates"></a>Plantillas predeterminadas XSLT
Se usa una plantilla predeterminada durante el procesamiento XSLT si no hay ninguna regla de plantilla explícita coincidente en la hoja de estilos. La plantilla predeterminada, también denominada regla de plantilla integrada, se define en la sección 5.8 de la recomendación W3C XSLT 1.0. La plantilla predeterminada permite que el procesador XSLT procese un nodo, aunque no haya ninguna regla de plantilla explícita que coincida. Sin embargo, como la regla de plantilla integrada no está explícitamente definida en la hoja de estilos, puede conducir a unos resultados de transformación XSLT inesperados o confusos.  
  
 El depurador XSLT ahora muestra el código de las plantillas predeterminadas XSLT. Cuando se ejecuta paso a paso una transformación XSLT, si se usa una plantilla predeterminada, el depurador muestra la plantilla predeterminada en una ventana. Esto permite analizar el código de la plantilla predeterminada y establecer puntos de interrupción en las instrucciones.  
  
## <a name="see-also"></a>Vea también  
 [Depuración de XSLT](../xml-tools/debugging-xslt.md)