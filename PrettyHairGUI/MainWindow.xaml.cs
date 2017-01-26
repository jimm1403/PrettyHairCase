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

namespace PrettyHairGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            OrderRepository orderRepo = new OrderRepository();
            Order order1 = new Order("69-69-6969", "08-12-2017", 25, 102, "77556688");
            Order order2 = new Order("80085", "12-12-2017", 22, 101, "22885544");
            Order order3 = new Order("09-11-2001", "09-11-2001", 3, 137, "11223344");
            orderRepo.AddOrderToList(order1);
            orderRepo.AddOrderToList(order2);
            orderRepo.AddOrderToList(order3);
        }
    }
}
