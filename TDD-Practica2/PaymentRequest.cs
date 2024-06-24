using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    public class PaymentRequest
    {
        private double amount;
        public PaymentRequest(double amount)
        {
            this.amount = amount;
        } 

        public double GetAmount() 
        {
            return amount;
        }
    }
}
