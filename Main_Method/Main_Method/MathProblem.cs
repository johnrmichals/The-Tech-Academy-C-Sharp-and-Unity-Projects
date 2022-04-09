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
        public int AddFive(decimal x) { return Convert.ToInt32(5 + x); }
        public int AddFive(string x) { return Convert.ToInt32(x) + 5; }
    }
}
