using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalsMS.SystemException
{
    internal class InvalidEmailRegex : Exception
    {
        private static string _error_message = $"Error: Invalid email\n\nEmails must respect one of the two patterns:\n\nexample@abc.abc.abc\nexample@abc.abc";

        public static string Error_message = _error_message;

        public InvalidEmailRegex()
        {
            // The message below is not being captured as the error message.
            Console.WriteLine($"Error: Invalid email\n\nEmails must respect one of the two patterns:\n\nexample@abc.abc.abc\nexample@abc.abc");
        }
    }
}
