namespace Grocery_App
{
    partial class profit
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
            this.dgvinvoice = new System.Windows.Forms.DataGridView();
            this.InviceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProfit = new System.Windows.Forms.DataGridView();
            this.profitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Stockid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblincome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblprofit = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.errfromdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errtodate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errfromdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtodate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinvoice
            // 
            this.dgvinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InviceNo,
            this.Date,
            this.Total,
            this.Discount});
            this.dgvinvoice.Location = new System.Drawing.Point(50, 455);
            this.dgvinvoice.Name = "dgvinvoice";
            this.dgvinvoice.RowTemplate.Height = 24;
            this.dgvinvoice.Size = new System.Drawing.Size(690, 319);
            this.dgvinvoice.TabIndex = 0;
            // 
            // InviceNo
            // 
            this.InviceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InviceNo.DataPropertyName = "InvoiceId";
            this.InviceNo.HeaderText = "INVOICE NO";
            this.InviceNo.Name = "InviceNo";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "DateTime";
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "DISCOUNT";
            this.Discount.Name = "Discount";
            // 
            // dgvProfit
            // 
            this.dgvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profitid,
            this.datepr,
            this.fdate,
            this.tdate,
            this.incomep,
            this.expensesp,
            this.profitval});
            this.dgvProfit.Location = new System.Drawing.Point(50, 118);
            this.dgvProfit.Name = "dgvProfit";
            this.dgvProfit.RowTemplate.Height = 24;
            this.dgvProfit.Size = new System.Drawing.Size(1400, 331);
            this.dgvProfit.TabIndex = 1;
            // 
            // profitid
            // 
            this.profitid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profitid.DataPropertyName = "GrossProfitId";
            this.profitid.HeaderText = "GROSS PROFIT ID";
            this.profitid.Name = "profitid";
            // 
            // datepr
            // 
            this.datepr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datepr.DataPropertyName = "Date";
            this.datepr.HeaderText = "DATE";
            this.datepr.Name = "datepr";
            // 
            // fdate
            // 
            this.fdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fdate.DataPropertyName = "FromDate";
            this.fdate.HeaderText = "FROM DATE";
            this.fdate.Name = "fdate";
            // 
            // tdate
            // 
            this.tdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tdate.DataPropertyName = "ToDate";
            this.tdate.HeaderText = "TO DATE";
            this.tdate.Name = "tdate";
            // 
            // incomep
            // 
            this.incomep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incomep.DataPropertyName = "TotalIncom";
            this.incomep.HeaderText = "INCOME";
            this.incomep.Name = "incomep";
            // 
            // expensesp
            // 
            this.expensesp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expensesp.DataPropertyName = "TotalExpense";
            this.expensesp.HeaderText = "EXPENSES";
            this.expensesp.Name = "expensesp";
            // 
            // profitval
            // 
            this.profitval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profitval.DataPropertyName = "profit";
            this.profitval.HeaderText = "GROSS PROFIT";
            this.profitval.Name = "profitval";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(398, 70);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(829, 70);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(669, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TO DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(201, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "FROM DATE";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnView.Location = new System.Drawing.Point(1189, 63);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 35);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(1130, 795);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(1300, 795);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "&PRINT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stockid,
            this.Supplierid,
            this.datest,
            this.paid});
            this.dgvStock.Location = new System.Drawing.Point(760, 455);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(690, 319);
            this.dgvStock.TabIndex = 9;
            // 
            // Stockid
            // 
            this.Stockid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stockid.DataPropertyName = "StockId";
            this.Stockid.HeaderText = "STOCK ID";
            this.Stockid.Name = "Stockid";
            // 
            // Supplierid
            // 
            this.Supplierid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplierid.DataPropertyName = "SupplierId";
            this.Supplierid.HeaderText = "SUPPLIER ID";
            this.Supplierid.Name = "Supplierid";
            // 
            // datest
            // 
            this.datest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datest.DataPropertyName = "Date";
            this.datest.HeaderText = "DATE";
            this.datest.Name = "datest";
            // 
            // paid
            // 
            this.paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid.DataPropertyName = "PaidAmount";
            this.paid.HeaderText = "PAID AMOUNT";
            this.paid.Name = "paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 795);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Incone ";
            // 
            // lblincome
            // 
            this.lblincome.AutoSize = true;
            this.lblincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblincome.Location = new System.Drawing.Point(199, 795);
            this.lblincome.Name = "lblincome";
            this.lblincome.Size = new System.Drawing.Size(53, 29);
            this.lblincome.TabIndex = 11;
            this.lblincome.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(336, 795);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Expenses";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExpense.Location = new System.Drawing.Point(526, 795);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(61, 29);
            this.lblExpense.TabIndex = 13;
            this.lblExpense.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(681, 795);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Profit";
            // 
            // lblprofit
            // 
            this.lblprofit.AutoSize = true;
            this.lblprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprofit.Location = new System.Drawing.Point(809, 795);
            this.lblprofit.Name = "lblprofit";
            this.lblprofit.Size = new System.Drawing.Size(77, 29);
            this.lblprofit.TabIndex = 15;
            this.lblprofit.Text = "--------";
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPOS.Location = new System.Drawing.Point(27, 27);
            this.lblPOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(143, 30);
            this.lblPOS.TabIndex = 16;
            this.lblPOS.Text = "Gross Profit";
            // 
            // errfromdate
            // 
            this.errfromdate.ContainerControl = this;
            // 
            // errtodate
            // 
            this.errtodate.ContainerControl = this;
            // 
            // profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.lblprofit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblincome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dgvProfit);
            this.Controls.Add(this.dgvinvoice);
            this.Name = "profit";
            this.Size = new System.Drawing.Size(1500, 850);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errfromdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtodate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvinvoice;
        private System.Windows.Forms.DataGridView dgvProfit;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblincome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblprofit;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomep;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitval;
        private System.Windows.Forms.DataGridViewTextBoxColumn InviceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn datest;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.ErrorProvider errfromdate;
        private System.Windows.Forms.ErrorProvider errtodate;
    }
}
