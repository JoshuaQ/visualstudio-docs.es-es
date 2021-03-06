---
title: Ejemplo Dia2dump | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-debug
ms.tgt_pltfrm: 
ms.topic: article
dev_langs: C++
helpviewer_keywords:
- sample applications [DIA SDK]
- Dia2dump sample [DIA SDK]
ms.assetid: 492c0893-7043-452f-a020-890a47230d20
caps.latest.revision: "12"
author: mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: multiple
ms.openlocfilehash: bd21806dee94031c6d5486daf1696e1f97e2956f
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="dia2dump-sample"></a>Ejemplo Dia2dump
El ejemplo Dia2dump se instala con Visual Studio y contiene el archivo de origen dia2dump.cpp. El archivo ejecutable compilado se ejecuta desde la línea de comandos y muestra el contenido de un archivo de programa (.pdb) de la base de datos.  
  
### <a name="to-install-the-sample"></a>Para instalar el ejemplo  
  
1.  Compruebe que su sistema cumple todos los requisitos de configuración que se describe en la página de inicio de instalación de Visual Studio.  
  
2.  Instalar Visual Studio y siga todas las instrucciones de instalación y configuración para los ejemplos incluidos.  
  
#### <a name="to-build-the-sample"></a>Para compilar el ejemplo  
  
1.  Abra el archivo Dia2dump.sln en Visual Studio. (Si es necesario, Visual Studio le primero permitirá actualizar el proyecto de Dia2dump.)  
  
2.  En las páginas de propiedades de proyecto, en la **C/C++** &#124; **General** &#124; **Directorios de inclusión adicionales** propiedad, especifique el `..\DIA SDK\include` directory. Esto garantiza que el compilador pueda encontrar el archivo dia2.h.  
  
3.  En el **generar** menú, haga clic en **volver a generar solución**.  
  
4.  Cierre Visual Studio.  
  
#### <a name="to-run-the-sample"></a>Para ejecutar el ejemplo  
  
1.  Abra un símbolo del sistema y escriba lo siguiente:  
  
    ```  
    dia2dump filename  
    ```  
  
## <a name="see-also"></a>Vea también  
 [Origen Dia2dump.cpp](../../debugger/debug-interface-access/dia2dump-cpp-source-file.md)   
 [Portar, migrar y actualizar proyectos de Visual Studio](../../porting/port-migrate-and-upgrade-visual-studio-projects.md)