using System;
using Microsoft.Extensions.Logging;

namespace Calculator
{
    public class Calculate : ISimpleCalculator
    {

        private readonly ILogger<Calculate> _logger;

        public Calculate() { }
        public Calculate(ILogger<Calculate> logger)
        {
            this._logger = logger;
        }


        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            if (a == b) return 0;

            return a - b;
        }

        /*public int Substract(int a, int b)
        {
            if (a == b) return 0;
            if(b>a) return b - a;
            else return a - b;
        }*/

        public int Multiply(int a, int b)
        {
            _logger.LogInformation($"Multiplication result is {a * b}");
            return a * b;
        }

        public float Divide(int a, int b)
        {
            return (float)a / b;
        }


    }
}