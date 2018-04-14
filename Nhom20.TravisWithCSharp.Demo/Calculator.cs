using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom20.TravisWithCSharp.Demo
{
    public class Calculator
    {
        public int Add(int x1, int y)
        {
            return x1 + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            return x / y;
        }
    }
}
