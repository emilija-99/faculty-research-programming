using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka
{
    public class Utakmica
    {
        public int id;
        public string pocetak;
        public string domacin;
        public string gost;
        public string rezultat;
        public int idEkipeDomacina;
        public int idEkipeGosta;

        public Utakmica(int id, int idEkipeDomacina, int idEkipeGosta, string pocetak, string domacin, string gost, string rezultat)
        {
            
            this.id = id;
            this.idEkipeDomacina = idEkipeDomacina;
            this.idEkipeGosta = idEkipeGosta;
            this.pocetak = pocetak;
            this.domacin = domacin;
            this.gost = gost;
            this.rezultat = rezultat;
        }

       
    }
}
