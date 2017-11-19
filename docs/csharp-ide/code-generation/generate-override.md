---
title: "Generar una invalidación - generación de código (C#) | Documentos de Microsoft"
ms.custom: 
ms.date: 11/16/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-general
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: b3c8cfc4-7c1f-4606-970e-3f7651604bab
author: gewarren
ms.author: gewarren
manager: ghogen
ms.openlocfilehash: d2972cfe2ea4481ab8f5eab6284277615d1d64a8
ms.sourcegitcommit: f40311056ea0b4677efcca74a285dbb0ce0e7974
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 10/31/2017
---
# <a name="generate-an-override-in-c"></a>Generar una invalidación en C# #
**¿Qué:** le permite generar inmediatamente el código para un cualquier método que se puede invalidar en una clase base. 

**Cuándo:** que desea reemplazar un método de clase base y generar la firma automáticamente.  

**Por este motivo:** si escribes la firma del método usted mismo, sin embargo, esta característica generará automáticamente la firma. 

**Cómo:**

1. Tipo de la **invalidar** (palabra clave), seguido por un espacio, donde desea insertar una firma de método invalidado y aparecerá una lista desplegable de IntelliSense.

   ![Invalidar IntelliSense](media/override_intellisense.png)

1. Seleccione el método que le gustaría invalidar de la clase base, al hacer clic en él con el mouse o navegar a él con el teclado y presionar **ENTRAR**.

   >[!TIP]
   >* Use el icono de propiedades ![Icono de propiedad](media/override_property.png) para mostrar u ocultar propiedades en la lista.
   >* Utilice el icono de método ![Icono de propiedad](media/override_method.png) para mostrar u ocultar los métodos en la lista.

1. El método seleccionado o la propiedad se agrega a la clase como una invalidación, lista para implementarse.

   ![Invalidar los resultados](media/override_result.png)

## <a name="see-also"></a>Vea también  
[Code Generation (C#)](../code-generation-csharp.md) (Generación de código (C#))  