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
        /// GenerateReturnDataObjectStep
        /// </summary>
        public void GenerateReturnDataObjectStep(ReturnDataObjectStep returnDataObjectStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(Keywords.RETURN).Write(Marks.WHITESPACE);

            GenerateDataObject(returnDataObjectStepBuilder.DataObject, codeWriter, options);
        }
    }
}
