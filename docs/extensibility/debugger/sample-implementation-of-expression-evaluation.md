---
title: "Ejemplo de implementaci&#243;n de evaluaci&#243;n de expresiones | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "evaluadores de expresiones"
  - "depurar [SDK de depuración], evaluadores de expresión"
  - "evaluación de expresiones, ejemplos"
ms.assetid: 2a5f04b8-6c65-4232-bddd-9093653a22c4
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
caps.handback.revision: 9
---
# Ejemplo de implementaci&#243;n de evaluaci&#243;n de expresiones
[!INCLUDE[vs2017banner](../../code-quality/includes/vs2017banner.md)]

> [!IMPORTANT]
>  En Visual Studio 2015, esta forma de implementar los evaluadores de expresión está obsoleta. Para obtener información sobre la implementación de evaluadores de expresión de CLR, vea [evaluadores de expresiones CLR](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) y [ejemplo de evaluador de expresiones administrado](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Para una **inspección** expresión de la ventana, Visual Studio llama [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) para producir un [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) objeto.`IDebugExpressionContext2::ParseText` crea una instancia de un evaluador de expresiones \(EE\) y llama [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) para obtener un [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) objeto.  
  
 Esta implementación de `IDebugExpressionEvaluator::Parse` realiza las siguientes tareas:  
  
1.  \[Solo C\+\+\] Analiza la expresión para buscar errores.  
  
2.  Crea una instancia de una clase \(denominada `CParsedExpression` en este ejemplo\) que implementa el `IDebugParsedExpression` de interfaz y almacena en la clase de la expresión que se va a analizar.  
  
3.  Devuelve el `IDebugParsedExpression` de la interfaz de la `CParsedExpression` objeto.  
  
> [!NOTE]
>  En los ejemplos siguientes y en el ejemplo MyCEE, el evaluador de expresiones no separa el análisis de la evaluación.  
  
## Código administrado  
 Se trata de una implementación de `IDebugExpressionEvaluator::Parse` en código administrado. Tenga en cuenta que esta versión del método aplaza el análisis a [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) como también evalúa el código de análisis al mismo tiempo \(consulte [Evaluar una expresión de inspección](../../extensibility/debugger/evaluating-a-watch-expression.md)\).  
  
```c#  
namespace EEMC { public class CParsedExpression : IDebugParsedExpression { public HRESULT Parse( string                 expression, uint                   parseFlags, uint                   radix, out string                 errorMessage, out uint                   errorPosition, out IDebugParsedExpression parsedExpression) { errorMessage = ""; errorPosition = 0; parsedExpression = new CParsedExpression(parseFlags, radix, expression); return COM.S_OK; } } }  
```  
  
## Código no administrado  
 Se trata de una implementación de `IDebugExpressionEvaluator::Parse` en código no administrado. Este método llama a una función auxiliar, `Parse`, para analizar la expresión y compruebe si hay errores, pero este método omite el valor resultante. La evaluación formal se aplaza hasta [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) donde la expresión se analiza mientras se evalúa \(consulte [Evaluar una expresión de inspección](../../extensibility/debugger/evaluating-a-watch-expression.md)\).  
  
```cpp#  
STDMETHODIMP CExpressionEvaluator::Parse( in    LPCOLESTR                 pszExpression, in    PARSEFLAGS                flags, in    UINT                      radix, out   BSTR                     *pbstrErrorMessages, inout UINT                     *perrorCount, out   IDebugParsedExpression  **ppparsedExpression ) { if (pbstrErrorMessages == NULL) return E_INVALIDARG; else *pbstrErrormessages = 0; if (pparsedExpression == NULL) return E_INVALIDARG; else *pparsedExpression = 0; if (perrorCount == NULL) return E_INVALIDARG; HRESULT hr; // Look for errors in the expression but ignore results hr = ::Parse( pszExpression, pbstrErrorMessages ); if (hr != S_OK) return hr; CParsedExpression* pparsedExpr = new CParsedExpression( radix, flags, pszExpression ); if (!pparsedExpr) return E_OUTOFMEMORY; hr = pparsedExpr->QueryInterface( IID_IDebugParsedExpression, reinterpret_cast<void**>(ppparsedExpression) ); pparsedExpr->Release(); return hr; }  
```  
  
## Vea también  
 [Evaluar una expresión de la ventana Inspección](../../extensibility/debugger/evaluating-a-watch-window-expression.md)   
 [Evaluar una expresión de inspección](../../extensibility/debugger/evaluating-a-watch-expression.md)