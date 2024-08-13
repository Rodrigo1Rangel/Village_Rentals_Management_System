using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidFirstName : Exception
    {
        private static string _error_message = $"Error: Invalid first name\n\nFirst names can be a maximum of 50 characters long.";

        public static string Error_message = _error_message;

        public InvalidFirstName()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid first name\n\nFirst names can be a maximum of 50 characters long.");
        }
    }
}