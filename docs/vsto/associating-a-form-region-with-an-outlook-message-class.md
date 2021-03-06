---
title: "Asociar un área de formulario a una clase de mensaje de Outlook | Documentos de Microsoft"
ms.custom: 
ms.date: 02/02/2017
ms.reviewer: 
ms.suite: 
ms.technology: office-development
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: VSTO.NewFormRegionWizard.InvalidMessageClassName
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- FormRegionMessageClassAttribute
- form regions [Office development in Visual Studio], message classes
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: office
ms.openlocfilehash: 2c09622189b335e58dc9cad15d415eb75385955f
ms.sourcegitcommit: f9fbf1f55f9ac14e4e5c6ae58c30dc1800ca6cda
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/10/2018
---
# <a name="associating-a-form-region-with-an-outlook-message-class"></a>Asociar un área de formulario a una clase de mensaje de Outlook
  Puede especificar de qué elementos de Microsoft Office Outlook muestran un área de formulario asociando el área de formulario con la clase de mensaje de cada elemento. Por ejemplo, si desea anexar un área de formulario a la parte inferior de un elemento de correo, puede asociar el área de formulario con el formulario IPM. Tenga en cuenta message (clase).  
  
 Para asociar un área de formulario a una clase de mensaje, especifique el nombre de clase de mensaje en el **nueva área de formulario de Outlook** asistente o aplicar un atributo a la clase de generador de áreas de formulario.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## <a name="understanding-outlook-message-classes"></a>Introducción a las clases de mensaje de Outlook  
 Una clase de mensaje de Outlook identifica un tipo de elemento de Outlook. En la tabla siguiente se enumera los ocho tipos estándar de elementos y sus nombres de clase de mensaje.  
  
|Tipo de elemento de Outlook|Nombre de la clase de mensaje|  
|-----------------------|------------------------|  
|Objeto AppointmentItem|IPM. Cita|  
|Objeto ContactItem|IPM. Póngase en contacto con|  
|DistListItem|IPM. DistList|  
|JournalItem|IPM. Actividad|  
|Objeto MailItem|IPM. Tenga en cuenta|  
|PostItem|IPM. POST o IPM. Post.RSS|  
|Objeto TaskItem|IPM. Tarea|  
  
 También puede especificar los nombres de clases de mensaje personalizadas. Clases de mensaje personalizadas identifican los formularios personalizados que defina en Outlook.  
  
> [!NOTE]  
>  Para reemplazo y áreas de formulario de reemplazo total, puede especificar un nuevo nombre de clase de mensaje personalizado. No es necesario utilizar el nombre de clase de mensaje de un formulario personalizado existente. El nombre de la clase de mensaje personalizado debe ser único. Una manera de asegurarse de que el nombre es único es usar una convención de nomenclatura similar al siguiente: \< *nombreDeClaseDeMensajeEstándar*>.\< *Empresa*>.\< *NombreDeClaseDeMensaje*> (por ejemplo: IPM. Note.Contoso.MyMessageClass).  
  
## <a name="associating-a-form-region-with-an-outlook-message-class"></a>Asociar un área de formulario a una clase de mensaje de Outlook  
 Hay dos formas de asociar un área de formulario a una clase de mensaje:  
  
-   Use la **nueva área de formulario de Outlook** asistente.  
  
-   Aplicar atributos de clase.  
  
### <a name="using-the-new-outlook-form-region-wizard"></a>Mediante el Asistente para nueva región de formulario de Outlook  
 En la página final de la **nueva área de formulario de Outlook** asistente, puede seleccionar clases de mensaje estándar y escriba los nombres de clases de mensaje personalizadas que se va a asociar con el área de formulario.  
  
 Las clases de mensaje estándar no están disponibles si el área de formulario está diseñado para reemplazar todo el formulario o la página predeterminada de un formulario. Puede especificar nombres de clase de mensaje estándar sólo para los formularios que agregue una nueva página a un formulario o que se anexan a la parte inferior de un formulario. Para obtener más información, consulte [Cómo: agregar un área de formulario a un proyecto de complemento de Outlook](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md).  
  
 Para incluir una o más clases de mensaje personalizado, escriba sus nombres en el **qué clases de mensaje personalizadas mostrarán esta área de formulario?** cuadro.  
  
 Los nombres que escriba deben ser compatible con las siguientes directrices:  
  
