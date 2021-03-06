---
title: "Cómo: definir el Descriptor de tipo de un parámetro | Documentos de Microsoft"
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
- VB
- CSharp
helpviewer_keywords:
- Business Data Connectivity service [SharePoint development in Visual Studio], type descriptor
- BDC [SharePoint development in Visual Studio], parameter types
- BDC [SharePoint development in Visual Studio], type descriptor
- Business Data Connectivity service [SharePoint development in Visual Studio], parameter types
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 78df43a5d5614c175c5134ee638a75034ced8a5d
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="how-to-define-the-type-descriptor-of-a-parameter"></a>Cómo: Definir el descriptor de tipo de un parámetro
  Un descriptor de tipo contiene propiedades que describen el tipo de datos de un parámetro. Un descriptor de tipo puede definir un campo, una entidad o una colección de entidades. Para obtener más información, consulte [TypeDescriptor](http://msdn.microsoft.com/library/ms543392%28v=office.12%29.aspx).  
  
### <a name="to-define-the-type-descriptor-of-a-parameter"></a>Para definir el descriptor de tipo de un parámetro  
  
1.  En el **detalles del método de BDC** ventana, elija el descriptor de tipo del parámetro.  
  
2.  En la barra de menús, elija **vista**, **ventana propiedades**.  
  
3.  En el **propiedades** ventana, establezca las propiedades del descriptor de tipo.  
  
     En los procedimientos siguientes se describe cómo se define un descriptor de tipo como un campo, entidad o colección de entidades.  
  
### <a name="to-define-a-field"></a>Para definir un campo  
  
1.  En el **propiedades** ventana, establezca el **nombre** propiedad del descriptor de tipo para el nombre de un campo en el tipo que representa la entidad (por ejemplo: **FirstName**).  
  
2.  En la lista situada junto a la **TypeName** propiedad, elija el tipo de datos adecuado (por ejemplo, **Int32**).  
  
     Para obtener información acerca de los parámetros opcionales, vea [TypeDescriptor](http://msdn.microsoft.com/library/ms543392%28v=office.12%29.aspx).  
  
### <a name="to-define-an-entity"></a>Para definir una entidad  
  
1.  En el **propiedades** ventana, establezca el **nombre** propiedad en un nombre que describa la entidad (por ejemplo: **póngase en contacto con**).  
  
2.  Establecer el **TypeName** propiedad en el nombre completo del tipo que representa la entidad. Este tipo puede ser una clase del proyecto, un tipo definido en un ensamblado al que se hace referencia en la solución o un tipo definido en el modelo de objetos de BDC.  
  
    -   Para una clase en el proyecto, elija la flecha abajo junto a la **TypeName** propiedad, elija la **proyecto actual** ficha en el cuadro de diálogo que aparece y, a continuación, elija la clase en el proyecto.  
  
         El nombre completo incluye el espacio de nombres y el nombre de la clase seguidos del nombre del sistema LOB. En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a una clase en el proyecto.  
  
         `MyBDCNamespace.BdcModel1.Contact, BdcModel1`  
  
    -   Si se trata de un tipo ubicado en un ensamblado de la solución, el nombre completo contiene el nombre del tipo, el nombre del ensamblado, el número de versión, la referencia cultural y el token de clave pública.  
  
         En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a un tipo definido en un ensamblado que hace referencia en la solución.  
  
         `MyNamespace.Contact, myAssemblyName, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089`  
  
    -   Si se trata de un tipo definido en el modelo de objetos de BDC, el nombre completo incluye el espacio de nombres y el nombre del tipo.  
  
         En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a un tipo en el modelo de objetos BDC.  
  
         `Microsoft.BusinessData.Runtime.DynamicType`  
  
3.  En el **detalles del método de BDC** ventana, abra la lista que aparece para el descriptor de tipo y, a continuación, elija **editar**.  
  
     El **Explorador de BDC** abre la ventana.  
  
4.  En el **Explorador de BDC**, abra el menú contextual del descriptor de tipo y, a continuación, elija **agregar Descriptor de tipo**.  
  
     Un nuevo descriptor de tipo se agrega como elemento secundario al descriptor de tipo de entidad. Configure este descriptor de tipo como un campo.  
  
5.  Repita el paso 4 para agregar un descriptor de tipo secundario en cada campo de la entidad.  
  
### <a name="to-define-a-collection-of-entities"></a>Para definir una colección de entidades  
  
1.  En el **detalles del método de BDC** ventana, elija el descriptor de tipo del parámetro que desee.  
  
2.  En la barra de menús, elija **vista**, **ventana propiedades**.  
  
3.  En el **propiedades** ventana, establezca el **nombre** propiedad en un nombre que describa la entidad (por ejemplo: **contactos**).  
  
4.  Establecer el **IsCollection** propiedad **True**. Esto indica que este descriptor de tipo es una colección de entidades.  
  
5.  Establecer el **TypeName** propiedad a una cadena que contiene una referencia a la <xref:System.Collections.Generic.IEnumerable%601> interfaz y el nombre completo del tipo que representa la entidad. Este tipo puede ser una clase del proyecto, un tipo definido en un ensamblado al que se hace referencia en la solución o un tipo definido en el modelo de objetos de BDC.  
  
    -   Para una clase en el proyecto, elija la flecha abajo junto a la **TypeName** propiedad, elija la **proyecto actual** ficha en el cuadro de diálogo que aparece y, a continuación, elija la clase en el proyecto.  
  
         El nombre completo incluye el espacio de nombres y el nombre de la clase seguidos del nombre del sistema LOB.  
  
         En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a una colección de clases en el proyecto.  
  
         `System.Collections.Generic.IEnumerable`1 [MyBDCNamespace.` ` BdcModel1.Contact, BdcModel1]'  
  
    -   Si se trata de un tipo ubicado en un ensamblado de la solución, el nombre completo contiene el nombre del tipo, el nombre del ensamblado, el número de versión, la referencia cultural y el token de clave pública.  
  
         En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a una colección de tipos en un ensamblado que hace referencia en la solución.  
  
         `System.Collections.Generic.IEnumerable`1 [MyNamespace.Contact, myAssemblyName, versión = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089]'  
  
    -   Si se trata de un tipo definido en el modelo de objetos de BDC, el nombre completo solamente incluye el espacio de nombres y el nombre del tipo.  
  
         En el ejemplo siguiente se establece el valor de la **TypeName** propiedad a una colección de tipos definidos en el modelo de objetos BDC.  
  
         `System.Collections.Generic.IEnumerable`1 [Microsoft.BusinessData.Runtime.DynamicType]'  
  
6.  En el **detalles del método de BDC** ventana, abra la lista que aparece para el descriptor de tipo y, a continuación, elija **editar**.  
  
     El **Explorador de BDC** abre la ventana.  
  
7.  En el **Explorador de BDC**, abra el menú contextual del descriptor de tipo y, a continuación, elija **agregar Descriptor de tipo**.  
  
     Un nuevo descriptor de tipo se agrega como elemento secundario al descriptor de tipo de la colección. Configure este descriptor de tipo como una entidad.  
  
## <a name="see-also"></a>Vea también  
 [Información general de herramientas del diseño de modelo BDC](../sharepoint/bdc-model-design-tools-overview.md)   
 [Cómo: agregar una entidad a un modelo](../sharepoint/how-to-add-an-entity-to-a-model.md)   
 [Cómo: agregar un parámetro a un método](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [Cómo: definir una instancia de método](../sharepoint/how-to-define-a-method-instance.md)   
 [Diseñar un modelo de conectividad a datos profesionales](../sharepoint/designing-a-business-data-connectivity-model.md)  
  
  