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
        public void GenerateStepOrCollection(StepOrCollection stepBuilder, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (stepBuilder == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            if (stepBuilder is EmptyStep)
            {
                codeWriter.WriteLine();
            }

            if (stepBuilder is StatementStep)
            {
                GenerateStatementStep(stepBuilder as StatementStep, codeWriter, options);
            }

            if (stepBuilder is IfStep)
            {
                GenerateIfStep(stepBuilder as IfStep, codeWriter, options);
            }

            if (stepBuilder is SwitchStep)
            {
                GenerateSwitchStep(stepBuilder as SwitchStep, codeWriter, options);
            }

            if (stepBuilder is ForStep)
            {
                GenerateForStep(stepBuilder as ForStep, codeWriter, options);
            }

            if (stepBuilder is ReturnDataObjectStep)
            {
                GenerateReturnDataObjectStep(stepBuilder as ReturnDataObjectStep, codeWriter, options);
            }

            if (stepBuilder is ReturnSortedDataObjectStep)
            {
                GenerateReturnSortedDataObjectStep(stepBuilder as ReturnSortedDataObjectStep, codeWriter, options);
            }

            if (stepBuilder is PushIndentStep)
            {
                GeneratePushIndentStep(stepBuilder as PushIndentStep, codeWriter, options);
            }

            if (stepBuilder is StatementChainStep)
            {
                GenerateStatementChainStep(stepBuilder as StatementChainStep, codeWriter, options);
            }

            if (stepBuilder is BlockStep)
            {
                GenerateBlockStep(stepBuilder as BlockStep, codeWriter, options);
            }

            if (stepBuilder is AssignDataObjectStep)
            {
                GenerateAssignDataObjectStep(stepBuilder as AssignDataObjectStep, codeWriter, options);
            }

            if (stepBuilder is AssignSortedDataObjectStep)
            {
                GenerateAssignSortedDataObjectStep(stepBuilder as AssignSortedDataObjectStep, codeWriter, options);
            }

            if (stepBuilder is AssignDataArrayStep)
            {
                GenerateAssignDataArrayStep(stepBuilder as AssignDataArrayStep, codeWriter, options);
            }

            if (stepBuilder is AssignMethodStep)
            {
                GenerateAssignMethodStep(stepBuilder as AssignMethodStep, codeWriter, options);
            }

            if (stepBuilder is DefineMethodStep)
            {
                GenerateDefineMethodStep(stepBuilder as DefineMethodStep, codeWriter, options);
            }
        }
    }
}
