using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageRentalsMS.Interface;
using Oracle.ManagedDataAccess.Client;
using VillageRentalsMS.Utilities;

namespace VillageRentalsMS.Domain
{
    internal class EquipmentForSale : Equipment
    {
        // =====================================  INSTANCE FIELDS ======================================
        private double _price;

        // ========================================  PROPERTIES ========================================
        public double Price { get { return _price; } set { _price = value; } }

        // =======================================  CONSTRUCTORS =======================================
        public EquipmentForSale (Equipment parentEquipment, double price) : base(parentEquipment.Equipment_id, parentEquipment.Category_id, parentEquipment.Description, parentEquipment.Name)
        {
            Price = price;
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
        public EquipmentForSale GetObjectFromDataset(int equipment_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            return equipmentForSale;
        }
    }
}
