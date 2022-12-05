using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        /// <summary>
        /// GenerateForStep
        /// </summary>
        public void GenerateForStep(ForStep forStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(KEYWORD_FOR).Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACKET)
                .Write(forStepBuilder.Start ?? string.Empty).Write(Marks.SEMICOLON).Write(Marks.WHITESPACE)
                .Write(forStepBuilder.Middle ?? string.Empty).Write(Marks.SEMICOLON).Write(Marks.WHITESPACE)
                .Write(forStepBuilder.End ?? string.Empty)
                .Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);

            options.PushIndent();

            GenerateStepOrCollectionList(forStepBuilder.StepBuilders, codeWriter, options);

            options.PopIndent();

            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }
    }
}
