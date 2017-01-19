using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class Product
    {
        //Variables
        string productId;
        string productName;
        double price;
        string description;
        int amount;

        //Properties
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        //Constructor
        public Product()
        {
        }
        public Product(string productName, double price, string description, int amount)
        {
            this.productName = productName;
            this.price = price;
            this.description = description;
            this.amount = amount;
        }

        //Methods
        public string GetId()
        {
            return productId;
        }
        public override string ToString()
        {
            return productId + ", " + productName + ", " + price + ", " + description + ", " + amount;
        }
        public void AddToAmount(int addAmount)
        {
            amount += addAmount;
        }
        public void SubFromAmount(int subAmount)
        {
            if (amount > subAmount)
            {
                amount -= subAmount;
            }
            else
            {
                throw new Exception();
            }
        }
        public void AdjustPrice(double adjustedPrice)
        {
            price = adjustedPrice;
        }
    }
}
