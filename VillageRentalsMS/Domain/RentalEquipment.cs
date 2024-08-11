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
    internal class RentalEquipment : IDatasetTable
    {
        // =====================================  INSTANCE FIELDS ======================================
        private int _equipment_id;
        private int _rental_id;
        private int _item_quantity;
        private string _rent_date;
        private string _return_date;
        private double _rental_cost;

        // ========================================  PROPERTIES ========================================
        public int Equipment_id { get { return _equipment_id; } set { _equipment_id = value; } }
        public int Rental_id { get { return _rental_id; } set { _rental_id = value; } }
        public int Item_quantity { get { return _item_quantity; } set { _item_quantity = value; } }
        public string Rent_date { get { return _rent_date; } set { _rent_date = value; } }
        public string Return_date { get { return _return_date; } set { _return_date = value; } }
        public double Rental_cost { get { return _rental_cost; } set { _rental_cost = value; } }


        // =======================================  CONSTRUCTORS =======================================
        public RentalEquipment (Equipment equipment, int rental_id, int item_quantity, string rent_date, string return_date, double rental_cost)
        {
            Equipment_id = equipment.Equipment_id;
            Rental_id = rental_id;
            Item_quantity = item_quantity;
            Rent_date = rent_date;
            Return_date = return_date;
            Rental_cost = rental_cost;
        }

        /// When item_quantity is not specified, default to 1.
        public RentalEquipment(Equipment equipment, int rental_id, string rent_date, string return_date, double rental_cost)
        {
            Equipment_id = equipment.Equipment_id;
            Rental_id = rental_id;
            Item_quantity = 1;
            Rent_date = rent_date;
            Return_date = return_date;
            Rental_cost = rental_cost;
        }

        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public void UpdateDataset()
        {
            // VR_RENTALEQUIPMENT
            // VR_RENTALEQUIPMENTINFO
        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public RentalEquipment GetObjectFromDataset(int rental_id, int customer_id, int equipment_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            return rentalEquipment;
        }
    }
}
