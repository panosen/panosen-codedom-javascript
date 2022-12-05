using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest14
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var callMethodStepBuilder = codeMethod.StepStatementChain();
            callMethodStepBuilder.AddCallMethodExpression("this.service.basic");
            callMethodStepBuilder.AddCallMethodExpression("then");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    this.service.basic().then();
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
