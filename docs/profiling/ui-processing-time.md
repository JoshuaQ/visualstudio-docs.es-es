---
title: Tiempo de procesamiento de la interfaz de usuario | Microsoft Docs
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vs.cv.threads.timeline.uiprocessing
helpviewer_keywords: Concurrency Visualizer, UI Processing Time
ms.assetid: 0ddb05a3-8c6b-448b-8488-2751c1e5abcc
caps.latest.revision: "5"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 8171fa96848aa53fb151ed4d4701268308e4ad1c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ui-processing-time"></a>Tiempo de procesamiento de la interfaz de usuario
Estos segmentos de la escala de tiempo están asociados a tiempos de bloqueo que se clasifican como procesamiento de la interfaz de usuario. Esto implica que un subproceso está generando mensajes de Windows o realizando otro trabajo de la interfaz de usuario. Durante este tiempo, se ha bloqueado un subproceso en una API que el visualizador de simultaneidad está contando como procesamiento de la interfaz de usuario. Las API como `GetMessage()` y `MsgWaitForMultipleObjects()` se incluyen en este grupo.  
  
 Si no se identifica ninguna API de bloqueo predefinida, revise las pilas de llamadas y los informes de perfil para determinar las causas subyacentes del retraso.  
  
 La categoría de procesamiento de la interfaz de usuario es importante para entender la capacidad de respuesta de las aplicaciones de interfaz gráfica de usuario y es conveniente en aplicaciones que dependen de la capacidad de respuesta de la interfaz de usuario. Por ejemplo, si el subproceso de interfaz de usuario en una aplicación alcanza el 100 % de tiempo de procesamiento de la interfaz de usuario, probablemente tenga gran capacidad de respuesta. Sin embargo, si el subproceso de interfaz de usuario emplea tiempo considerable en otras categorías, busque las causas principales y considere la posibilidad de reducir las categorías que no sean de interfaz de usuario en ese subproceso.  
  
## <a name="see-also"></a>Vea también  
 [Vista de subprocesos](../profiling/threads-view-parallel-performance.md)