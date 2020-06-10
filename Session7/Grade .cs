using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Grade : Student
    {
        string _class = "Four";
        float _percent = 71.25f;
        public override void PrintDetails()
        {
            Console.WriteLine("Class: " + _class);
            Console.WriteLine("Percentage: " + _percent);
        }
    }
}
