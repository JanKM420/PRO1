using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastevniTipiVaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Branje iz tipkovnice
            Console.WriteLine("Izberite tip klica: 1-Mobilni, 2-Stacionarni ");
            string klic = Console.ReadLine();
            int tip = int.Parse(klic);
            Console.WriteLine("Vpišite število minut klica");
            int minute = Convert.ToInt32(Console.ReadLine());
            if (tip.Equals(1))
            {
                double znesek = minute * 0.03;
                Console.WriteLine("Vaš znesek je: " + znesek);
            }
            else
            {
                double znesek = minute * 0.2;
                Console.WriteLine("Vaš znesek je: " + znesek);
            }
        }
    }
}
