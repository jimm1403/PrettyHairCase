using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair.Controller
{
    class ProductController
    {
        //Fields
        private static ProductController instance;

        //Properties
        public Product CurrentProduct { get; private set; }
        public List<Product> prodList { get; private set; }

        //Constructor
        private ProductController()
        {
            CurrentProduct = null;
        }

        //Methods
        public static ProductController GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductController();
            }
            return instance;
        }
        public void AddProduct()
        {
            Product product = new Product();
            CurrentProduct = product;
        }
    }
}
