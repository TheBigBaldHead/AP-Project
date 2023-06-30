using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WpfApp3.Properties
{
    internal class WpfApp3
    {
        static void Main()
        {
            

        }
        public static bool ValidateLuhnAlgorithm(string number)
        {
            // Remove any non-digit characters from the input string
            string cleanedNumber = new string(number.Where(char.IsDigit).ToArray());

            int sum = 0;
            bool alternate = false;

            // Iterate over the digits from right to left
            for (int i = cleanedNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(cleanedNumber[i].ToString());

                if (alternate)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit = (digit % 10) + 1;
                    }
                }

                sum += digit;
                alternate = !alternate;
            }

            // The number is valid if the sum is divisible by 10
            return sum % 10 == 0;
        }
    }
    class Customer
    {

    }
}
