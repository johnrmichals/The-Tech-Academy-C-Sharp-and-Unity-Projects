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
        public void DivideByTwo(out int x, int y) 
        {
            y /= 2;
            x = y; 
        }
    }
}
