---
title: "Validar código con diagramas de dependencia | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- dependency diagrams, validating
- validation, dependency diagrams
- validation, code
- code exploration, validating
- architecture, validating
- Visual Studio Ultimate, validating code
- validation, architecture
- validation, dependencies
- MSBuild, tasks
- MSBuild, dependency diagrams
- MSBuild, validating code
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: c3f457e46c1f9f0d7b3ed2f862a411245caf72e7
ms.sourcegitcommit: bd16e764134c436d2d2f46490f51234d5246ee50
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/22/2018
---
# <a name="validate-code-with-dependency-diagrams"></a>Validar código con diagramas de dependencia

**Últimas noticias**: vea [esta entrada de blog](https://blogs.msdn.microsoft.com/visualstudioalm/2016/11/30/live-dependency-validation-in-visual-studio-2017/).

[Vídeo: Validar las dependencias de arquitectura en tiempo real](https://sec.ch9.ms/sessions/69613110-c334-4f25-bb36-08e5a93456b5/170ValidateArchitectureDependenciesWithVisualStudio.mp4) 

## <a name="why-use-dependency-diagrams"></a>¿Por qué usar diagramas de dependencia?

Para asegurarse de que código no entre en conflicto con el diseño, valide el código con diagramas de dependencia en Visual Studio. Esto puede ser útil para:  
  
-   Busque los conflictos entre las dependencias del código y las dependencias en el diagrama de dependencia.  
  
-   Encontrar dependencias que podrían verse afectadas por los cambios propuestos.  
  
     Por ejemplo, puede editar el diagrama de dependencia para mostrar los posibles cambios de arquitectura y, a continuación, valide el código para ver las dependencias afectadas.  
  
-   Refactorizar o migrar el código a un diseño diferente.  
  
     Encontrar código o dependencias que requieran trabajo al cambiar el código a una arquitectura diferente.  
  
 **Requisitos**  
  
-   Visual Studio  
  
-   Visual Studio en el servidor de Team Foundation Build para validar código automáticamente con Team Foundation Build  
  
-   Una solución que tiene un proyecto de modelado con un diagrama de dependencia. Este diagrama de dependencia se debe vincularse a artefactos de proyectos de Visual C# .NET o Visual Basic .NET que se desea validar. Vea [crear diagramas de dependencia desde el código](../modeling/create-layer-diagrams-from-your-code.md).  
  
 Para ver qué versiones de Visual Studio admiten esta característica, vea [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
 Puede validar código manualmente desde un diagrama de dependencia abierta en Visual Studio o desde un símbolo del sistema. También puede validar código automáticamente al ejecutar compilaciones locales o Team Foundation Build. Vea [vídeo de Channel 9: diseño y validar la arquitectura mediante diagramas de dependencia](http://go.microsoft.com/fwlink/?LinkID=252073).  
  
> [!IMPORTANT]
>  Si desea ejecutar la validación de capa con Team Foundation Build, debe instalar también la misma versión de Visual Studio en el servidor de compilación.  
  
-   [Ver si un elemento admite validación](#SupportsValidation)  
  
-   [Incluir otros ensamblados .NET y proyectos para la validación](#IncludeReferences)  
  
-   [Validar código manualmente](#ValidateManually)  
  
-   [Validar código automáticamente](#ValidateAuto)  
  
-   [Solucionar problemas de validación de capas](#TroubleshootingValidation)  
  
-   [Entender y resolver errores de validación de capas](#UnderstandingValidationErrors)  

## <a name="live-dependency-validation"></a>Validación de la dependencia en vivo

En esta versión de Visual Studio, se produce la validación de dependencia en tiempo real y los errores se muestran inmediatamente en la ventana Lista de errores de Visual Studio.

* Validación en vivo se admite para C# y Visual Basic.NET. 

* Para habilitar el análisis de la solución completa cuando se utiliza la validación de la dependencia en vivo, abrir la configuración de opciones de la barra dorada que aparece en la lista de errores. 
 - Permanentemente se puede ignorar esta barra gold si no está interesado en ver todos los problemas de arquitectura de la solución.
 - Si no habilita el análisis de la solución completa, el análisis se realiza solo para los archivos que se está editando.<p /> 

* Al actualizar proyectos para habilitar la validación en vivo, un cuadro de diálogo muestra el progreso de la conversión.

* Al actualizar un proyecto para la validación de dependencia en vivo, la versión del paquete de NuGet se actualiza para que sea el mismo para todos los proyectos y es la versión más alta en uso. 

* Agregar un nuevo desencadenadores de proyecto de validación de dependencia una actualización del proyecto. 
  
##  <a name="SupportsValidation"></a>Ver si un elemento admite validación  
 Puede vincular capas a sitios web, documentos de Office, archivos de texto sin formato y archivos de proyectos que se comparten entre varias aplicaciones, pero el proceso de validación no los incluirá. Los errores de validación no aparecerán para las referencias a proyectos o ensamblados que están vinculados a capas independientes cuando no aparece ninguna dependencia entre esas capas. Tales referencias no se consideran dependencias a menos que el código utilice esas referencias.  
  
1.  En el diagrama de dependencia, seleccione una o varias capas, haga clic en la selección y, a continuación, haga clic en **ver vínculos**.  
  
2.  En **Explorador de capas**, mire el **admite validación** columna. Si el valor es false, el elemento no admite la validación.  
  
##  <a name="IncludeReferences"></a>Incluir otros ensamblados .NET y proyectos para la validación  
 Al arrastrar elementos al diagrama de dependencia, las referencias a los ensamblados de .NET correspondientes o los proyectos se agregan automáticamente a la **referencias de capa** carpeta del proyecto de modelado. Esta carpeta contiene referencias a los ensamblados y proyectos que se analizan durante la validación. Puede incluir otros ensamblados .NET y proyectos para validación sin arrastrarlos manualmente al diagrama de dependencia.  
  
1.  En **el Explorador de soluciones**, haga clic en el proyecto de modelado o **referencias de capa** carpeta y, a continuación, haga clic en **Agregar referencia**.  
  
2.  En el **Agregar referencia** cuadro de diálogo, seleccione los ensamblados o proyectos y, a continuación, haga clic en **Aceptar**.  
  
##  <a name="ValidateManually"></a>Validar código manualmente  
 Si tiene un diagrama de dependencia abierto que se vincula a elementos de la solución, puede ejecutar el **validar** comando de acceso directo del diagrama. También puede utilizar el símbolo del sistema para ejecutar el **msbuild** comando con el **pValidateArchitecture** propiedad personalizada que se establece en **True**. Por ejemplo, cuando haga cambios en el código, realice la validación de capas con regularidad para detectar pronto los conflictos de dependencia.  
  
#### <a name="to-validate-code-from-an-open-dependency-diagram"></a>Para validar el código de un diagrama de dependencia abierto   
  
1.  Haga clic en la superficie del diagrama y, a continuación, haga clic en **validar arquitectura**.  
  
    > [!NOTE]
    >  De forma predeterminada, el **acción de compilación** propiedad en el archivo de diagrama (.layerdiagram) de dependencia se establece en **validar** para que el diagrama se incluya en el proceso de validación.  
  
     El **lista de errores** ventana notifica los errores que se producen. Para obtener más información acerca de los errores de validación, consulte [entender y resolver errores de validación de capas](#UnderstandingValidationErrors).  
  
2.  Para ver el origen de cada error, haga doble clic en el error en la **lista de errores** ventana.  
  
    > [!NOTE]
    >  [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] podría mostrar un mapa de código en lugar del origen del error. Esto se produce cuando el código tiene una dependencia en un ensamblado que no se especifica en el diagrama de dependencia, o el código le falta una dependencia que se especifica en el diagrama de dependencia. Revise el mapa de código o el código para determinar si debe existir la dependencia. Para obtener más información acerca de los mapas de código, vea [asignar dependencias en las soluciones](../modeling/map-dependencies-across-your-solutions.md).  
  
3.  Para administrar los errores, vea [administrar errores de validación](#ManageErrors).  
  
#### <a name="to-validate-code-at-the-command-prompt"></a>Para validar código en el símbolo del sistema  
  
1.  Abra el símbolo del sistema de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
2.  Elija una de las siguientes opciones:  
  
    -   Para validar el código comparándolo con un proyecto de modelado concreto en la solución, ejecute [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] con la siguiente propiedad personalizada.  
  
        ```  
        msbuild <FilePath+ModelProjectFileName>.modelproj /p:ValidateArchitecture=true  
        ```  
  
         - O  
  
         Vaya a la carpeta que contiene el modelado del archivo (.modelproj) y el diagrama de dependencia de proyecto y, a continuación, ejecute [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] con la siguiente propiedad personalizada:  
  
        ```  
        msbuild /p:ValidateArchitecture=true   
        ```  
  
    -   Para validar el código comparándolo con todos los proyectos de modelado de la solución, ejecute [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] con la siguiente propiedad personalizada.  
  
        ```  
        msbuild <FilePath+SolutionName>.sln /p:ValidateArchitecture=true   
        ```  
  
         - O  
  
         Vaya a la carpeta de soluciones, que debe contener un proyecto de modelado que contiene un diagrama de dependencia y, a continuación, ejecute [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] con la siguiente propiedad personalizada:  
  
        ```  
        msbuild /p:ValidateArchitecture=true  
        ```  
  
     Se mostrará cualquier error que se produzca. Para obtener más información acerca de [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)], consulte [MSBuild](../msbuild/msbuild.md) y [tareas de MSBuild](../msbuild/msbuild-task.md).  
  
 Para obtener más información acerca de los errores de validación, consulte [entender y resolver errores de validación de capas](#UnderstandingValidationErrors).  
  
###  <a name="ManageErrors"></a>Administrar errores de validación  
 Durante el proceso de desarrollo, puede que desee suprimir algunos de los conflictos notificados durante la validación. Por ejemplo, es posible que desee suprimir errores de los que ya se ha ocupado o que no son pertinentes para su escenario concreto. Cuando se suprime un error, conviene registrar un elemento de trabajo en [!INCLUDE[esprfound](../code-quality/includes/esprfound_md.md)].  
  
> [!WARNING]
>  Ya debe estar conectado al control de código fuente TFS (SCC) para crear o vincular a un elemento de trabajo. Si intenta abrir una conexión a un SCC TFS diferente, Visual Studio cierra automáticamente la solución actual. Asegúrese de que ya está conectado al SCC apropiado antes de intentar crear o vincular a un elemento de trabajo. En las versiones posteriores de Visual Studio, los comandos de menú no están disponibles si no está conectado a un SCC.  
  
##### <a name="to-create-a-work-item-for-a-validation-error"></a>Para crear un elemento de trabajo para un error de validación  
  
-   En el **lista de errores** ventana, haga clic en el error, seleccione **crear elemento de trabajo**y, a continuación, haga clic en el tipo de elemento de trabajo que desea crear.  
  
 Utilice estos procedimientos para administrar los errores de validación de la **lista de errores** ventana:  
  
|**En**|**Siga estos pasos**|  
|------------|----------------------------|  
|Suprimir los errores seleccionados durante la validación|Haga clic en el uno o varios errores seleccionados, seleccione **administrar errores de validación**y, a continuación, haga clic en **suprimir errores**.<br /><br /> Los errores suprimidos aparecen tachados. La próxima vez que ejecute la validación, estos errores no aparecerán.<br /><br /> Errores suprimidos se realiza el seguimiento en un archivo .suppressions relacionado con el archivo de diagrama de dependencia correspondiente.|  
|Detener la supresión de los errores seleccionados|Haga clic en los errores suprimidos seleccionada o errores, seleccione **administrar errores de validación**y, a continuación, haga clic en **Detener supresión de errores**.<br /><br /> La próxima vez que ejecute la validación, los errores suprimidos aparecerán.|  
|Restaurar todos los errores suprimidos en la **lista de errores** ventana|Haga clic en cualquier lugar en el **lista de errores** ventana, seleccione **administrar errores de validación**y, a continuación, haga clic en **mostrar errores suprimidos**.|  
|Ocultar todos los errores suprimidos de la **lista de errores** ventana|Haga clic en cualquier lugar en el **lista de errores** ventana, seleccione **administrar errores de validación**y, a continuación, haga clic en **Ocultar errores suprimidos**.|  
  
##  <a name="ValidateAuto"></a>Validar código automáticamente  
 Puede realizar la validación de capas cada vez que ejecute una compilación local. Si el equipo usa Team Foundation Build, podrá realizar la validación de capas con protecciones controladas, que se pueden especificar creando una tarea MSBuild personalizada, y usar informes de compilación para recopilar los errores de validación. Para crear compilaciones en el repositorio validadas, consulte [utilizar un proceso de compilación de protección controlada para validar cambios](http://msdn.microsoft.com/Library/9cfc8b9c-1023-40fd-8ab5-1b1bd9c172ec).  
  
#### <a name="to-validate-code-automatically-during-a-local-build"></a>Para validar código automáticamente durante una compilación local  
  
-   Use un editor de texto para abrir el archivo del proyecto de modelado (.modelproj) y, a continuación, incluya la siguiente propiedad:  
  
```  
<ValidateArchitecture>true</ValidateArchitecture>  
```  
  
 \- o -  
  
1.  En **el Explorador de soluciones**, haga clic en el proyecto de modelado que contiene el diagrama de dependencias o diagramas y, a continuación, haga clic en **propiedades**.  
  
2.  En el **propiedades** ventana, establezca el proyecto de modelado **validar arquitectura** propiedad **True**.  
  
     Esto incluye el proyecto de modelado en el proceso de validación.  
  
3.  En **el Explorador de soluciones**, haga clic en el archivo de diagrama (.layerdiagram) de dependencia que se va a utilizar para la validación.  
  
4.  En el **propiedades** ventana, asegúrese de que el diagrama **acción de compilación** propiedad está establecida en **validar**.  
  
     Esto incluye el diagrama de dependencia en el proceso de validación.  
  
 Para administrar los errores en la ventana Lista de errores, vea [administrar errores de validación](#ManageErrors).  
  
#### <a name="to-validate-code-automatically-during-a-team-foundation-build"></a>Para validar código automáticamente durante una compilación con Team Foundation Build  
  
1.  En **Team Explorer**, haga doble clic en la definición de compilación y, a continuación, haga clic en **proceso**.  
  
2.  En **parámetros del proceso de compilación**, expanda **compilación**y escriba lo siguiente en el **argumentos de MSBuild** parámetro:  
  
     `/p:ValidateArchitecture=true`  
  
 Para obtener más información acerca de los errores de validación, consulte [entender y resolver errores de validación de capas](#UnderstandingValidationErrors). Para obtener más información acerca de [!INCLUDE[esprbuild](../misc/includes/esprbuild_md.md)], vea:  
  
-   [Compilación y versión](/vsts/build-release/index)  
  
-   [Usar la plantilla predeterminada para el proceso de compilación](http://msdn.microsoft.com/Library/43930b12-c21b-4599-a980-2995e3d16e31)  
  
-   [Modificar una compilación heredado que se basa en UpgradeTemplate.xaml](http://msdn.microsoft.com/Library/ee1a8259-1dd1-4a10-9563-66c5446ef41c)  
  
-   [Personalizar la plantilla de proceso de compilación](http://msdn.microsoft.com/Library/b94c58f2-ae6f-4245-bedb-82cd114f6039)  
  
-   [Supervisar el progreso de una compilación en ejecución](http://msdn.microsoft.com/Library/e51e3bad-2d1d-4b7b-bfcc-c43439c6c8ef)  
  
##  <a name="TroubleshootingValidation"></a>Solucionar problemas de validación de capas  
 En la siguiente tabla se describen problemas de validación de capas y su resolución. Estos problemas difieren de los errores que son resultado de conflictos entre el código y el diseño. Para obtener más información acerca de estos errores, vea [entender y resolver errores de validación de capas](#UnderstandingValidationErrors).  
  
|**Problema**|**Causa posible**|**Resolución**|  
|---------------|------------------------|--------------------|  
|Los errores de validación no se producen como se espera.|La validación no funciona en los diagramas de dependencia que se copian de otros diagramas de dependencia en el Explorador de soluciones y que están en el mismo proyecto de modelado. diagramas de dependencia que se copian de esta manera contienen las mismas referencias que el diagrama de dependencia original.|Agregue un nuevo diagrama de dependencia para el proyecto de modelado.<br /><br /> Copie los elementos del diagrama de dependencia de origen en el nuevo diagrama.|  
  
##  <a name="UnderstandingValidationErrors"></a>Entender y resolver errores de validación de capas  
 Cuando valide el código contra un diagrama de dependencias, se producen errores de validación cuando el código entra en conflicto con el diseño. Por ejemplo, las siguientes condiciones podrían producir errores de validación:  
  
-   Un artefacto se ha asignado a la capa equivocada. En este caso, mueva el artefacto.  
  
-   Un artefacto, como por ejemplo una clase, usa otra clase de forma que hay conflictos con su arquitectura. En este caso, tiene que refactorizar el código para quitar la dependencia.  
  
 Para resolver estos errores, actualice el código hasta no aparezcan más errores durante la validación. Puede realizar esta tarea repetitivamente.  
  
 En la sección siguiente se describe la sintaxis que se usa en estos errores, se explica el significado de los mismos y se sugiere qué se puede hacer para resolverlos o administrarlos.  
  
|**Sintaxis**|**Descripción**|  
|----------------|---------------------|  
|*ArtifactN*(*ArtifactTypeN*)|*ArtifactN* es un artefacto que está asociado a una capa en el diagrama de dependencia.<br /><br /> *ArtifactTypeN* es el tipo de *ArtifactN*, como un **clase** o **método**, por ejemplo:<br /><br /> MiSolución.MiProyecto.MiClase.MiMétodo(Método)|  
|*NamespaceNameN*|Nombre de un espacio de nombres.|  
|*LayerNameN*|El nombre de una capa en el diagrama de dependencia.|  
|*DependencyType*|El tipo de relación de dependencia entre *Artifact1* y *Artifact2*. Por ejemplo, *Artifact1* tiene un **llamadas** relación con *Artifact2*.|  
  
|**Sintaxis de error**|**Descripción del error**|  
|----------------------|---------------------------|  
|DV0001: **una dependencia no válida**|Este problema se notifica cuando un elemento de código (espacio de nombres, tipo de miembro) que asigna a las referencias de una capa un elemento de código que se asigna a otra capa, pero no hay ninguna flecha de dependencia entre estas capas en el diagrama de la validación de dependencia que contiene este capas. Se trata de una infracción de restricción de dependencia.|  
|DV1001: **nombre de espacio de nombres no válido**|Este problema se notifica en un elemento de código asociado a una capa que "Permite nombres de Namespace" propiedad no contienen el espacio de nombres en el que se define este elemento de código. Se trata de una infracción de restricción de nomenclatura. Tenga en cuenta que la sintaxis de "Permite nombres de Namespace" es como una lista de punto y coma de en qué código elementos asociados a son capas de espacios de nombres pueden definirse.|  
|DV1002: **depende del espacio de nombres unreferenceable**|Este problema se notifica en un elemento de código asociados a una capa y hacer referencia a otro elemento de código definido en un espacio de nombres que se define en la propiedad "Namespace Unreferenceable" de la capa. Se trata de una infracción de restricción de nomenclatura. Tenga en cuenta que la propiedad "Espacios de nombres Unreferenceable" se define como una lista separada por punto y coma de espacios de nombres que no se deben hacer referencia en los elementos de código asociados a esta capa.|  
|DV1003: **nombre de espacio de nombres no permitido**|Este problema se notifica en un elemento de código asociado a una capa que propiedad "No permite nombres de Namespace" contiene el espacio de nombres en el que se define este elemento de código. Se trata de una infracción de restricción de nomenclatura. Tenga en cuenta que la propiedad "Nombre de espacio de nombres no permitido" se define como una lista separada por punto y coma de espacios de nombres en el código que no se deben definir elementos asociados a esta capa.|  
|DV3001: **vínculo que falta**|Capa '*LayerName*'vincula a'*artefacto*' que no se encuentra. ¿Falta una referencia de ensamblado?|*LayerName* vinculada a un artefacto que no se encuentra. Por ejemplo, es posible que falte un vínculo a una clase porque en el proyecto de modelado falta una referencia al ensamblado que contiene la clase.|  
|DV9001: **análisis de arquitectura encontró errores internos**|Puede que los resultados no estén completos. Vea el registro detallado de eventos de compilación o la ventana de salida para obtener más información.|Vea el registro de eventos de compilación o la ventana de salida para obtener más información.|  

 
## <a name="see-also"></a>Vea también  
 [Validar el sistema durante el desarrollo](../modeling/validate-your-system-during-development.md)   
 [Vídeo: Validar las dependencias de arquitectura en tiempo real](https://sec.ch9.ms/sessions/69613110-c334-4f25-bb36-08e5a93456b5/170ValidateArchitectureDependenciesWithVisualStudio.mp4)   
