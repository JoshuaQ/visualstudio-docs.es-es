---
title: "No se puede heredar la interfaz &#39;&lt;interfacename1&gt;&#39; porque la interfaz &#39;&lt;interfacename2&gt;&#39; de la que hereda podr&#237;a ser id&#233;ntica a la interfaz &#39;&lt;interfacename3&gt;&#39; de la que la interfaz &#39;&lt;interfacename4&gt;&#39; hereda para algunos argumentos de tipo | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vbc32122"
  - "bc32122"
helpviewer_keywords: 
  - "BC32122"
ms.assetid: 64a66ec7-0f5f-4804-a92b-9a6279fdfd6d
caps.latest.revision: 5
caps.handback.revision: 5
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
---
# No se puede heredar la interfaz &#39;&lt;interfacename1&gt;&#39; porque la interfaz &#39;&lt;interfacename2&gt;&#39; de la que hereda podr&#237;a ser id&#233;ntica a la interfaz &#39;&lt;interfacename3&gt;&#39; de la que la interfaz &#39;&lt;interfacename4&gt;&#39; hereda para algunos argumentos de tipo
Una interfaz genérica hereda de dos o más interfaces genéricas, y ciertos valores de argumentos de tipo de dos de las herencias podrían estar en conflicto.  
  
 Las instrucciones siguientes pueden generar este error.  
  
```  
Public Interface interfaceA(Of u) End Interface Public Interface interfaceX(Of v) Inherits interfaceA(Of v) End Interface Public Interface interfaceY(Of w) Inherits interfaceA(Of w) End Interface Public Interface derivedInterface(Of t1, t2) Inherits interfaceX(Of t1), interfaceY(Of t2) End Interface  
```  
  
 Si `derivedInterface` se construye o se implementa con una especificación del mismo tipo para `t1` y `t2`, debe heredar dos versiones de `interfaceA` con argumentos de tipo idénticos. Esto produciría ambigüedad respecto a la versión a la que se debe acceder.  
  
 **Id. de error:** BC32122  
  
### Para corregir este error  
  
-   Cambie uno de los argumentos de tipo facilitados a la interfaz derivada para que no haya ningún conflicto.  
  
     O bien  
  
-   Quite de la instrucción `Inherits` una de las interfaces que producen el posible conflicto de herencia o de implementación.  
  
## Vea también  
 [NO ESTÁ EN LA COMPILACIÓN: Información general de las interfaces](http://msdn.microsoft.com/es-es/f96bb470-c1b8-4c73-89bc-6f536b798da1)   
 [Interface \(Instrucción\)](/dotnet/visual-basic/language-reference/statements/interface-statement)   
 [Fundamentos de la herencia](/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics)   
 [Inherits \(Instrucción\)](/dotnet/visual-basic/language-reference/statements/inherits-statement)   
 [Tipos genéricos en Visual Basic](/dotnet/visual-basic/programming-guide/language-features/data-types/generic-types)