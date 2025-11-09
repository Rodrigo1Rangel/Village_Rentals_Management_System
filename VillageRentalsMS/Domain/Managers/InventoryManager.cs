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
using VillageRentalsMS.SystemException.InventoryManager;

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
            try
            {
                adapter.DeleteCommand.ExecuteNonQuery();            
                
                MessageBox.Show($"Equipment update:\n\n{equipment_name} was deleted!");

            }
            catch (OracleException ex)
            {
                if (ex.Message != null && ex.Message.Contains("ORA-02292"))
                {
                    MessageBox.Show(
                        "There are related records (rentals, rental items or sales) that reference this equipment. " +
                        "Remove or archive related records before attempting to delete this equipment.\n\nDetails: " + ex.Message,
                        "Cannot delete equipment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "An error was thrown when attempting to delete an item.");
                }
            }
            finally
            {
                adapter.Dispose();
            }
        }

        /// <summary>
        /// Removes the category with the corresponding Category ID from the database. Due to the database
        /// constraints relationships, a category placeholder will have to be created and addressed to the
        /// equipment that have are associated to the category that will be deleted.
        /// </summary>
        /// <param name="category_id">The category referred to the category_id will be removed.</param>
        public static void RemoveCategory(string category_id)
        {
            /// The category id dropdown in the GUI should be populated from a selection that does not consider
            /// the 'Uncategorized' category. However, it takes every category. This should be addressed later.
            if (category_id == "0")
                return;

            OracleConnection conn = DatabaseSingleton.Connection;

            // Get category name to use at MessageBox.Show()

            string sql_select_name = "SELECT description FROM vr_categories WHERE category_id = (:param1)";

            OracleCommand command1 = new OracleCommand(sql_select_name, conn);

            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = category_id;

            OracleDataReader reader = command1.ExecuteReader();
            reader.Read();
            string category_description = reader.GetString(0);

            // Check if the placeholder category already exists
            string sql_check_placeholder = "SELECT COUNT(*) FROM vr_categories WHERE category_id = 00";
            OracleCommand command_check_00_exist = new OracleCommand(sql_check_placeholder, conn);
            int count = Convert.ToInt32(command_check_00_exist.ExecuteScalar());

            // If it does not exist, creates a category placeholder named Uncategorized
            if (count == 0)
            { 

                string sql_category_placeholder = "INSERT INTO vr_categories(category_id, description) VALUES(:param1, :param2)";

                OracleCommand command3 = new OracleCommand(sql_category_placeholder, conn);
                command3.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = 00 ;
                command3.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = "Uncategorized";

                command3.ExecuteNonQuery();
            }

            // Replace the category to be deleted for an uncategorized one.
            string sql_update_VR_EQUIPMENT =
                $"UPDATE vr_equipment " +
                $"SET CATEGORY_ID = '00', " +
                $"DESCRIPTION = 'Uncategorized' " +
                $"WHERE CATEGORY_ID = {category_id}";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_update_VR_EQUIPMENT, conn);

            OracleCommand command = new OracleCommand(sql_update_VR_EQUIPMENT, conn);

            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();


            // Delete category
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

        /// <summary>
        /// Sets an equipment for sale or updates its sale price if it was already for sale.
        /// </summary>
        /// <param name="equipment_id">Equipment id referred to the equipment that will be removed.</param>
        /// <param name="sale_price">Sale price of the equipment.</param>
        public static void SetEquipmentToSale(string equipment_id, string sale_price)
        {
            // Confirmation request
            DialogResult res = MessageBox.Show(
            "Are you sure?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (res == DialogResult.No)
                return;

            OracleConnection conn = DatabaseSingleton.Connection;

            try
            {
                // Checks if there is an active rental associated 
                string sql_check_associatedRental = 
                    $"SELECT COUNT(*) " +
                    $"FROM vr_rentalequipmentinfo " +
                    $"WHERE equipment_id = {equipment_id}" +
                    $"AND return_date > SYSDATE";

                OracleCommand command_activeRental = new OracleCommand(sql_check_associatedRental, conn);
                int count = Convert.ToInt32(command_activeRental.ExecuteScalar());

                // If it does not exist, creates a category placeholder named Uncategorized
                if (count != 0)
                    throw new ForbiddenRentalEquipmentDeletionDueToActiveRental();
            }
            catch(ForbiddenRentalEquipmentDeletionDueToActiveRental error_message)
            {
                MessageBox.Show(ForbiddenRentalEquipmentDeletionDueToActiveRental.Error_message);
                return;
            }



            // We may not delete them instead... It will imply an interpretation that equipment that
            // are for sale are still rentable. (Please, read bellow to understand it)

            //// Delete equipment from the VR_RENTALEQUIPMENT table
            ///// FATAL ERROR:
            ///// Due to a wrong entity relationship interpretation, this action will
            ///// not be performed. VR_RENTALEQUIPMENTINFO should be connected to VR_EQUIPMENT, instead
            ///// of with VR_RENTALEQUIPMENT, because items from VR_RENTALEQUIPMENT cannot be switched
            ///// between VR_RENTALEQUIPMENT and VR_EQUIPMENTFORSALE if the equipment was ever rented,
            ///// due to PK/FK constraint relationships.
            ///// Therefore, an exception will be thrown summarizing this error, which will not be addressed
            ///// before the project submission.
            //try
            //{
            //    OracleDataAdapter adapter = new OracleDataAdapter();

            //    string sql_remove_rentalequipment = "DELETE FROM vr_rentalequipment WHERE equipment_id = (:param1)";

            //    OracleCommand command_rem = new OracleCommand(sql_remove_rentalequipment, conn);

            //    command_rem.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;

            //    adapter.DeleteCommand = command_rem;
            //    adapter.DeleteCommand.ExecuteNonQuery();
            //}
            //catch (OracleException exception)
            //{
            //    if (exception.Number == 2292)
            //    {
            //        /// Throwing an "internal" exception still made the Oracle client window
            //        /// to pop up, so a MessageBox was showed instead.
            //        //throw new WrongEquipmentAndRentalRelationship();
            //        MessageBox.Show(WrongEquipmentAndRentalRelationship.Error_message);
            //    }
            //}
            ////catch (WrongEquipmentAndRentalRelationship error_message)
            ////{
            ////    MessageBox.Show(WrongEquipmentAndRentalRelationship.Error_message);
            ////}


            // Checks if there is an active rental associated 
            string sql_check_existence_EquipmentForSale =
                $"SELECT COUNT(*) " +
                $"FROM vr_equipmentforsale " +
                $"WHERE equipment_id = {equipment_id}";

            OracleCommand command_EquipAlreadyForSale = new OracleCommand(sql_check_existence_EquipmentForSale, conn);
            int count2 = Convert.ToInt32(command_EquipAlreadyForSale.ExecuteScalar());

            if (count2 == 0)
            {
                // Create an equipment for sale at the VR_EQUIPMENTFORSALE
                string sql_add_equipmentForSale = "INSERT INTO vr_equipmentforsale(equipment_id, price) VALUES(:param1, :param2)";

                OracleCommand command_addForSale = new OracleCommand(sql_add_equipmentForSale, conn);
                command_addForSale.Parameters.Add(new OracleParameter("param1", OracleDbType.Int32)).Value = equipment_id;
                command_addForSale.Parameters.Add(new OracleParameter("param2", OracleDbType.Double)).Value = sale_price;

                command_addForSale.ExecuteNonQuery();

                MessageBox.Show($"Equipment update:\n\nEquipment has been set for sale!");
            }
            else
            {
                // Updates the price if it already was for sale.
                string sql_update_VR_EQUIPMENT =
                    $"UPDATE vr_equipmentforsale " +
                    $"SET PRICE = {sale_price} " +
                    $"WHERE EQUIPMENT_ID = {equipment_id}";

                OracleDataAdapter adapter4 = new OracleDataAdapter(sql_update_VR_EQUIPMENT, conn);

                OracleCommand command = new OracleCommand(sql_update_VR_EQUIPMENT, conn);

                adapter4.UpdateCommand = command;
                adapter4.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show($"Equipment update:\n\nEquipment's price updated to ${sale_price}!");
            }
        }
    }
}
