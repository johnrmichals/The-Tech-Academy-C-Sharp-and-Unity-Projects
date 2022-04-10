using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Method_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("Gimme one or two numbers (second number can be empty) and I'll add 'em up!");
            var x = Console.ReadLine();                      
            var z = Console.ReadLine();
            AddEmUp MathObj = new AddEmUp();
            if (z == "")
            {
                y = 0;
            }
            else
                y = Convert.ToInt32(z);
            Console.WriteLine(MathObj.AddEm(Convert.ToInt32(x), y));
            Console.ReadLine();

        }
    }
}
