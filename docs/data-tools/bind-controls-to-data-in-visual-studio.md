---
title: Enlazar controles a datos en Visual Studio | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- data, displaying
- data sources, displaying data
- Data Sources window
- dislaying data
ms.assetid: be8b6623-86a6-493e-ab7a-050de4661fd6
caps.latest.revision: "40"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: d6a1ab26dc402d039a5e858896ec25668be8df9e
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="bind-controls-to-data-in-visual-studio"></a>Enlazar controles a datos en Visual Studio
Para mostrar los datos a los usuarios de la aplicación, puede enlazarlos a controles. Puede crear estos controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana hasta una superficie de diseño o controles en una superficie en Visual Studio.  
  
 En este tema se describen los orígenes de datos que puede utilizar para crear controles enlazados a datos. También se describen algunas de las tareas generales implicadas en el enlace de datos. Para obtener información más específica sobre cómo crear controles enlazados a datos, vea [enlazar controles formularios Windows Forms a datos en Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md) y [WPF enlazar controles a datos en Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md).  
  
## <a name="data-sources"></a>Orígenes de datos  
 En el contexto de enlace de datos, un origen de datos representa los datos en memoria que se puede enlazar a la interfaz de usuario. En términos prácticos, un origen de datos puede ser una clase de Entity Framework, un conjunto de datos, un extremo de servicio que se encapsula en un objeto de proxy. NET, una clase de LINQ to SQL, o cualquier objeto .NET o colección. Algunos orígenes de datos le permiten crear controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana, mientras que otros orígenes de datos no. En la tabla siguiente se muestran los orígenes de datos que se admiten.  
  
|Origen de datos|Compatibilidad con arrastrar y colocar en **el Diseñador de Windows Forms**|Compatibilidad con arrastrar y colocar en **WPF Designer**|Compatibilidad con arrastrar y colocar en **el Diseñador de Silverlight**|  
|-----------------|---------------------------------------------------------------|-----------------------------------------------------|-------------------------------------------------------------|  
|Conjunto de datos|Sí|Sí|No|  
|Entity Data Model|Sí<sup>1</sup>|Sí|Sí|  
|Clases LINQ to SQL|Ya no<sup>2</sup>|Ya no<sup>2</sup>|Ya no<sup>2</sup>|  
|Servicios (incluidos [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)], WCF services y los servicios web)|Sí|Sí|Sí|  
|Object|Sí|Sí|Sí|  
|SharePoint|Sí|Sí|Sí|  
  
 1. Generar el modelo con el **Entity Data Model** asistente, a continuación, arrastrar esos objetos al diseñador.  
  
 2. Clases LINQ to SQL no aparecen en la **orígenes de datos** ventana. Sin embargo, puede agregar un nuevo origen de datos de objeto basado en clases LINQ to SQL y, a continuación, arrastrar esos objetos al diseñador para crear los controles enlazados a datos. Para obtener más información, consulte [Tutorial: crear clases de LINQ to SQL (Object Relational Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md).  
  
## <a name="data-sources-window"></a>Ventana de orígenes de datos  
 Orígenes de datos están disponibles para su proyecto como elementos en el **orígenes de datos** ventana. Esta ventana está visible o accesible desde el **vista** menú, cuando una superficie de diseño del formulario es la ventana activa en el proyecto. También puede arrastrar elementos desde esta ventana para crear controles que están enlazados a los datos subyacentes y también puede configurar los orígenes de datos con el botón secundario.  
  
 ![Ventana Orígenes de datos](../data-tools/media/raddata-data-sources-window.png "raddata ventana de orígenes de datos")  
  
 Para cada tipo de datos que aparece en el **orígenes de datos** ventana, se crea un control predeterminado al arrastrar el elemento hasta el diseñador. Antes de arrastrar un elemento de la **orígenes de datos** ventana, puede cambiar el control que se va a crear. Para obtener más información, consulte [establecer el control que se creará al arrastrar desde la ventana de orígenes de datos](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).  
  
## <a name="tasks-involved-in-binding-controls-to-data"></a>Tareas necesarias para enlazar controles a datos  
 En la tabla siguiente se enumera algunas de las tareas más comunes que realizar para enlazar controles a datos.  
  
|Tarea|Más información|  
|----------|----------------------|  
|Abra la **orígenes de datos** ventana.|Abra una superficie de diseño en el editor y elija **vista** > **orígenes de datos**.|  
|Agregar un origen de datos al proyecto.|[Agregar nuevos orígenes de datos](../data-tools/add-new-data-sources.md)|  
|Establecer el control que se crea cuando se arrastra un elemento de la **orígenes de datos** ventana hasta el diseñador.|[Establecer el control que se creará al arrastrar desde la ventana Orígenes de datos](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)|  
|Modificar la lista de controles que están asociados a elementos en el **orígenes de datos** ventana.|[Agregar controles personalizados a la ventana Orígenes de datos](../data-tools/add-custom-controls-to-the-data-sources-window.md)|  
|Crear controles enlazados a datos.|[Enlazar controles de Windows Forms a datos en Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)<br /><br /> [Enlace de controles de WPF a datos en Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md)|  
|Enlazar a un objeto o colección.|[Enlazar objetos en Visual Studio](../data-tools/bind-objects-in-visual-studio.md)|  
|Filtrar los datos que aparecen en la interfaz de usuario.|[Filtrar y ordenar los datos en una aplicación Windows Forms](../data-tools/filter-and-sort-data-in-a-windows-forms-application.md)|  
|Personalizar títulos para los controles.|[Personalizar el modo en que Visual Studio crea los títulos de controles enlazados a datos](../data-tools/customize-how-visual-studio-creates-captions-for-data-bound-controls.md)|  
  
## <a name="see-also"></a>Vea también  
 [Visual Studio Data Tools para .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)   
 [Enlace de datos en Windows Forms](/dotnet/framework/winforms/windows-forms-data-binding)