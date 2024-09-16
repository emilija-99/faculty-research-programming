using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka
{
    public class FKosarka : IKosarka
    {
        SqlConnection db = ConnectionDB.Connection;

        // upis u DataGridView
        public List<Utakmica> SveUtakmice()
        {
            db.Open();
            List<Utakmica> utakmice = new List<Utakmica>();

            String query = @"select pocetakUtakmice, id, idEkipeDomacina, idEkipeGosta, 
                (select naziv from Ekipa where IdEkipe = idEkipeGosta) as gost,
                (select naziv from Ekipa where IdEkipe = idEkipeDomacina) as domacin,
                concat(
                    (select sum(tp.vrednostPogotka) from Pogodak p join TipPogodtka tp on p.idTipaPogotka = tp.id join Igrac i on i.id = p.idIgraca where u.id = p.idUtakmice and i.idEkipe = idEkipeDomacina),':',
                    (select sum(tp.vrednostPogotka) from Pogodak p join TipPogodka tp on p.idTipaPogodtka = tp.id join Igrac i on i.id = p.idIgraca where u.id = p.idUtakmice and i.idEkipe = idEkipeGosta) 
                as rezultat)
                from Utakmica u";

            SqlCommand comm = new SqlCommand(query, db);
            SqlDataReader rdr = comm.ExecuteReader();

            while(rdr.Read())
            {
                utakmice.Add(
                    new Utakmica((int)rdr["id"],(int)rdr["idEkipeDomacina"], (int)rdr["idEkipeGosta"], rdr["pocetakUtakmice"].ToString(), rdr["domacin"].ToString(), rdr["gost"].ToString(), rdr["rezultat"].ToString()));
            }

            db.Close();
            return utakmice;
        }

    }
}
