using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class CategoryDAO : AbstractDAO<CategoryDTO>, ICategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set => instance = value;
        }

        private CategoryDAO() { }

        public List<CategoryDTO> FindAll()
        {
            string sql = "SELECT * FROM category";
            return Query(sql, new CategoryMapper());
        }

        public CategoryDTO FindOneById(long id)
        {
            string sql = "SELECT * FROM category WHERE id = @id";
            object[] parameters = { id };
            List<CategoryDTO> categories = Query(sql, new CategoryMapper(), parameters);
            if (categories.Count == 0) return null;
            return categories[0];
        }

        public long Save(CategoryDTO category)
        {
            string sql = "INSERT INTO category (name, status, createddate, createdby) VALUES( @name , @status , @createddate , @createdby )";
            object[] parameters = { category.Name, category.Status, category.CreatedDate, category.CreatedBy };
            return Insert(sql, parameters);
        }

        public bool Update(long id, CategoryDTO category)
        {
            string sql = "UPDATE category SET name = @name , status = @status , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { category.Name, category.Status, category.ModifiedDate, category.ModifiedBy, id };
            return Update(sql, parameters);
        }

        public bool Delete(long id)
        {
            string sql = "DELETE FROM category WHERE id = @id";
            object[] parameters = { id };
            return Update(sql, parameters);
        }
    }
}