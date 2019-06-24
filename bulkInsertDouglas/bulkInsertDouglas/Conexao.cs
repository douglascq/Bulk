using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BulkInsert
{
    public class Conexao
    {
        public SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = "Data Source=192.168.20.222;Initial Catalog=BD_Dist;Persist Security Info=True;User ID=wimp;Password=c14n11g2000;Connect Timeout=30000";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
