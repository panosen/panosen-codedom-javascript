using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateCallMethodExpression(CallMethodExpression callMethodExpression, CodeWriter codeWriter, GenerateOptions options)
        {
            if (callMethodExpression == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(callMethodExpression.MethodName).Write(Marks.LEFT_BRACKET);

            if (callMethodExpression.Parameters != null && callMethodExpression.Parameters.Count > 0)
            {
                var enumerator = callMethodExpression.Parameters.GetEnumerator();
                var moveNext = enumerator.MoveNext();
                while (moveNext)
                {
                    GenerateDataItem(enumerator.Current, codeWriter, options);

                    moveNext = enumerator.MoveNext();
                    if (moveNext)
                    {
                        codeWriter.Write(Marks.COMMA).Write(Marks.WHITESPACE);
                    }
                }
            }

            codeWriter.Write(Marks.RIGHT_BRACKET);
        }
    }
}
