using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Konto:IComparable<Konto>
    {
        string wlasciciel;
        int saldo;

        public Konto(string p1, int p2)
        {
            this.wlasciciel = p1;
            this.saldo = p2;
        }

        public override string ToString()
        {
            return "Konto, właściciel: "+wlasciciel+", saldo:"+saldo;
        }

        public virtual void Wyplata(int p3)
        {
            this.saldo = saldo - p3;
        }

        public int PobierzSaldo()
        {
            return saldo; 
        }

        public void UstawSaldo(int p1)
        {
            this.saldo = p1;
        }

        public int CompareTo(Konto other)
        {
            return other.wlasciciel.CompareTo(this.wlasciciel);
        }
    }
}
