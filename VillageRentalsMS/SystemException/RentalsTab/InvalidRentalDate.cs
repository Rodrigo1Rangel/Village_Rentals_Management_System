using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidRentalDate : Exception
    {
        private static string _error_message = $"Error: Invalid selection of dates\n\nThe returning date must not occur prior to the renting date.\nPlease select a valid date.";

        public static string Error_message = _error_message;

        public InvalidRentalDate()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid selection of dates\n\nThe returning date must not occur prior to the renting date.\nPlease select a valid date.");
        }
    }
}
