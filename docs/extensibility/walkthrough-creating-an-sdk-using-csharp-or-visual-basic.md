---
title: 'Tutorial: Crear un SDK usando C# o Visual Basic | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology:
- vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: ef96a249-5eef-402a-a8d5-d74cb49239bd
caps.latest.revision: 20
ms.author: gregvanl
manager: ghogen
translation.priority.mt:
- cs-cz
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- pl-pl
- pt-br
- ru-ru
- tr-tr
- zh-cn
- zh-tw
translationtype: Machine Translation
ms.sourcegitcommit: c43f3022ba53e67ff510ed63aa419c9f23964a58
ms.openlocfilehash: ce17214ec4bfc49f82ee537d6dee13a471a36ca2
ms.lasthandoff: 02/22/2017

---
# <a name="walkthrough-creating-an-sdk-using-c-or-visual-basic"></a>Tutorial: Crear un SDK usando C# o Visual Basic
En este tutorial, aprenderá a crear un SDK de biblioteca matemática simple mediante Visual C# y, a continuación, empaquete el SDK como una extensión de Visual Studio (VSIX). Se realizarán los siguientes procedimientos:  
  
-   [Para crear el componente de tiempo de ejecución de Windows SimpleMath](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createClassLibrary)  
  
-   [Para crear el proyecto de extensión SimpleMathVSIX](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createVSIX)  
  
-   [Para crear una aplicación de ejemplo que utiliza la biblioteca de clases](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createSample)  
  
## <a name="prerequisites"></a>Requisitos previos  
 Para seguir este tutorial, debe instalar el Visual Studio SDK. Para obtener más información, consulte [SDK de Visual Studio](../extensibility/visual-studio-sdk.md).  
  
##  <a name="a-namecreateclasslibrarya-to-create-the-simplemath-windows-runtime-component"></a><a name="createClassLibrary"></a>Para crear el componente de tiempo de ejecución de Windows SimpleMath  
  
1.  En la barra de menús, elija **archivo**, **nueva**, **nuevo proyecto**.  
  
2.  En la lista de plantillas, expanda **Visual C#** o **Visual Basic**, elija la **tienda Windows** nodo y, a continuación, elija la **componente de tiempo de ejecución de Windows** plantilla.  
  
3.  En el **nombre** , especifique **SimpleMath**y, a continuación, elija la **Aceptar** botón.  
  
4.  En **el Explorador de soluciones**, abra el menú contextual para el **SimpleMath** nodo de proyecto y, a continuación, elija **propiedades**.  
  
5.  Cambiar el nombre de **Class1.cs** a **Arithmetic.cs** y actualícelo para que coincida con el código siguiente:  
  
     [!code-cs[CreatingAnSDKUsingWinRT&3;](../extensibility/codesnippet/CSharp/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_1.cs) ] 
     [!code-vb [CreatingAnSDKUsingWinRT&3;](../extensibility/codesnippet/VisualBasic/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_1.vb)]  
  
6.  En **el Explorador de soluciones**, abra el menú contextual para el **solución 'SimpleMath'** nodo y, a continuación, elija **Configuration Manager**.  
  
     El **Configuration Manager** abre el cuadro de diálogo.  
  
7.  En el **configuración de soluciones activas** , elija **versión**.  
  
8.  En el **configuración** columna, compruebe que **SimpleMath** fila se establece en **versión**y, a continuación, elija la **cerrar** botón para aceptar el cambio.  
  
    > [!IMPORTANT]
    >  El SDK para el componente SimpleMath incluye una sola configuración. Esta configuración debe ser la versión de lanzamiento, o aplicaciones que utilizan el componente no apruebe la certificación el[!INCLUDE[win8_appstore_long](../debugger/includes/win8_appstore_long_md.md)].  
  
9. En **el Explorador de soluciones**, abra el menú contextual para el **SimpleMath** nodo de proyecto y, a continuación, elija **de compilación**.  
  
##  <a name="a-namecreatevsixa-to-create-the-simplemathvsix-extension-project"></a><a name="createVSIX"></a>Para crear el proyecto de extensión SimpleMathVSIX  
  
1.  En el menú contextual para el **solución 'SimpleMath'** nodo, elija **agregar**, **nuevo proyecto**.  
  
2.  En la lista de plantillas, expanda **Visual C#** o **Visual Basic**, elija la **extensibilidad** nodo y, a continuación, elija la **proyecto VSIX** plantilla.  
  
3.  En el **nombre** , especifique **SimpleMathVSIX**y, a continuación, elija la **Aceptar** botón.  
  
4.  En **el Explorador de soluciones**, elija la **source.extension.vsixmanifest** elemento.  
  
5.  En la barra de menús, elija **Ver**, **Código**.  
  
