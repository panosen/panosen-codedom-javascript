using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// DataObjectExtension
    /// </summary>
    public static class SortedDataObjectExtension
    {
        /// <summary>
        /// 添加一个数组
        /// </summary>
        public static TSortedDataObject AddCodeMethod<TSortedDataObject>(this TSortedDataObject sortedDataObject, DataKey dataKey, CodeMethod codeMethod)
            where TSortedDataObject : SortedDataObject
        {
            if (sortedDataObject.DataItemMap == null)
            {
                sortedDataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            sortedDataObject.DataItemMap.Add(dataKey, codeMethod);

            return sortedDataObject;
        }

        /// <summary>
        /// 添加一个数组，并返回该数组
        /// </summary>
        public static CodeMethod AddCodeMethod(this SortedDataObject sortedDataObject, DataKey dataKey, string name = null)
        {
            if (sortedDataObject.DataItemMap == null)
            {
                sortedDataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            CodeMethod codeMethod = new CodeMethod();
            codeMethod.Name = name;

            sortedDataObject.DataItemMap.Add(dataKey, codeMethod);

            return codeMethod;
        }
    }
}
