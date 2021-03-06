---
title: Campos de la ventana de propiedades e Interfaces | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: Properties window, fields and interfaces
ms.assetid: 0328f0e5-2380-4a7a-a872-b547cb775050
caps.latest.revision: "12"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 1f238cceb189723e3ec10fbf8db4abbd9675ae21
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="properties-window-fields-and-interfaces"></a>Interfaces y campos de la ventana de propiedades
El modelo de selección determinar qué información se muestra en el **propiedades** ventana se basa en la ventana que tiene el foco en el IDE. Cada ventana y el objeto dentro de la ventana seleccionada, pueden tener su objeto de contexto de selección insertado en el contexto de selección global. El entorno actualiza el contexto de selección global con los valores de un marco de ventana cuando esa ventana tiene el foco. Al cambiar el foco, hace que el contexto de selección.  
  
## <a name="tracking-selection-in-the-ide"></a>Selección de seguimiento en el IDE  
 El marco de ventana o el sitio, el IDE, propiedad tiene un servicio denominado <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection>. Los pasos siguientes muestran cómo un cambio en una selección, causada por el usuario cambia el foco a otra ventana abierta o seleccionar un elemento de proyecto diferente en **el Explorador de soluciones**, se implementa para modificar el contenido mostrado en el  **Propiedades** ventana.  
  
1.  El objeto creado por el VSPackage que se sitúa en las llamadas de la ventana seleccionada <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A> tener <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection> invocar <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection>.  
  
2.  El contenedor de selección, proporcionado por la ventana seleccionada, se crea su propio <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> objeto. Cuando la selección cambia, el VSPackage llama <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange%2A> para notificar a los agentes de escucha en el entorno, incluida la **propiedades** ventana, el cambio de. También proporciona acceso a la información de jerarquía y elementos relacionados con la nueva selección.  
  
3.  Al llamar a <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange%2A> y pasar los elementos de la jerarquía seleccionada en el `VSHPROPID_BrowseObject` parámetro rellena la <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> objeto.  
  
