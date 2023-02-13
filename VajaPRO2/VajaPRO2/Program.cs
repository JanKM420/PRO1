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
            for (int i = 0; i < 100; i++)
            {
                int st = random.Next(0, 100);
                vsota += st;
                Console.WriteLine("Naključna številka {0}: {1}", i + 1, st);
            }
            Console.WriteLine("Vsota teh 100 števil je: {0}", vsota);
            Console.ReadLine();
        }
    }
}
