using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    public class Festival
    {
        public int id;
        public string naziv;

        public Festival(int id, string nazivFestivala)
        {
            this.id = id;
            this.naziv = nazivFestivala;
        }

        public override string ToString()
        {
            return this.naziv;
        }
    }
}
