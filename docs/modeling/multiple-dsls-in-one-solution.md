---
title: "Varios lenguajes DSL en una única solución | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: f3c024fc6be841f5329f133ece35ed0ef7517eb3
ms.sourcegitcommit: f89ed5fc2e5078213e30a6ade4604e34df48181f
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/13/2018
---
# <a name="multiple-dsls-in-one-solution"></a>Varios DSL en una solución
Puede empaquetar varios DSL como parte de una única solución para que se instalen juntos.  
  
 Puede usar varias técnicas para integrar varios DSL. Para obtener más información, consulte [integrar modelos mediante Modelbus de Visual Studio](../modeling/integrating-models-by-using-visual-studio-modelbus.md) y [Cómo: agregar un controlador de arrastrar y colocar](../modeling/how-to-add-a-drag-and-drop-handler.md) y [personalizar el comportamiento de copia](../modeling/customizing-copy-behavior.md).  
  
### <a name="to-build-more-than-one-dsl-in-the-same-solution"></a>Para compilar más de un DSL en la misma solución  
  
1.  Cree dos o más soluciones de DSL y un proyecto de VSIX, y agregue todos los proyectos a una única solución.  
  
    -   Para crear un nuevo proyecto VSIX: en el **nuevo proyecto** cuadro de diálogo, seleccione **Visual C#**, **extensibilidad**, **proyecto VSIX**.  
  
    -   Cree dos o más soluciones de DSL en el directorio de soluciones VSIX.  
  
         Por cada DSL, abra una nueva instancia de Visual Studio. Cree el nuevo DSL y especifique la misma carpeta de solución que la solución de VSIX.  
  
         Asegúrese de crear cada DSL con una extensión de nombre de archivo diferente.  
  
    -   Cambiar los nombres de los **Dsl** y **DslPackage** proyectos para que sean distintos. Por ejemplo: `Dsl1`, `DslPackage1`, `Dsl2`, `DslPackage2`.  
  
    -   En cada uno de ellos **DslPackage\*\source.extension.tt**, actualice esta línea con el nombre de proyecto de Dsl correcto:  
  
         `string dslProjectName = "Dsl2";`  
  
    -   En la solución VSIX, agregue el ADSL * y DslPackage\* proyectos.  
  
         Quizás quiera coloca cada par en su propia carpeta de solución.  
  
2.  Combine los manifiestos VSIX de los DSL:  
  
    1.  Abra * YourVsixProject ***\source.extension.manifest**.  
  
    2.  Para cada ADSL, elija **agregar contenido** y agregue:  
  
        -   `Dsl*`un proyecto como un **componente MEF**  
  
        -   `DslPackage*`un proyecto como un **componente MEF**  
  
        -   `DslPackage*`un proyecto como un **VS Package**  
  
3.  Compile la solución.  
  
 El VSIX resultante instalará ambos DSL. Puede probar a ellos mediante F5 o implementar * YourVsixProject ***\bin\Debug\\\*.vsix**.  
  
## <a name="see-also"></a>Vea también  
 [Integrar modelos utilizando Modelbus de Visual Studio](../modeling/integrating-models-by-using-visual-studio-modelbus.md)   
 [Cómo: agregar un controlador de arrastrar y colocar](../modeling/how-to-add-a-drag-and-drop-handler.md)   
 [Personalizar comportamiento de copia](../modeling/customizing-copy-behavior.md)