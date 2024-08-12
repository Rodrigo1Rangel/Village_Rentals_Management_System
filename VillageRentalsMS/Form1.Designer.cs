namespace VillageRentalsMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RemoveEquipmentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.lblCatGrid = new System.Windows.Forms.Label();
            this.datagridCategories = new System.Windows.Forms.DataGridView();
            this.cATEGORYIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRCATEGORIESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vR_Dataset = new VillageRentalsMS.VR_Dataset();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.lblEquipGrid = new System.Windows.Forms.Label();
            this.datagridEquipment = new System.Windows.Forms.DataGridView();
            this.eQUIPMENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vREQUIPMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddCatBox = new System.Windows.Forms.Label();
            this.txt_AddCategory = new System.Windows.Forms.TextBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblEquipName = new System.Windows.Forms.Label();
            this.lblEquipDesc = new System.Windows.Forms.Label();
            this.lblEquipCat = new System.Windows.Forms.Label();
            this.txtAddEquip_Name = new System.Windows.Forms.TextBox();
            this.txt_AddEquipDescription = new System.Windows.Forms.TextBox();
            this.addEquipment_category_id = new System.Windows.Forms.ComboBox();
            this.vRCATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCustList = new System.Windows.Forms.Label();
            this.datagridCustomers = new System.Windows.Forms.DataGridView();
            this.lblCustID = new System.Windows.Forms.Label();
            this.cmbxCustIDEdit = new System.Windows.Forms.ComboBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.txtbxCNoteEdit = new System.Windows.Forms.TextBox();
            this.lblCNoteEdit = new System.Windows.Forms.Label();
            this.lblCEmailAddressEdit = new System.Windows.Forms.Label();
            this.txtbxCEmailAddressEdit = new System.Windows.Forms.TextBox();
            this.lblCPhoneNumberEdit = new System.Windows.Forms.Label();
            this.txtbxCPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.lblCFirstNameEdit = new System.Windows.Forms.Label();
            this.txtbxCFirstNameEdit = new System.Windows.Forms.TextBox();
            this.lblCLastNameEdit = new System.Windows.Forms.Label();
            this.txtbxCLastNameEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btbAddCustomer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCNote = new System.Windows.Forms.Label();
            this.lblCEmailAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCPhoneNumber = new System.Windows.Forms.Label();
            this.txtbxCPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblCFirstName = new System.Windows.Forms.Label();
            this.txtbxCFirstName = new System.Windows.Forms.TextBox();
            this.lblCLastName = new System.Windows.Forms.Label();
            this.txtbxCLastName = new System.Windows.Forms.TextBox();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCurrentRentals = new System.Windows.Forms.Label();
            this.lblAvailEquip = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpEquipDateReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpEquipDateRented = new System.Windows.Forms.DateTimePicker();
            this.lblEquipIDRent = new System.Windows.Forms.Label();
            this.cmbxEquipIDRent = new System.Windows.Forms.ComboBox();
            this.btnRentEquip = new System.Windows.Forms.Button();
            this.lblEquipDateReturn = new System.Windows.Forms.Label();
            this.lblEquipDateRented = new System.Windows.Forms.Label();
            this.lblCustIDRent = new System.Windows.Forms.Label();
            this.cmbxCustIDRent = new System.Windows.Forms.ComboBox();
            this.lblRentEquip = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExportEquipment = new System.Windows.Forms.Button();
            this.btnExportSales = new System.Windows.Forms.Button();
            this.lblEquipListSort = new System.Windows.Forms.Label();
            this.lblSalesListSort = new System.Windows.Forms.Label();
            this.cmbxSortEquipBy = new System.Windows.Forms.ComboBox();
            this.lblSortEquipBy = new System.Windows.Forms.Label();
            this.datagridEquipmentReport = new System.Windows.Forms.DataGridView();
            this.datagridSalesReport = new System.Windows.Forms.DataGridView();
            this.cmbxSortSalesBy = new System.Windows.Forms.ComboBox();
            this.lblSortSales = new System.Windows.Forms.Label();
            this.vREQUIPMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vR_EQUIPMENTTableAdapter = new VillageRentalsMS.VR_DatasetTableAdapters.VR_EQUIPMENTTableAdapter();
            this.rENTEQUIPEQUIPMENTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vR_RENTALEQUIPMENTTableAdapter = new VillageRentalsMS.VR_DatasetTableAdapters.VR_RENTALEQUIPMENTTableAdapter();
            this.vR_CATEGORIESTableAdapter = new VillageRentalsMS.VR_DatasetTableAdapters.VR_CATEGORIESTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_category_id_to_remove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_RemoveCatategory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRCATEGORIESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vR_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vREQUIPMENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRCATEGORIESBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEquipmentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vREQUIPMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTEQUIPEQUIPMENTIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 989);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_category_id_to_remove);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_RemoveEquipmentID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAddCat);
            this.tabPage1.Controls.Add(this.btn_RemoveCatategory);
            this.tabPage1.Controls.Add(this.lblCatGrid);
            this.tabPage1.Controls.Add(this.datagridCategories);
            this.tabPage1.Controls.Add(this.btnRemoveItem);
            this.tabPage1.Controls.Add(this.btnAddEquipment);
            this.tabPage1.Controls.Add(this.lblEquipGrid);
            this.tabPage1.Controls.Add(this.datagridEquipment);
            this.tabPage1.Controls.Add(this.lblAddCatBox);
            this.tabPage1.Controls.Add(this.txt_AddCategory);
            this.tabPage1.Controls.Add(this.lblAddCategory);
            this.tabPage1.Controls.Add(this.lblEquipName);
            this.tabPage1.Controls.Add(this.lblEquipDesc);
            this.tabPage1.Controls.Add(this.lblEquipCat);
            this.tabPage1.Controls.Add(this.txtAddEquip_Name);
            this.tabPage1.Controls.Add(this.txt_AddEquipDescription);
            this.tabPage1.Controls.Add(this.addEquipment_category_id);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1285, 956);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 835);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Equipment ID";
            // 
            // txt_RemoveEquipmentID
            // 
            this.txt_RemoveEquipmentID.Location = new System.Drawing.Point(30, 861);
            this.txt_RemoveEquipmentID.Name = "txt_RemoveEquipmentID";
            this.txt_RemoveEquipmentID.Size = new System.Drawing.Size(200, 26);
            this.txt_RemoveEquipmentID.TabIndex = 19;
            this.txt_RemoveEquipmentID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 795);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Remove Equipment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(867, 150);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(200, 35);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "Add Category";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // lblCatGrid
            // 
            this.lblCatGrid.AutoSize = true;
            this.lblCatGrid.Location = new System.Drawing.Point(867, 225);
            this.lblCatGrid.Name = "lblCatGrid";
            this.lblCatGrid.Size = new System.Drawing.Size(86, 20);
            this.lblCatGrid.TabIndex = 15;
            this.lblCatGrid.Text = "Categories";
            // 
            // datagridCategories
            // 
            this.datagridCategories.AutoGenerateColumns = false;
            this.datagridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cATEGORYIDDataGridViewTextBoxColumn1,
            this.dESCRIPTIONDataGridViewTextBoxColumn1});
            this.datagridCategories.DataSource = this.vRCATEGORIESBindingSource1;
            this.datagridCategories.Location = new System.Drawing.Point(867, 251);
            this.datagridCategories.Name = "datagridCategories";
            this.datagridCategories.RowHeadersWidth = 62;
            this.datagridCategories.RowTemplate.Height = 28;
            this.datagridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCategories.Size = new System.Drawing.Size(382, 514);
            this.datagridCategories.TabIndex = 14;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn1
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn1.DataPropertyName = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn1.HeaderText = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cATEGORYIDDataGridViewTextBoxColumn1.Name = "cATEGORYIDDataGridViewTextBoxColumn1";
            this.cATEGORYIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn1
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn1.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dESCRIPTIONDataGridViewTextBoxColumn1.Name = "dESCRIPTIONDataGridViewTextBoxColumn1";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vRCATEGORIESBindingSource1
            // 
            this.vRCATEGORIESBindingSource1.DataMember = "VR_CATEGORIES";
            this.vRCATEGORIESBindingSource1.DataSource = this.vR_Dataset;
            // 
            // vR_Dataset
            // 
            this.vR_Dataset.DataSetName = "VR_Dataset";
            this.vR_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(30, 903);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(200, 35);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(30, 150);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(200, 35);
            this.btnAddEquipment.TabIndex = 12;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btn_AddEquipment);
            // 
            // lblEquipGrid
            // 
            this.lblEquipGrid.AutoSize = true;
            this.lblEquipGrid.Location = new System.Drawing.Point(30, 225);
            this.lblEquipGrid.Name = "lblEquipGrid";
            this.lblEquipGrid.Size = new System.Drawing.Size(74, 20);
            this.lblEquipGrid.TabIndex = 11;
            this.lblEquipGrid.Text = "Inventory";
            // 
            // datagridEquipment
            // 
            this.datagridEquipment.AutoGenerateColumns = false;
            this.datagridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eQUIPMENTIDDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.datagridEquipment.DataSource = this.vREQUIPMENTBindingSource1;
            this.datagridEquipment.Location = new System.Drawing.Point(30, 251);
            this.datagridEquipment.Name = "datagridEquipment";
            this.datagridEquipment.RowHeadersWidth = 62;
            this.datagridEquipment.RowTemplate.Height = 28;
            this.datagridEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEquipment.Size = new System.Drawing.Size(666, 514);
            this.datagridEquipment.TabIndex = 10;
            this.datagridEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridEquipment_CellContentClick);
            // 
            // eQUIPMENTIDDataGridViewTextBoxColumn
            // 
            this.eQUIPMENTIDDataGridViewTextBoxColumn.DataPropertyName = "EQUIPMENT_ID";
            this.eQUIPMENTIDDataGridViewTextBoxColumn.HeaderText = "EQUIPMENT_ID";
            this.eQUIPMENTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eQUIPMENTIDDataGridViewTextBoxColumn.Name = "eQUIPMENTIDDataGridViewTextBoxColumn";
            this.eQUIPMENTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            this.cATEGORYIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // vREQUIPMENTBindingSource1
            // 
            this.vREQUIPMENTBindingSource1.DataMember = "VR_EQUIPMENT";
            this.vREQUIPMENTBindingSource1.DataSource = this.vR_Dataset;
            // 
            // lblAddCatBox
            // 
            this.lblAddCatBox.AutoSize = true;
            this.lblAddCatBox.Location = new System.Drawing.Point(867, 68);
            this.lblAddCatBox.Name = "lblAddCatBox";
            this.lblAddCatBox.Size = new System.Drawing.Size(73, 20);
            this.lblAddCatBox.TabIndex = 9;
            this.lblAddCatBox.Text = "Category";
            // 
            // txt_AddCategory
            // 
            this.txt_AddCategory.Location = new System.Drawing.Point(867, 94);
            this.txt_AddCategory.Name = "txt_AddCategory";
            this.txt_AddCategory.Size = new System.Drawing.Size(200, 26);
            this.txt_AddCategory.TabIndex = 8;
            this.txt_AddCategory.TextChanged += new System.EventHandler(this.txt_AddCategory_TextChanged);
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.Location = new System.Drawing.Point(863, 27);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(187, 20);
            this.lblAddCategory.TabIndex = 7;
            this.lblAddCategory.Text = "Add Equipment Category";
            // 
            // lblEquipName
            // 
            this.lblEquipName.AutoSize = true;
            this.lblEquipName.Location = new System.Drawing.Point(496, 68);
            this.lblEquipName.Name = "lblEquipName";
            this.lblEquipName.Size = new System.Drawing.Size(51, 20);
            this.lblEquipName.TabIndex = 6;
            this.lblEquipName.Text = "Name";
            // 
            // lblEquipDesc
            // 
            this.lblEquipDesc.AutoSize = true;
            this.lblEquipDesc.Location = new System.Drawing.Point(263, 68);
            this.lblEquipDesc.Name = "lblEquipDesc";
            this.lblEquipDesc.Size = new System.Drawing.Size(89, 20);
            this.lblEquipDesc.TabIndex = 5;
            this.lblEquipDesc.Text = "Description";
            // 
            // lblEquipCat
            // 
            this.lblEquipCat.AutoSize = true;
            this.lblEquipCat.Location = new System.Drawing.Point(30, 68);
            this.lblEquipCat.Name = "lblEquipCat";
            this.lblEquipCat.Size = new System.Drawing.Size(73, 20);
            this.lblEquipCat.TabIndex = 4;
            this.lblEquipCat.Text = "Category";
            // 
            // txtAddEquip_Name
            // 
            this.txtAddEquip_Name.Location = new System.Drawing.Point(496, 94);
            this.txtAddEquip_Name.Name = "txtAddEquip_Name";
            this.txtAddEquip_Name.Size = new System.Drawing.Size(200, 26);
            this.txtAddEquip_Name.TabIndex = 3;
            // 
            // txt_AddEquipDescription
            // 
            this.txt_AddEquipDescription.Location = new System.Drawing.Point(263, 94);
            this.txt_AddEquipDescription.Name = "txt_AddEquipDescription";
            this.txt_AddEquipDescription.Size = new System.Drawing.Size(200, 26);
            this.txt_AddEquipDescription.TabIndex = 2;
            this.txt_AddEquipDescription.TextChanged += new System.EventHandler(this.txtbxEquipDesc_TextChanged);
            // 
            // addEquipment_category_id
            // 
            this.addEquipment_category_id.DataSource = this.vRCATEGORIESBindingSource;
            this.addEquipment_category_id.DisplayMember = "DESCRIPTION";
            this.addEquipment_category_id.FormattingEnabled = true;
            this.addEquipment_category_id.Location = new System.Drawing.Point(30, 94);
            this.addEquipment_category_id.Name = "addEquipment_category_id";
            this.addEquipment_category_id.Size = new System.Drawing.Size(200, 28);
            this.addEquipment_category_id.TabIndex = 1;
            this.addEquipment_category_id.ValueMember = "CATEGORY_ID";
            this.addEquipment_category_id.SelectedIndexChanged += new System.EventHandler(this.Inventory_AddEquipment);
            // 
            // vRCATEGORIESBindingSource
            // 
            this.vRCATEGORIESBindingSource.DataMember = "VR_CATEGORIES";
            this.vRCATEGORIESBindingSource.DataSource = this.vR_Dataset;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Equipment";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCustList);
            this.tabPage2.Controls.Add(this.datagridCustomers);
            this.tabPage2.Controls.Add(this.lblCustID);
            this.tabPage2.Controls.Add(this.cmbxCustIDEdit);
            this.tabPage2.Controls.Add(this.btnEditCustomer);
            this.tabPage2.Controls.Add(this.txtbxCNoteEdit);
            this.tabPage2.Controls.Add(this.lblCNoteEdit);
            this.tabPage2.Controls.Add(this.lblCEmailAddressEdit);
            this.tabPage2.Controls.Add(this.txtbxCEmailAddressEdit);
            this.tabPage2.Controls.Add(this.lblCPhoneNumberEdit);
            this.tabPage2.Controls.Add(this.txtbxCPhoneNumberEdit);
            this.tabPage2.Controls.Add(this.lblCFirstNameEdit);
            this.tabPage2.Controls.Add(this.txtbxCFirstNameEdit);
            this.tabPage2.Controls.Add(this.lblCLastNameEdit);
            this.tabPage2.Controls.Add(this.txtbxCLastNameEdit);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btbAddCustomer);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lblCNote);
            this.tabPage2.Controls.Add(this.lblCEmailAddress);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblCPhoneNumber);
            this.tabPage2.Controls.Add(this.txtbxCPhoneNumber);
            this.tabPage2.Controls.Add(this.lblCFirstName);
            this.tabPage2.Controls.Add(this.txtbxCFirstName);
            this.tabPage2.Controls.Add(this.lblCLastName);
            this.tabPage2.Controls.Add(this.txtbxCLastName);
            this.tabPage2.Controls.Add(this.lblAddCustomer);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1285, 956);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCustList
            // 
            this.lblCustList.AutoSize = true;
            this.lblCustList.Location = new System.Drawing.Point(26, 338);
            this.lblCustList.Name = "lblCustList";
            this.lblCustList.Size = new System.Drawing.Size(107, 20);
            this.lblCustList.TabIndex = 27;
            this.lblCustList.Text = "Customer List";
            // 
            // datagridCustomers
            // 
            this.datagridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCustomers.Location = new System.Drawing.Point(30, 361);
            this.datagridCustomers.Name = "datagridCustomers";
            this.datagridCustomers.RowHeadersWidth = 62;
            this.datagridCustomers.RowTemplate.Height = 28;
            this.datagridCustomers.Size = new System.Drawing.Size(1218, 461);
            this.datagridCustomers.TabIndex = 26;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(789, 194);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(99, 20);
            this.lblCustID.TabIndex = 25;
            this.lblCustID.Text = "Customer ID";
            // 
            // cmbxCustIDEdit
            // 
            this.cmbxCustIDEdit.FormattingEnabled = true;
            this.cmbxCustIDEdit.Location = new System.Drawing.Point(789, 220);
            this.cmbxCustIDEdit.Name = "cmbxCustIDEdit";
            this.cmbxCustIDEdit.Size = new System.Drawing.Size(200, 28);
            this.cmbxCustIDEdit.TabIndex = 24;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(558, 279);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(200, 35);
            this.btnEditCustomer.TabIndex = 23;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // txtbxCNoteEdit
            // 
            this.txtbxCNoteEdit.Location = new System.Drawing.Point(558, 222);
            this.txtbxCNoteEdit.Name = "txtbxCNoteEdit";
            this.txtbxCNoteEdit.Size = new System.Drawing.Size(200, 26);
            this.txtbxCNoteEdit.TabIndex = 22;
            // 
            // lblCNoteEdit
            // 
            this.lblCNoteEdit.AutoSize = true;
            this.lblCNoteEdit.Location = new System.Drawing.Point(554, 199);
            this.lblCNoteEdit.Name = "lblCNoteEdit";
            this.lblCNoteEdit.Size = new System.Drawing.Size(43, 20);
            this.lblCNoteEdit.TabIndex = 21;
            this.lblCNoteEdit.Text = "Note";
            // 
            // lblCEmailAddressEdit
            // 
            this.lblCEmailAddressEdit.AutoSize = true;
            this.lblCEmailAddressEdit.Location = new System.Drawing.Point(789, 134);
            this.lblCEmailAddressEdit.Name = "lblCEmailAddressEdit";
            this.lblCEmailAddressEdit.Size = new System.Drawing.Size(111, 20);
            this.lblCEmailAddressEdit.TabIndex = 20;
            this.lblCEmailAddressEdit.Text = "Email Address";
            // 
            // txtbxCEmailAddressEdit
            // 
            this.txtbxCEmailAddressEdit.Location = new System.Drawing.Point(789, 157);
            this.txtbxCEmailAddressEdit.Name = "txtbxCEmailAddressEdit";
            this.txtbxCEmailAddressEdit.Size = new System.Drawing.Size(200, 26);
            this.txtbxCEmailAddressEdit.TabIndex = 19;
            // 
            // lblCPhoneNumberEdit
            // 
            this.lblCPhoneNumberEdit.AutoSize = true;
            this.lblCPhoneNumberEdit.Location = new System.Drawing.Point(558, 134);
            this.lblCPhoneNumberEdit.Name = "lblCPhoneNumberEdit";
            this.lblCPhoneNumberEdit.Size = new System.Drawing.Size(115, 20);
            this.lblCPhoneNumberEdit.TabIndex = 18;
            this.lblCPhoneNumberEdit.Text = "Phone Number";
            // 
            // txtbxCPhoneNumberEdit
            // 
            this.txtbxCPhoneNumberEdit.Location = new System.Drawing.Point(558, 157);
            this.txtbxCPhoneNumberEdit.Name = "txtbxCPhoneNumberEdit";
            this.txtbxCPhoneNumberEdit.Size = new System.Drawing.Size(200, 26);
            this.txtbxCPhoneNumberEdit.TabIndex = 17;
            // 
            // lblCFirstNameEdit
            // 
            this.lblCFirstNameEdit.AutoSize = true;
            this.lblCFirstNameEdit.Location = new System.Drawing.Point(789, 68);
            this.lblCFirstNameEdit.Name = "lblCFirstNameEdit";
            this.lblCFirstNameEdit.Size = new System.Drawing.Size(86, 20);
            this.lblCFirstNameEdit.TabIndex = 16;
            this.lblCFirstNameEdit.Text = "First Name";
            // 
            // txtbxCFirstNameEdit
            // 
            this.txtbxCFirstNameEdit.Location = new System.Drawing.Point(789, 91);
            this.txtbxCFirstNameEdit.Name = "txtbxCFirstNameEdit";
            this.txtbxCFirstNameEdit.Size = new System.Drawing.Size(200, 26);
            this.txtbxCFirstNameEdit.TabIndex = 15;
            // 
            // lblCLastNameEdit
            // 
            this.lblCLastNameEdit.AutoSize = true;
            this.lblCLastNameEdit.Location = new System.Drawing.Point(558, 68);
            this.lblCLastNameEdit.Name = "lblCLastNameEdit";
            this.lblCLastNameEdit.Size = new System.Drawing.Size(86, 20);
            this.lblCLastNameEdit.TabIndex = 14;
            this.lblCLastNameEdit.Text = "Last Name";
            // 
            // txtbxCLastNameEdit
            // 
            this.txtbxCLastNameEdit.Location = new System.Drawing.Point(558, 91);
            this.txtbxCLastNameEdit.Name = "txtbxCLastNameEdit";
            this.txtbxCLastNameEdit.Size = new System.Drawing.Size(200, 26);
            this.txtbxCLastNameEdit.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edit Customer";
            // 
            // btbAddCustomer
            // 
            this.btbAddCustomer.Location = new System.Drawing.Point(30, 279);
            this.btbAddCustomer.Name = "btbAddCustomer";
            this.btbAddCustomer.Size = new System.Drawing.Size(200, 35);
            this.btbAddCustomer.TabIndex = 11;
            this.btbAddCustomer.Text = "Add Customer";
            this.btbAddCustomer.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 10;
            // 
            // lblCNote
            // 
            this.lblCNote.AutoSize = true;
            this.lblCNote.Location = new System.Drawing.Point(26, 199);
            this.lblCNote.Name = "lblCNote";
            this.lblCNote.Size = new System.Drawing.Size(43, 20);
            this.lblCNote.TabIndex = 9;
            this.lblCNote.Text = "Note";
            // 
            // lblCEmailAddress
            // 
            this.lblCEmailAddress.AutoSize = true;
            this.lblCEmailAddress.Location = new System.Drawing.Point(261, 134);
            this.lblCEmailAddress.Name = "lblCEmailAddress";
            this.lblCEmailAddress.Size = new System.Drawing.Size(111, 20);
            this.lblCEmailAddress.TabIndex = 8;
            this.lblCEmailAddress.Text = "Email Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 7;
            // 
            // lblCPhoneNumber
            // 
            this.lblCPhoneNumber.AutoSize = true;
            this.lblCPhoneNumber.Location = new System.Drawing.Point(30, 134);
            this.lblCPhoneNumber.Name = "lblCPhoneNumber";
            this.lblCPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lblCPhoneNumber.TabIndex = 6;
            this.lblCPhoneNumber.Text = "Phone Number";
            // 
            // txtbxCPhoneNumber
            // 
            this.txtbxCPhoneNumber.Location = new System.Drawing.Point(30, 157);
            this.txtbxCPhoneNumber.Name = "txtbxCPhoneNumber";
            this.txtbxCPhoneNumber.Size = new System.Drawing.Size(200, 26);
            this.txtbxCPhoneNumber.TabIndex = 5;
            // 
            // lblCFirstName
            // 
            this.lblCFirstName.AutoSize = true;
            this.lblCFirstName.Location = new System.Drawing.Point(261, 68);
            this.lblCFirstName.Name = "lblCFirstName";
            this.lblCFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblCFirstName.TabIndex = 4;
            this.lblCFirstName.Text = "First Name";
            // 
            // txtbxCFirstName
            // 
            this.txtbxCFirstName.Location = new System.Drawing.Point(261, 91);
            this.txtbxCFirstName.Name = "txtbxCFirstName";
            this.txtbxCFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtbxCFirstName.TabIndex = 3;
            // 
            // lblCLastName
            // 
            this.lblCLastName.AutoSize = true;
            this.lblCLastName.Location = new System.Drawing.Point(30, 68);
            this.lblCLastName.Name = "lblCLastName";
            this.lblCLastName.Size = new System.Drawing.Size(86, 20);
            this.lblCLastName.TabIndex = 2;
            this.lblCLastName.Text = "Last Name";
            // 
            // txtbxCLastName
            // 
            this.txtbxCLastName.Location = new System.Drawing.Point(30, 91);
            this.txtbxCLastName.Name = "txtbxCLastName";
            this.txtbxCLastName.Size = new System.Drawing.Size(200, 26);
            this.txtbxCLastName.TabIndex = 1;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(26, 27);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(111, 20);
            this.lblAddCustomer.TabIndex = 0;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCurrentRentals);
            this.tabPage3.Controls.Add(this.lblAvailEquip);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.dtpEquipDateReturn);
            this.tabPage3.Controls.Add(this.dtpEquipDateRented);
            this.tabPage3.Controls.Add(this.lblEquipIDRent);
            this.tabPage3.Controls.Add(this.cmbxEquipIDRent);
            this.tabPage3.Controls.Add(this.btnRentEquip);
            this.tabPage3.Controls.Add(this.lblEquipDateReturn);
            this.tabPage3.Controls.Add(this.lblEquipDateRented);
            this.tabPage3.Controls.Add(this.lblCustIDRent);
            this.tabPage3.Controls.Add(this.cmbxCustIDRent);
            this.tabPage3.Controls.Add(this.lblRentEquip);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1285, 956);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblCurrentRentals
            // 
            this.lblCurrentRentals.AutoSize = true;
            this.lblCurrentRentals.Location = new System.Drawing.Point(376, 210);
            this.lblCurrentRentals.Name = "lblCurrentRentals";
            this.lblCurrentRentals.Size = new System.Drawing.Size(121, 20);
            this.lblCurrentRentals.TabIndex = 28;
            this.lblCurrentRentals.Text = "Current Rentals";
            // 
            // lblAvailEquip
            // 
            this.lblAvailEquip.AutoSize = true;
            this.lblAvailEquip.Location = new System.Drawing.Point(30, 210);
            this.lblAvailEquip.Name = "lblAvailEquip";
            this.lblAvailEquip.Size = new System.Drawing.Size(153, 20);
            this.lblAvailEquip.TabIndex = 27;
            this.lblAvailEquip.Text = "Available Equipment";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(380, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(871, 589);
            this.dataGridView2.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(295, 589);
            this.dataGridView1.TabIndex = 25;
            // 
            // dtpEquipDateReturn
            // 
            this.dtpEquipDateReturn.Location = new System.Drawing.Point(729, 102);
            this.dtpEquipDateReturn.Name = "dtpEquipDateReturn";
            this.dtpEquipDateReturn.Size = new System.Drawing.Size(200, 26);
            this.dtpEquipDateReturn.TabIndex = 24;
            // 
            // dtpEquipDateRented
            // 
            this.dtpEquipDateRented.Location = new System.Drawing.Point(495, 102);
            this.dtpEquipDateRented.Name = "dtpEquipDateRented";
            this.dtpEquipDateRented.Size = new System.Drawing.Size(200, 26);
            this.dtpEquipDateRented.TabIndex = 23;
            // 
            // lblEquipIDRent
            // 
            this.lblEquipIDRent.AutoSize = true;
            this.lblEquipIDRent.Location = new System.Drawing.Point(263, 74);
            this.lblEquipIDRent.Name = "lblEquipIDRent";
            this.lblEquipIDRent.Size = new System.Drawing.Size(107, 20);
            this.lblEquipIDRent.TabIndex = 22;
            this.lblEquipIDRent.Text = "Equipment ID";
            // 
            // cmbxEquipIDRent
            // 
            this.cmbxEquipIDRent.FormattingEnabled = true;
            this.cmbxEquipIDRent.Location = new System.Drawing.Point(263, 100);
            this.cmbxEquipIDRent.Name = "cmbxEquipIDRent";
            this.cmbxEquipIDRent.Size = new System.Drawing.Size(200, 28);
            this.cmbxEquipIDRent.TabIndex = 21;
            // 
            // btnRentEquip
            // 
            this.btnRentEquip.Location = new System.Drawing.Point(30, 152);
            this.btnRentEquip.Name = "btnRentEquip";
            this.btnRentEquip.Size = new System.Drawing.Size(200, 35);
            this.btnRentEquip.TabIndex = 20;
            this.btnRentEquip.Text = "Rent Equipment";
            this.btnRentEquip.UseVisualStyleBackColor = true;
            // 
            // lblEquipDateReturn
            // 
            this.lblEquipDateReturn.AutoSize = true;
            this.lblEquipDateReturn.Location = new System.Drawing.Point(725, 74);
            this.lblEquipDateReturn.Name = "lblEquipDateReturn";
            this.lblEquipDateReturn.Size = new System.Drawing.Size(97, 20);
            this.lblEquipDateReturn.TabIndex = 19;
            this.lblEquipDateReturn.Text = "Return Date";
            // 
            // lblEquipDateRented
            // 
            this.lblEquipDateRented.AutoSize = true;
            this.lblEquipDateRented.Location = new System.Drawing.Point(491, 74);
            this.lblEquipDateRented.Name = "lblEquipDateRented";
            this.lblEquipDateRented.Size = new System.Drawing.Size(101, 20);
            this.lblEquipDateRented.TabIndex = 18;
            this.lblEquipDateRented.Text = "Date Rented";
            // 
            // lblCustIDRent
            // 
            this.lblCustIDRent.AutoSize = true;
            this.lblCustIDRent.Location = new System.Drawing.Point(30, 74);
            this.lblCustIDRent.Name = "lblCustIDRent";
            this.lblCustIDRent.Size = new System.Drawing.Size(99, 20);
            this.lblCustIDRent.TabIndex = 17;
            this.lblCustIDRent.Text = "Customer ID";
            // 
            // cmbxCustIDRent
            // 
            this.cmbxCustIDRent.FormattingEnabled = true;
            this.cmbxCustIDRent.Location = new System.Drawing.Point(30, 100);
            this.cmbxCustIDRent.Name = "cmbxCustIDRent";
            this.cmbxCustIDRent.Size = new System.Drawing.Size(200, 28);
            this.cmbxCustIDRent.TabIndex = 14;
            // 
            // lblRentEquip
            // 
            this.lblRentEquip.AutoSize = true;
            this.lblRentEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentEquip.Location = new System.Drawing.Point(26, 27);
            this.lblRentEquip.Name = "lblRentEquip";
            this.lblRentEquip.Size = new System.Drawing.Size(125, 20);
            this.lblRentEquip.TabIndex = 13;
            this.lblRentEquip.Text = "Rent Equipment";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnExportEquipment);
            this.tabPage4.Controls.Add(this.btnExportSales);
            this.tabPage4.Controls.Add(this.lblEquipListSort);
            this.tabPage4.Controls.Add(this.lblSalesListSort);
            this.tabPage4.Controls.Add(this.cmbxSortEquipBy);
            this.tabPage4.Controls.Add(this.lblSortEquipBy);
            this.tabPage4.Controls.Add(this.datagridEquipmentReport);
            this.tabPage4.Controls.Add(this.datagridSalesReport);
            this.tabPage4.Controls.Add(this.cmbxSortSalesBy);
            this.tabPage4.Controls.Add(this.lblSortSales);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1285, 956);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExportEquipment
            // 
            this.btnExportEquipment.Location = new System.Drawing.Point(664, 773);
            this.btnExportEquipment.Name = "btnExportEquipment";
            this.btnExportEquipment.Size = new System.Drawing.Size(200, 35);
            this.btnExportEquipment.TabIndex = 10;
            this.btnExportEquipment.Text = "Export";
            this.btnExportEquipment.UseVisualStyleBackColor = true;
            // 
            // btnExportSales
            // 
            this.btnExportSales.Location = new System.Drawing.Point(30, 773);
            this.btnExportSales.Name = "btnExportSales";
            this.btnExportSales.Size = new System.Drawing.Size(200, 35);
            this.btnExportSales.TabIndex = 9;
            this.btnExportSales.Text = "Export";
            this.btnExportSales.UseVisualStyleBackColor = true;
            // 
            // lblEquipListSort
            // 
            this.lblEquipListSort.AutoSize = true;
            this.lblEquipListSort.Location = new System.Drawing.Point(664, 114);
            this.lblEquipListSort.Name = "lblEquipListSort";
            this.lblEquipListSort.Size = new System.Drawing.Size(86, 20);
            this.lblEquipListSort.TabIndex = 8;
            this.lblEquipListSort.Text = "Equipment";
            // 
            // lblSalesListSort
            // 
            this.lblSalesListSort.AutoSize = true;
            this.lblSalesListSort.Location = new System.Drawing.Point(30, 115);
            this.lblSalesListSort.Name = "lblSalesListSort";
            this.lblSalesListSort.Size = new System.Drawing.Size(49, 20);
            this.lblSalesListSort.TabIndex = 7;
            this.lblSalesListSort.Text = "Sales";
            // 
            // cmbxSortEquipBy
            // 
            this.cmbxSortEquipBy.FormattingEnabled = true;
            this.cmbxSortEquipBy.Location = new System.Drawing.Point(664, 64);
            this.cmbxSortEquipBy.Name = "cmbxSortEquipBy";
            this.cmbxSortEquipBy.Size = new System.Drawing.Size(200, 28);
            this.cmbxSortEquipBy.TabIndex = 6;
            // 
            // lblSortEquipBy
            // 
            this.lblSortEquipBy.AutoSize = true;
            this.lblSortEquipBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortEquipBy.Location = new System.Drawing.Point(660, 27);
            this.lblSortEquipBy.Name = "lblSortEquipBy";
            this.lblSortEquipBy.Size = new System.Drawing.Size(142, 20);
            this.lblSortEquipBy.TabIndex = 5;
            this.lblSortEquipBy.Text = "Sort Equipment By";
            // 
            // datagridEquipmentReport
            // 
            this.datagridEquipmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEquipmentReport.Location = new System.Drawing.Point(664, 141);
            this.datagridEquipmentReport.Name = "datagridEquipmentReport";
            this.datagridEquipmentReport.RowHeadersWidth = 62;
            this.datagridEquipmentReport.RowTemplate.Height = 28;
            this.datagridEquipmentReport.Size = new System.Drawing.Size(600, 625);
            this.datagridEquipmentReport.TabIndex = 4;
            // 
            // datagridSalesReport
            // 
            this.datagridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSalesReport.Location = new System.Drawing.Point(30, 141);
            this.datagridSalesReport.Name = "datagridSalesReport";
            this.datagridSalesReport.RowHeadersWidth = 62;
            this.datagridSalesReport.RowTemplate.Height = 28;
            this.datagridSalesReport.Size = new System.Drawing.Size(600, 625);
            this.datagridSalesReport.TabIndex = 3;
            // 
            // cmbxSortSalesBy
            // 
            this.cmbxSortSalesBy.FormattingEnabled = true;
            this.cmbxSortSalesBy.Location = new System.Drawing.Point(30, 64);
            this.cmbxSortSalesBy.Name = "cmbxSortSalesBy";
            this.cmbxSortSalesBy.Size = new System.Drawing.Size(200, 28);
            this.cmbxSortSalesBy.TabIndex = 2;
            // 
            // lblSortSales
            // 
            this.lblSortSales.AutoSize = true;
            this.lblSortSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSales.Location = new System.Drawing.Point(26, 27);
            this.lblSortSales.Name = "lblSortSales";
            this.lblSortSales.Size = new System.Drawing.Size(105, 20);
            this.lblSortSales.TabIndex = 1;
            this.lblSortSales.Text = "Sort Sales By";
            // 
            // vREQUIPMENTBindingSource
            // 
            this.vREQUIPMENTBindingSource.DataMember = "VR_EQUIPMENT";
            this.vREQUIPMENTBindingSource.DataSource = this.vR_Dataset;
            // 
            // vR_EQUIPMENTTableAdapter
            // 
            this.vR_EQUIPMENTTableAdapter.ClearBeforeFill = true;
            // 
            // rENTEQUIPEQUIPMENTIDBindingSource
            // 
            this.rENTEQUIPEQUIPMENTIDBindingSource.DataMember = "RENTEQUIP_EQUIPMENT_ID";
            this.rENTEQUIPEQUIPMENTIDBindingSource.DataSource = this.vREQUIPMENTBindingSource;
            // 
            // vR_RENTALEQUIPMENTTableAdapter
            // 
            this.vR_RENTALEQUIPMENTTableAdapter.ClearBeforeFill = true;
            // 
            // vR_CATEGORIESTableAdapter
            // 
            this.vR_CATEGORIESTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(867, 835);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Category ID";
            // 
            // txt_category_id_to_remove
            // 
            this.txt_category_id_to_remove.Location = new System.Drawing.Point(867, 861);
            this.txt_category_id_to_remove.Name = "txt_category_id_to_remove";
            this.txt_category_id_to_remove.Size = new System.Drawing.Size(200, 26);
            this.txt_category_id_to_remove.TabIndex = 23;
            this.txt_category_id_to_remove.TextChanged += new System.EventHandler(this.txt_category_id_to_remove_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(863, 795);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Remove Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_RemoveCatategory
            // 
            this.btn_RemoveCatategory.Location = new System.Drawing.Point(867, 903);
            this.btn_RemoveCatategory.Name = "btn_RemoveCatategory";
            this.btn_RemoveCatategory.Size = new System.Drawing.Size(200, 35);
            this.btn_RemoveCatategory.TabIndex = 16;
            this.btn_RemoveCatategory.Text = "Remove Category";
            this.btn_RemoveCatategory.UseVisualStyleBackColor = true;
            this.btn_RemoveCatategory.Click += new System.EventHandler(this.btn_RemoveCatategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 1013);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Village Rentals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRCATEGORIESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vR_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vREQUIPMENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRCATEGORIESBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEquipmentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vREQUIPMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTEQUIPEQUIPMENTIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquipName;
        private System.Windows.Forms.Label lblEquipDesc;
        private System.Windows.Forms.Label lblEquipCat;
        private System.Windows.Forms.TextBox txtAddEquip_Name;
        private System.Windows.Forms.TextBox txt_AddEquipDescription;
        private System.Windows.Forms.ComboBox addEquipment_category_id;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Label lblEquipGrid;
        private System.Windows.Forms.DataGridView datagridEquipment;
        private System.Windows.Forms.Label lblAddCatBox;
        private System.Windows.Forms.TextBox txt_AddCategory;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblCatGrid;
        private System.Windows.Forms.DataGridView datagridCategories;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblCNote;
        private System.Windows.Forms.Label lblCEmailAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCPhoneNumber;
        private System.Windows.Forms.TextBox txtbxCPhoneNumber;
        private System.Windows.Forms.Label lblCFirstName;
        private System.Windows.Forms.TextBox txtbxCFirstName;
        private System.Windows.Forms.Label lblCLastName;
        private System.Windows.Forms.TextBox txtbxCLastName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.ComboBox cmbxCustIDEdit;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox txtbxCNoteEdit;
        private System.Windows.Forms.Label lblCNoteEdit;
        private System.Windows.Forms.Label lblCEmailAddressEdit;
        private System.Windows.Forms.TextBox txtbxCEmailAddressEdit;
        private System.Windows.Forms.Label lblCPhoneNumberEdit;
        private System.Windows.Forms.TextBox txtbxCPhoneNumberEdit;
        private System.Windows.Forms.Label lblCFirstNameEdit;
        private System.Windows.Forms.TextBox txtbxCFirstNameEdit;
        private System.Windows.Forms.Label lblCLastNameEdit;
        private System.Windows.Forms.TextBox txtbxCLastNameEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btbAddCustomer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCustList;
        private System.Windows.Forms.DataGridView datagridCustomers;
        private System.Windows.Forms.Label lblEquipIDRent;
        private System.Windows.Forms.ComboBox cmbxEquipIDRent;
        private System.Windows.Forms.Button btnRentEquip;
        private System.Windows.Forms.Label lblEquipDateReturn;
        private System.Windows.Forms.Label lblEquipDateRented;
        private System.Windows.Forms.Label lblCustIDRent;
        private System.Windows.Forms.ComboBox cmbxCustIDRent;
        private System.Windows.Forms.Label lblRentEquip;
        private System.Windows.Forms.DateTimePicker dtpEquipDateReturn;
        private System.Windows.Forms.DateTimePicker dtpEquipDateRented;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCurrentRentals;
        private System.Windows.Forms.Label lblAvailEquip;
        private System.Windows.Forms.Label lblSortSales;
        private System.Windows.Forms.Button btnExportEquipment;
        private System.Windows.Forms.Button btnExportSales;
        private System.Windows.Forms.Label lblEquipListSort;
        private System.Windows.Forms.Label lblSalesListSort;
        private System.Windows.Forms.ComboBox cmbxSortEquipBy;
        private System.Windows.Forms.Label lblSortEquipBy;
        private System.Windows.Forms.DataGridView datagridEquipmentReport;
        private System.Windows.Forms.DataGridView datagridSalesReport;
        private System.Windows.Forms.ComboBox cmbxSortSalesBy;
        private VR_Dataset vR_Dataset;
        private System.Windows.Forms.BindingSource vREQUIPMENTBindingSource;
        private VR_DatasetTableAdapters.VR_EQUIPMENTTableAdapter vR_EQUIPMENTTableAdapter;
        private System.Windows.Forms.BindingSource rENTEQUIPEQUIPMENTIDBindingSource;
        private VR_DatasetTableAdapters.VR_RENTALEQUIPMENTTableAdapter vR_RENTALEQUIPMENTTableAdapter;
        private System.Windows.Forms.BindingSource vRCATEGORIESBindingSource;
        private VR_DatasetTableAdapters.VR_CATEGORIESTableAdapter vR_CATEGORIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eQUIPMENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vREQUIPMENTBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource vRCATEGORIESBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RemoveEquipmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_category_id_to_remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_RemoveCatategory;
    }
}

