---
title: "Advertencia de conformidad con CLS CLS02609 | Microsoft Docs"
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
  - "CLS02609"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS02609"
ms.assetid: ea1afa9a-03d2-4417-af14-68e3b03a858f
caps.latest.revision: 8
caps.handback.revision: 8
author: "corob-msft"
ms.author: "corob"
manager: "douge"
---
# Advertencia de conformidad con CLS CLS02609
Una propiedad y todos sus descriptores de acceso deben ser estáticos, virtuales o de instancia.  
  
 Una propiedad y sus descriptores de acceso no deberán diferir en sus calificadores static, virtual o instance.  
  
 Para más información sobre la comprobación de conformidad con CLS, vea [CLS Compliant Assemblies](http://msdn.microsoft.com/es-es/3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 El ejemplo siguiente genera la advertencia CLS02609:  
  
```  
// CLS02609.cpp // compile with: /clr /LD // CLS02609 expected using namespace System; using namespace System::Reflection; [assembly:CLSCompliant (true)]; [assembly:AssemblyKeyFile("clscompliance.snk")]; public ref class One { private: int InstanceMember; static int StaticMember; public: property int MyProperty1 {   // CLS02609 public: void set(int value) {} static int get() { return StaticMember; } } property int MyProperty2 {   // OK public: void set(int value) {} int get() { return StaticMember; } } };  
```