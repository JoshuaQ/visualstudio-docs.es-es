---
title: "Área de prueba 2: Obtener de Control de código fuente | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- source control plug-ins, getting items from source control
- source control [Visual Studio SDK], getting items from
ms.assetid: cbd345c5-ca43-4630-b7a4-85564f4e2090
caps.latest.revision: "18"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: a9ec7071a1e4ca78bb116c577cdcc77f9798c050
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="test-area-2-get-from-source-control"></a>Área de prueba 2: Obtener de Control de código fuente
Esta área de ensayo trata los casos de prueba para recuperar elementos desde el almacén de versiones mediante el comando Get. Estos casos de prueba se pueden aplicar a ambos local y a los proyectos Web.  
  
## <a name="command-menu-access"></a>Acceso al menú de comandos  
 El siguiente [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] las rutas de acceso del menú de entorno de desarrollo integrado se utilizan en los casos de prueba.  
  
##### <a name="get-latest-version"></a>Obtener la versión más reciente:  
  
-   **Archivo**, **Control de código fuente**, **obtener última versión**.  
  
-   **Archivo**, **obtener última versión**.  
  
-   Menú contextual, **obtener última versión**.  
  
-   Get: **archivo**, **Control de código fuente**, **obtener**.  
  
## <a name="expected-behavior"></a>Comportamiento esperado  
  
##### <a name="get-latest-version"></a>Obtener la versión más reciente:  
 Realiza una recuperación silenciosa (sin interfaz de usuario) de la versión más reciente del elemento desde el almacén de versiones.  
  
##### <a name="get"></a>Obtener:  
 Muestra el **obtener** cuadro de diálogo y permite al usuario realizar cambios en el conjunto de archivos que se va a recuperar, así como para modificar las opciones que afectan a cómo se recuperan los archivos.  
  
## <a name="test-cases"></a>Casos de prueba  
  
|Acción|Pasos de prueba|Resultados esperados para comprobar|  
|------------|----------------|--------------------------------|  
|Obtener la versión más reciente de un archivo que no existe localmente|1.  Cree un proyecto.<br />2.  Agregar un elemento al proyecto.<br />3.  Coloque el proyecto bajo control de código fuente.<br />4.  Elimine la copia local del elemento.<br />5.  Obtener la versión más reciente del elemento (menú contextual, **obtener última versión**).|Archivo de elemento se recupera localmente.|  
|Obtener un archivo que no existe localmente|1.  Cree un proyecto.<br />2.  Agregar un elemento al proyecto.<br />3.  Coloque el proyecto bajo control de código fuente.<br />4.  Elimine la copia local del elemento.<br />5.  Obtener el elemento (**archivo**, **Control de código fuente**, **obtener** \<elemento >).|Archivo de elemento se recupera localmente.|  
|Obtener un archivo que se ha desprotegido exclusivamente y modificado localmente|1.  Cree un proyecto.<br />2.  Agregar un elemento al proyecto.<br />3.  Coloque el proyecto bajo control de código fuente.<br />4.  Desprotege el elemento de proyecto en modo exclusivo.<br />5.  Modificar la copia local.<br />6.  Obtener la versión más reciente del elemento (**archivo**, **obtener la versión más reciente de** \<elemento >). Si este paso se realiza correctamente, vaya al paso siguiente.<br />7.  Haga clic en **reemplazar** botón en el cuadro de diálogo de advertencia.|**ReResult en el paso 6**`:`<br /><br /> Cuadro de diálogo de advertencia indica que el archivo está desprotegido.<br /><br /> **ReResult del paso 7:**<br /><br /> Archivo local modificado se reemplaza por la versión original del almacén de versiones.<br /><br /> Archivo es de lectura/escritura.|  
|Obtener y reemplazar el archivo que está desprotegido, compartido y modificar localmente|1.  Cree un nuevo proyecto.<br />2.  Agregar un elemento al proyecto.<br />3.  Coloque el proyecto bajo control de código fuente.<br />4.  Desproteger el elemento de proyecto como compartida.<br />5.  Modificar la copia local.<br />6.  Obtener la versión más reciente del elemento (**archivo**, **obtener la versión más reciente de** \<elemento >). Si este paso se realiza correctamente, vaya al paso siguiente.<br />7.  Haga clic en **reemplazar** en el cuadro de diálogo de advertencia.|**Como resultado del paso 6:**<br /><br /> Cuadro de diálogo de advertencia indica que el archivo está desprotegido.<br /><br /> **Como resultado del paso 7:**<br /><br /> Archivo local modificado se reemplaza por la versión original del almacén de versiones.<br /><br /> Archivo es de lectura/escritura.|  
|Obtener un archivo que existe localmente, igual a la versión más reciente en el almacén de versiones|1.  Cree un nuevo proyecto.<br />2.  Agregar un elemento al proyecto.<br />3.  Coloque el proyecto bajo control de código fuente.<br />4.  Obtener el elemento (**archivo**, **Control de código fuente**, **obtener** \<elemento >).|Archivo local se ha modificado.|  
|Obtener una solución con un proyecto|1.  Crear una solución con un proyecto.<br />2.  Coloque la solución bajo control de código fuente.<br />3.  Eliminar localmente todos los archivos del proyecto.<br />4.  Obtener la solución (**archivo**, **Control de código fuente**, **obtener**).|Todos los archivos eliminados se restauran localmente.|  
  
## <a name="see-also"></a>Vea también  
 [Guía de pruebas para los complementos de control de código fuente](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)