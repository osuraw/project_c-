using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Grocery_App
{
    public partial class UCSupplier : UserControl
    {
       // private Supplier supplier;
        //DB db;

        SqlConnection con = new SqlConnection(frmMain.mainquery);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public UCSupplier()
        {
            InitializeComponent();
            //supplier = new Supplier();
            //db = new DB();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && lblSupplierID.Text.Length != 0 && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtAccountDetails.Text != "")
            {
                int value;
                if (int.TryParse(lblSupplierID.Text, out value))
                {
                    int id = Int32.Parse(lblSupplierID.Text);
                    string name = txtSupplierName.Text;
                    string address = txtAddress.Text;
                    string telephone = txtPhone.Text;
                    string email = txtEmail.Text;
                    string account = txtAccountDetails.Text;

                    string query = "INSERT INTO supplier(id,name,address,telephone,email,bankaccountno) VALUES('" + id + "' , '" + name + "' , '" + address + "' , '" + telephone + "' , '" + email + "' , '" + account + "'   )";
                    con.Open();
                    SqlDataAdapter sq = new SqlDataAdapter(query, con);
                    sq.SelectCommand.ExecuteNonQuery();
                    con.Close();


                    txtSupplierName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    txtAccountDetails.Clear();
                    //lblSupplierID.Text = "";


                    string queryid = "select id from supplier where id = (select MAX(id) from supplier)";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(queryid, con);

                    int initialidsup = Convert.ToInt32(cmd1.ExecuteScalar());
                    initialidsup++;
                    string supid = Convert.ToString(initialidsup);
                    lblSupplierID.Text = supid;

                    ShowSupplierTable();

                    MessageBox.Show("successfully added supplier data");
                }
            }
            else
            {
                MessageBox.Show("Enter values");
            }

            //set new id for next supplier
            string quryid = "select id from supplier where id = (select MAX(id) from supplier)";
            con.Open();
            SqlCommand cmd = new SqlCommand(quryid, con);

            int initialid = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            initialid++;
            string sid = Convert.ToString(initialid);
            lblSupplierID.Text = sid;
        }
        public void ShowSupplierTable()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select id,name,address,telephone,email,bankaccountno from supplier", con);
            adapt.Fill(dt);
            dgvAddSuppliers.DataSource = dt;
            con.Close();
        }

        private void btnSupplierRemove_Click(object sender, EventArgs e)
        {
            string id = dgvAddSuppliers.CurrentRow.Cells[0].Value.ToString();
            con.Open();
            string querydel = "delete from supplier where id = '" + id + "' ";
            SqlDataAdapter del = new SqlDataAdapter(querydel, con);
            del.SelectCommand.ExecuteNonQuery();
            con.Close();
            ShowSupplierTable();

            string queryid = "select id from supplier where id = (select MAX(id) from supplier)";

            con.Open();
            SqlCommand cmd1 = new SqlCommand(queryid, con);
            int initialidsup = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            initialidsup++;
            string supid = Convert.ToString(initialidsup);
            lblSupplierID.Text = supid;

            txtSupplierName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtAccountDetails.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && lblSupplierID.Text.Length != 0 && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtAccountDetails.Text != "")
            {
                int id = Convert.ToInt32(lblSupplierID.Text);
                string name = txtSupplierName.Text;
                string address = txtAddress.Text;
                string telephone = txtPhone.Text;
                string email = txtEmail.Text;
                string account = txtAccountDetails.Text;

                string query = "UPDATE supplier SET name = '" + name + "' , address =  '" + address + "' , telephone = '" + telephone + "' , email = '" + email + "' , bankaccountno = '" + account + "' WHERE id = '" + id + "' ";
                con.Open();
                SqlDataAdapter sq = new SqlDataAdapter(query, con);
                sq.SelectCommand.ExecuteNonQuery();
                con.Close();

                txtSupplierName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtAccountDetails.Clear();
                //lblSupplierID.Text = "";

                string queryid = "select id from supplier where id = (select MAX(id) from supplier)";
                con.Open();
                SqlCommand cmd1 = new SqlCommand(queryid, con);

                int initialidsup = Convert.ToInt32(cmd1.ExecuteScalar());
                initialidsup++;
                string supid = Convert.ToString(initialidsup);
                lblSupplierID.Text = supid;

                ShowSupplierTable();

                MessageBox.Show("successfully updated supplier data");
            }
            else
            {
                MessageBox.Show("Enter values");
            }

            //set new id for next supplier
            string quryid = "select id from supplier where id = (select MAX(id) from supplier)";
            con.Open();
            SqlCommand cmd = new SqlCommand(quryid, con);

            int initialid = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            initialid++;
            string sid = Convert.ToString(initialid);
            lblSupplierID.Text = sid;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtPhone.Text.Length == 10)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"(^\w+@\w+)(\.com\z)"))
            {
                MessageBox.Show(txtEmail, "Invalid Email!");
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {

            }
            else
            {
                MessageBox.Show("Check your phone number again!");
            }
        }

        private void dgvAddSuppliers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            var cell = ((DataGridView)sender)[col, row];
            if (cell != null)
            {
                DataGridViewRow rows = cell.OwningRow;
                lblSupplierID.Text = rows.Cells["SupplierID"].Value.ToString();
                txtSupplierName.Text = rows.Cells["SupplierName"].Value.ToString();
                txtAddress.Text = rows.Cells["address"].Value.ToString();
                txtPhone.Text = rows.Cells["phone"].Value.ToString();
                txtEmail.Text = rows.Cells["email"].Value.ToString();
                txtAccountDetails.Text = rows.Cells["AccountDetail"].Value.ToString();
            }
        }

        private void dgvAddSuppliers_SelectionChanged(object sender, EventArgs e)
        {

        }
        public void SetSupplierUi()
        {
            string quryid = "select id from supplier where id = (select MAX(id) from supplier)";
            con.Open();
            SqlCommand cmd = new SqlCommand(quryid, con);
            int initialid = Convert.ToInt32(cmd.ExecuteScalar());
            initialid++;
            string sid = Convert.ToString(initialid);
            lblSupplierID.Text = sid;
            ShowSupplierTable();
        }
    }
}
