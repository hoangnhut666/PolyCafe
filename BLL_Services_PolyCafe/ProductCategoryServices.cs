using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models_PolyCafe;
using DAL_Data_PolyCafe;
using DAL_Data_PolyCafe.Constants;

namespace BLL_Services_PolyCafe
{
    public class ProductCategoryServices
    {
        private readonly ProductCategoryRepository productCategoryRepository;

        public ProductCategoryServices()
        {
            productCategoryRepository = new ProductCategoryRepository();
        }

        public List<ProductCategory> GetAllProductCategories()
        {
            // Assuming ProductCategoryRepository is defined and has a method GetAll
            ProductCategoryRepository productCategoryRepository = new ProductCategoryRepository();
            return productCategoryRepository.GetAll();
        }

        //Get product category by creteria
        public List<ProductCategory> GetProductCategoriesByCriteria(string columnName, string value)
        {
            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            return productCategoryRepository.GetProductCategoriesByCriteria(columnName, value);
        }

        // Get product categories id
        public string GenerateProductCategoryId()
        {
            return EntityRepository.GenerateId(DbTables.ProductCategory, ProductCategoryColumns.CategoryId ,"LSP");
        }

        // Add a new product category
        public int AddProductCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
            {
                throw new ArgumentNullException(nameof(productCategory), "Product category cannot be null.");
            }
            return productCategoryRepository.Insert(productCategory);
        }


        // Update an existing product category
        public int UpdateProductCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
            {
                throw new ArgumentNullException(nameof(productCategory), "Product category cannot be null.");
            }
            return productCategoryRepository.Update(productCategory);
        }


        // Delete a product category by ID
        public int DeleteProductCategory(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                throw new ArgumentException("Category ID cannot be null or empty.", nameof(categoryId));
            }
            return productCategoryRepository.Delete(categoryId);
        }
    }
}
