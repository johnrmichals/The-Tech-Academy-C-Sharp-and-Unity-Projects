using System;

namespace Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Let's count to 5!");
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            Console.WriteLine(i);
            
            string answer = "";
            while (answer != "gesundheit")
            {   
                Console.WriteLine("Achoo! (say gesundheit!)");
                answer = Console.ReadLine();
            }
            
        }        
    }
}
