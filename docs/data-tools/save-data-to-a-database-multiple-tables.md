---
title: Guardar datos en una base de datos (varias tablas) | Documentos de Microsoft
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
- updating datasets, walkthroughs
- data [Visual Studio], saving
- saving data, walkthroughs
- data [Visual Studio], updating
ms.assetid: 7ebe03da-ce8c-4cbc-bac0-a2fde4ae4d07
caps.latest.revision: "24"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: e3841a0052081700be899576e1adc0a0740fecec
ms.sourcegitcommit: 49aa031cbebdd9c7ec070c713afb1a97d1ecb701
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/23/2018
---
# <a name="save-data-to-a-database-multiple-tables"></a>Guardar datos en una base de datos (varias tablas)
Uno de los escenarios más comunes en el desarrollo de aplicaciones consiste en mostrar los datos en un formulario de una aplicación Windows, editar los datos y devolverlos actualizados a la base de datos. Este tutorial crea un formulario en el que aparecen datos de dos tablas relacionadas y muestra cómo editar los registros y volver a guardar los cambios en la base de datos. En este ejemplo se utilizan las tablas `Customers` y `Orders` de la base de datos de ejemplo Northwind.  
  
 Puede guardar los datos de su aplicación en la base de datos llamando al método `Update` de un TableAdapter. Al arrastrar las tablas de la **orígenes de datos** ventana en un formulario, el código que se necesita para guardar los datos se agrega automáticamente. Cualquier tabla adicional que se agrega a un formulario requiere la adición manual de este código. Este tutorial muestra cómo agregar código para guardar las actualizaciones de varias tablas.  
  
> [!NOTE]
>  Los cuadros de diálogo y comandos de menú que se ven pueden diferir de los descritos en la Ayuda, dependiendo de la configuración activa o la edición que esté usando. Para cambiar la configuración, elija la opción **Importar y exportar configuraciones** del menú **Herramientas** . Para más información, vea [Personalizar el IDE de Visual Studio](../ide/personalizing-the-visual-studio-ide.md).  
  
 Las tareas ilustradas en este tutorial incluyen:  
  
-   Crear un nuevo **aplicación de Windows Forms** proyecto.  
  
-   Crear y configurar un origen de datos en la aplicación con el [Asistente para configuración de orígenes de datos](../data-tools/media/data-source-configuration-wizard.png).  
  
-   Establecer los controles de los elementos de la [ventana Orígenes de datos](add-new-data-sources.md). Para obtener más información, consulte [establecer el control que se creará al arrastrar desde la ventana de orígenes de datos](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).  
  
-   Crear controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana hasta el formulario.  
  
-   Modificación de algunos registros de cada tabla en el conjunto de datos.  
  
-   Modificar el código para devolver los datos actualizados del conjunto de datos a la base de datos.  
  
## <a name="prerequisites"></a>Requisitos previos  
Este tutorial usa SQL Server Express LocalDB y la base de datos de ejemplo Northwind.  
  
