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
using PrettyHair;

namespace PrettyHairGUI
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            var controller = CustomerController.GetInstance();
            controller.AddCustomer();
            controller.CurrentCustomer.FirstName = firstNameTextbox.Text;
            controller.CurrentCustomer.LastName = lastNameTextbox.Text;
            controller.CurrentCustomer.Address = addressTextbox.Text;
            controller.CurrentCustomer.PhoneNumber = phoneTextbox.Text;
            controller.saveToDB();
            this.Close();
            
        }
    }
}
