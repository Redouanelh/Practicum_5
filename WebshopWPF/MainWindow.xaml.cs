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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebshopWPF.WebshopService;

namespace WebshopWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyServiceClient webshopProxy = new MyServiceClient();

        public MainWindow()
        {
            InitializeComponent();

            // Alle producten uit de winkel ophalen met een stock (voorraad) boven de 0
            Product[] products = LoadProducts();
            ProductsListView.ItemsSource = products;

            // Haal het customerobject weer op
            int customerId = Int16.Parse(Application.Current.Resources["CUSTOMERID"].ToString());
            Customer customer = webshopProxy.GetCustomerById(customerId);

            // Toont huidige saldo
            DynamicSaldoLabel.Text = customer.Balance.ToString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MyProductsButton_Click(object sender, RoutedEventArgs e)
        {
            // Toon de window met producten van de desbetreffende persoon
            MyProducts myProductWindow = new MyProducts();
            myProductWindow.Show();

            // Sluit de dashboard
            this.Close();
        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsListView.ItemsSource = webshopProxy.GetProducts();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {


            // Pas saldo label aan
            UpdateSaldoLabel();
        }

        private Product[] LoadProducts()
        {
            return webshopProxy.GetProducts();
        }

        private void UpdateSaldoLabel()
        {
            int customerId = Int16.Parse(Application.Current.Resources["CUSTOMERID"].ToString());
            Customer customer = webshopProxy.GetCustomerById(customerId);
            DynamicSaldoLabel.Text = customer.Balance.ToString();
        }
    }
}
