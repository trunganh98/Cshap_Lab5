using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Employees
    {
        int _empId = 1;
        string _empName = "JameAnderson";
        int _age = 25;
        public void Display()
        {
            Console.WriteLine("EmployeeID: " + _empId);
            Console.WriteLine("EmployeeName: " + _empName);
        }

    }

    class Department : Employees
    {
        int _depid = 501;
        string _depName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("DepartmentID" + _depid);
            Console.WriteLine("DepartmentName" + _depName);
        }

        public void Snippet5()
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    } 
}
