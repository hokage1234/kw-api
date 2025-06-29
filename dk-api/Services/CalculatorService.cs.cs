using dk_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dk_api.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Nie mo¿na dzieliæ przez zero.");
            return (double)a / b;
        }

       
    }
}
