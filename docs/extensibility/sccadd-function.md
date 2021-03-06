---
title: "Función SccAdd | Documentos de Microsoft"
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: SccAdd
helpviewer_keywords: SccAdd function
ms.assetid: 545268f3-8e83-446a-a398-1a9db9e866e8
caps.latest.revision: "17"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: 52137da9d14920a2fd5213f1110a74d895e51c7f
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="sccadd-function"></a>SccAdd (función)
Esta función agrega nuevos archivos para el sistema de control de código fuente.  
  
## <a name="syntax"></a>Sintaxis  
  
```cpp  
SCCRTN SccAdd(  
   LPVOID    pvContext,  
   HWND      hWnd,  
   LONG      nFiles,  
   LPCSTR*   lpFileNames,  
   LPCSTR    lpComment,  
   LONG*     pfOptions,  
   LPCMDOPTS pvOptions  
);  
```  
  
#### <a name="parameters"></a>Parámetros  
 pvContext  
 [in] La estructura de contexto de complemento de control de código fuente.  
  
 hWnd  
 [in] Identificador de la ventana del IDE que puede usar el complemento de control de código fuente como elemento primario para los cuadros de diálogo que proporciona.  
  
 nFiles  
 [in] Número de archivos que seleccionó para agregarlo al proyecto actual como se indica en la `lpFileNames` matriz.  
  
 lpFileNames  
 [in] Matriz de nombres locales completos de archivos que se va a agregar.  
  
 lpComment  
 [in] El comentario que se aplicará a todos los archivos que se va a agregar.  
  
 pfOptions  
 [in] Matriz de marcas de comando proporcionada en una base por cada archivo.  
  
 pvOptions  
 [in] Opciones de específicas del complemento de control de origen.  
  
## <a name="return-value"></a>Valor devuelto  
 La implementación de complemento de control de origen de esta función debe devolver uno de los siguientes valores:  
  
|Valor|Descripción|  
|-----------|-----------------|  
|SCC_OK|La operación de agregar fue correcta.|  
|SCC_E_FILEALREADYEXISTS|El archivo seleccionado ya está bajo control de código fuente.|  
|SCC_E_TYPENOTSUPPORTED|El tipo de archivo (por ejemplo, binario) no es compatible con el sistema de control de código fuente.|  
|SCC_E_OPNOTSUPPORTED|El sistema de control de código fuente no admite esta operación.|  
|SCC_E_ACCESSFAILURE|Hubo un problema al obtener acceso al sistema de control de código fuente, probablemente debido a problemas de red o de contención. Se recomienda un reintento.|  
|SCC_E_NOTAUTHORIZED|El usuario no puede realizar esta operación.|  
|SCC_E_NONSPECIFICERROR|Error no determinado; agregar no lleva a cabo.|  
|SCC_I_OPERATIONCANCELED|Se canceló la operación antes de la finalización.|  
|SCC_I_RELOADFILE|Debe volver a cargar un archivo o proyecto.|  
|SCC_E_FILENOTEXIST|No se encontró el archivo local.|  
  
## <a name="remarks"></a>Comentarios  
 La habitual `fOptions` se reemplazan aquí por una matriz, `pfOptions`, con una `LONG` opción única especificación de cada archivo. Esto es porque el tipo de archivo puede variar desde archivos.  
  
> [!NOTE]
>  No es válido especificar ambos `SCC_FILETYPE_TEXT` y `SCC_FILETYPE_BINARY` opciones para el mismo archivo, pero es válido especificar ninguna de ellas. Establecer ninguna de ellas es lo mismo que establecer `SCC_FILETYPE_AUTO`, en cuyo caso el origen de control de complemento detecta automáticamente el tipo de archivo.  
  
 A continuación se muestra la lista de marcas que se usan en el `pfOptions` matriz:  
  
|Opción|Valor|Significado|  
|------------|-----------|-------------|  
|SCC_FILETYPE_AUTO|0 x 00|El complemento de control de código fuente debe detectar el tipo de archivo.|  
|SCC_FILETYPE_TEXT|0 x 01|Indica un archivo de texto ASCII.|  
|SCC_FILETYPE_BINARY|0 x 02|Indica un tipo de archivo que no sea texto ASCII.|  
|SCC_ADD_STORELATEST|0 x 04|Almacena solo la copia más reciente del archivo, no hay diferencias.|  
|SCC_FILETYPE_TEXT_ANSI|0 x 08|Trata el archivo como texto ANSI.|  
|SCC_FILETYPE_UTF8|0 x 10|Trata el archivo como texto Unicode en formato UTF8.|  
|SCC_FILETYPE_UTF16LE|0 x 20|Trata el archivo como texto Unicode en UTF16 Little Endian formato.|  
|SCC_FILETYPE_UTF16BE|0 x 40|Trata el archivo como texto Unicode en UTF16 Big Endian de formato.|  
  
## <a name="see-also"></a>Vea también  
 [Funciones de API de complemento de control de código fuente](../extensibility/source-control-plug-in-api-functions.md)