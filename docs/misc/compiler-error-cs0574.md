---
title: "Error del compilador CS0574 | Microsoft Docs"
ms.custom: ""
ms.date: "10/29/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CS0574"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0574"
ms.assetid: 43684abe-982c-45ae-9d0b-4fe031671fc8
caps.latest.revision: 6
caps.handback.revision: 6
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
---
# Error del compilador CS0574
El nombre del destructor debe coincidir con el nombre de la clase  
  
 El nombre del destructor debe ser el nombre de clase precedido por una tilde \(~\).  
  
 El ejemplo siguiente genera la advertencia CS0574:  
  
```  
// CS0574.cs namespace x { public class iii { ~iiii()   // CS0574 { } public static void Main() { } } }  
```