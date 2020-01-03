using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppCode.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var temp = AppCode.Class1.Hello();

            Assert.AreEqual("Hello World", temp);
        }
    }
}
