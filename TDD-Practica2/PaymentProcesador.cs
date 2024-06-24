using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    public class PaymentProcesador
    {
        private PaymentGateway gateway;
        public PaymentProcesador(PaymentGateway gateway) 
        { 
            this.gateway = gateway;
        }
        public bool makePayment(double amount)
        {
            PaymentResponse response = gateway.requestPayment(new PaymentRequest(amount));
            if (response.GetStatus() == PaymentResponse.PaymentStatus.OK) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
