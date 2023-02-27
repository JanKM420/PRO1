using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ŠtudentANG : ŠtudentABS
    {
        public override string Izpis()
        {
            string r = "";
            r += "******ŠTUDENT ANGLEŠČINE******";
            r += Environment.NewLine + "Delni 1" + delni1;
            r += Environment.NewLine + "Delni 2" + delni2;
            r += Environment.NewLine + "Seminarska " + seminar;
            r += Environment.NewLine + "Ustna " + ustna;
            r += Environment.NewLine + "Končna  " + Ocena();
            r += Environment.NewLine + "Črka  " + Črka();
            return r;

        }

        public override double Ocena()
        {
            return 0.25 * delni1 + 0.25 * delni2 + 0.3 * seminar + 0.2 * ustna;
        }

        public override string Črka()
        {
            double x = Ocena();
            if (x >= 93)
                return "A";
            if (x >= 85)
                return "B";
            if (x >= 78)
                return "C";
            if (x >= 70)
                return "D";
            return "F";
        }
    }
}
