using System;
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
        /// <param name="orderId">id of the order that to be retrive</param>
        /// <returns></returns>
        public Order Retrive(int orderId) => new Order();
        /// <summary>
        /// Save Current Order.
        /// </summary>
        /// <returns>true if saved</returns>
        public bool Save(Order order) => true;
        /// <summary>
        /// Validate the order data.
        /// </summary>
        /// <returns>true if valid</returns>
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

