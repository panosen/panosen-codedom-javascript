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
        /// GenerateDataValue
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateDataValue(DataValue dataValue, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (dataValue.Value == null)
            {
                codeWriter.Write("null");
            }
            else
            {
                codeWriter.Write(dataValue.Value ?? "null");
            }
        }
    }
}
