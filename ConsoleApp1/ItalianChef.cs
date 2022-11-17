using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ItalianChef : Chef //ItalianChef inherate Chef 
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
        public override void MakeSpecialDish() //as you can see we use the same method in Chef class
        {
            //with override,program use the italianChef's makespecial method when we call it
            // not the chef's makespecialdish's methos
            Console.WriteLine("The Chef makes chichken parm");
        }

    }
}
