using System;

namespace Class_Assignment
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I'll divide it in two!"); 
            int y = Convert.ToInt32(Console.ReadLine());
           
            Division division = new Division();
            division.DivideByTwo(y);

            int x = 10;
            division.DivideByTwo(out x, y); 
            Console.WriteLine(x);

            FirstClass.FirstMethod();
        }
        static class FirstClass
        {
            public static void FirstMethod()
            {
                Console.WriteLine("Hello, from my static class.");
            }
        }
    }
}
