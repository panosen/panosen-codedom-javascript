using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    /// <summary>
    /// CodeMethodExtension
    /// </summary>
    public static class CodeMethodExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this CodeMethod codeMethod, GenerateOptions options = null)
        {
            var builder = new StringBuilder();

            new JsCodeEngine().Generate(codeMethod, builder, options);

            return builder.ToString();
        }
    }
}
