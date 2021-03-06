---
title: 'CA2003: No tratar fibras como subprocesos | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords:
- CA2003
- DoNotTreatFibersAsThreads
helpviewer_keywords:
- CA2003
- DoNotTreatFibersAsThreads
ms.assetid: 15398fb1-f384-4bcc-ad93-00e1c0fa9ddf
caps.latest.revision: "16"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 5afde6273a7730804746fe03446ea4c16c415302
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="ca2003-do-not-treat-fibers-as-threads"></a>CA2003: No tratar fibras como subprocesos
|||  
|-|-|  
|TypeName|DoNotTreatFibersAsThreads|  
|Identificador de comprobación|CA2003|  
|Categoría|Microsoft.Reliability|  
|Cambio problemático|Poco problemático|  
  
## <a name="cause"></a>Motivo  
 Un subproceso administrado se trata como un subproceso de Win32.  
  
## <a name="rule-description"></a>Descripción de la regla  
 No suponga que un subproceso administrado es un subproceso de Win32. Es una fibra. Common language runtime (CLR) ejecutará los subprocesos administrados como fibras en el contexto de los subprocesos reales que son propiedad de SQL. Estos subprocesos pueden compartirse entre los AppDomains e incluso las bases de datos en el proceso de SQL Server. Mediante administrado subproceso almacenamiento local funcionará, pero no se puede usar el almacenamiento local de subprocesos no administrados ni se supone que el código se ejecutará en el subproceso de sistema operativo actual de nuevo. No cambie la configuración como la configuración regional del subproceso. No llame a CreateCriticalSection ni a CreateMutex a través de P/Invoke porque requieren que el subproceso que entra en un bloqueo también salga del bloqueo. Dado que este no es el caso cuando se utilizan fibras, secciones críticas de Win32 y exclusiones mutuas será inútiles en SQL. Puede utilizar sin ningún riesgo la mayor parte del estado en mutuas. Esto incluye el almacenamiento local de subprocesos administrados y la referencia cultural actual (UI) de la interfaz de usuario del subproceso. Sin embargo, para los motivos de modelo de programación, no podrá cambiar la referencia cultural actual de un subproceso cuando se usa SQL; Esto se aplicará a través de un nuevo permiso.  
  
## <a name="how-to-fix-violations"></a>Cómo corregir infracciones  
 Examine el uso de subprocesos y cambiar el código en consecuencia.  
  
## <a name="when-to-suppress-warnings"></a>Cuándo suprimir advertencias  
 No se debe suprimir esta regla.