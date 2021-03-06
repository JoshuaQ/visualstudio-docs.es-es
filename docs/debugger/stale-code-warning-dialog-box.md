---
title: "Cuadro de diálogo de advertencia de código, es decir obsoleto | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: vs.debug.ENC.stalecode
dev_langs:
- CSharp
- VB
- FSharp
- C++
helpviewer_keywords:
- Stale Code Warning dialog box
- code, stale code warning
- warnings, Stale Code Warning dialog box
- Edit and Continue, stale code
ms.assetid: 594b894c-e652-4e13-a980-9909473d5712
caps.latest.revision: "13"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 77fbbd558e424103b8d6ecc69e3724c9011365c1
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="stale-code-warning-dialog-box"></a>Advertencia de código obsoleto (cuadro de diálogo)
Este cuadro de diálogo aparece cuando han realizado cambios a código nativo el código que **editar y continuar** no pudo aplicar inmediatamente. Por tanto, parte del código nativo en el marco de pila actual no está actualizado, es decir, que está obsoleto. Para obtener más información, consulte [Cómo: trabajar con código obsoleto](http://msdn.microsoft.com/en-us/c7536e95-66a6-44a0-995d-3fe5035250b4).  
  
 **No volver a mostrar este cuadro de diálogo**  
 Si activa esta casilla, la función Editar y continuar aplicará los cambios en el código sin pedir permiso en el futuro. Puede activar esta advertencia nuevo, vaya a la **opciones** cuadro de diálogo, abra el **depuración** carpeta, haga clic en el **editar y continuar** página y seleccionar **Avisar cuando haya código obsoleto**.  
  
## <a name="see-also"></a>Vea también  
 [Cambios admitidos en el código (C++)](../debugger/supported-code-changes-cpp.md)   
 [Editar y continuar, depuración, cuadro de diálogo Opciones](http://msdn.microsoft.com/Library/009d225f-ef65-463f-a146-e4c518f86103)