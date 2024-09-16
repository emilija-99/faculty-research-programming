using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    public class Karta
    {
        public int idFestivala;
        public int godina;
        public int dan;
        public int idPosetioca;
        public int cena;
    
        public Karta(int idFestivala, int godina, int dan, int idPosetioca, int cena)
        {
            this.idFestivala = idFestivala;
            this.godina= godina;
            this.dan = dan;
            this.idPosetioca = idPosetioca;
            this.cena= cena;
        }
    }
}
