---
title: "&lt;personalización&gt; elemento (desarrollo de Office en Visual Studio) | Documentos de Microsoft"
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
helpviewer_keywords: application manifests [Office development in Visual Studio], <customization> element
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: b8e1c2c21fe5cf3a038066a47f50fe4b813b277e
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="ltcustomizationgt-element-office-development-in-visual-studio"></a>&lt;personalización&gt; elemento (desarrollo de Office en Visual Studio)
  El elemento `customization` del espacio de nombres `vstov4` describe una solución de Office específica. Los elementos secundarios son diferentes para las personalizaciones de nivel de documento y los complementos de VSTO.  
  
## <a name="syntax-for-document-level-customizations"></a>Sintaxis de las personalizaciones de nivel de documento  
  
```  
<customization  
  id  
  <document  
    solutionId  
  />  
</customization>  
```  
  
## <a name="syntax-for-vsto-add-ins"></a>Sintaxis de los complementos de VSTO  
  
```  
<customization  
  id  
  <appAddin  
    application  
    loadBehavior  
    keyName>  
  <friendlyName></friendlyName>  
  <description></description>  
  <formRegions></formRegions>  
</customization>  
```  
  
## <a name="elements-and-attributes"></a>Elementos y atributos  
 El elemento `customization` contiene información específica de la personalización. Este elemento debe estar en el espacio de nombres siguiente: `vstov4=urn:schemas-microsoft-com:vsto.v4`. Hay un elemento `customization` para cada solución de Office. Por ejemplo, si implementa tres soluciones de Office en una implementación de varios proyectos, hay tres elementos `customization` en el manifiesto de aplicación.  
  
 Los elementos secundarios del ensamblado también deben estar en este espacio de nombres.  
  
 El elemento `customization` tiene el siguiente atributo.  
  
|Atributo|Descripción|  
|---------------|-----------------|  
|`id`|Obligatorio en implementaciones de varios proyectos. El elemento `id` identifica de forma única una solución de Office.|  
  
### <a name="document-level-customizations"></a>Personalizaciones de nivel de documento  
 El elemento `customization` tiene el siguiente elemento secundario:  
  
#### <a name="document"></a>documento  
 El `document` elemento en el `vstov4` espacio de nombres se define en [&#60; documento &#62; Elemento &#40; desarrollo de Office en Visual Studio &#41; ](../vsto/document-element-office-development-in-visual-studio.md).  
  
### <a name="vsto-add-ins"></a>Complementos de VSTO  
 El elemento `customization` tiene el siguiente elemento secundario:  
  
#### <a name="appaddin"></a>appAddin  
 El `appAddin` elemento en el `vstov4` espacio de nombres se define en [&#60; appAddin &#62; Elemento &#40; desarrollo de Office en Visual Studio &#41; ](../vsto/appaddin-element-office-development-in-visual-studio.md).  
  
## <a name="example-of-a-document-level-customization"></a>Ejemplo de personalización de nivel de documento  
  
### <a name="description"></a>Descripción  
 En el ejemplo de código siguiente se muestra el elemento `customization` para una personalización de nivel de documento. Este ejemplo de código forma parte de un ejemplo más extenso incluido en [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### <a name="code"></a>Código  
  
```  
<vstov4:customization>  
  <vstov4:document   
    solutionId="73e" />  
</vstov4:customization>  
```  
  
## <a name="example-of-an-vsto-add-in"></a>Ejemplo de un complemento de VSTO  
  
### <a name="description"></a>Descripción  
 En el ejemplo de código siguiente se muestra el elemento `customization` para un complemento de VSTO. Este es un complemento de VSTO para Outlook que incluye áreas de formulario. Este ejemplo de código forma parte de un ejemplo más extenso incluido en [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### <a name="code"></a>Código  
  
```  
<vstov4:customization>  
  <vstov4:appAddIn   
    application="Outlook"   
    loadBehavior="3"   
    keyName="ContosoOutlookAddIn">  
    <vstov4:friendlyName>  
      ContosoOutlookAddIn  
    </vstov4:friendlyName>  
    <vstov4:description>  
      ContosoOutlookAddIn - Outlook VSTO Add-in   
      created with Visual Studio Tools for Office  
    </vstov4:description>  
    <vstov4:formRegions>  
      <vstov4:formRegion  
          name="OutlookAddIn1.FormRegion1">  
        <vstov4:messageClass name="IPM.Note" />  
        <vstov4:messageClass name="IPM.Contact" />  
        <vstov4:messageClass name="IPM.Appointment" />  
      </vstov4:formRegion>  
    </vstov4:formRegions>  
  </vstov4:appAddIn>  
</vstov4:customization>  
```  
  
## <a name="see-also"></a>Vea también  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Manifiestos de implementación para soluciones de Office](../vsto/deployment-manifests-for-office-solutions.md)   
 [Manifiesto de aplicación ClickOnce](/visualstudio/deployment/clickonce-application-manifest)  
  
  