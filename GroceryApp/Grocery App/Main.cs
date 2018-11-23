using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_App
{
    
    public partial class frmMain : Form
    {
        public static string mainquery = "Data Source=DESKTOP-B1UPLI9;Initial Catalog=project1-2018-7-15-5-7;Integrated Security=True";

		private PurchaseOrder purchaseOrder;
		//DB obj;

		SqlConnection con = new SqlConnection(mainquery);
		//SqlCommand cmd;
		SqlDataAdapter adapt;

		public frmMain(string [] data)
        {
            InitializeComponent();
			purchaseOrder = new PurchaseOrder();
			label10.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblUsername.Text = data[2];
		}

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnDashboard.Height;
            pnlIndicator.Top = btnDashboard.Top;
            this.profit1.BringToFront();
            profitclass profitclass = new profitclass();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnPOS.Height;
            pnlIndicator.Top = btnPOS.Top;
            this.UCInvoice1.BringToFront();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnSuppliers.Height;
            pnlIndicator.Top = btnSuppliers.Top;
            this.ucSupplier1.BringToFront();
            ucSupplier1.SetSupplierUi();
        }

        private void btnStocs_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnStocs.Height;
            pnlIndicator.Top = btnStocs.Top;
            this.stockControl1.BringToFront();
        }
        private void btnStockDetail_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnStockDetail.Height;
            pnlIndicator.Top = btnStockDetail.Top;
            this.stockDetailsControl1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmClose closedialog = new frmClose();
            closedialog.ShowDialog();
            //Close();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            frmRegistration reg = new frmRegistration();
            reg.Show();
        }
        #region product

        private void btnProduct_Click(object sender, EventArgs e)// ----------------product
        {
            pnlIndicator.Height = btnProduct.Height;
            pnlIndicator.Top = btnProduct.Top;
            this.pnlProduct.BringToFront();

            string queryId = "select id from Product where id = (select MAX(id) from Product)";
            con.Open();
            SqlCommand cmd = new SqlCommand(queryId, con);

            int initialId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            initialId++;

            string pId = Convert.ToString(initialId);

            lblProductId.Text = pId;

            ProductDisplayData();

        }

        private void btnOrder_Click(object sender, EventArgs e)
		{
			pnlIndicator.Height = btnOrder.Height;
			pnlIndicator.Top = btnOrder.Top;
			this.pnlOrder.BringToFront();
			//lblOrderId.Text = purchaseOrder.GetOrderId().ToString();
			lblShowOrderId.Text = purchaseOrder.GetOrderId().ToString();
			cmbSupplierName.Items.AddRange(purchaseOrder.GetSupplierName());
			lblPOShowId.Text = lblShowOrderId.Text;
			lblShowDate.Text = DateTime.Now.ToString("yyyy-MM-dd");


			string queryId = "select id,name,quantity,[ExisitingQuantity] from product where quantity>[ExisitingQuantity]";
			con.Open();
			SqlCommand cmd = new SqlCommand(queryId, con);
			SqlDataReader reader = cmd.ExecuteReader();
			while(reader.Read())
			{
				dgvPoShowMin.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
			}
//			int initialId = Convert.ToInt32(cmd.ExecuteScalar());
			con.Close();



		}

		//Add a product to database using add button in product
		private void btnAddNewProduct_Click(object sender, EventArgs e)
		{
			if (txtProductName.Text != null && txtCategory.Text != null && txtMinimumQuantity.Text != null && txtCategoryDetails.Text != null)
			{
				int value;
				if (int.TryParse(txtMinimumQuantity.Text, out value))
				{
					int id = Int32.Parse(lblProductId.Text);
					string name = txtProductName.Text;
					string category = txtCategory.Text;
					int minimumqty = Convert.ToInt32(txtMinimumQuantity.Text);
					string details = txtCategoryDetails.Text;


					string query = "INSERT INTO product(id,name,category,quantity,details) VALUES('" + id + "' , '" + name + "' , '" + category + "' , '" + minimumqty + "' , '" + details + "')";
					con.Open();
					SqlDataAdapter sq1 = new SqlDataAdapter(query, con);
					sq1.SelectCommand.ExecuteNonQuery();
					con.Close();

					ProductDisplayData();
					ClearData();

					string queryId = "select id from Product where id = (select MAX(id) from Product)";
					con.Open();
					SqlCommand cmd = new SqlCommand(queryId, con);

					int initialId = Convert.ToInt32(cmd.ExecuteScalar());
					con.Close();
					initialId++;

					string pId = Convert.ToString(initialId);

					lblProductId.Text = pId;

					MessageBox.Show("Add product Successfully");
				}
				else
				{
					MessageBox.Show("Enter numeric value for minimum quantity");
				}
				
			}
			else
			{
				MessageBox.Show("Enter valuess for missing fields");
			}

			
		}

		//Display Data in Product DataGridView  
		private void ProductDisplayData()
		{
			//con.Open();
			DataTable dt = new DataTable();
			adapt = new SqlDataAdapter("select * from product", con);
			adapt.Fill(dt);
			dgvProduct.DataSource = dt;
			//con.Close();
		}
		//Clear product Data  
		private void ClearData()
		{
			txtProductName.Text = "";
			txtCategory.Text = "";
			txtMinimumQuantity.Text = "";
			txtCategoryDetails.Text = "";
		}

		private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			//MessageBox.Show("AAA");
			lblShowSupplierId.Text = DB.DataSet1.Tables["Supplier"].Rows[cmbSupplierName.SelectedIndex][0].ToString();
			txtContactNo.Text = DB.DataSet1.Tables["Supplier"].Rows[cmbSupplierName.SelectedIndex][3].ToString();
			txtEmail.Text = DB.DataSet1.Tables["Supplier"].Rows[cmbSupplierName.SelectedIndex][4].ToString();
			txtAddress.Text = DB.DataSet1.Tables["Supplier"].Rows[cmbSupplierName.SelectedIndex][2].ToString();
			lblShowSupplierTo.Text = txtEmail.Text;

		}
	
		private void btnAdd_Click(object sender, EventArgs e)   //-----------add same products together
		{
			

			if(txtItemId.Text.Length != 0 && txtItemName.Text != null && nudQuantity.Value != 0)
			{
				string[] rowTable = { txtItemId.Text, txtItemName.Text, Convert.ToString(nudQuantity.Value) };
				dgvPurchaseOrder.Rows.Add(rowTable[0],rowTable[1],rowTable[2]);
				txtItemId.Clear();
				txtItemName.Clear();
				nudQuantity.Value = 0;
				
			}
			else
			{
				MessageBox.Show("Enter values");
			}

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{

			foreach (DataGridViewCell oneCell in dgvPurchaseOrder.SelectedCells)
			{
				if (oneCell.Selected)
					dgvPurchaseOrder.Rows.RemoveAt(oneCell.RowIndex);
			}
		}

		private void btnEmailPO_Click(object sender, EventArgs e)
		{
			purchaseOrder.SendMail(lblShowSupplierTo.Text , txtDescription.Text );
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			//delete row 
			String id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
			con.Open();
			String queryDelete = "delete from Product where id ='" + id + "'   ";
			SqlDataAdapter sqDelete = new SqlDataAdapter(queryDelete, con);
			sqDelete.SelectCommand.ExecuteNonQuery();
			ProductDisplayData();
			ClearData();

			//change product id
			string queryId = "select id from Product where id = (select MAX(id) from Product)";
			SqlCommand cmd = new SqlCommand(queryId, con);
			int initialId = Convert.ToInt32(cmd.ExecuteScalar());
			initialId++;
			string pId = Convert.ToString(initialId);
			lblProductId.Text = pId;

			con.Close();
			MessageBox.Show("Deleted Successfully");
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			//update selected row row
			if (txtProductName.Text != null && txtCategory.Text != null && txtMinimumQuantity.Text != null && txtCategoryDetails.Text != null)
			{
				int value;
				if (int.TryParse(txtMinimumQuantity.Text, out value))
				{
					int id = Int32.Parse(lblProductId.Text);
					string name = txtProductName.Text;
					string category = txtCategory.Text;
					int minimumqty = Convert.ToInt32(txtMinimumQuantity.Text);
					string details = txtCategoryDetails.Text;

					string query = "UPDATE product SET name = '" + name + "' , category = '" + category + "' , quantity = '" + minimumqty + "' , details ='" + details + "' WHERE id = '"+id+"' ";

					con.Open();
					SqlDataAdapter sda = new SqlDataAdapter(query , con);
					sda.SelectCommand.ExecuteNonQuery();
					con.Close();

					ProductDisplayData();
					ClearData();

					//set next id
					string queryId = "select id from Product where id = (select MAX(id) from Product)";
					con.Open();
					SqlCommand cmd = new SqlCommand(queryId, con);
					int initialId = Convert.ToInt32(cmd.ExecuteScalar());
					initialId++;
					string pId = Convert.ToString(initialId);
					lblProductId.Text = pId;
					con.Close();
					MessageBox.Show("updated product data", "Updated" , MessageBoxButtons.OK);
				}
			}

		}

		private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int col = e.ColumnIndex;
			int row = e.RowIndex;

			var cell = ((DataGridView)sender)[col, row];

			if (cell != null)
			{
				DataGridViewRow rows = cell.OwningRow;
				lblProductId.Text = rows.Cells["tblProductId"].Value.ToString();
				txtProductName.Text = rows.Cells["tblProductName"].Value.ToString();
				txtCategory.Text = rows.Cells["tblCategory"].Value.ToString();
				txtMinimumQuantity.Text = rows.Cells["tblMinimumQuantity"].Value.ToString();
				txtCategoryDetails.Text = rows.Cells["tblDetails"].Value.ToString();

			}
		}

		private void dgvPoShowMin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int col = e.ColumnIndex;
			int row = e.RowIndex;

			var cell = ((DataGridView)sender)[col, row];

			if (cell != null)
			{
				DataGridViewRow rows = cell.OwningRow;
				txtItemId.Text = rows.Cells["tblItemId"].Value.ToString();
				txtItemName.Text = rows.Cells["tblItemName"].Value.ToString();
				

			}
		}
        #endregion

      
    }
}
