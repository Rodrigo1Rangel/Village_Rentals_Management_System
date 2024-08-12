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
    internal class Customer// : IDatasetTable
    {
        // =====================================  INSTANCE FIELDS ======================================
        private int _customer_id;
        private string _last_name;
        private string _first_name;
        private string _contact_phone;
        private string _email;
        private string _note;

        // ========================================  PROPERTIES ========================================
        public int Customer_id { get { return _customer_id; } set { _customer_id = value; } }
        public string Last_name { get { return _last_name; } set { _last_name = value; } }
        public string First_name { get { return _first_name; } set { _first_name = value; } }
        public string Contact_phone { get { return _contact_phone; } set { _contact_phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Note { get { return _note; } set { _note = value; } }

        // =======================================  CONSTRUCTORS =======================================
        public Customer(int customer_id, string last_name, string first_name, string contact_phone, string email, string note)
        {
            Customer_id = customer_id;
            Last_name = last_name;
            First_name = first_name;
            Contact_phone = contact_phone;
            Email = email;
            Note = note;
        }

        /// When a description is not added, default to an empty string.
        public Customer(int customer_id, string last_name, string first_name, string contact_phone, string email)
        {
            Customer_id = customer_id;
            Last_name = last_name;
            First_name = first_name;
            Contact_phone = contact_phone;
            Email = email;
            Note = "";
        }

        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public void UpdateDataset()
        {

        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        //public Customer GetObjectFromDataset(int customer_id)
        //{
        //    OracleConnection conn = DatabaseSingleton.Connection;

        //    return customer;
        //}

    }
}
