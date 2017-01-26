using DomainLayer;
using PrettyHair;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrettyHairGUI.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        string selectedPhone;
        public CustomerView()
        {
            InitializeComponent();
        }

        private void newCustBtn_Click(object sender, RoutedEventArgs e)
        {
            NewCustomer newCustWindow = new NewCustomer();
            newCustWindow.ShowDialog();
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            var controller = CustomerController.GetInstance();

            customerDataGrid.ItemsSource = controller.GetCustomer();
            customerDataGrid.Items.Refresh();
        }

        private void orderWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer cust = (Customer)customerDataGrid.SelectedItem;

            NewOrder newOrder = new NewOrder(cust.PhoneNumber);
            newOrder.Show();
        }
    }
}
