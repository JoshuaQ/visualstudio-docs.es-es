---
title: "Inicio rápido: Crear un proyecto de Python desde una plantilla en Visual Studio | Microsoft Docs"
ms.custom: 
ms.date: 09/25/2017
ms.reviewer: 
ms.suite: 
ms.technology: devlang-python
ms.devlang: python
ms.tgt_pltfrm: 
ms.topic: quickstart
caps.latest.revision: "1"
author: kraigb
ms.author: kraigb
manager: ghogen
ms.workload:
- python
- data-science
ms.openlocfilehash: 87fdca001430acc1ecef7e69b9afc2123dedafd0
ms.sourcegitcommit: 11740fed01cc602252ef698aaa11c07987b00570
ms.translationtype: HT
ms.contentlocale: es-ES
ms.lasthandoff: 01/12/2018
---
# <a name="quickstart-create-a-python-project-from-a-template-in-visual-studio"></a>Inicio rápido: Crear un proyecto de Python desde una plantilla en Visual Studio

Después de [instalar la compatibilidad con Python en Visual Studio 2017](installation.md), resulta fácil crear un nuevo proyecto de Python con una variedad de plantillas.

1. Inicie Visual Studio.

1. Seleccione **Archivo > Nuevo > Proyecto** (Ctrl+Shift+N). En el cuadro de diálogo **Nuevo proyecto**, busque “Python” y seleccione la plantilla que quiera. Tenga en cuenta que al seleccionar una plantilla se muestra una breve descripción de lo que proporciona esa plantilla. (Vea también [Proyectos de Python](python-projects.md#project-templates)).

    ![Cuadro de diálogo Nuevo proyecto con plantillas de Python en VS2017](media/projects-new-project-dialog2.png)

1. Para este inicio rápido, seleccione la plantilla “Aplicación de Python”, asigne al proyecto un nombre (por ejemplo, “MakePI”) y una ubicación, y seleccione **Aceptar**. 

1. Visual Studio crea el archivo de proyecto (un archivo `.pyproj` que se almacena en disco) junto con cualquier otro archivo descritos por la plantilla. Con la plantilla de “Aplicación de Python”, el proyecto contiene un único archivo vacío con el mismo nombre que el proyecto. El archivo se abre en el editor de Visual Studio de manera predeterminada.

    ![Proyecto resultante al usar la plantilla de la aplicación Python](media/projects-new-structure.png)

1. Agregue código al archivo abierto, como el código siguiente, que calcula y muestra 1000 dígitos de PI:

    ```python
    """ Print digits of PI; code adapted from the second, shorter solution
    at http://www.codecodex.com/wiki/Calculate_digits_of_pi#Python
    """

    from time import perf_counter

    def pi_digits_Python(digits):
        scale = 10000
        maxarr = int((digits / 4) * 14)
        arrinit = 2000
        carry = 0
        arr = [arrinit] * (maxarr + 1)
        output = ""

        for i in range(maxarr, 1, -14):
            total = 0
            for j in range(i, 0, -1):
                total = (total * j) + (scale * arr[j])
                arr[j] = total % ((j * 2) - 1)
                total = total / ((j * 2) - 1)

            output += "%04d" % (carry + (total / scale))
            carry = total % scale

        return output;

    def test_py():
        digits = 1000;

        start = perf_counter()
        output = pi_digits_Python(digits);
        elapsed = perf_counter() - start;

        print("PI to " + str(digits) + " digits in " + str(int(elapsed * 10000)/10000) + " seconds:")

        ## replace inserts the decimal point
        print(output.replace("3", "3.", 1))

    if __name__ == "__main__":
        test_py();
    ```

1. Ejecute el programa presionando CTRL+F5 o seleccionando **Depurar > Iniciar sin depurar** en el menú. Los resultados se muestran en una ventana de la consola.

## <a name="next-steps"></a>Pasos siguientes

> [!div class="nextstepaction"]
> [Tutorial: Trabajar con Python en Visual Studio](vs-tutorial-01-01.md)

## <a name="see-also"></a>Vea también

- [Creación de un entorno para un intérprete de Python existente](python-environments.md#creating-an-environment-for-an-existing-interpreter).
- [Instalación de la compatibilidad con Python en Visual Studio 2015 y versiones anteriores](installation.md).
- [Ubicaciones de instalación](installation.md#install-locations).
