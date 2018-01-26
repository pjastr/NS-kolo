using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bank
    {
        string nazwa;

        Bank(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public static Bank Utworz(string nazwa)
        {
            return new Bank(nazwa);
        }
    }
}
