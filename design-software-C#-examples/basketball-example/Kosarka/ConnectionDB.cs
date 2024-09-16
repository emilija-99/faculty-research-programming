using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka
{
    public class ConnectionDB
    {
        private static SqlConnection _conn = null;
        public static SqlConnection Connection
        {
            get
            {
                if(_conn == null)
                    _conn = new SqlConnection();
                return _conn;
            }
        }
    }
}
