using System;

namespace Lambdas
{
    public static class LambdasExtensions
    {
        public static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, Fname = "Joe", Lname = "Smith"},
                new Employee() { Id = 2, Fname = "Mary", Lname = "Jackson"},
                new Employee() { Id = 3, Fname = "Diane", Lname = "O'Neil"},
                new Employee() { Id = 4, Fname = "Luciano", Lname = "Matino"},
                new Employee() { Id = 5, Fname = "Muhammed", Lname = "Ahmad"},
                new Employee() { Id = 6, Fname = "Jason", Lname = "Argonat"},
                new Employee() { Id = 7, Fname = "Jackson", Lname = "Miller"},
                new Employee() { Id = 8, Fname = "Miranda", Lname = "Ingert"},
                new Employee() { Id = 9, Fname = "Camila", Lname = "Chelsea"},
                new Employee() { Id = 10, Fname = "Joe", Lname = "Morgan"}
            };

            int counter = 0;
            List<Employee> joes = new List<Employee>();
            foreach (Employee e in list)
            {
                if (e.Fname == "Joe")
                {
                    joes.Add(e);
                }
                counter++;
            }

            List<Employee> joes2 = new List<Employee>();
            joes2 = list.Where(y => y.Fname == "Joe").ToList();

            List<Employee> greaterthanfive = new List<Employee>();
            greaterthanfive = list.Where(y => y.Id > 5).ToList();


        }
    }
}