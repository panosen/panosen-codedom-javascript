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
        /// GenerateDefineMethodStep
        /// </summary>
        public void GenerateDefineMethodStep(DefineMethodStep defineMethodStepBuilder, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (defineMethodStepBuilder == null || defineMethodStepBuilder.Method == null) return;
            if (codeWriter == null) return;
            options = options ?? new GenerateOptions();

            GenerateCodeMethod(defineMethodStepBuilder.Method, codeWriter, options, true);
        }
    }
}
