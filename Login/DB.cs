using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    class DB
    {
        private string constring;
        private MySqlConnection conn;
        public DB()
        {
            this.constring = "SERVER=localhost;DATABASE=login;UID=root;PASSWORD=0307;";
            this.conn = new MySqlConnection(constring);
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }
        public void OpenConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
