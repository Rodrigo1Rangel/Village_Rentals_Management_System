using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageRentalsMS.Interface;

namespace VillageRentalsMS.Domain
{
    internal class EquipmentToRent : Equipment
    {
        // =====================================  INSTANCE FIELDS ======================================
        private double _daily_rental_cost;

        // ========================================  PROPERTIES ========================================
        public double Daily_rental_cost { get { return _daily_rental_cost; } set { _daily_rental_cost = value; } }

        // =======================================  CONSTRUCTORS =======================================
        public EquipmentToRent(Equipment parentEquipment, double daily_rental_cost) : base (parentEquipment.Equipment_id, parentEquipment.Category_id, parentEquipment.Description, parentEquipment.Name)
        {
            Daily_rental_cost = daily_rental_cost;
        }

        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public override void UpdateDataset()
        {

        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public EquipmentToRent GetObjectFromDataset(int equipment_id)
        {
            return equipmentToRent;
        }
    }
}
