---
title: "Introducción a los lenguajes específicos de dominio | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 024392a2-2c04-404f-a27b-7273553c3b60
caps.latest.revision: 16
author: alancameronwills
ms.author: awills
manager: douge
translation.priority.mt:
- cs-cz
- de-de
- es-es
- fr-fr
- it-it
- ja-jp
- ko-kr
- pl-pl
- pt-br
- ru-ru
- tr-tr
- zh-cn
- zh-tw
translationtype: Machine Translation
ms.sourcegitcommit: 3d07f82ea737449fee6dfa04a61e195654ba35fa
ms.openlocfilehash: 8bd2f054db2c69a99218af05ca8d12465731ebca
ms.lasthandoff: 02/22/2017

---
# <a name="getting-started-with-domain-specific-languages"></a>Introducción a los lenguajes específicos de dominio
En este tema se explica los conceptos básicos de la definición y uso de un lenguaje específico de dominio (DSL) creado con el SDK de modelado de Visual Studio.  


[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

  
 Si está familiarizado con DSL, recomendamos que trabaje en el **laboratorio de herramientas DSL**, que encontrará en este sitio: [visualización y modelado de SDK](http://go.microsoft.com/fwlink/?LinkID=186128)  
  
## <a name="what-can-you-do-with-a-domain-specific-language"></a>¿Qué puede hacer con un lenguaje específico de dominio?  
 Un lenguaje específico de dominio es una notación normalmente gráfica, que está diseñado para utilizarse para un propósito determinado. En cambio, los lenguajes como UML son uso generales. En un DSL, puede definir los tipos de elemento de modelo y sus relaciones y cómo se presentan en la pantalla.  
  
 Al diseñar un DSL, puede distribuirla como parte de un paquete de extensión de integración de Visual Studio (VSIX). Los usuarios trabajan con DSL en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]:  
  
 ![Diagrama de árbol genealógico, cuadro de herramientas y el explorador](../modeling/media/familyt_instance.png "FamilyT_Instance")  
  
 La notación es sólo una parte de un DSL. Junto con la notación, el paquete VSIX incluye herramientas que se pueden aplicar a los usuarios para ayudarles a editar y generar material de sus modelos.  
  
 Una de las aplicaciones principales de DSL es generar código de programa, archivos de configuración y otros artefactos. Especialmente en proyectos grandes y líneas de productos, donde se creará varias variantes de un producto, generar muchos de los aspectos variables de DSL puede proporcionar un gran aumento de confiabilidad y una respuesta rápidamente a los cambios de requisitos.  
  
 El resto de esta introducción es un tutorial que explica las operaciones básicas de creación y uso de un lenguaje específico de dominio en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
## <a name="prerequisites"></a>Requisitos previos  
 Para definir un DSL, debe tener instalados los siguientes componentes:  
  
|||  
|-|-|  
|[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]|[http://go.Microsoft.com/fwlink/?LinkId=185579](http://go.microsoft.com/fwlink/?LinkId=185579)|  
|[!INCLUDE[vssdk_current_short](../modeling/includes/vssdk_current_short_md.md)]|[http://go.Microsoft.com/fwlink/?LinkId=185580](http://go.microsoft.com/fwlink/?LinkId=185580)|  
|Modelar el SDK de Visual Studio||  


[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

  
## <a name="creating-a-dsl-solution"></a>Creación de una solución DSL  
 Para crear un nuevo lenguaje específico de dominio, cree un nuevo [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solución mediante la plantilla de proyecto de lenguaje específico de dominio.  
  
#### <a name="to-create-a-dsl-solution"></a>Para crear una solución de DSL  
  
1.  En el menú **Archivo** , elija **Nuevo**y haga clic en **Proyecto**.  
  
2.  En **tipos de proyecto**, expanda la **otros tipos de proyectos** nodo y haga clic en **extensibilidad**.  
  
3.  Haga clic en **Diseñador de lenguaje específico de dominio**.  
  
     ![Crear cuadro de diálogo DSL](../modeling/media/create_dsldialog.png "Create_DSLDialog")  
  
4.  En el **nombre** , escriba **FamilyTree**. Haga clic en **Aceptar**.  
  
     El **Asistente de lenguaje específico de dominio** abre y muestra una lista de soluciones DSL de plantilla.  
  
     Haga clic en cada plantilla para ver una descripción  
  
     Las plantillas son útiles puntos de partida. Cada uno de ellos proporciona un DSL, que se puede editar para satisfacer sus necesidades de trabajo completando. Normalmente, elija la plantilla más cercano que desea crear.  
  
5.  En este tutorial, elija la **lenguaje mínimo** plantilla.  
  
6.  Escriba una extensión de nombre de archivo para su DSL en la página del asistente correspondiente. Esta es la extensión que usarán los archivos que contienen instancias de su DSL.  
  
    -   Elija una extensión que no está asociada a ninguna aplicación en el equipo o en cualquier equipo donde desea instalar el DSL. Por ejemplo, **docx** y **htm** sería inaceptable archivo extensiones de nombre.  
  
    -   El asistente le advertirá en caso de que la extensión que haya especificado se esté usando como un DSL. Piense en usar una extensión de nombre de archivo diferente. También puede restablecer la instancia de Visual Studio SDK Experimental para borrar antiguos diseñadores experimentales. Haga clic en **iniciar**, haga clic en **todos los programas**, **Microsoft Visual Studio 2010 SDK**, **herramientas**y, a continuación, **restablecer la instancia de Microsoft Visual Studio 2010 Experimental**.  
  
7.  Inspeccionar las otras páginas y, a continuación, haga clic en **finalizar**.  
  
     Se genera una solución que contiene dos proyectos. Se denominan Dsl y DslPackage. Un archivo de diagrama abre con nombre DslDefinition.dsl.  
  
    > [!NOTE]
    >  La mayoría del código que se puede ver en las carpetas de los dos proyectos se genera a partir de DslDefinition.dsl. Por este motivo, la mayoría su DSL modificaciones en este archivo.  
  
 Ahora, la interfaz de usuario es similar a la imagen siguiente.  
  
 ![Diseñador DSL](../modeling/media/dsl_designer.png "dsl_designer")  
  
 Esta solución define un lenguaje específico de dominio. Para obtener más información, consulte [información general de la interfaz de usuario de herramientas de lenguaje específico de dominio](../modeling/overview-of-the-domain-specific-language-tools-user-interface.md).  
  
## <a name="the-important-parts-of-the-dsl-solution"></a>Las partes importantes de la solución de DSL  
 Tenga en cuenta los siguientes aspectos de la nueva solución.  
  
-   **Dsl\DslDefinition.DSL** es el archivo que aparece cuando se crea una solución de DSL. Casi todo el código de la solución se genera a partir de este archivo y la mayoría de los cambios que realice en una definición de DSL se realiza aquí. Para obtener más información, consulte trabajo con el [trabajar con diagramas de definición DSL](../modeling/working-with-the-dsl-definition-diagram.md).  
  
-   **Proyecto DSL** este proyecto contiene código que define el lenguaje específico de dominio.  
  
-   **Proyecto DslPackage** este proyecto contiene código que permite que las instancias del DSL para abrir y editar en [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
##  <a name="a-namedebugginga-running-the-dsl"></a><a name="Debugging"></a>Ejecuta el DSL  
 Puede ejecutar la solución de DSL tan pronto como se ha creado. Más adelante, puede modificar la definición de DSL gradualmente, ejecutando la solución de nuevo después de cada cambio.  
  
#### <a name="to-experiment-with-the-dsl"></a>Para experimentar con el DSL  
  
1.  Haga clic en **Transformar todas las plantillas** en la barra de herramientas del explorador de soluciones. Esto vuelve a generar la mayor parte del código fuente de DslDefinition.dsl.  
  
    > [!NOTE]
    >  Cada vez que cambie DslDefinition.dsl, debe hacer clic en **Transformar todas las plantillas** antes de volver a generar la solución. Este paso se puede automatizar. Para obtener más información, consulte [cómo automatizar Transformar todas las plantillas](http://msdn.microsoft.com/en-us/b63cfe20-fe5e-47cc-9506-59b29bca768a).  
  
2.  Presione F5, o en la **depurar** menú, haga clic en **Iniciar depuración**.  
  
     DSL se crea y está instalado en la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
     Se iniciará una instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. La instancia experimental toma sus valores de un subárbol independiente del registro, donde [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] extensiones están registradas con fines de depuración. Las instancias normales de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] no tiene acceso a las extensiones registradas no existe.  
  
3.  En la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], abra el archivo de modelo denominado **prueba** de **el Explorador de soluciones**.  
  
     \- o -  
  
     Haga clic en el proyecto de depuración, seleccione **agregar**y, a continuación, haga clic en **elemento**. En el **Agregar elemento** cuadro de diálogo, seleccione el tipo de archivo de su DSL.  
  
     Se abre el archivo de modelo como un diagrama en blanco.  
  
     El cuadro de herramientas se abre y muestra las herramientas apropiadas para el tipo de diagrama.  
  
4.  Utilice las herramientas para crear formas y conectores del diagrama.  
  
    1.  Para crear formas, arrastre desde la herramienta de forma de ejemplo al diagrama.  
  
    2.  Para conectar dos formas, haga clic en la herramienta Conector de ejemplo, haga clic en la primera forma y, a continuación, haga clic en la segunda forma.  
  
5.  Haga clic en las etiquetas de las formas para cambiarlos.  
  
 La instancia experimental [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] se asemejarán al ejemplo siguiente:  
  
 ![](../modeling/media/dsl_min.png "DSL_min")  
  
### <a name="the-content-of-a-model"></a>El contenido de un modelo  
 El contenido de un archivo que es una instancia de un DSL se denomina un *modelo*. El modelo contiene *modelo**elementos* y *vínculos* entre los elementos. La definición de DSL especifica qué tipos de elementos del modelo y vínculos pueden existir en el modelo. Por ejemplo, en un DSL creado a partir de la plantilla de idioma mínimo, hay un tipo de elemento de modelo y un tipo de vínculo.  
  
 La definición de DSL puede especificar cómo aparece el modelo en un diagrama. Puede elegir entre una variedad de estilos de formas y conectores. Puede especificar que algunas formas aparecen dentro de otras formas.  
  
 Puede ver un modelo como un árbol en el **Explorer** ver mientras se edita un modelo. Cuando se agregan formas al diagrama, los elementos del modelo también aparecen en el explorador. El explorador puede utilizarse incluso si no hay ningún diagrama.  
  
 Si no puede ver el explorador en la instancia de depuración de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], en la **vista** menú, seleccione **otras ventanas**y, a continuación, haga clic en * \<su lenguaje >* **Explorer**.  
  
### <a name="the-api-of-your-dsl"></a>La API de su DSL  
 Su DSL genera una API que permite leer y actualizar modelos que son instancias de la DSL. Es una aplicación de API generar archivos de texto de un modelo. Para obtener más información, consulte [generación de código de tiempo de diseño mediante el uso de plantillas de texto T4](../modeling/design-time-code-generation-by-using-t4-text-templates.md).  
  
 En la solución de depuración, abra los archivos de plantilla con la extensión "tt". Estos ejemplos muestran cómo puede generar texto en modelos y le permiten probar la API de su DSL. Uno de los ejemplos se escribe [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)], el otro en [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)].  
  
 En cada plantilla de archivo es el archivo que genera. Expanda el archivo de plantilla en el Explorador de soluciones y abra el archivo generado.  
  
 El archivo de plantilla contiene un segmento corto de código que enumera todos los elementos del modelo.  
  
 El archivo generado contiene el resultado.  
  
 Cuando se cambia un archivo de modelo, verá los cambios correspondientes en los archivos generados después de regenerar los archivos.  
  
##### <a name="to-regenerate-text-files-after-you-change-the-model-file"></a>Volver a generar archivos de texto después de cambiar el archivo de modelo  
  
1.  En la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], guarde el archivo de modelo.  
  
2.  Asegúrese de que el parámetro de nombre de archivo en cada archivo .tt hace referencia al archivo de modelo que está usando para los experimentos. Guarde el archivo .tt.  
  
3.  Haga clic en **Transformar todas las plantillas** en la barra de herramientas de **el Explorador de soluciones**.  
  
     \- o -  
  
     Haga clic en las plantillas que desea volver a generar y, a continuación, haga clic en **ejecutar herramienta personalizada**.  
  
 Puede agregar cualquier número de archivos de plantilla de texto a un proyecto. Cada plantilla genera un archivo de resultados.  
  
> [!NOTE]
>  Al cambiar la definición de DSL, el código de plantilla de texto de ejemplo no funcionará, a menos que lo actualice.  
  
 Para obtener más información, consulte [generar código desde un lenguaje específico de dominio](../modeling/generating-code-from-a-domain-specific-language.md) y [escribir el código para personalizar un lenguaje específico de dominio](../modeling/writing-code-to-customise-a-domain-specific-language.md).  
  
## <a name="customizing-the-dsl"></a>Personalizar el DSL  
 Si desea modificar la definición de DSL, cierre la instancia experimental y actualice la definición de los principales [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] instancia.  
  
> [!NOTE]
>  Después de modificar la definición de DSL, podría perder la información en los modelos de prueba creados con versiones anteriores.  Por ejemplo, la solución de depuración contiene un archivo denominado ejemplo, que contiene algunas formas y conectores. Después de empezar a desarrollar su definición de DSL, no estará visibles y se perderán cuando se guarde el archivo.  
  
 Puede realizar una amplia variedad de extensiones en su DSL. Los ejemplos siguientes le proporcionará una impresión de las posibilidades.  
  
 Después de cada cambio, guarde la definición de DSL, haga clic en **Transformar todas las plantillas** en **el Explorador de soluciones**y, a continuación, presione **F5** para experimentar con el DSL modificado.  
  
### <a name="rename-the-types-and-tools"></a>Cambiar el nombre de los tipos y herramientas  
 Cambiar el nombre de las clases de dominio existentes y relaciones. Por ejemplo, a partir de una definición de Dsl creado a partir de la plantilla de idioma mínima, podría realizar las siguientes operaciones de cambio de nombre, para hacer el DSL representan árboles de familia.  
  
##### <a name="to-rename-domain-classes-relationships-and-tools"></a>Para cambiar el nombre de las herramientas, las relaciones y las clases de dominio  
  
1.  En el diagrama DslDefinition, cambie el nombre **ExampleModel** a **FamilyTreeModel**, **ExampleElement** a **persona**, **destinos** a **padres**, y **orígenes** a **hijos**. Puede hacer clic en cada etiqueta para cambiarla.  
  
     ![Diagrama de definición DSL - modelo de árbol genealógico](../modeling/media/familyt_person.png "FamilyT_Person")  
  
2.  Cambiar el nombre de las herramientas de elemento y el conector.  
  
    1.  Abra la ventana del explorador de DSL haciendo clic en la pestaña en el Explorador de soluciones. Si no lo ve, en la **vista** menú, seleccione **otras ventanas** y, a continuación, haga clic en **DSL Explorer**. Explorador de DSL sólo es visible cuando el diagrama de la definición de DSL es la ventana activa.  
  
    2.  Abra la ventana Propiedades y colóquelo para que puedan ver el Explorador de DSL y propiedades al mismo tiempo.  
  
    3.  En el Explorador de DSL, expanda **Editor**, **Toolbox Tabs**, * \<su DSL >*y, a continuación, **herramientas**.  
  
    4.  Haga clic en **ExampleElement**. Éste es el elemento de cuadro de herramientas que se utiliza para crear elementos.  
  
    5.  En la ventana Propiedades, cambie la **nombre** propiedad **persona**.  
  
         Observe que la **título** propiedad también cambia.  
  
    6.  En la misma manera, cambie el nombre de la **ExampleConnector** herramienta **ParentLink**. Modificar el **título** propiedad para que no sea una copia de la propiedad Name. Por ejemplo, escriba **vínculo primario**.  
  
3.  Vuelva a generar el DSL.  
  
    1.  Guarde el archivo de definición de DSL.  
  
    2.  Haga clic en **Transformar todas las plantillas** en la barra de herramientas del explorador de soluciones  
  
    3.  Presione F5. Espere hasta que la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] aparece.  
  
