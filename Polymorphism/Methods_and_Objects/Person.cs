using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        abstract public void SayName();      
    }
}
