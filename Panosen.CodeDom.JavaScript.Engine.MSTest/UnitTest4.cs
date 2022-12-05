using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var ifStepBuilder = codeMethod.StepIf("true")
                 .StepStatement("name = age.ToString();")
                 .StepStatement("name = age.ToString();");
            for (int i = 0; i < 3; i++)
            {
                var elseIfStepBuilder = ifStepBuilder.WithElseIf("OK");
                elseIfStepBuilder.StepStatement("age = 1;");
                elseIfStepBuilder.StepStatement("age = 2;");
            }

            var elseStepBuilder = ifStepBuilder.WithElse();
            elseStepBuilder.StepStatement("cc = 1;");
            elseStepBuilder.StepStatement("cc = 2;");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    if (true) {
        name = age.ToString();
        name = age.ToString();
    } else if (OK) {
        age = 1;
        age = 2;
    } else if (OK) {
        age = 1;
        age = 2;
    } else if (OK) {
        age = 1;
        age = 2;
    } else {
        cc = 1;
        cc = 2;
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
