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
        List<T> Query(string sql, IRowMapper<T> rowMapper, object[] parameters);
        long Insert(string sql, object[] parameters);
        void Update(string sql, object[] parameters);
    }
}
