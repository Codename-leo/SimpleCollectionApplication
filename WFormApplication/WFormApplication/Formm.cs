﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormApplication
{
    public delegate int getAnswer(int num1, int num2);
    class Formm
    {
        public static int Addition(int x, int y)
        {

            return x + y;
        }
        public static int Subtraction(int x, int y)
        {
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            return x / y;
        }
        
    }
}
