using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepAssignMethod("refresh")
                .StepStatement("console.log('ok');");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    refresh = function () {
        console.log('ok');
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
