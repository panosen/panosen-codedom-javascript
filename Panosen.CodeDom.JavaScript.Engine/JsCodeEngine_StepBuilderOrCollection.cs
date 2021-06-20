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
        /// 生成方法步骤
        /// </summary>
        /// <param name="stepBuilder"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateStepBuilderOrCollection(StepBuilderOrCollection stepBuilder, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (stepBuilder == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (stepBuilder is EmptyStepBuilder)
            {
                codeWriter.WriteLine();
            }

            if (stepBuilder is StatementStepBuilder)
            {
                GenerateStatementStepBuilder(stepBuilder as StatementStepBuilder, codeWriter, options);
            }

            if (stepBuilder is IfStepBuilder)
            {
                GenerateIfStepBuilder(stepBuilder as IfStepBuilder, codeWriter, options);
            }

            if (stepBuilder is SwitchStepBuilder)
            {
                GenerateSwitchStepBuilder(stepBuilder as SwitchStepBuilder, codeWriter, options);
            }

            if (stepBuilder is ForStepBuilder)
            {
                GenerateForStepBuilder(stepBuilder as ForStepBuilder, codeWriter, options);
            }

            if (stepBuilder is ReturnDataObjectStepBuilder)
            {
                GenerateReturnDataObjectStepBuilder(stepBuilder as ReturnDataObjectStepBuilder, codeWriter, options);
            }

            if (stepBuilder is ReturnSortedDataObjectStepBuilder)
            {
                GenerateReturnSortedDataObjectStepBuilder(stepBuilder as ReturnSortedDataObjectStepBuilder, codeWriter, options);
            }

            if (stepBuilder is PushIndentStepBuilder)
            {
                GeneratePushIndentStepBuilder(stepBuilder as PushIndentStepBuilder, codeWriter, options);
            }

            if (stepBuilder is StatementChainStepBuilder)
            {
                GenerateStatementChainStepBuilder(stepBuilder as StatementChainStepBuilder, codeWriter, options);
            }

            if (stepBuilder is BlockStepBuilder)
            {
                GenerateBlockStepBuilder(stepBuilder as BlockStepBuilder, codeWriter, options);
            }

            if (stepBuilder is AssignDataObjectStepBuilder)
            {
                GenerateAssignDataObjectStepBuilder(stepBuilder as AssignDataObjectStepBuilder, codeWriter, options);
            }

            if (stepBuilder is AssignSortedDataObjectStepBuilder)
            {
                GenerateAssignSortedDataObjectStepBuilder(stepBuilder as AssignSortedDataObjectStepBuilder, codeWriter, options);
            }

            if (stepBuilder is AssignDataArrayStepBuilder)
            {
                GenerateAssignDataArrayStepBuilder(stepBuilder as AssignDataArrayStepBuilder, codeWriter, options);
            }

            if (stepBuilder is AssignMethodStepBuilder)
            {
                GenerateAssignMethodStepBuilder(stepBuilder as AssignMethodStepBuilder, codeWriter, options);
            }

            if (stepBuilder is DefineMethodStepBuilder)
            {
                GenerateDefineMethodStepBuilder(stepBuilder as DefineMethodStepBuilder, codeWriter, options);
            }
        }
    }
}
