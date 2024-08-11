using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageRentalsMS.Interface;

namespace VillageRentalsMS.Domain
{
    internal class Equipment : IDatasetTable
    {
        // =====================================  INSTANCE FIELDS ======================================
        private int _equipment_id;
        private int _category_id;
        private string _description;
        private string _name;

        // ========================================  PROPERTIES ========================================
        public int Equipment_id { get { return _equipment_id; } set { _equipment_id = value; } }
        public int Category_id { get { return _category_id; } set { _category_id = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        // =======================================  CONSTRUCTORS =======================================
        public Equipment(int equipment_id, int category_id, string description, string name)
        {
            Equipment_id = equipment_id;
            Category_id = category_id;
            Description = description;
            Name = name;
        }

        /// When a description is not added, default to an empty string.
        public Equipment(int equipment_id, int category_id, string name)
        {
            Equipment_id = equipment_id;
            Category_id = category_id;
            Description = "";
            Name = name;
        }
        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public virtual void UpdateDataset()
        {

        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public Equipment GetObjectFromDataset(int equipment_id)
        {
            return equipment;
        }
    }
}
