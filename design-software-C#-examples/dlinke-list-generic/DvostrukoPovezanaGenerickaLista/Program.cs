using System;

namespace DvostrukoPovezanaGenerickaLista
{
    class Program
    {
        //public event Delegati<Tip> DodatJeNoviElement;
        public static void funkcija(Teniser t)
        {
            Console.WriteLine("Dodat je novi teniser " + t);
        }

        public static bool paran(Teniser t)
        {
            if (t.brojATP % 2 == 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            DvostrukaLista<Teniser> lista = new DvostrukaLista<Teniser>();

            lista.DodatJeNoviElement += funkcija;

            lista.dodaj(new Teniser("Zoran","Zoki",1000));
            lista.dodaj(new Teniser("Miroslav", "Miki", 2000));
            lista.dodaj(new Teniser("Patkica", "Patka", 3000));
            lista.dodaj(new Teniser("Srdjan", "Srle", 12000));

            lista.Stampaj();

            Console.WriteLine("-----------------");

            Console.WriteLine("Treci element je: "+lista[3]);

            Console.WriteLine("-----------------");

            foreach (Teniser t in lista)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("-----------------");

            foreach (Teniser t in lista.ObrnutiPoredak())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("-----------------");

            foreach (var item in lista.where(paran))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
