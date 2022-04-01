using System;
using System.Collections.Generic;


namespace divider
{
    class Program
    {
        static void Main(string[] args)
        {
            int divider = 0;
            var numbers = new List<int>() { 2, 8, 29, 134, 77, 12, 44, 1 };
            try
            {
                Console.WriteLine("Pick a number to divide my numbers by");
                divider = Convert.ToInt32(Console.ReadLine());
                foreach (int x in numbers)
                {
                    Console.WriteLine(x / divider);
                }
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
