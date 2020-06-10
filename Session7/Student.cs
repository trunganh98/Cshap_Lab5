using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Student
    {
        string _studentName = "James";
        string _address = "California";
        public virtual void PrintDetails()
        {
            Console.WriteLine("StudentName: " + _studentName);
            Console.WriteLine("Address: " + _address);
        }
    }

}
