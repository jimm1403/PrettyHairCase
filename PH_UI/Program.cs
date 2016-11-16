using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrettyHair;

namespace PH_UI
{
    class Program
    {
        string NL = Environment.NewLine;
        CustomerRepository customerRepository = new CustomerRepository();
        InventoryRepository invRepo = new InventoryRepository();
        ProductRepository prodRepo = new ProductRepository();
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        public void Run()
        {
            string choice = "";
            bool run = true;
            prodRepo.AddIgnoredAsFirstToList();
            do
            {
                Console.Clear();
                ShowMenu();
                choice = GetUserInput();

                switch (choice)
                {
                    case "r": RegisterCustomer(); break;
                    case "l": ShowCustomerList(); break;
                    case "p": ShowProductInventory(); break;
                    case "i": InputOrder(); break;
                    case "n": NewProductType(); break;
                    case "d": ChangeDescription(); break;
                    case "a": AdjustPrice(); break;
                    case "exit": run = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (run);
        }
        public void ShowMenuSelectionError()
        {
            Console.WriteLine("That was invalid input. Try again");
            Console.ReadKey();
        }
        public void ShowMenu()
        {
            Console.WriteLine("This is the prettyhair app." + NL +
                "Type 'R' to register customer." + NL +
                "Type 'L' to show the list of registered customers" + NL +
                "Type 'P' to show the list of products in the inventory" + NL +
                "Type 'I' to input a new order" + NL +
                "Type 'N' to add a new product type" + NL +
                "Type 'D' to change the description of a product" + NL +
                "Type 'A' to adjust the price of a product" + NL +
                "Type exit to close program.");
        }
        public string GetUserInput()
        {
            string userInput = Console.ReadLine().ToLower();
            return userInput;
        }
        public void RegisterCustomer()
        {
            Console.WriteLine("Customer last name:");
            string lastName = GetUserInput();
            Console.WriteLine("Customer first name:");
            string firstName = GetUserInput();
            Console.WriteLine("Customer address:");
            string address = GetUserInput();
            Console.WriteLine("Customer phone number:");
            string phoneNumber = GetUserInput();
            Customer newCustomer = new Customer(lastName, firstName, address, phoneNumber);
            customerRepository.AddCustomerToList(newCustomer);
            Console.WriteLine("You have registered: " + lastName + ", " + firstName + ", " + address + ", " + phoneNumber + "." + NL + "Click Enter");
            Console.ReadKey();
        }
        public void InputOrder()
        {
            Console.WriteLine("Order date: 'dd-mm-yyyy'");
            DateTime orderDate = DateTime.Parse(GetUserInput());
            Console.WriteLine("Order delivery date:");
            DateTime orderDeliveryDate = DateTime.Parse(GetUserInput());
            Console.WriteLine("Quantity:");
            int quantity = int.Parse(GetUserInput());
            Console.WriteLine("Product type id:");
            int productTypeId = int.Parse(GetUserInput());
            Order newOrder = new Order(orderDate, orderDeliveryDate, quantity, productTypeId);
            invRepo.AddOrderToList(newOrder);
        }
        public void NewProductType()
        {
            Console.WriteLine("Product name:");
            string productName = GetUserInput();
            Console.WriteLine("Price:");
            double price = double.Parse(GetUserInput());
            Console.WriteLine("Description:");
            string description = GetUserInput();
            Console.WriteLine("Amount:");
            int amount = int.Parse(GetUserInput());
            Product newProduct = new Product(productName, price, description, amount);
            prodRepo.AddProductToList(newProduct);
            Console.WriteLine("You have added: " + productName + ", " + price + ", " + description + ", " + amount + "." + NL + "Click Enter");
            Console.ReadKey();
        }
        public void ChangeDescription()
        {
            Product myProduct = new Product();
            ShowProductInventory();

            Console.WriteLine("Which row would you like to change the description in(Use the first number)");
            int indexToChange = int.Parse(GetUserInput());

            Console.WriteLine("Enter new description for the product.");
            string changedDescription = GetUserInput();

            prodRepo.ChangeDescription(indexToChange, changedDescription);
        }
        public void AdjustPrice()
        {
            Product myProduct = new Product();
            Console.WriteLine("Adjust the price for the product.");
            double adjustedPrice = double.Parse(GetUserInput());
            myProduct.AdjustPrice(adjustedPrice);
        }
        public void ShowCustomerList()
        {
            List<string> customerList = customerRepository.GetListAsStringList();
            foreach (string customer in customerList)
            {
                Console.WriteLine(customer);
            }
        }
        public void ShowProductInventory()
        {
            List<string> productList = prodRepo.GetListAsStringList();
            foreach (string product in productList.Skip(1))
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
            productList.Clear();
        }
        
    }
}
