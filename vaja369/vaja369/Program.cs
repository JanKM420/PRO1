using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja369
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Igrača a = new Igrača(1, "Žoga", 5.6);
            Console.WriteLine(a.GetIme() + " " + a.GetCategory());
            Console.WriteLine(a.GetDescription());
            Console.WriteLine(a.GetPrice()+ " "+a.GetDiscountedPrice());

            Knjiga b = new Knjiga(1, "Millenium", 35.3);
            Console.WriteLine(b.GetIme() + " " + b.GetCategory());
            Console.WriteLine(b.GetDescription());
            Console.WriteLine(b.GetPrice() + " " + b.GetDiscountedPrice());
            Console.ReadLine();
        }
    }
}
