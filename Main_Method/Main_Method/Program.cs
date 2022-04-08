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
            int a = 0;
            double b = 0.0;
            string c = "";

            Console.WriteLine("If you give me a whole number, I will add 5.");
            a = Convert.ToInt32(Console.ReadLine());
            int Var1 = MathObj.AddFive(a);
            Console.WriteLine(Var1);

            Console.WriteLine("If you give me a decimal, I'll add 0.5 to it.");
            b = Convert.ToDouble(Console.ReadLine());
            double Var2 = MathObj.AddFive(b);
            Console.WriteLine(Var2);

            Console.WriteLine("If you type a whole number between one and ten, I'll return that number.");
            c = Console.ReadLine();
            string Var3 = MathProblem.AddFive(c);
            Console.WriteLine(Var3);

        }
    }
}