using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException.InventoryManager
{
    internal class ForbiddenRentalEquipmentDeletionDueToActiveRental : Exception
    {
        private static string _error_message = $"Error: Forbidden action\n\nThere is an ongoing rental associated to this equipment.\nTry again after the rental is finished or cancelled.";

        public static string Error_message = _error_message;

        public ForbiddenRentalEquipmentDeletionDueToActiveRental()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Forbidden action\n\nThere is an ongoing rental associated to this equipment.\nTry again after the rental is finished or cancelled.");
        }
    }
}
