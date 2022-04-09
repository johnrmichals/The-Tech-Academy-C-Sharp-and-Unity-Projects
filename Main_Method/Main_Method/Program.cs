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

            int Var1 = MathObj.AddFive(6);
            Console.WriteLine(Var1);

            int Var2 = MathObj.AddFive(Convert.ToInt32(6.4m));
            Console.WriteLine(Var2);

            int Var3 = MathObj.AddFive(Convert.ToInt32('8'));
            Console.WriteLine(Var3);
        }
    }
}