4.  En la solución de depuración en la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], abra el archivo de modelo de prueba. Arrastrar elementos a él desde el cuadro de herramientas. Observe que se han cambiado los títulos de herramienta y los nombres de tipo Explorador de DSL.  
  
5.  Guarde el archivo de modelo.  
  
6.  Abra un archivo .tt y reemplazar las apariciones de los nombres de propiedad y tipo anteriores con los nuevos nombres.  
  
7.  Asegúrese de que el nombre de archivo que se especifica en el archivo .tt especifica el modelo de prueba.  
  
8.  Guarde el archivo .tt. Abra el archivo generado para ver el resultado de la ejecución del código en el archivo .tt. Compruebe que es correcta.  
  
### <a name="add-domain-properties-to-classes"></a>Agregar propiedades de dominio a clases  
 Agregar propiedades a una clase de dominio, por ejemplo para representar los años de nacimiento y la muerte de una persona.  
  
 Para hacer que las nuevas propiedades visible en el diagrama, debe agregar *decoradores* a la forma en que se muestra el elemento de modelo. También debe asignar las propiedades a los elementos Decorator.  
  
##### <a name="to-add-properties-and-display-them"></a>Para agregar propiedades y mostrarlos  
  
1.  Agregue las propiedades.  
  
    1.  En el diagrama de la definición de DSL, haga clic en el **persona** clase de dominio, seleccione **agregar**y, a continuación, haga clic en **propiedad de dominio**.  
  
    2.  Escriba una lista de los nuevos nombres de propiedad, como **nacimiento** y **muerte**. Presione **ENTRAR** después de cada uno de ellos.  
  
