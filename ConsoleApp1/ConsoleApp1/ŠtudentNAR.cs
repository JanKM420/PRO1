using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ŠtudentNAR : ŠtudentABS
    {
        public override string Izpis()
        {
            string r = "";
            r += "******ŠTUDENT NARAVOSLOVJA******";
            r += Environment.NewLine + "Delni 1" + delni1;
            r += Environment.NewLine + "Delni 2" + delni2;
            r += Environment.NewLine + "Seminarska" + seminar;
            r += Environment.NewLine + "Končna  " + Ocena();
            r += Environment.NewLine + "Črka  " + Črka();
            return r;

        }

        public override double Ocena()
        {
            return 0.4 * delni1 + 0.4 * delni2 + 0.2 + seminar;
        }

        public override string Črka()
        {
            double x = Ocena();
            if (x >= 90)
                return "A";
            if (x >= 80)
                return "B";
            if (x >= 70)
                return "C";
            if (x >= 60)
                return "D";
            return "F";
        }
    }
}
