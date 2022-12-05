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
    public abstract class Step : StepOrCollection
    {
        /// <summary>
        /// 步骤
        /// </summary>
        public List<Step> StepBuilders { get; set; }
    }
}