2.  Agregue elementos Decorator que mostrará las propiedades de la forma.  
  
    1.  Siga la línea gris que abarca desde la clase de dominio de la persona a la otra parte del diagrama. Se trata de una asignación de elemento del diagrama. La clase de dominio está vinculado a una clase de la forma.  
  
    2.  Haga clic en esta clase de forma, seleccione **agregar**y, a continuación, haga clic en **Decorator de texto**.  
  
    3.  Agregue dos elementos Decorator con nombres como **BirthDecorator** y **DeathDecorator**.  
  
    4.  Seleccione cada elemento decorator nueva y, en la ventana Propiedades, establezca la **posición** campo. Esto determina dónde se mostrará el valor de la propiedad de dominio de la forma. Por ejemplo, establecer **InnerBottomLeft** y **InnerBottomRight**.  
  
         ![Definición de la forma de compartimiento](../modeling/media/familyt_compartment.png "FamilyT_Compartment")  
  
3.  Los elementos Decorator se asignan a las propiedades.  
  
    1.  Abra la ventana de detalles de DSL. Normalmente está en una ficha situada junto a la ventana de salida. Si no lo ve, en la **vista** menú, seleccione **otras ventanas**y, a continuación, haga clic en **detalles de DSL**.  
  
    2.  En el diagrama de definición de DSL, haga clic en la línea que conecta el **persona** clase de dominio para la clase shape.  
  
    3.  En **detalles de DSL**, en la **Decorator Maps** ficha, haga clic en la casilla de verificación en un decorador no asignada. En **propiedad Display**, seleccione la propiedad de dominio al que desea asignar. Por ejemplo, asignar **BirthDecorator** a **nacimiento**.  
  
