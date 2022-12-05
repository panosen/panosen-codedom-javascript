using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var dataObject = codeMethod.StepReturnSortedDataObject().AddSortedDataObject();
            dataObject.AddDataValue("name", "tom");
            dataObject.AddDataValue("from1", DataValue.SingleQuotationString("english"));
            dataObject.AddDataValue("from2", DataValue.SingleQuotationString("english"));
            dataObject.AddDataValue("age", 18);

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    return {
        age: 18,
        from1: 'english',
        from2: 'english',
        name: tom
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
