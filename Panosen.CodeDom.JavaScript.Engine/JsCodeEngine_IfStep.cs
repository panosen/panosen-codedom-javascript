using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateIfStep(IfStep ifStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            //if
            {
                codeWriter.Write(options.IndentString).Write(KEYWORD_IF).Write(Marks.WHITESPACE)
                    .Write(Marks.LEFT_BRACKET).Write(ifStepBuilder.Expression ?? string.Empty).Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
                options.PushIndent();

                GenerateStepOrCollectionList(ifStepBuilder.StepBuilders, codeWriter, options);

                options.PopIndent();
                codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
            }

            //else if
            {
                if (ifStepBuilder.ElseIfStepBuilders != null && ifStepBuilder.ElseIfStepBuilders.Count > 0)
                {
                    foreach (var elseIfStepBuilder in ifStepBuilder.ElseIfStepBuilders)
                    {
                        codeWriter.Write(Marks.WHITESPACE).Write(KEYWORD_ELSE).Write(Marks.WHITESPACE)
                            .Write(KEYWORD_IF).Write(Marks.WHITESPACE)
                            .Write(Marks.LEFT_BRACKET).Write(elseIfStepBuilder.Condition ?? string.Empty)
                            .Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
                        options.PushIndent();

                        GenerateStepOrCollectionList(elseIfStepBuilder.StepBuilders, codeWriter, options);

                        options.PopIndent();
                        codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
                    }
                }
            }

            //else
            {
                if (ifStepBuilder.ElseStepBuilder != null)
                {
                    codeWriter.Write(Marks.WHITESPACE).Write(KEYWORD_ELSE).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
                    options.PushIndent();

                    GenerateStepOrCollectionList(ifStepBuilder.ElseStepBuilder.StepBuilders, codeWriter, options);

                    options.PopIndent();
                    codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
                }
            }

            codeWriter.WriteLine();
        }
    }
}
