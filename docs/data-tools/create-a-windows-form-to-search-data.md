---
title: Crear un formulario Windows Forms para buscar datos | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- Windows Forms, searching data
- Windows Forms, displaying data
- parameters, displaying filtered data
- data [Visual Studio], parameterizing queries
- data [Visual Studio], searching
ms.assetid: 65ca79a9-7458-466c-af55-978cd24c549e
caps.latest.revision: "28"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload: data-storage
ms.openlocfilehash: 31ec03dbc2eda481d4de82a848d696b80e99cb2e
ms.sourcegitcommit: 49aa031cbebdd9c7ec070c713afb1a97d1ecb701
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/23/2018
---
# <a name="create-a-windows-form-to-search-data"></a>Crear un formulario Windows Forms para buscar datos
Un escenario habitual de la aplicación es mostrar los datos seleccionados en un formulario. Por ejemplo, puede que desee mostrar los pedidos de un cliente concreto o los detalles de un pedido específico. En este caso, un usuario escribe información en un formulario y, a continuación, se ejecuta una consulta con la entrada del usuario como parámetro; es decir, los datos se seleccionan basándose en una consulta parametrizada. La consulta devuelve sólo los datos que satisfacen los criterios escritos por el usuario. Este tutorial muestra cómo crear una consulta que devuelve los clientes de una ciudad específica y cómo modificar la interfaz de usuario para que los usuarios puedan escribir el nombre de una ciudad y presionar un botón para ejecutar la consulta.  
  
 El uso de consultas parametrizadas ayuda a que la aplicación sea más eficaz, ya que permite a la base de datos realizar el trabajo que mejor sabe hacer: filtrar registros rápidamente. En cambio, si solicita una tabla de base de datos completa, transferirla por la red y, a continuación, usar lógica de la aplicación para buscar los registros que desee, la aplicación puede tornarse más lenta e ineficaz.  
  
 Puede agregar consultas parametrizadas a cualquier TableAdapter (y controles para aceptar los valores de parámetro y ejecutar la consulta), mediante el **generador de criterios de búsqueda** cuadro de diálogo. Abra el cuadro de diálogo seleccionando el **Agregar consulta** comando el **datos** menú (o en cualquier etiqueta inteligente del TableAdapter).  
  
 Las tareas ilustradas en este tutorial incluyen:  
  
-   Crear un nuevo proyecto de aplicación de Windows Forms.  
  
-   Crear y configurar el origen de datos en la aplicación con el **configuración del origen de datos** asistente.  
  
-   Establecer el tipo de colocación de los elementos de la **orígenes de datos**ventana.  
  
-   Crear controles que muestran datos arrastrando elementos desde la **orígenes de datos** ventana a un formulario.  
  
-   Agregar controles para mostrar los datos en el formulario.  
  
-   Completar la **generador de criterios de búsqueda** cuadro de diálogo.  
  
-   Escribir parámetros en el formulario y ejecutar la consulta con parámetros.  
  
## <a name="prerequisites"></a>Requisitos previos

Este tutorial usa SQL Server Express LocalDB y la base de datos de ejemplo Northwind.  

