using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest15
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepStatement("//this is a test.");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    //this is a test.
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
