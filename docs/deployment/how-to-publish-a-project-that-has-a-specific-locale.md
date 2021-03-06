---
title: "Cómo: publicar un proyecto que tiene una configuración regional específica | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-deployment
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- publishing, localized projects
- locales, publishing for
- deploying applications [ClickOnce], localized projects
- locales, deploying for
- publishing localized projects
- macros, deploying with
- macros, publishing with
ms.assetid: 7c4cd83a-f985-4c85-9022-fadb5dbd2b39
caps.latest.revision: "11"
author: stevehoag
ms.author: shoag
manager: wpickett
ms.workload: multiple
ms.openlocfilehash: b2560275ae08a9a860d62f11e0fb011e5e7a5b31
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-publish-a-project-that-has-a-specific-locale"></a>Cómo: Publicar un proyecto que tiene una configuración regional específica
No es raro que una aplicación contenga componentes con diferentes configuraciones regionales. En este escenario, crearía una solución con varios proyectos para después publicar diferentes proyectos para cada configuración regional. En este procedimiento se muestra cómo usar una macro para publicar el primer proyecto en una solución usando la configuración regional 'en'. Si quiere intentar este procedimiento con una configuración regional que no sea 'en', asegúrese de establecer `localeString` de manera que coincida con la configuración regional que está usando (por ejemplo, 'de' o 'de-DE').  
  
> [!NOTE]
>  Cuando se usa esta macro, la ubicación de publicación debe ser una dirección URL o un recurso compartido UNC (Convención de nomenclatura universal) válidos. Además, Internet Information Services (IIS) debe estar instalado en el equipo. Para instalar IIS, en la **iniciar** menú, haga clic en **el Panel de Control**. Haga doble clic en **agregar o quitar programas**. En **agregar o quitar programas**, haga clic en **agregar o quitar componentes de Windows**. En el **Asistente para componentes de Windows**, seleccione la **Internet Information Services (IIS)** casilla de verificación en la **componentes** lista. A continuación, haga clic en **finalizar** para cerrar el asistente.  
  
### <a name="to-create-the-publishing-macro"></a>Para crear la macro de publicación  
  
1.  Para abrir el Explorador de macros, en la **herramientas** menú, elija **Macros**y, a continuación, haga clic en **Explorador de macros**.  
  
2.  Crear un nuevo módulo de macros. En el Explorador de macros, seleccione **MyMacros**. En el **herramientas** menú, elija **Macros**y, a continuación, haga clic en **nuevo módulo de macros**. Nombre del módulo **PublishSpecificCulture**.  
  
3.  En el Explorador de macros, expanda la **MyMacros** nodo y, a continuación, abra el **PublishAllProjects** módulo haciendo doble clic en él (o, en el **herramientas** menú, seleccione **Macros**y, a continuación, haga clic en **IDE de Macros**).  
  
4.  En el IDE de macros, agregue el siguiente código al módulo, después de las instrucciones `Import`:  
  
    ```vb  
    Module PublishSpecificCulture  
        Sub PublishProjectFirstProjectWithEnLocale()  
            ' Note: You should publish projects by using the IDE at least once  
            ' before you use this macro. Items such as the certficate and the   
            ' security zone must be set.  
            Dim localeString As String = "en"  
  
            ' Get first project.  
            Dim proj As Project = DTE.Solution.Projects.Item(1)  
            Dim publishProperties As Object = proj.Properties.Item("Publish").Value  
  
            ' GenerateManifests and SignManifests must always be set to  
            ' True for publishing to work.   
            proj.Properties.Item("GenerateManifests").Value = True  
            proj.Properties.Item("SignManifests").Value = True  
  
            'Set the publish language.  
            'This will set the deployment language and pick up all   
            ' en resource dlls:  
            Dim originalTargetCulture As String = _  
                publishProperties.Item("TargetCulture").Value  
            publishProperties.Item("TargetCulture").Value = localeString  
  
            'Append 'en' to end of publish, install, and update URLs if needed:  
            Dim originalPublishUrl As String = _  
                publishProperties.Item("PublishUrl").Value  
            Dim originalInstallUrl As String = _  
                publishProperties.Item("InstallUrl").Value  
            Dim originalUpdateUrl As String = _  
                publishProperties.Item("UpdateUrl").Value  
            publishProperties.Item("PublishUrl").Value = _  
                AppendStringToUrl(localeString, New Uri(originalPublishUrl))  
            If originalInstallUrl <> String.Empty Then  
                publishProperties.Item("InstallUrl").Value = _  
                    AppendStringToUrl(localeString, New Uri(originalInstallUrl))  
            End If  
            If originalUpdateUrl <> String.Empty Then  
                publishProperties.Item("UpdateUrl").Value = _  
                    AppendStringToUrl(localeString, New Uri(originalUpdateUrl))  
            End If  
            proj.Save()  
  
            Dim slnbld2 As SolutionBuild2 = _  
                CType(DTE.Solution.SolutionBuild, SolutionBuild2)  
            slnbld2.Clean(True)  
  
            slnbld2.BuildProject( _  
            proj.ConfigurationManager.ActiveConfiguration.ConfigurationName, _  
            proj.UniqueName, True)  
  
            ' Only publish if build is successful.  
            If slnbld2.LastBuildInfo <> 0 Then  
                MsgBox("Build failed for " & proj.UniqueName)  
            Else  
                slnbld2.PublishProject( _  
                proj.ConfigurationManager.ActiveConfiguration.ConfigurationName, _  
                proj.UniqueName, True)  
                If slnbld2.LastPublishInfo = 0 Then  
                    MsgBox("Publish succeeded for " & proj.UniqueName _  
                    & vbCrLf & "." _  
                    & " Publish Language was '" & localeString & "'.")  
                Else  
                    MsgBox("Publish failed for " & proj.UniqueName)  
                End If  
            End If  
  
            ' Return URLs and target culture to their previous state.  
            publishProperties.Item("PublishUrl").Value = originalPublishUrl  
            publishProperties.Item("InstallUrl").Value = originalInstallUrl  
            publishProperties.Item("UpdateUrl").Value = originalUpdateUrl  
            publishProperties.Item("TargetCulture").Value = originalTargetCulture  
            proj.Save()  
        End Sub  
  
        Private Function AppendStringToUrl(ByVal str As String, _  
        ByVal baseUri As Uri) As String  
            Dim returnValue As String = baseUri.OriginalString  
            If baseUri.IsFile OrElse baseUri.IsUnc Then  
                returnValue = IO.Path.Combine(baseUri.OriginalString, str)  
            Else  
                If Not baseUri.ToString.EndsWith("/") Then  
                    returnValue = baseUri.OriginalString & "/" & str  
                Else  
                    returnValue = baseUri.OriginalString & str  
                End If  
            End If  
            Return returnValue  
        End Function  
    End Module  
    ```  
  
