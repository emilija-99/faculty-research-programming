using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe3
{
    delegate int nazivDelegata(int p1, int p2);
    
    internal class Program
    {

        /*
         * -> Delegati - pokazivaci na funkcije koje imaju isti potipis
         * funkcije istog tipa i vracaju int (potpis im je isti)
         
        static int Saberi(int a, int b)
        {
            return a + b;
        }
        static int Oduzmi(int a, int b)
        {
            return a - b;
        }
        static void funkcija(int a, int b, nazivDelegata n)
        {
            Console.WriteLine(n(a, b));
        }
       // private static IEnumerable<object> Vrednost;
        */

        static void ispisiTemp(int temperatura)
        {
            Console.WriteLine("Nova temperatura je " + temperatura);
        }
        static void ispisiTemp1(int temperatura)
        {
            Console.WriteLine("Druga temperatura je " + temperatura);
        }
        static void Main(string[] args)
        {

            /*
             * Events -> obavestenja o akciji
             * 1. Kreiranje delegata
             * 2. Event
             * 
             * Lista funkcija koja treba da se pozove okidanjem eventa
            */
            Termometar t = new Termometar();
            t.temperaturaJePromenjenaDogadjaj += ispisiTemp;
            t.temperaturaJePromenjenaDogadjaj += ispisiTemp1;
            t.MeriTemperaturu();
            /*
             Delegati ->
             Console.WriteLine(Saberi(10, 25));
             nazivDelegata f;
             f = Saberi; // kada pozivamo f, pozivamo saberi
             Console.WriteLine(f(10, 23));
             f = Oduzmi;
             Console.WriteLine(f(10, 23));
             /*
              * nacin pozivanja funkcija koje nisu staticke
                 new Program.funckija(10, 5, Saberi);

             funkcija(10, 22, Saberi);
             funkcija(10, 22, Oduzmi);
             funkcija(10, 22, Math.Max);
             funkcija(10, 22, Math.Min);
             */

            /*
            Vrednost vrednost = new Vrednost(5);
            vrednost[0] = "vrednost0";
            vrednost[1] = "vrednost1";
            vrednost[2] = "vrednost2";

               vrednost[2] = "v0";
               object o = vrednost[2];
               Console.WriteLine(o);

               vrednost["3"] = "v1";
               o = vrednost[3];
               Console.WriteLine(o);

            -> podrska za foreach (implicit)
            foreach (object s in vrednost)
            {
                Console.WriteLine(s);
                 
                 * move next, current => kako radi foreach;
                 
            }
            -> explicit
            -> Where filyter;
            foreach (var item in vrednost.DajVrednosti().Where(v=>((string)v).Length>5))
            {
                Console.WriteLine(item);
                // pozovi se na DajVrenosti();
            }
*/

        }
    }
}
