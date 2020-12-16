using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Mapper
{
    public interface IRowMapper<T>
    {
        T MapRow(MySqlDataReader reader);
    }
}
