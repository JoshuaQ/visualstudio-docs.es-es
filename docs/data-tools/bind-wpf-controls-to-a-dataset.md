---
title: Enlazar controles WPF a un conjunto de datos | Documentos de Microsoft
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
- WPF, data binding in Visual Studio
- WPF data binding [Visual Studio], walkthroughs
- WPF Designer, data binding
ms.assetid: 177420b9-568b-4dad-9d16-1b0e98a24d71
caps.latest.revision: "32"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: 072adcf912e5921164647cf77ee561617f844786
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="bind-wpf-controls-to-a-dataset"></a>Enlazar controles WPF a un conjunto de datos
En este tutorial, se creará una aplicación de WPF que contiene controles enlazados a datos. Los controles se enlazan a registros de productos que se encapsulan en un conjunto de datos. También agregará botones para examinar los productos y guardar los cambios en los registros de productos.  
  
En este tutorial se muestran las tareas siguientes:  
  
- Crear una aplicación de WPF y un conjunto de datos que se genera a partir de los datos de la base de datos de ejemplo AdventureWorksLT.  
  
- Crear un conjunto de controles enlazados a datos arrastrando una tabla de datos de la **orígenes de datos** ventana a una ventana de WPF Designer.  
  
- Crear botones que naveguen hacia adelante y hacia atrás por los registros de productos.  
  
- Crear un botón que guarde los cambios que los usuarios realizan en los registros de productos en la tabla de datos y en el origen de datos subyacente.  
  
