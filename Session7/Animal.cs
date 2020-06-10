using System;

namespace Session7
{
    class Animal
    {
        protected string Food;
        protected string Activity;

        

        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Every animal does something.");
        }

    }

}
