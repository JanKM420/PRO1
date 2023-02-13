using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi temperaturo vode od 5 do 100 stopinj: ");

            string s = Console.ReadLine();
            int t = int.Parse(s);

            if(t <= 10)
            {
                Console.WriteLine("Zelo mrzla");
            }
            else if(10 < t && t <= 20)
            {
                Console.WriteLine("Hladna");
            }
            else if(20 < t && t <= 30)
            {
                Console.WriteLine("Topla");
            }
            else if (30 < t && t <= 50)
            {
                Console.WriteLine("vroča");
            }
            else if(t > 50)
            {
                Console.WriteLine("Zelo vroča");
            }
            Console.ReadLine();
        }
    }
}
