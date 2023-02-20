using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaoseba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oseba a = new Oseba("Miha", 19);
            Oseba b = new Oseba("Marija", 16);

            Console.WriteLine("Starost osebe a v mesecih: " + a.GetAgeInMonths());
            Console.WriteLine("Oseba a je odrasla: " + a.IsAdult());
            Console.WriteLine("Oseba a je enaka osebi b: " + a.IsEqual(b));

            Oseba c = new Oseba("Ana", 25);

            Console.WriteLine("Oseba a je enaka osebi c " + a.IsEqual(c));
        }
    }
    
}