5.  Cierre el IDE de macros. El foco volverá a Visual Studio.  
  
### <a name="to-publish-a-project-for-a-specific-locale"></a>Para publicar un proyecto para una configuración regional específica  
  
1.  Para crear un proyecto de aplicación de Windows de Visual Basic, en el **archivo** menú, elija **New**y, a continuación, haga clic en **proyecto**.  
  
2.  En el **nuevo proyecto** cuadro de diálogo, seleccione **aplicación de Windows** desde el **Visual Basic** nodo. Denomine el proyecto **PublishLocales**.  
  
3.  Haga clic en Form1. En el **propiedades** ventana, en **diseño**, cambie la **lenguaje** propiedad de **(predeterminado)** a **inglés**. Cambiar el **texto** propiedad del formulario para **MyForm**.  
  
     Tenga en cuenta que los archivos DLL de recursos localizados no se crean hasta que se necesitan. Por ejemplo, se crean cuando se cambia el texto del formulario o uno de sus controles después de haber especificado la nueva configuración regional.  
  
4.  Publique PublishLocales usando el IDE de Visual Studio.  
  
     En **el Explorador de soluciones**, seleccione PublishLocales. En el **proyecto** menú, seleccione **propiedades**. En el Diseñador de proyectos, en la **publicar** página, especifique una ubicación de publicación de **http://localhost/PublishLocales**y, a continuación, haga clic en **publicar ahora**.  
  
     Cuando la página web de publicación aparezca, ciérrela. (En este paso, solo tiene que publicar el proyecto, no tiene que instalarlo).  
  
5.  Publique PublishLocales de nuevo invocando la macro en la ventana del símbolo del sistema de Visual Studio. Para ver la ventana de símbolo del sistema, en la **vista** menú, elija **otras ventanas** y, a continuación, haga clic en **ventana de comandos**, o presione CTRL + ALT + A. En la ventana de símbolo del sistema, escriba `macros`; Autocompletar proporcionará una lista de las macros disponibles. Seleccione la macro siguiente y presione ENTRAR:  
  
     `Macros.MyMacros.PublishSpecificCulture.PublishProjectFirstProjectWithEnLocale`  
  
6.  Cuando el proceso de publicación se realiza correctamente, generará el mensaje que indica "Publicación realizada correctamente para PublishLocales\PublishLocales.vbproj. El idioma de publicación era 'en'". Haga clic en **Aceptar** en el cuadro de mensaje. Cuando aparezca la página Web de publicación, haga clic en **instalar**.  
  
7.  Mire en C:\Inetpub\wwwroot\PublishLocales\en. Deberá ver los archivos instalados, como los manifiestos, setup.exe y el archivo de la página web de publicación, además del archivo DLL de recursos localizados. (De forma predeterminada ClickOnce anexa una extensión .deploy a los archivos EXE y DLL; puede quitar esta extensión después de la implementación).  
  
## <a name="see-also"></a>Vea también  
 [Publicar aplicaciones ClickOnce](../deployment/publishing-clickonce-applications.md)   
 [Entorno de desarrollo de macros](http://msdn.microsoft.com/en-us/d23105d8-34fe-4ad9-8278-fae2c660aeac)   
 [Ventana Explorador de macros](http://msdn.microsoft.com/en-us/762169e6-f83f-44b4-bffa-d0f107cae9a3)   
 [Cómo: editar y crear Macros mediante programación](http://msdn.microsoft.com/en-us/6716f820-1feb-48ad-a718-27eb6b473c5a)