using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException.InventoryManager
{
    internal class InvalidAddEquipmentDescriptionMaxLength : Exception
    {
        private static string _error_message = $"Error: Invalid Equipment Description\n\nEquipment descriptions can be a maximum of 100 characters long.";

        public static string Error_message = _error_message;

        public InvalidAddEquipmentDescriptionMaxLength()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid Equipment Description\n\nEquipment descriptions can be a maximum of 100 characters long.");
        }
    }
}
