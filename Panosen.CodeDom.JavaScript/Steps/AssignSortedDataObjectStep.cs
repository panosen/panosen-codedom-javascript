﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// AssignSortedDataObjectStepBuilder
    /// </summary>
    public class AssignSortedDataObjectStep : Step
    {
        /// <summary>
        /// SortedDataObject
        /// </summary>
        public SortedDataObject SortedDataObject { get; set; }
    }

    /// <summary>
    /// AssignSortedDataObjectStepBuilderExtension
    /// </summary>
    public static class AssignSortedDataObjectStepBuilderExtension
    {
        /// <summary>
        /// Set SortedDataObject
        /// </summary>
        public static AssignSortedDataObjectStep AddSortedDataObject<TAssignSortedDataObjectStepBuilder>(this TAssignSortedDataObjectStepBuilder assignSortedDataObjectStepBuilder, SortedDataObject sortedDataObject)
            where TAssignSortedDataObjectStepBuilder : AssignSortedDataObjectStep
        {
            assignSortedDataObjectStepBuilder.SortedDataObject = sortedDataObject;

            return assignSortedDataObjectStepBuilder;
        }

        /// <summary>
        /// Set SortedDataObject
        /// </summary>
        public static SortedDataObject AddSortedDataObject<TAssignSortedDataObjectStepBuilder>(this TAssignSortedDataObjectStepBuilder assignSortedDataObjectStepBuilder)
            where TAssignSortedDataObjectStepBuilder : AssignSortedDataObjectStep
        {
            SortedDataObject dataObject = new SortedDataObject();

            assignSortedDataObjectStepBuilder.SortedDataObject = dataObject;

            return dataObject;
        }
    }
}
