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

        [Route("api/tables/search")]
        [HttpGet]
        public List<TableDTO> Search(string keyword)
        {
            tableService = TableService.Instance;
            return tableService.FindByKeyWord(keyword);
        }

        public TableDTO Get(long id)
        {
            tableService = TableService.Instance;
            return tableService.FindOneById(id);
        }

        public TableDTO Post(TableDTO table)
        {
            tableService = TableService.Instance;
            return tableService.Save(table);
        }

        public TableDTO Put(long id, TableDTO table)
        {
            tableService = TableService.Instance;
            return tableService.Update(id,table);
        }

        public bool Delete(long id)
        {
            tableService = TableService.Instance;
            return tableService.Delete(id);
        }
    }
}
