---
title: "Directrices para la importación de flujos de trabajo reutilizables | Documentos de Microsoft"
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- SharePoint development in Visual Studio, importing items
- SharePoint development in Visual Studio, reusable workflows
- importing items [SharePoint development in Visual Studio]
- reusable workflows [SharePoint development in Visual Studio]
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: a79f277c5cecead23def256e16b8fd69c64b2d36
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="guidelines-for-importing-reusable-workflows"></a>Pautas para importar flujos de trabajo reutilizables
  Para importar flujos de trabajo reutilizables creados en SharePoint Designer, use la plantilla de proyecto Importar flujo de trabajo de reutilizable SharePoint 2010 en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. Esta plantilla se importa un *declarativa* *flujo de trabajo* ([!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)]-solo) y lo convierte en un *flujo de trabajo de código*, que es un flujo de trabajo que pueden mejorar con cualquiera [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] o [!INCLUDE[csprcs](../sharepoint/includes/csprcs-md.md)] código. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)][Tutorial: importar un flujo de trabajo reutilizable de SharePoint Designer en Visual Studio](../sharepoint/walkthrough-import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md).  
  
 Sin embargo, la plantilla de flujo de trabajo de importación reutilizable SharePoint 2010 puede importar sólo las soluciones de granja de servidores. Si va a implementar el flujo de trabajo como una solución en espacio aislado, impórtelo con la plantilla Importar paquete de solución de SharePoint 2010. Sin embargo, al hacerlo, no se puede convertir para flujo de trabajo de código y no podrá modificarlo como tal.  
  
## <a name="importing-reusable-workflows-by-using-the-import-reusable-workflow-template"></a>Importar flujos de trabajo reutilizables con la plantilla de flujo de trabajo reutilizable de importación  
 Si importa un flujo de trabajo reutilizable con la plantilla Importar flujo de trabajo de reutilizable SharePoint 2010, puede ejecutar o cambiar la solución como cualquier otro [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] solución de SharePoint, pero es podrán que deba corregir manualmente algunos elementos.  
  
### <a name="importing-task-forms"></a>Importar formularios de tareas  
 La plantilla de proyecto de flujo de trabajo de importación reutilizable SharePoint 2010 importa todos los formularios de iniciación y asociación pero importa solo un formulario de tareas porque el esquema de flujo de trabajo de código solamente permite un formulario de tareas. Los formularios de tareas adicionales de la solución de flujo de trabajo original se colocan en la **otros archivos importados** carpeta **el Explorador de soluciones**.  
  
## <a name="importing-reusable-workflows-by-using-the-import-sharepoint-2010-solution-package-template"></a>Importar flujos de trabajo reutilizables con la plantilla de paquete de importación SharePoint 2010 solución  
 Si importa un flujo de trabajo reutilizable con la plantilla Importar paquete de solución de SharePoint 2010, necesitará tener en cuenta lo siguiente:  
  
-   Después de importar el flujo de trabajo, inmediatamente puede implementarla y ejecutarla [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] eligiendo la tecla F5. Sin embargo, si se cambia algo en el flujo de trabajo de la solución importada, tendrá que corregir manualmente los elementos en el proyecto antes de poder implementar y ejecutar el flujo de trabajo.  
  
-   Dado que el flujo de trabajo es declarativo, no se puede agregar código a él. Para convertir el flujo de trabajo en un flujo de trabajo de código, debe importarlo en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] mediante la plantilla de flujo de trabajo de importación reutilizable SharePoint 2010.  
  
-   Aunque puede editar el archivo de diseñador (.xoml) del flujo de trabajo en la vista Diseño, se recomienda editarlo en la vista de origen, porque el Diseñador de flujo de trabajo muestra falsos errores.  
  
-   La depuración en el flujo de trabajo no funciona con contenido declarativo. Establezcan puntos de interrupción el [!INCLUDE[wfd2](../sharepoint/includes/wfd2-md.md)] pero no.  
  
## <a name="importing-globally-reusable-workflow-solutions"></a>Importar soluciones de flujo de trabajo reutilizable globalmente  
 No se puede importar flujos de trabajo reutilizables globalmente mediante la plantilla de flujo de trabajo de importación reutilizable SharePoint 2010. Para importar un flujo de trabajo reutilizable globalmente, tiene que convertir en un flujo de trabajo reutilizable no globalmente o tendrá que usar la plantilla Importar paquete de solución de SharePoint 2010.  
  
 Para convertir el flujo de trabajo, haga una copia del flujo de trabajo reutilizable globalmente en SharePoint Designer (abriendo el menú contextual para el flujo de trabajo y, a continuación, eligiendo **Guardar como copia**). A continuación, importar el nuevo flujo de trabajo reutilizable con la plantilla Importar flujo de trabajo de reutilizable SharePoint 2010 en [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].  
  
 Para importar el flujo de trabajo reutilizable globalmente sin modificación alguna, use la plantilla Importar paquete de solución de SharePoint 2010. Si utiliza este método, el flujo de trabajo no se convierte en un flujo de trabajo de código y sigue siendo un flujo de trabajo declarativo.  
  
## <a name="see-also"></a>Vea también  
 [Importar elementos de un sitio de SharePoint existente](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)   
 [Tutorial: Importar un flujo de trabajo reutilizable de SharePoint Designer en Visual Studio](../sharepoint/walkthrough-import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md)  
  
  