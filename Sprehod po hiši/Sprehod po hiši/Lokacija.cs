using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprehod_po_hiši
{
    internal class Lokacija
    {
        public string ime;
        public Lokacija[] izhodi;
        public Lokacija(string i)
        {
            ime = i;
        }
        public string Opis()
        {
            string r = "";
            r += "Trenutno si v " + ime;
            r += Environment.NewLine;
            r += "Od tu lahko greš: ";
            r += Environment.NewLine;
            for (int k = 0; k < izhodi.Length; k++)
            {
                r += k + " - " + izhodi[k].ime;
                r += Environment.NewLine;
            }
            return r;
        }

    }
}
