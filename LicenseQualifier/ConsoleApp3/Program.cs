using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool impared = false;
            string dui = "";
            int tickets = 0;


            Console.WriteLine("How old are you?");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Write \"yes\" or \"no\"");
            dui = Console.ReadLine();
                if (dui == "yes") { impared = true; }
            Console.WriteLine("How many driving tickets have you gotten?");
            tickets = Convert.ToInt16(Console.ReadLine());
            if (age > 15 && impared == false && tickets <= 3 )
                { Console.WriteLine("You qualify for a license!"); }
            else
                { Console.WriteLine("Sorry, you do not qualify."); }
            Console.ReadLine();

        }
    }
}
