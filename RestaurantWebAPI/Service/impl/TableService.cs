using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class TableService : ITableService
    {
        private ITableDAO tableDAO;
        private static TableService instance;

        public static TableService Instance
        {
            get { if (instance == null) instance = new TableService(); return instance; }
            private set => instance = value;
        }
        private TableService() { }

        public List<TableDTO> FindAll()
        {
            tableDAO = TableDAO.Instance;
            return tableDAO.FindAll();
        }

        public TableDTO Save(TableDTO table)
        {
            tableDAO = TableDAO.Instance;
            table.CreatedDate = DateTime.Now;
            long id = tableDAO.Save(table);
            return tableDAO.FindOneById(id);
        }

        public TableDTO Update(long id, TableDTO table)
        {
            tableDAO = TableDAO.Instance;

            TableDTO oldTable = tableDAO.FindOneById(id);
            if (oldTable != null)
            {
                table.CreatedDate = oldTable.CreatedDate;
                table.CreatedBy = oldTable.CreatedBy;
                table.ModifiedDate = DateTime.Now;
                tableDAO.Update(id, table);
                return tableDAO.FindOneById(id);
            }
            return null;
        }

        public void Delete(long id)
        {
            tableDAO = TableDAO.Instance;
            tableDAO.Delete(id);
        }
    }
}