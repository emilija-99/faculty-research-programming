using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvostrukoPovezanaGenerickaLista
{
    interface IUporediv<Tip>
    {
        public int Uporedi(Tip tip);
    }
}
