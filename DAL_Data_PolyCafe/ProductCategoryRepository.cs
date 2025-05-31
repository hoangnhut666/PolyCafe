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
        public string GenerateProductCategoryId()
        {
            string prefix = "LSP";
            string query = $"SELECT COUNT(*) FROM {DbTables.ProductCategory}";
            int count = Convert.ToInt32(Utilities.ExecuteScalar(query));
            return prefix + (count + 1).ToString("D3");
        }


        public List<ProductCategory> GetAllProductCategories()
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
            return productCategories ;
        }

        public int Insert(ProductCategory productCategory) {
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


        public int Update(ProductCategory productCategory) {
            string query = $"UPDATE {DbTables.ProductCategory}" +
                           $"{ProductCategoryColumns.CategoryName} " +
                           $"{ProductCategoryColumns.Notes}";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@CategoryName", productCategory.CategoryName),
                new SqlParameter("@Notes", productCategory.Notes),
            };

            return Utilities.ExecuteNonQuery(query, parameters);
        }



        public int Delete(string categoryId) {
            string query = $"DELETE FROM {DbTables.ProductCategory}" +
                           $"WHERE {ProductCategoryColumns.CategoryId} = @CategoryId";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@CategoryId", categoryId)
            };

            return Utilities.ExecuteNonQuery(query, parameters);
        }
    }
}


