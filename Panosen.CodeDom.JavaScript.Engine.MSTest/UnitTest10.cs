using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var dataArray = codeMethod.StepAssignDataArray("items").AddDataArray();
            for (int i = 0; i < 3; i++)
            {
                var dataObject = dataArray.AddDataObject();
                dataObject.AddDataValue($"item_{i}");
            }

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    items = [{
        item_0: null
    }, {
        item_1: null
    }, {
        item_2: null
    }]
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
