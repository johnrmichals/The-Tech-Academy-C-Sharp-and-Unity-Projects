using System;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            person.SayName();
            person.Quit();
        }
    }
}
