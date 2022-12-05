using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateStatementChainStep(StatementChainStep statementChainStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            if (statementChainStepBuilder == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (statementChainStepBuilder.CallMethodExpressions == null || statementChainStepBuilder.CallMethodExpressions.Count == 0)
            {
                return;
            }

            codeWriter.Write(options.IndentString);

            if (!string.IsNullOrEmpty(statementChainStepBuilder.Target))
            {
                codeWriter.Write(statementChainStepBuilder.Target);
            }

            if (statementChainStepBuilder.CallMethodExpressions != null && statementChainStepBuilder.CallMethodExpressions.Count != 0)
            {
                for (int i = 0; i < statementChainStepBuilder.CallMethodExpressions.Count; i++)
                {
                    GenerateStatementChainStep_Chain(statementChainStepBuilder.CallMethodExpressions[i], codeWriter, options, i > 0 || !string.IsNullOrEmpty(statementChainStepBuilder.Target));
                }
            }

            codeWriter.WriteLine(Marks.SEMICOLON);
        }

        private void GenerateStatementChainStep_Chain(CallMethodExpression callMethodExpression, CodeWriter codeWriter, GenerateOptions options, bool withDot)
        {
            if (withDot)
            {
                codeWriter.Write(Marks.DOT);
            }
            GenerateCallMethodExpression(callMethodExpression, codeWriter, options);
        }
    }
}
