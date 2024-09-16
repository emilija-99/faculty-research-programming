using System.Data.SqlClient;

namespace Vezba
{
    public class FestivaliNoSql : IFestivali
    {
        private SqlConnection _conn = ConnectionNoSql.Connection;
    }
}