using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidEmailLength : Exception
    {
        private static string _error_message = $"Error: Invalid email\n\nEmails can be a maximum of 100 characters long.";

        public static string Error_message = _error_message;

        public InvalidEmailLength()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Invalid email\n\nEmails can be a maximum of 100 characters long.");
        }
    }
}
