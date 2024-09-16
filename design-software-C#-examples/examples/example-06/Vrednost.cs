using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe3
{
    internal class Vrednost : IEnumerable
    {
        private object[] vrednosti;
        internal Vrednost(int Count)
        {
            vrednosti = new object[Count];
            
        }
        // object uzimamo, vracamo int
        internal object this[int indeks]
        {
            get
            {
                return vrednosti[indeks];
            }
            set
            {
                vrednosti[indeks] = value; // ono sto se setuje 
            }
        }
		internal object this[String indeks]
		{
			get
			{
				return vrednosti[Int32.Parse(indeks)];
			}
			set
			{
				vrednosti[Int32.Parse(indeks)] = value; // ono sto se setuje 
			}
		}

        public IEnumerator GetEnumerator()
        {
            return new NasEnumetor(vrednosti);
           
        }
        // IEnumerable za bilo koji tip podataka
        public IEnumerable<object> DajVrednosti()
        {
            // kolekcija vrednosti i da se prodje kroz funkciju
            yield return "v23132111";
            yield return "v2";
            /*
             * return -> kraj funkcije
             * yield -> pravi kolekciju i mozemo da vratimo rproizvoljan broj vrednosti
             * a foreach preuzima iz te kolekcije jednu po jendu vrednost
             
            foreach(var item in vrednosti)
            {
                yield return item;
            }
            */

        }


}
}
