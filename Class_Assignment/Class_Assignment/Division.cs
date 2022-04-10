using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment
{
    class Division
    {
        public void DivideByTwo(int x)
        {
            Console.WriteLine(x / 2);
        }
        public int TimesThree(int x) //method with output parameters
        {
            return x * 3;
        }
        public float TimesThree(float x) //overloading a method
        {
            return x / 3;
        }
    }
}
