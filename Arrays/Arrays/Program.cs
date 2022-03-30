using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] oceans = { "N Pacific", "S Pacific", "N Atlantic", "S Atlantic", "Arctic", "Indian", "Southern" };
            int answer1 = 0;

            Console.WriteLine("Choose one of the seven seas! (numbers 0-6)");
            answer1 = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine(oceans[answer1]);


            int[] fav_numbers = { 69, 420, 17, 0, 20 };
            int answer2 = 0;

            Console.WriteLine("Choose one of my favorite numbers! (numbers 0-4)");
            answer2 = Convert.ToInt16(Console.ReadLine());
            while (answer2 > fav_numbers.Length)
            {
                Console.WriteLine("That's too many, there's only five! Try again.");
                answer2 = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("That is " + (fav_numbers[answer2]));

            List<int> least_numbers = new List<int>();
            least_numbers.Add(19);
            least_numbers.Add(7);
            least_numbers.Add(45);
            least_numbers.Add(112);
            int answer3 = 0;

            Console.WriteLine("Choose one of my least favorite numbers! (numbers 0-4)");
            answer3 = Convert.ToInt16(Console.ReadLine());
            while (answer3 > least_numbers.Count)
            {
                Console.WriteLine("That's too many, there's only five! Try again.");
                answer3 = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("That is " + (least_numbers[answer3]));
            Console.ReadLine();
        }
    }
}
