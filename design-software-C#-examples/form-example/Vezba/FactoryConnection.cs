using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    public class FactoryConnection
    {
        public static IFestivali Festval(string baza)
        {
            switch (baza)
            {
                case "sql":
                    return new FestivaliDB();
                    break;
                case "nosql":
                    return new FestivaliNoSql();
                    break;
                default:
                    return new FestivaliDB();
            }
        }
    }
}
