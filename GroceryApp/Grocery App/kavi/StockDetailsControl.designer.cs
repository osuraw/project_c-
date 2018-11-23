namespace Grocery_App.StockManagement
{
    partial class StockDetailsControl
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStockID = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.cmbProductID = new System.Windows.Forms.ComboBox();
			this.txtPPrice = new System.Windows.Forms.TextBox();
			this.txtSPrice = new System.Windows.Forms.TextBox();
			this.dtpMDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEDate = new System.Windows.Forms.DateTimePicker();
			this.btnAddUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.project1DSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.project1DS = new Grocery_App.project1DS();
			this.lblStockDetailID = new System.Windows.Forms.Label();
			this.stockDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stockDetailTableAdapter = new Grocery_App.project1DSTableAdapters.StockDetailTableAdapter();
			this.dgvStockDetailGrid = new System.Windows.Forms.DataGridView();
			this.project1DSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.stockDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStockDetailGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(64, 43);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(270, 49);
			this.lblTitle.TabIndex = 26;
			this.lblTitle.Text = "Stock Details";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(67, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 32);
			this.label1.TabIndex = 27;
			this.label1.Text = "Stock ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(349, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 32);
			this.label4.TabIndex = 28;
			this.label4.Text = "Product ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(733, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 32);
			this.label2.TabIndex = 28;
			this.label2.Text = "Quantity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(733, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 32);
			this.label3.TabIndex = 28;
			this.label3.Text = "Purchase Price";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(401, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 32);
			this.label5.TabIndex = 27;
			this.label5.Text = "Expiry Date ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(67, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(247, 32);
			this.label6.TabIndex = 27;
			this.label6.Text = "Manufacture Date ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(1040, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 32);
			this.label7.TabIndex = 28;
			this.label7.Text = "Selling Price";
			// 
			// txtStockID
			// 
			this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStockID.Location = new System.Drawing.Point(73, 226);
			this.txtStockID.Margin = new System.Windows.Forms.Padding(4);
			this.txtStockID.Name = "txtStockID";
			this.txtStockID.Size = new System.Drawing.Size(151, 37);
			this.txtStockID.TabIndex = 29;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.Location = new System.Drawing.Point(740, 340);
			this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(151, 37);
			this.txtQuantity.TabIndex = 29;
			this.txtQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			// 
			// cmbProductID
			// 
			this.cmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProductID.FormattingEnabled = true;
			this.cmbProductID.Location = new System.Drawing.Point(356, 226);
			this.cmbProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbProductID.Name = "cmbProductID";
			this.cmbProductID.Size = new System.Drawing.Size(183, 39);
			this.cmbProductID.TabIndex = 30;
			// 
			// txtPPrice
			// 
			this.txtPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPPrice.Location = new System.Drawing.Point(740, 228);
			this.txtPPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtPPrice.Name = "txtPPrice";
			this.txtPPrice.Size = new System.Drawing.Size(151, 37);
			this.txtPPrice.TabIndex = 29;
			this.txtPPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPrice_KeyPress);
			// 
			// txtSPrice
			// 
			this.txtSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSPrice.Location = new System.Drawing.Point(1047, 234);
			this.txtSPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtSPrice.Name = "txtSPrice";
			this.txtSPrice.Size = new System.Drawing.Size(151, 37);
			this.txtSPrice.TabIndex = 29;
			this.txtSPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSPrice_KeyPress);
			// 
			// dtpMDate
			// 
			this.dtpMDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMDate.Location = new System.Drawing.Point(73, 340);
			this.dtpMDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpMDate.Name = "dtpMDate";
			this.dtpMDate.Size = new System.Drawing.Size(260, 37);
			this.dtpMDate.TabIndex = 31;
			this.dtpMDate.Value = new System.DateTime(2018, 7, 9, 22, 56, 4, 0);
			// 
			// dtpEDate
			// 
			this.dtpEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEDate.Location = new System.Drawing.Point(389, 340);
			this.dtpEDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpEDate.Name = "dtpEDate";
			this.dtpEDate.Size = new System.Drawing.Size(260, 37);
			this.dtpEDate.TabIndex = 31;
			this.dtpEDate.Value = new System.DateTime(2018, 7, 9, 22, 56, 4, 0);
			// 
			// btnAddUpdate
			// 
			this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAddUpdate.Location = new System.Drawing.Point(739, 412);
			this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddUpdate.Name = "btnAddUpdate";
			this.btnAddUpdate.Size = new System.Drawing.Size(259, 50);
			this.btnAddUpdate.TabIndex = 32;
			this.btnAddUpdate.Text = "ADD PRODUCT";
			this.btnAddUpdate.UseVisualStyleBackColor = true;
			this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDelete.Location = new System.Drawing.Point(1049, 412);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(149, 50);
			this.btnDelete.TabIndex = 32;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// project1DSBindingSource
			// 
			this.project1DSBindingSource.DataSource = this.project1DS;
			this.project1DSBindingSource.Position = 0;
			// 
			// project1DS
			// 
			this.project1DS.DataSetName = "project1DS";
			this.project1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lblStockDetailID
			// 
			this.lblStockDetailID.AutoSize = true;
			this.lblStockDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStockDetailID.ForeColor = System.Drawing.Color.White;
			this.lblStockDetailID.Location = new System.Drawing.Point(67, 121);
			this.lblStockDetailID.Name = "lblStockDetailID";
			this.lblStockDetailID.Size = new System.Drawing.Size(194, 32);
			this.lblStockDetailID.TabIndex = 27;
			this.lblStockDetailID.Text = "StockDetail ID";
			// 
			// stockDetailBindingSource
			// 
			this.stockDetailBindingSource.DataMember = "StockDetail";
			this.stockDetailBindingSource.DataSource = this.project1DSBindingSource;
			// 
			// stockDetailTableAdapter
			// 
			this.stockDetailTableAdapter.ClearBeforeFill = true;
			// 
			// dgvStockDetailGrid
			// 
			this.dgvStockDetailGrid.AllowUserToAddRows = false;
			this.dgvStockDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStockDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStockDetailGrid.Location = new System.Drawing.Point(73, 545);
			this.dgvStockDetailGrid.MultiSelect = false;
			this.dgvStockDetailGrid.Name = "dgvStockDetailGrid";
			this.dgvStockDetailGrid.RowTemplate.Height = 24;
			this.dgvStockDetailGrid.Size = new System.Drawing.Size(1125, 150);
			this.dgvStockDetailGrid.TabIndex = 33;
			this.dgvStockDetailGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockDetailGrid_CellClick);
			// 
			// project1DSBindingSource1
			// 
			this.project1DSBindingSource1.DataSource = this.project1DS;
			this.project1DSBindingSource1.Position = 0;
			// 
			// stockDetailBindingSource1
			// 
			this.stockDetailBindingSource1.DataMember = "StockDetail";
			this.stockDetailBindingSource1.DataSource = this.project1DSBindingSource1;
			// 
			// StockDetailsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
			this.Controls.Add(this.dgvStockDetailGrid);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddUpdate);
			this.Controls.Add(this.dtpEDate);
			this.Controls.Add(this.dtpMDate);
			this.Controls.Add(this.cmbProductID);
			this.Controls.Add(this.txtPPrice);
			this.Controls.Add(this.txtSPrice);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtStockID);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblStockDetailID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitle);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "StockDetailsControl";
			this.Size = new System.Drawing.Size(1276, 742);
			this.Load += new System.EventHandler(this.StockDetailsControl_Load);
			this.Click += new System.EventHandler(this.StockDetailsControl_Click);
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStockDetailGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockDetailBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.DateTimePicker dtpMDate;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDate;
        private System.Windows.Forms.BindingSource project1DSBindingSource;
        private project1DS project1DS;
        private System.Windows.Forms.Label lblStockDetailID;
        private System.Windows.Forms.BindingSource stockDetailBindingSource;
        private project1DSTableAdapters.StockDetailTableAdapter stockDetailTableAdapter;
		private System.Windows.Forms.DataGridView dgvStockDetailGrid;
		private System.Windows.Forms.BindingSource project1DSBindingSource1;
		private System.Windows.Forms.BindingSource stockDetailBindingSource1;
	}
}
