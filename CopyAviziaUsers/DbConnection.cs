using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CopyAviziaUsers
{
    public class DbConnection
    {
        private static SqlConnection _con1;
        private static SqlConnection _con2;
        public static SqlConnection con1
        {
            get
            {
                if (_con1 == null)
                {
                    _con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr1"].ConnectionString);
                }
                return _con1;
            }
        }

        public static SqlConnection con2
        {
            get
            {
                if (_con2 == null)
                {
                    _con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr2"].ConnectionString);
                }
                return _con2;
            }
        }

    }
}
