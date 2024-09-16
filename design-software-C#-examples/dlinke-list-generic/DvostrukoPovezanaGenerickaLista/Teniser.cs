using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvostrukoPovezanaGenerickaLista
{
    class Teniser : IUporediv<Teniser>
    {
        string ime;
        string prezime;
        public int brojATP;

        public Teniser()
        {
        
        }

        public Teniser(string ime, string prezime,int brojATP) {
            this.ime = ime;
            this.prezime = prezime;
            this.brojATP = brojATP;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + brojATP;
        }

        public int Uporedi(Teniser teniser) {
            if (this.brojATP > teniser.brojATP)
                return 1;
            return 0;
        }
    }
}
