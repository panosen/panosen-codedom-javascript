using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// ReturnDataObjectStepBuilder
    /// </summary>
    public class ReturnDataObjectStepBuilder : StepBuilder
    {
        /// <summary>
        /// DataObject
        /// </summary>
        public DataObject DataObject { get; set; }
    }

    /// <summary>
    /// ReturnDataObjectStepBuilderExtension
    /// </summary>
    public static class ReturnDataObjectStepBuilderExtension
    {
        /// <summary>
        /// AddDataObject
        /// </summary>
        public static DataObject AddDataObject(this ReturnDataObjectStepBuilder returnDataObjectStepBuilder)
        {
            DataObject dataObject = new DataObject();

            returnDataObjectStepBuilder.DataObject = dataObject;

            return dataObject;
        }
    }
}
