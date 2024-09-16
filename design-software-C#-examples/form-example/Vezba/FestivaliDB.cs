using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    public class FestivaliDB : IFestivali
    {
        private SqlConnection _conn = ConnectionDB.Connection;

        public List<int> DajGodine()
        {
            _conn.Open();
            String query = @"select disticnt(godina) from lineup_festivala";

            List<int> godine = new List<int>();

            SqlCommand comm = new SqlCommand(query, _conn);
            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
                godine.Add((int)rdr["godina"]);
            }

            _conn.Close();
            return godine;
        }

        public List<int> dajSveDane(int godina, Festival festival)
        {
            _conn.Open();

            List<int> dani = new List<int>();

            String query = @"select dan from karte k
                            where k.godina = @godina and k.idFestivala = @id";
            SqlCommand comm = new SqlCommand(query, _conn);
            comm.Parameters.AddWithValue("@godina", godina);
            comm.Parameters.AddWithValue("@id", festival.id);

            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
                dani.Add((int)rdr["dani"]);
            }

            return dani;
        }

        public List<PoseteFestivalima> dajSveFestivaleZaPosetioca(int idPosetioca)
        {
            _conn.Open();
            List<PoseteFestivalima> poseteFestivalima = new List<PoseteFestivalima>();

            String query = @"select f.naziv, k.godina, k.dan, k.cena from karte k where k.idPosetioca = @idPosetioca join
                            lineup_festivala lf on k.godina = lf.godina, k.dan = lf.dan and lf.idFestivala = k.idFestivala
                            join festivali f on f.idFestivala = k.idFestivala";
            SqlCommand comm = new SqlCommand(query, _conn);
            
            comm.Parameters.AddWithValue("@idPosetioca", idPosetioca);

            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
                poseteFestivalima.Add((rdr["naziv"].ToString(),
                                     (int.Parse(rdr["godina"].ToString()),
                                     (int.Parse(rdr["dan"].ToString()),
                                     (int.Parse(rdr["cena"].ToString()))));

            }
            _conn.Close();
            return poseteFestivalima;
        }

        public List<Festival> dajSveFestivaleTeGodine(int godina)
        {
            _conn.Open();

            List<Festival> festivali = new List<Festival>();

            String query = @"select f.id, f.naziv from lineup_festivala lf join festivali f 
                            on lfgodina = @godina and lf.idFestivala = f.idFestivala";

            SqlCommand comm = new SqlCommand(query, _conn);
            comm.Parameters.AddWithValue("@godina", godina);
            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
                festivali.Add(new Festival((int)rdr["id"], rdr["naziv"].ToString()));
            }

            return festivali;
        }

        public List<Posetilac> dajSvePosetioce(int godina, Festival festival, int dan)
        {
            List<Posetilac> posetioci = new List<Posetilac>();
            _conn.Open();

            String query = @"select p.idPosetioca, p.ime from posetioci p join karte k
                                on k.idFestivala = @festival.id and k.dan = @dan and k.godina = @godina
                                and k.idPosetioca = p.idPosetioca";

            SqlCommand comm = new SqlCommand(query,_conn);
            comm.Parameters.AddWithValue("@godina", godina);
            comm.Parameters.AddWithValue("@festival.id", festival.id);
            comm.Parameters.AddWithValue("@dan", dan);

            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
                posetioci.Add(new Posetilac((int)rdr["idPosetioca"], rdr["ime"].ToString()));
            }

            _conn.Close();
            return posetioci;
        }

        public void cena(int godina, Festival f, Posetilac p, int dan, int cena)
        {
            _conn.Open();
            
            String sql = @"insert into table karte values(@idFestivala, @godina, @dan, @idPosetioca, @cena)";
            Karta k = null;
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@idFestivala", f.id);
            cmd.Parameters.AddWithValue("@godina", godina);
            cmd.Parameters.AddWithValue("@idPosetioca", p.idPosetioca);
            cmd.Parameters.AddWithValue("@dan", dan);
            cmd.Parameters.AddWithValue("@cena", cena);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                k = new Karta(
                    (int)rdr["idFestivala"],
                    (int)rdr["godina"],
                    (int)rdr["dan"],
                    (int)rdr["idPoseioca"],
                    (int)rdr["cena"]);
            }
            
        }
    }
}
