using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WebshopWPF.WebshopService;

namespace WebshopWPF
{
    /// <summary>
    /// Interaction logic for MyProducts.xaml
    /// </summary>
    public partial class MyProducts : Window
    {

        private MyServiceClient webshopProxy = new MyServiceClient();
        public MyProducts()
        {
            InitializeComponent();

            // Haal het customerobject weer op
            int customerId = Int16.Parse(Application.Current.Resources["CUSTOMERID"].ToString());
            Customer customer = webshopProxy.GetCustomerById(customerId);

            // Toont huidige saldo
            DynamicSaldoLabel.Text = customer.Balance.ToString();

            // Alle producten van de desbetreffende customer ophalen
            Product[] products = webshopProxy.GetProductsFromCustomer(customer.CustomerId);
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            // Toont weer de dashboard
            MainWindow dashboardWindow = new MainWindow();
            dashboardWindow.Show();

            // Sluit de dashboard
            this.Close();
        }
    }
}
