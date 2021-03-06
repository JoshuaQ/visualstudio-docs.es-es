---
title: Conservar la propiedad de un elemento de proyecto | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- properties, adding to a project item
- project items, adding properties
ms.assetid: d7a0f2b0-d427-4d49-9536-54edfb37c0f3
caps.latest.revision: "7"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: e732821cf1ea14497038a65d49f2a10ce22c28a5
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="persisting-the-property-of-a-project-item"></a>Conservar la propiedad de un elemento de proyecto
Puede que desee conservar una propiedad que se agrega a un elemento de proyecto, como el autor de un archivo de código fuente. Puede hacerlo mediante el almacenamiento de la propiedad en el archivo de proyecto.  
  
 El primer paso para conservar una propiedad en un archivo de proyecto consiste en obtener la jerarquía del proyecto como un <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interfaz. Puede obtener esta interfaz mediante la automatización o mediante <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection>. Una vez que obtenga la interfaz, se puede usar para determinar qué elemento de proyecto está seleccionado actualmente. Una vez que tenga el identificador de elemento de proyecto, puede usar <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> para agregar la propiedad.  
  
 En los procedimientos siguientes, conservar la propiedad VsPkg.cs `Author` con el valor `Tom` en el archivo de proyecto.  
  
### <a name="to-obtain-the-project-hierarchy-with-the-dte-object"></a>Para obtener la jerarquía del proyecto con el objeto DTE  
  
1.  Agregue el código siguiente para el paquete de VS:  
  
    ```csharp  
    EnvDTE.DTE dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));  
    EnvDTE.Project project = dte.Solution.Projects.Item(1);  
  
    string uniqueName = project.UniqueName;  
    IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));  
    IVsHierarchy hierarchy;  
    solution.GetProjectOfUniqueName(uniqueName, out hierarchy);  
    ```  
  
### <a name="to-persist-the-project-item-property-with-the-dte-object"></a>Para conservar la propiedad de elemento de proyecto con el objeto DTE  
  
1.  Agregue el código siguiente en el código proporcionado en el método en el procedimiento anterior:  
  
    ```csharp  
    IVsBuildPropertyStorage buildPropertyStorage =   
        hierarchy as IVsBuildPropertyStorage;  
    if (buildPropertyStorage != null)  
    {  
        uint itemId;  
        string fullPath = (string)project.ProjectItems.Item(  
            "VsPkg.cs").Properties.Item("FullPath").Value;  
        hierarchy.ParseCanonicalName(fullPath, out itemId);  
        buildPropertyStorage.SetItemAttribute(itemId, "Author", "Tom");  
    }  
    ```  
  
### <a name="to-obtain-the-project-hierarchy-using-ivsmonitorselection"></a>Para obtener la jerarquía del proyecto mediante IVsMonitorSelection  
  
1.  Agregue el código siguiente para el paquete de VS:  
  
    ```csharp  
    IVsHierarchy hierarchy = null;  
    IntPtr hierarchyPtr = IntPtr.Zero;  
    IntPtr selectionContainer = IntPtr.Zero;  
    uint itemid;  
  
    // Retrieve shell interface in order to get current selection  
    IVsMonitorSelection monitorSelection =     Package.GetGlobalService(typeof(SVsShellMonitorSelection)) as     IVsMonitorSelection;  
    if (monitorSelection == null)  
        throw new InvalidOperationException();  
  
    try  
    {  
        // Get the current project hierarchy, project item, and selection container for the current selection  
        // If the selection spans multiple hierachies, hierarchyPtr is Zero  
        IVsMultiItemSelect multiItemSelect = null;  
        ErrorHandler.ThrowOnFailure(  
            monitorSelection.GetCurrentSelection(  
                out hierarchyPtr, out itemid,   
                out multiItemSelect, out selectionContainer));  
  
        // We only care if there is only one node selected in the tree  
        if (!(itemid == VSConstants.VSITEMID_NIL ||   
            hierarchyPtr == IntPtr.Zero ||  
            multiItemSelect != null ||  
            itemid == VSConstants.VSITEMID_SELECTION))  
        {  
            hierarchy = Marshal.GetObjectForIUnknown(hierarchyPtr)  
                as IVsHierarchy;  
        }  
    }  
    finally  
    {  
        if (hierarchyPtr != IntPtr.Zero)  
            Marshal.Release(hierarchyPtr);  
        if (selectionContainer != IntPtr.Zero)  
            Marshal.Release(selectionContainer);  
    }  
    ```  
  
2.  
  
### <a name="to-persist-the-selected-project-item-property-given-the-project-hierarchy"></a>Para conservar la propiedad de elemento de proyecto seleccionado, dada la jerarquía del proyecto  
  
1.  Agregue el código siguiente en el código proporcionado en el método en el procedimiento anterior:  
  
    ```  
    IVsBuildPropertyStorage buildPropertyStorage =   
        hierarchy as IVsBuildPropertyStorage;  
    if (buildPropertyStorage != null)  
    {  
        buildPropertyStorage.SetItemAttribute(itemId, "Author", "Tom");  
    }  
    ```  
  
### <a name="to-verify-that-the-property-is-persisted"></a>Para comprobar que se conserva la propiedad  
  
1.  Iniciar [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] y, a continuación, abra o cree una solución.  
  
2.  Seleccione el proyecto elemento VsPkg.cs en **el Explorador de soluciones**.  
  
3.  Usar un punto de interrupción o en caso contrario, determinar que se carga el paquete de VS y que se ejecuta SetItemAttribute.  
  
    > [!NOTE]
    >  Puede cargar automáticamente un VSPackage en el contexto de la interfaz de usuario <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT_SolutionExists>. Para obtener más información, consulte [cargar VSPackages](../extensibility/loading-vspackages.md).  
  
4.  Cerrar [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] y, a continuación, abra el archivo de proyecto en el Bloc de notas. Debería ver el \<Autor > etiqueta con el valor Tom, como se indica a continuación:  
  
    ```  
    <Compile Include="VsPkg.cs">  
        <Author>Tom</Author>  
    </Compile>  
    ```  
  
## <a name="see-also"></a>Vea también  
 [Herramientas personalizadas](../extensibility/internals/custom-tools.md)