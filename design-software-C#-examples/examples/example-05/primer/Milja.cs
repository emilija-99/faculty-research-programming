using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
   
    internal class Milja
    {
        public double vrednost;
        public Milja(double vrednost)
        {
            this.vrednost = vrednost;
        }
        /* uvek je static, explicit cast 
        public static explicit operator Milja(Kilometar km)
        {
            double m = km.vrenost / 1.0;
            Milja milja = new Milja(m);
            return milja;
        }*/
        
        public static implicit operator Milja(Kilometar km)
        {
            double m = km.vrenost / 1.0;
            Milja milja = new Milja(m);
            return milja;
        }
        
        // prihvatamo int, pravimo Milju
        public static implicit operator Milja(int km)
        {
            double m = km / 1.0;
            Milja milja = new Milja(km);
            return milja;
        }
        public static bool operator ==(Milja m1, Milja m2)
        {
            return m1.vrednost == m2.vrednost;
        }
        public static bool operator !=(Milja m1, Milja m2)
        {
            return m1.vrednost != m2.vrednost;
        }

        // indekser
        public int this[int indekser]
        {
            get
            {
                int p = 13432;
                return p;
            }
            set
            {
                vrednost = indekser;
                Console.WriteLine(value);

            }
        }
        public String this[int v, String str]
        {
            get
            {
                return v + str;
            }
            set
            {
                
            //  Console.WriteLine(value);

            }
        }
    }
}
