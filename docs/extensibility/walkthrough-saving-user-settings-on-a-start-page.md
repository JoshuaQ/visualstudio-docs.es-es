---
title: "Tutorial: Guardar configuración de usuario en una página de inicio | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 754b9bf3-8681-4c77-b0a4-09146a4e1d2d
caps.latest.revision: "18"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 16de0e205d71e2a71b14f523dedbb45354157355
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="walkthrough-saving-user-settings-on-a-start-page"></a>Tutorial: Guardar configuración de usuario en una página de inicio
Puede conservar la configuración de usuario para la página de inicio. Si sigue este tutorial, puede crear un control que guarda una configuración en el registro cuando el usuario hace clic en un botón y, a continuación, recupera ese valor cada vez que se cargue la página de inicio. Dado que la plantilla de proyecto de la página de inicio incluye un control de usuario personalizable y el XAML de la página de inicio predeterminada llama a ese control, no es necesario que modificar la página de inicio propio.  
  
 El almacén de configuración que se crea una instancia en este tutorial es una instancia de la <xref:Microsoft.VisualStudio.Shell.Interop.IVsWritableSettingsStore> interfaz, que lee y escribe en la siguiente ubicación del registro cuando se llama: HKCU\Software\Microsoft\VisualStudio\14.0\\  *NombreDeColección*  
  
 Cuando se ejecuta en la instancia experimental de Visual Studio, el almacén de configuración lee y escribe en HKCU\Software\Microsoft\VisualStudio\14.0Exp\\*nombreDeColección.*  
  
 Para obtener más información acerca de cómo conservar la configuración, consulte [opciones y configuración de usuario de extensión](../extensibility/extending-user-settings-and-options.md).  
  
## <a name="prerequisites"></a>Requisitos previos  
  
> [!NOTE]
>  Para seguir este tutorial, debe instalar el SDK de Visual Studio. Para obtener más información, consulte [SDK de Visual Studio](../extensibility/visual-studio-sdk.md).  
>   
>  Puede descargar la plantilla de proyecto de la página de inicio mediante el uso de **Extension Manager**.  
  
## <a name="setting-up-the-project"></a>Configurar el proyecto  
  
#### <a name="to-configure-the-project-for-this-walkthrough"></a>Para configurar el proyecto para este tutorial  
  
1.  Crear un proyecto de la página de inicio como se describe en [crear una página de inicio personalizada](creating-a-custom-start-page.md). Denomine el proyecto **SaveMySettings**.  
  
2.  En **el Explorador de soluciones**, agregue las siguientes referencias de ensamblado al proyecto StartPageControl:  
  
    -   EnvDTE  
  
    -   EnvDTE80  
  
    -   Microsoft.VisualStudio.OLE.Interop  
  
    -   Microsoft.VisualStudio.Shell.Interop.11.0  
  
3.  Abra MyControl.xaml.  
  
4.  En el panel XAML, en el nivel superior <xref:System.Windows.Controls.UserControl> definición de elemento, agregue la siguiente declaración de evento después de las declaraciones de espacio de nombres.  
  
    ```  
    Loaded="OnLoaded"  
    ```  
  
5.  En el panel de diseño, haga clic en el área principal del control y, a continuación, presione SUPR.  
  
     Esto quita la <xref:System.Windows.Controls.Border> elemento y todos los elementos de la base de datos y deja solo el nivel superior <xref:System.Windows.Controls.Grid> elemento.  
  
6.  Desde el **cuadro de herramientas**, arrastre un <xref:System.Windows.Controls.StackPanel> control a la cuadrícula.  
  
7.  Ahora, arrastre un <xref:System.Windows.Controls.TextBlock>, <xref:System.Windows.Controls.TextBox>y un botón a la <xref:System.Windows.Controls.StackPanel>.  
  
8.  Agregar un **x: Name** de atributo para el <xref:System.Windows.Controls.TextBox>y un `Click` eventos para el <xref:System.Windows.Controls.Button>, como se muestra en el ejemplo siguiente.  
  
    ```xml  
    <StackPanel Width="300" HorizontalAlignment="Center" VerticalAlignment="Center">  
        <TextBlock Width="140" FontSize="14">Enter your setting</TextBlock>  
        <TextBox x:Name="txtblk" Margin="0, 5, 0, 10" Width="140" />  
        <Button Click="Button_Click" Width="100">Save My Setting</Button>  
    </StackPanel>  
    ```  
  
## <a name="implementing-the-user-control"></a>Implementar el Control de usuario  
  
#### <a name="to-implement-the-user-control"></a>Para implementar el control de usuario  
  
1.  En el panel XAML, haga clic en el `Click` atributo de la <xref:System.Windows.Controls.Button> elemento y, a continuación, haga clic en **navegar al controlador de eventos**.  
  
     Esto abre MyControl.xaml.cs y crea un controlador de código auxiliar para el `Button_Click` eventos.  
  
