---
title: "Tutorial: Analizar código de c/c ++ en previsión de defectos | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- C/C++, code analysis
- code analysis, walkthroughs
- code, analyzing C/C++
- code analysis tool, walkthroughs
ms.assetid: eaee55b8-85fe-47c7-a489-9be0c46ae8af
caps.latest.revision: "35"
author: mikeblome
ms.author: mblome
manager: ghogen
ms.workload: cplusplus
ms.openlocfilehash: c95d03201fe9c84e01e83e7fd55bef83755337e7
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="walkthrough-analyzing-cc-code-for-defects"></a>Tutorial: Analizar código de C/C++ en previsión de defectos
Este tutorial muestra cómo analizar código de C/C ++ en previsión de posibles defectos de código mediante la herramienta de análisis de código para código de C o C++.  
  
 En este tutorial, paso a través del proceso de uso de análisis de código para analizar el código de C/C ++ en previsión de defectos de código potenciales.  
  
 Se realizarán los pasos siguientes:  
  
-   Ejecutar análisis de código en código nativo.  
  
-   Analizar las advertencias de defectos de código.  
  
-   Tratar advertencia como un error.  
  
-   Agregar una anotación de código fuente para mejorar el análisis de defectos de código.  
  
## <a name="prerequisites"></a>Requisitos previos  
  
-   [!INCLUDE[vsPreLong](../code-quality/includes/vsprelong_md.md)] o [!INCLUDE[vsUltLong](../code-quality/includes/vsultlong_md.md)].  
  
-   Una copia de la [ejemplo de demostración](../code-quality/demo-sample.md).  
  
-   Conocimientos básicos de C o C++.  
  
### <a name="to-run-code-defect-analysis-on-native-code"></a>Para ejecutar el análisis de defectos de código en código nativo  
  
1.  Abra la solución Demo en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
     La solución Demo rellenará **el Explorador de soluciones**.  
  
2.  En el **generar** menú, haga clic en **volver a generar solución**.  
  
     La solución se compila sin errores ni advertencias.  
  
3.  En **el Explorador de soluciones**, seleccione el proyecto CodeDefects.  
  
4.  En el menú **Proyecto**, haga clic en **Propiedades**.  
  
     El **páginas de propiedades de CodeDefects** se muestra el cuadro de diálogo.  
  
5.  Haga clic en **de análisis de código**.  
  
6.  Haga clic en el **Habilitar análisis de código para C/C ++ al compilar** casilla de verificación.  
  
7.  Vuelva a generar el proyecto CodeDefects.  
  
     Advertencias de análisis de código se muestran en la **lista de errores**.  
  
### <a name="to-analyze-code-defect-warnings"></a>Para analizar las advertencias de defectos de código  
  
1.  En el **vista** menú, haga clic en **lista de errores**.  
  
     Dependiendo del perfil del desarrollador que eligió en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], es posible que deba hacer **otras ventanas** en el **vista** menú y, a continuación, haga clic en **lista de errores**.  
  
2.  En el **lista de errores**, haga doble clic en la siguiente advertencia:  
  
     Advertencia C6230: conversión implícita entre tipos semánticamente diferentes: usando HRESULT en un contexto booleano.  
  
     El editor de código muestra la línea que produjo la advertencia en la función `bool``ProcessDomain()`. Esta advertencia indica que se está utilizando un valor de HRESULT en una instrucción 'if' donde se espera un resultado booleano.  
  
3.  Corregir esta advertencia mediante la macro SUCCEEDED. El código debe ser similar al código siguiente:  
  
    ```  
    if (SUCCEEDED (ReadUserAccount()) )  
    ```  
  
4.  En el **lista de errores**, haga doble clic en la siguiente advertencia:  
  
     Advertencia C6282: Operador incorrecto: asignación de constante en el contexto de prueba. ¿Pretendía indicar ==?  
  
