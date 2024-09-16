using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Student : IUporediv<Student>
    {
        public String ime;
        public String prezime;
        public String indeks;
        public double prosek;

        public Student()
        {

        }
        public Student(string ime, string prezime, string indeks, double prosek)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.indeks = indeks;
            this.prosek = prosek;
        }

        public override string ToString()
        {
            return this.ime+" "+this.prezime+" "+this.indeks+" "+this.prosek;
        }

        public int Uporedi(Student tip)
        {
            if(this.prosek > tip.prosek)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
