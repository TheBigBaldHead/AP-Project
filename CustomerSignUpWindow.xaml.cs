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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for CustomerSignUpWindow.xaml
    /// </summary>
    public partial class CustomerSignUpWindow : Window
    {
        public CustomerSignUpWindow ()
        {
            InitializeComponent();
        }

        private void CustomerSignUpPageSubmitButtonClick (object sender, RoutedEventArgs e)
        {
            // generate a random and unique username and password(both must be unique)
            // E-mail the username and password to the customer
            // add the customer information
            Close();
        }
    }
}
