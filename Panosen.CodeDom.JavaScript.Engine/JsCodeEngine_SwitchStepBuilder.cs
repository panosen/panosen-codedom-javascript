using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateSwitchStepBuilder(SwitchStepBuilder switchStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            // switch (${expression}) {
            codeWriter.Write(options.IndentString).Write(KEYWORD_SWITCH).Write(Marks.WHITESPACE)
                .Write(Marks.LEFT_BRACKET).Write(switchStepBuilder.Expression ?? string.Empty).Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            if (switchStepBuilder.ConditionList != null && switchStepBuilder.ConditionList.Count > 0)
            {
                foreach (var item in switchStepBuilder.ConditionList)
                {
                    // case ${conditionKey}: {
                    codeWriter.Write(options.IndentString).Write(KEYWORD_CASE).Write(Marks.WHITESPACE).Write(item.ConditionExpression.Value).Write(Marks.COLON);

                    if (item.LinkToNext)
                    {
                        codeWriter.WriteLine();
                        continue;
                    }

                    options.PushIndent();

                    if (item.StepBuilders != null && item.StepBuilders.Count > 0)
                    {
                        codeWriter.Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACE);
                    }

                    codeWriter.WriteLine();

                    GenerateStepBuilderOrCollectionList(item.StepBuilders, codeWriter, options);

                    if (item.StepBuilders != null && item.StepBuilders.Count > 0)
                    {
                        options.PopIndent();
                        codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
                        options.PushIndent();
                    }

                    codeWriter.Write(options.IndentString).Write(KEYWORD_BREAK).WriteLine(Marks.SEMICOLON);
                    options.PopIndent();
                }
            }

            if (switchStepBuilder.DefaultStepBuilders != null)
            {
                // case ${conditionKey}:
                codeWriter.Write(options.IndentString).Write(KEYWORD_DEFAULT).Write(Marks.COLON);
                options.PushIndent();

                if (switchStepBuilder.DefaultStepBuilders.StepBuilders != null && switchStepBuilder.DefaultStepBuilders.StepBuilders.Count > 0)
                {
                    codeWriter.Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACE);
                }

                codeWriter.WriteLine();

                GenerateStepBuilderOrCollectionList(switchStepBuilder.DefaultStepBuilders.StepBuilders, codeWriter, options);

                if (switchStepBuilder.DefaultStepBuilders.StepBuilders != null && switchStepBuilder.DefaultStepBuilders.StepBuilders.Count > 0)
                {
                    options.PopIndent();
                    codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
                    options.PushIndent();
                }

                codeWriter.Write(options.IndentString).Write(KEYWORD_BREAK).WriteLine(Marks.SEMICOLON);
                options.PopIndent();
            }

            // }
            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }
    }
}
