

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTestForAbs
    {
        public AllFunctions _calculator = new AllFunctions();

        [TestMethod]
        public void PositiveTestMethod()
        {
            double arg1 = -3.1;
            double actualresult = 3.1;
            double result = _calculator.Abs(arg1);
            Assert.AreEqual(result, actualresult);

        }


        [TestMethod]
        public void NegativeTestMethod()
        {
            double arg1 = -2;
            double result = _calculator.Abs(arg1);
            Assert.IsFalse( result < 0);
        }
    }
}
