---
title: Crear un Windows Forms Control Toolbox | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- winforms
- toolbox
- windows forms
ms.assetid: 0be6ffc1-8afd-4d02-9a5d-e27dde05fde6
caps.latest.revision: "19"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 4229d9045dfe64fcb320eca7cf004de56e7f8f0d
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="creating-a-windows-forms-toolbox-control"></a>Crear un Control de cuadro de herramientas de Windows Forms
La plantilla de elemento de Control de cuadro de herramientas de Windows Forms que se incluye en las herramientas de extensibilidad de Visual Studio (SDK de VS) le permite crear un control que se agrega automáticamente a la **cuadro de herramientas** cuando se instala la extensión. Este tema muestra cómo usar la plantilla para crear un control de contador simple que se puede distribuir a otros usuarios.  
  
## <a name="prerequisites"></a>Requisitos previos  
 A partir de Visual Studio 2015, no instale el SDK de Visual Studio desde el centro de descarga. Se incluye como una característica opcional en el programa de instalación de Visual Studio. También puede instalar el SDK de VS más adelante. Para obtener más información, consulte [instalar el SDK de Visual Studio](../extensibility/installing-the-visual-studio-sdk.md).  
  
## <a name="creating-a-windows-forms-toolbox-control"></a>Crear un Control de cuadro de herramientas de Windows Forms  
 La plantilla de Control de cuadro de herramientas de Windows Forms crea un control de usuario no definido y proporciona toda la funcionalidad necesaria para agregar el control a la **cuadro de herramientas**.  
  
#### <a name="create-an-extension-with-a-windows-forms-toolbox-control"></a>Crear una extensión con un Control de cuadro de herramientas de Windows Forms  
  
1.  Crear un proyecto VSIX denominado `MyWinFormsControl`. Puede encontrar la plantilla de proyecto VSIX en la **nuevo proyecto** en el cuadro de diálogo **Visual C# / extensibilidad**.  
  
2.  Cuando se abre el proyecto, agregue un **Windows Forms Toolbox Control** plantilla de elemento denominada `Counter`. En el **el Explorador de soluciones**, haga clic en el nodo del proyecto y seleccione **Agregar / nuevo elemento**. En el **Agregar nuevo elemento** cuadro de diálogo, vaya a **Visual C# / extensibilidad** y seleccione **Control de cuadro de herramientas de Windows Forms**  
  
3.  Esto agrega un control de usuario, un `ProvideToolboxControlAttribute` <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute> para colocar el control en el **cuadro de herramientas**y un **Microsoft.VisualStudio.ToolboxControl** entrada de activo en el manifiesto VSIX para la implementación.  
  
### <a name="building-a-user-interface-for-the-control"></a>Crear una interfaz de usuario para el control  
 El `Counter` control requiere dos controles secundarios: una <xref:System.Windows.Forms.Label> para mostrar el recuento actual y un <xref:System.Windows.Forms.Button> para restablecer el recuento a 0. No hay más controles secundarios son necesarios porque los llamadores incrementará el contador mediante programación.  
  
##### <a name="to-build-the-user-interface"></a>Para crear la interfaz de usuario  
  
1.  En **el Explorador de soluciones**, haga doble clic en Counter.cs para abrirlo en el diseñador.  
  
2.  Quitar el "haga clic aquí!" **Botón** que se incluye de forma predeterminada cuando se agrega la plantilla de elemento de Control de cuadro de herramientas de Windows Forms.  
  
3.  Desde el **cuadro de herramientas**, arrastre un `Label` control y, a continuación, un `Button` control por debajo de él en la superficie de diseño.  
  
4.  El tamaño del control de usuario general a 150, 50 píxeles y el botón de cambio de tamaño el control a 50, 20 píxeles.  
  
5.  En el **propiedades** ventana, establezca los siguientes valores para los controles en la superficie de diseño.  
  
    |Control|Propiedad|Valor|  
    |-------------|--------------|-----------|  
    |`Label1`|**Texto**|""|  
    |`Button1`|**Name**|btnReset|  
    |`Button1`|**Texto**|Restablecer|  
  
