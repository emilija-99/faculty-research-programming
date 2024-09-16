using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    public class Class1 // : object
    {
        public Class1()
        {
            mesec = 12;
        }
        // int p; default private
        // public int p; 
        // internal int p1;
        private int godina;
        public int mesec
        {  // moze samo da se uzima vrednost, ali ne da se setuje(ili obrnuto)
            get;
            private set;
        }
        private int Dan;
        public int dan // promenljiva ima svojstvo ne postoji fizicki u memoriji, ponasa se kao funkcija
        {
            get { return Dan; }
            set 
            {
                if (dan < 0 && dan > 30)
                    throw new Exception("Dan nije ispravan");
                Dan = value;
            }

        }

 /*       public void setDan(int dan)
        {
            // pravimo logiku kako da setujemo
            if(dan < 0 && dan > 30)
            { // C# ne zahteva da mu naglasavamo da koristimo izuzetke kao u javi 
                throw new Exception("Dan name ispravnu vrendost");
            }
            this.dan = dan; // enkapsulacija -> ne dozvoljavamo da neko setuje vrednosti 
        }
*/        
    }
}
