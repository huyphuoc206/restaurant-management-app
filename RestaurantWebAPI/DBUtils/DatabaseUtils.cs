using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DBUtils
{
    public class DatabaseUtils
    {
        private static MySqlConnection connection;
        public static MySqlConnection getMySqlConnection()
        {
            if(connection == null)
            {
                string host = "localhost";
                int port = 3306;
                string database = "restaurantmanagement";
                string username = "root";
                string password = "";
                connection =  MySqlUtils.getConnection(host, database, port, username, password);
            }
            return connection;
        }
    }
}