using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class Order
    {
        DateTime orderDate;
        DateTime deliveryDate;
        int productTypeId;
        int quantity;

        public Order(DateTime _orderDate, DateTime _deliveryDate, int _quantity, int _productTypeId)
        {
            orderDate = _orderDate;
            deliveryDate = _deliveryDate;
            quantity = _quantity;
            productTypeId = _productTypeId;
        }
    }
}
