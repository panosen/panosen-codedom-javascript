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
        /// GenerateReturnSortedDataObjectStep
        /// </summary>
        public void GenerateReturnSortedDataObjectStep(ReturnSortedDataObjectStep returnSortedDataObjectStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(KEYWORD_RETURN).Write(Marks.WHITESPACE);

            GenerateSortedDataObject(returnSortedDataObjectStepBuilder.SortedDataObject, codeWriter, options);
        }
    }
}
