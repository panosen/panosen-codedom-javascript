using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        private void GenerateStepBuilderOrCollectionList(List<StepBuilderOrCollection> stepBuilders, CodeWriter codeWriter, GenerateOptions options)
        {
            if (stepBuilders == null || stepBuilders.Count == 0)
            {
                return;
            }

            foreach (var item in stepBuilders)
            {
                GenerateStepBuilderOrCollection(item, codeWriter, options);
            }
        }
    }
}
