using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPRO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vsota = 0;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int st = random.Next(0, 1000);
                vsota = vsota+st;
            }
            Console.WriteLine("Povprečje teh 1000 števil je: {0}", vsota/1000);
            Console.ReadLine();
        }
    }
}
