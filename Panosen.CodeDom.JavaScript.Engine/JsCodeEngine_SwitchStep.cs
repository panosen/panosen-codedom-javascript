using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateSwitchStep(SwitchStep switchStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            // switch (${expression}) {
            codeWriter.Write(options.IndentString).Write(Keywords.SWITCH).Write(Marks.WHITESPACE)
                .Write(Marks.LEFT_BRACKET).Write(switchStepBuilder.Expression ?? string.Empty).Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            if (switchStepBuilder.ConditionList != null && switchStepBuilder.ConditionList.Count > 0)
            {
                foreach (var item in switchStepBuilder.ConditionList)
                {
                    // case ${conditionKey}: {
                    codeWriter.Write(options.IndentString).Write(Keywords.CASE).Write(Marks.WHITESPACE).Write(item.ConditionExpression.Value).Write(Marks.COLON);

                    if (item.LinkToNext)
                    {
                        codeWriter.WriteLine();
                        continue;
                    }

                    options.PushIndent();

                    if (item.Steps != null && item.Steps.Count > 0)
                    {
                        codeWriter.Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACE);
                    }

                    codeWriter.WriteLine();

                    GenerateStepOrCollectionList(item.Steps, codeWriter, options);

                    if (item.Steps != null && item.Steps.Count > 0)
                    {
                        options.PopIndent();
                        codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
                        options.PushIndent();
                    }

                    codeWriter.Write(options.IndentString).Write(Keywords.BREAK).WriteLine(Marks.SEMICOLON);
                    options.PopIndent();
                }
            }

            if (switchStepBuilder.DefaultStepBuilders != null)
            {
                // case ${conditionKey}:
                codeWriter.Write(options.IndentString).Write(Keywords.DEFAULT).Write(Marks.COLON);
                options.PushIndent();

                if (switchStepBuilder.DefaultStepBuilders.Steps != null && switchStepBuilder.DefaultStepBuilders.Steps.Count > 0)
                {
                    codeWriter.Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACE);
                }

                codeWriter.WriteLine();

                GenerateStepOrCollectionList(switchStepBuilder.DefaultStepBuilders.Steps, codeWriter, options);

                if (switchStepBuilder.DefaultStepBuilders.Steps != null && switchStepBuilder.DefaultStepBuilders.Steps.Count > 0)
                {
                    options.PopIndent();
                    codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
                    options.PushIndent();
                }

                codeWriter.Write(options.IndentString).Write(Keywords.BREAK).WriteLine(Marks.SEMICOLON);
                options.PopIndent();
            }

            // }
            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }
    }
}
