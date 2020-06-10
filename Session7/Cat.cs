using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Cat : Animal
    { 

        public void Hihi()
        {
            Console.WriteLine("Cat miaow hello.");
        }

        public void Snippet3()
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "lazearoungd";
            Console.WriteLine("The Cat loves to eat " + objCat.Food + ".");
            Console.WriteLine("The Cat loves to " + objCat.Activity + ".");
        }
    }
}
