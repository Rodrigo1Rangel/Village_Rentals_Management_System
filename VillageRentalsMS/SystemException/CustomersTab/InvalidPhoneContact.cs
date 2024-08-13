using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidPhoneContact : Exception
    {
        private static string _error_message = $"Error: Invalid phone number\n\nIt must meet the format 000.000.0000";

        public static string Error_message = _error_message;

        public InvalidPhoneContact()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid phone number\n\nIt must meet the format 000.000.0000");
        }
    }
}