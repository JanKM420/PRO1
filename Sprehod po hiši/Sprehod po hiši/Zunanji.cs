using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprehod_po_hiši
{
    internal class Zunanji:Lokacija
    {
        bool jeVroče;
        public  Zunanji(string i,bool v):base(i)
        {
            jeVroče = v;
        }
        public string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r += "Je vroče? " + jeVroče + Environment.NewLine;
            return r;
        }
    }
}
