---
title: "Cómo: personalizar una pestaña integrada | Documentos de Microsoft"
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- Ribbon [Office development in Visual Studio], tabs
- built-in tabs [Office development in Visual Studio]
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 251c1cf70ab1d528f65d558208f0f2d43e10388a
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-customize-a-built-in-tab"></a>Cómo: Personalizar una pestaña integrada
  Puede agregar grupos y controles a una pestaña integrada. Una pestaña integrada es una pestaña que ya existe en la cinta de una aplicación de Microsoft Office. Por ejemplo, el **datos** ficha es una pestaña integrada en Excel. Al crear un grupo personalizado, este aparece al final de la pestaña, pero puede colocarlo en la parte que quiera de la pestaña.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
> [!NOTE]  
>  Puede agregar grupos a una pestaña integrada, pero no puede quitar grupos integrados de una pestaña integrada.  
  
### <a name="to-add-groups-to-a-built-in-tab"></a>Para agregar grupos a una pestaña integrada  
  
1.  Haga clic en el archivo de código de la cinta de opciones en **el Explorador de soluciones**y, a continuación, haga clic en **Diseñador de vistas**.  
  
    > [!NOTE]  
    >  Si no aparece el archivo de código de la cinta de opciones en **el Explorador de soluciones**, debe agregar una **elemento cinta** al proyecto. Vea [Cómo: empezar a personalizar la cinta de opciones](../vsto/how-to-get-started-customizing-the-ribbon.md).  
  
2.  Haga clic en una pestaña en el Diseñador de la cinta de opciones y, a continuación, haga clic en **propiedades**.  
  
3.  En el **propiedades** ventana, expanda la **ControlId** propiedad y, a continuación, establezca el **ControlIdType** propiedad **Office**.  
  
4.  Establecer el **OfficeId** propiedad a la *Id. de control* de la ficha integrada que desea personalizar.  
  
     El identificador de control es el nombre que identifica de forma única a las fichas, grupos y controles que se integran en las aplicaciones de Microsoft Office.  
  
     Para obtener una lista de identificadores de control, vea [archivos de Ayuda de Office 2010: identificadores de Control en la interfaz de usuario de Office Fluent](http://go.microsoft.com/fwlink/?LinkID=181052).  
  
5.  Desde el **controles de la cinta de Office** pestaña de la **cuadro de herramientas**, arrastre los grupos a la ficha.  
  
    > [!NOTE]  
    >  Los grupos integrados no aparecen en el diseñador. Por lo tanto, la única manera de determinar si se está trabajando con una pestaña integrada es examinar el **ControlId** propiedad de la pestaña.  
  
### <a name="to-position-groups-on-a-built-in-tab"></a>Para colocar grupos en una pestaña integrada  
  
1.  En el diseñador de la cinta, seleccione un grupo personalizado.  
  
2.  En el **propiedades** ventana, expanda la **posición** propiedad.  
  
3.  Establecer el **PositionType** propiedad en el valor adecuado:  
  
    -   **BeforeOfficeId** coloca el grupo antes de un grupo integrado especificado.  
  
    -   **AfterOfficeId** coloca el grupo después de un grupo integrado especificado.  
  
4.  Establecer el **OfficeId** propiedad para el Id. de control de un grupo integrado.  
  
     Para obtener una lista de identificadores de control, vea [archivos de Ayuda de Office 2010: identificadores de Control en la interfaz de usuario de Office Fluent](http://go.microsoft.com/fwlink/?LinkID=181052).  
  
## <a name="see-also"></a>Vea también  
 [Información general de la cinta de opciones](../vsto/ribbon-overview.md)   
 [Diseñador de la cinta](../vsto/ribbon-designer.md)   
 [XML de la cinta de opciones](../vsto/ribbon-xml.md)   
 [Tutorial: Crear una pestaña personalizada usando el Diseñador de la cinta de opciones](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Tutorial: Crear una pestaña personalizada usando XML de la cinta de opciones](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)   
 [Cómo: empezar a personalizar la cinta de opciones](../vsto/how-to-get-started-customizing-the-ribbon.md)   
 [Cómo: cambiar la posición de una pestaña en la cinta de opciones](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)   
 [Cómo: agregar controles a la vista Backstage](../vsto/how-to-add-controls-to-the-backstage-view.md)   
 [Cómo: Mostrar errores de complementos de la interfaz de usuario](../vsto/how-to-show-add-in-user-interface-errors.md)  
  
  