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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private MyServiceClient webshopProxy = new MyServiceClient();

        // Voor het stylen van onze applicatie hebben we een youtube video gebruikt die ons uitlegt hoe .xaml files werken:
        // https://www.youtube.com/watch?v=MWVfsLOhUXM
        public Login()
        {            
                InitializeComponent();           
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Check of de username en password combinatie correct in de database staan (zo ja; true, zo nee; false)
            Customer customer = webshopProxy.LoginCheck(UsernameInput.Text, PasswordInput.Password);

            if (customer != null)
            {
                // Persoon heeft juiste inloggegevens gegeven
                InvalidCombinationLabel.Visibility = Visibility.Hidden;

                // Onthoud het id van de ingelogde customer binnen de current applicatie (https://stackoverflow.com/questions/22270850/what-is-the-difference-between-application-current-resources-and-resources)
                Application.Current.Resources["CUSTOMERID"] = customer.CustomerId;

                // Opent de MainWindow (de client dashboard)
                MainWindow dashboard = new MainWindow();
                dashboard.Show();

                // Sluit de inlogpagina
                this.Close();

            } else
            {
                // Persoon heeft onjuiste inloggegevens gegeven
                InvalidCombinationLabel.Visibility = Visibility.Visible;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Opent de Register pagina
            Register registerWindow = new Register();
            registerWindow.Show();

            // Sluit de inlogpagina
            this.Close();
        }
    }
}
