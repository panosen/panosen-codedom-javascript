using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// ReturnSortedDataObjectStepBuilder
    /// </summary>
    public class ReturnSortedDataObjectStepBuilder : StepBuilder
    {
        /// <summary>
        /// SortedDataObject
        /// </summary>
        public SortedDataObject SortedDataObject { get; set; }
    }

    /// <summary>
    /// ReturnSortedDataObjectStepBuilderExtension
    /// </summary>
    public static class ReturnSortedDataObjectStepBuilderExtension
    {
        /// <summary>
        /// AddDataObject
        /// </summary>
        public static SortedDataObject AddSortedDataObject(this ReturnSortedDataObjectStepBuilder returnSortedDataObjectStepBuilder)
        {
            SortedDataObject dataObject = new SortedDataObject();

            returnSortedDataObjectStepBuilder.SortedDataObject = dataObject;

            return dataObject;
        }
    }
}
