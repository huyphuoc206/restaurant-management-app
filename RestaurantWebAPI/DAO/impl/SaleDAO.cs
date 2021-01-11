using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class SaleDAO : AbstractDAO<SaleDTO>, ISaleDAO
    {
        private static SaleDAO instance;

        public static SaleDAO Instance
        {
            get { if (instance == null) instance = new SaleDAO(); return instance; }
            private set => instance = value;
        }

        private SaleDAO() { }

        public List<SaleDTO> FindAll()
        {
            string sql = "SELECT * FROM sales";
            return Query(sql, new SaleMapper());
        }

        public SaleDTO FindOneById(long id)
        {
            string sql = "SELECT * FROM sales WHERE id = @id";
            object[] parameters = { id };
            List<SaleDTO> sales = Query(sql, new SaleMapper(), parameters);
            if (sales.Count == 0) return null;
            return sales[0];
        }

        public long Save(SaleDTO sale)
        {
            string sql = "INSERT INTO sales (name, discount, status, createddate, createdby) VALUES( @name , @discount , @status , @createddate , @createdby )";
            object[] parameters = { sale.Name, sale.Discount, sale.Status, sale.CreatedDate, sale.CreatedBy };
            return Insert(sql, parameters);
        }

        public bool Update(long id, SaleDTO sale)
        {
            string sql = "UPDATE sales SET name = @name , discount = @discount , status = @status , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { sale.Name, sale.Discount, sale.Status, sale.ModifiedDate, sale.ModifiedBy, id };
            return Update(sql, parameters);
        }

        public bool Delete(long id)
        {
            string sql = "DELETE FROM sales WHERE id = @id";
            object[] parameters = { id };
            return Update(sql, parameters);
        }

        public List<SaleDTO> FindByKeyWord(string keyword)
        {
            string sql = "SELECT * FROM sales WHERE name LIKE @keyword";
            keyword = '%' + keyword + '%';
            object[] parameters = { keyword };
            return Query(sql, new SaleMapper(),parameters);
        }
    }
}