---
title: "Cómo: obtener acceso a las fuentes integradas y la combinación de colores | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- fonts, accessing built-in
- font and color control [Visual Studio SDK], categories
- colors, accessing built-in schemes
ms.assetid: 6905845e-e88e-4805-adcf-21da39108ec7
caps.latest.revision: "23"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: c5d8af96857fa3e3c02ce8ea29711eaffbb532e9
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-access-the-built-in-fonts-and-color-scheme"></a>Cómo: obtener acceso a las fuentes integradas y la combinación de colores
El entorno de desarrollo integrado (IDE) de Visual Studio tiene un esquema de fuentes y colores que está asociado a la ventana del editor. Puede tener acceso a este esquema a través de la <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interfaz.  
  
 Para usar las fuentes integradas y la combinación de colores, un VSPackage debe:  
  
-   Definir una categoría que se va a usar con el servicio de fuentes y colores de forma predeterminada.  
  
-   Registre la categoría con el servidor de fuentes y colores de forma predeterminada.  
  
-   Indicar que al IDE que una ventana específica utiliza las categorías y elementos de pantalla integrado utilizando la `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer` y `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer` interfaces.  
  
 El IDE usa la categoría resultante como un identificador de la ventana. Nombre de la categoría se muestra en el **mostrar valores para:** cuadro de lista desplegable en el **fuentes y colores** página de propiedades.  
  
### <a name="to-define-a-category-using-built-in-fonts-and-colors"></a>Para definir una categoría con colores y fuentes integradas  
  
1.  Crear un GUID arbitrario.  
  
     Este GUID se utiliza para identificar de forma exclusiva una categoría**.** Esta categoría reutiliza la especificación de colores y fuentes de forma predeterminada del IDE.  
  
    > [!NOTE]
    >  Cuando se recuperan datos de fuente y color con el <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents> o de otras interfaces, VSPackages usan este GUID para hacer referencia a información integrado.  
  
2.  Nombre de la categoría debe agregarse a una tabla de cadenas en archivo de recursos (.rc) de VSPackage, por lo que puede localizarse según sea necesario cuando se muestran en el IDE.  
  
     Para obtener más información, consulte [adición o eliminación de una cadena](/cpp/windows/adding-or-deleting-a-string).  
  
### <a name="to-register-a-category-using-built-in-fonts-and-colors"></a>Para registrar una categoría de uso de colores y fuentes integradas  
  
1.  Construir un tipo especial de entrada de registro de la categoría en la siguiente ubicación:  
  
     [HKLM\SOFTWARE\Microsoft \Visual Studio\\*\<versión de Visual Studio >*\FontAndColors\\*\<categoría >*]  
  
     *\<Categoría >* es el nombre no traducido de la categoría.  
  
2.  Rellenar el registro para usar las fuentes estándar y la combinación de colores con cuatro valores:  
  
    |nombre|Tipo|Datos|Descripción|  
    |----------|----------|----------|-----------------|  
    |Categoría|REG_SZ|GUID|Un GUID arbitrario que identifica una categoría que contiene el esquema estándar de fuente y color.|  
    |Package|REG_SZ|GUID|{F5E7E71D-1401-11D1-883B-0000F87579D2}<br /><br /> Este GUID se usa por todos los VSPackages que usar las configuraciones de fuente y color predeterminado.|  
    |NameID|REG_DWORD|Id.|El identificador de recurso de nombre de categoría localizables en el VSPackage.|  
    |ToolWindowPackage|REG_SZ|GUID|El GUID del paquete de VS que implementa el <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interfaz.|  
  
3.  
  
### <a name="to-initiate-the-use-of-system-provided-fonts-and-colors"></a>Para iniciar el uso de colores y fuentes proporcionados por el sistema  
  
1.  Cree una instancia de la `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer` interfaz como parte de la implementación y la inicialización de la ventana.  
  
2.  Llame a la <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer.GetPropertyCategory%2A> método para obtener una instancia de la `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer` interfaz correspondiente a la actual <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> instancia.  
  
3.  Llamar a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty%2A> dos veces.  
  
    -   Llamar una vez con `VSEDITPROPID_ViewGeneral_ColorCategory`como un argumento.  
  
    -   Llamar una vez con `VSEDITPROPID_ViewGeneral_FontCategory` como un argumento.  
  
     Esto establece y expone los servicios de fuentes y colores de forma predeterminada como una propiedad de la ventana.  
  
## <a name="example"></a>Ejemplo  
 En el ejemplo siguiente se inicia el uso de colores y fuentes integradas.  
  
```  
CComVariant vt;  
CComQIPtr<IVsTextEditorPropertyCategoryContainer> spPropCatContainer(m_spView);  
if (spPropCatContainer != NULL){  
    CComPtr<IVsTextEditorPropertyContainer> spPropContainer;  
    if (SUCCEEDED(spPropCatContainer->GetPropertyCategory(GUID_EditPropCategory_View_MasterSettings,   
                                                          &spPropContainer))){  
        CComVariant vt;CComVariant VariantGUID(bstrGuidText);  
        spPropContainer->SetProperty(VSEDITPROPID_ViewGeneral_FontCategory, VariantGUID);  
        spPropContainer->SetProperty(VSEDITPROPID_ViewGeneral_ColorCategory, VariantGUID);  
    }  
}  
```  
  
## <a name="see-also"></a>Vea también  
 [Utilizar fuentes y colores](../extensibility/using-fonts-and-colors.md)   
 [Obtención de fuente y la información de Color para el color de texto](../extensibility/getting-font-and-color-information-for-text-colorization.md)   
 [Obtener acceso a la configuración de Color y fuente almacenado](../extensibility/accessing-stored-font-and-color-settings.md)   
 [Información general de Color y fuente](../extensibility/font-and-color-overview.md)