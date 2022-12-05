using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// DefineMethodStepBuilder
    /// </summary>
    public class DefineMethodStep : Step
    {
        /// <summary>
        /// Method
        /// </summary>
        public CodeMethod Method { get; set; }
    }

    /// <summary>
    /// DefineMethodStepBuilderExtension
    /// </summary>
    public static class DefineMethodStepBuilderExtension
    {
        /// <summary>
        /// AddMethod
        /// </summary>
        /// <typeparam name="TDefineMethodStepBuilder"></typeparam>
        /// <param name="defineMethodStepBuilder"></param>
        /// <param name="codeMethod"></param>
        /// <returns></returns>
        public static TDefineMethodStepBuilder AddMethod<TDefineMethodStepBuilder>(this TDefineMethodStepBuilder defineMethodStepBuilder, CodeMethod codeMethod)
            where TDefineMethodStepBuilder : DefineMethodStep
        {
            defineMethodStepBuilder.Method = codeMethod;

            return defineMethodStepBuilder;
        }

        /// <summary>
        /// AddMethod
        /// </summary>
        /// <typeparam name="TDefineMethodStepBuilder"></typeparam>
        /// <param name="defineMethodStepBuilder"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CodeMethod AddMethod<TDefineMethodStepBuilder>(this TDefineMethodStepBuilder defineMethodStepBuilder, string name = null)
            where TDefineMethodStepBuilder : DefineMethodStep
        {
            CodeMethod codeMethod = new CodeMethod();
            codeMethod.Name = name;

            defineMethodStepBuilder.Method = codeMethod;

            return codeMethod;
        }
    }
}
