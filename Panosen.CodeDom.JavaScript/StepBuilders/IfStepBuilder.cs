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
    public class IfStepBuilder : StepBuilderCollection
    {
        /// <summary>
        /// if(${Condition})
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// else if
        /// </summary>
        public List<ElseIfStepBuilder> ElseIfStepBuilders { get; set; }

        /// <summary>
        /// else
        /// </summary>
        public ElseStepBuilder ElseStepBuilder { get; set; }
    }

    /// <summary>
    /// IfStepBuilderExtension
    /// </summary>
    public static class IfStepBuilderExtension
    {
        /// <summary>
        /// WithElseIf
        /// </summary>
        public static ElseIfStepBuilder WithElseIf(this IfStepBuilder ifStepBuilder, string condition)
        {
            if (ifStepBuilder.ElseIfStepBuilders == null)
            {
                ifStepBuilder.ElseIfStepBuilders = new List<ElseIfStepBuilder>();
            }

            ElseIfStepBuilder elseIfStepBuilder = new ElseIfStepBuilder();
            elseIfStepBuilder.Condition = condition;
            ifStepBuilder.ElseIfStepBuilders.Add(elseIfStepBuilder);

            return elseIfStepBuilder;
        }

        /// <summary>
        /// WithElse
        /// </summary>
        public static ElseStepBuilder WithElse(this IfStepBuilder ifStepBuilder)
        {
            ElseStepBuilder elseStepBuilder = new ElseStepBuilder();

            ifStepBuilder.ElseStepBuilder = elseStepBuilder;

            return elseStepBuilder;
        }
    }
}
