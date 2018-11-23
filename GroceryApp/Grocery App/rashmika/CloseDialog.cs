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
    public partial class frmClose : Form
    {
        public frmClose()
        {
            InitializeComponent();
        }

        private void lblFormclose_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseyes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
