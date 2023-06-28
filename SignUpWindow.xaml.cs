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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow ()
        {
            InitializeComponent();
        }

        private void SignUpPageSubmitButtonClick (object sender, RoutedEventArgs e)
        {
            if (PasswordEntry1.Password != PasswordEntry2.Password)
                MessageBox.Show("Passwords don't match.");
        }
    }
}
