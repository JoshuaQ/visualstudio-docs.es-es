---
title: Crear un control de usuario que admite el enlace de datos simple | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- custom controls [Visual Studio], Data Sources Window
- Data Sources Window, controls
ms.assetid: b1488366-6dfb-454e-9751-f42fd3f3ddfb
caps.latest.revision: "14"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: 63df502f17a5c85e51e658854d2ab7dec312fcc5
ms.sourcegitcommit: 49aa031cbebdd9c7ec070c713afb1a97d1ecb701
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/23/2018
---
# <a name="create-a-windows-forms-user-control-that-supports-simple-data-binding"></a>Crear un control de usuario de formularios Windows Forms que admita el enlace de datos simple
Para mostrar datos en formularios de aplicaciones de Windows, puede elegir controles existentes en el **cuadro de herramientas**, o puede crear controles personalizados si la aplicación requiere funcionalidad que no está disponible en los controles estándar. En este tutorial se muestra cómo crear un control que implementa <xref:System.ComponentModel.DefaultBindingPropertyAttribute>. Los controles que implementan <xref:System.ComponentModel.DefaultBindingPropertyAttribute> pueden contener una propiedad que se puede enlazar a datos. Tales controles son similares a <xref:System.Windows.Forms.TextBox> o <xref:System.Windows.Forms.CheckBox>.  
  
 Para obtener más información sobre la creación de control, vea [desarrollar controles de Windows Forms en tiempo de diseño](/dotnet/framework/winforms/controls/developing-windows-forms-controls-at-design-time).  
  
 Al crear controles para su uso en escenarios de enlace de datos, debe implementar uno de los atributos de enlace de datos siguientes:  
  
|Uso de atributos de enlace de datos|  
|-----------------------------------|  
|Implemente el <xref:System.ComponentModel.DefaultBindingPropertyAttribute> en controles sencillos, como un <xref:System.Windows.Forms.TextBox>, que muestra una única columna (o propiedad) de datos. (Este proceso se describe en esta página del tutorial.)|  
|Implemente el <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> en controles, como <xref:System.Windows.Forms.DataGridView>, que muestra listas (o tablas) de datos. Para obtener más información, consulte [crear un control de usuario de formularios Windows Forms que admita el enlace de datos complejo](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md).|  
|Implemente el <xref:System.ComponentModel.LookupBindingPropertiesAttribute> en controles, como <xref:System.Windows.Forms.ComboBox>, que muestren listas (o tablas) de datos, pero que también necesiten presentar una única columna o propiedad. Para obtener más información, consulte [crear un control de usuario de formularios Windows Forms que admita el enlace de datos de búsqueda](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).|  
  
 En este tutorial se crea un control simple que muestra los datos de una sola columna en una tabla. En este ejemplo se usa la columna `Phone` de la tabla `Customers` de la base de datos de ejemplo Northwind. El control de usuario simple mostrará los números de teléfono de los clientes en un formato de número de teléfono estándar, mediante el uso de un <xref:System.Windows.Forms.MaskedTextBox> y estableciendo la máscara en un número de teléfono.  
  
 Durante este tutorial aprenderá a:  
  
-   Crear un nuevo **aplicación de Windows Forms**.  
  
-   Agregue un nuevo **Control de usuario** al proyecto.  
  
-   Diseñe visualmente el control de usuario.  
  
-   Implemente el atributo `DefaultBindingProperty`.  
  
-   Crear un conjunto de datos con la **configuración del origen de datos** asistente.  
  
-   Establecer el **teléfono** columna en el **orígenes de datos** ventana para utilizar el nuevo control.  
  
-   Cree un formulario para mostrar los datos en el nuevo control.  
  
## <a name="prerequisites"></a>Requisitos previos  
Este tutorial usa SQL Server Express LocalDB y la base de datos de ejemplo Northwind.  
  
