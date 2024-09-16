using System;

namespace GenerickaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<Student> listaStudenata = new Lista<Student>(new Student("Pera",8.2));

            listaStudenata.Add(new Student("Mika",6.2));
            listaStudenata.Add(new Student("Zika",7.1));
            listaStudenata.Add(new Student("Patkica", 10));
            listaStudenata.Add(new Student("Sotka", 6.0));

            foreach (Student s in listaStudenata)
            {
                Console.WriteLine(s);
            }

            listaStudenata.Sortiraj();
            Console.WriteLine("Sortirano: ");
            foreach (Student s in listaStudenata)
            {
                Console.WriteLine(s);
            }
        }
    }
}
