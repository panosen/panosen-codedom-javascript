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
        /// GenerateFile
        /// </summary>
        public void GenerateFile(JsCodeFile codeFile, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeFile == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (codeFile.CodeMethods != null && codeFile.CodeMethods.Count > 0)
            {
                foreach (var codeMethod in codeFile.CodeMethods)
                {
                    GenerateCodeMethod(codeMethod, codeWriter, options);
                }
            }

            if (codeFile.Steps != null && codeFile.Steps.Count > 0)
            {
                foreach (var stepBuilder in codeFile.Steps)
                {
                    GenerateStepOrCollection(stepBuilder, codeWriter, options);
                }
            }
        }
    }
}
