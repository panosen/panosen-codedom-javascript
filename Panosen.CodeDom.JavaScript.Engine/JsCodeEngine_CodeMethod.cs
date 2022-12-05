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
        /// 生成方法
        /// </summary>
        /// <param name="codeMethod"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        /// <param name="endWithNewLine">以换行结尾。默认值：true</param>
        public void GenerateCodeMethod(CodeMethod codeMethod, CodeWriter codeWriter, GenerateOptions options = null, bool endWithNewLine = true)
        {
            if (codeMethod == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (codeMethod.IsAsync)
            {
                codeWriter.Write(Keywords.ASYNC).Write(Marks.WHITESPACE);
            }

            if (!codeMethod.InLamdaStyle)
            {
                codeWriter.Write(Keywords.FUNCTION).Write(Marks.WHITESPACE);
            }

            if (codeMethod.Name != null)
            {
                codeWriter.Write(codeMethod.Name);
            }

            codeWriter.Write(Marks.LEFT_BRACKET);

            if (codeMethod.Parameters != null && codeMethod.Parameters.Count > 0)
            {
                var enumerator = codeMethod.Parameters.GetEnumerator();
                var moveNext = enumerator.MoveNext();
                while (moveNext)
                {
                    codeWriter.Write(enumerator.Current);

                    moveNext = enumerator.MoveNext();
                    if (moveNext)
                    {
                        codeWriter.Write(Marks.COMMA).Write(Marks.WHITESPACE);
                    }
                }

            }

            codeWriter.Write(Marks.RIGHT_BRACKET);

            if (codeMethod.InLamdaStyle)
            {
                codeWriter.Write(Marks.WHITESPACE).Write(Marks.EQUAL).Write(Marks.GREATER_THAN);
            }

            codeWriter.Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);

            if (codeMethod.CodeMethods != null && codeMethod.CodeMethods.Count > 0)
            {
                options.PushIndent();

                foreach (var item in codeMethod.CodeMethods)
                {
                    codeWriter.WriteLine();

                    codeWriter.Write(options.IndentString);
                    GenerateCodeMethod(item, codeWriter, options);
                }

                options.PopIndent();
            }

            if (codeMethod.StepCollection != null)
            {
                //如果codeMethod有子方法，那么在【子方法结束之后，步骤开始之前】，插入一个空行，用于分隔
                if (codeMethod.CodeMethods != null && codeMethod.CodeMethods.Count > 0)
                {
                    codeWriter.WriteLine();
                }

                options.PushIndent();

                GenerateStepOrCollection(codeMethod.StepCollection, codeWriter, options);

                options.PopIndent();
            }

            codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);

            if (endWithNewLine)
            {
                codeWriter.WriteLine();
            }
        }
    }
}
