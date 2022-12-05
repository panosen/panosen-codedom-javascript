using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var request = codeMethod.StepAssignSortedDataObject("var request").AddSortedDataObject();
            request.AddDataObject("name");

            var items1 = request.AddDataArray("items1");
            for (int i = 0; i < 3; i++)
            {
                items1.AddDataObject(new DataObject().AddDataValue($"key{i}", $"value{i}"));
            }

            var items2 = request.AddDataArray("items2");
            for (int i = 0; i < 3; i++)
            {
                items2.AddDataValue(i * 3);
            }

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    var request = {
        items1: [{
            key0: value0
        }, {
            key1: value1
        }, {
            key2: value2
        }],
        items2: [0, 3, 6],
        name: {}
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
