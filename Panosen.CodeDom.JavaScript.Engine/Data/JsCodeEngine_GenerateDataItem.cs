using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    partial class JsCodeEngine
    {
        /// <summary>
        /// GenerateDataItem
        /// </summary>
        /// <param name="dataItem"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateDataItem(DataItem dataItem, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (dataItem is DataArray)
            {
                GenerateDataArray(dataItem as DataArray, codeWriter, options, false);
            }
            else if (dataItem is DataObject)
            {
                GenerateDataObject(dataItem as DataObject, codeWriter, options, false);
            }
            else if (dataItem is SortedDataObject)
            {
                GenerateSortedDataObject(dataItem as SortedDataObject, codeWriter, options, false);
            }
            else if (dataItem is DataValue)
            {
                GenerateDataValue(dataItem as DataValue, codeWriter, options);
            }
            else if (dataItem is CodeMethod)
            {
                GenerateCodeMethod(dataItem as CodeMethod, codeWriter, options, false);
            }
        }
    }
}
