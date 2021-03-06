---
title: "Cómo: Crear un informe de comparación del generador de perfiles desde un símbolo del sistema | Microsoft Docs"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 00548d16-eb5b-46f7-8a65-862f98a43831
caps.latest.revision: "10"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: b3eb863a53b1e03ca71db9c18a1d8188ef47b392
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="how-to-create-a-profiler-comparison-report-from-a-command-prompt"></a>Cómo: Crear un informe de comparación del generador de perfiles desde un símbolo del sistema
Puede generar un informe de las Herramientas de generación de perfiles de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] que compara los datos de rendimiento de dos archivos de datos de generación de perfiles (.VSP o .VSPS). El informe muestra las diferencias, reducciones de rendimiento y mejoras producidas de una sesión de generación de perfiles a la otra. Los valores del informe presentan el delta (o cambio) de la base de referencia del primer archivo que especifique. Este delta se calcula al determinar la diferencia entre el valor anterior, que es el valor de la base de referencia, y el valor del resultado del nuevo análisis. Las comparaciones de datos del generador de perfiles pueden basarse en las funciones del código, los módulos de la aplicación, las líneas, los punteros de instrucciones (IP) y los tipos.  
  
 Para obtener una lista de los identificadores de las categorías de comparación y los campos, escriba la siguiente línea de comandos:  
  
 **VSPerfReport /querydifftables**  *VspFileName1* *VspFileName2*  
  
 Use la sintaxis siguiente para crear el informe de comparación:  
  
 **VSPerfReport /diff**  `VspFileName1` *VspFileName2* [**/**`Options`]  
  
 Puede agregar opciones de la tabla siguiente a la línea de comandos **VSPerfReport /diff**.  
  
|Opción|Description|  
|------------|-----------------|  
|**DiffThreshold:**[*Value*]|Omita la diferencia si está por debajo de este valor de umbral de porcentaje. Además, no aparecen nuevos datos que tengan valores por debajo de este umbral.|  
|**DiffTable:** *TableName*|Use esta tabla para comparar archivos. De forma predeterminada, se usa la tabla de funciones. Especifique el identificador que aparece en **VSPerfReport /querydifftables**.|  
|**DiffColumn:** *ColumnName*|Use esta columna para comparar valores. De forma predeterminado, se usa la columna de porcentaje de muestras exclusivas. Especifique el identificador que aparece en **VSPerfReport /querydifftables**.|