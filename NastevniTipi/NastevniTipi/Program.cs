using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastevniTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planeti p = Planeti.Zemlja;
            Console.WriteLine("Izbrala sem " + p);
            int odd = (int)p;
            Console.WriteLine("Po oddaljenosti od sonca je " + odd);
            PeriodaPlaneti pp = PeriodaPlaneti.Zemlja;
            if (pp <= PeriodaPlaneti.Mars)
            {
                Console.WriteLine("obhodni čas je " + (int)pp);
            }
            else
            {
                Console.WriteLine("obhodni čas ni znan za" + pp);
            }
            //branje iz tipkovnice
            Console.WriteLine("Vnesi zaporedno številko svojega meseca ");
            string odg = Console.ReadLine();
            int mojPlanet = int.Parse(odg);
            Planeti moj = (Planeti)mojPlanet;
            Console.WriteLine("Tvoj planet je " + moj);
            Console.ReadLine();
        }
    }
}
