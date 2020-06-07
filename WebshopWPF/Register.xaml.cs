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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private MyServiceClient webshopProxy = new MyServiceClient();
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Generaten van een password, er staan checks binnen deze methode wat betreft unieke username
            String password = webshopProxy.RegisterCheck(UsernameInput.Text);

            if (password == null)
            {
                // Persoon heeft een bestaande username ingevoerd
                UsernameInUse.Visibility = Visibility.Visible;
            } else
            {
                // Persoon heeft een nieuw username ingevoerd
                UsernameInUse.Visibility = Visibility.Hidden;

                // Hide de registreer button om te voorkomen dat iemand weer erop klikt
                RegisterButton.Visibility = Visibility.Hidden;

                // Toon de gegenereerde wachtwoord in een label
                GeneratedPassword.Text = password;
            }

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // LoginWindow openen
            Login loginWindow = new Login();
            loginWindow.Show();

            // Registreerwindow sluiten
            this.Close();
        }

    }
}
