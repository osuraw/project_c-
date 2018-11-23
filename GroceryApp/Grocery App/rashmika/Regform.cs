using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_App
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btcRegformClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void btnRegiser_Click(object sender, EventArgs e)
        {
            if(txtFname.TextLength==0||txtFname.Text.Any(char.IsDigit))
            {
                errSeterror.SetError(txtFname, "Characters only");
            }
            else
            {
                errSeterror.Clear();
                if (txtLname.TextLength==0||txtLname.Text.Any(char.IsDigit))
                {
                    errSeterror.SetError(txtLname, "Characters only");
                }
                else
                {
                    errSeterror.Clear();
                    if(txtContact.TextLength==0||txtContact.Text.Any(char.IsLetter)||txtContact.TextLength!=10)
                    {
                        errSeterror.SetError(txtContact, "Check the Numbers");
                    }
                    else
                    {
                        errSeterror.Clear();
                        if (txtAddress.TextLength==0)
                        {
                            errSeterror.SetError(txtAddress, "Required");
                        }
                        else
                        {
                            errSeterror.Clear();
                            if (txtUname.TextLength==0)
                            {
                                errSeterror.SetError(txtUname, "Required");
                            }
                            else
                            {
                                errSeterror.Clear();
                                if (txtPw.TextLength==0)
                                {
                                    errSeterror.SetError(txtPw, "Required");
                                }
                                else
                                {
                                    if (txtCpw.TextLength == 0 | txtCpw.Text != txtPw.Text)
                                    {
                                        errSeterror.SetError(txtCpw, "Check Confirm Password");
                                    }
                                    else
                                    {
                                        errSeterror.Clear();
                                        if (radAdmin.Checked==false&&RadLimited.Checked==false)
                                        {
                                            errSeterror.SetError(groupBox1, "Required");
                                        }
                                        else
                                        {
                                            int usertype=0;
                                            if (radAdmin.Checked == true) usertype = 1;
                                            if (RadLimited.Checked == true) usertype = 2;
                                            try
                                            {
                                                DB dB = new DB();
                                                string query = "INSERT INTO [user]([firstname],[lastname],[mobile],[address],[username],[password],[usertype]) VALUES (@1,@2,@3,@4,@5,@6,@7)";
                                                int result = dB.command1(query, txtFname.Text, txtLname.Text, txtContact.Text, txtAddress.Text, txtUname.Text, txtPw.Text, usertype);
                                                if (result == 1)
                                                    MessageBox.Show("New User Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                else
                                                    MessageBox.Show("Error in Registration", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                            }
                                            catch(SqlException ex)
                                            {
                                                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            finally
                                            {
                                                txtFname.Clear();txtLname.Clear();txtAddress.Clear();txtContact.Clear();txtCpw.Clear();
                                                txtPw.Clear();txtUname.Clear();radAdmin.Checked = false;RadLimited.Checked = false;

                                            }
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
