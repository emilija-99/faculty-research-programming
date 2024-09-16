using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DList
{
    class Program
    {

        //public delegate void Delegat<T>(T value);

        public static void funkcija(Teniser t)
        {
            Console.WriteLine("Novi teniser " + t);
        }



        public static void funkcija_v2(int t)
        {
            Console.WriteLine("Novi teniser " + t);
        }

        public static bool paran(Teniser t)
        {
            if (t.brojPoena % 2 == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            DList<Teniser> lista1 = new DList<Teniser>();
            DList<Teniser> lista2 = new DList<Teniser>();

            lista1.DodatJeNoviElement += funkcija;
            //lista.DodatJeNoviElement += funkcija_v2;

            lista1.dodaj(new Teniser("Ime 1", "Prezime 1", 100));
            lista1.dodaj(new Teniser("Ime", "Prezime 2", 205));
            lista1.dodaj(new Teniser("Ime 3", "Prezime 3", 55));
            lista1.dodaj(new Teniser("Ime", "Prezime 4", 150));
            lista2.dodaj(new Teniser("Ime", "Prezime 5", 305));
            lista2.dodaj(new Teniser("Ime 6", "Prezime 6", 150));
            lista2.dodaj(new Teniser("Ime", "Prezime 7", 50));
            lista2.dodaj(new Teniser("Ime 8", "Prezime 8", 305));

            DList<Teniser> lista = lista1 + lista2;

            //lista.stampajElemente();

            Console.WriteLine("-------------");

            //Console.WriteLine("3 - " + lista[3]);
            //Console.WriteLine("5 - " + lista[5]);

            foreach(var t in lista)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("-------------");

            /*
            foreach (var t in lista.ObrnutiPoredak())
            {
                Console.WriteLine(t);
            }


            List<Teniser> genericList = (List<Teniser>)lista;
            
            Console.WriteLine("C# lista");

            foreach (var t in genericList)
            {
                Console.WriteLine(t);
            }
            */

            foreach (var t in lista.Where(element => element.ime.Length > 3))
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
