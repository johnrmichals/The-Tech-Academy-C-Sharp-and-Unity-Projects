using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class program
    {  
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Joe", "Mac", "Sam"};

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 4, 6, 8 };

            for (int i = 0; i < employee.Things.Count; i++)
            {
                Console.WriteLine(employee.Things[i] + " " + employee2.Things[i]);
            }
        }        
    }
}