4.  Guarde el DSL, haga clic en Transformar todas las plantillas y presione F5.  
  
5.  En un diagrama de modelo de ejemplo, compruebe que ahora puede hacer clic en las posiciones que seleccionó y escriba valores en ellos. Además, cuando se selecciona un **persona** forma, la ventana Propiedades muestra las nuevas propiedades de nacimiento y la muerte.  
  
6.  En un archivo .tt, puede agregar código que obtiene las propiedades de cada persona.  
  
 ![Diagrama de árbol genealógico, cuadro de herramientas y el explorador](../modeling/media/familyt_instance.png "FamilyT_Instance")  
  
### <a name="define-new-classes"></a>Definir nuevas clases  
 Puede agregar clases de dominio y las relaciones en un modelo. Por ejemplo, podría crear una nueva clase para representar las ciudades y una nueva relación para representar que una persona vive en una ciudad.  
  
 Para hacer que los distintos tipos distintos en un diagrama de modelo, puede asignar las clases de dominio diferentes tipos de forma o formas con colores y geometría diferente.  
  
##### <a name="to-add-and-display-a-new-domain-class"></a>Agregar y mostrar una nueva clase de dominio  
  
1.  Agregar una clase de dominio y convertirlo en un elemento secundario de la raíz del modelo.  
  
    1.  En el diagrama de la definición de DSL, haga clic en el **relación de incrustación** de la herramienta, haga clic en la clase raíz **FamilyTreeModel**y, a continuación, haga clic en una parte vacía del diagrama.  
  
         Aparece una nueva clase de dominio, que está conectado a la FamilyTreeModel con una relación de incrustación.  
  
         Establezca su nombre, por ejemplo **Town**.  
  
        > [!NOTE]
        >  Cada clase de dominio excepto la raíz del modelo debe ser el destino de al menos una relación de incrustación o deben heredar de una clase que es el destino de una inserción. Por este motivo, es conveniente con frecuencia crear una clase de dominio mediante la herramienta de relación de incrustación.  
  
    2.  Agregar una propiedad de dominio a la nueva clase, por ejemplo **nombre**.  
  
