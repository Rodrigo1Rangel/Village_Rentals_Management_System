using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException.InventoryManager
{
    internal class InvalidSetToSalePriceNN : Exception
    {
        private static string _error_message = $"Error: Invalid Price\n\nThe 'Price' field cannot be left empty.\nPlease enter the required information.";

        public static string Error_message = _error_message;

        public InvalidSetToSalePriceNN()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid Price\n\nThe 'Price' field cannot be left empty.\nPlease enter the required information.");
        }
    }
}