### <a name="coding-the-user-control"></a>Codificar el control de usuario  
 El control `Counter` presentará un método para incrementar el contador, un evento que se desencadenará cuando el contador se incremente, un botón `Reset` y tres propiedades para almacenar el recuento actual, el texto para mostrar y si se debe mostrar u ocultar el botón `Reset` . El `ProvideToolboxControl` atributo determina dónde en la **cuadro de herramientas** el `Counter` control aparecerá.  
  
##### <a name="to-code-the-user-control"></a>Para codificar el control de usuario  
  
1.  Haga doble clic en el formulario para abrir su controlador de eventos de carga en la ventana de código.  
  
2.  Por encima del método de controlador de eventos, en la clase de control crea un entero para almacenar el valor del contador y una cadena para almacenar el texto para mostrar, tal como se muestra en el ejemplo siguiente.  
  
    ```csharp  
    int currentValue;  
    string displayText;  
    ```  
  
3.  Cree las siguientes declaraciones de propiedad pública.  
  
    ```csharp  
    public int Value {  
        get { return currentValue; }   
    }  
  
    public string Message {  
        get { return displayText; }  
        set { displayText = value; }  
    }  
  
    public bool ShowReset {  
        get { return btnReset.Visible; }  
        set { btnReset.Visible = value; }  
    }  
  
    ```  
  
     Los autores de llamada pueden tener acceso a estas propiedades para obtener y establecer el texto de presentación del contador y para mostrar u ocultar el `Reset` botón. Los autores de llamadas pueden obtener el valor actual de solo lectura `Value` propiedad, pero no se puede establecer el valor directamente.  
  
4.  Coloque el siguiente código el `Load` eventos para el control.  
  
    ```csharp  
    private void Counter_Load(object sender, EventArgs e)  
    {  
        currentValue = 0;  
        label1.Text = Message + Value;  
    }  
  
    ```  
  
     Establecer el **etiqueta** texto en la <xref:System.Windows.Forms.UserControl.Load> evento permite cargar antes de que sus valores se aplican las propiedades de destino. Establecer el **etiqueta** texto en el constructor, se crearán vacío **etiqueta**.  
  
5.  Cree el siguiente método público para incrementar el contador.  
  
    ```csharp  
    public void Increment()  
    {  
        currentValue++;  
        label1.Text = displayText + Value;  
        Incremented(this, EventArgs.Empty);  
    }  
  
    ```  
  
6.  Agregue una declaración para el `Incremented` eventos a la clase de control.  
  
    ```csharp  
    public event EventHandler Incremented;  
    ```  
  
     Los autores de llamadas pueden agregar controladores a este evento para responder a los cambios en el valor del contador.  
  
7.  Vuelva a la vista Diseño y haga doble clic en el `Reset` botón para generar el `btnReset_Click` controlador de eventos y, a continuación, rellénelo en tal como se muestra en el ejemplo siguiente.  
  
    ```csharp  
    private void btnReset_Click(object sender, EventArgs e)  
    {  
        currentValue = 0;  
        label1.Text = displayText + Value;  
    }  
  
    ```  
  
8.  Justo encima de la definición de clase en el `ProvideToolboxControl` declaración de atributos, cambie el valor del primer parámetro de `"MyWinFormsControl.Counter"` a `"General"`. Se establece el nombre del grupo de elementos que va a hospedar el control en el **Cuadro de herramientas**.  
  
     En el ejemplo siguiente se muestra el atributo `ProvideToolboxControl` y la definición de clase ajustada.  
  
    ```csharp  
    [ProvideToolboxControl("General", false)]  
    public partial class Counter : UserControl  
    ```  
  
