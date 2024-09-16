using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DList
{
    interface IUporediv<GenericType>
    {
        int Uporedi(GenericType value);
    }
}
