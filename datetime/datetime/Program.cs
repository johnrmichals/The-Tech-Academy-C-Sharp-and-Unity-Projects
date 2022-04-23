using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = DateTime.Now;

            Console.WriteLine("The current time is " + y);
            Console.WriteLine("Gimme a number!");

            int x = Convert.ToInt32(Console.ReadLine());
            var updated = y.Add(TimeSpan.FromHours(x));

            Console.WriteLine("In " + x + " hours it will be " + updated);
            Console.ReadLine();
        }
    }
}
