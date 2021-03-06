---
title: "Advertencia de conformidad con CLS CLS03411 | Microsoft Docs"
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
  - "CLS03411"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS03411"
ms.assetid: 79b0955a-5a86-46a8-90e9-4419c9068bbe
caps.latest.revision: 9
caps.handback.revision: 9
author: "corob-msft"
ms.author: "corob"
manager: "douge"
---
# Advertencia de conformidad con CLS CLS03411
CLS solo permite un subconjunto de codificaciones de atributos personalizados.  
  
 CLS solo permite un subconjunto de tipos como parámetros para el constructor de atributos personalizados, o como el tipo de miembros de datos de un atributo personalizado. Los únicos tipos que deben aparecer son:  
  
-   System.Type  
  
-   System.String  
  
-   System.Char  
  
-   System.Boolean  
  
-   System.Byte  
  
-   System.Int16  
  
-   System.Int32  
  
-   System.Int64  
  
-   System.Single  
  
-   System.Double  
  
-   los tipos de enumeración basados en un tipo entero base conforme a CLS.  
  
 Para más información sobre la comprobación de conformidad con Common Language Subset \(CLS\), vea [CLS Compliant Assemblies](http://msdn.microsoft.com/es-es/3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 El ejemplo siguiente genera la advertencia CLS03411:  
  
```  
// CLS03411.cpp // compile with: /clr /LD // CLS03411 expected using namespace System; using namespace System::Reflection; using namespace cli::language; [assembly:CLSCompliant (true)]; [assembly:AssemblyKeyFile("clscompliance.snk")]; // CLS03411 [AttributeUsage(AttributeTargets::All, AllowMultiple=true)] public ref class MyAttribute1 : public Attribute { public: MyAttribute1(Object^ parameter) {} }; // OK [AttributeUsage(AttributeTargets::All, AllowMultiple=true)] public ref class MyAttribute3 : public Attribute { public: MyAttribute3(Char parameter) {} };  
```