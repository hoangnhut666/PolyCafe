using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe.Constants;
using DTO_Models_PolyCafe;
using DBUTIL_Utilities_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_Data_PolyCafe
{
    public class ProductRepository
    {
        //Get all products
        public List<Product> GetAll()
        {
            string sql = $"SELECT * FROM {DbTables.Product}";
            List<Product> products = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Product
                {
                    ProductId = reader[ProductColumns.ProductId].ToString(),
                    ProductName = reader[ProductColumns.ProductName].ToString(),
                    UnitPrice = Convert.ToDecimal(reader[ProductColumns.Price]),
                    CategoryId = reader[ProductColumns.CategoryId].ToString(),
                    Image = reader[ProductColumns.Image].ToString(),
                    Status = Convert.ToBoolean(reader[ProductColumns.Status])
                };
            });
            return products;
        }

        //Get products by criteria
        public List<Product> GetProductsByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM {DbTables.Product} WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Product> products = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Product
                {
                    ProductId = reader[ProductColumns.ProductId].ToString(),
                    ProductName = reader[ProductColumns.ProductName].ToString(),
                    UnitPrice = Convert.ToDecimal(reader[ProductColumns.Price]),
                    CategoryId = reader[ProductColumns.CategoryId].ToString(),
                    Image = reader[ProductColumns.Image].ToString(),
                    Status = Convert.ToBoolean(reader[ProductColumns.Status])
                };
            });
            return products;
        }

        //Insert a new product
        public int Insert(Product product)
        {
            string sql = $"INSERT INTO {DbTables.Product} " +
                         $"({ProductColumns.ProductId}, {ProductColumns.ProductName}, {ProductColumns.Price}, " +
                         $"{ProductColumns.CategoryId}, {ProductColumns.Image}, {ProductColumns.Status}) " +
                         $"VALUES (@ProductId, @ProductName, @Price, @CategoryId, @Image, @Status)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", product.ProductId),
                new SqlParameter("@ProductName", product.ProductName),
                new SqlParameter("@Price", product.UnitPrice),
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Image", product.Image),
                new SqlParameter("@Status", product.Status)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Update an existing product
        public int Update(Product product)
        {
            string sql = $"UPDATE {DbTables.Product} SET " +
                         $"{ProductColumns.ProductName} = @ProductName, " +
                         $"{ProductColumns.Price} = @Price, " +
                         $"{ProductColumns.CategoryId} = @CategoryId, " +
                         $"{ProductColumns.Image} = @Image, " +
                         $"{ProductColumns.Status} = @Status " +
                         $"WHERE {ProductColumns.ProductId} = @ProductId";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", product.ProductId),
                new SqlParameter("@ProductName", product.ProductName),
                new SqlParameter("@Price", product.UnitPrice),
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Image", product.Image),
                new SqlParameter("@Status", product.Status)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Delete a product
        public int Delete(string productId)
        {
            string sql = $"DELETE FROM {DbTables.Product} WHERE {ProductColumns.ProductId} = @ProductId";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", productId)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Update product image file path to database
        public int UpdateImagePath(string productId, string imagePath)
        {
            string sql = $"UPDATE {DbTables.Product} SET {ProductColumns.Image} = @Image WHERE {ProductColumns.ProductId} = @ProductId";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", productId),
                new SqlParameter("@Image", imagePath)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}