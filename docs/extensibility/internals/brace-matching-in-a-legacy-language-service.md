---
title: Coincidencia de llaves en un servicio de lenguaje heredado | Documentos de Microsoft
ms.custom: 
ms.date: 11/04/2016
ms.reviewer: 
ms.suite: 
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords:
- brace matching
- language services [managed package framework], brace matching
ms.assetid: 4e3d0a70-f22f-49dd-92d8-edf48ab62b52
caps.latest.revision: "27"
author: gregvanl
ms.author: gregvanl
manager: ghogen
ms.workload: vssdk
ms.openlocfilehash: c496c65244f0ede0c3a6385f6cf1329479a17c22
ms.sourcegitcommit: 32f1a690fc445f9586d53698fc82c7debd784eeb
ms.translationtype: MT
ms.contentlocale: es-ES
ms.lasthandoff: 12/22/2017
---
# <a name="brace-matching-in-a-legacy-language-service"></a>Coincidencia de llaves en un servicio de lenguaje heredado
Coincidencia de llaves ayuda a los desarrolladores realizar un seguimiento de elementos del lenguaje que deben realizarse conjuntamente, como paréntesis y llaves. Cuando un programador escribe una llave de cierre, se resalta la llave de apertura.  
  
 Puede comparar dos o tres elementos que ocurren mismo tiempo, denominados pares y triples. Triples son conjuntos de tres elementos que ocurren mismo tiempo. Por ejemplo, en C#, la `foreach` instrucción constituye un triple: "`foreach()`","`{`", y "`}`". Los tres elementos se resaltan cuando se escribe la llave de cierre.  
  
 Los servicios de lenguaje heredado se implementan como parte de un paquete VSPackage, pero la forma más reciente para implementar características del servicio de lenguaje es utilizar las extensiones MEF. Para obtener más información acerca de la nueva forma de implementar la coincidencia de llaves, consulte [Tutorial: mostrar llaves coincidentes](../../extensibility/walkthrough-displaying-matching-braces.md).  
  
> [!NOTE]
>  Le recomendamos que empiece a usar el nuevo editor de API tan pronto como sea posible. Esto mejora el rendimiento de su servicio de lenguaje y le permiten aprovechar las nuevas características del editor.  
  
 El <xref:Microsoft.VisualStudio.Package.AuthoringSink> clase es compatible con ambos pares y triplica con el <xref:Microsoft.VisualStudio.Package.AuthoringSink.MatchPair%2A> y <xref:Microsoft.VisualStudio.Package.AuthoringSink.MatchTriple%2A> métodos.  
  
## <a name="implementation"></a>Implementación  
 El servicio de lenguaje es necesario identificar todos los elementos coincidentes en el idioma y, a continuación, buscar todos los pares coincidentes. Normalmente, esto se logra mediante la implementación <xref:Microsoft.VisualStudio.Package.IScanner> para detectar un idioma coincidente y, a continuación, usar el <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> método para que coincida con los elementos.  
  
 El <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> método llama el escáner para dividir la línea y devolver el token justo antes del símbolo de intercalación. El escáner indica que se ha encontrado un par de elementos de lenguaje estableciendo un valor de símbolo (token) de desencadenador de <xref:Microsoft.VisualStudio.Package.TokenTriggers> en el token actual. El <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> llamadas al método el <xref:Microsoft.VisualStudio.Package.Source.MatchBraces%2A> método que llama a su vez la <xref:Microsoft.VisualStudio.Package.LanguageService.BeginParse%2A> método con el valor de la razón de análisis de <xref:Microsoft.VisualStudio.Package.ParseReason> para buscar el elemento de lenguaje correspondiente. Cuando se encuentra el elemento de lenguaje correspondiente, se resaltan los elementos.  
  
 Para obtener una descripción completa de cómo escribir una llave desencadena el resaltado de llaves, consulte la sección "Ejemplo de operación analizar" en el tema [analizador del servicio de lenguaje heredado y el analizador](../../extensibility/internals/legacy-language-service-parser-and-scanner.md).  
  
## <a name="enabling-support-for-brace-matching"></a>Habilitar la compatibilidad para la coincidencia de llaves  
 El <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> atributo puede establecer el `MatchBraces`, `MatchBracesAtCaret`, y `ShowMatchingBrace` parámetros con nombre que establecen las propiedades correspondientes de la <xref:Microsoft.VisualStudio.Package.LanguagePreferences> clase. También se pueden establecer propiedades de la preferencia de idioma por el usuario.  
  
