using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class SaleService : ISaleService
    {
        private ISaleDAO saleDAO;
        private static SaleService instance;

        public static SaleService Instance
        {
            get { if (instance == null) instance = new SaleService(); return instance; }
            private set => instance = value;
        }
        private SaleService() { }

        public List<SaleDTO> FindAll()
        {
            saleDAO = SaleDAO.Instance;
            return saleDAO.FindAll();
        }

        public SaleDTO Save(SaleDTO sale)
        {
            if (sale.Discount < 0 || sale.Discount > 100) return null;
            saleDAO = SaleDAO.Instance;
            sale.CreatedDate = DateTime.Now;
            long id = saleDAO.Save(sale);
            return saleDAO.FindOneById(id);
        }

        public SaleDTO Update(long id, SaleDTO sale)
        {
            if (sale.Discount < 0 || sale.Discount > 100) return null;
            saleDAO = SaleDAO.Instance;
            SaleDTO oldSale = saleDAO.FindOneById(id);
            if (oldSale != null)
            {
                sale.CreatedDate = oldSale.CreatedDate;
                sale.CreatedBy = oldSale.CreatedBy;
                sale.ModifiedDate = DateTime.Now;
                if (saleDAO.Update(id, sale))
                    return saleDAO.FindOneById(id);
            }
            return null;

        }

        public bool Delete(long id)
        {
            saleDAO = SaleDAO.Instance;
            return saleDAO.Delete(id);
        }
    }
}