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
        //public EquipmentToRent DeleteEquipment(int equipment_id)
        //{
        //    return;
        //}

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
        public static void AddCategory(string new_description)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(category_id) FROM vr_categories";

            OracleDataReader reader = cmd.ExecuteReader();

            // A single value will be returned, from which we will read the highest category_id number
            // that was added into the system. We will automatically create a new id based on that one.
            reader.Read();
            int new_category = reader.GetInt32(0) + 10;
            
            string sql = "INSERT INTO vr_categories(category_id, description) VALUES(:param1, :param2)";

            OracleCommand command = new OracleCommand(sql, conn);
            command.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = new_category;
            command.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = new_description;
            
            command.ExecuteNonQuery();
                       
            cmd.Dispose();
        }

        public static void AddEquipment(string category_id, string description, string name)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(equipment_id) FROM vr_equipment";

            OracleDataReader reader = cmd.ExecuteReader();

            // A single value will be returned, from which we will read the highest equipment_id number
            // that was added into the system. We will automatically create a new id based on that one.
            reader.Read();
            int new_equipment_id = reader.GetInt32(0) + 1;

            string sql = "INSERT INTO vr_equipment(equipment_id, category_id, description, name) VALUES(:param1, :param2, :param3, :param4)";

            OracleCommand command = new OracleCommand(sql, conn);
            command.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = new_equipment_id;
            command.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = category_id;
            command.Parameters.Add(new OracleParameter("param3", OracleDbType.Varchar2)).Value = description;
            command.Parameters.Add(new OracleParameter("param4", OracleDbType.Varchar2)).Value = name;

            command.ExecuteNonQuery();   
        }

        public static void RemoveEquipment(string equipment_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            // Get equipment name to use at MessageBox.Show()

            string sql_select_name = "SELECT name FROM vr_equipment WHERE equipment_id = (:param1)";

            OracleCommand command1 = new OracleCommand(sql_select_name, conn);

            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            OracleDataReader reader = command1.ExecuteReader();
            reader.Read();
            string equipment_name = reader.GetString(0);


            // Delete equipment

            OracleDataAdapter adapter = new OracleDataAdapter();

            string sql_remove_equipment = "DELETE FROM vr_equipment WHERE equipment_id = (:param1)";

            OracleCommand command2 = new OracleCommand(sql_remove_equipment, conn);

            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            adapter.DeleteCommand = command2;
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show($"Equipment update:\n\n{equipment_name} was deleted!");

            adapter.Dispose();
        }

        public static void RemoveCategory(string equipment_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            // Get category name to use at MessageBox.Show()

            string sql_select_name = "SELECT description FROM vr_categories WHERE category_id = (:param1)";

            OracleCommand command1 = new OracleCommand(sql_select_name, conn);

            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            OracleDataReader reader = command1.ExecuteReader();
            reader.Read();
            string category_description = reader.GetString(0);


            // Delete category

            OracleDataAdapter adapter = new OracleDataAdapter();

            string sql_remove_equipment = "DELETE FROM vr_categories WHERE category_id = (:param1)";

            OracleCommand command2 = new OracleCommand(sql_remove_equipment, conn);

            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            adapter.DeleteCommand = command2;
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show($"Category update:\n\n{category_description} was deleted!");

            adapter.Dispose();
        }
    }
}
