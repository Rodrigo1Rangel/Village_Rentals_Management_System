using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException.InventoryManager
{
    internal class WrongEquipmentAndRentalRelationship : Exception
    {
        private static string _error_message = $"Error: Forbidden action\n\nThe current software's version is not capable of setting for sale an equipment that was once rented.\nWe are sorry for the inconvenience.";

        public static string Error_message = _error_message;

        public WrongEquipmentAndRentalRelationship()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Forbidden action\n\nThe current software's version is not capable of setting for sale an equipment that was once rented.\nWe are sorry for the inconvenience.");
        }
    }
}
