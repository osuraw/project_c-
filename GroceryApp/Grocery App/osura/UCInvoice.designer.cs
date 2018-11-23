namespace Grocery_App
{
    partial class UCInvoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.lblNTotal1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.ldlPaid = new System.Windows.Forms.Label();
            this.lblNTotal = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbPOSProductName = new System.Windows.Forms.ComboBox();
            this.cmbPOSStockId = new System.Windows.Forms.ComboBox();
            this.lblDiscount1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPOSRemove = new System.Windows.Forms.Button();
            this.btnPosGenarate = new System.Windows.Forms.Button();
            this.btnAddPOS = new System.Windows.Forms.Button();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.errQtySId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPaid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProductname = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQtySId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProductname)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPOS
            // 
            this.pnlPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlPOS.Controls.Add(this.btnClear);
            this.pnlPOS.Controls.Add(this.btnIncome);
            this.pnlPOS.Controls.Add(this.txtPaid);
            this.pnlPOS.Controls.Add(this.lblBalance1);
            this.pnlPOS.Controls.Add(this.lblNTotal1);
            this.pnlPOS.Controls.Add(this.lblBalance);
            this.pnlPOS.Controls.Add(this.ldlPaid);
            this.pnlPOS.Controls.Add(this.lblNTotal);
            this.pnlPOS.Controls.Add(this.numQuantity);
            this.pnlPOS.Controls.Add(this.cmbPOSProductName);
            this.pnlPOS.Controls.Add(this.cmbPOSStockId);
            this.pnlPOS.Controls.Add(this.lblDiscount1);
            this.pnlPOS.Controls.Add(this.lblDiscount);
            this.pnlPOS.Controls.Add(this.lblTotal1);
            this.pnlPOS.Controls.Add(this.lblTotal);
            this.pnlPOS.Controls.Add(this.btnPOSRemove);
            this.pnlPOS.Controls.Add(this.btnPosGenarate);
            this.pnlPOS.Controls.Add(this.btnAddPOS);
            this.pnlPOS.Controls.Add(this.lblBillNo);
            this.pnlPOS.Controls.Add(this.dgvPOS);
            this.pnlPOS.Controls.Add(this.label4);
            this.pnlPOS.Controls.Add(this.label3);
            this.pnlPOS.Controls.Add(this.label2);
            this.pnlPOS.Controls.Add(this.label1);
            this.pnlPOS.Controls.Add(this.lblPOS);
            this.pnlPOS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPOS.Location = new System.Drawing.Point(0, 0);
            this.pnlPOS.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1500, 850);
            this.pnlPOS.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(1316, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIncome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIncome.Location = new System.Drawing.Point(66, 766);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(150, 50);
            this.btnIncome.TabIndex = 28;
            this.btnIncome.Text = "&Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // txtPaid
            // 
            this.txtPaid.Enabled = false;
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(968, 718);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(180, 30);
            this.txtPaid.TabIndex = 27;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // lblBalance1
            // 
            this.lblBalance1.AutoSize = true;
            this.lblBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblBalance1.Location = new System.Drawing.Point(1340, 716);
            this.lblBalance1.Name = "lblBalance1";
            this.lblBalance1.Size = new System.Drawing.Size(71, 32);
            this.lblBalance1.TabIndex = 26;
            this.lblBalance1.Text = "0.00";
            // 
            // lblNTotal1
            // 
            this.lblNTotal1.AutoSize = true;
            this.lblNTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblNTotal1.Location = new System.Drawing.Point(727, 718);
            this.lblNTotal1.Name = "lblNTotal1";
            this.lblNTotal1.Size = new System.Drawing.Size(71, 32);
            this.lblNTotal1.TabIndex = 25;
            this.lblNTotal1.Text = "0.00";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblBalance.Location = new System.Drawing.Point(1204, 715);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(119, 32);
            this.lblBalance.TabIndex = 24;
            this.lblBalance.Text = "Balance";
            // 
            // ldlPaid
            // 
            this.ldlPaid.AutoSize = true;
            this.ldlPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.ldlPaid.Location = new System.Drawing.Point(868, 718);
            this.ldlPaid.Name = "ldlPaid";
            this.ldlPaid.Size = new System.Drawing.Size(73, 32);
            this.ldlPaid.TabIndex = 23;
            this.ldlPaid.Text = "Paid";
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblNTotal.Location = new System.Drawing.Point(569, 718);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(152, 32);
            this.lblNTotal.TabIndex = 22;
            this.lblNTotal.Text = "Net Total : ";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(1126, 175);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 21;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // cmbPOSProductName
            // 
            this.cmbPOSProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPOSProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPOSProductName.FormattingEnabled = true;
            this.cmbPOSProductName.Location = new System.Drawing.Point(752, 174);
            this.cmbPOSProductName.Name = "cmbPOSProductName";
            this.cmbPOSProductName.Size = new System.Drawing.Size(121, 24);
            this.cmbPOSProductName.TabIndex = 20;
            this.cmbPOSProductName.SelectedIndexChanged += new System.EventHandler(this.cmbPOSProductName_SelectedIndexChanged);
            // 
            // cmbPOSStockId
            // 
            this.cmbPOSStockId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPOSStockId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPOSStockId.FormattingEnabled = true;
            this.cmbPOSStockId.Location = new System.Drawing.Point(251, 179);
            this.cmbPOSStockId.Name = "cmbPOSStockId";
            this.cmbPOSStockId.Size = new System.Drawing.Size(121, 24);
            this.cmbPOSStockId.TabIndex = 19;
            this.cmbPOSStockId.SelectedIndexChanged += new System.EventHandler(this.cmbPOSStockId_SelectedIndexChanged);
            // 
            // lblDiscount1
            // 
            this.lblDiscount1.AutoSize = true;
            this.lblDiscount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount1.Location = new System.Drawing.Point(455, 718);
            this.lblDiscount1.Name = "lblDiscount1";
            this.lblDiscount1.Size = new System.Drawing.Size(71, 32);
            this.lblDiscount1.TabIndex = 18;
            this.lblDiscount1.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(294, 718);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(155, 32);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "Discount  : ";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(160, 718);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(71, 32);
            this.lblTotal1.TabIndex = 16;
            this.lblTotal1.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(63, 718);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 32);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total : ";
            // 
            // btnPOSRemove
            // 
            this.btnPOSRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOSRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPOSRemove.Location = new System.Drawing.Point(1072, 775);
            this.btnPOSRemove.Name = "btnPOSRemove";
            this.btnPOSRemove.Size = new System.Drawing.Size(150, 50);
            this.btnPOSRemove.TabIndex = 14;
            this.btnPOSRemove.Text = "&Remove";
            this.btnPOSRemove.UseVisualStyleBackColor = true;
            this.btnPOSRemove.Click += new System.EventHandler(this.btnPOSRemove_Click);
            // 
            // btnPosGenarate
            // 
            this.btnPosGenarate.Enabled = false;
            this.btnPosGenarate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosGenarate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPosGenarate.Location = new System.Drawing.Point(1315, 775);
            this.btnPosGenarate.Name = "btnPosGenarate";
            this.btnPosGenarate.Size = new System.Drawing.Size(150, 50);
            this.btnPosGenarate.TabIndex = 12;
            this.btnPosGenarate.Text = "&Print";
            this.btnPosGenarate.UseVisualStyleBackColor = true;
            this.btnPosGenarate.Click += new System.EventHandler(this.btnPosGenarate_Click);
            // 
            // btnAddPOS
            // 
            this.btnAddPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPOS.Location = new System.Drawing.Point(1316, 128);
            this.btnAddPOS.Name = "btnAddPOS";
            this.btnAddPOS.Size = new System.Drawing.Size(150, 50);
            this.btnAddPOS.TabIndex = 22;
            this.btnAddPOS.Text = "&ADD";
            this.btnAddPOS.UseVisualStyleBackColor = true;
            this.btnAddPOS.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(245, 115);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(87, 32);
            this.lblBillNo.TabIndex = 6;
            this.lblBillNo.Text = "--------";
            // 
            // dgvPOS
            // 
            this.dgvPOS.AllowUserToAddRows = false;
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Product_ID,
            this.PName,
            this.UnitPrice,
            this.Quantity,
            this.Discount,
            this.DiscountAllowed,
            this.Total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPOS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPOS.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPOS.Location = new System.Drawing.Point(66, 293);
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.ReadOnly = true;
            this.dgvPOS.RowTemplate.Height = 24;
            this.dgvPOS.Size = new System.Drawing.Size(1399, 365);
            this.dgvPOS.TabIndex = 5;
            // 
            // ProductId
            // 
            this.ProductId.Frozen = true;
            this.ProductId.HeaderText = "Stock ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 125;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.Width = 125;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 125;
            // 
            // DiscountAllowed
            // 
            this.DiscountAllowed.HeaderText = "Discount Allowed";
            this.DiscountAllowed.Name = "DiscountAllowed";
            this.DiscountAllowed.ReadOnly = true;
            this.DiscountAllowed.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(942, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "BarCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill NO";
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPOS.Location = new System.Drawing.Point(27, 27);
            this.lblPOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(170, 30);
            this.lblPOS.TabIndex = 0;
            this.lblPOS.Text = "Point of Sales";
            // 
            // errQtySId
            // 
            this.errQtySId.ContainerControl = this;
            // 
            // errPaid
            // 
            this.errPaid.ContainerControl = this;
            // 
            // errProductname
            // 
            this.errProductname.ContainerControl = this;
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPOS);
            this.Name = "UCInvoice";
            this.Size = new System.Drawing.Size(1500, 850);
            this.pnlPOS.ResumeLayout(false);
            this.pnlPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQtySId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProductname)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPOS;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblBalance1;
        private System.Windows.Forms.Label lblNTotal1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label ldlPaid;
        private System.Windows.Forms.Label lblNTotal;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cmbPOSProductName;
        private System.Windows.Forms.ComboBox cmbPOSStockId;
        private System.Windows.Forms.Label lblDiscount1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPOSRemove;
        private System.Windows.Forms.Button btnPosGenarate;
        private System.Windows.Forms.Button btnAddPOS;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errQtySId;
        private System.Windows.Forms.ErrorProvider errPaid;
        private System.Windows.Forms.ErrorProvider errProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
