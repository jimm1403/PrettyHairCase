using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class InventoryRepository
    {
        List<Order> orderList = new List<Order>();

        public void AddOrderToList(Order newOrder)
        {
            orderList.Add(newOrder);
        }

        public List<Order> GetList()
        {
            return orderList;
        }
    }
}
