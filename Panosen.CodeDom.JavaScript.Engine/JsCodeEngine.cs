using System;

namespace Panosen.CodeDom.JavaScript.Engine
{
    public partial class JsCodeEngine
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        public void Generate(CodeMethod codeMethod, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeMethod == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            GenerateCodeMethod(codeMethod, codeWriter, options);
        }
    }
}