### <a name="testing-the-control"></a>Probar el control  
 Para probar un **cuadro de herramientas** controlar, pruébelo primero en el entorno de desarrollo y, a continuación, vuelva a probarlo en una aplicación compilada.  
  
##### <a name="to-test-the-control"></a>Para probar el control  
  
1.  Presione F5.  
  
     Esto compila el proyecto y abre una segunda instancia Experimental de Visual Studio que tiene instalado el control.  
  
2.  En la instancia Experimental de Visual Studio, cree un **aplicación de Windows Forms** proyecto.  
  
3.  En **el Explorador de soluciones**, haga doble clic en Form1.cs para abrirlo en el diseñador si no está ya abierto.  
  
4.  En el **cuadro de herramientas**, `Counter` control debe mostrarse en el **General** sección.  
  
5.  Arrastre un `Counter` el control al formulario y, a continuación, selecciónelo. El `Value`, `Message`, y `ShowReset` propiedades se mostrarán en el **propiedades** ventana, junto con las propiedades que se heredan de <xref:System.Windows.Forms.UserControl>.  
  
6.  Establezca la propiedad `Message` en `Count:`.  
  
7.  Arrastre un <xref:System.Windows.Forms.Button> control al formulario y, a continuación, establezca las propiedades de nombre y el texto del botón en `Test`.  
  
8.  Haga doble clic en el botón para abrir Form1.cs en la vista de código y crear un controlador de clic.  
  
9. En el controlador de clic, llame a `counter1.Increment()`.  
  
10. En la función constructora, después de llamar a `InitializeComponent`, tipo `counter1``.``Incremented +=` y, a continuación, presione TAB dos veces.  
  
     Visual Studio genera un controlador de nivel de formulario para el `counter1.Incremented` eventos.  
  
11. Resalte el `Throw` instrucción en el controlador de eventos, tipo `mbox`, y, a continuación, presione la tecla TAB dos veces para generar un cuadro de mensaje del fragmento de código de buzón.  
  
12. En la línea siguiente, agregue el siguiente `if` / `else` bloque para establecer la visibilidad de la `Reset` botón.  
  
    ```csharp  
    if (counter1.Value < 5) counter1.ShowReset = false;  
    else counter1.ShowReset = true;  
    ```  
  
13. Presione F5.  
  
     Abre el formulario. El `Counter` control muestra el texto siguiente.  
  
     **Recuento: 0**  
  
14. Haga clic en **Probar**.  
  
     Los incrementos de contador y Visual Studio muestra un cuadro de mensaje.  
  
15. Cierre el cuadro de mensaje.  
  
     El **restablecer** botón desaparece.  
  
16. Haga clic en **prueba** hasta que el contador llega a **5** al cerrar el mensaje cuadros cada vez.  
  
     El **restablecer** botón vuelve a aparecer.  
  
17. Haga clic en **Restablecer**.  
  
     El contador se restablece a **0**.  
  
## <a name="next-steps"></a>Pasos siguientes  
 Cuando se crea un control del **Cuadro de herramientas** , Visual Studio crea un archivo denominado *NombreDelProyecto*.vsix en la carpeta \bin\debug\ del proyecto. Para implementar el control, puede cargar el archivo .vsix en una red o un sitio web. Cuando un usuario abre el archivo .vsix, el control se instala y se agrega a Visual Studio **cuadro de herramientas** en el equipo del usuario. Como alternativa, puede cargar el archivo .vsix en el [Galería de Visual Studio](http://go.microsoft.com/fwlink/?LinkID=123847) sitio Web para que los usuarios pueden buscarlo en el **herramientas / extensiones y actualizaciones** cuadro de diálogo.  
  
## <a name="see-also"></a>Vea también  
 [Extender otras partes de Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)   
 [Crear un Control de cuadro de herramientas WPF](../extensibility/creating-a-wpf-toolbox-control.md)   
 [Extender otras partes de Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)   
 [Fundamentos de desarrollo de controles de Windows Forms](/dotnet/framework/winforms/controls/windows-forms-control-development-basics)