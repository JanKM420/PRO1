using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPRO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double vsota = 0;
            double obresti = 0;
            double obrestnaMera = 0.023;

            for (int i = 0; i < 100000; i++)
            {
                double vrednost = rnd.Next(0, 1000001);
                vsota += vrednost;
                obresti += vrednost * obrestnaMera;
            }
            Console.WriteLine("Vsota vseh zneskov: " + vsota);
            Console.WriteLine("2.3% od vsote vseh zneskov: " + vsota * obrestnaMera);
            Console.WriteLine("Vsota obresti: " + obresti);
        }
    }
}
