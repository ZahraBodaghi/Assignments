using System;
using System.Collections.Generic;
/*
 * Zahra Bodaghi
 */
namespace OrderItemManagement //I had to change the namespace name because the compiler was confused with the name of my class.
{
    public class OrderItem
    {
        public OrderItem() { }
        #region Properties, Variables, and Fields
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        #endregion
        /// <summary>
        /// Retrive One Order item.
        /// </summary>
        /// <param name="orderItemId"> id of the order item that retrived</param>
        /// <returns></returns>
        public OrderItem Retrive(int orderItemId) => new OrderItem();
        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns>true if it saves</returns>
        /// <summary>
        /// Retive a List Of all OrderItem. (I added this method since my customer class has one)
        /// </summary>
        /// <returns>list of orderitem</returns>
        public List<OrderItem> Retrive() => new List<OrderItem>();
        public bool Save(OrderItem orderItem) => true;
        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns>true if it is valid</returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <= 0)
            {
                isValid = false;
            }
            if (ProductId <= 0)
            {
                isValid = false;
            }
            if (PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
