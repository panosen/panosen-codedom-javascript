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
        /// GenerateAssignDataArrayStepBuilder
        /// </summary>
        /// <param name="assignDataArrayStepBuilder"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateAssignDataArrayStepBuilder(AssignDataArrayStepBuilder assignDataArrayStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(assignDataArrayStepBuilder.Name).Write(Marks.WHITESPACE).Write(Marks.EQUAL).Write(Marks.WHITESPACE);

            GenerateDataArray(assignDataArrayStepBuilder.DataArray, codeWriter, options);
        }
    }
}
