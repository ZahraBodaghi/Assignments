using System;
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
        /// Save the current product
        /// </summary>
        /// <returns>true if it saves</returns>
        public bool Save() => true;
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
            return isValid;
        }
    }
}
