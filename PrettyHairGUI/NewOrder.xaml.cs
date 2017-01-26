using DomainLayer;
using PrettyHair;
using PrettyHairGUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrettyHairGUI
{
    /// <summary>
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        public string selectedPhone { get; set; }
        public NewOrder(string phone)
        {
            InitializeComponent();
            selectedPhone = phone;
            customerIDTextbox.Text = selectedPhone;
            customerIDTextbox.IsEnabled = false;
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order(orderDateTextbox.Text, deliveryDateTextbox.Text, int.Parse(quantityTextbox.Text), int.Parse(productTypeIDTextbox.Text), customerIDTextbox.Text);
            OrderRepository orderRepo = new OrderRepository();
            orderRepo.AddOrderToList(newOrder);
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
