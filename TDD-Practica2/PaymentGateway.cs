using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    public interface PaymentGateway
    {
        public PaymentResponse requestPayment(PaymentRequest paymentRequest);
    }
}
