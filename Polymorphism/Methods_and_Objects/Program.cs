using System;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable person = new Employee();           

            person.Quit();
        }
    }
}
