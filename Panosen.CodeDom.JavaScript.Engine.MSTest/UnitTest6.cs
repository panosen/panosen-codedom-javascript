using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepBlock();

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    {
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
