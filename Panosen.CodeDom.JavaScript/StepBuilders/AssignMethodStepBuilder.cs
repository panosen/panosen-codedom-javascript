using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// 赋值方法给一个变量
    /// </summary>
    public class AssignMethodStepBuilder : StepBuilder
    {
        /// <summary>
        /// 变量
        /// </summary>
        public string VariableName { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public CodeMethod CodeMethod { get; set; }
    }
}
