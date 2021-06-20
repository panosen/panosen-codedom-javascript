using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// AssignDataObjectStepBuilder
    /// </summary>
    public class AssignDataObjectStepBuilder : StepBuilder
    {
        /// <summary>
        /// DataObject
        /// </summary>
        public DataObject DataObject { get; set; }
    }

    /// <summary>
    /// AssignDataObjectStepBuilderExtension
    /// </summary>
    public static class AssignDataObjectStepBuilderExtension
    {
        /// <summary>
        /// Set DataObject
        /// </summary>
        /// <typeparam name="TAssignDataObjectStepBuilder"></typeparam>
        /// <param name="assignDataObjectStepBuilder"></param>
        /// <param name="dataObject"></param>
        /// <returns></returns>
        public static AssignDataObjectStepBuilder AddDataObject<TAssignDataObjectStepBuilder>(this TAssignDataObjectStepBuilder assignDataObjectStepBuilder, DataObject dataObject)
            where TAssignDataObjectStepBuilder : AssignDataObjectStepBuilder
        {
            assignDataObjectStepBuilder.DataObject = dataObject;

            return assignDataObjectStepBuilder;
        }

        /// <summary>
        /// Set DataObject
        /// </summary>
        /// <typeparam name="TAssignDataObjectStepBuilder"></typeparam>
        /// <param name="assignDataObjectStepBuilder"></param>
        /// <returns></returns>
        public static DataObject AddDataObject<TAssignDataObjectStepBuilder>(this TAssignDataObjectStepBuilder assignDataObjectStepBuilder)
            where TAssignDataObjectStepBuilder : AssignDataObjectStepBuilder
        {
            DataObject dataObject = new DataObject();

            assignDataObjectStepBuilder.DataObject = dataObject;

            return dataObject;
        }
    }
}
