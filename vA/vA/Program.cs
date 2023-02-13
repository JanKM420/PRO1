using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vsota = 0;
            for (int i = 1; i <= 100; i++)
            {
                vsota += Math.Sin(Math.PI / i);
            }
            Console.WriteLine("Vsota je: {0}", vsota);
            Console.ReadLine();
        }
    }
}
