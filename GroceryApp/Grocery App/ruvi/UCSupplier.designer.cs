namespace Grocery_App
{
    partial class UCSupplier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.grpSupplierItemDetails = new System.Windows.Forms.GroupBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblNoOfProducts = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grpSupplierDetails = new System.Windows.Forms.GroupBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dgvAddSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAccountDetails = new System.Windows.Forms.TextBox();
            this.btnSupplierRemove = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.pnlSuppliers.SuspendLayout();
            this.grpSupplierItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlSuppliers.Controls.Add(this.grpSupplierItemDetails);
            this.pnlSuppliers.Controls.Add(this.grpSupplierDetails);
            this.pnlSuppliers.Location = new System.Drawing.Point(0, 0);
            this.pnlSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(1500, 860);
            this.pnlSuppliers.TabIndex = 3;
            // 
            // grpSupplierItemDetails
            // 
            this.grpSupplierItemDetails.Controls.Add(this.cmbProductName);
            this.grpSupplierItemDetails.Controls.Add(this.txtProductID);
            this.grpSupplierItemDetails.Controls.Add(this.lblNoOfProducts);
            this.grpSupplierItemDetails.Controls.Add(this.dgvProducts);
            this.grpSupplierItemDetails.Controls.Add(this.label17);
            this.grpSupplierItemDetails.Controls.Add(this.label18);
            this.grpSupplierItemDetails.Controls.Add(this.btnRemoveProduct);
            this.grpSupplierItemDetails.Controls.Add(this.btnAddProduct);
            this.grpSupplierItemDetails.Controls.Add(this.lblSupplierName);
            this.grpSupplierItemDetails.Controls.Add(this.label19);
            this.grpSupplierItemDetails.Controls.Add(this.label20);
            this.grpSupplierItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSupplierItemDetails.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpSupplierItemDetails.Location = new System.Drawing.Point(880, 27);
            this.grpSupplierItemDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpSupplierItemDetails.Name = "grpSupplierItemDetails";
            this.grpSupplierItemDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpSupplierItemDetails.Size = new System.Drawing.Size(569, 559);
            this.grpSupplierItemDetails.TabIndex = 38;
            this.grpSupplierItemDetails.TabStop = false;
            this.grpSupplierItemDetails.Text = "Supplier Item Details";
            this.grpSupplierItemDetails.Visible = false;
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(188, 193);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(239, 33);
            this.cmbProductName.TabIndex = 51;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(185, 143);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(132, 30);
            this.txtProductID.TabIndex = 50;
            // 
            // lblNoOfProducts
            // 
            this.lblNoOfProducts.AutoSize = true;
            this.lblNoOfProducts.Location = new System.Drawing.Point(181, 95);
            this.lblNoOfProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfProducts.Name = "lblNoOfProducts";
            this.lblNoOfProducts.Size = new System.Drawing.Size(60, 25);
            this.lblNoOfProducts.TabIndex = 49;
            this.lblNoOfProducts.Text = "____";
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductName});
            this.dgvProducts.Location = new System.Drawing.Point(67, 341);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(457, 176);
            this.dgvProducts.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 201);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Product Name";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(87, 146);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 43;
            this.label18.Text = "Product ID";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemoveProduct.Location = new System.Drawing.Point(424, 263);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(100, 37);
            this.btnRemoveProduct.TabIndex = 42;
            this.btnRemoveProduct.Text = "&Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddProduct.Location = new System.Drawing.Point(281, 263);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 37);
            this.btnAddProduct.TabIndex = 41;
            this.btnAddProduct.Text = "&Add ";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(181, 55);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(144, 18);
            this.lblSupplierName.TabIndex = 40;
            this.lblSupplierName.Text = "_________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 96);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "No. of Products";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 55);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "Supplier Name";
            // 
            // grpSupplierDetails
            // 
            this.grpSupplierDetails.Controls.Add(this.lblSupplierID);
            this.grpSupplierDetails.Controls.Add(this.btnAddSupplier);
            this.grpSupplierDetails.Controls.Add(this.dgvAddSuppliers);
            this.grpSupplierDetails.Controls.Add(this.label10);
            this.grpSupplierDetails.Controls.Add(this.btnUpdate);
            this.grpSupplierDetails.Controls.Add(this.txtAccountDetails);
            this.grpSupplierDetails.Controls.Add(this.btnSupplierRemove);
            this.grpSupplierDetails.Controls.Add(this.txtEmail);
            this.grpSupplierDetails.Controls.Add(this.txtPhone);
            this.grpSupplierDetails.Controls.Add(this.txtAddress);
            this.grpSupplierDetails.Controls.Add(this.label11);
            this.grpSupplierDetails.Controls.Add(this.label13);
            this.grpSupplierDetails.Controls.Add(this.label14);
            this.grpSupplierDetails.Controls.Add(this.label15);
            this.grpSupplierDetails.Controls.Add(this.label16);
            this.grpSupplierDetails.Controls.Add(this.txtSupplierName);
            this.grpSupplierDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSupplierDetails.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpSupplierDetails.Location = new System.Drawing.Point(67, 27);
            this.grpSupplierDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpSupplierDetails.Name = "grpSupplierDetails";
            this.grpSupplierDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpSupplierDetails.Size = new System.Drawing.Size(771, 802);
            this.grpSupplierDetails.TabIndex = 37;
            this.grpSupplierDetails.TabStop = false;
            this.grpSupplierDetails.Text = "Supplier Details";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(197, 50);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(80, 25);
            this.lblSupplierID.TabIndex = 51;
            this.lblSupplierID.Text = "SUP00";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddSupplier.Location = new System.Drawing.Point(615, 108);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(100, 37);
            this.btnAddSupplier.TabIndex = 34;
            this.btnAddSupplier.Text = "&Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // dgvAddSuppliers
            // 
            this.dgvAddSuppliers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAddSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.SupplierName,
            this.Address,
            this.Phone,
            this.Email,
            this.AccountDetail});
            this.dgvAddSuppliers.Location = new System.Drawing.Point(32, 450);
            this.dgvAddSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAddSuppliers.Name = "dgvAddSuppliers";
            this.dgvAddSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddSuppliers.Size = new System.Drawing.Size(705, 185);
            this.dgvAddSuppliers.TabIndex = 33;
            this.dgvAddSuppliers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddSuppliers_CellMouseClick);
            this.dgvAddSuppliers.SelectionChanged += new System.EventHandler(this.dgvAddSuppliers_SelectionChanged);
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "ID";
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.Name = "SupplierID";
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "name";
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "telephone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // AccountDetail
            // 
            this.AccountDetail.DataPropertyName = "bankaccountno";
            this.AccountDetail.HeaderText = "AccountDetail";
            this.AccountDetail.Name = "AccountDetail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Account Details";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdate.Location = new System.Drawing.Point(615, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAccountDetails
            // 
            this.txtAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountDetails.Location = new System.Drawing.Point(197, 347);
            this.txtAccountDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountDetails.Multiline = true;
            this.txtAccountDetails.Name = "txtAccountDetails";
            this.txtAccountDetails.Size = new System.Drawing.Size(336, 69);
            this.txtAccountDetails.TabIndex = 49;
            // 
            // btnSupplierRemove
            // 
            this.btnSupplierRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierRemove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSupplierRemove.Location = new System.Drawing.Point(615, 166);
            this.btnSupplierRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupplierRemove.Name = "btnSupplierRemove";
            this.btnSupplierRemove.Size = new System.Drawing.Size(100, 37);
            this.btnSupplierRemove.TabIndex = 36;
            this.btnSupplierRemove.Text = "&Remove";
            this.btnSupplierRemove.UseVisualStyleBackColor = true;
            this.btnSupplierRemove.Click += new System.EventHandler(this.btnSupplierRemove_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 295);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 24);
            this.txtEmail.TabIndex = 48;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(197, 244);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 24);
            this.txtPhone.TabIndex = 46;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 146);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(336, 77);
            this.txtAddress.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "E-mail";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(131, 244);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Phone";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(115, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Address";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(95, 52);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "Supplier ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(197, 95);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(336, 24);
            this.txtSupplierName.TabIndex = 37;
            // 
            // UCSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlSuppliers);
            this.Name = "UCSupplier";
            this.Size = new System.Drawing.Size(1500, 860);
            this.pnlSuppliers.ResumeLayout(false);
            this.grpSupplierItemDetails.ResumeLayout(false);
            this.grpSupplierItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpSupplierDetails.ResumeLayout(false);
            this.grpSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.GroupBox grpSupplierItemDetails;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblNoOfProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRemoveProduct;
        public System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpSupplierDetails;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Button btnAddSupplier;
        public System.Windows.Forms.DataGridView dgvAddSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetail;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtAccountDetails;
        private System.Windows.Forms.Button btnSupplierRemove;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtSupplierName;
    }
}
