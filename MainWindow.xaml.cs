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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged (object sender, TextChangedEventArgs e)
        {
            if (LoginPagePasswordBox.Password.ToString() == LoginPageUsernameBox.Text.ToString())
            {
                MessageBox.Show("Login Successful.");
            }
        }

        private void LoginButtonClick (object sender, RoutedEventArgs e)
        {
            // if the person is a employee:
            if (true)
            {
                EmployeePanel employeePanel = new EmployeePanel();
                employeePanel.Show();
                
            }

            // else if the person is a customer :
            else
            {
                // open customer panel
            }
            Close();
        }

        private void SignUpButtonClick (object sender, RoutedEventArgs e)
        {
            SignUpWindow temp = new SignUpWindow();
            temp.Show();
        }
    }
}
