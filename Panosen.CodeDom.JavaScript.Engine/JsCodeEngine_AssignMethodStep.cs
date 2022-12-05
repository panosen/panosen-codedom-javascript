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
        /// GenerateAssignMethodStep
        /// </summary>
        public void GenerateAssignMethodStep(AssignMethodStep assignMethodStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(assignMethodStepBuilder.VariableName).Write(Marks.WHITESPACE).Write(Marks.EQUAL)
                .Write(Marks.WHITESPACE);

            GenerateCodeMethod(assignMethodStepBuilder.CodeMethod, codeWriter, options);
        }
    }
}
