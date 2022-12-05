using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var chain = codeMethod.StepStatementChain("this");
            var _where = chain.AddCallMethodExpression("where");
            var method = _where.AddParameterOfCodeMethod().AddParameter("x").AddParameter("y");
            method.StepStatement("var cc = 1;");
            method.StepStatement("var cc = 1;");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    this.where(function (x, y) {
        var cc = 1;
        var cc = 1;
    });
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
