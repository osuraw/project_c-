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
    public partial class frmPreloader : Form
    {
        public frmPreloader()
        {
            InitializeComponent();
            tmrPrealoader.Start();
            DB obj = new DB();
        }

        private void tmrPrealoader_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
