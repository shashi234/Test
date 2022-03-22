using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculator
{
    [TestClass]
    public class calculatortests
    {
        int a = 4; int b = 5;

        [TestMethod]
        public void TestMultiply()
        {
            int expected = 20;

            Calculate c = new Calculate();
            int result = c.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAdd()
        {
            int expected = 9;

            Calculate c = new Calculate();
            int result = c.Add(a, b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSubstract()
        {
            int expected = -1;

            Calculate c = new Calculate();
            int result = c.Substract(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            float expected = 0.8F;

            Calculate c = new Calculate();
            float result = c.Divide(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}