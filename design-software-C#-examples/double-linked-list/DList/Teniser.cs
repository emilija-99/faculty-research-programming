zusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DList
{
    class Teniser : IUporediv<Teniser>
    {
        public string ime;
        public string prezime;
        public int brojPoena;

        public Teniser()
        {
           
        }

        public Teniser(string ime, string prezime, int brojPoena)
        {
            this.ime = ime;
            this.brojPoena = brojPoena;
            this.prezime = prezime;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + brojPoena;
        }

        public int Uporedi(Teniser value)
        {
            if (this.brojPoena < value.brojPoena)
                return 1;
            else
                if (this.brojPoena > value.brojPoena)
                return -1;
            else
                return 0;
        }
    }
}
