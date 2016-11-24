using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class OrderRepository
    {
        List<Order> orderList = new List<Order>();
        List<string> stringList = new List<string>();

        public void AddOrderToList(Order newOrder)
        {
            orderList.Add(newOrder);
        }
        public List<Order> GetList()
        {
            return orderList;
        }
        public List<string> GetListAsStringList()
        {
            foreach (Order order in orderList)
            {
                stringList.Add(order.ToString());
            }

            return stringList;
        }
    }
}
