﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        /// <summary>
        /// GenerateAssignSortedDataObjectStepBuilder
        /// </summary>
        public void GenerateAssignSortedDataObjectStepBuilder(AssignSortedDataObjectStepBuilder assignSortedDataObjectStepBuilder, CodeWriter codeWriter, GenerateOptions options)
        {
            codeWriter.Write(options.IndentString).Write(assignSortedDataObjectStepBuilder.Name).Write(Marks.WHITESPACE).Write(Marks.EQUAL).Write(Marks.WHITESPACE);

            GenerateSortedDataObject(assignSortedDataObjectStepBuilder.SortedDataObject, codeWriter, options);
        }
    }
}
