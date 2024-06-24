using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practica2
{
    internal class Calculator
    {
        public Calculator() {}

        public int Sum(int n1, int n2)
        {
            return n1+ n2;
        }

        public int subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public int multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public int division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