6.  Reemplace el XML con el siguiente código XML:  
  
     [!code-xml[1 CreatingAnSDKUsingWinRT](../extensibility/codesnippet/XML/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_2.xml)]
  
7.  En **el Explorador de soluciones**, elija la **SimpleMathVSIX** proyecto.  
  
8.  En la barra de menús, elija **proyecto**, **Agregar nuevo elemento**.  
  
9. En la lista de **elementos comunes**, expanda **datos**y, a continuación, elija **archivo XML**.  
  
10. En el **nombre** , especifique `SDKManifest.xml`y, a continuación, elija la **agregar** botón.  
  
11. En **el Explorador de soluciones**, abra el menú contextual de `SDKManifest.xml`, elija **propiedades**y, a continuación, cambie el valor de la **incluir en VSIX** propiedad **True**.  
  
12. Sustituye el contenido del archivo por el siguiente código XML:  

    **C#**
    ```xml
    <FileList
      DisplayName="WinRT Math Library (CS)"
      MinVSVersion="11.0"
      TargetFramework=".NETCore,version=v4.5"
      AppliesTo="WindowsAppContainer"
      SupportsMultipleVersions="Error"
      MoreInfo="http://www.msdn.microsoft.com/">
    </FileList>
    ```

    **Visual Basic**
    ```xml
    <FileList
      DisplayName="WinRT Math Library (VB)"
      MinVSVersion="11.0"
      TargetFramework=".NETCore,version=v4.5"
      AppliesTo="WindowsAppContainer"
      SupportsMultipleVersions="Error"
      MoreInfo="http://www.msdn.microsoft.com/">
    </FileList>
    ```  
  
13. En **el Explorador de soluciones**, abra el menú contextual para el **SimpleMathVSIX** del proyecto, elija **agregar**y, a continuación, elija **nueva carpeta**.  
  
14. Cambiar el nombre de la carpeta `references`.  
  
15. Abra el menú contextual para el **referencias** carpeta, elija **agregar**y, a continuación, elija **nueva carpeta**.  
  
16. Cambiar el nombre de la subcarpeta de `commonconfiguration`, cree una subcarpeta dentro de él y el nombre de la subcarpeta `neutral`.  
  
17. Repita los cuatro pasos anteriores, esta vez para cambiar el nombre de la primera carpeta a `redist`.  
  
     El proyecto contiene ahora la estructura de carpetas siguiente:  
  
    ```
    references\commonconfiguration\neutral  
    redist\commonconfiguration\neutral  
    ```  
  
18. En **el Explorador de soluciones**, abra el menú contextual para el **SimpleMath** del proyecto y, a continuación, elija **Abrir carpeta en el Explorador de archivos**.  
  
19. En **Explorador de archivos**, navegue hasta la carpeta bin\Release, abra el menú contextual para el archivo SimpleMath.winmd y, a continuación, elija **copia**.  
  
20. En **el Explorador de soluciones**, pegue el archivo en la carpeta references\commonconfiguration\neutral en la **SimpleMathVSIX** proyecto.  
  
21. Repita el paso anterior, pegue el archivo SimpleMath.pri en la carpeta redist\commonconfiguration\neutral en la **SimpleMathVSIX** proyecto.  
  
22. En **el Explorador de soluciones**, elija **SimpleMath.winmd**.  
  
23. En la barra de menús, elija **vista**, **propiedades** (teclado: elija la tecla F4).  
  
24. En el **propiedades** ventana, cambiar la **acción de compilación** propiedad **contenido**y, a continuación, cambie la **incluir en VSIX** propiedad **True**.  
  
25. En **el Explorador de soluciones**, repita este proceso para **SimpleMath.pri**.  
  
26. En **el Explorador de soluciones**, elija la **SimpleMathVSIX** proyecto.  
  
27. En la barra de menús, elija **crear**, **SimpleMathVSIX de compilación**.  
  
28. En **el Explorador de soluciones**, abra el menú contextual para el **SimpleMathVSIX** del proyecto y, a continuación, elija **Abrir carpeta en el Explorador de archivos**.  
  
29. En **Explorador de archivos**, navegue hasta la carpeta \bin\Release y, a continuación, ejecute SimpleMathVSIX.vsix para instalarlo.  
  
30. Elija la **instalar** botón, espere a que finalice la instalación y, a continuación, reinicie Visual Studio.  
  
##  <a name="a-namecreatesamplea-to-create-a-sample-app-that-uses-the-class-library"></a><a name="createSample"></a>Para crear una aplicación de ejemplo que utiliza la biblioteca de clases  
  
1.  En la barra de menús, elija **archivo**, **nueva**, **nuevo proyecto**.  
  
2.  En la lista de plantillas, expanda **Visual C#** o **Visual Basic**y, a continuación, elija la **tienda Windows** nodo.  
  
