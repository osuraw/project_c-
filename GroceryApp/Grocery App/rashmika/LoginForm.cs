using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB obj = new DB();
            string query = "Select [userid],[firstname],[usertype] from [user] where [username]='" + txtUsename.Text + "' and [password]='" + txtPassword.Text + "' ";
            string[] data =  obj.reader5(query);
            if (data == null)
            {
                MessageBox.Show("Login faild : Check your UserName and Password", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                frmMain systemOpen = new frmMain(data);
                systemOpen.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
