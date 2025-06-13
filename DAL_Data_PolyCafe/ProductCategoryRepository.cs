using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe.Constants;
using DBUTIL_Utilities_PolyCafe;
using DTO_Models_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_Data_PolyCafe
{
    public class ProductCategoryRepository
    {

        public List<ProductCategory> GetAll()
        {
            string query = $"SELECT * FROM {DbTables.ProductCategory}";
            List<ProductCategory> productCategories = Utilities.ExecuteQuery(query, reader =>
            {
                return new ProductCategory
                {
                    CategoryId = reader[ProductCategoryColumns.CategoryId].ToString(),
                    CategoryName = reader[ProductCategoryColumns.CategoryName].ToString(),
                    Notes = reader[ProductCategoryColumns.Notes].ToString(),
                };
            });
            return productCategories;
        }


        // Get product categories by criteria
        public List<ProductCategory> GetProductCategoriesByCriteria(string columnName, string value)
        {
            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            string query = $"SELECT * FROM {DbTables.ProductCategory} WHERE {columnName} = @Value";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<ProductCategory> productCategories = Utilities.ExecuteQuery(query, reader =>
            {
                return new ProductCategory
                {
                    CategoryId = reader[ProductCategoryColumns.CategoryId].ToString(),
                    CategoryName = reader[ProductCategoryColumns.CategoryName].ToString(),
                    Notes = reader[ProductCategoryColumns.Notes].ToString(),
                };
            }, parameters);
            return productCategories;
        }


        public int Insert(ProductCategory productCategory)
        {
            string query = $"INSERT INTO {DbTables.ProductCategory} ({ProductCategoryColumns.CategoryId}, " +
                           $"{ProductCategoryColumns.CategoryName} , {ProductCategoryColumns.Notes})" +
                           $"VALUES (@CategoryId, @CategoryName, @Notes)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryId", productCategory.CategoryId),
                new SqlParameter("@CategoryName", productCategory.CategoryName),
                new SqlParameter("@Notes", productCategory.Notes)
            };

            return Utilities.ExecuteNonQuery(query, parameters);
        }


        public int Update(ProductCategory productCategory)
        {
            string query = $"UPDATE {DbTables.ProductCategory} SET " +
                           $"{ProductCategoryColumns.CategoryName} = @CategoryName, " +
                           $"{ProductCategoryColumns.Notes} = @Notes " +
                           $"WHERE {ProductCategoryColumns.CategoryId} = @CategoryId";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@CategoryId", productCategory.CategoryId),
                new SqlParameter("@CategoryName", productCategory.CategoryName),
                new SqlParameter("@Notes", productCategory.Notes)
            };
            return Utilities.ExecuteNonQuery(query, parameters);
        }



        // Delete a product category by ID
        public int Delete(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                throw new ArgumentException("Category ID cannot be null or empty.", nameof(categoryId));
            }
            string query = $"DELETE FROM {DbTables.ProductCategory} WHERE {ProductCategoryColumns.CategoryId} = @CategoryId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryId", categoryId)
            };
            return Utilities.ExecuteNonQuery(query, parameters);

        }
    }
}


