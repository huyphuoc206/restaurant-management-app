using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class FoodDAO : AbstractDAO<FoodDTO>, IFoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set => instance = value;
        }

        private FoodDAO() { }

        public List<FoodDTO> FindAll()
        {
            string sql = "SELECT food.*, category.name as categoryname FROM food JOIN category ON food.categoryid = category.id";
            return Query(sql, new FoodMapper());
        }

        public FoodDTO FindOneById(long id)
        {
            string sql = "SELECT * FROM food WHERE id = @id";
            object[] parameters = { id };
            List<FoodDTO> food = Query(sql, new FoodMapper(), parameters);
            if (food.Count == 0) return null;
            return food[0];
        }

        public List<FoodDTO> FindAllByCategoryId(long categoryId)
        {
            string sql = "SELECT food.*, category.name as categoryname FROM food JOIN category ON food.categoryid = category.id WHERE categoryid = @categoryid";
            object[] parameters = { categoryId };
            return Query(sql, new FoodMapper(), parameters);
        }

        public long Save(FoodDTO food)
        {
            string sql = "INSERT INTO food (name, price, discount, status, categoryid, createddate, createdby) VALUES ( @name , @price , @discount , @status , @categoryid , @createddate , @createdby )";
            object[] parameters = { food.Name, food.Price, food.Discount, food.Status, food.Category.ID, food.CreatedDate, food.CreatedBy };
            return Insert(sql, parameters);
        }

        public void Update(long id, FoodDTO food)
        {
            string sql = "UPDATE food SET name =  @name , price = @price , discount = @discount , status = @status , categoryid = @categoryid , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { food.Name, food.Price, food.Discount, food.Status, food.Category.ID, food.ModifiedDate, food.ModifiedBy, id };
            Update(sql, parameters);
        }

        public void Delete(long id)
        {
            string sql = "DELETE FROM food WHERE id = @id";
            object[] parameters = { id };
            Update(sql, parameters);
        }
    }
}