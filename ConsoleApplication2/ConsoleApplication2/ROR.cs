using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ROR:IOperacje
    {
        private double saldo;



        public void Wplata(int param1)
        {
            this.saldo+=param1;
        }

        public void Odestki()
        {
            if (saldo > 0) saldo += 5;
            else if (saldo <0) saldo-=10;
        }

        public void UstawSaldo(double p1)
        {
            this.saldo = p1;
        }
    }
}
