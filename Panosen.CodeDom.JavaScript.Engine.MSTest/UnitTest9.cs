using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepBlock().StepStatement("var xx = {};");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    {
        var xx = {};
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
