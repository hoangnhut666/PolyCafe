using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DAL_Data_PolyCafe.Constants;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class ProductServices
    {
        private readonly ProductRepository productRepository;
        public ProductServices()
        {
            productRepository = new ProductRepository();
        }

        // Get all products
        public List<Product> GetAllProducts()
        {
            return productRepository.GetAll();
        }


        // Get product by ID
        public Product? GetProductById(string productId)
        {
            if (string.IsNullOrEmpty(productId))
            {
                throw new ArgumentException("Product ID cannot be null or empty.", nameof(productId));
            }
            return productRepository.GetProductsByCriteria(ProductColumns.ProductId, productId).FirstOrDefault();
        }


        //Generate id automaticly
        public string GenerateProductId()
        {
            return EntityRepository.GenerateId(DbTables.Product, ProductColumns.ProductId, "SP");
        }

        // Get products by criteria
        public List<Product> GetProductsByCriteria(string columnName, string value)
        {
            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            return productRepository.GetProductsByCriteria(columnName, value);
        }

        //Add a new product
        public int AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }
            return productRepository.Insert(product);
        }

        // Update an existing product
        public int UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }
            return productRepository.Update(product);
        }

        // Delete a product by ID
        public int DeleteProduct(string productId)
        {
            if (string.IsNullOrEmpty(productId))
            {
                throw new ArgumentException("Product ID cannot be null or empty.", nameof(productId));
            }
            return productRepository.Delete(productId);
        }

        //Save image path to the database
        public int SaveImagePath(string productId, string imagePath)
        {
            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Product ID and image path cannot be null or empty.");
            }
            return productRepository.UpdateImagePath(productId, imagePath);
        }
    }
}
