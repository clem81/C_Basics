using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        //The virtual keyword means it can be overwritten by sub classes
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes stir fry");
        }
    }
}
