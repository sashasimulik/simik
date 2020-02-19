using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            double xy1 = 3;
            double xy2 = 5;
            double xy3 = 4;
            double result = Laba1.Program.Tester(xy1, xy2, xy3);
            Assert.AreEqual(12, result);
        }
    }
}