2.  Agregar una relación de referencia entre la persona y ciudad.  
  
    1.  Haga clic en el **relación de referencia** de herramientas, haga clic en persona y, a continuación, haga clic en Ciudad.  
  
         ![Fragmento de definición DSL: raíz de árbol genealógico](../modeling/media/familyt_root.png "FamilyT_Root")  
  
        > [!NOTE]
        >  Relaciones de referencia representan referencias cruzadas de una parte del árbol del modelo a otro.  
  
3.  Agregar una forma para representar ciudades en los diagramas de modelo.  
  
    1.  Arrastre un **forma geométrica** del cuadro de herramientas al diagrama y cámbiele el nombre, por ejemplo **TownShape**.  
  
    2.  En la ventana Propiedades, establezca los campos de la apariencia de la nueva forma, como el Color de relleno y Geometry.  
  
    3.  Agregar un elemento Decorator para mostrar el nombre de la ciudad y cámbiele el nombre NameDecorator. Establezca su propiedad de posición.  
  
4.  Asignar la clase de dominio de la ciudad a la TownShape.  
  
    1.  Haga clic en el **asignación de elemento de diagrama** de herramientas, a continuación, haga clic en la clase de dominio de ciudad y, a continuación, la clase de forma TownShape.  
  
    2.  En el **Decorator Maps** ficha de la **detalles de DSL** seleccionado de la ventana con el conector de mapa, comprobar NameDecorator y establecer **propiedad Display** al nombre.  
  
