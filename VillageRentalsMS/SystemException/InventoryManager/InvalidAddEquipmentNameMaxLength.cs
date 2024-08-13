using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException.InventoryManager
{
    internal class InvalidAddEquipmentNameMaxLength : Exception
    {
        private static string _error_message = $"Error: Invalid Equipment Name\n\nEquipment names can be a maximum of 100 characters long.";

        public static string Error_message = _error_message;

        public InvalidAddEquipmentNameMaxLength()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid Equipment Name\n\nEquipment names can be a maximum of 100 characters long.");
        }
    }
}