2.  Agregue las siguientes `using` instrucciones a la parte superior del archivo.  
  
     [!code-csharp[StartPageDTE#11](../extensibility/codesnippet/CSharp/walkthrough-saving-user-settings-on-a-start-page_1.cs)]  
  
3.  Agregar una privada `SettingsStore` propiedad, como se muestra en el ejemplo siguiente.  
  
    ```csharp  
    private IVsWritableSettingsStore _settingsStore = null;  
    private IVsWritableSettingsStore SettingsStore  
    {  
        get  
        {  
            if (_settingsStore == null)  
            {  
                // Get a reference to the DTE from the DataContext.   
                var typeDescriptor = DataContext as ICustomTypeDescriptor;  
                var propertyCollection = typeDescriptor.GetProperties();  
                var dte = propertyCollection.Find("DTE", false).GetValue(  
                    DataContext) as DTE2;  
  
                // Get the settings manager from the DTE.   
                var serviceProvider = new ServiceProvider(  
                    (Microsoft.VisualStudio.OLE.Interop.IServiceProvider)dte);  
                var settingsManager = serviceProvider.GetService(  
                    typeof(SVsSettingsManager)) as IVsSettingsManager;  
  
                // Write the user settings to _settingsStore.  
                settingsManager.GetWritableSettingsStore(  
                    (uint)__VsSettingsScope.SettingsScope_UserSettings,  
                    out _settingsStore);  
            }  
            return _settingsStore;  
        }  
    }  
    ```  
  
     Esta propiedad obtiene primero una referencia a la <xref:EnvDTE80.DTE2> interfaz, que contiene el modelo de objetos de automatización de la <xref:System.Windows.FrameworkElement.DataContext%2A> del control de usuario y, a continuación, utiliza la propiedad DTE para obtener una instancia de la <xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsManager> interfaz. A continuación, utiliza esa instancia para devolver la configuración del usuario actual.  
  
4.  Rellene el `Button_Click` evento como se indica a continuación.  
  
    ```csharp  
    private void Button_Click(object sender, RoutedEventArgs e)  
    {  
        int exists = 0;  
        SettingsStore.CollectionExists("MySettings", out exists);  
        if (exists != 1)  
        {  
            SettingsStore.CreateCollection("MySettings");  
        }  
        SettingsStore.SetString("MySettings", "MySetting", txtblk.Text);  
    }  
    ```  
  
     Escribe el contenido del cuadro de texto a un campo de "MySetting" en una colección de "MySettings" en el registro. Si la colección no existe, se crea.  
  
5.  Agregue el siguiente controlador para el `OnLoaded` eventos del control de usuario.  
  
    ```csharp  
    private void OnLoaded(Object sender, RoutedEventArgs e)  
    {  
        string value;  
        SettingsStore.GetStringOrDefault(  
            "MySettings", "MySetting", "", out value);  
        txtblk.Text = value;  
    }  
    ```  
  
     Esto establece el texto del cuadro de texto en el valor actual de "MySetting".  
  
6.  Compilar el control de usuario.  
  
7.  En **el Explorador de soluciones**, abra source.extension.vsixmanifest.  
  
8.  En el editor de manifiestos, establezca **Product Name** a **Guardar página de inicio de la configuración de mi**.  
  
     Esto establece el nombre de la página de inicio que va a aparecer en el **Personalizar página principal** lista en la **opciones** cuadro de diálogo.  
  
9. Generar StartPage.xaml.  
  
## <a name="testing-the-control"></a>Probar el control  
  
#### <a name="to-test-the-user-control"></a>Para probar el control de usuario  
  
1.  Presione F5.  
  
     Se abre la instancia experimental de Visual Studio.  
  
2.  En la instancia experimental, en la **herramientas** menú, haga clic en **opciones**.  
  
3.  En el **entorno** nodo, haga clic en **inicio**y, a continuación, en la **Personalizar página principal** lista, seleccione **[extensión instalado] guardar mi configuración de página de inicio** .  
  
     Haga clic en **Aceptar**.  
  
4.  Cierre la página de inicio si está abierto y, a continuación, en la **vista** menú, haga clic en **página de inicio**.  
  
5.  En la página de inicio, haga clic en el **MyControl** ficha.  
  
6.  En el cuadro de texto, escriba **Cat**y, a continuación, haga clic en **guardar mi configuración**.  
  
7.  Cierre la página de inicio y, a continuación, vuelva a abrirlo.  
  
     La palabra "Cat" se debe mostrar en el cuadro de texto.  
  
8.  Reemplace la palabra "Cat" por la palabra "Dog". No se hace clic en el botón.  
  
9. Cierre la página de inicio y, a continuación, vuelva a abrirlo.  
  
     La palabra "Dog" debe mostrarse en el cuadro de texto, aunque no se ha guardado la configuración. Esto sucede porque Visual Studio realiza las ventanas de herramientas en la memoria, incluso si están cerrados, hasta que se cierre Visual Studio.  
  
10. Cierre la instancia experimental de Visual Studio.  
  
11. Presione F5 para volver a abrir la instancia experimental.  
  
12. La palabra "Cat" se debe mostrar en el cuadro de texto.  
  
## <a name="next-steps"></a>Pasos siguientes  
 Puede modificar este control de usuario para guardar y recuperar cualquier número de configuración personalizada mediante el uso de valores distintos de los controladores de eventos diferentes para obtener y establecer el `SettingsStore` propiedad. Siempre y cuando utilice otro `propertyName` parámetro para cada llamada a <xref:Microsoft.VisualStudio.Shell.Interop.IVsWritableSettingsStore.SetString%2A>, los valores no sobrescribirán entre sí en el registro.  
  
## <a name="see-also"></a>Vea también  
 <xref:EnvDTE80.DTE2?displayProperty=fullName>     
 [Adición de comandos de Visual Studio a una página de inicio](../extensibility/adding-visual-studio-commands-to-a-start-page.md)