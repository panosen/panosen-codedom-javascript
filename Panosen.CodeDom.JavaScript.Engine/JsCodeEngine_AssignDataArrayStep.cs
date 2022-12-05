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
        /// GenerateAssignDataArrayStep
        /// </summary>
        public void GenerateAssignDataArrayStep(AssignDataArrayStep assignDataArrayStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(assignDataArrayStepBuilder.Name).Write(Marks.WHITESPACE).Write(Marks.EQUAL).Write(Marks.WHITESPACE);

            GenerateDataArray(assignDataArrayStepBuilder.DataArray, codeWriter, options);
        }
    }
}
