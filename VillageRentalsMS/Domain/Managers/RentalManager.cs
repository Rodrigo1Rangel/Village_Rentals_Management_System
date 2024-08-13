using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using VillageRentalsMS.Utilities;

namespace VillageRentalsMS.Domain.Managers
{
    internal class RentalManager
    {
        // ==========================================  METHODS =========================================

        /// <summary>
        /// Blob.
        /// </summary>
        /// <param name="value">Blob.</param>
        /// <returns>Blob.</returns>

        public static DataTable PopulateAvailableEquipmentGridView()
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            string sql_available_equipment =
                    $"SELECT equip.equipment_id \"Equipment ID\", " +
                    $"cat.description \"Category\", " +
                    $"equip.name \"Name\", " +
                    $"equip.description \"Description\", " +
                    $"re.daily_rental_cost \"Rental Cost\" " +
                    $"FROM VR_RENTALEQUIPMENT re " +
                    $"JOIN VR_EQUIPMENT equip ON re.equipment_id = equip.equipment_id " +
                    $"JOIN VR_CATEGORIES cat ON equip.category_id = cat.category_id " +
                    $"WHERE re.equipment_id NOT IN(" +
                        $"SELECT equipment_id " +
                        $"FROM VR_RENTALEQUIPMENTINFO " +
                        $"WHERE SYSDATE <= return_date)";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_available_equipment, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable PopulateCurrentRentalsGridView()
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            string sql_current_rentals =
                    $"SELECT rentequip.rental_id \"Rental ID\", " +
                    $"cust.first_name || ' ' || cust.last_name \"Customer Name\", " +
                    $"rentequip.equipment_id \"Equipment ID\", " +
                    $"rentequip.item_quantity \"Quantity\", " +
                    $"rentequip.rent_date \"Rental Date\", " +
                    $"rentequip.return_date \"Return Date\", " +
                    $"rentequip.rental_cost \"Rental Cost\" " +
                    $"FROM VR_RENTALEQUIPMENTINFO rentequip " +
                    $"JOIN VR_RENTALINFO rentinfo ON rentinfo.equipment_id = rentequip.equipment_id " +
                    $"AND rentinfo.rental_id = rentequip.rental_id " +
                    $"JOIN VR_CUSTOMERINFO cust ON rentinfo.customer_id = cust.customer_id " +
                    $"JOIN VR_EQUIPMENT equipment ON rentequip.equipment_id = equipment.equipment_id " +
                    $"WHERE SYSDATE <= rentequip.return_date";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_current_rentals, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable EquipmentGridView()
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            string sql_all_equipment =
                    $"SELECT equip.equipment_id \"Equipment ID\", " +
                    $"equip.name \"Name\", " +
                    $"equip.description \"Description\", " +
                    $"cat.description \"Category\", " +
                    $"rentequip.daily_rental_cost \"Daily Rental Cost\" " +
                    $"FROM VR_EQUIPMENT equip " +
                    $"JOIN VR_CATEGORIES cat ON cat.category_id = equip.category_id " +
                    $"JOIN VR_RENTALEQUIPMENT rentequip ON rentequip.equipment_id = equip.equipment_id";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_all_equipment, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public static void CreateReservation(string customer_id_to_rent, string equipment_id_to_rent, string DateRented, string DateToReturn, int durationInDays)
        {
            OracleConnection conn = DatabaseSingleton.Connection;

            // Create a new rental_id
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(rental_id) FROM vr_rentalinfo";

            OracleDataReader reader = cmd.ExecuteReader();

            /// A single value will be returned, from which we will read the highest rental_id number
            /// that was added into the system. We will automatically create a new id based on that one.
            reader.Read();
            int new_rental_id = reader.GetInt32(0) + 1;


            // Calculate the total rental cost
            cmd.CommandText = $"SELECT daily_rental_cost FROM vr_rentalequipment WHERE equipment_id = {equipment_id_to_rent}";

            OracleDataReader reader2 = cmd.ExecuteReader();

            reader2.Read();
            double daily_rental_cost = reader.GetDouble(0);

            double total_rental_cost = daily_rental_cost * durationInDays;


            // Inserting the rental in the database

            /// VR_RENTALEQUIPMENTINFO (1)
            string sql1 = "INSERT INTO vr_rentalequipmentinfo(equipment_id, rental_id, item_quantity, rent_date, return_date, rental_cost) VALUES(:param1, :param2, :param3, :param4, :param5, :param6)";

            OracleCommand command1 = new OracleCommand(sql1, conn);
            command1.Parameters.Add(new OracleParameter("param1", OracleDbType.Varchar2)).Value = equipment_id_to_rent;
            command1.Parameters.Add(new OracleParameter("param2", OracleDbType.Int32)).Value = new_rental_id;
            command1.Parameters.Add(new OracleParameter("param3", OracleDbType.Int32)).Value = 1;
            command1.Parameters.Add(new OracleParameter("param4", OracleDbType.Date)).Value = DateTime.Parse(DateRented);
            command1.Parameters.Add(new OracleParameter("param5", OracleDbType.Date)).Value = DateTime.Parse(DateToReturn);
            command1.Parameters.Add(new OracleParameter("param6", OracleDbType.Decimal)).Value = total_rental_cost;
            
            command1.ExecuteNonQuery();

            /// VR_RENTALINFO (2)
            string sql2 = "INSERT INTO vr_rentalinfo(rental_id, equipment_id, customer_id) VALUES(:param1, :param2, :param3)";

            OracleCommand command2 = new OracleCommand(sql2, conn);
            command2.Parameters.Add(new OracleParameter("param1", OracleDbType.Varchar2)).Value = new_rental_id;
            command2.Parameters.Add(new OracleParameter("param2", OracleDbType.Varchar2)).Value = equipment_id_to_rent;
            command2.Parameters.Add(new OracleParameter("param3", OracleDbType.Varchar2)).Value = customer_id_to_rent;

            command2.ExecuteNonQuery();
        }

        public static DataTable SalesGridView()
        {
            OracleConnection conn = DatabaseSingleton.Connection;
            string sql_every_rental =
                    $"SELECT rentequip.rental_id \"Rental ID\", " +
                    $"cust.first_name || ' ' || cust.last_name \"Customer Name\", " +
                    $"rentequip.equipment_id \"Equipment ID\", " +
                    $"rentequip.item_quantity \"Quantity\", " +
                    $"rentequip.rent_date \"Rental Date\", " +
                    $"rentequip.return_date \"Return Date\", " +
                    $"rentequip.rental_cost \"Rental Cost\" " +
                    $"FROM VR_RENTALEQUIPMENTINFO rentequip " +
                    $"JOIN VR_RENTALINFO rentinfo ON rentinfo.equipment_id = rentequip.equipment_id " +
                    $"AND rentinfo.rental_id = rentequip.rental_id " +
                    $"JOIN VR_CUSTOMERINFO cust ON rentinfo.customer_id = cust.customer_id " +
                    $"JOIN VR_EQUIPMENT equipment ON rentequip.equipment_id = equipment.equipment_id";

            OracleDataAdapter adapter = new OracleDataAdapter(sql_every_rental, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
