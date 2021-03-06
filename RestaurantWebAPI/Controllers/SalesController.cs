﻿using RestaurantWebAPI.DTO;
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
    public class SalesController : ApiController
    {
        private ISaleService saleService;

        public List<SaleDTO> Get()
        {
            saleService = SaleService.Instance;
            return saleService.FindAll();
        }

        [Route("api/sales/search")]
        [HttpGet]
        public List<SaleDTO> Search(string keyword)
        {
            saleService = SaleService.Instance;
            return saleService.FindByKeyWord(keyword);
        }

        public SaleDTO Post(SaleDTO sale)
        {
            saleService = SaleService.Instance;
            return saleService.Save(sale);
        }

        public SaleDTO Put(long id, SaleDTO sale)
        {
            saleService = SaleService.Instance;
            return saleService.Update(id, sale);
        }

        public bool Delete(long id)
        {
            saleService = SaleService.Instance;
            return saleService.Delete(id);
        }
    }
}
