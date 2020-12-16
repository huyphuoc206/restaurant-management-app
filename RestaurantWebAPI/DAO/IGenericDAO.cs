using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface IGenericDAO<T>
    {
        List<T> query(string sql, IRowMapper<T> rowMapper, object[] parameters);
        int update(string sql, object[] parameters);
        long insert(string sql, object[] parameters);

    }
}
