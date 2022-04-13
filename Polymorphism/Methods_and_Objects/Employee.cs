using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Press Enter to Quit");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
    }
}