[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
## <a name="prerequisites"></a>Requisitos previos  
Necesita los componentes siguientes para completar este tutorial:  
  
-   [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]  
  
-   Acceder a una instancia en ejecución de SQL Server o SQL Server Express que tenga asociada la base de datos de ejemplo AdventureWorksLT. Puede descargar la base de datos AdventureWorksLT del [sitio Web de CodePlex](http://go.microsoft.com/fwlink/?linkid=87843).  
  
El conocimiento previo de los siguientes conceptos es útil, aunque no necesario, para completar el tutorial:  
  
-   objetos DataSet y TableAdapter. Para obtener más información, consulte [herramientas de conjunto de datos en Visual Studio](../data-tools/dataset-tools-in-visual-studio.md) y [TableAdapter](../data-tools/create-and-configure-tableadapters.md).  
  
-   Enlace a datos de WPF. Para obtener más información, consulte [Información general sobre el enlace de datos](/dotnet/framework/wpf/data/data-binding-overview).  
  
## <a name="create-the-project"></a>Crear el proyecto  
 Cree un nuevo proyecto de WPF. El proyecto mostrará registros de productos.  
  
#### <a name="to-create-the-project"></a>Para crear el proyecto  
  
1.  Inicie Visual Studio.  
  
2.  En el menú **Archivo** , elija **Nuevo**y haga clic en **Proyecto**.  
  
3.  Expanda **Visual Basic** o **Visual C#**y, a continuación, seleccione **Windows**.  
  
4.  Seleccione el **aplicación WPF** plantilla de proyecto.  
  
5.  En el **nombre** , escriba `AdventureWorksProductsEditor` y haga clic en **Aceptar**.  
  
     Visual Studio crea el `AdventureWorksProductsEditor` proyecto.  
  
## <a name="create-a-dataset-for-the-application"></a>Crear un conjunto de datos para la aplicación  
 Para poder crear controles enlazados a datos, debe definir un modelo de datos para la aplicación y agregarlo a la **orígenes de datos** ventana. En este tutorial, se crea un conjunto de datos que se usará como modelo de datos.  
  
#### <a name="to-create-a-dataset"></a>Para crear un conjunto de datos  
  
1.  En el menú **Datos** , haga clic en **Mostrar orígenes de datos**.  
  
     El **orígenes de datos** abre la ventana.  
  
2.  En la ventana **Orígenes de datos** , seleccione **Agregar nuevo origen de datos**.  
  
     El **configuración del origen de datos** abre el asistente.  
  
3.  En el **elegir un tipo de origen de datos** página, seleccione **base de datos**y, a continuación, haga clic en **siguiente**.  
  
4.  En el **elegir un modelo de base de datos** página, seleccione **conjunto de datos**y, a continuación, haga clic en **siguiente**.  
  
5.  En el **elegir la conexión de datos** página, seleccione una de las siguientes opciones:  
  
    -   Si una conexión de datos a la base de datos de ejemplo AdventureWorksLT está disponible en la lista desplegable, selecciónela y, a continuación, haga clic en **siguiente**.  
  
    -   Haga clic en **nueva conexión**y crear una conexión a la base de datos AdventureWorksLT.  
  
6.  En el **Guardar cadena de conexión en el archivo de aplicación configurar** página, seleccione la **Sí, guardar la conexión como** casilla de verificación y, a continuación, haga clic en **siguiente**.  
  
7.  En el **elija los objetos de base de datos** página, expanda **tablas**y, a continuación, seleccione la **Product (SalesLT)** tabla.  
  
8.  Haga clic en **Finalizar**.  
  
     Visual Studio agrega un nuevo `AdventureWorksLTDataSet.xsd` los archivos del proyecto y agrega su correspondiente **AdventureWorksLTDataSet** elemento a la **orígenes de datos** ventana. El `AdventureWorksLTDataSet.xsd` archivo define un conjunto de datos con tipo denominado `AdventureWorksLTDataSet` y un TableAdapter llamado `ProductTableAdapter`. Más adelante, en este tutorial, usará `ProductTableAdapter` para rellenar con datos el conjunto de datos y guardar los cambios de nuevo en la base de datos.  
  
9. Compile el proyecto.  
  
## <a name="edit-the-default-fill-method-of-the-tableadapter"></a>Editar el método de relleno predeterminado de TableAdapter  
 Para rellenar con datos el conjunto de datos, use el método `Fill` de `ProductTableAdapter`. De forma predeterminada, el método `Fill` rellena la tabla `ProductDataTable` del `AdventureWorksLTDataSet` con todas las filas de datos de la tabla Product. Puede modificar este método para que devuelva solo un subconjunto de las filas. Para este tutorial, modifique el método `Fill` para que devuelva solo las filas de productos que tengan fotos.  
  
#### <a name="to-load-product-rows-that-have-photos"></a>Para cargar filas de productos que tengan fotos  
  
1.  En **el Explorador de soluciones**, haga doble clic en el `AdventureWorksLTDataSet.xsd` archivo.  
  
     Se abre el diseñador de DataSet.  
  
2.  En el diseñador, haga clic en el **rellenar GetData()** de consulta y seleccione **configurar**.  
  
     El **configuración de TableAdapter** abre el asistente.  
  
3.  En el **escriba una instrucción SQL** página, agregue la siguiente cláusula WHERE después de la `SELECT` instrucción en el cuadro de texto.  
  
    ```  
    WHERE ThumbnailPhotoFileName <> 'no_image_available_small.gif'  
    ```  
  
4.  Haga clic en **Finalizar**.  
  
## <a name="define-the-user-interface"></a>Definir la interfaz de usuario  
 Agregue varios botones a la ventana modificando el código XAML en WPF Designer. Más adelante en este tutorial, agregará código que permite a los usuarios desplazarse por los registros de productos y guardar cambios usando estos botones.  
  
#### <a name="to-define-the-user-interface-of-the-window"></a>Para definir la interfaz de usuario de la ventana  
  
1.  En **el Explorador de soluciones**, haga doble clic en MainWindow.xaml.  
  
     La ventana se abre en WPF Designer.  
  
2.  En la vista [!INCLUDE[TLA#tla_titlexaml](../data-tools/includes/tlasharptla_titlexaml_md.md)] del diseñador, agregue el código siguiente entre las etiquetas `<Grid>`:  
  
    ```xaml  
    <Grid.RowDefinitions>  
        <RowDefinition Height="75" />  
        <RowDefinition Height="625" />  
    </Grid.RowDefinitions>  
    <Button HorizontalAlignment="Left" Margin="22,20,0,24" Name="backButton" Width="75"><</Button>  
    <Button HorizontalAlignment="Left" Margin="116,20,0,24" Name="nextButton" Width="75">></Button>  
    <Button HorizontalAlignment="Right" Margin="0,21,46,24" Name="saveButton" Width="110">Save changes</Button>  
    ```  
  
3.  Compile el proyecto.  
  
## <a name="create-data-bound-controls"></a>Crear controles enlazados a datos  
 Crear controles que muestren los registros de clientes, arrastrando el `Product` tabla desde el **orígenes de datos** ventana hasta WPF Designer.  
  
#### <a name="to-create-data-bound-controls"></a>Para crear controles enlazados a datos  
  
1.  En el **orígenes de datos** ventana, haga clic en el menú desplegable de la **producto** nodo y seleccione **detalles**.  
  
2.  Expanda el **producto** nodo.  
  
3.  En este ejemplo, algunos campos no se mostrarán, por lo que haga clic en el menú desplegable situado junto a los nodos siguientes y seleccione **ninguno**:  
  
    -   ProductCategoryID  
  
    -   ProductModelID  
  
    -   ThumbnailPhotoFileName  
  
    -   rowguid  
  
    -   ModifiedDate  
  
4.  Haga clic en el menú desplegable situado junto a la **ThumbNailPhoto** nodo y seleccione **imagen**.  
  
    > [!NOTE]
    >  De forma predeterminada, los elementos de la **orígenes de datos** ventana que representan imágenes tienen sus controles predeterminados establecidos en **ninguno**. Esto se debe a que las imágenes se almacenan como matrices de bytes en las bases de datos, y las matrices de bytes pueden contener desde una matriz de bytes simple al archivo ejecutable de una aplicación grande.  
  
5.  Desde el **orígenes de datos** ventana, arrastre la **producto** nodo a la fila de cuadrícula debajo de la fila que contiene los botones.  
  
     Visual Studio genera XAML que define un conjunto de controles que están enlazados a datos en el **productos** tabla. También genera el código que carga los datos. Para obtener más información sobre el XAML y el código generado, consulte [WPF enlazar controles a datos en Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md).  
  
6.  En el diseñador, haga clic en el cuadro de texto junto a la **Id. de producto** etiqueta.  
  
7.  En el **propiedades** ventana, seleccione la casilla situada junto a la **IsReadOnly** propiedad.  
  
## <a name="navigating-product-records"></a>Navegar por los registros de producto  
 Agregue código que permita a los usuarios desplazarse por registros de productos usando el  **\<**  y  **>**  botones.  
  
#### <a name="to-enable-users-to-navigate-product-records"></a>Para que los usuarios puedan navegar por los registros de productos  
  
1.  En el diseñador, haga doble clic en el  **<**  botón en la superficie de la ventana.  
  
     Visual Studio abre el archivo de código subyacente y crea un nuevo `backButton_Click` controlador de eventos para el <xref:System.Windows.Controls.Primitives.ButtonBase.Click> eventos.  
  
2.  Modificar el `Window_Loaded` controlador de eventos, por lo que la `ProductViewSource`, `AdventureWorksLTDataSet`, y `AdventureWorksLTDataSetProductTableAdapter` queden fuera del método y estén accesibles para todo el formulario. Señalarlos solo sea global al formulario y asígnelos dentro el `Window_Loaded` controlador de eventos similar al siguiente:  
  
     [!code-csharp[Data_WPFDATASET#1](../data-tools/codesnippet/CSharp/bind-wpf-controls-to-a-dataset_1.cs)]
     [!code-vb[Data_WPFDATASET#1](../data-tools/codesnippet/VisualBasic/bind-wpf-controls-to-a-dataset_1.vb)]  
  
3.  Agregue el código siguiente al controlador de eventos `backButton_Click`:  
  
     [!code-csharp[Data_WPFDATASET#2](../data-tools/codesnippet/CSharp/bind-wpf-controls-to-a-dataset_2.cs)]
     [!code-vb[Data_WPFDATASET#2](../data-tools/codesnippet/VisualBasic/bind-wpf-controls-to-a-dataset_2.vb)]  
  
4.  Volver al diseñador y haga doble clic en el  **>**  botón.  
  
5.  Agregue el código siguiente al controlador de eventos `nextButton_Click`:  
  
     [!code-csharp[Data_WPFDATASET#3](../data-tools/codesnippet/CSharp/bind-wpf-controls-to-a-dataset_3.cs)]
     [!code-vb[Data_WPFDATASET#3](../data-tools/codesnippet/VisualBasic/bind-wpf-controls-to-a-dataset_3.vb)]  
  
## <a name="save-changes-to-product-records"></a>Guardar los cambios en los registros de productos  
Agregue código que permita a los usuarios guardar cambios en los registros de producto mediante el uso de la **guardar cambios** botón.  
  
#### <a name="to-add-the-ability-to-save-changes-to-product-records"></a>Para agregar la posibilidad de guardar cambios en los registros de productos  
  
1.  En el diseñador, haga doble clic en el **guardar cambios** botón.  
  
     Visual Studio abre el archivo de código subyacente y crea un nuevo `saveButton_Click` controlador de eventos para el <xref:System.Windows.Controls.Primitives.ButtonBase.Click> eventos.  
  
2.  Agregue el código siguiente al controlador de eventos `saveButton_Click`:  
  
     [!code-csharp[Data_WPFDATASET#4](../data-tools/codesnippet/CSharp/bind-wpf-controls-to-a-dataset_4.cs)]
     [!code-vb[Data_WPFDATASET#4](../data-tools/codesnippet/VisualBasic/bind-wpf-controls-to-a-dataset_4.vb)]  
  
    > [!NOTE]
    >  En este ejemplo se usa el método `Save` de `TableAdapter` para guardar los cambios. Esto es apropiado en este tutorial, porque solo se está cambiando una tabla de datos. Si tiene que guardar cambios en varias tablas de datos, puede usar también el método `UpdateAll` de `TableAdapterManager` que Visual Studio genera con el conjunto de datos. Para obtener más información, consulte [TableAdapters](../data-tools/create-and-configure-tableadapters.md).  
  
## <a name="test-the-application"></a>Probar la aplicación  
 Compile y ejecute la aplicación. Compruebe que puede ver y actualizar los registros de productos.  
  
#### <a name="to-test-the-application"></a>Para probar la aplicación  
  
1.  Presione **F5**.  
  
     La aplicación se compila y se ejecuta. Compruebe lo siguiente:  
  
    -   Los cuadros de texto muestran datos del primer registro de producto que tiene una foto. Este producto tiene el identificador 713 del producto y el nombre **Long-Sleeve Logo Jersey, S**.  
  
    -   Puede hacer clic en el  **>**  o  **<**  botones para navegar por otros registros de productos.  
  
2.  En uno de los registros de productos, cambie el **tamaño** valor y, a continuación, haga clic en **guardar cambios**.  
  
3.  Cierre la aplicación y, a continuación, reinicie la aplicación presionando **F5** en Visual Studio.  
  
4.  Navegue al registro de producto que ha cambiado y compruebe que el cambio se conserva.  
  
5.  Cierre la aplicación.  
  
## <a name="next-steps"></a>Pasos siguientes  
 Una vez completado este tutorial, puede realizar las siguientes tareas relacionadas:  
  
-   Obtenga información acerca de cómo utilizar el **orígenes de datos** controla la ventana de Visual Studio para enlazar WPF a otros tipos de orígenes de datos. Para obtener más información, consulte [WPF enlazar controles a un servicio de datos WCF](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md).  
  
-   Obtenga información acerca de cómo utilizar el **orígenes de datos** ventana de Visual Studio para mostrar datos relacionados (es decir, los datos en una relación de elementos primarios y secundarios) en los controles WPF. Para obtener más información, consulte [Tutorial: mostrar datos relacionados en una aplicación WPF](../data-tools/display-related-data-in-wpf-applications.md).  
  
## <a name="see-also"></a>Vea también
[Enlazar controles WPF a datos en Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md)   
[Herramientas de conjuntos de datos en Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)   
[Información general sobre el enlace de datos](/dotnet/framework/wpf/data/data-binding-overview)