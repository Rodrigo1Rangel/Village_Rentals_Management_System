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
        // ==========================================  METHODS =========================================

        /// <summary>
        /// Creates a new category and insert it into the database.
        /// </summary>
        /// <param name="new_description">Description to be added into the new category.</param>
        public static void AddCategory(string new_description)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(category_id) FROM vr_categories";

            OracleDataReader reader = cmd.ExecuteReader();

            /// A single value will be returned, from which we will read the highest category_id number
            /// that was added into the system. We will automatically create a new id based on that one.
            reader.Read();
            int new_category = reader.GetInt32(0) + 10;
            
            string sql = "INSERT INTO vr_categories(category_id, description) VALUES(:param1, :param2)";

            OracleCommand command = new OracleCommand(sql, conn);
            command.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = new_category;
            command.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = new_description;
            
            command.ExecuteNonQuery();
                       
            cmd.Dispose();
        }

        /// <summary>
        /// Creates a new equipment and add it into the database.
        /// </summary>
        /// <param name="category_id">Category ID to which the new equipment belongs to.</param>
        /// <param name="description">Description from the new equipment.</param>
        /// <param name="name">Name of the new equipment.</param>
        /// <param name="daily_rental_cost">Daily rental cost from the new equipment.</param>
        public static void AddEquipment(string category_id, string description, string name, double daily_rental_cost)
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(equipment_id) FROM vr_equipment";

            OracleDataReader reader = cmd.ExecuteReader();

            /// A single value will be returned, from which we will read the highest equipment_id number
            /// that was added into the system. We will automatically create a new id based on that one.
            reader.Read();
            int new_equipment_id = reader.GetInt32(0) + 1;

            // Insert new equipment into VR_EQUIPMENT
            string sql_equipment = "INSERT INTO vr_equipment(equipment_id, category_id, description, name) VALUES(:param1, :param2, :param3, :param4)";

            OracleCommand command1 = new OracleCommand(sql_equipment, conn);
            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = new_equipment_id;
            command1.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = category_id;
            command1.Parameters.Add(new OracleParameter("param3", OracleDbType.Varchar2)).Value = description;
            command1.Parameters.Add(new OracleParameter("param4", OracleDbType.Varchar2)).Value = name;

            command1.ExecuteNonQuery();

            // Insert new equipment into VR_RENTALEQUIPMENT
            string sql = "INSERT INTO vr_rentalequipment(equipment_id, daily_rental_cost) VALUES(:param1, :param2)";

            OracleCommand command2 = new OracleCommand(sql, conn);
            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = new_equipment_id;
            command2.Parameters.Add(new OracleParameter("param2", OracleDbType.Double)).Value = daily_rental_cost;

            command2.ExecuteNonQuery();
            cmd.Dispose();
        }

        /// <summary>
        /// Removes the equipment with the corresponding Equipment ID from the database.
        /// </summary>
        /// <param name="equipment_id">Equipment ID referred to the equipment that will be removed.</param>
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


            // Delete equipment from VR_RENTALEQUIPMENT

            OracleDataAdapter adapter = new OracleDataAdapter();

            string sql_remove_rentalequipment = "DELETE FROM vr_rentalequipment WHERE equipment_id = (:param1)";

            OracleCommand command3 = new OracleCommand(sql_remove_rentalequipment, conn);

            command3.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            adapter.DeleteCommand = command3;
            adapter.DeleteCommand.ExecuteNonQuery();

            // Delete equipment from VR_EQUIPMENT

            string sql_remove_equipment = "DELETE FROM vr_equipment WHERE equipment_id = (:param1)";

            OracleCommand command2 = new OracleCommand(sql_remove_equipment, conn);

            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            adapter.DeleteCommand = command2;
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show($"Equipment update:\n\n{equipment_name} was deleted!");

            adapter.Dispose();
        }

        /// <summary>
        /// Removes the category with the corresponding Category ID from the database.
        /// </summary>
        /// <param name="category_id">The category referred to the category_id will be removed.</param>
        public static void RemoveCategory(string category_id)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            // Get category name to use at MessageBox.Show()

            string sql_select_name = "SELECT description FROM vr_categories WHERE category_id = (:param1)";

            OracleCommand command1 = new OracleCommand(sql_select_name, conn);

            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = category_id;

            OracleDataReader reader = command1.ExecuteReader();
            reader.Read();
            string category_description = reader.GetString(0);


            // Delete category

            OracleDataAdapter adapter = new OracleDataAdapter();

            string sql_remove_equipment = "DELETE FROM vr_categories WHERE category_id = (:param1)";

            OracleCommand command2 = new OracleCommand(sql_remove_equipment, conn);

            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = category_id;

            adapter.DeleteCommand = command2;
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show($"Category update:\n\n{category_description} was deleted!");

            adapter.Dispose();
        }

        /// <summary>
        /// Select the equipment ID from the equipments that are available to be rented. In other words, it selects the equipment_id from the equipments that do not have an active rental associated to them.
        /// </summary>
        /// <returns>DataTable containing an equipment_id column.</returns>
        public static DataTable GetAvailableEquipToRent()
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            string sql_AvailableEquipToRent =
                    $"SELECT equip.equipment_id " +
                    $"FROM VR_RENTALEQUIPMENT re " +
                    $"JOIN VR_EQUIPMENT equip ON re.equipment_id = equip.equipment_id " +
                    $"JOIN VR_CATEGORIES cat ON equip.category_id = cat.category_id " +
                    $"WHERE equip.equipment_id NOT IN(" +
                        $"SELECT equipment_id " +
                        $"FROM VR_RENTALEQUIPMENTINFO " +
                        $"WHERE SYSDATE <= return_date)";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_AvailableEquipToRent, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
