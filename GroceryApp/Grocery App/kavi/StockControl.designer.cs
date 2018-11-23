namespace Grocery_App.StockManagement
{
    partial class StockControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStockID = new System.Windows.Forms.TextBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.btnAddUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dgvStock = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbSupplierID = new System.Windows.Forms.ComboBox();
			this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.project1DS = new Grocery_App.project1DS();
			this.project1DSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(55, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Stock ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(457, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(777, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total Amount";
			// 
			// txtStockID
			// 
			this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStockID.Location = new System.Drawing.Point(61, 235);
			this.txtStockID.Margin = new System.Windows.Forms.Padding(4);
			this.txtStockID.Name = "txtStockID";
			this.txtStockID.Size = new System.Drawing.Size(151, 37);
			this.txtStockID.TabIndex = 3;
			// 
			// dtpDate
			// 
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Location = new System.Drawing.Point(463, 235);
			this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(260, 37);
			this.dtpDate.TabIndex = 4;
			this.dtpDate.Value = new System.DateTime(2018, 7, 9, 22, 56, 4, 0);
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalAmount.Location = new System.Drawing.Point(784, 238);
			this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.Size = new System.Drawing.Size(245, 37);
			this.txtTotalAmount.TabIndex = 3;
			this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
			// 
			// btnAddUpdate
			// 
			this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAddUpdate.Location = new System.Drawing.Point(840, 311);
			this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddUpdate.Name = "btnAddUpdate";
			this.btnAddUpdate.Size = new System.Drawing.Size(189, 50);
			this.btnAddUpdate.TabIndex = 23;
			this.btnAddUpdate.Text = "ADD";
			this.btnAddUpdate.UseVisualStyleBackColor = true;
			this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDelete.Location = new System.Drawing.Point(840, 380);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(189, 50);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(52, 58);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(318, 49);
			this.lblTitle.TabIndex = 25;
			this.lblTitle.Text = "Purchase Stock";
			// 
			// dgvStock
			// 
			this.dgvStock.AllowUserToAddRows = false;
			this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStock.Location = new System.Drawing.Point(61, 471);
			this.dgvStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvStock.Name = "dgvStock";
			this.dgvStock.RowTemplate.Height = 24;
			this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStock.Size = new System.Drawing.Size(969, 150);
			this.dgvStock.TabIndex = 26;
			this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
			this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(236, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 32);
			this.label4.TabIndex = 2;
			this.label4.Text = "Supplier ID";
			// 
			// cmbSupplierID
			// 
			this.cmbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSupplierID.FormattingEnabled = true;
			this.cmbSupplierID.Location = new System.Drawing.Point(243, 233);
			this.cmbSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbSupplierID.Name = "cmbSupplierID";
			this.cmbSupplierID.Size = new System.Drawing.Size(183, 39);
			this.cmbSupplierID.TabIndex = 28;
			// 
			// sid
			// 
			this.sid.DataPropertyName = "StockId";
			this.sid.HeaderText = "StockID";
			this.sid.Name = "sid";
			this.sid.Width = 171;
			// 
			// project1DS
			// 
			this.project1DS.DataSetName = "project1DS";
			this.project1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// project1DSBindingSource
			// 
			this.project1DSBindingSource.DataSource = this.project1DS;
			this.project1DSBindingSource.Position = 0;
			// 
			// StockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
			this.Controls.Add(this.cmbSupplierID);
			this.Controls.Add(this.dgvStock);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddUpdate);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.txtTotalAmount);
			this.Controls.Add(this.txtStockID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "StockControl";
			this.Size = new System.Drawing.Size(1276, 716);
			this.Load += new System.EventHandler(this.StockControl_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StockControl_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.project1DSBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSupplierID;
		private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.BindingSource project1DSBindingSource;
        private project1DS project1DS;
    }
}
