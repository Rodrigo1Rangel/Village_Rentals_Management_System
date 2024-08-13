using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidNote : Exception
    {
        private static string _error_message = $"Error: Invalid note\n\nNotes can be a maximum of 500 characters long.";

        public static string Error_message = _error_message;

        public InvalidNote()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid note\n\nNotes can be a maximum of 500 characters long.");
        }
    }
}
