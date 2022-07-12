using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Operations
{
    internal class MultiplyOperation : IMathOperation
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }

        public string GetOperationSign()
        {
            return "*";
        }
    }
}
