﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero");
                return 0; 
            }
            return num1 / num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
