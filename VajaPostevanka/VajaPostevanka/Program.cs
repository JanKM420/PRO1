using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPostevanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            do
            {


                Random rnd = new Random();
                Console.WriteLine("Vnesi število poštevanke: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int pravilni = 0;
                int odg = 0;

                for (int i = 0; i < 5; i++)
                {
                    int y = rnd.Next(10);
                    Console.WriteLine(y + "*" + x + "=");
                    odg = Convert.ToInt32(Console.ReadLine());
                    if (y * x == odg)
                    {
                        pravilni++;
                    }

                }
                Console.WriteLine("Pravilni odgovori: " + pravilni);


                Console.WriteLine("Ali želiš vajo ponoviti? (Y/N)");
                string pon = Console.ReadLine();
                p = false;
                if (pon == "Y")
                {
                    p = true;
                }

            } while (p == true);




        }
    }
}