---
title: Elemento CommandTable | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: CommandTable
helpviewer_keywords:
- CommandTable element (VSCT XML schema)
- VSCT XML schema elements, CommandTable
ms.assetid: 15c38159-660a-4ef4-9643-aa6fcfca82a9
caps.latest.revision: "11"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 6fe68f25748df171ec6695554903b37854e7d8c6
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="commandtable-element"></a>Elemento CommandTable
CommandTable es el elemento raíz del archivo vsct. Este es el archivo que define el diseño real y el tipo de los comandos que un VSPackage proporciona al IDE. Comandos pueden incluir elementos de menú, menús, barras de herramientas y cuadros combinados. Para obtener más información, consulta [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).  
  
## <a name="syntax"></a>Sintaxis  
  
```  
<CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable" xmlns:xs="http://www.w3.org/2001/XMLSchema" >  
  <Extern>... </Extern>  
  <Include>... </Include>  
  <Define>... </Define>  
  <Commands>... </Commands>  
  <CommandPlacements>... </CommandPlacements>  
  <VisibilityConstraints>... </VisibilityConstraints>  
  <KeyBindings>... </KeyBindings>  
  <UsedCommands... </UsedCommands>  
  <Symbols>... </Symbols>  
</CommandTable>  
```  
  
## <a name="attributes-and-elements"></a>Atributos y elementos  
 En las siguientes secciones se describen los atributos, los elementos secundarios y los elementos primarios.  
  
### <a name="attributes"></a>Atributos  
  
|Atributo|Descripción|  
|---------------|-----------------|  
|xmlns|Requerido. Espacios de nombres XML:<br /><br /> xmlns = "http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable"<br /><br /> xmlns: xs = "http://www.w3.org/2001/XMLSchema"|  
|lenguaje|Opcional. El atributo language puede utilizarse para especificar el idioma predeterminado de todos los \<cadenas > elementos en la tabla de comandos.  Si el idioma no se especifica, se usará el idioma del proceso actual:<br /><br /> idioma = "en-us"|  
  
### <a name="child-elements"></a>Elementos secundarios  
  
|Elemento|Descripción|  
|-------------|-----------------|  
|[Extern (Elemento)](../extensibility/extern-element.md)|Opcional. Contiene directivas de preprocesador para el compilador.|  
|[Include (Elemento)](../extensibility/include-element.md)|Opcional. Contiene las rutas de acceso a los archivos que se incluirán en la compilación.|  
|[Define (Elemento)](../extensibility/define-element.md)|Opcional. Define un símbolo dado su nombre y valor.|  
|[Commands (Elemento)](../extensibility/commands-element.md)|Opcional. El elemento primario define todos los comandos para el paquete de VS que contiene todos los demás elementos.|  
|[CommandPlacements (Elemento)](../extensibility/commandplacements-element.md)|Opcional. Define dónde en la barra de comandos, los comandos están va a colocar.|  
|[VisibilityConstraints (Elemento)](../extensibility/visibilityconstraints-element.md)|Opcional. Determina la visibilidad estática de comandos y las barras de herramientas.|  
|[KeyBindings (Elemento)](../extensibility/keybindings-element.md)|Opcional. Especifica las combinaciones de teclas de método abreviado, si existe, para los comandos.|  
|[UsedCommands (Elemento)](../extensibility/usedcommands-element.md)|Opcional. Permite que un paquete VSPackage, opcionalmente, implementar su propia versión de la funcionalidad admitida originalmente por otros VSPackages.|  
|[Symbols (Elemento)](http://msdn.microsoft.com/en-us/f2ddd0aa-c3dd-439e-834d-28f136a27ffa)|Opcional. Contiene los datos de símbolos--GUID, identificadores y así sucesivamente, para que el compilador.|  
  
### <a name="parent-elements"></a>Elementos primarios  
  
|Elemento|Descripción|  
|-------------|-----------------|  
|Ninguna||  
  
## <a name="see-also"></a>Vea también  
 [Archivos de tabla de comandos de Visual Studio (.Vsct)](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)