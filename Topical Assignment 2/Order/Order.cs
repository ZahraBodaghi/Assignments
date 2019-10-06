using System;
using System.Collections.Generic;
/*
 * Zahra Bodaghi
 */

namespace Order
{
    public class Order
    {
        public Order() { }
        #region Properties, Variables and Fields
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        #endregion
        /// <summary>
        /// Retrive one order
        /// </summary>
        /// <param name="orderId">id of the order that be retrived</param>
        /// <returns></returns>
        public Order Retrive(int orderId) => new Order();
        /// <summary>
        /// Retive a List Of all Orders. (I added this method since my customer class has one)
        /// </summary>
        /// <returns>list of orders</returns>
        public List<Order> Retrive() => new List<Order>();
        /// <summary>
        /// Saves the current orders
        /// </summary>
        /// <param name="order"></param>
        /// <returns>true if it saves</returns>
        public bool Save(Order order) => true;
        /// <summary>
        /// Validate the order data.
        /// </summary>
        /// <returns>true if the order is valid or false if the order is not valid</returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}

