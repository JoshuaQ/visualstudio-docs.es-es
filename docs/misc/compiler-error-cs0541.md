---
title: "Error del compilador CS0541 | Microsoft Docs"
ms.custom: ""
ms.date: "11/17/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CS0541"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0541"
ms.assetid: ed812c07-24f7-43c6-9a44-553f27f6249d
caps.latest.revision: 7
caps.handback.revision: 7
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
---
# Error del compilador CS0541
'declaration': la declaración explícita de la interfaz solo se puede declarar en una clase o estructura  
  
 Una declaración explícita de la [interfaz](/dotnet/csharp/language-reference/keywords/interface) solo se puede declarar en una [clase](/dotnet/csharp/language-reference/keywords/class) o una [estructura](/dotnet/csharp/language-reference/keywords/struct).  
  
 El ejemplo siguiente genera la advertencia CS0541:  
  
```  
// CS0541.cs namespace x { interface IFace { void F(); } interface IFace2 : IFace { void IFace.F();   // CS0541 } }  
```