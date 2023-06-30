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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        static int errors = 0;
        public SignUpWindow ()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void SignUpPagePasswordCheckBox (object sender, RoutedEventArgs e)
        {
            if (SignUpPageCheckBox.IsChecked == true)
            {
                PasswordEntry1.Visibility = Visibility.Collapsed;
                PasswordEntry2.Visibility = Visibility.Collapsed;

                PasswordEntry1Txt.Text = PasswordEntry1.Password;
                PasswordEntry2Txt.Text = PasswordEntry2.Password;
                
                PasswordEntry1Txt.Visibility = Visibility.Visible;
                PasswordEntry2Txt.Visibility = Visibility.Visible;
            }
            else if (SignUpPageCheckBox.IsChecked == false)
            {
                PasswordEntry1.Visibility = Visibility.Visible;
                PasswordEntry2.Visibility = Visibility.Visible;

                PasswordEntry1Txt.Text = string.Empty;
                PasswordEntry2Txt.Text = string.Empty;

                PasswordEntry1Txt.Visibility = Visibility.Collapsed;
                PasswordEntry2Txt.Visibility = Visibility.Collapsed;
            }
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

        private void Id_TextChanged (object sender, TextChangedEventArgs e)
        {
            Regex SsnValidation = new Regex(@"^00\d{8}$");

            if (!SsnValidation.IsMatch(IdField.Text))
            {
                IdField.Style = (Style)FindResource("TextBoxError");
                errors++;
            }
            else if (SsnValidation.IsMatch(IdField.Text))
            {
                IdField.Style = (Style)FindResource("SignUpPageTextBox");
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

        private void SignUpPageSubmitButtonClick (object sender, RoutedEventArgs e)
        {
            Regex passwordVerification = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{3,32}$");

            if (passwordVerification.IsMatch(PasswordEntry1.Password) && PasswordEntry1.Password == PasswordEntry2.Password)
            {
                if (errors != 0)
                {
                    MessageBox.Show("Problems remain.");
                    return;
                }

                // continue and save the data

                Close();
            }
            else
            {
                PasswordEntry1.Style = (Style)FindResource("PasswordBoxError");
                PasswordEntry2.Style = (Style)FindResource("PasswordBoxError");

                MessageBox.Show("Password is not up to the standards.");
            }
                
        }

        private void UsernameField_TextChanged (object sender, TextChangedEventArgs e)
        {

        }
    }
}
