using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.AddParameter("name");
            codeMethod.AddParameter("age");

            codeMethod.StepStatement("name = age.ToString();");
            codeMethod.StepStatement("name = age.ToString();");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod(name, age) {
    name = age.ToString();
    name = age.ToString();
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
