using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPravokotnik
{
    internal class Pravokotnik
    {
        private readonly int dolzina;
        private readonly int sirina;

        public Pravokotnik(int dolzina, int sirina)
        {
            this.dolzina = dolzina;
            this.sirina = sirina;
        }
        public int GetArea()
        {
            return dolzina * sirina;
        }
        public int GetPerimeter()
        {
            return 2 * (dolzina + sirina);
        }
        public bool IsSquare()
        {
            return dolzina == sirina;
        }
    }
}

