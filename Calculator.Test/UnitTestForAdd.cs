using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTestForAdd
    {
        public AllFunctions _calculator = new AllFunctions();

        [TestMethod]
        public void PositiveTestMethod()
        {

            double arg1 = 3.1;
            double arg2 = 2;
            double actualresult = 5.1;
            double result = _calculator.Add(arg1, arg2);
            Assert.AreEqual(result, actualresult);

        }

        [TestMethod]
        public void NegativeTestMethod()
        {
            double arg1 = 3.1;
            double arg2 = 2;
            double actualresult = 5;
            double result = _calculator.Add(arg1, arg2);
            Assert.AreNotEqual(result, actualresult);
        }
    }
}