3.  Elija la **aplicación vacía** plantilla, el nombre del proyecto **ArithmeticUI**y, a continuación, elija la **Aceptar** botón.  
  
4.  En **el Explorador de soluciones**, abra el menú contextual para el **ArithmeticUI** del proyecto y, a continuación, elija **agregar**, **referencia**.  
  
5.  En la lista de tipos de referencia, expanda **Windows**y, a continuación, elija **extensiones**.  
  
6.  En el panel de detalles, elija la **SDK matemática Simple** extensión.  
  
     Muestra información adicional sobre el SDK. Puede elegir la **información más** vínculo para abrir http://www.msdn.microsoft.com, tal como especifica en el archivo SDKManifest.xml anteriormente en este tutorial.  
  
7.  En el **Administrador de referencias** cuadro de diálogo, seleccione la **SDK matemática Simple** y, a continuación, elija la **Aceptar** botón.  
  
8.  En la barra de menús, elija **vista**, **Examinador de objetos**.  
  
9. En el **examinar** , elija **Simple cálculo matemático**.  
  
     Ahora puede explorar Novedades en el SDK.  
  
10. En **el Explorador de soluciones**, abra MainPage.xaml y reemplace su contenido por el siguiente código XAML:  

    **C#**
    ```xml
    <Page
        x:Class="WinRTMathTestCS.MainPage"
        IsTabStop="False"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:local="using:WinRTMathTestCS"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d">

        <Grid Background="{StaticResource ApplicationPageBackgroundThemeBrush}">
            <TextBox x:Name="_firstNumber" HorizontalAlignment="Left" Margin="414,370,0,0" TextWrapping="Wrap" Text="First Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <TextBox x:Name="_secondNumber" HorizontalAlignment="Left" Margin="613,370,0,0" TextWrapping="Wrap" Text="Second Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <Button Content="+" HorizontalAlignment="Left" Margin="557,301,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="-" HorizontalAlignment="Left" Margin="557,345,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="*" HorizontalAlignment="Left" Margin="557,389,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="/" HorizontalAlignment="Left" Margin="557,433,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="=" HorizontalAlignment="Left" Margin="755,367,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnResultsClick"/>
            <TextBox x:Name="_result" HorizontalAlignment="Left" Margin="809,370,0,0" TextWrapping="Wrap" Text="Result" VerticalAlignment="Top" Height="32" Width="163" TextAlignment="Center" IsReadOnly="True"/>
        </Grid>
    </Page>
    ```
    
    **Visual Basic**
    ```xml
    <Page
        x:Class="WinRTMathTest.MainPage"
        IsTabStop="False"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:local="using:WinRTMathTest"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d">

        <Grid Background="{StaticResource ApplicationPageBackgroundThemeBrush}">
            <TextBox x:Name="_firstNumber" HorizontalAlignment="Left" Margin="414,370,0,0" TextWrapping="Wrap" Text="First Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <TextBox x:Name="_secondNumber" HorizontalAlignment="Left" Margin="613,370,0,0" TextWrapping="Wrap" Text="Second Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <Button Content="+" HorizontalAlignment="Left" Margin="557,301,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="-" HorizontalAlignment="Left" Margin="557,345,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="*" HorizontalAlignment="Left" Margin="557,389,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="/" HorizontalAlignment="Left" Margin="557,433,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="=" HorizontalAlignment="Left" Margin="755,367,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnResultsClick"/>
            <TextBox x:Name="_result" HorizontalAlignment="Left" Margin="809,370,0,0" TextWrapping="Wrap" Text="Result" VerticalAlignment="Top" Height="32" Width="163" TextAlignment="Center" IsReadOnly="True"/>
        </Grid>
    </Page>
    ```
  
11. Actualizar MainPage.xaml.cs para que coincida con el código siguiente:  
  
     [!code-cs[CreatingAnSDKUsingWinRTDemoApp&#2;](../extensibility/codesnippet/CSharp/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_5.cs) ] 
     [!code-vb [CreatingAnSDKUsingWinRTDemoApp&2;](../extensibility/codesnippet/VisualBasic/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_5.vb)]  
  
12. Elija la tecla F5 para ejecutar la aplicación.  
  
13. En la aplicación, escriba los dos números, elegir una operación y, a continuación, elija la ** = ** botón.  
  
     Aparecerá el resultado correcto.  
  
 Ha creado y utilizado un SDK de extensión.  
  
## <a name="see-also"></a>Vea también  
 [Tutorial: Crear un SDK con C++](../extensibility/walkthrough-creating-an-sdk-using-cpp.md)   
 [Tutorial: Crear un SDK con JavaScript](http://msdn.microsoft.com/en-us/6195ff56-4a27-45fc-bd29-4b0451225f4b)   
 [Crear un Kit de desarrollo de Software](../extensibility/creating-a-software-development-kit.md)