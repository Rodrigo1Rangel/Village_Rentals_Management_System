using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageRentalsMS.Domain.Managers;
using VillageRentalsMS.Domain;
using System.Data.OracleClient;
using VillageRentalsMS.SystemException;
using VillageRentalsMS.Utilities;
using VillageRentalsMS.SystemException.InventoryManager;


namespace VillageRentalsMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDatabase();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vR_Dataset.VR_RENTALINFO' table. You can move, or remove it, as needed.
            this.vR_RENTALINFOTableAdapter.Fill(this.vR_Dataset.VR_RENTALINFO);
            // TODO: This line of code loads data into the 'vR_Dataset.VR_RENTALEQUIPMENTINFO' table. You can move, or remove it, as needed.
            this.vR_RENTALEQUIPMENTINFOTableAdapter.Fill(this.vR_Dataset.VR_RENTALEQUIPMENTINFO);
            // TODO: This line of code loads data into the 'vR_Dataset.VR_CUSTOMERINFO' table. You can move, or remove it, as needed.
            this.vR_CUSTOMERINFOTableAdapter.Fill(this.vR_Dataset.VR_CUSTOMERINFO);
            // TODO: This line of code loads data into the 'vR_Dataset.VR_CATEGORIES' table. You can move, or remove it, as needed.
            this.vR_CATEGORIESTableAdapter.Fill(this.vR_Dataset.VR_CATEGORIES);
            // TODO: This line of code loads data into the 'vR_Dataset.VR_RENTALEQUIPMENT' table. You can move, or remove it, as needed.
            this.vR_RENTALEQUIPMENTTableAdapter.Fill(this.vR_Dataset.VR_RENTALEQUIPMENT);
            // TODO: This line of code loads data into the 'vR_Dataset.VR_EQUIPMENT' table. You can move, or remove it, as needed.
            this.vR_EQUIPMENTTableAdapter.Fill(this.vR_Dataset.VR_EQUIPMENT);
        }

        // ======================================== ADD NEW EQUIPMENT ========================================
        private void Inventory_AddEquipment(object sender, EventArgs e) {}
        private void txtbxEquipDesc_TextChanged(object sender, EventArgs e) {}
        private void tabPage1_Click(object sender, EventArgs e) {}
        private void btn_AddEquipment(object sender, EventArgs e)
        {
            try
            {
                string category_description = this.addEquipment_category_id.Text;
                string category_id = this.addEquipment_category_id.SelectedValue.ToString();

                string equipment_description = txt_AddEquipDescription.Text.Replace("'", "''");
                InventoryTabValidator.CheckAddEquipmentDescriptionNN(equipment_description);
                InventoryTabValidator.CheckAddEquipmentDescriptionMaxLength(equipment_description);

                string equipment_name = txtAddEquip_Name.Text.Replace("'", "''");
                InventoryTabValidator.CheckAddEquipmentNameNN(equipment_name);
                InventoryTabValidator.CheckAddEquipmentNameMaxLength(equipment_name);

                string string_daily_rental_cost = newEquip_daily_rental_cost.Text.Replace("'", "''");
                InventoryTabValidator.CheckAddEquipmentDailyRentalCostNN(string_daily_rental_cost);
                InventoryTabValidator.CheckAddEquipmentDailyRentalCostRegex(string_daily_rental_cost);

                double daily_rental_cost;
                double.TryParse(string_daily_rental_cost, out daily_rental_cost);

                InventoryManager.AddEquipment(category_id, equipment_description, equipment_name, daily_rental_cost);

                Form1_Load(null, null);

                MessageBox.Show($"Equipment update:\n\n{equipment_name} equipment was added!");
                UpdateDatabase();
            }
            catch (InvalidAddEquipmentDescriptionNN error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentDescriptionNN.Error_message}");
            }
            catch (InvalidAddEquipmentDescriptionMaxLength error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentDescriptionMaxLength.Error_message}");
            }
            catch (InvalidAddEquipmentNameNN error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentNameNN.Error_message}");
            }
            catch (InvalidAddEquipmentNameMaxLength error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentNameMaxLength.Error_message}");
            }
            catch (InvalidAddEquipmentDailyRentalCostNN error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentDailyRentalCostNN.Error_message}");
            }
            catch (InvalidAddEquipmentDailyRentalCostRegex error_message)
            {
                MessageBox.Show($"{InvalidAddEquipmentDailyRentalCostRegex.Error_message}");
            }
        }

        // =========================================== SET EQUIPMENT TO SALE ==================================
        private void label9_Click(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e) { }

        private void btn_SetForSale_Click(object sender, EventArgs e)
        {
            try
            {
           string sale_equip_id = cmb_equipidForSale.SelectedValue.ToString();
            
            string sale_price = txt_SetForSale_Price.Text.Replace("'", "''");
            InventoryTabValidator.CheckSetToSalePriceNN(sale_price);
            InventoryTabValidator.CheckSetToSaleIPriceRegex(sale_price);

            InventoryManager.SetEquipmentToSale(sale_equip_id, sale_price);
            UpdateDatabase();
            }
            catch (InvalidSetToSalePriceNN error_message)
            {
                MessageBox.Show($"{InvalidSetToSalePriceNN.Error_message}");
            }
            catch (InvalidSetToSalePriceRegex error_message)
            {
                MessageBox.Show($"{InvalidSetToSalePriceRegex.Error_message}");
            }
        }

        // ========================================= ADD NEW CATEGORY =========================================
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                string new_category_description = txt_AddCategory.Text.Replace("'", "''");
                InventoryTabValidator.CheckAddCategoryDescriptionNN(new_category_description);
                InventoryTabValidator.CheckAddCategoryDescriptionMaxLength(new_category_description);

                InventoryManager.AddCategory(new_category_description);

                Form1_Load(null, null);

                MessageBox.Show($"Category update:\n\n{new_category_description} category was added!");
            }
            catch (InvalidAddCategoryDescriptionNN error_message)
            {
                MessageBox.Show($"{InvalidAddCategoryDescriptionNN.Error_message}");
            }
            catch (InvalidAddCategoryDescriptionMaxLength error_message)
            {
                MessageBox.Show($"{InvalidAddCategoryDescriptionMaxLength.Error_message}");
            }
        }
        private void txt_AddCategory_TextChanged(object sender, EventArgs e) {}


        // ========================================= REMOVE EQUIPMENT =========================================
        private void datagridEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string equipment_id_to_remove = this.cmb_RemoveEquipmentID.SelectedValue.ToString();

            DialogResult res = MessageBox.Show(
            "Are you sure?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (res == DialogResult.No)
                return;

            InventoryManager.RemoveEquipment(equipment_id_to_remove);
            Form1_Load(null, null);
        }

        private void label2_Click(object sender, EventArgs e) {}

        private void textBox3_TextChanged(object sender, EventArgs e) {}


        // ========================================== REMOVE CATEGORY ==========================================
        private void label5_Click(object sender, EventArgs e) {}

        private void txt_category_id_to_remove_TextChanged(object sender, EventArgs e) {}

        private void btn_RemoveCatategory_Click(object sender, EventArgs e)
        {
            string category_id_to_remove = this.cmb_category_id_to_remove.SelectedValue.ToString();
            
            // Confirmation request
            DialogResult res = MessageBox.Show(
            "Are you sure?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (res == DialogResult.No)
                return;

            InventoryManager.RemoveCategory(category_id_to_remove);
            Form1_Load(null, null);
        }


        // ========================================== ADD CUSTOMER ==========================================
        private void txtbxCFirstName_TextChanged(object sender, EventArgs e) {}

        private void btbAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string last_name = txt_AddCustomer_LastName.Text.Replace("'", "''");
                CustomerTabValidator.CheckLastNameNN(last_name);
                CustomerTabValidator.CheckLastName(last_name);

                string first_name = txt_AddCustomer_FirstName.Text.Replace("'", "''");
                CustomerTabValidator.CheckFirstNameNN(first_name);
                CustomerTabValidator.CheckFirstName(first_name);

                string contact_phone = txt_AddCustomer_PhoneNumber.Text;
                CustomerTabValidator.CheckPhoneNumberNN(contact_phone);
                CustomerTabValidator.CheckPhoneNumber(contact_phone);

                string email = txt_AddCustomer_Email.Text.Replace("'", "''");
                CustomerTabValidator.CheckEmailNN(email);
                CustomerTabValidator.CheckEmailLength(email);
                CustomerTabValidator.CheckEmailRegex(email);

                string note = txt_AddCustomer_Note.Text.Replace("'", "''");
                CustomerTabValidator.CheckNote(note);

                CustomerManager.AddCustomer(last_name, first_name, contact_phone, email, note);

                MessageBox.Show($"Customer update:\n\n{first_name} {last_name} was registered!");
            
            }
            catch (InvalidPhoneContact error_message)
            {
                MessageBox.Show($"{InvalidPhoneContact.Error_message}");
            }
            catch (InvalidFirstName error_message)
            {
                MessageBox.Show($"{InvalidFirstName.Error_message}");
            }
            catch (InvalidLastName error_message)
            {
                MessageBox.Show($"{InvalidLastName.Error_message}");
            }
            catch (InvalidEmailRegex error_message)
            {
                MessageBox.Show($"{InvalidEmailRegex.Error_message}");
            }
            catch (InvalidEmailLength error_message)
            {
                MessageBox.Show($"{InvalidEmailLength.Error_message}");
            }
            catch (InvalidNote error_message)
            {
                MessageBox.Show($"{InvalidNote.Error_message}");
            }
            catch (InvalidEmailNN error_message)
            {
                MessageBox.Show($"{InvalidEmailNN.Error_message}");
            }
            catch (InvalidFirstNameNN error_message)
            {
                MessageBox.Show($"{InvalidFirstNameNN.Error_message}");
            }
            catch (InvalidLastNameNN error_message)
            {
                MessageBox.Show($"{InvalidLastNameNN.Error_message}");
            }
            catch (InvalidPhoneContactNN error_message)
            {
                MessageBox.Show($"{InvalidPhoneContactNN.Error_message}");
            }



            Form1_Load(null, null);
        }


        // ========================================== EDIT CUSTOMER ==========================================
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string last_name = txt_EditCustomer_LastName.Text.Replace("'", "''");
                CustomerTabValidator.CheckLastNameNN(last_name);
                CustomerTabValidator.CheckLastName(last_name);

                string first_name = txt_EditCustomer_FirstName.Text.Replace("'", "''");
                CustomerTabValidator.CheckFirstNameNN(first_name);
                CustomerTabValidator.CheckFirstName(first_name);

                string contact_phone = txt_EditCustomer_PhoneNumber.Text.Replace("'", "''");
                CustomerTabValidator.CheckPhoneNumberNN(contact_phone);
                CustomerTabValidator.CheckPhoneNumber(contact_phone);

                string email = txt_EditCustomer_Email.Text.Replace("'", "''");
                CustomerTabValidator.CheckEmailNN(email);
                CustomerTabValidator.CheckEmailLength(email);
                CustomerTabValidator.CheckEmailRegex(email);

                // Confirmation request
                DialogResult res = MessageBox.Show(
                "Are you sure?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (res == DialogResult.No)
                    return;

                string note = txt_EditCustomer_Note.Text.Replace("'", "''");
                string customer_id = this.cmbx_EditCustomer_customer_id.SelectedValue.ToString();
                int.TryParse(customer_id, out int int_customer_id);

                CustomerManager.EditCustomer(int_customer_id, last_name, first_name, contact_phone, email, note);

                Form1_Load(null, null);

                MessageBox.Show($"Customer update:\n\n{first_name} {last_name}'s information were updated!");

            }
            catch (InvalidPhoneContact error_message)
            {
                MessageBox.Show($"{InvalidPhoneContact.Error_message}");
            }
            catch (InvalidFirstName error_message)
            {
                MessageBox.Show($"{InvalidFirstName.Error_message}");
            }
            catch (InvalidLastName error_message)
            {
                MessageBox.Show($"{InvalidLastName.Error_message}");
            }
            catch (InvalidEmailRegex error_message)
            {
                MessageBox.Show($"{InvalidEmailRegex.Error_message}");
            }
            catch (InvalidEmailLength error_message)
            {
                MessageBox.Show($"{InvalidEmailLength.Error_message}");
            }
            catch (InvalidNote error_message)
            {
                MessageBox.Show($"{InvalidNote.Error_message}");
            }
            catch (InvalidEmailNN error_message)
            {
                MessageBox.Show($"{InvalidEmailNN.Error_message}");
            }
            catch (InvalidFirstNameNN error_message)
            {
                MessageBox.Show($"{InvalidFirstNameNN.Error_message}");
            }
            catch (InvalidLastNameNN error_message)
            {
                MessageBox.Show($"{InvalidLastNameNN.Error_message}");
            }
            catch (InvalidPhoneContactNN error_message)
            {
                MessageBox.Show($"{InvalidPhoneContactNN.Error_message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        private void dataGridView_AvailableEquipments_Click(object sender, DataGridViewCellEventArgs e) {}

        // ==================================== LOAD AVAILABLE EQUIPMENT LIST ======================================

        private void Load_dataGridView_AvailableEquipment()
        {
            DataTable table_AvailableEquipment = RentalManager.PopulateAvailableEquipmentGridView();
            dataGridView_AvailableEquipment.DataSource = table_AvailableEquipment;
        }


        // ==================================== LOAD CURRENT RENTALS ======================================

        private void Load_dataGridView_CurrentRentals()
        {
            DataTable table_CurrentRentals = RentalManager.PopulateCurrentRentalsGridView();
            //dataGridView_AvailableEquipment.DataSource = null;
            dataGridView_CurrentRentals.DataSource = table_CurrentRentals;
            //dataGridView_AvailableEquipment.Refresh();
        }


        // ========================================== RENT EQUIPMENT ==========================================

        private void PopulateAvailableEquipIdToRent()
        {
            DataTable table_AvailableEquipToRent = InventoryManager.GetAvailableEquipToRent();
            cmb_Equipment_id_to_Rent.DataSource = table_AvailableEquipToRent;
            cmb_Equipment_id_to_Rent.DisplayMember = "equipment_id";
            cmb_Equipment_id_to_Rent.ValueMember = "equipment_id";
        }
        private void cmb_Equipment_id_to_Rent_SelectedIndexChanged(object sender, EventArgs e) {}

        private void btnRentEquip_Click(object sender, EventArgs e)
        {
            try
            {
                string customer_id_to_rent = this.cmb_Customer_id_to_Rent.SelectedValue.ToString();

                string equipment_id_to_rent = this.cmb_Equipment_id_to_Rent.SelectedValue.ToString();

                DateTime dtpDateRented = dtpEquipDateRented.Value;
                string SQLDateRented = dtpDateRented.ToString("dd-MMM-yyyy");

                DateTime dtpDateToReturn = dtpEquipDateReturn.Value;
                string SQLDateToReturn = dtpDateToReturn.ToString("dd-MMM-yyyy");

                // Validation: selection of dates
                if (dtpDateRented.Day > dtpDateToReturn.Day)
                {
                    throw new InvalidRentalDate();
                }

                // Calculate duration
                int durationInDays;
                /// Unsuccessful attempt to make a rental to be returned in the same day to work
                if (dtpDateRented.Day == dtpDateToReturn.Day)
                {
                    durationInDays = 1;
                }
                else
                {
                    TimeSpan duration = dtpDateToReturn - dtpDateRented;
                    /// +1 as the retrieving day counts as a renting day
                    durationInDays = duration.Days + 1;
                }

                // Create a new reservation
                RentalManager.CreateReservation(customer_id_to_rent, equipment_id_to_rent, SQLDateRented, SQLDateToReturn, durationInDays);
            }
            catch(InvalidRentalDate error_message)
            {
                MessageBox.Show(InvalidRentalDate.Error_message);
            }
            UpdateDatabase();
        }



        // ====================================== LOAD SALES REPORT =======================================
        private void Load_datagridSalesReport()
        {
            DataTable table_Sales = RentalManager.SalesGridView();
            datagridSalesReport.DataSource = table_Sales;
        }

        private void datagridSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        // ====================================== LOAD SALES REPORT =======================================
        private void Load_datagridEquipmentReport()
        {
            DataTable table_Equipment = RentalManager.EquipmentGridView();
            datagridEquipmentReport.DataSource = table_Equipment;
        }
        private void datagridEquipmentReport_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        // ========================================== UPDATE DATABASE ================================
        private void UpdateDatabase()
        {
            Load_datagridEquipmentReport();
            Load_dataGridView_AvailableEquipment();
            Load_dataGridView_CurrentRentals();
            Load_datagridSalesReport();
            PopulateAvailableEquipIdToRent();
        }


    }
}
