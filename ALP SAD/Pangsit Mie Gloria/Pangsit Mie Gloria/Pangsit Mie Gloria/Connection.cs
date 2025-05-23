using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangsit_Mie_Gloria
{
    internal class Connection
    {
        #region field
        private MySqlConnection sqlConnect;
        #endregion

        #region const
        public Connection()
        {
            SqlConnect = new MySqlConnection("server=localhost;uid=root;pwd='root';database=Pangsit_Mie_Gloria;");
            Connect();
        }
        #endregion

        #region property
        public MySqlConnection SqlConnect { get => sqlConnect; set => sqlConnect = value; }
        #endregion

        #region method
        public void Connect()
        {
            if (SqlConnect.State == System.Data.ConnectionState.Open)
            {
                SqlConnect.Close();
            }
            SqlConnect.Open();
        }

        public static MySqlDataReader query(string sql)
        {
            Connection conn = new Connection();
            MySqlCommand comm = new MySqlCommand(sql, conn.SqlConnect);
            MySqlDataReader hasil = comm.ExecuteReader();
            return hasil;
        }

        public static int dml(string sql)
        {
            Connection conn = new Connection();
            MySqlCommand comm = new MySqlCommand(sql, conn.SqlConnect);
            int hasil = 0;
            hasil = comm.ExecuteNonQuery();
            return hasil;
        }
        #endregion
    }
}
