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
        /// GenerateBlockStep
        /// </summary>
        public void GenerateBlockStep(BlockStep blockStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            GenerateStepOrCollectionList(blockStepBuilder.Steps, codeWriter, options);

            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }
    }
}
