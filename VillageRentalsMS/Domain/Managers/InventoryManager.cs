using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using VillageRentalsMS.SystemException;
using VillageRentalsMS.Utilities;

namespace VillageRentalsMS.Domain.Managers
{
    internal class InventoryManager
    {
        // =====================================  INSTANCE FIELDS ======================================


        // ========================================  PROPERTIES ========================================


        // =======================================  CONSTRUCTORS =======================================


        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public EquipmentToRent DeleteEquipment(int equipment_id)
        {

        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public Category GetCategoryFromDataset(int category_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM vr_categories";
            OracleDataReader reader = cmd.ExecuteReader();

            Category category = null;

            while (reader.Read())
            {
                int CATEGORY_ID = reader.GetInt32(0);
                string NOTE = reader.IsDBNull(1) ? "" : reader.GetString(1);

                if (CATEGORY_ID == category_id)
                {
                    category = new Category(CATEGORY_ID, NOTE);
                }
            }

            if (category == null)
            {
                throw new CategoryNotFound(category_id);
            }

            cmd.Dispose();

            return category;
        }

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>
        public void CreateEquipmentCategory(string description)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(category_id) FROM vr_categories";
            int new_category;
            OracleDataReader reader = cmd.ExecuteReader();
            
            // A single value will be returned, from which we will read the last category that was
            // added into the system. We will automatically create a new id based on that one.
            reader.Read();
            new_category = reader.GetInt32(0) + 10;
            
            string sql = "INSERT INTO vr_categories(category_id, description) VALUES(?, ?)";

            OracleCommand command = new OracleCommand(sql, conn);
            command.Parameters.Add(new OracleParameter("@param1", OracleDbType.Int32)).Value = new_category;
            command.Parameters.Add(new OracleParameter("@param2", OracleDbType.Varchar2)).Value = description;
            
            command.ExecuteNonQuery();
            MessageBox.Show($"A category {new_category} was created!");
            
            // *** reload the forms with the updated data from the database
            Form1_Load(null, null);
           
            cmd.Dispose();
        }
    }
}
