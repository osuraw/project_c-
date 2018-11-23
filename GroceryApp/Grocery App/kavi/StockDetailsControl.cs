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
    public partial class StockDetailsControl : UserControl
    {

		private int StockDetailID=1;

        private string StockID;
        private int ProductID;
        private float PurchasePrice;
        private float SellingPrice;
        private DateTime ManufactureDate;
        private DateTime ExpiryDate;
        private int Quantity;

		public int rowcount = -1;
		Boolean isValid=true;


		public StockDetailsControl()
        {
            InitializeComponent();

			
            StockDetails.getStockDetails();

            
            DataTable table = DB.DataSet1.Tables["StockDetail"];
		   
            //DataRow newRow = table.NewRow();

            DataRow lastRow = table.Rows[table.Rows.Count - 1];
            lastRow.Delete();

            dgvStockDetailGrid.DataSource = DB.DataSet1.Tables["StockDetail"];
		
			rowcount = DB.DataSet1.Tables["StockDetail"].Rows.Count;
			StockDetailID = rowcount + 1;
			lblStockDetailID.Text = StockDetailID.ToString();
			Console.WriteLine(rowcount);
			//for (int i=0; i<rowcount-1;i++ )
			//{
			//	dgvStockDetails.Rows.RemoveAt(i);
			//}


		}
		
											

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            //


            if (btnAddUpdate.Text.ToString() == "ADD PRODUCT")
            {

                if (txtStockID.Text != "" && cmbProductID.SelectedText != null && txtPPrice.Text != "" && txtSPrice.Text != "" && dtpMDate.Text != null && dtpEDate.Text !=null && txtQuantity.Text != "")
                {


                    StockID = txtStockID.Text.ToString();
                    ProductID = Int32.Parse(cmbProductID.SelectedItem.ToString());
                    PurchasePrice = float.Parse(txtPPrice.Text.ToString());
                    SellingPrice = float.Parse(txtSPrice.Text.ToString());
                    ManufactureDate = dtpMDate.Value;
                    ExpiryDate = dtpEDate.Value;
                    Quantity = Int32.Parse(txtQuantity.Text.ToString());


                    string[] rowTable = {StockDetailID.ToString(),StockID,ProductID.ToString(),PurchasePrice.ToString(),SellingPrice.ToString(),ManufactureDate.ToString(),ExpiryDate.ToString(),Quantity.ToString()};

                    StockDetails stockdetails = new StockDetails();

                    stockdetails.setStockDetailID(StockDetailID);

                    stockdetails.setStockID(StockID);
                    stockdetails.setProductID(ProductID);
                    stockdetails.setPurchasePrice(PurchasePrice);
                    stockdetails.setSellingPrice(SellingPrice);
                    stockdetails.setManufactureDate(ManufactureDate);
                    stockdetails.setExpiryDate(ExpiryDate);
                    stockdetails.setQuantity(Quantity);

                    stockdetails.insertStockDetails();


                    DataTable table = DB.DataSet1.Tables["StockDetail"];
                    // DataRow newRow = table.NewRow();
                    table.Rows.Add(rowTable);

					txtStockID.Clear();
					cmbProductID.ResetText();
					txtPPrice.ResetText();
					txtSPrice.Clear();
					dtpMDate.ResetText();
					dtpEDate.ResetText();
					txtQuantity.Clear();

					StockDetailID++;
					lblStockDetailID.Text = StockDetailID.ToString();
					// dgvStock.Rows.Add(rowTable);    
					//dgvStock.Update();
					//Stock.getStock();
				}
                else
                {
					MessageBox.Show("Cannot Leave fields Empty!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            
            if (btnAddUpdate.Text == "UPDATE PRODUCT")
            {


				if (txtStockID.Text != "" && cmbProductID.SelectedText != null && txtPPrice.Text != "" && txtSPrice.Text != "" && dtpMDate.Text != null && dtpEDate.Text != null && txtQuantity.Text != "")
				{
					int SDID=StockDetailID;
					StockDetailID = Int32.Parse(lblStockDetailID.Text.ToString());
					StockID = txtStockID.Text.ToString();
					ProductID = Int32.Parse(cmbProductID.SelectedItem.ToString());
					PurchasePrice = float.Parse(txtPPrice.Text.ToString());
					SellingPrice = float.Parse(txtSPrice.Text.ToString());
					ManufactureDate = dtpMDate.Value;
					ExpiryDate = dtpEDate.Value;
					Quantity = Int32.Parse(txtQuantity.Text.ToString());

					StockDetails.updateStockDetails(StockDetailID, StockID, ProductID, PurchasePrice, SellingPrice, ManufactureDate, ExpiryDate, Quantity);

					DataTable table = DB.DataSet1.Tables["StockDetail"];

					string[] rowTable = { StockDetailID.ToString(), StockID, ProductID.ToString(), PurchasePrice.ToString(), SellingPrice.ToString(), ManufactureDate.ToString(), ExpiryDate.ToString(), Quantity.ToString() };
					//Check
					string Exp = "StockDetailID ='" + StockDetailID + "'";
					DataRow row = table.Select(Exp).FirstOrDefault();

					row["StockId"] = StockID;
					row["ProductId"] = ProductID;
					row["PurchasePrice"] = PurchasePrice;
					row["SellingPrice"] = SellingPrice;
					row["SellingPrice"] = SellingPrice;
					row["ManufactureDate"] = ManufactureDate;
					row["ExpiryDate"] = ExpiryDate;
					row["Quantity"] = Quantity;


					lblStockDetailID.Text = SDID.ToString();

					txtStockID.Clear();
					cmbProductID.ResetText();
					txtPPrice.ResetText();
					txtSPrice.Clear();
					dtpMDate.ResetText();
					dtpEDate.ResetText();
					txtQuantity.Clear();
					//
				}
				else
				{
					MessageBox.Show("Cannot Leave fields Empty!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}


			}
            //
        }

        private void StockDetailsControl_Load(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(frmMain.mainquery);

			dgvStockDetailGrid.ClearSelection();
			string queryid = "SELECT id from Product";
			con.Open();
			SqlCommand cmd1 = new SqlCommand(queryid, con);

			SqlDataReader productidset = cmd1.ExecuteReader();

			while (productidset.Read())
			{
				cmbProductID.Items.Add(productidset.GetValue(0));
			}

			con.Close();



		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStockDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dgvStockDetailGrid.CurrentRow.Index;
            int columnindex = 0;
			//Testing
			Console.WriteLine(rowindex);
			if (rowindex == -1)
			{
				MessageBox.Show("Please Select Table Row!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else
			{
				string selectedStockDetailID = dgvStockDetailGrid.Rows[rowindex].Cells[columnindex].Value.ToString();
				int selectedStockDetailIDInt = Int32.Parse(selectedStockDetailID);
				//
				//selectedStockDetailIDInt = 1;
				DataTable table = DB.DataSet1.Tables["StockDetail"];

				table.Rows.RemoveAt(rowindex);

				//table.Rows.Clear();
				StockDetails.deleteStockDetails(selectedStockDetailIDInt);
			}

		}

		private void dgvStockDetailGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvStockDetailGrid.Rows[e.RowIndex];
			int rowIndex = dgvStockDetailGrid.Rows[e.RowIndex].Index;
			if (rowIndex != -1)
			{

				btnAddUpdate.Text = "UPDATE PRODUCT";
				lblStockDetailID.Text = row.Cells[0].Value.ToString();
				txtStockID.Text = row.Cells[1].Value.ToString();
				cmbProductID.Text = row.Cells[2].Value.ToString();
				txtPPrice.Text = row.Cells[3].Value.ToString();
				txtSPrice.Text = row.Cells[4].Value.ToString();
				dtpMDate.Text = row.Cells[5].Value.ToString();
				dtpEDate.Text = row.Cells[6].Value.ToString();
				txtQuantity.Text = row.Cells[7].Value.ToString();



				//txtStockID.Text = dgvStock.SelectedRows[rowIndex].Cells[0].Value + string.Empty;
				//cmbSupplierID.SelectedItem = dgvStock.SelectedRows[rowIndex].Cells[1].Value + string.Empty;
				//dtpDate.Text = dgvStock.SelectedRows[rowIndex].Cells[2].Value + string.Empty;
				//txtTotalAmount.Text= dgvStock.SelectedRows[rowIndex].Cells[3].Value + string.Empty;


			}
		}

		private void StockDetailsControl_Click(object sender, EventArgs e)
		{
			dgvStockDetailGrid.ClearSelection();
			btnAddUpdate.Text = "ADD PRODUCT";
			lblStockDetailID.Text = StockDetailID.ToString();
		}

		private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void txtSPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}
	}
}
