---
title: 'La zona de ensayo 8: Cambio de complementos | Documentos de Microsoft'
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- source control [Visual Studio SDK], switching plug-ins
- source control plug-ins, switching
ms.assetid: 01370792-b5da-4e46-9ce2-7dd326587141
caps.latest.revision: "9"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 9f6a518d618b3a98ec85cbbe015d3b2c5fc7a710
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="test-area-8-plug-in-switching"></a>La zona de ensayo 8: Cambio de complementos
El [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] el entorno de desarrollo integrado (IDE) tiene la interfaz de usuario (UI) para cambiar el complemento de control de código fuente actual. Esta área de ensayo proporciona casos de prueba para el proceso de elegir qué complemento que se utilizará para el control de código fuente de la solución.  
  
## <a name="command-menu-access"></a>Acceso al menú de comandos  
 El siguiente [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] las rutas de acceso del menú de entorno de desarrollo integrado se utilizan en los casos de prueba.  
  
-   Complemento de control de código fuente actual: **herramientas** -> **opciones** -> **Control de código fuente** -> **selección de complemento** .  
  
-   Cambiar origen de enlace de control: **archivo** -> **Control de código fuente** -> **cambiar Control de código fuente**...  
  
## <a name="common-expected-behavior"></a>Comportamiento esperado común  
 Es posible cambiar el complemento para una solución de control de código fuente sin salir de Visual Studio o volver a cargar la solución. Además, el complemento de control de código fuente actual cambia automáticamente al utilizado por una solución cuando se carga esa solución.  
  
## <a name="test-cases"></a>Casos de prueba  
 Éstos son los casos de prueba concretos para la zona de ensayo conmutación complemento.  
  
### <a name="case-8a-automatic-change"></a>Caso 8a: cambio automático  
  
#### <a name="expected-behavior"></a>Comportamiento esperado  
 Cuando un usuario carga una solución que se encuentra bajo control de código fuente, se carga automáticamente la solución y el complemento de control de origen correspondiente se selecciona como actual.  
  
|Acción|Pasos de prueba|Resultados esperados para comprobar|  
|------------|----------------|--------------------------------|  
|Cambio de complemento de control de origen automática|1.  Seleccione complemento en prueba como actual (**herramientas** -> **opciones** -> **Control de código fuente** -> **complemento Selección**.)<br />2.  Cree un nuevo proyecto.<br />3.  Agregar la solución al control de código fuente.<br />4.  Seleccione otro complemento (por ejemplo, [!INCLUDE[vsvss](../../extensibility/includes/vsvss_md.md)]).<br />5.  Aceptar descargar aviso de solución.<br />6.  Vuelva a abrir la solución desde el disco.|Se abre la solución.<br /><br /> Complemento sometida a prueba es el complemento de control de código fuente actual.|  
  
### <a name="case-8b-solution-based-change"></a>Caso 8b: cambio de la solución  
  
#### <a name="expected-behavior"></a>Comportamiento esperado  
 La solución puede tener su complemento de control de código fuente asociado cambiarlo.  
  
|Acción|Pasos de prueba|Resultados esperados para comprobar|  
|------------|----------------|--------------------------------|  
|Cambio de complemento para una solución|1.  Seleccione complemento en prueba como actual (**herramientas** -> **opciones** -> **Control de código fuente** -> **complemento Selección de**).<br />2.  Crear un nuevo proyecto y una solución.<br />3.  Agregar la solución al control de código fuente.<br />4.  Desenlace la solución de control de código fuente (utilizando el **cambiar Control de código fuente** cuadro de diálogo).<br />5.  Seleccione otro complemento (por ejemplo, [!INCLUDE[vsvss](../../extensibility/includes/vsvss_md.md)]).<br />6.  Vuelva a cargar la solución desde el disco si descarga.<br />7.  Agregar la solución al control de código fuente.<br />8.  Desenlace la solución de control de código fuente (con **cambiar Control de código fuente** cuadro de diálogo).<br />9. Seleccione complemento sometida a prueba de nuevo.<br />10. Vuelva a cargar la solución desde el disco si descarga.<br />11. Enlazar la solución en la ubicación original (mediante la **cambiar Control de código fuente** cuadro de diálogo).|Solución se agrega al control de código fuente utilizando el complemento.|  
  
## <a name="see-also"></a>Vea también  
 [Guía de pruebas para los complementos de control de código fuente](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)