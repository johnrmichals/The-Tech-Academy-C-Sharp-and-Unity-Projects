using System;

namespace salarycomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double person1hourly = 0;
            double person1workweek = 0;
            double person2hourly = 0;
            double person2workweek = 0;
            double person1salary = 0;
            double person2salary = 0;
            bool person1higher = true;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("What is Person 1's hourly wage?");
            person1hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours does Person 1 work a week?");
            person1workweek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is Person 2's hourly wage?");
            person2hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours does Person 2 work a week?");
            person2workweek = Convert.ToDouble(Console.ReadLine());

            person1salary = (person1hourly + person1workweek) * 52;
            person2salary = (person2hourly + person2workweek) * 52;
            if (person2salary > person1salary) { person1higher = false; }

            Console.WriteLine("The Annual Salary of Person 1 is $" + person1salary);
            Console.WriteLine("The Annual Salary of Person 2 is $" + person2salary);
            Console.WriteLine("Does Person 1 make more money? " + person1higher);
            Console.ReadLine();


        }
    }
}
