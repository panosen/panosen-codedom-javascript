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
    }
}
