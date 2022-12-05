using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// AssignDataArrayStepBuilder
    /// </summary>
    public class AssignDataArrayStep : Step
    {
        /// <summary>
        /// DataArray
        /// </summary>
        public DataArray DataArray { get; set; }
    }

    /// <summary>
    /// AssignDataArrayStepBuilderExtension
    /// </summary>
    public static class AssignDataArrayStepBuilderExtension
    {
        /// <summary>
        /// Set DataArray
        /// </summary>
        /// <typeparam name="TAssignDataArrayStepBuilder"></typeparam>
        /// <param name="assignDataArrayStepBuilder"></param>
        /// <param name="dataArray"></param>
        /// <returns></returns>
        public static AssignDataArrayStep AddDataArray<TAssignDataArrayStepBuilder>(this TAssignDataArrayStepBuilder assignDataArrayStepBuilder, DataArray dataArray)
            where TAssignDataArrayStepBuilder : AssignDataArrayStep
        {
            assignDataArrayStepBuilder.DataArray = dataArray;

            return assignDataArrayStepBuilder;
        }

        /// <summary>
        /// Set DataArray
        /// </summary>
        /// <typeparam name="TAssignDataArrayStepBuilder"></typeparam>
        /// <param name="assignDataArrayStepBuilder"></param>
        /// <returns></returns>
        public static DataArray AddDataArray<TAssignDataArrayStepBuilder>(this TAssignDataArrayStepBuilder assignDataArrayStepBuilder)
            where TAssignDataArrayStepBuilder : AssignDataArrayStep
        {
            DataArray dataArray = new DataArray();

            assignDataArrayStepBuilder.DataArray = dataArray;

            return dataArray;
        }
    }
}
