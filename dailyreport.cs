using System;

namespace dailyreport
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string course = "";
            int page = 0;
            bool help = false;
            string experience = "";
            string feedback = "";
            int hours = 0;
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();
            Console.WriteLine("What page number?");
            page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
