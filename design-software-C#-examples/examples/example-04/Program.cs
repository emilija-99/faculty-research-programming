using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe4
{
    internal class Program
    {
        public delegate Tip3 GenerickiDelegat<Tip3,Tip1,Tip2> (Tip1 a, Tip2 b);

        public delegate int funkcija(int x, int y);
        public delegate int funkcija1(int x, int y, int z);
        
        public static int saberi(int x, int y)
        {
            return x + y;
        }
        public static bool daLiJeParan(int broj)
        {
            return broj % 2 == 0;
        }
        public static int saberiDouble(double a, string x)
        {
            return (int)(a+x.Length);
        }
        static void Main(string[] args)
        {

            /* Delegati anonimni -> lokalne funkcija 
               funkcija f = delegate(int a, int b)
               {
                   return a - b;
               };
               Console.WriteLine(f(10, 25));
               f = delegate (int a, int b)
               {
                   return a + b;
               };
               Console.WriteLine(f(10, 25));

               lambda izrazi (mora da se definise delegat)
                (lista argumenata) => izraz (jedan red) ili {telo, obavezan return}

               f = (x, y) => x / y;
               Console.WriteLine(f(10, 5));

               funkcija1 f1 = (x, y, z) =>
               {
                   return x + y + z;
               };
               Console.WriteLine(f1(10, 5, 9));

                * Implementacija liste, sa filterima (lamda)
                * Iz liste zelimo da izvucemo sve neparne brojeve

               List<int> list = new List<int>(); 
               for(int i = 0; i < 10; i++)
               {
                   list.Add(i);
               }

               int s = 0;
               foreach(var item in list)
               {
                   if (item % 2 == 0)
                   {
                       Console.WriteLine(item);
                       s += item;
                   }
               }

               Console.WriteLine("Suma elemenata parnih, foreach :"+s);

                za svaki element gde vazi sledece, prihvata funkciju(lambda izraz)
               var s1 = list.Where(elementListe => elementListe % 2 == 0).Sum(); // suma svih elemenata 
               Console.WriteLine("Suma elemenata parnih, lambda izraz : "+s1);

               var c = list.Where(elementListe => elementListe % 2 == 0).Count(); // za koje elemente iz liste vazi 
                var c = list.Where(daLiJeParan).Count();
               Console.WriteLine("Broj elemenata liste koji su parni: "+c);

               foreach(var item in list.Where(daLiJeParan))
               {
                   Console.WriteLine(item);
               }

               foreach (var item in list.Where(x => x > 6))
               {
                   Console.WriteLine(item);
               }
           */

            /*
             * Genericke klase -> cuva razlicite tipove i radi sa njima
                Kada radimo sa tom klasom, naglasavamo joj sta radimo
             
             

                   Test<int, string> t = new Test< int, string>(0,0,"genericki2");
                 t.Write();
           
            Test<Student, int> t1 = new Test<Student, int>(10, new Student(114), 10);
             <T vrednost;V vrednost2;int vrednost1;>
             */
            Test<string, Student> t = new Test<string, Student>("Sds", new Student(10),15);
            t.Write();


            //   GenerickiDelegat<int> gd = saberi;
            //   GenerickiDelegat<double> gd1 = saberiDouble;
            GenerickiDelegat<int, double, string> gd = saberiDouble;
            Console.WriteLine(saberiDouble(10, "ss"));



        }
    }
}
