using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        static int errors = 0;
        public CustomerSignUpWindow ()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void NameBox_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex nameValidationPattern = new Regex(@"^[a-zA-Z]{3,32}$");

            if (!nameValidationPattern.IsMatch(FirstNameBox.Text))
            {
                FirstNameBox.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (nameValidationPattern.IsMatch(FirstNameBox.Text))
            {
                FirstNameBox.Style = (Style)FindResource("SignUpPageTextBox");
                errors--;
            }
        }

        private void NameBox2_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex nameValidationPattern = new Regex(@"^[a-zA-Z]{3,32}$");

            if (!nameValidationPattern.IsMatch(LastNameBox.Text))
            {
                LastNameBox.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (nameValidationPattern.IsMatch(LastNameBox.Text))
            {
                LastNameBox.Style = (Style)FindResource("SignUpPageTextBox");
                errors--;
            }
        }

        private void Ssn_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex SsnValidation = new Regex(@"^00\d{8}$");

            if (!SsnValidation.IsMatch(SsnField.Text))
            {
                SsnField.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (SsnValidation.IsMatch(SsnField.Text))
            {
                SsnField.Style = (Style)FindResource("SignUpPageTextBox");
                errors--;
            }
        }

        private void EmailField_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex emailValidation = new Regex(@"^[a-zA-Z]{3,32}@[a-zA-Z]{3,32}.[a-zA-Z]{2,3}$");

            if (!emailValidation.IsMatch(EmailField.Text))
            {
                EmailField.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (emailValidation.IsMatch(EmailField.Text))
            {
                EmailField.Style = (Style)FindResource("SignUpPageTextBox");
                errors--;
            }
        }

        private void PhoneNumberField_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex phonenumberPattern = new Regex(@"^09\d{9}$");

            if (!phonenumberPattern.IsMatch(PhoneNumberField.Text))
            {
                PhoneNumberField.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (phonenumberPattern.IsMatch(PhoneNumberField.Text))
            {
                PhoneNumberField.Style = (Style)FindResource("SignUpPageTextBox");
                errors--;
            }
        }

        private void CustomerSignUpPageSubmitButtonClick (object sender, RoutedEventArgs e)
        {
            
            if (errors == 0)
            {
                // generate a random and unique username and password(both must be unique)
                // E-mail the username and password to the customer
                // add the customer information

                Close();
            }
            else
                MessageBox.Show("Problems remain.");
        }
    }
}
