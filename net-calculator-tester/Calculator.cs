using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero");
                return 0; 
            }
            return num1 / num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
