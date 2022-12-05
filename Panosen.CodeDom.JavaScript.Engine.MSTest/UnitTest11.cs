using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest11
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepAssignDataObject("request").AddDataObject().AddDataValue("pageIndex", 1);

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    request = {
        pageIndex: 1
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
