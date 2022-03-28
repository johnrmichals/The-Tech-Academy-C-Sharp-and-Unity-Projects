using System;

namespace PackageDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 0;
            int height = 0;
            int width = 0;
            int length = 0;
            int total = 0;
            bool fits = true;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            weight = Convert.ToInt16(Console.ReadLine());
                if (weight > 50) { 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
                }
            Console.WriteLine("What is the height of your package?");
            height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the width of your package?");
            width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            length = Convert.ToInt16(Console.ReadLine());
                if (weight > 50 || height > 50 || length > 50 ) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            total = ((width * height * length) * weight ) / 100;
            Console.WriteLine("Your esitmated total for this package is $" + total);
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