5.  Crear un conector para mostrar la relación entre la persona y ciudades.  
  
    1.  Arrastre un conector en el cuadro de herramientas al diagrama. Cámbiele el nombre y establecer sus propiedades de apariencia.  
  
    2.  Utilice la **asignación de elemento de diagrama** herramienta para vincular el nuevo conector a la relación entre la persona y ciudad.  
  
         ![Definición de árbol genealógico con asignación de forma agregada](../modeling/media/familyt_shapemap.png "FamilyT_ShapeMap")  
  
6.  Crear una herramienta de elemento para realizar una ciudad de nuevo.  
  
    1.  En **DSL Explorer**, expanda **Editor** , a continuación, **Toolbox Tabs**.  
  
    2.  Haga clic en * \<su DSL >* y, a continuación, haga clic en **agregar una nueva herramienta de elemento**.  
  
    3.  Establecer el **nombre** propiedad de la nueva herramienta y establezca su **clase** propiedad a la misma ciudad.  
  
    4.  Establecer el **icono cuadro de herramientas** propiedad. Click **[...] ** y en el **nombre de archivo** , seleccione un archivo de icono.  
  
7.  Crear una herramienta de conector para hacer que un vínculo entre pueblos y personas.  
  
    1.  Haga clic en * \<su DSL >* y, a continuación, haga clic en **agregar nueva herramienta conector**.  
  
    2.  Establezca la propiedad de nombre de la nueva herramienta.  
  
    3.  En el **ConnectionBuilder** propiedad, seleccione el generador que contiene el nombre de la relación de la ciudad de la persona.  
  
    4.  Establecer el **icono cuadro de herramientas**.  
  
8.  Guardar la definición de DSL, haga clic en **Transformar todas las plantillas**y, a continuación, presione **F5**.  
  
9. En la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], abra el archivo de modelo de prueba. Utilizar las nuevas herramientas para crear pueblos y vínculos entre los pueblos y las personas. Tenga en cuenta que sólo puede crear vínculos entre los tipos correctos de elemento.  
  