|Entrada del registro|Property|Descripción|  
|--------------------|--------------|-----------------|  
|`MatchBraces`|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableMatchBraces%2A>|Habilita la concordancia de llaves|  
|`MatchBracesAtCaret`|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableMatchBracesAtCaret%2A>|Habilita la coincidencia de llaves como el símbolo de intercalación se mueve.|  
|`ShowMatchingBrace`|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableShowMatchingBrace%2A>|Resalta la llave correspondiente.|  
  
## <a name="matching-conditional-statements"></a>Coincidencia de instrucciones condicionales  
 Puede hacer coincidir las instrucciones condicionales, como `if`, `else if`, y `else`, o `#if`, `#elif`, `#else`, `#endif`, de la misma manera como delimitadores de valores coincidentes. Puede crear subclases de la <xref:Microsoft.VisualStudio.Package.AuthoringSink> clase y proporcionan un método que puede agregar texto abarca, así como delimitadores para que la matriz interna de elementos coincidentes.  
  
## <a name="setting-the-trigger"></a>Establecer el desencadenador  
 En el ejemplo siguiente se muestra cómo detectar paréntesis coincidentes, las llaves y corchetes y establecer el desencadenador para él en el escáner. El <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> método en la <xref:Microsoft.VisualStudio.Package.Source> clase detecta el desencadenador y llama el analizador para encontrar la pareja coincidente (consulte la sección "Buscar la coincidencia" en este tema). En este ejemplo es solo con fines ilustrativos. Se supone que el escáner contiene un método `GetNextToken` que identifica y devuelve símbolos (tokens) de una línea de texto.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    public class TestScanner : IScanner  
    {  
        private const string braces = "()[]{}";  
        private Lexer lex;  
  
        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo,  
                                                   ref int state)  
        {  
            bool foundToken = false;  
            string token = lex.GetNextToken();  
            if (token != null)  
            {  
                foundToken = true;  
                char firstChar = token[0];  
                if (Char.IsPunctuation(firstChar) && token.Length > 0)  
                {  
                    if (braces.IndexOf(firstChar) != -1)  
                    {  
                        tokenInfo.Trigger = TokenTriggers.MatchBraces;  
                    }  
                }  
            }  
            return foundToken;  
        }  
```  
  
## <a name="matching-the-braces"></a>Las llaves coincidentes  
 Este es un ejemplo simplificado para coincidir los {} de elementos de lenguaje, () y [] y agregar sus intervalos para la <xref:Microsoft.VisualStudio.Package.AuthoringSink> objeto. Este enfoque no es un método recomendado para el análisis de código fuente; es solo con fines ilustrativos.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    public class Parser  
    {  
         private IList<TextSpan[]> m_braces;  
         public IList<TextSpan[]> Braces  
         {  
             get { return m_braces; }  
         }  
         private void AddMatchingBraces(TextSpan braceSpan1, TextSpan braceSpan2)  
         {  
             if IsMatch(braceSpan1, braceSpan2)  
                 m_braces.Add(new TextSpan[] { braceSpan1, braceSpan2 });  
         }  
  
         private bool IsMatch(TextSpan braceSpan1, TextSpan braceSpan2)  
         {  
             //definition for matching here  
          }  
    }  
  
    public class TestLanguageService : LanguageService  
    {  
         Parser parser = new Parser();  
         Source source = (Source) this.GetSource(req.FileName);  
  
         private AuthoringScope ParseSource(ParseRequest req)  
         {  
             if (req.Sink.BraceMatching)  
             {  
                 if (req.Reason==ParseReason.MatchBraces)  
                 {  
                     foreach (TextSpan[] brace in parser.Braces)  
                     {  
                         req.Sink.MatchPair(brace[0], brace[1], 1);  
                     }  
                 }  
             }  
             return new TestAuthoringScope();  
         }  
    }  
}  
```  
  
## <a name="see-also"></a>Vea también  
 [Características del servicio de lenguaje heredado](../../extensibility/internals/legacy-language-service-features1.md)   
 [Escáner y analizador del servicio de lenguaje heredado](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)