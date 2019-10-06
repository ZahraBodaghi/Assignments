using System;
using System.Collections.Generic;
/*
 * Zahra Bodaghi
 */
namespace ProductManagement
{
    public class Product
    {
        public Product() { }
        #region Properties, Variables and Fields
        public Product(int productId)
        {
            this.ProductId = productId;
        }
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        #endregion
        /// <summary>
        /// Retrive One product
        /// </summary>
        /// <param name="productId"> id of the order that retrive</param>
        /// <returns></returns>
        public Product Retrive(int productId) => new Product();
        /// <summary>
        /// Retive a List Of all products. (I added this method since my customer class has one)
        /// </summary>
        /// <returns>list of products</returns>
        public List<Product> Retrive() => new List<Product>();
        /// <summary>
        /// Save the current product
        /// </summary>
        /// <returns>true if it saves</returns>
        public bool Save(Product product) => true;
        /// <summary>
        /// Validate the product data
        /// </summary>
        /// <returns>true if product name is not empty</returns>
        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