1.  Si no tiene SQL Server Express LocalDB, puede instalarlo desde el [página de descarga de SQL Server Express](https://www.microsoft.com/sql-server/sql-server-editions-express), o a través del **instalador de Visual Studio**. El instalador de Visual Studio, se puede instalar SQL Server Express LocalDB como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo, o como un componente individual.

2.  Instalar la base de datos de ejemplo Northwind, siga estos pasos:  

    1. En Visual Studio, abra el **Explorador de objetos de SQL Server** ventana. (Explorador de objetos de SQL Server se instala como parte de la **almacenamiento de datos y el procesamiento** carga de trabajo en el instalador de Visual Studio.) Expanda el **SQL Server** nodo. Haga doble clic en la instancia de LocalDB y seleccione **nueva consulta...** .  

       Se abre una ventana del editor de consultas.  

    2. Copia la [script Transact-SQL de Northwind](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) en el Portapapeles. Este script de T-SQL crea la base de datos Northwind desde el principio y lo rellena con datos.  

    3. Pegue el script de T-SQL en el editor de consultas y, a continuación, elija la **Execute** botón.  

       Después de unos minutos, finaliza la ejecución de la consulta y se crea la base de datos Northwind.  
  
## <a name="create-the-windows-forms-application"></a>Crear la aplicación de Windows Forms  
 El primer paso es crear un **aplicación de Windows Forms**. Asignar un nombre al proyecto es opcional en este paso, pero se podrá asignarle un nombre aquí debido a que podrá guardar el proyecto más adelante.  
  
#### <a name="to-create-the-new-windows-forms-application-project"></a>Para crear el nuevo proyecto de aplicación de Windows Forms  
  
1. En Visual Studio, en el **archivo** menú, seleccione **New**, **proyecto...** .  
  
2. Expanda **Visual C#** o **Visual Basic** en el panel izquierdo, seleccione **escritorio clásico de Windows**.  

3. En el panel central, seleccione la **aplicación de Windows Forms** tipo de proyecto.  

4. Denomine el proyecto **WindowsSearchForm**y, a continuación, elija **Aceptar**. 
  
     El **WindowsSearchForm** se crea y se agrega al proyecto **el Explorador de soluciones**.  
  
## <a name="create-the-data-source"></a>Crear el origen de datos  
Este paso crea un origen de datos desde una base de datos mediante la **configuración del origen de datos** asistente.  
  
#### <a name="to-create-the-data-source"></a>Para crear el origen de datos  
  
1.  En el menú **Datos** , haga clic en **Mostrar orígenes de datos**.  
  
2.  En el **orígenes de datos** ventana, seleccione **Agregar nuevo origen de datos** para iniciar el **configuración del origen de datos** asistente.  
  
3.  Seleccione **Base de datos** en la página **Elegir un tipo de datos de origen** y luego haga clic en **Siguiente**.  
  
4.  En el **elegir la conexión de datos** realice de página una de las siguientes acciones:  
  
    -   Si una conexión de datos a la base de datos de ejemplo Northwind está disponible en la lista desplegable, selecciónela.  
  
    -   Seleccione **nueva conexión** para iniciar el **agregar o modificar conexión** cuadro de diálogo.  
  
5.  Si la base de datos requiere una contraseña, seleccione la opción para incluir datos confidenciales y, a continuación, haga clic en **siguiente**.  
  
6.  En el **Guardar cadena de conexión en el archivo de configuración de la aplicación** página, haga clic en **siguiente**.  
  
7.  En el **elija los objetos de base de datos** página, expanda la **tablas** nodo.  
  
8.  Seleccione el **clientes** de tabla y, a continuación, haga clic en **finalizar**.  
  
     El **NorthwindDataSet** se agrega al proyecto y el **clientes** tabla aparece en la **orígenes de datos** ventana.  
  
## <a name="create-the-form"></a>Crear el formulario  
 Puede crear los controles enlazados a datos arrastrando elementos desde la **orígenes de datos** ventana hasta el formulario.  
  
#### <a name="to-create-data-bound-controls-on-the-form"></a>Para crear controles enlazados en el formulario  
  
1.  Expanda el **clientes** nodo en el **orígenes de datos** ventana.  
  
2.  Arrastre el **clientes** nodo desde el **orígenes de datos** ventana al formulario.  
  
     En el formulario aparecen un control <xref:System.Windows.Forms.DataGridView> y una barra de herramientas (<xref:System.Windows.Forms.BindingNavigator>) para navegar por los registros. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, y <xref:System.Windows.Forms.BindingNavigator> aparecen en la Bandeja de componentes.  
  
## <a name="add-parameterization-search-functionality-to-the-query"></a>Agregar parametrización (funcionalidad de búsqueda) a la consulta  
 Puede agregar una cláusula WHERE a la consulta original utilizando el **generador de criterios de búsqueda** cuadro de diálogo.  
  
#### <a name="to-create-a-parameterized-query-and-controls-to-enter-the-parameters"></a>Para crear una consulta parametrizada y controles para escribir los parámetros  
  
1.  Seleccione el <xref:System.Windows.Forms.DataGridView> de control y, a continuación, elija **Agregar consulta** en el **datos** menú.  
  
2.  Tipo de `FillByCity` en el **nuevo nombre de consulta** área en el **generador de criterios de búsqueda** cuadro de diálogo.  
  
3.  Agregar `WHERE City = @City` a la consulta en el **texto de la consulta** área.  
  
     La consulta debe ser similar a lo siguiente:  
  
     ```sql
     SELECT CustomerID, CompanyName, ContactName, ContactTitle,  
          Address, City, Region, PostalCode, Country, Phone, Fax  
     FROM Customers
     WHERE City = @City  
     ```
  
    > [!NOTE]
    >  Orígenes de datos de Access y OLE DB usan el signo de interrogación ('? ') para denotar los parámetros, por lo que la cláusula WHERE tendría este aspecto: `WHERE City = ?`.  
  
4.  Haga clic en **Aceptar** para cerrar el **generador de criterios de búsqueda** cuadro de diálogo.  
  
     A **FillByCityToolStrip** se agrega al formulario.  
  
## <a name="testing-the-application"></a>Probar la aplicación  
 Al ejecutar la aplicación, se abre el formulario listo para tomar el parámetro como entrada.  
  
#### <a name="to-test-the-application"></a>Para probar la aplicación  
  
1.  Presione F5 para ejecutar la aplicación.  
  
2.  Tipo de **London** en el **City** cuadro de texto y, a continuación, haga clic en **FillByCity**.  
  
     La cuadrícula de datos se rellena con los clientes que cumplen los criterios. En este ejemplo, la cuadrícula de datos muestra sólo los clientes que tienen un valor de **London** en sus **City** columna.  
  
## <a name="next-steps"></a>Pasos siguientes  
 Dependiendo de los requisitos de la aplicación, existen varios pasos que se pueden realizar después de crear un formulario parametrizado. Entre las mejoras que podría realizar se incluyen:  
  
-   Agregar controles que muestran datos relacionados. Para obtener más información, consulte [relaciones en conjuntos de datos](relationships-in-datasets.md).  
  
-   Modificar el conjunto de datos agregando o quitando objetos de la base de datos. Para obtener más información, vea [Crear y configurar conjuntos de datos](../data-tools/create-and-configure-datasets-in-visual-studio.md).  
  
## <a name="see-also"></a>Vea también  
 [Enlazar controles de Windows Forms a datos en Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)