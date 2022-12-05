using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// if
    /// </summary>
    public class IfStep : StepCollection
    {
        /// <summary>
        /// if(${Condition})
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// else if
        /// </summary>
        public List<ElseIfStep> ElseIfStepBuilders { get; set; }

        /// <summary>
        /// else
        /// </summary>
        public ElseStep ElseStepBuilder { get; set; }
    }

    /// <summary>
    /// IfStepBuilderExtension
    /// </summary>
    public static class IfStepBuilderExtension
    {
        /// <summary>
        /// WithElseIf
        /// </summary>
        public static ElseIfStep WithElseIf(this IfStep ifStepBuilder, string condition)
        {
            if (ifStepBuilder.ElseIfStepBuilders == null)
            {
                ifStepBuilder.ElseIfStepBuilders = new List<ElseIfStep>();
            }

            ElseIfStep elseIfStepBuilder = new ElseIfStep();
            elseIfStepBuilder.Condition = condition;
            ifStepBuilder.ElseIfStepBuilders.Add(elseIfStepBuilder);

            return elseIfStepBuilder;
        }

        /// <summary>
        /// WithElse
        /// </summary>
        public static ElseStep WithElse(this IfStep ifStepBuilder)
        {
            ElseStep elseStepBuilder = new ElseStep();

            ifStepBuilder.ElseStepBuilder = elseStepBuilder;

            return elseStepBuilder;
        }
    }
}
