using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //polecenie 2
            List<Konto> bank = new List<Konto>();
            bank.Add(new Konto("erttr", 1000));
            bank.Add(new Konto("werr", 2000));
            bank.Add(new Konto("mnbb", 23000));
            bank.Add(new KontoFirmowe("mnbb", 2233));
            bank.Add(new KontoFirmowe("poui", 1133));
            bank.Add(new KontoFirmowe("mjytr", 78712));
            foreach(var element in bank)
            {
                element.Wyplata(100);
            }
            foreach (var element in bank)
            {
                Console.WriteLine(element);
            }

            //polecenie 3
            bank.Sort();
            Console.WriteLine("Po sortowaniu");
            foreach (var element in bank)
            {
                Console.WriteLine(element);
            }
            bank.Reverse();

            //polecenie 4d
            ROR ror1 = new ROR();
            ror1.Wplata(2000);
            ror1.Odestki();

            //polecenie 5
            try
            {
                Console.WriteLine("Podaj liczbę");
                double saldo = Convert.ToDouble(Console.ReadLine());
                ROR konto2 = new ROR();
                konto2.UstawSaldo(saldo);
            }
            catch
            {
                Console.WriteLine("coś jest nie tak");
            }

            //polecenie 6b
            Bank bank2 = Bank.Utworz("aaa");

            //polecenie 7
            string[,] wyrazy = new string[3,2];
            Console.WriteLine(wyrazy.GetLength(0));
            Console.WriteLine(wyrazy.GetLength(1));
            Console.ReadKey();
        }
    }
}
