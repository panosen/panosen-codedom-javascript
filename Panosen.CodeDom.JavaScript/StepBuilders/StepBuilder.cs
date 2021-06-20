using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// StepBuilder
    /// </summary>
    public abstract class StepBuilder : StepBuilderOrCollection
    {
        /// <summary>
        /// 步骤
        /// </summary>
        public List<StepBuilder> StepBuilders { get; set; }
    }
}
