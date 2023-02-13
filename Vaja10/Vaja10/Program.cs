using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi trimestno število: ");
           
            string b = Console.ReadLine();
            int a = int.Parse(b);

            int c1;
            int c2;
            int c3;

            c1 = a % 10;
            a = a / 10;
            c2 = a % 10;
            a = a / 10;
            c3 = a % 10;

            if(c1%2==0 && c2%2==0 && c3%2==0)
            {
                Console.WriteLine("Vse števke so sode. ");

            }
            else if(c1 % 2 != 0 && c2 % 2 != 0 && c3 % 2 != 0)
            {
                Console.WriteLine("Vse števke so lihe. ");

            }
            else
            {
                Console.WriteLine("Števke so lihe in sode: ");

            }
            Console.ReadLine();
        }

    }
}
