using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    internal class MathProblem
    {
        public int AddFive(int x) { return x + 5; }
        public double AddFive(double x) { return x + 0.5; }
        public static string AddFive(string x) 
        {
            if (x == "one") { return "1"; }
            else if (x == "two") { return "2"; }
            else if (x == "three") { return "3"; }
            else if (x == "four") { return "4"; }
            else if (x == "five") { return "5"; }
            else if (x == "six") { return "6"; }
            else if (x == "seven") { return "7"; }
            else if (x == "eight") { return "8"; }
            else if (x == "nine") { return "9"; }
            else if (x == "ten") { return "10"; }
            else { return "That's not a whole number ten or below!"; }
        }
    }
}