10. Crear código que muestra la ciudad en la que reside cada persona. Plantillas de texto son uno de los lugares donde puede ejecutar dicho código. Por ejemplo, podría modificar el archivo de Sample.tt existente en la solución de depuración para que contenga el código siguiente:  
  
    ```  
    <#@ template inherits="Microsoft.VisualStudio.TextTemplating.VSHost.ModelingTextTransformation" debug="true" #>  
    <#@ output extension=".txt" #>  
    <#@ FamilyTree processor="FamilyTreeDirectiveProcessor" requires="fileName='Sample.ftree'" #>  
  
    <#  
      foreach (Person person in this.FamilyTreeModel.People)  
      {  
    #>  
        <#= person.Name #><#if (person.Town != null) {#> of <#= person.Town.Name #> <#}#>  
  
    <#  
          foreach (Person child in person.Children)  
      {  
    #>  
                <#= child.Name #>  
    <#  
      }  
      }  
    #>  
  
    ```  
  
     Cuando se guarda el archivo *.tt, creará un archivo subsidiario que contiene la lista de personas y sus Residencias. Para obtener más información, consulte [generar código desde un lenguaje específico de dominio](../modeling/generating-code-from-a-domain-specific-language.md).  
  
## <a name="validation-and-commands"></a>Validación y comandos  
 También puede desarrollar aún más este DSL agregando restricciones de validación. Estas restricciones son métodos que se pueden definir, asegúrese de que el modelo está en un estado correcto. Por ejemplo, podría definir una restricción para asegurarse de que la fecha de nacimiento de un elemento secundario es posterior a la de sus elementos primarios. La característica de validación muestra una advertencia si el usuario DSL intenta guardar un modelo que infringe alguna de las restricciones. Para obtener más información, consulte [validación en un lenguaje específico de dominio](../modeling/validation-in-a-domain-specific-language.md).  
  
 También puede definir los comandos de menú que el usuario puede invocar. Comandos pueden modificar el modelo. También pueden interactuar con otros modelos de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] y con los recursos externos. Para obtener más información, consulte [Cómo: modificar un comando de menú estándar](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).  
  
## <a name="deploying-the-dsl"></a>Implementación de DSL  
 Para permitir que otros usuarios utilicen el lenguaje específico de dominio, se distribuye un [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] el archivo de extensión (VSIX). Se crea cuando se compila la solución DSL.  
  
 Busque el archivo .vsix en la carpeta bin de la solución. Cópielo en el equipo en el que desea instalar. En el equipo, haga doble clic en el archivo VSIX. La DSL puede utilizarse en todas las instancias de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] en ese equipo.  
  
 Puede utilizar el mismo procedimiento para instalar el DSL en su propio equipo, por lo que no es necesario usar la instancia experimental de [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
 Para obtener más información, consulte [implementar soluciones de lenguajes específicos de dominio](../modeling/deploying-domain-specific-language-solutions.md).  
  
##  <a name="a-namereseta-removing-old-experimental-dsls"></a><a name="Reset"></a>Quitar el antiguo DSL Experimental  
 Si ha creado experimental DSL que ya no desea, puede quitarlos del equipo restableciendo el [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] instancia Experimental.  
  
 Esto quitará del equipo todos los lenguajes DSL experimental y otros experimental [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] extensiones. Se trata de extensiones que se han ejecutado en modo de depuración.  
  
 Este procedimiento no quita DSL u otro [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] extensiones que se han instalado completamente ejecutando el archivo VSIX.  
  
#### <a name="to-reset-the-visual-studio-experimental-instance"></a>Para restablecer la instancia Experimental de Visual Studio  
  
1.  Haga clic en **iniciar**, haga clic en **todos los programas**, **Microsoft Visual Studio 2010 SDK**, **herramientas**y, a continuación, **restablecer la instancia de Microsoft Visual Studio 2010 Experimental**.  
  
2.  Volver a generar cualquier DSL experimental o en otros experimental [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] extensiones que desea utilizar.  
  
## <a name="see-also"></a>Vea también  
 [Las relaciones, las clases y descripción de los modelos](../modeling/understanding-models-classes-and-relationships.md)   
 [Cómo definir lenguajes específicos de dominio](../modeling/how-to-define-a-domain-specific-language.md)   

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

