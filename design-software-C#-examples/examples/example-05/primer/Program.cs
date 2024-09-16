using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    internal class Program
    {
        class Rezultat
        {
            public int zbir;
            public int razlika;
            // za vracanje vise vrednosti class, struct, array
        }



        static int snap1(ref int x1, ref int x2, out int razlika)
        {
            int p = x1;
            x1 = x2;
            x2 = p;

            razlika = x1 - x2;
            return x1 + x2;
            // out int -> moramo da setujemo neku vrednost (ref)

        }
        static Rezultat snap(ref int x1, ref int x2)
        {
            int p = x1;
            x1 = x2;
            x2 = p;
            return new Rezultat
            {
                zbir = x1 + x2,
                razlika = x1 - x2
            };
            // returnx new[] {x1=x2,x1+x2};
        }
        List<Dictionary<String, String>> F { get; }

        static void Main(string[] args)
        {
            // properties(get/set) -> iza promenljive da postoji logika
            //  Class1 d = new Class1();
            // d.dan = 60;
            // d.dan = 10;
            //  Console.WriteLine(d.dan); // poziva get i vraca private Dan

            // d.mesec = 12; prvivate set, compile error
            //   Console.WriteLine(d.mesec);


            // mozemo prost tip da koristimo kao referentni
            /*        int x1 = 10;
                    int x2 = 20;
                    int razlika;
                    var rez1 = F();
                    // lokalno instanciranje
                    var e = new { o = 10, s = "sfjksfjskjf"};
                    String novo1 = e.s;
                    int novo = e.o;

                    snap(ref x1, ref x2); // ako saljemo po referenci, radi
                    Console.WriteLine("X1 = " + x1 + " X2 = " + x2);

                    Rezultat rez = snap(ref x1, ref x2);
                    Console.WriteLine("SNAP => Rezultat zbir = " + rez.zbir + ", Rezultat razlika = " + rez.razlika);

                    int p = snap1(ref x1, ref x2, out razlika);
                    Console.WriteLine("SNAP1 => Zbir = "+p+" Razlika = "+razlika);

                    enum Dani { Ponedeljak, Utorak, Sreda }
            */
            // cast
            // siri u uzi tip ne gube se informacije
            // uzi u siri tip, potreban je cast
            /*          int p = 10;
                      double d = 10.3;
                      d = p;
                      p = (int)d;

             */

            Kilometar km = new Kilometar(1);
            /*
             explicit 
             Milja m = (Milja)km; // Milja se pretvara u Kilomenatr
            */
            // implicit
            Milja m1 = km;
            Console.WriteLine("Milja = " + m1.vrednost);
           
            int kmInt = 1;

            // od int pravimo objekat
            Milja m = kmInt;
            Console.WriteLine("Milja = " + m.vrednost);

            if(m1 == m)
            {
                Console.WriteLine("Same");
            }
            if(m1 != m)
            {
                Console.WriteLine("Not the Same");
            }

            // indekseri
            Milja m3 = new Milja(0);
            Console.WriteLine("Milja3 = " + m3.vrednost);
            int[] niz = new int[] { 1, 2, 3 };
            niz[2] = 10;

            m3[0,"Tekst"] = "String";
            Console.WriteLine(m3[0,""]);

        }
    }
}
    
