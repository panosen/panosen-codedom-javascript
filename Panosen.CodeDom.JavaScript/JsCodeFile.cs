using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// js code file
    /// </summary>
    public class JsCodeFile : StepBuilderCollection
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        public List<CodeMethod> CodeMethods { get; set; }
    }

    /// <summary>
    /// JsCodeFileExtension
    /// </summary>
    public static class JsCodeFileExtension
    {
        /// <summary>
        /// 添加一个function
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="codeMethod"></param>
        public static void AddMethod(this JsCodeFile codeFile, CodeMethod codeMethod)
        {
            if (codeFile.CodeMethods == null)
            {
                codeFile.CodeMethods = new List<CodeMethod>();
            }

            codeFile.CodeMethods.Add(codeMethod);
        }

        /// <summary>
        /// 添加一个function
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CodeMethod AddMethod(this JsCodeFile codeFile, string name)
        {
            if (codeFile.CodeMethods == null)
            {
                codeFile.CodeMethods = new List<CodeMethod>();
            }

            CodeMethod codeMethod = new CodeMethod();
            codeMethod.Name = name;

            codeFile.CodeMethods.Add(codeMethod);

            return codeMethod;
        }
    }
}
