using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest16
    {
        [TestMethod]
        public void Test()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var switchStepBuilder = codeMethod.StepSwitch("value");
            for (int i = 0; i < 3; i++)
            {
                var tempCase = switchStepBuilder.WithCase(i);
                {
                    tempCase.StepStatement("//test");
                    tempCase.StepStatement($"console.log({i})");
                }
            }
            for (int i = 3; i < 6; i++)
            {
                var tempCase = switchStepBuilder.WithCase(i);
            }
            for (int i = 6; i < 9; i++)
            {
                var tempCase = switchStepBuilder.WithCase(i).SetLinkToNext(true);
            }
            {
                var defaultCase = switchStepBuilder.WithDefault();
                defaultCase.StepStatement("//test");
                defaultCase.StepStatement($"console.log(11)");
            }

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    switch (value) {
        case 0: {
            //test
            console.log(0)
        }
            break;
        case 1: {
            //test
            console.log(1)
        }
            break;
        case 2: {
            //test
            console.log(2)
        }
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
        case 7:
        case 8:
        default: {
            //test
            console.log(11)
        }
            break;
    }
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
