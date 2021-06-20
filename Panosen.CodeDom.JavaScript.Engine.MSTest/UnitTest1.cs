using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panosen.CodeDom.JavaScript.Engine.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
}
";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
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


        [TestMethod]
        public void TestMethod3()
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

        [TestMethod]
        public void TestMethod4()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var dataObject = codeMethod.StepReturnSortedDataObject().AddSortedDataObject();
            dataObject.AddDataValue("name", "tom");
            dataObject.AddDataValue("from1", DataValue.SingleQuotationString("english"));
            dataObject.AddDataValue("from2", DataValue.SingleQuotationString("english"));
            dataObject.AddDataValue("age", 18);

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    return {
        age: 18,
        from1: 'english',
        from2: 'english',
        name: tom
    }
}
";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
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


        [TestMethod]
        public void TestMethod6()
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


        [TestMethod]
        public void TestMethod7()
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

        [TestMethod]
        public void TestMethod8()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var request = codeMethod.StepAssignSortedDataObject("var request").AddSortedDataObject();
            request.AddDataObject("name");

            var items1 = request.AddDataArray("items1");
            for (int i = 0; i < 3; i++)
            {
                items1.AddDataObject(new DataObject().AddDataValue($"key{i}", $"value{i}"));
            }

            var items2 = request.AddDataArray("items2");
            for (int i = 0; i < 3; i++)
            {
                items2.AddDataValue(i * 3);
            }

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    var request = {
        items1: [{
            key0: value0
        }, {
            key1: value1
        }, {
            key2: value2
        }],
        items2: [0, 3, 6],
        name: {}
    }
}
";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var dataArray = codeMethod.StepAssignDataArray("items").AddDataArray();
            for (int i = 0; i < 3; i++)
            {
                var dataObject = dataArray.AddDataObject();
                dataObject.AddDataValue($"item_{i}");
            }

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    items = [{
        item_0: null
    }, {
        item_1: null
    }, {
        item_2: null
    }]
}
";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
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

        [TestMethod]
        public void TestMethod11()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            codeMethod.StepStatementChain().AddCallMethodExpression("this.items.push");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    this.items.push();
}
";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod12()
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

        [TestMethod]
        public void TestMethod13()
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

        [TestMethod]
        public void TestMethod14()
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

        [TestMethod]
        public void TestMethod15()
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

        [TestMethod]
        public void TestMethod16()
        {
            var codeMethod = new CodeMethod();
            codeMethod.Name = "TestMethod";

            var chain = codeMethod.StepStatementChain("this");
            var _where = chain.AddCallMethodExpression("where");
            var method = _where.AddParameterOfCodeMethod().SetInLamdaStyle(true).AddParameter("x").AddParameter("y");
            method.StepStatement("var cc = 1;");
            method.StepStatement("var cc = 1;");

            var actual = codeMethod.TransformText();

            var expected = @"function TestMethod() {
    this.where((x, y) => {
        var cc = 1;
        var cc = 1;
    });
}
";

            Assert.AreEqual(expected, actual);
        }
    }
}
