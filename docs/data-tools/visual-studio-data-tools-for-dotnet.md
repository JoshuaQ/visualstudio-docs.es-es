---
title: Herramientas de datos de Visual Studio para .NET | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: c3175080-1dfb-4ab8-a460-92dadbb844b4
caps.latest.revision: "20"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-data-tools
ms.workload:
- data-storage
- dotnet
ms.openlocfilehash: 6c1558c591c982673015af4eaf4e50bc9a81f7d4
ms.sourcegitcommit: 9357209350167e1eb7e50b483e44893735d90589
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 01/05/2018
---
# <a name="visual-studio-data-tools-for-net"></a>Herramientas de datos de Visual Studio para .NET
Visual Studio y .NET Framework proporcionan conjuntamente una amplia API y las herramientas de soporte técnico para conectarse a bases de datos, modelado de datos en memoria y mostrar los datos en la interfaz de usuario. Las clases de .NET Framework que proporcionan la funcionalidad de acceso a datos se conocen como [ADO.NET](/dotnet/framework/data/adonet/index). ADO.NET, junto con los datos de herramientas en Visual Studio, se diseñó originalmente principalmente para admitir bases de datos relacionales y XML. Hoy en día, muchos proveedores de base de datos NoSQL, o de terceros, ofrecen proveedores de ADO.NET.  
  
[.NET core](https://www.dotnetfoundation.org/netcore) es compatible con ADO.NET, excepto para los conjuntos de datos y los tipos relacionados. Si el destino es .NET Core y requieren un nivel de asignación relacional de objetos (ORM), use [Entity Framework Core](/ef/core/).  
  
El siguiente diagrama muestra una vista simplificada de la arquitectura básica:  
  
![Arquitectura de ADO.NET](../data-tools/media/raddata-ado-net-architecture-diagram.png "raddata diagrama de arquitectura de ADO.NET")  
  
El flujo de trabajo típico es el siguiente:  
  
1.  Instalar un desarrollo o la base de datos de prueba en el equipo local. Vea [instalar sistemas de base de datos, herramientas y ejemplos de](../data-tools/installing-database-systems-tools-and-samples.md). Si usas un servicio de datos de Azure, este paso no es necesario.  
  
2.  Probar la conexión a la base de datos (o servicio o archivo local) en Visual Studio. Vea [agregar nuevas conexiones](../data-tools/add-new-connections.md).  
  
3.  (Opcional) Usar las herramientas para generar y configurar un nuevo modelo. Los modelos basados en Entity Framework son la recomendación predeterminada para las aplicaciones nuevas. El modelo, sea cual sea uno de los que utilice, es el origen de datos que la aplicación interactúa con. El modelo se encuentra lógicamente entre la base de datos o servicio y la aplicación.  Vea [agregar nuevos orígenes de datos](../data-tools/add-new-data-sources.md).  
  
4.  Arrastre el origen de datos de la **orígenes de datos** ventana en una superficie de diseño de formularios Windows Forms, ASP.NET o Windows Presentation Foundation para generar el código de enlace de datos que se mostrará los datos al usuario en la forma en que especifique. Vea [enlazar controles a datos en Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).  
  
5.  Agregar código personalizado para cosas como las reglas de negocios, búsqueda y la validación de datos, o para aprovechar las ventajas de la funcionalidad personalizada que expone la base de datos subyacente.  
  
Puede omitir el paso 3 y programar una aplicación .NET para enviar comandos directamente a una base de datos, en lugar de usar un modelo. En este caso, encontrará la documentación pertinente aquí: [ADO.NET](/dotnet/framework/data/adonet/index). Tenga en cuenta que todavía puede usar el Asistente para configuración de orígenes de datos y los diseñadores para generar el código de enlace de datos al rellenar sus propios objetos en memoria y, a continuación, enlazar controles de IU a esos objetos.
  
## <a name="see-also"></a>Vea también
[Obtener acceso a los datos en Visual Studio](../data-tools/accessing-data-in-visual-studio.md)