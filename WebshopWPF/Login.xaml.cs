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

        // For the login interface styling, we used a youtube video which explained us how .xaml files worked:
        // https://www.youtube.com/watch?v=MWVfsLOhUXM
        public Login()
        {            
                InitializeComponent();           
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean found = webshopProxy.LoginCheck(UsernameInput.Text, PasswordInput.Password);

            if (found)
            {
                // Persoon heeft juiste inloggegevens gegeven

            } else
            {
                // Persoon heeft verkeerde inloggegevens gegeven

            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
