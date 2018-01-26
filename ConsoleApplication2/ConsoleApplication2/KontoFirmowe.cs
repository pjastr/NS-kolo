using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class KontoFirmowe:Konto
    {
        public KontoFirmowe(string p1, int p2)
            :base(p1,p2)
        {

        }

        public override string ToString()
        {
            return base.ToString()+" Firma";
        }

        public override void Wyplata(int p3)
        {
            base.Wyplata(p3);
            base.UstawSaldo(base.PobierzSaldo() - 10);
        }
    }
}
