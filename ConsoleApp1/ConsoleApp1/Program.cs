using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi oddelek študenta 1-ang,2-mat,3-nar");
            int oddelek = int.Parse(Console.ReadLine());
            switch (oddelek)
            {
                case 1:
                    ŠtudentANG n = new ŠtudentANG();
                    Console.WriteLine("Vnesi delni 1");
                    n.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2");
                    n.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi seminarsko");
                    n.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi ustno");
                    n.Ustna = int.Parse(Console.ReadLine());
                    Console.WriteLine(n.Izpis());
                    break;
                case 2:
                    ŠtudentMAT m = new ŠtudentMAT();
                    Console.WriteLine("Vnesi delni 1");
                    m.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2");
                    m.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(m.Izpis());
                    break;
                case 3:
                    ŠtudentNAR v = new ŠtudentNAR();
                    Console.WriteLine("Vnesi delni 1");
                    v.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2");
                    v.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("vNESI Seminarsko");
                    v.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine(v.Izpis());
                    break;
            }
            Console.ReadLine();
        }
    }
}
