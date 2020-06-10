using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Program
    {
        static void Main(string[] args)
        {
            snippet1();
            snippet2();
            snippet5();
            snippet6();
            snippet7();
            snipper9();
            snippet10();
            snippet11();
            snippet13();
            Console.ReadLine();
        }

        static void snippet1()
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
              
        static void snippet2()
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.DoSomething();
            objCat.Hihi();
            objCat.Snippet3();
        }

        static void snippet5()
        {
            Department objDepartment = new Department();
            objDepartment.Snippet5();
        }

        static void snippet6()
        {
            Canine objCandine = new Canine();
        }

        static void snippet7()
        {
            Automobiles objAutomobiles = new Automobiles("Chassies");
        }

        static void snipper9()
        {
            Student objStudent = new Student();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
        }

        static void snippet10()
        {
            Product objProduct = new Product();
            objProduct.Quantity = 50;
            objProduct.Cost = 75;
            Console.WriteLine("Quantity of the Product: " + objProduct.Quantity);
            Console.WriteLine("Cost of the Product: " + objProduct.Cost);
        }

        static void snippet11()
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.Print();
        }

        static void snippet13()
        {
            Circle objRunOne = new Circle();
            Console.WriteLine("Area is: " +objRunOne.Area());
            Circle objRunTwo = new Cone();
            Console.WriteLine("Area is: " +objRunTwo.Area());
        }
    }

}
