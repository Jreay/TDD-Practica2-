namespace TDD_Practica2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(5, calculator.Sum(3, 2));
            
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(1, calculator.subtraction(3, 2));
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(6, calculator.multiplication(3, 2));
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(1, calculator.division(3, 3));
        }
    }
}