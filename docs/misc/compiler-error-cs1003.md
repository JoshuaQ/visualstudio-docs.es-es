---
title: "Error del compilador CS1003 | Microsoft Docs"
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
  - "CS1003"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1003"
ms.assetid: 59f4d053-13c0-4f79-830e-263acdbe94fa
caps.latest.revision: 6
caps.handback.revision: 6
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
---
# Error del compilador CS1003
Error de sintaxis, se esperaba 'carácter'  
  
 El compilador genera este error para varias condiciones de error. Revise el código para encontrar el error de sintaxis.  
  
 El ejemplo siguiente genera la advertencia CS1003:  
  
```  
// CS1003.cs public class b { public static void Main() { int[] a; a[);   // CS1003 } }  
```