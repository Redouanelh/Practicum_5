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
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MyProductsButton_Click(object sender, RoutedEventArgs e)
        {
            // Toon de window met producten van de desbetreffende persoon. (*HAALDITWEG* TODO, miss de token die we gaan doen gebruiken voor username om producten op te halen?)
            MyProducts myProductWindow = new MyProducts();
            myProductWindow.Show();

            // Sluit de dashboard
            this.Close();
        }

        private Product[] LoadProducts()
        {
            return webshopProxy.GetProducts();
        }
    }
}
