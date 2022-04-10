using System;

namespace Class_Assignment
{
    static class Program //program class declared static 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I'll divide it in two!"); 
            int y = Convert.ToInt32(Console.ReadLine());

            Division division = new Division(); //instantiates the method
            division.DivideByTwo(y); //calls the method with user input
        }
    }
}
