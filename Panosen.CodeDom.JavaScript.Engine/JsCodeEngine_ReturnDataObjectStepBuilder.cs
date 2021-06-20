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
        /// GenerateReturnDataObjectStepBuilder
        /// </summary>
        /// <param name="returnDataObjectStepBuilder"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateReturnDataObjectStepBuilder(ReturnDataObjectStepBuilder returnDataObjectStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(KEYWORD_RETURN).Write(Marks.WHITESPACE);

            GenerateDataObject(returnDataObjectStepBuilder.DataObject, codeWriter, options);
        }
    }
}
