using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Calculation
    {
        int a, b, result;
        public int Add(int a, int b)
        { return a + b; }
        public int Subtract(int a, int b) {  return a - b; }
        public int Multiply(int a, int b)
        {
                return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public bool IsPrime(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                if (a == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }   }
    }
}
