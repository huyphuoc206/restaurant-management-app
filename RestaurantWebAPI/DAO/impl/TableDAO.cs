using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class TableDAO : AbstractDAO<TableDTO>, ITableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set => instance = value;
        }

        private TableDAO() { }

        public List<TableDTO> FindAll()
        {
            string sql = "SELECT * FROM tables";
            return Query(sql, new TableMapper());
        }

        public TableDTO FindOneById(long id)
        {
            string sql = "SELECT * FROM tables WHERE id = @id";
            object[] parameters = { id };
            List<TableDTO> tables = Query(sql, new TableMapper(), parameters);
            if (tables.Count == 0) return null;
            return tables[0];
        }

        public long Save(TableDTO table)
        {
            string sql = "INSERT INTO tables (name, seats, status, createddate, createdby) VALUES ( @name , @seats , @status , @createddate , createdby )";
            object[] parameters = { table.Name, table.Seats, table.Status, table.CreatedDate, table.CreatedBy };
            return Insert(sql, parameters);
        }

        public void Update(long id, TableDTO table)
        {
            string sql = "UPDATE tables SET name = @name , seats = @seats , status = @status , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { table.Name, table.Seats, table.Status, table.ModifiedDate, table.ModifiedBy, id };
            Update(sql, parameters);
        }

        public void Delete(long id)
        {
            string sql = "DELETE FROM tables WHERE id = @id";
            object[] parameters = { id };
            Update(sql, parameters);
        }
    }
}