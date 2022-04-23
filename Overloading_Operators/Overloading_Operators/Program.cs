using System;

namespace Overloading_Operators
{
    class program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            if (employee1 == employee2)
                Console.WriteLine("True!");
            if (employee1 != employee2)
                Console.WriteLine("False!");
        }
    }
}