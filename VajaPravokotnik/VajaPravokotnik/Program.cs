using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPravokotnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik a = new Pravokotnik(5, 8);
            Console.WriteLine($"Pravokotnik a: površina = {a.GetArea()}, obseg = {a.GetPerimeter()}, kvadrat = {a.IsSquare()}");

            Pravokotnik b = new Pravokotnik(6, 6);
            Console.WriteLine($"Pravokotnik b: površina = {b.GetArea()}, obseg = {b.GetPerimeter()}, kvadrat = {b.IsSquare()}");
        }
    }
}
    