4.  Un objeto derivado de la [interfaz IDispatch](https://msdn.microsoft.com/library/windows/desktop/ms221608.aspx) se devuelve para <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID> para el elemento solicitado, y el entorno ajusta en un <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> (vea el paso siguiente). Si se produce un error en la llamada, el entorno hace que una segunda llamada a `IVsHierarchy::GetProperty`, pasándole el contenedor de selección <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID> que proporcionan el elemento de la jerarquía o elementos.  
  
     El proyecto de VSPackage no crea <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> porque la ventana proporcionado por el entorno de VSPackage que implemente (por ejemplo, **el Explorador de soluciones**) construye <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> en su nombre.  
  
5.  El entorno invoca los métodos de <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> para obtener los objetos según el `IDispatch` interfaz en blanco para igualar la **propiedades** ventana.  
  
 Cuando un valor de la **propiedades** ventana se cambia, implemente VSPackages `IVsTrackSelectionEx::OnElementValueChangeEx` y `IVsTrackSelectionEx::OnSelectionChangeEx` para notificar el cambio en el valor del elemento. A continuación, se invoca el entorno <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> o <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer> para mantener la información mostrada en el **propiedades** ventana sincronizada con los valores de propiedad. Para obtener más información, consulte [actualizar valores de propiedad en la ventana propiedades](#updating-property-values-in-the-properties-window).  
  
 Además de seleccionar otro elemento de proyecto en **el Explorador de soluciones** para mostrar las propiedades relacionadas con ese elemento, también puede elegir un objeto diferente desde dentro de una ventana de formulario o el documento mediante la lista desplegable disponible en el **Propiedades** ventana. Para obtener más información, consulte [lista de objetos de ventana de propiedades](../../extensibility/internals/properties-window-object-list.md).  
  
 Puede cambiar la forma en que se muestra información en el **propiedades** cuadrícula de la ventana de alfabético en categorías, y, si está disponible, también puede abrir una página de propiedades de un objeto seleccionado, haga clic en los botones apropiados en el  **Propiedades** ventana. Para obtener más información, consulte [botones de la ventana de propiedades](../../extensibility/internals/properties-window-buttons.md) y [páginas de propiedades](../../extensibility/internals/property-pages.md).  
  
 Por último, la parte inferior de la **propiedades** ventana también contiene una descripción del campo seleccionado en el **propiedades** cuadrícula de la ventana. Para obtener más información, consulte [obtener descripciones de los campos de la ventana propiedades](#getting-field-descriptions-from-the-properties-window).  
  
## <a name="updating-property-values-in-the-properties-window"></a>Actualizar valores de propiedad en la ventana Propiedades
Existen dos maneras de mantener la ventana **Propiedades** sincronizada con los cambios de valores de propiedad. La primera consiste en llamar a la <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interfaz, que proporciona acceso a la funcionalidad básica basada en ventanas, incluidos el acceso y la creación de ventanas de documento y de herramientas proporcionada el entorno. Los pasos siguientes describen este proceso de sincronización.  
  
### <a name="updating-property-values-using-ivsuishell"></a>Actualización de los valores de propiedad mediante IVsUIShell  
  
#### <a name="to-update-property-values-using-the-ivsuishell-interface"></a>Para actualizar los valores de propiedad mediante la interfaz IVsUIShell  
  
1.  Llame a <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> (a través de <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell> servicio) cada vez que paquetes VSPackage, proyectos, o editores necesiten crear o enumerar las ventanas de documentos o la herramienta.  
  
2.  Implemente <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.RefreshPropertyBrowser%2A> para mantener la **propiedades** ventana sincronizada con los cambios de propiedad para un proyecto (o cualquier otro objeto seleccionado que se esté explorando por la **propiedades** ventana) sin necesidad de implementar <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer> dispara <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink.OnChanged%2A> eventos.  
  
3.  Implementar la <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> métodos <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.AdviseHierarchyEvents%2A> y <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.UnadviseHierarchyEvents%2A> para establecer y deshabilitar, respectivamente, la notificación de cliente de los eventos de jerarquía sin necesidad de la jerarquía para implementar <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer>.  
  
### <a name="updating-property-values-using-iconnection"></a>Actualización de los valores de propiedad mediante IConnection  
 La segunda manera de mantener la ventana **Propiedades** sincronizada con los cambios de valores de propiedad consiste en implementar `IConnection` en el objeto conectable para indicar la existencia de las interfaces de salida. Si desea localizar el nombre de propiedad, derive su objeto de <xref:System.ComponentModel.ICustomTypeDescriptor>. El <xref:System.ComponentModel.ICustomTypeDescriptor> implementación puede modificar los descriptores de propiedades que se devuelve y cambiar el nombre de una propiedad. Para localizar la descripción, cree un atributo que se deriva de <xref:System.ComponentModel.DescriptionAttribute> e invalidar la propiedad Description.  
  
#### <a name="considerations-in-implementing-the-iconnection-interface"></a>Consideraciones de la implementación de la interfaz IConnection  
  
1.  `IConnection`proporciona acceso a un subobjeto enumerador con el <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interfaz. También proporciona acceso a todas las conexiones subobjetos del punto, cada uno de los cuales implementa la <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interfaz.  
  
2.  Cualquier objeto de búsqueda es responsable de implementar un <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink> eventos. La ventana **Propiedades** aconsejará sobre el evento establecido a través de `IConnection`.  
  
3.  Un punto de conexión controla cuántas conexiones (uno o más) permite en su implementación de <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.Advise%2A>. Puede devolver un punto de conexión que permite solo una interfaz <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL> desde el <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.EnumConnections%2A> método.  
  
4.  Un cliente puede llamar a la `IConnection` interfaz para obtener acceso a un subobjeto enumerador con el <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interfaz. El <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interfaz, a continuación, se puede llamar para enumerar los puntos de conexión para cada salida identificador de interfaz (IID).  
  
5.  `IConnection`También se puede llamar para obtener acceso a los objetos secundarios de punto de conexión con el <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interfaz para cada IID saliente. A través de la <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interfaz, un cliente inicia o termina un bucle de asesoría con el objeto conectable y la sincronización del cliente. El cliente puede llamar a la <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interfaz para obtener un objeto enumerador con el <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnections> interfaz para enumerar las conexiones que conoce.  
  
## <a name="getting-field-descriptions-from-the-properties-window"></a>Obtener descripciones de los campos de la ventana Propiedades
En la parte inferior de la ventana **Propiedades** , un área de descripción muestra información relacionada con el campo de la propiedad seleccionada. Esta característica está activada de forma predeterminada. Si quiere ocultar el campo de descripción, haga clic con el botón derecho en la ventana **Propiedades** y haga clic en **Descripción**. Al hacerlo, también se quita la marca de verificación junto al título **Descripción** de la ventana de menú. Puede volver a mostrar el campo siguiendo los mismos pasos para volver a activar **Descripción** .  
  
 La información contenida en el campo descripción proviene <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo>. Cada método, interfaz, coclase, etc. puede tener un atributo `helpstring` sin localizar en la biblioteca de tipos. El **propiedades** ventana recupera la cadena de <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo.GetDocumentation%2A>.  
  
### <a name="to-specify-localized-help-strings"></a>Para especificar cadenas de ayuda localizadas  
  
1.  Agregue el atributo `helpstringdll` a la instrucción de la biblioteca en la biblioteca de tipos (`typelib`).  
  
    > [!NOTE]
    >  Este paso es opcional si la biblioteca de tipos está en un archivo de biblioteca de objetos (.olb).  
  
2.  Especifique atributos `helpstringcontext` para las cadenas. También puede especificar atributos `helpstring` .  
  
     Estos atributos son distintos de los atributos `helpfile` y `helpcontext` , que se encuentran en los temas de Ayuda del archivo .chm real.  
  
 Para recuperar la información de descripción que se mostrará para el nombre de la propiedad resaltada, la **propiedades** ventana llamadas <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2.GetDocumentation2%2A> para la propiedad que se selecciona, especifica lo que se desea `lcid` de atributo para el cadena de salida. Internamente, <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2> busca el archivo .dll especificado en el `helpstringdll` atributo y llamadas `DLLGetDocumentation` en dicho archivo .dll con el contexto especificado y `lcid` atributo.  
  
 La signatura y la implementación de `DLLGetDocumentation` son:  
  
```cpp  
STDAPI DLLGetDocumentation  
(  
   ITypeLib * /* ptlib */,  
   ITypeInfo * /* ptinfo */,  
   LCID /* lcid */,  
   DWORD dwCtx,  
   BSTR * pbstrHelpString  
);  
```  
  
 La función `DLLGetDocumentation` debe ser una exportación definida en el archivo .def para la DLL.  
  
 Internamente, se crea un archivo .olb, que en realidad es una DLL. Esta DLL contiene un recurso, el archivo de biblioteca de tipos (.tlb) y una función exportada, `DLLGetDocumentation`.  
  
 En el caso de los archivos .olb, el atributo `helpstringdll` es opcional porque es el mismo archivo que contiene el propio archivo .tlb.  
  
 Para obtener cadenas que aparezcan en el panel **Descripciones** , por tanto, lo mínimo que debe hacer es especificar el atributo `helpstring` en la biblioteca de tipos. Si quiere que estas cadenas se localicen, debe especificar el atributo `helpstringdll` (opcional) y el atributo `helpstringcontext` (obligatorio) e implementar `DLLGetDocumentation`.  
  
 No hay interfaces adicionales que deban implementarse al obtener información localizada a través del atributo `helpstringcontext` y la función `DLLGetDocumentation`del archivo .idl.  
  
 Otra manera de obtener el nombre traducido y la descripción de una propiedad que se está implementando <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.GetLocalizedPropertyInfo%2A>. Para obtener más información sobre la implementación de este método, consulte [campos de la ventana de propiedades e Interfaces](../../extensibility/internals/properties-window-fields-and-interfaces.md).  

## <a name="see-also"></a>Vea también  
 [Extensión de propiedades](../../extensibility/internals/extending-properties.md)