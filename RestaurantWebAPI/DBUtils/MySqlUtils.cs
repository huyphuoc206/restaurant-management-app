using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DBUtils
{
    public class MySqlUtils
    {
        public static MySqlConnection getConnection(string host, string database, int port, string username, string password)
        {
            string connectionString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
            return new MySqlConnection(connectionString);
        }
    }
}