using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidFirstNameNN : Exception
    {
        private static string _error_message = $"Error: Invalid first name\n\nThe 'First Name' field cannot be left empty.\nPlease enter the required information.";

        public static string Error_message = _error_message;

        public InvalidFirstNameNN()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid first name\n\nThe 'First Name' field cannot be left empty.\nPlease enter the required information.");
        }
    }
}