1.  Si no tiene SQL Server Express LocalDB, puede instalarlo desde el [página de descarga de SQL Server Express](https://www.microsoft.com/sql-server/sql-server-editions-express), o a través del **instalador de Visual Studio**. El instalador de Visual Studio, se puede instalar SQL Server Express LocalDB como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo, o como un componente individual.  
  
2.  Instalar la base de datos de ejemplo Northwind, siga estos pasos:  

    1. En Visual Studio, abra el **Explorador de objetos de SQL Server** ventana. (Explorador de objetos de SQL Server se instala como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo en el instalador de Visual Studio.) Expanda el **SQL Server** nodo. Haga doble clic en la instancia de LocalDB y seleccione **nueva consulta...** .  

       Se abre una ventana del editor de consultas.  

    2. Copia la [script Transact-SQL de Northwind](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) en el Portapapeles. Este script de T-SQL crea la base de datos Northwind desde el principio y lo rellena con datos.  

    3. Pegue el script de T-SQL en el editor de consultas y, a continuación, elija la **Execute** botón.  

       Después de unos minutos, finaliza la ejecución de la consulta y se crea la base de datos Northwind.  
  
## <a name="create-the-windows-forms-application"></a>Crear la aplicación de formularios Windows Forms  
 El primer paso es crear un **aplicación de Windows Forms**. Asignar un nombre al proyecto es opcional en este paso, pero se le asignará un nombre dado que podrá guardar el proyecto más adelante.  
  
#### <a name="to-create-the-new-windows-forms-application-project"></a>Para crear el nuevo proyecto de aplicación de Windows forms  
  
1. En Visual Studio, en el **archivo** menú, seleccione **New**, **proyecto...** .  
  
2. Expanda **Visual C#** o **Visual Basic** en el panel izquierdo, seleccione **escritorio clásico de Windows**.  

3. En el panel central, seleccione la **aplicación de Windows Forms** tipo de proyecto.  

4. Denomine el proyecto **UpdateMultipleTablesWalkthrough**y, a continuación, elija **Aceptar**. 
  
     El **UpdateMultipleTablesWalkthrough** se crea y se agrega al proyecto **el Explorador de soluciones**.  
  
## <a name="create-the-data-source"></a>Crear el origen de datos  
 Este paso crea un origen de datos de la base de datos Northwind utilizando el **Asistente para configuración de orígenes de datos**. Debe tener acceso a la base de datos de ejemplo Northwind para crear la conexión. Para obtener información acerca de cómo configurar la base de datos de ejemplo Northwind, vea [Cómo: instalar bases de datos de ejemplo](../data-tools/installing-database-systems-tools-and-samples.md).  
  
#### <a name="to-create-the-data-source"></a>Para crear el origen de datos  
  
1.  En el **datos** menú, seleccione **Mostrar orígenes de datos**.  
  
2.  En el **orígenes de datos** ventana, seleccione**Agregar nuevo origen de datos** para iniciar el **Asistente para configuración de orígenes de datos**.  
  
3.  En el **elegir un tipo de origen de datos** pantalla, seleccione **base de datos**y, a continuación, seleccione **siguiente**.  
  
4.  En el **elegir la conexión de datos** realice pantalla uno de los siguientes:  
  
    -   Si una conexión de datos a la base de datos de ejemplo Northwind está disponible en la lista desplegable, selecciónela.  
  
         O bien  
  
    -   Seleccione **nueva conexión** para abrir el **agregar o modificar conexión** cuadro de diálogo.  
  
5.  Si la base de datos requiere una contraseña, seleccione la opción para incluir datos confidenciales y, a continuación, seleccione **siguiente**.  
  
6.  En el **Guardar cadena de conexión en el archivo de configuración de la aplicación**, seleccione **siguiente**.  
  
7.  En el **elija los objetos de base de datos**pantalla, expanda la **tablas** nodo.  
  
8.  Seleccione el **clientes** y **pedidos** tablas y, a continuación, seleccione **finalizar**.  
  
     El **NorthwindDataSet** se agrega al proyecto, y las tablas aparecen en la **orígenes de datos** ventana.  
  
## <a name="set-the-controls-to-be-created"></a>Establecer los controles que se va a crear  
 En este tutorial, los datos de la `Customers` tabla se encuentra en un **detalles** diseño donde se muestran los datos en controles individuales. Los datos de la `Orders` tabla se encuentra en un **cuadrícula** diseño que se muestra en un <xref:System.Windows.Forms.DataGridView> control.  
  
#### <a name="to-set-the-drop-type-for-the-items-in-the-data-sources-window"></a>Para establecer el tipo de acción de colocación de los elementos de la ventana Orígenes de datos  
  
1.  En el **orígenes de datos** ventana, expanda la **clientes** nodo.  
  
2.  En el **clientes** nodo, seleccione **detalles** en la lista de control para cambiar el control de la **clientes** tabla a controles individuales. Para obtener más información, consulte [establecer el control que se creará al arrastrar desde la ventana de orígenes de datos](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).  
  
## <a name="create-the-data-bound-form"></a>Crear el formulario enlazado a datos  
 Puede crear los controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana hasta el formulario.  
  
#### <a name="to-create-data-bound-controls-on-the-form"></a>Para crear controles enlazados en el formulario  
  
1.  Arrastre el método main **clientes** nodo desde el **orígenes de datos** ventana **Form1**.  
  
     Los controles enlazados a datos con etiquetas descriptivas aparecen en el formulario, junto con una barra de herramientas (<xref:System.Windows.Forms.BindingNavigator>) para navegar por los registros. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), `CustomersTableAdapter`, <xref:System.Windows.Forms.BindingSource>, y <xref:System.Windows.Forms.BindingNavigator> aparecen en la Bandeja de componentes.  
  
