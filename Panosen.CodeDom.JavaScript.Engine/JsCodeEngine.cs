using System;

namespace Panosen.CodeDom.JavaScript.Engine
{
    public partial class JsCodeEngine
    {
        private const string KEYWORD_IF = "if";
        private const string KEYWORD_ELSE = "else";
        private const string KEYWORD_FOR = "for";
        private const string KEYWORD_FUNCTION = "function";
        private const string KEYWORD_RETURN = "return";
        private const string KEYWORD_VAR = "var";
        private const string KEYWORD_SWITCH = "switch";
        private const string KEYWORD_CASE = "case";
        private const string KEYWORD_BREAK = "break";
        private const string KEYWORD_DEFAULT = "default";
        private const string KEYWORD_ASYNC = "async";

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

        /// <summary>
        /// 生成代码
        /// </summary>
        public void Generate(Code code, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (code == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (code is JsCodeFile)
            {
                GenerateFile(code as JsCodeFile, codeWriter, options);
                return;
            }
        }
    }
}
