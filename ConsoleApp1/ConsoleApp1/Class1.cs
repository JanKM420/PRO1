using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class ŠtudentABS
    {
        protected int delni1;
        protected int delni2;
        protected int seminar;
        protected int ustna;

        public int Delni1
        { get => delni1;
            set{
                if (value >= 0 && value <= 100)
                    delni1 = value;
                else
                    throw new Exception("Neveljavna ocena");
            }

        }

        public int Delni2
        { get => delni2;
            set{
                if (value >= 0 && value <= 100)
                    delni2 = value;
                else
                    throw new Exception("Neveljevna ocena");
            }

        }

        public int Seminar
        { get => seminar;
            set{
                if (value >= 0 && value <= 100)
                    seminar = value;
                else
                    throw new Exception("Neveljevna ocena");
            }

        }

        public int Ustna
        { get => ustna;
            set{
                if (value >= 0 && value <= 100)
                    ustna = value;
                else
                    throw new Exception("Neveljevna ocena");
            }

        }
        public abstract double Ocena();
        public abstract string Črka();
        public abstract string Izpis();
    }
}
