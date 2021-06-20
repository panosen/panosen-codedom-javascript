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
        /// GeneratePushIndentStepBuilder
        /// </summary>
        /// <param name="pushIndentStepBuilder"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GeneratePushIndentStepBuilder(PushIndentStepBuilder pushIndentStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).WriteLine(pushIndentStepBuilder.Key ?? string.Empty);

            if (pushIndentStepBuilder.StepBuilders == null || pushIndentStepBuilder.StepBuilders.Count == 0)
            {
                return;
            }

            options.PushIndent();

            foreach (var stepBuilder in pushIndentStepBuilder.StepBuilders)
            {
                GenerateStepBuilderOrCollection(stepBuilder, codeWriter, options);
            }

            options.PopIndent();
        }
    }
}
