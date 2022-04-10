using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProblem MathObj = new MathProblem();

            int Var1 = 5; 
            Console.WriteLine("Passing the int value of 5 into the method. Return this: " + MathObj.AddFive(Var1));

            decimal Var2 = 6.4m;                
            Console.WriteLine("Passing the decimal value of 6.4 into the method. Return this: " + MathObj.AddFive(Var2)); 

            string Var3 = "8";               
            Console.WriteLine("Passing the string value of 8 into the method. Return this: " + MathObj.AddFive(Var3));

            Console.ReadLine();
        }
    }
}