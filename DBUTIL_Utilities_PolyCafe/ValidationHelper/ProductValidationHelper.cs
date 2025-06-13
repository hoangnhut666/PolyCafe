using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models_PolyCafe;

namespace DBUTIL_Utilities_PolyCafe.ValidationHelper
{
    public class ProductValidationHelper
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public bool IsValidProductId(Product product)
        {
            // Check if the product ID is not null or empty
            if (string.IsNullOrEmpty(product.ProductId))
            {
                ErrorMessage = "Product ID cannot be null or empty.";
                return false;
            }

            //Check if the unit price is a positive decimal number
            if (product.Price <= 0)
            {
                ErrorMessage = "Product price must be a positive number.";
                return false;
            }

            // Check if the product name is not null or empty
            if (string.IsNullOrEmpty(product.ProductName))
            {
                ErrorMessage = "Product name cannot be null or empty.";
                return false;
            }

            // Check if the category ID is not null or empty
            if (string.IsNullOrEmpty(product.CategoryId))
            {
                ErrorMessage = "Category ID cannot be null or empty.";
                return false;
            }

            return true;
        }
    }
}
