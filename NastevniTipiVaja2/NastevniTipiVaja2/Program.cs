using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastevniTipiVaja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int Barva = r.Next(4);
            int Številka = r.Next(13);

            Barva k = (Barva)Barva;
            Vrednost v = (Vrednost)Številka;

            Console.WriteLine("Karta je " + k + " z vrednostjo " + v);
            Console.ReadLine();

        }
    }
}
