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
    public static class DataObjectExtension
    {
        /// <summary>
        /// 添加一个数组
        /// </summary>
        public static TDataObject AddCodeMethod<TDataObject>(this TDataObject dataObject, DataKey dataKey, CodeMethod codeMethod)
            where TDataObject :  DataObject
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            dataObject.DataItemMap.Add(dataKey, codeMethod);

            return dataObject;
        }

        /// <summary>
        /// 添加一个数组，并返回该数组
        /// </summary>
        public static CodeMethod AddCodeMethod(this DataObject dataObject, DataKey dataKey, string name = null)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            CodeMethod codeMethod = new CodeMethod();
            codeMethod.Name = name;

            dataObject.DataItemMap.Add(dataKey, codeMethod);

            return codeMethod;
        }
    }
}
