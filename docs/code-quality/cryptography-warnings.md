---
title: "Advertencias de criptografía | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: d96723ea-a293-488d-b9db-adb437e50cdd
caps.latest.revision: "7"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: 5270a9b2cb2801d80dc9a087821e73d6c54bfe1c
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="cryptography-warnings"></a>Advertencias de criptografía
Las advertencias de criptografía admiten bibliotecas y aplicaciones más seguras gracias al uso correcto de criptografía. Estas advertencias ayudan a evitar los errores de seguridad en su programa. Si deshabilita cualquier advertencia de este tipo, se debe indicar el motivo claramente en el código además de informar al responsable de seguridad designado a ese proyecto de desarrollo.  
  
|Regla|Descripción|  
|----------|-----------------|  
|[CA5350: Do Not Use Weak Cryptographic Algorithms (No use algoritmos criptográficos no seguros)](../code-quality/ca5350-do-not-use-weak-cryptographic-algorithms.md)|Las funciones hash y los algoritmos de cifrado débiles se usan hoy en día para numerosos propósitos, pero no se recomiendan para garantizar la confidencialidad o la integridad de los datos que se protegen.        Esta regla se desencadena cuando se encuentran los algoritmos TripleDES, SHA1 o RIPEMD160 en el código.|  
|[CA5351: Do Not Use Broken Cryptographic Algorithms (No use algoritmos criptográficos rotos)](../code-quality/ca5351-do-not-use-broken-cryptographic-algorithms.md)|Los algoritmos criptográficos rotos no se consideran seguros y debe desalentarse su uso. Esta regla se desencadena cuando encuentra el algoritmo hash MD5 o los algoritmos de cifrado DES o RC2 en el código.|