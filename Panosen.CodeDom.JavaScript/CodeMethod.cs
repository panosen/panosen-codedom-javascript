using System;
using System.Collections.Generic;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// 方法
    /// </summary>
    public class CodeMethod : DataItem, IStepCollectionHost
    {
        /// <summary>
        /// 方法名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        public List<string> Parameters { get; set; }

        /// <summary>
        /// 子方法
        /// </summary>
        public List<CodeMethod> CodeMethods { get; set; }

        /// <summary>
        /// async
        /// </summary>
        public bool IsAsync { get; set; }

        /// <summary>
        /// 使用Lamda格式
        /// </summary>
        public bool InLamdaStyle { get; set; }

        #region IStepCollectionHost Members

        /// <summary>
        /// IStepCollectionHost.StepCollection
        /// </summary>
        public StepCollection StepCollection { get; set; }

        #endregion
    }

    /// <summary>
    /// CodeMethod 扩展方法
    /// </summary>
    public static class CodeMethodExtension
    {
        /// <summary>
        /// set IsAsync
        /// </summary>
        public static TCodeMethod SetIsAsync<TCodeMethod>(this TCodeMethod codeMethod, bool isAsync)
            where TCodeMethod : CodeMethod
        {
            codeMethod.IsAsync = isAsync;

            return codeMethod;
        }

        /// <summary>
        /// set InLamdaStyle
        /// </summary>
        public static TCodeMethod SetInLamdaStyle<TCodeMethod>(this TCodeMethod codeMethod, bool inLamdaStyle)
            where TCodeMethod : CodeMethod
        {
            codeMethod.InLamdaStyle = inLamdaStyle;

            return codeMethod;
        }

        /// <summary>
        /// 添加参数
        /// </summary>
        /// <param name="codeMethod"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static TCodeMethod AddParameter<TCodeMethod>(this TCodeMethod codeMethod, string parameter) where TCodeMethod : CodeMethod
        {
            if (codeMethod.Parameters == null)
            {
                codeMethod.Parameters = new List<string>();
            }

            codeMethod.Parameters.Add(parameter);

            return codeMethod;
        }

        /// <summary>
        /// 添加一个子方法
        /// </summary>
        /// <param name="codeMethod"></param>
        /// <param name="item"></param>
        public static void AddMethod(this CodeMethod codeMethod, CodeMethod item)
        {
            if (codeMethod.CodeMethods == null)
            {
                codeMethod.CodeMethods = new List<CodeMethod>();
            }

            codeMethod.CodeMethods.Add(item);
        }

        /// <summary>
        /// 添加一个子方法
        /// </summary>
        /// <param name="codeMethod"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CodeMethod AddMethod(this CodeMethod codeMethod, string name)
        {
            if (codeMethod.CodeMethods == null)
            {
                codeMethod.CodeMethods = new List<CodeMethod>();
            }

            CodeMethod item = new CodeMethod();
            item.Name = name;
            codeMethod.CodeMethods.Add(item);

            return item;
        }
    }
}