1.  Si no tiene SQL Server Express LocalDB, puede instalarlo desde el [página de descarga de SQL Server Express](https://www.microsoft.com/sql-server/sql-server-editions-express), o a través del **instalador de Visual Studio**. El instalador de Visual Studio, se puede instalar SQL Server Express LocalDB como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo, o como un componente individual.  
  
2.  Instalar la base de datos de ejemplo Northwind, siga estos pasos:  

    1. En Visual Studio, abra el **Explorador de objetos de SQL Server** ventana. (Explorador de objetos de SQL Server se instala como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo en el instalador de Visual Studio.) Expanda el **SQL Server** nodo. Haga doble clic en la instancia de LocalDB y seleccione **nueva consulta...** .  

       Se abre una ventana del editor de consultas.  

    2. Copia la [script Transact-SQL de Northwind](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) en el Portapapeles. Este script de T-SQL crea la base de datos Northwind desde el principio y lo rellena con datos.  

    3. Pegue el script de T-SQL en el editor de consultas y, a continuación, elija la **Execute** botón.  

       Después de unos minutos, finaliza la ejecución de la consulta y se crea la base de datos Northwind.  
  
## <a name="create-a-windows-forms-application"></a>Crear una aplicación de Windows Forms  
 El primer paso es crear un **aplicación de Windows Forms**.  
  
#### <a name="to-create-the-new-windows-project"></a>Para crear el nuevo proyecto de Windows  
  
1. En Visual Studio, en el **archivo** menú, seleccione **New**, **proyecto...** .  
  
2. Expanda **Visual C#** o **Visual Basic** en el panel izquierdo, seleccione **escritorio clásico de Windows**.  

3. En el panel central, seleccione la **aplicación de Windows Forms** tipo de proyecto.  

4. Denomine el proyecto **Tutorialdecontrolsimple**y, a continuación, elija **Aceptar**. 
  
     El **Tutorialdecontrolsimple** proyecto se crea y se agrega a **el Explorador de soluciones**.  
  
## <a name="add-a-user-control-to-the-project"></a>Agregue un control de usuario al proyecto  
 Este tutorial crea un control simple enlazable a datos de un **Control de usuario**, por lo que agregar una **Control de usuario** elemento a la **Tutorialdecontrolsimple** proyecto.  
  
#### <a name="to-add-a-user-control-to-the-project"></a>Para agregar un control de usuario al proyecto  
  
1.  Desde el **proyecto** menú, elija **agregar Control de usuario**.  
  
2.  Tipo de `PhoneNumberBox` en el área nombre y haga clic en **agregar**.  
  
     El **PhoneNumberBox** se agrega al control **el Explorador de soluciones**y se abre en el diseñador.  
  
## <a name="design-the-phonenumberbox-control"></a>Diseñar el control PhoneNumberBox  
 Este tutorial se basa en el <xref:System.Windows.Forms.MaskedTextBox> existente y lo amplía para crear el control `PhoneNumberBox`.  
  
#### <a name="to-design-the-phonenumberbox-control"></a>Para diseñar el control PhoneNumberBox  
  
1.  Arrastre un <xref:System.Windows.Forms.MaskedTextBox> desde el **cuadro de herramientas** en la superficie de diseño del control de usuario.  
  
2.  Seleccione la etiqueta inteligente en el <xref:System.Windows.Forms.MaskedTextBox> acaba de arrastrar y elija **establecer máscara**.  
  
3.  Seleccione **número de teléfono** en el **máscara de entrada** cuadro de diálogo y haga clic en **Aceptar** para establecer la máscara.  
  
## <a name="add-the-required-data-binding-attribute"></a>Agregue el atributo de enlace de datos requerido  
 En el caso de los controles simples que admiten enlaces de datos, implemente el <xref:System.ComponentModel.DefaultBindingPropertyAttribute>.  
  
#### <a name="to-implement-the-defaultbindingproperty-attribute"></a>Para implementar el atributo DefaultBindingProperty  
  
1.  Cambie el control `PhoneNumberBox` a la vista de código. (En el **vista** menú, elija **código**.)  
  
2.  Reemplace el código de `PhoneNumberBox` por lo siguiente:  
  
     [!code-csharp[VbRaddataDisplaying#3](../data-tools/codesnippet/CSharp/create-a-windows-forms-user-control-that-supports-simple-data-binding_1.cs)]
     [!code-vb[VbRaddataDisplaying#3](../data-tools/codesnippet/VisualBasic/create-a-windows-forms-user-control-that-supports-simple-data-binding_1.vb)]  
  
3.  En el menú **Compilar** , elija **Compilar solución**.  
  
## <a name="create-a-data-source-from-your-database"></a>Crear un origen de datos de la base de datos  
 Este paso se utiliza el **configuración del origen de datos**Asistente para crear un origen de datos en función de la `Customers` tabla en la base de datos de ejemplo Northwind. Debe tener acceso a la base de datos de ejemplo Northwind para crear la conexión. Para obtener información sobre cómo configurar la base de datos de ejemplo Northwind, vea [Cómo: instalar bases de datos de ejemplo](../data-tools/installing-database-systems-tools-and-samples.md).  
  
#### <a name="to-create-the-data-source"></a>Para crear el origen de datos  
  
1.  En el menú **Datos** , haga clic en **Mostrar orígenes de datos**.  
  
2.  En el **orígenes de datos** ventana, seleccione **Agregar nuevo origen de datos** para iniciar el **configuración del origen de datos** asistente.  
  
3.  En el **elegir un tipo de origen de datos** página, seleccione **base de datos**y, a continuación, haga clic en **siguiente**.  
  
4.  En el **elegir la conexión de datos** página, realice una de las siguientes acciones:  
  
    -   Si una conexión de datos a la base de datos de ejemplo Northwind está disponible en la lista desplegable, selecciónela.  
  
    -   Seleccione **nueva conexión** para iniciar el **agregar o modificar conexión** cuadro de diálogo.  
  
5.  Si la base de datos requiere una contraseña, seleccione la opción para incluir datos confidenciales y, a continuación, haga clic en **siguiente**.  
  
6.  En el **Guardar cadena de conexión en el archivo de configuración de la aplicación** página, haga clic en **siguiente**.  
  
7.  En el **elija los objetos de base de datos** página, expanda la **tablas** nodo.  
  
8.  Seleccione el `Customers` de tabla y, a continuación, haga clic en **finalizar**.  
  
     El **NorthwindDataSet** se agrega al proyecto y el `Customers` tabla aparece en la **orígenes de datos** ventana.  
  
## <a name="set-the-phone-column-to-use-the-phonenumberbox-control"></a>Establezca la columna phone para utilizar el control PhoneNumberBox  
 En el **orígenes de datos** ventana, puede establecer el control que se creará antes de arrastrar elementos a un formulario.  
  
#### <a name="to-set-the-phone-column-to-bind-to-the-phonenumberbox-control"></a>Para establecer la columna Phone para enlazarse al control PhoneNumberBox  
  
1.  Abra **Form1** en el diseñador.  
  
2.  Expanda el **clientes** nodo en el **orígenes de datos** ventana.  
  
3.  Haga clic en la flecha de lista desplegable en el **clientes** nodo y elija **detalles** desde la lista de control.  
  
4.  Haga clic en la flecha de lista desplegable en el **teléfono** columna y elija **personalizar**.  
  
5.  Seleccione el **PhoneNumberBox** en la lista de **controles asociados** en el **opciones de personalización de interfaz de usuario de datos** cuadro de diálogo.  
  
6.  Haga clic en la flecha de lista desplegable en el **teléfono** columna y elija **PhoneNumberBox**.  
  
## <a name="add-controls-to-the-form"></a>Agregar controles al formulario  
 Puede crear los controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana hasta el formulario.  
  
#### <a name="to-create-data-bound-controls-on-the-form"></a>Para crear controles enlazados en el formulario  
  
-   Arrastre los principales **clientes** nodo desde el **orígenes de datos** ventana en el formulario y compruebe que la `PhoneNumberBox` control se usa para mostrar los datos en la `Phone` columna.  
  
     Los controles enlazados a datos con etiquetas descriptivas aparecen en el formulario, junto con una barra de herramientas (<xref:System.Windows.Forms.BindingNavigator>) para navegar por los registros. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, y <xref:System.Windows.Forms.BindingNavigator> aparecen en la Bandeja de componentes.  
  
## <a name="run-the-application"></a>Ejecutar la aplicación  
  
#### <a name="to-run-the-application"></a>Para ejecutar la aplicación  
  
-   Presione F5 para ejecutar la aplicación.  
  
## <a name="next-steps"></a>Pasos siguientes  
 Según cuáles sean los requisitos de la aplicación, hay varios pasos que se pueden realizar después de crear un control que admite el enlace a datos. Entre los pasos más habituales están los siguientes:  
  
-   Colocar los controles personalizados en una biblioteca de controles para poder reutilizarlos en otras aplicaciones.  
  
-   Crear controles que admitan escenarios de enlace a datos más complejos. Para obtener más información, consulte [crear un control de usuario de formularios Windows Forms que admita el enlace de datos complejo](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md) y [crear un control de usuario de formularios Windows Forms que admita el enlace de datos de búsqueda](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).  
  
## <a name="see-also"></a>Vea también  
 [Enlazar controles de Windows Forms a datos en Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Establecer el control que se creará al arrastrar desde la ventana Orígenes de datos](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)
