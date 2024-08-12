using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageRentalsMS.SystemException
{
    internal class CategoryNotFound : Exception
    {
        // =======================================  CONSTRUCTORS =======================================
        public CategoryNotFound(int category_id)
        {
            string error_message = $"The category identification {category_id} is not registered in the system."; 
        }
    }
}
