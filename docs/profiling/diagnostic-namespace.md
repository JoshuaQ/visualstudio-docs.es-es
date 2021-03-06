---
title: diagnostic (espacio de nombres) | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: cvmarkersobj/Concurrency::diagnostic
helpviewer_keywords: Concurrency::diagnostic namespace
ms.assetid: ad786b19-7c4c-46ee-bfb6-c4752b373a09
caps.latest.revision: "6"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 3fb9b831562e2d9e4ce7d686f49ac484d58f6804
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="diagnostic-namespace"></a>diagnostic (Espacio de nombres)
El espacio de nombres `diagnostics` proporciona funcionalidad para emitir los marcadores del visualizador de simultaneidad.  
  
## <a name="syntax"></a>Sintaxis  
  
```  
namespace diagnostic;  
```  
  
## <a name="members"></a>Miembros  
  
### <a name="classes"></a>Clases  
  
|nombre|Description|  
|----------|-----------------|  
|[Clase marker_series](../profiling/marker-series-class.md)|Representa un canal de la serie de eventos generados por un único proveedor.|  
|[Clase span](../profiling/span-class.md)|Define una fase de la aplicación.|  
  
### <a name="enumerations"></a>Enumeraciones  
  
|nombre|Description|  
|----------|-----------------|  
|[Enumeración marker_importance](../profiling/marker-importance-enumeration.md)|Representa el nivel de importancia de un marcador del visualizador de simultaneidad.|  
  
## <a name="requirements"></a>Requisitos  
 **Encabezado:** cvmarkersobj.h  
  
 **Espacio de nombres:** Concurrency  
  
## <a name="see-also"></a>Vea también  
 [Espacio de nombres de simultaneidad (visualizador de simultaneidad)](../profiling/concurrency-namespace-concurrency-visualizer.md)