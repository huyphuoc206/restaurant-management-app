using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Service;
using RestaurantWebAPI.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantWebAPI.Controllers
{
    public class TablesController : ApiController
    {
        private ITableService tableService;

        public List<TableDTO> Get()
        {
            tableService = TableService.Instance;
            return tableService.FindAll();
        }

        public TableDTO Post(TableDTO table)
        {
            tableService = TableService.Instance;
            return tableService.Save(table);
        }

        public TableDTO Put(long id, TableDTO table)
        {
            tableService = TableService.Instance;
            return tableService.Update(id, table);
        }

        public void Delete(long id)
        {
            tableService = TableService.Instance;
            tableService.Delete(id);
        }
    }
}
