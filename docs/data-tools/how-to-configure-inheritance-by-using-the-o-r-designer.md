---
title: "Cómo: configurar la herencia mediante el diseñador O R | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: e594af12-e777-434a-bc08-7dd2dac84cdc
caps.latest.revision: "4"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: b53dec270481ca8aa6009b9ddd27bdcdfeae6037
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-configure-inheritance-by-using-the-or-designer"></a>Cómo: configurar la herencia utilizando Object Relational Designer
El [!INCLUDE[vs_ordesigner_long](../data-tools/includes/vs_ordesigner_long_md.md)] ([!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]) admite el concepto de la herencia de tabla única normalmente implementada en los sistemas relacionales. En la herencia de tabla única, hay una sola tabla de base de datos que contiene campos tanto para la información de elementos primarios como para la información de elementos secundarios. En el caso de datos relacionales, una columna discriminadora contiene el valor que determina la clase a la que pertenece un registro cualquiera.  
  
Por ejemplo, consideremos una tabla Persons que contiene todas las personas que trabajan en una compañía. Algunas personas son los empleados y otras son los directores. La tabla Persons contiene una columna denominada `EmployeeType` que tiene el valor 1 para los directores y el valor 2 para los empleados; ésta es la columna discriminadora. En este escenario, puede crear una subclase de empleados y rellenar la clase únicamente con los registros cuyo `EmployeeType` tiene el valor 2. Puede eliminar también columnas que no se aplican desde cada una de las clases.  
  
La creación de un modelo de objetos que use la herencia (y que corresponda a datos relacionales) puede resultar un poco confusa. En el procedimiento siguiente se describen los pasos necesarios para configurar la herencia con Object Relational Designer. Puede resultar difícil seguir estos pasos genéricos sin hacer referencia a una tabla y columnas ya existentes, por lo que se ha proporcionado un tutorial con datos. Para obtener instrucciones detalladas paso a paso para configurar la herencia mediante el uso de la [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)], consulte [Tutorial: crear clases de LINQ to SQL mediante el uso de la herencia de tabla única (Object Relational Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md).  
  
## <a name="to-create-inherited-data-classes"></a>Para crear clases de datos heredadas
  
1.  Abra la [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] agregando un **clases LINQ to SQL** elemento a un proyecto existente de Visual Basic o C#.  
  
2.  Arrastre la tabla que desee usar como clase base hasta el [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
3.  Arrastre una segunda copia de la tabla en la [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] y cambie su nombre. Ésta es la clase derivada o subclase.  
  
4.  Haga clic en **herencia** en el **Object Relational Designer** pestaña de la **cuadro de herramientas**y, a continuación, haga clic en la subclase (la tabla que se ha cambiado el nombre) y conectarse a la clase base.  
  
    > [!NOTE]
    >  Haga clic en el **herencia** de elemento en el **cuadro de herramientas** y suelte el botón del mouse, haga clic en la segunda copia de la clase que creó en el paso 3 y, a continuación, haga clic en la primera clase que creó en el paso 2. La flecha en la línea de herencia apuntará a la primera clase.  
  
5.  En cada clase, elimine las propiedades de objeto que no desee que aparezcan y que no se utilicen para asociaciones. Recibirá un error si intenta eliminar las propiedades de objeto que se utilicen para asociaciones: [la propiedad \<nombre de propiedad > no se puede eliminar porque participa en la asociación \<nombre de asociación >](../data-tools/the-property-property-name-cannot-be-deleted-because-it-is-participating-in-the-association-association-name.md).  
  
    > [!NOTE]
    >  Dado que una clase derivada hereda las propiedades definidas en su clase base, no se pueden definir las mismas columnas en cada clase. (Las columnas se implementan como propiedades.) Puede habilitar la creación de columnas en la clase derivada estableciendo el Modificador de herencia de la propiedad en la clase base. Para obtener más información, consulte [Fundamentos de la herencia (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics).  
  
6.  Seleccione la línea de herencia en el [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
7.  En el **propiedades** ventana, establezca el **propiedad Discriminator** al nombre de columna que se utiliza para distinguir los registros en las clases.  
  
8.  Establecer el **valor de discriminador de clase derivada** valor para la propiedad en la base de datos que designa el registro como tipo heredado. (Éste es el valor que está almacenado en la columna discriminadora y que se usa para designar la clase heredada).  
  
9. Establecer el **valor de discriminador de clase Base** en el valor que designa el registro como un tipo base. (Éste es el valor que está almacenado en la columna discriminadora y que se usa para designar la clase base).  
  
10. Si lo desea, también puede establecer el **predeterminado de herencia** propiedad para designar un tipo en una jerarquía de herencia que se usa cuando se carguen filas que no coincide con ningún código de herencia definido. En otras palabras, si un registro tiene un valor en su columna discriminadora que no coincide con el valor de la **valor de discriminador de clase derivada** o **valor de discriminador de clase Base** propiedades, el registro se cargará en el tipo designado como el **predeterminado de herencia**.  
  
## <a name="see-also"></a>Vea también
[LINQ to SQL herramientas en Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
[Tutorial: Crear clases LINQ to SQL (Object Relational Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)   
[Obtener acceso a los datos en Visual Studio](../data-tools/accessing-data-in-visual-studio.md)   
[LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)   
[Tutorial: Crear clases LINQ to SQL mediante la herencia de tabla única (Object Relational Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)   
[Fundamentos de la herencia (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics)  
[Herencia](/dotnet/csharp/programming-guide/classes-and-structs/inheritance)