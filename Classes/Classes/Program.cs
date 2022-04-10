using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Three MathObj = new Three();
            int y = 0;

            Console.WriteLine("Give me a number and I'll add, subtract, and multiply it by three!");
            y = Convert.ToInt32(Console.ReadLine());
            int newVar1 = MathObj.AddThree(y);
            Console.WriteLine(newVar1);
            int newVar2 = MathObj.SubThree(y);
            Console.WriteLine(newVar2);
            int newVar3 = MathObj.TimesThree(y);
            Console.WriteLine(newVar3);
            Console.ReadLine();
        }
    }
}