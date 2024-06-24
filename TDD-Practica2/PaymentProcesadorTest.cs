using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    [TestClass]
    public class PaymentProcesadorTest
    {
        [TestMethod]
        public void test_then_ok()
        {
            var mockCalculator = new Mock<PaymentGateway>();
            PaymentProcesador mockPayment = new PaymentProcesador(mockCalculator.Object);
            mockCalculator.Setup(g => g.requestPayment(It.IsAny<PaymentRequest>())).Returns(new PaymentResponse(PaymentResponse.PaymentStatus.OK));

            Assert.IsTrue(mockPayment.makePayment(100));
        }

        [TestMethod]
        public void test_then_error()
        {
            var mockCalculator = new Mock<PaymentGateway>();
            PaymentProcesador mockPayment = new PaymentProcesador(mockCalculator.Object);
            mockCalculator.Setup(g => g.requestPayment(It.IsAny<PaymentRequest>())).Returns(new PaymentResponse(PaymentResponse.PaymentStatus.ERROR));

            Assert.IsFalse(mockPayment.makePayment(100));
        }
    }
}
