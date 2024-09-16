using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Lista
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Student s1 = new Student("Emilija", "Ristic", "114/2018", 6.24);
            Student s2 = new Student("Jovana", "Ristic", "11/2018", 8.24);
            Student s3 = new Student("Danijela", "Ristic", "14/2018", 9.24);
            Student s4 = new Student("Milena", "Ristic", "4/2018", 7.24);

            Lista<Student> listaStudenata = new Lista<Student>();
            listaStudenata.AddStart(s1);
            listaStudenata.AddStart(s2);
            listaStudenata.AddStart(s3);
            listaStudenata.AddStart(s4);

            listaStudenata.StampajListu();

            Lista<Student> listaStudenata1 = new Lista<Student>();
            Student s11 = new Student("Milunka", "Ristic", "114/2014", 6.34);
            Student s22 = new Student("Jordanka", "Ristic", "11/2012", 8.64);
            Student s33 = new Student("Dan", "Ristic", "14/2011", 7.74);
            Student s44 = new Student("Mileva", "Ristic", "4/2010", 5.24);

            listaStudenata1.AddEnd(s11);
            listaStudenata1.AddEnd(s22);
            listaStudenata1.AddEnd(s33);
            listaStudenata1.AddEnd(s44);

            listaStudenata1.StampajListu();

            int broj = listaStudenata.BrojElemenata;
            int broj1 = listaStudenata1.BrojElemenata;
            Console.WriteLine(broj+ ""+ broj1);

            // Console.WriteLine(listaStudenata.VrednostGlave);
            Console.WriteLine("\n");
            List<Student> novi = new List<Student>();
            //Console.WriteLine("PUCA");
            novi = listaStudenata + listaStudenata1;
           
            //Console.WriteLine("PUCA");
        }
            //listaStudenata.ElementJeDuplikat = ElementPostojiUListi(s11);
        }
    }


