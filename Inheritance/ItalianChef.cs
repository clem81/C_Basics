using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // The colon is used to inherit the functionality of the Chef class
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The ItalianChef makes pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian Chef makes bolognese");
        }
    }
}
