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
    public class AssignDataObjectStep : Step
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
        public static AssignDataObjectStep AddDataObject<TAssignDataObjectStepBuilder>(this TAssignDataObjectStepBuilder assignDataObjectStepBuilder, DataObject dataObject)
            where TAssignDataObjectStepBuilder : AssignDataObjectStep
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
            where TAssignDataObjectStepBuilder : AssignDataObjectStep
        {
            DataObject dataObject = new DataObject();

            assignDataObjectStepBuilder.DataObject = dataObject;

            return dataObject;
        }
    }
}
