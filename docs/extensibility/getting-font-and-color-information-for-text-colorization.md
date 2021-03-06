---
title: "Obtener información de Color para los colores de texto y de fuente | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- text, coloring
- font and color control [Visual Studio SDK], coloring
ms.assetid: d1f985bd-743e-40b7-9458-d9af53647c91
caps.latest.revision: "22"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 97b97b6a79ac93dd614cf6557d338d5f0398192e
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="getting-font-and-color-information-for-text-colorization"></a>Obtención de fuente y la información de Color para el color de texto
El proceso que se representa o se muestra texto de los elementos de interfaz de usuario depende del tipo de las preferencias del proyecto, su tecnología y developer. El **fuentes y colores** página de propiedades almacena la configuración.  
  
 Necesita la mayoría de las implementaciones que muestran texto los el `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults` y asociados de interfaces para la configuración de pantalla de presentación, recuperar y almacenar texto.  
  
> [!NOTE]
>  Al personalizar el editor principal (que admite la **EditorCategory de texto**), se recomienda encarecidamente que utilice la tecnología de color en el servicio de lenguaje. Para obtener más información, consulte [información general de Color y fuente](../extensibility/font-and-color-overview.md).  
  
## <a name="getting-default-font-and-color-information"></a>Obtener información de Color y fuente predeterminada  
 Todas la **fuentes y colores** deben especificar los valores de las ventanas de mostrar texto en el **elementos para mostrar** de uno **categoría**. Para obtener más información, consulte [fuentes y colores, entorno, cuadro de diálogo Opciones](../ide/reference/fonts-and-colors-environment-options-dialog-box.md).  
  
 Para colorear, un VSPackage debe obtener actual **fuentes y colores** configuración. Un VSPackage puede hacerlo en las formas siguientes, dependiendo de sus necesidades:  
  
-   Usar el mecanismo de persistencia de fuente y color para recuperar el estado almacenado o actual. Para obtener más información, consulte [acceso a fuentes almacenados y la configuración de Color](../extensibility/accessing-stored-font-and-color-settings.md).  
  
-   Use la <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider> interfaz de un servicio que proporciona datos de fuente y color para obtener una instancia de <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>, si el VSPackage no es también el proveedor de fuente y color.  
  
-   Implementar la interfaz <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents>.  
  
 Para asegurarse de que los resultados obtenidos mediante sondeo están actualizadas, puede ser útil usar la <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager> interfaz para determinar si se necesita una actualización antes de llamar a los métodos de recuperación de la <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage> interfaz.  
  
 Después de ha obtenido información de fuente y color, analice el texto que se mostrará para identificar elementos que requieren la coloración y, a continuación, muestra el texto en la ventana con las fuentes adecuadas y los colores.  
  
## <a name="see-also"></a>Vea también  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>   
 [Utilizar fuentes y texto](/dotnet/framework/winforms/advanced/using-fonts-and-text)   
 [Trabajar con colores](/cpp/windows/working-with-color-image-editor-for-icons)   
 [GDI (interfaz de dispositivo gráfico)](http://msdn.microsoft.com/en-us/7e1d4540-bb2e-4257-8eee-eee376acba83)