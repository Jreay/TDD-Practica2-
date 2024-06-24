using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    [TestClass]
    public class IUnitTest1
    {
        [TestMethod]
        public void give_two_integers_adicitions_ok() 
        {
            var mockCalculator = new Mock<ICalculator>();

            mockCalculator.Setup(c => c.Addition(2, 3)).Returns(5);

            var calculator = mockCalculator.Object;

            int result = calculator.Addition(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
