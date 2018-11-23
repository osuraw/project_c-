using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_App.StockManagement
{
    public partial class StockControl : UserControl
    {
        private string StockID;
        private int SupplierID;
        private DateTime Date;
        private float TotalAmount;

        
        public StockControl()
        {
            InitializeComponent();
            Stock.getStock();


            DataTable table = DB.DataSet1.Tables["Stock"];
            // DataRow newRow = table.NewRow();
          
            DataRow lastRow = table.Rows[table.Rows.Count - 1];
            lastRow.Delete();

            dgvStock.DataSource = DB.DataSet1.Tables["Stock"];
            
            
        }

        private void dgvPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockControl_Load(object sender, EventArgs e)
        {

			SqlConnection con = new SqlConnection(frmMain.mainquery);


			string queryid = "SELECT id from supplier";
			con.Open();
			SqlCommand cmd1 = new SqlCommand(queryid, con);

			SqlDataReader supplieridset = cmd1.ExecuteReader();

			while (supplieridset.Read())
			{
				cmbSupplierID.Items.Add(supplieridset.GetValue(0));
			}

			con.Close();



		}

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnAddUpdate.Text.ToString() == "ADD")
            {

                if (txtStockID.Text != ""  && cmbSupplierID.SelectedItem != null && dtpDate.Value != null && txtTotalAmount.Text != "")
                {


                    StockID = txtStockID.Text.ToString();
                    SupplierID = Int32.Parse(cmbSupplierID.SelectedItem.ToString());
                    Date = dtpDate.Value;
                    TotalAmount = float.Parse(txtTotalAmount.Text.ToString());

                    string[] rowTable = { StockID , SupplierID.ToString() , Date.ToString() , TotalAmount.ToString() };

                    Stock stock = new Stock();
                    stock.setStockID(StockID);
                    stock.setSupplierID(SupplierID);
                    stock.setDate(Date);
                    stock.setTotalPayment(TotalAmount);

                    stock.insertStock();

                    txtStockID.Clear();
                    cmbSupplierID.ResetText();
                    dtpDate.ResetText();
                    txtTotalAmount.Clear();


                    DataTable table = DB.DataSet1.Tables["Stock"];
                   // DataRow newRow = table.NewRow();
                    table.Rows.Add(rowTable);
                    

                   // dgvStock.Rows.Add(rowTable);    
                   //dgvStock.Update();
                   //Stock.getStock();
                }
                else
                {
					MessageBox.Show("Cannot Leave fields Empty!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
			}
            if(btnAddUpdate.Text == "UPDATE")
            {

				if (txtStockID.Text != "" && cmbSupplierID.SelectedItem != null && dtpDate.Value != null && txtTotalAmount.Text != "")
				{
					StockID = txtStockID.Text.ToString();
					SupplierID = Int32.Parse(cmbSupplierID.SelectedItem.ToString());
					Date = dtpDate.Value;
					TotalAmount = float.Parse(txtTotalAmount.Text.ToString());
					Stock.updateStock(StockID, SupplierID, Date, TotalAmount);

					DataTable table = DB.DataSet1.Tables["Stock"];

					string[] rowTable = { StockID, SupplierID.ToString(), Date.ToString(), TotalAmount.ToString() };

					string Exp = "StockId ='" + StockID + "'";
					DataRow row = table.Select(Exp).FirstOrDefault();
					row["StockId"] = StockID;
					row["SupplierId"] = SupplierID;
					row["Date"] = Date;
					row["PaidAmount"] = TotalAmount;

					//

					txtStockID.Clear();
					cmbSupplierID.ResetText();
					dtpDate.ResetText();
					txtTotalAmount.Clear();
				}
				else
				{
					MessageBox.Show("Cannot Leave fields Empty!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
			}

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            int rowindex = dgvStock.CurrentRow.Index;
            int columnindex = 0;
			if (rowindex == -1)
			{
				MessageBox.Show("Please Select Table Row!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else
			{
				string selectedStockID = dgvStock.Rows[rowindex].Cells[columnindex].Value.ToString();

				DataTable table = DB.DataSet1.Tables["Stock"];
				table.Rows.RemoveAt(rowindex);

				Stock.deleteStock(selectedStockID);
			}
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvStock.Rows[e.RowIndex];
            int rowIndex = dgvStock.Rows[e.RowIndex].Index;
            if(rowIndex != -1)
            {
                btnAddUpdate.Text = "UPDATE";

                txtStockID.Text = row.Cells[0].Value.ToString();
                cmbSupplierID.Text = row.Cells[1].Value.ToString();
                dtpDate.Text = row.Cells[2].Value.ToString();
                txtTotalAmount.Text = row.Cells[3].Value.ToString();
        

                
                //txtStockID.Text = dgvStock.SelectedRows[rowIndex].Cells[0].Value + string.Empty;
                //cmbSupplierID.SelectedItem = dgvStock.SelectedRows[rowIndex].Cells[1].Value + string.Empty;
                //dtpDate.Text = dgvStock.SelectedRows[rowIndex].Cells[2].Value + string.Empty;
                //txtTotalAmount.Text= dgvStock.SelectedRows[rowIndex].Cells[3].Value + string.Empty;


            }
        }

        private void StockControl_MouseClick(object sender, MouseEventArgs e)
        {
            dgvStock.ClearSelection();
            btnAddUpdate.Text = "ADD";



            txtStockID.Clear();
            cmbSupplierID.ResetText();
            dtpDate.ResetText();
            txtTotalAmount.Clear();

        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            StockDetailsControl stockDetailsControl = new StockDetailsControl();
            stockDetailsControl.Show();
            stockDetailsControl.Visible = true;

        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
          
        }

		private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}
	}
}
