using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe4
{
    public class Student : IPrebivaliste, IComparable<Student>
    {
        public int Id { get; set; }
        public Student()
        {
            // mora da postoji podrazumevani konstruktor
        }
        public Student(int id)
        {
            Id = id;
        }
           
        public override string ToString()
        {
            return "Ovo je student! "+Id;
        }

        public string dajIme()
        {
            return "Ime studenta";
        }

        public int CompareTo(Student other)
        {
            return 0;
        }
    }
}