-   Utilice el nombre de clase de mensaje completo (por ejemplo: "IPM". ("Note.Contoso").  
  
-   Use punto y coma para separar varios nombres de clase de mensaje.  
  
-   No incluya clases de mensaje estándar de Outlook, como "IPM." Tenga en cuenta"o"IPM." Póngase en contacto con". Incluir solo las clases de mensaje personalizadas, como "IPM." Note.Contoso".  
  
-   No especifica la clase de mensaje base por sí mismo (por ejemplo: "IPM").  
  
-   No superar los 256 caracteres para cada nombre de clase de mensaje.  
  
 El **nueva área de formulario de Outlook** asistente valida el formato de la entrada al hacer clic en **finalizar**.  
  
> [!NOTE]  
>  El **nueva área de formulario de Outlook** asistente no comprueba que los nombres de clase de mensaje que proporcionan son correctos o válidos.  
  
 Cuando se completa el asistente, el **nueva área de formulario de Outlook** asistente aplica atributos a la clase de área de formulario que contiene los nombres de clase de mensaje especificado. También puede aplicar estos atributos manualmente.  
  
### <a name="applying-class-attributes"></a>Aplicar atributos de clase  
 Puede asociar un área de formulario a una clase de mensaje de Outlook después de completar la **nueva área de formulario de Outlook** asistente. Para ello, aplicar atributos a la clase de generador de áreas de formulario.  
  
 En el ejemplo siguiente se muestra dos <xref:Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute> atributos que se han aplicado a una clase de generador de áreas de formulario denominada `myFormRegion`. El primer atributo asocia el área de formulario a una clase de mensaje estándar para un formulario de mensaje de correo electrónico. El segundo atributo asocia el área de formulario a una clase de mensaje personalizado denominada `IPM.Task.Contoso`.  
  
 [!code-vb[Trin_Outlook_FR_Attributes#1](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Attributes/FormRegion1.vb#1)]
 [!code-csharp[Trin_Outlook_FR_Attributes#1](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Attributes/FormRegion1.cs#1)]  
  
 Atributos deben ser compatible con las siguientes directrices:  
  
-   Para las clases de mensaje personalizado, utilice el nombre de clase de mensaje completo (por ejemplo: "IPM". ("Note.Contoso").  
  
-   No especifica la clase de mensaje base por sí mismo (por ejemplo: "IPM").  
  
-   No superar los 256 caracteres para cada nombre de clase de mensaje.  
  
-   No incluya los nombres de clases de mensaje estándar si el área de formulario reemplaza todo el formulario o la página predeterminada de un formulario. Puede especificar nombres de clase de mensaje estándar sólo para los formularios que agregue una nueva página a un formulario o que se anexan a la parte inferior de un formulario. Para obtener más información, consulte [Cómo: agregar un área de formulario a un proyecto de complemento de Outlook](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md).  
  
 Visual Studio valida el formato de los nombres de clase de mensaje al compilar el proyecto.  
  
> [!NOTE]  
>  Visual Studio no comprueba que los nombres de clase de mensaje que proporcionan son correctos o válidos.  
  
## <a name="see-also"></a>Vea también  
 [Obtener acceso a un área de formulario en tiempo de ejecución](../vsto/accessing-a-form-region-at-run-time.md)   
 [Crear áreas de formulario de Outlook](../vsto/creating-outlook-form-regions.md)   
 [Tutorial: Diseñar un área de formulario de Outlook](../vsto/walkthrough-designing-an-outlook-form-region.md)   
 [Instrucciones para crear áreas de formulario de Outlook](../vsto/guidelines-for-creating-outlook-form-regions.md)   
 [Nombre del formulario y resumen de la clase de mensaje](http://msdn.microsoft.com/library/office/ff867629.aspx)   
 [Cómo funcionan conjuntamente los elementos y los formularios de Outlook](http://msdn.microsoft.com/library/office/ff869706.aspx)  
  
  