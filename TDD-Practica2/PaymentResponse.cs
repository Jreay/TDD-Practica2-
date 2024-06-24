using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    public class PaymentResponse
    {
        public enum PaymentStatus
        {
            OK, ERROR
        }
        private PaymentStatus Status { get; set; }
        public PaymentResponse(PaymentStatus Status) 
        { 
            this.Status = Status;
        }

        public PaymentStatus GetStatus() { 
            return Status;
        } 
    }
}
