using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class Order
    {
        string orderDate;
        string deliveryDate;
        int productTypeId;
        int quantity;
        string customerId;

        public int ProductTypeId
        {
            get { return productTypeId; }
        }
        public int Quantity
        {
            get { return quantity; }
        }
        public string OrderDate
        {
            get { return orderDate; }
        }
        public string DeliveryDate
        {
            get { return deliveryDate; }
        }
        public string CustomerId
        {
            get { return customerId; }
        }

        public Order(string orderDate, string deliveryDate, int quantity, int productTypeId, string customerId)
        {
            this.orderDate = orderDate;
            this.deliveryDate = deliveryDate;
            this.quantity = quantity;
            this.productTypeId = productTypeId;
            this.customerId = customerId;
        }
        
        //public override string ToString()
        //{
        //    return "ID: " + productTypeId + ", Quantity: " + quantity + 
        //        ", Orderdate: " + orderDate.Year + "-"+ orderDate.Month + "-"+ orderDate.Day + 
        //        ", Deliverydate: " + deliveryDate.Year + "-" + deliveryDate.Month + "-" + deliveryDate.Day;
        //}
    }
}
