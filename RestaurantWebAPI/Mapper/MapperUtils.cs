using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class MapperUtils
    {
        public static bool HasColumn(string columnName, MySqlDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {

                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}