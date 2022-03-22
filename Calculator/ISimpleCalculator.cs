using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ISimpleCalculator
    {
        int Add(int a, int b);
        int Substract(int a, int b);
        int Multiply(int a, int b);
        float Divide(int a, int b);
    }
}
