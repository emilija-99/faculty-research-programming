using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    public interface IFestivali
    {
        List<int> DajGodine();
        List<Festival> dajSveFestivaleTeGodine(int godina);
        List<int> dajSveDane(int godina, Festival festival);

        List<Posetilac> dajSvePosetioce(int godina, Festival festival, int dan);

        List<PoseteFestivalima> dajSveFestivaleZaPosetioca(int idPosetioca);

        void cena(int godina, Festival f, Posetilac p, int dan, int cena);
    }
}
