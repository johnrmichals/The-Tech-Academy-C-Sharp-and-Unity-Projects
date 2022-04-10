using System;

namespace Named_Parameter_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme two numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            twoNums TwoNumbers = new twoNums();
            TwoNumbers.TwoNumbers(a, b);
            TwoNumbers.TwoNumbers(x: a, y: b);
        }
    }
}