5.  Corregir esta advertencia mediante la comprobación de igualdad. El código debe ser similar al código siguiente:  
  
    ```  
    if ((len == ACCOUNT_DOMAIN_LEN) || (g_userAccount[len] != '\\'))  
    ```  
  
### <a name="to-treat-warning-as-an-error"></a>Tratar advertencia como un error  
  
1.  En el archivo Bug.cpp, agregue las siguientes `#pragma` instrucción al principio del archivo para tratar la advertencia C6001 como un error:  
  
    ```  
    #pragma warning (error: 6001)  
    ```  
  
2.  Vuelva a generar el proyecto CodeDefects.  
  
     En el **lista de errores**, C6001 aparecerá ahora como un error.  
  
3.  Corrija los dos errores de C6001 restantes en el **lista de errores** inicializando `i` y `j` en 0.  
  
4.  Vuelva a generar el proyecto CodeDefects.  
  
     El proyecto se compila sin errores ni advertencias.  
  
### <a name="to-correct-the-source-code-annotation-warnings-in-annotationc"></a>Para corregir las advertencias de anotación de código fuente en annotation.c  
  
1.  En el Explorador de soluciones, seleccione el proyecto de anotaciones.  
  
2.  En el menú **Proyecto**, haga clic en **Propiedades**.  
  
     El **páginas de propiedades de las anotaciones** se muestra el cuadro de diálogo.  
  
3.  Haga clic en **de análisis de código**.  
  
4.  Seleccione el **Habilitar análisis de código para C/C ++ al compilar** casilla de verificación.  
  
5.  Recompile el proyecto de anotaciones.  
  
6.  En el **lista de errores**, haga doble clic en la siguiente advertencia:  
  
     Advertencia C6011: Desreferenciación del puntero NULL 'newNode'.  
  
     Esta advertencia indica un error por el llamador para comprobar el valor devuelto. En este caso, una llamada a **AllocateNode** podría devolver un valor NULL (vea el archivo de encabezado annotations.h para la declaración de función correspondiente a AllocateNode).  
  
7.  Abra el archivo annotations.cpp.  
  
8.  Para corregir esta advertencia, utilice una instrucción 'if' para probar el valor devuelto. El código debe ser similar al código siguiente:  
  
     `if (NULL != newNode)`  
  
     `{`  
  
     `newNode->data = value;`  
  
     `newNode->next = 0;`  
  
     `node->next = newNode;`  
  
     `}`  
  
9. Recompile el proyecto de anotaciones.  
  
     El proyecto se compila sin errores ni advertencias.  
  
### <a name="to-use-source-code-annotation"></a>Para utilizar la anotación del código fuente  
  
1.  Anotar parámetros formales y devolver el valor de la función `AddTail` utilizando las condiciones Pre y Post como se muestra en este ejemplo:  
  
     `[returnvalue:SA_Post (Null=SA_Maybe)] LinkedList* AddTail`  
  
     `(`  
  
     `[SA_Pre(Null=SA_Maybe)] LinkedList* node,`  
  
     `int value`  
  
     `)`  
  
2.  Recompile el proyecto de anotaciones.  
  
3.  En el **lista de errores**, haga doble clic en la siguiente advertencia:  
  
     Advertencia C6011: Desreferenciación del puntero NULL 'node'.  
  
     Esta advertencia indica que el nodo pasado a la función podría ser null e indica el número de línea donde se produjo la advertencia.  
  
4.  Para corregir esta advertencia, utilice una instrucción 'if' para probar el valor devuelto. El código debe ser similar al código siguiente:  
  
    ```  
    . . .  
    LinkedList *newNode = NULL;   
    if (NULL == node)  
    {  
         return NULL;  
        . . .  
    }  
    ```  
  
5.  Recompile el proyecto de anotaciones.  
  
     El proyecto se compila sin errores ni advertencias.  
  
## <a name="see-also"></a>Vea también  
 [Tutorial: Analizar código administrado en previsión de defectos de código](../code-quality/walkthrough-analyzing-managed-code-for-code-defects.md)