2.  Arrastre relacionado **pedidos** nodo desde el **orígenes de datos** ventana **Form1**.  
  
    > [!NOTE]
    >  Relacionado **pedidos** nodo se encuentra debajo de la **Fax** columna y es un nodo secundario de la **clientes** nodo.  
  
     En el formulario aparecen un control <xref:System.Windows.Forms.DataGridView> y una barra de herramientas (<xref:System.Windows.Forms.BindingNavigator>) para navegar por los registros. Un `OrdersTableAdapter` y <xref:System.Windows.Forms.BindingSource> aparecen en la Bandeja de componentes.  
  
## <a name="add-code-to-update-the-database"></a>Agregue código para actualizar la base de datos  
 Puede actualizar la base de datos mediante una llamada a la `Update` métodos de la **clientes** y **pedidos** TableAdapters. De forma predeterminada, un controlador de eventos para el **guardar** botón de la<xref:System.Windows.Forms.BindingNavigator> se agrega al código del formulario para enviar actualizaciones a la base de datos. Este procedimiento modifica el código para enviar las actualizaciones en el orden correcto. Esto elimina la posibilidad de generar errores de integridad referencial. El código también implementa el control de errores colocando la llamada de actualización en un bloque try-catch. Puede modificar el código para satisfacer las necesidades de la aplicación.  
  
> [!NOTE]
>  Para mayor claridad, este tutorial no utiliza una transacción. Sin embargo, si va a actualizar dos o más tablas relacionadas, incluir toda la lógica de actualización dentro de una transacción. Una transacción es un proceso que asegura que todos los cambios relacionados con una base de datos son correctos antes de confirmados los cambios. Para obtener más información, consulte [transacciones y simultaneidad](/dotnet/framework/data/adonet/transactions-and-concurrency).  
  
#### <a name="to-add-update-logic-to-the-application"></a>Para agregar la lógica de actualización a la aplicación  
  
1.  Seleccione el **guardar** situado en el <xref:System.Windows.Forms.BindingNavigator>. Se abrirá el Editor de código para el `bindingNavigatorSaveItem_Click` controlador de eventos.  
  
2.  Reemplace el código del controlador de eventos para que llame a los métodos `Update` de los TableAdapters relacionados. El código siguiente crea en primer lugar tres tablas de datos temporales para la información actualizada de cada <xref:System.Data.DataRowState> (<xref:System.Data.DataRowState.Deleted>, <xref:System.Data.DataRowState.Added> y <xref:System.Data.DataRowState.Modified>). A continuación, las actualizaciones se ejecutan en el orden correcto. El código debe tener este aspecto:  
  
     [!code-vb[VbRaddataSaving#10](../data-tools/codesnippet/VisualBasic/save-data-to-a-database-multiple-tables_1.vb)]
     [!code-csharp[VbRaddataSaving#10](../data-tools/codesnippet/CSharp/save-data-to-a-database-multiple-tables_1.cs)]  
  
## <a name="test-the-application"></a>Probar la aplicación  
  
#### <a name="to-test-the-application"></a>Para probar la aplicación  
  
1.  Seleccione **F5**.  
  
2.  Realice algunos cambios en los datos de uno o más registros de cada tabla.  
  
3.  Seleccione el **guardar** botón.  
  
4.  Compruebe los valores de la base de datos para verificar que se guardaron los cambios.  
  
  
## <a name="see-also"></a>Vea también  
 [Guardar los datos de nuevo en la base de datos](../data-tools/save-data-back-to-the-database.md)