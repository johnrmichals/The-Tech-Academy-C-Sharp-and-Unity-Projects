using System;
using System.Collections.Generic;

namespace six_part_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE AND TWO

            string[] fnames = { "Johnny", "Bobby", "Sally", "Mandy" };
            string lname = "";
            int i = 0;

            Console.WriteLine("Part 1: Type a last name for a family.");
            lname = Console.ReadLine();
            while ( i < fnames.Length )
            {
                fnames[i] = fnames[i] + " " + lname;
                i++; //stops loop from going infinite   
            }
            i = 0;
            while (i < fnames.Length)
            {
                Console.WriteLine(fnames[i]);
                i++; //stops loop from going infinite
            }
            Console.ReadLine();

            //PART THREE
            int greaterthanfive = 0;

            Console.WriteLine("Type a number greater than five");
            greaterthanfive = Convert.ToInt32(Console.ReadLine());
            while (greaterthanfive <= 5)
            {
                Console.WriteLine("That's not right! Try again");
                greaterthanfive = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Well done!");
            Console.ReadLine();

            //PART FOUR
            int x = 0;
            string answer = "";
            var rainbow_colors = new List<string>()
            {
                "red", "orange", "yellow", "green", "blue", "indigo", "violet"
            };
            bool success = false;

            Console.WriteLine("type a color of the rainbow.");
            answer = Console.ReadLine();
            while (success == false)
            {
                while (x < rainbow_colors.Count)
                {
                    if (answer == rainbow_colors[x])
                    {
                        Console.WriteLine("Yes! " + answer + " is in position " + (x + 1) + " of the rainbow."); //success message
                        x = answer.Length; //exit condition
                        success = true; //exit condition
                    }
                    x++;
                }
                if (success == false)
                {
                    Console.WriteLine(answer + " isn't in the rainbow. Try again."); //error message
                    x = 0;
                    answer = Console.ReadLine();
                }
            }
            //PART FIVE
            var fav_cheeses = new List<string> {"cheddar", "brie", "gouda", "mozzerella", "brie", "feta" };
            string answer2 = "";
            int y = 0;
            bool wrong_cheese = false;

            Console.WriteLine("What kind of cheese do think is on my cheese list?");
            answer2 = Console.ReadLine();
            while (wrong_cheese == false)
            {
                while (y < fav_cheeses.Count)
                {
                    if (answer2 == fav_cheeses[y])
                    {
                        Console.WriteLine(answer2 + " is in position " + y);
                        wrong_cheese = true;
                    }
                    y++;
                }
                if ( wrong_cheese == false )
                {
                    Console.WriteLine("That's not a cheese on my list! Try again.");
                    answer2 = Console.ReadLine();
                }                
            }
            Console.ReadLine();
            //PART SIX
            var animals = new List<string>() { "bear", "tiger", "snake", "owl", "snake", "panther", "gorilla" };
            int counter = 0;
            int q = 0;

            foreach (string z in animals)
            {               
                while (q < animals.Count)
                {
                    if (z == animals[q])
                    {
                        counter++;
                    }
                    q++;
                }               
            Console.WriteLine(z + " appears " + counter + " times.");
                counter = 0;
                q = 0;
            }
        }
    }
}
