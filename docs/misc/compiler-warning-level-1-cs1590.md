---
title: "Advertencia del compilador (nivel 1) CS1590 | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CS1590"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1590"
ms.assetid: 0d6e5594-d6a6-43bf-8aa8-a452fa5748df
caps.latest.revision: 7
caps.handback.revision: 7
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
---
# Advertencia del compilador (nivel 1) CS1590
Elemento de inclusión XML no válido \-\- Falta el atributo de archivo  
  
 Falta un atributo de ruta de acceso o de documento pasado a la etiqueta [\<include\>](../Topic/%3Cinclude%3E%20\(C%23%20Programming%20Guide\).md) o está incompleto.  
  
 El ejemplo siguiente genera la advertencia CS1590:  
  
```  
// CS1590.cs // compile with: /W:1 /doc:x.xml /// <include path='MyDocs/MyMembers[@name="test"]/*' />   // CS1590 // try the following line instead // /// <include file='x.doc' path='MyDocs/MyMembers[@name="test"]/*' /> class Test { public static void Main() { } }  
```