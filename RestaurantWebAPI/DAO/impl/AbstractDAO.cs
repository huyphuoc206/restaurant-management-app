using MySql.Data.MySqlClient;
using RestaurantWebAPI.DBUtils;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class AbstractDAO<T> : IGenericDAO<T>
    {

        private void SetParameters(MySqlCommand command, object[] parameters, string sql)
        {
            string[] listPara = sql.Split(' ');
            int i = 0;
            foreach (string item in listPara)
            {
                if (item.Contains('@'))
                {
                    command.Parameters.AddWithValue(item, parameters[i]);
                    i++;
                }
            }
        }

        public List<T> Query(string sql, IRowMapper<T> rowMapper, object[] parameters = null)
        {
            List<T> result = new List<T>();
            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try
            {
                connection = DatabaseUtils.getMySqlConnection();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = sql;
                if (parameters != null)
                    SetParameters(command, parameters, sql);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        result.Add(rowMapper.MapRow(reader));
            }
            catch (Exception e)
            {
                return result;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (connection != null)
                    connection.Close();
            }
            return result;
        }

        public long NonQuery(string sql, object[] parameters = null)
        {
            long id = -1;
            MySqlConnection connection = null;
            MySqlCommand command = null;
            try
            {
                connection = DatabaseUtils.getMySqlConnection();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = sql;
                if (parameters != null)
                    SetParameters(command, parameters, sql);
                command.ExecuteNonQuery();
                id = command.LastInsertedId;
            }
            catch (Exception e)
            {
                return id;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return id;
        }
    }
}