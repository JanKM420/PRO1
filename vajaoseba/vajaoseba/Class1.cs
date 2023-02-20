using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaoseba
{
    internal class Oseba
    {
        private string ime;
        private int starost;

        public Oseba(string ime, int starost)
        {
            this.ime = ime;
            this.starost = starost;
        }

        public int GetAgeInMonths()
        {
            return starost * 12;
        }

        public bool IsAdult()
        {
            return starost >= 18;
        }

        public bool IsEqual(Oseba other)
        {
            return ime == other.ime && starost == other.starost;
        }
    }
}
