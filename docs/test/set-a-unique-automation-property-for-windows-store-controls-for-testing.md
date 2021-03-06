---
title: "Establecer una propiedad única de automatización para controles UWP para pruebas | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-devops-test
ms.tgt_pltfrm: 
ms.topic: article
ms.author: gewarren
manager: ghogen
ms.workload: uwp
author: gewarren
ms.openlocfilehash: 0b1054dbbbe39c5b6beb2740f74e3dd84988d02b
ms.sourcegitcommit: 7ae502c5767a34dc35e760ff02032f4902c7c02b
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 01/09/2018
---
# <a name="set-a-unique-automation-property-for-uwp-controls-for-testing"></a>Establecer una propiedad única de automatización para controles UWP para pruebas
Si desea ejecutar pruebas de IU codificadas para la aplicación para UWP basada en XAML, debe tener una propiedad única de automatización que identifique cada control.  
  
 Puede asignar una propiedad única de automatización basada en el tipo de control de XAML de la aplicación. Aquí se indica cómo asignar esta propiedad única de automatización en las situaciones siguientes:  
  
-   [Definición estática XAML de los controles](#UniquePropertyWindowsStoreControlsStaticXAML)  
  
-   [Asignar propiedades únicas de automatización mediante Visual Studio o Blend para Visual Studio](#UniquePropertyWindowsStoreControlsExpressionBlend)  
  
-   [Usar una plantilla de datos](#UniquePropertyWindowsStoreControlsDataTemplate)  
  
-   [Usar una plantilla de control](#UniquePropertyWindowsStoreControlsControlTemplate)  
  
-   [Controles dinámicos](#UniquePropertyWindowsStoreControlsDynamicControls)  
  
## <a name="use-methods-to-assign-a-unique-automation-property"></a>Usar métodos para asignar una propiedad única de automatización  
  
###  <a name="UniquePropertyWindowsStoreControlsStaticXAML"></a> Definición estática XAML  
 Para especificar una propiedad única de automatización de un control que se define en el archivo XAML, puede establecer AutomationProperties.AutomationId o el AutomationProperties.Name implícita o explícitamente, como se muestra en los ejemplos siguientes. Al establecer alguno de estos valores se proporciona al control una propiedad única de automatización que se puede usar para identificar el control cuando se crea una grabación de acciones o de pruebas de la interfaz de usuario.  
  
 **Establecer la propiedad implícitamente**  
  
 Establezca AutomationProperties.AutomationId en **ButtonX** mediante la propiedad Name en el código XAML para el control.  
  
```xaml  
<Button Name="ButtonX" Height="31" HorizontalAlignment="Left" Margin="23,26,0,0"  VerticalAlignment="Top" Width="140" Click="ButtonX_Click" />  
  
```  
  
 Establezca AutomationProperties.Name en **ButtonY** mediante la propiedad Content en el código XAML para el control.  
  
```xaml  
<Button Content="ButtonY" Height="31" HorizontalAlignment="Left" Margin="23,76,0,0" VerticalAlignment="Top" Width="140" Click="ButtonY_Click" />  
  
```  
  
 **Establecer la propiedad explícitamente**  
  
 Establezca AutomationProperties.AutomationId en **ButtonX** explícitamente en el código XAML para el control.  
  
```xaml  
<Button AutomationProperties.AutomationId="ButtonX" Height="31" HorizontalAlignment="Left" Margin="23,26,0,0"  VerticalAlignment="Top" Width="140" Click="ButtonX_Click" />  
  
```  
  
 Establezca AutomationProperties.Name en **ButtonY** explícitamente en el código XAML para el control.  
  
```  
<Button AutomationProperties.Name="ButtonY" Height="31" HorizontalAlignment="Left" Margin="23,76,0,0" VerticalAlignment="Top" Width="140" Click="ButtonY_Click" />  
```  
  
###  <a name="UniquePropertyWindowsStoreControlsExpressionBlend"></a> Asignar propiedades únicas de automatización mediante Visual Studio o Blend para Visual Studio  
 Puede usar Visual Studio o Blend para Visual Studio para asignar nombres únicos a elementos interactivos como botones, cuadros de lista, cuadros combinados y cuadros de texto. Esto proporciona al control un valor único para AutomationProperties.Name.  
  
 **Visual Studio:** en el menú **Herramientas**, apunte a **Opciones** y seleccione **Editor de texto**, **XAML** y **Varios**.  
  
 Seleccione **Asignar nombre automáticamente a los elementos interactivos cuando se creen** y después haga clic en **Aceptar**.  
  
 ![Otras opciones de XAML](../test/media/cuit_windowsstoreapp_b.png "CUIT_WindowsStoreApp_B")  
  
 **Blend para Visual Studio:** use uno de los métodos siguientes para realizar esta acción desde Blend para Visual Studio.  
  
> [!NOTE]
>  Solo puede usar este método para los controles que se crean estáticamente mediante XAML.  
  
 **Para asignar un nombre único a los controles existentes**  
  
 En el menú **Herramientas**, seleccione **Asignar nombre a elementos interactivos**, como se muestra aquí:  
  
 ![Seleccionar Asignar nombre a elementos interactivos en el menú Herramientas](../test/media/cuit_windowsstoreproperty_blend_1.png "CUIT_WindowsStoreProperty_Blend_1")  
  
 **Para asignar automáticamente un nombre único a los controles que se crean**  
  
 En el menú **Herramientas**, apunte a **Opciones** y seleccione **Proyecto**. Seleccione **Asignar nombre automáticamente a los elementos interactivos cuando se creen** y después haga clic en **Aceptar**, como se muestra aquí:  
  
 ![Establecer el proyecto para asignar nombre a los elementos interactivos](../test/media/cuit_windowsstoreproeprty_blend_2.png "CUIT_WindowsStoreProeprty_Blend_2")  
  
###  <a name="UniquePropertyWindowsStoreControlsDataTemplate"></a> Usar una plantilla de datos  
 Puede definir una plantilla sencilla mediante ItemTemplate para enlazar los valores de un cuadro de lista con variables utilizando el XAML siguiente.  
  
```xaml  
  
<ListBox Name="listBox1" ItemsSource="{Binding Source={StaticResource employees}}">  
   <ListBox.ItemTemplate>  
      <DataTemplate>  
         <StackPanel Orientation="Horizontal">  
            <TextBlock Text="{Binding EmployeeName}" />  
            <TextBlock Text="{Binding EmployeeID}" />  
         </StackPanel>  
      </DataTemplate>  
   </ListBox.ItemTemplate>  
</ListBox>  
```  
  
 También puede usar una plantilla con ItemContainerStyle para enlazar los valores a las variables utilizando el XAML siguiente.  
  
```xaml  
  
      <ListBox Name="listBox1" ItemsSource="{Binding Source={StaticResource employees}}">  
            <ListBox.ItemContainerStyle>  
                <Style TargetType="ListBoxItem">  
                    <Setter Property="Template">  
                        <Setter.Value>  
                            <ControlTemplate TargetType="ListBoxItem">  
                                <Grid>  
                                    <Button Content="{Binding EmployeeName}" AutomationProperties.AutomationId="{Binding EmployeeID}"/>  
                                </Grid>  
                            </ControlTemplate>  
                        </Setter.Value>  
                    </Setter>  
                </Style>  
            </ListBox.ItemContainerStyle>           
        </ListBox>  
  
```  
  
 En ambos ejemplos, debe reemplazar el método ToString () de ItemSource, como se muestra en el código siguiente. Este código se asegura de que el valor de AutomationProperties.Name está establecido y es único, porque no se puede establecer una propiedad única de automatización para cada elemento de lista enlazado a datos utilizando enlace a datos. Establecer un valor único de automatización Properties.Name es suficiente en este caso.  
  
> [!NOTE]
>  Con este enfoque, el contenido interno del elemento de lista también se puede establecer en una cadena en la clase de empleados a través del enlace. Como se muestra en el ejemplo, al control de botón dentro de cada elemento de lista se le asigna un identificador único de automatización que es el id. de empleado.  
  
```  
  
Employee[] employees = new Employee[]   
{  
   new Employee("john", "4384"),  
   new Employee("margaret", "7556"),  
   new Employee("richard", "8688"),  
   new Employee("george", "1293")  
};  
  
listBox1.ItemsSource = employees;  
  
public override string ToString()  
{  
    return EmployeeName + EmployeeID; // Unique Identification to be set as the AutomationProperties.Name  
}  
  
```  
  
###  <a name="UniquePropertyWindowsStoreControlsControlTemplate"></a> Usar una plantilla de control  
 Puede utilizar una plantilla de control para que cada instancia de un tipo específico obtenga una propiedad única de automatización cuando se define en el código. Debe crear la plantilla para que AutomationProperty enlace a un identificador único en la instancia del control. El XAML siguiente muestra un enfoque para crear este enlace con una plantilla de control.  
  
```xaml  
  
<Style x:Key="MyButton" TargetType="Button">  
<Setter Property="Template">  
   <Setter.Value>  
<ControlTemplate TargetType="Button">  
   <Grid>  
      <CheckBox HorizontalAlignment="Left" AutomationProperties.AutomationId="{TemplateBinding Content}"></CheckBox>  
      <Button Width="90" HorizontalAlignment="Right" Content="{TemplateBinding Content}" AutomationProperties.AutomationId="{TemplateBinding Content}"></Button>  
   </Grid>  
</ControlTemplate>  
   </Setter.Value>  
</Setter>  
</Style>  
  
```  
  
 Al definir dos instancias de un botón mediante esta plantilla de control, el id. de automatización se establece en la cadena de contenido única para los controles de la plantilla, como se muestra en el código XAML siguiente.  
  
```xaml  
  
<Button Content="Button1" Style="{StaticResource MyButton}" Width="140"/>  
<Button Content="Button2" Style="{StaticResource MyButton}" Width="140"/>  
```  
  
###  <a name="UniquePropertyWindowsStoreControlsDynamicControls"></a> Controles dinámicos  
 Si tiene controles creados dinámicamente desde el código en lugar de estáticamente o a través de las plantillas de los archivos XAML, debe establecer el contenido o las propiedades de dominio para el control. Esto garantiza que cada control dinámico tiene una propiedad única de automatización. Por ejemplo, si tiene una casilla que debe mostrarse cuando se selecciona un elemento de lista, puede establecer estas propiedades, como se muestra aquí:  
  
```csharp  
  
private void CreateCheckBox(string txt, StackPanel panel)  
   {  
      CheckBox cb = new CheckBox();  
      cb.Content = txt; // Sets the AutomationProperties.Name  
      cb.Height = 50;  
      cb.Width = 100;  
      cb.Name = "DynamicCheckBoxAid"+ txt; // Sets the AutomationProperties.AutomationId  
      panel.Children.Add(cb);  
    }  
  
```  
  
## <a name="see-also"></a>Vea también  
 [Comprobar aplicaciones para Windows UWP con pruebas de IU codificadas](../test/test-windows-store-8-1-apps-with-coded-ui-tests.md)
