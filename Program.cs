using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sp = new SmartPhone("Xiomi");
            sp.Connect();
            sp.Charge(18);
            Console.WriteLine(sp.Display());
            Laptop lp = new Laptop("Lenovo");
            lp.Connect();
            lp.Charge(12);
            Console.WriteLine(lp.Display());

            Console.ReadKey();
        }
    }
}
