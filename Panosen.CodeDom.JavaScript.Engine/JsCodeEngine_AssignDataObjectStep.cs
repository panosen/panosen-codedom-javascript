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
        /// GenerateAssignDataObjectStep
        /// </summary>
        public void GenerateAssignDataObjectStep(AssignDataObjectStep assignDataObjectStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(assignDataObjectStepBuilder.Name).Write(Marks.WHITESPACE).Write(Marks.EQUAL).Write(Marks.WHITESPACE);

            GenerateDataObject(assignDataObjectStepBuilder.DataObject, codeWriter, options);
        }
    }
}
