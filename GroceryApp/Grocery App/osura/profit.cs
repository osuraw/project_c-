using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_App
{
    public partial class profit : UserControl
    {
        profitclass profitclass;
        DateTime todate,fromdate;

        public profit()
        {
            InitializeComponent();
            profitclass = new profitclass();
            profitclass.getdata();
            int rowcount = DB.DataSet1.Tables["profit"].Rows.Count;
            dgvProfit.DataSource = DB.DataSet1.Tables["profit"];
            dgvinvoice.DataSource = DB.DataSet1.Tables["Invoice1"];
            dgvStock.DataSource = DB.DataSet1.Tables["stock"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblincome.Text != null)
            {
                int row = dgvProfit.RowCount;
                DB.DataSet1.Tables["profit"].Rows.Add(row, DateTime.Today, fromdate, todate, Convert.ToDouble(lblincome.Text), Convert.ToDouble(lblExpense.Text));
                profitclass.setdata();
                dgvProfit.DataSource = DB.DataSet1.Tables["profit"];
            }
            else
                MessageBox.Show("First view the profit for period", "Ifomation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value == DateTime.Today||dtpFrom.Value>DateTime.Today)
            {
                errfromdate.SetError(dtpFrom, "Set valide date");
            }
           else if(dtpTo.Value>=DateTime.Today)
            {
                errfromdate.Clear();
                errtodate.SetError(dtpTo, "Set valide date");
            }
            else
            {
                btnSave.Enabled = true;
                fromdate = dtpFrom.Value;
                todate = dtpTo.Value;
                errtodate.Clear();
                profitclass.getdata(fromdate,todate);
                double income = 0,expensec=0;
                foreach(DataGridViewRow row in dgvinvoice.Rows)
                {
                    income += Convert.ToDouble(row.Cells[2].Value);
                }
                lblincome.Text = income.ToString();
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    expensec += Convert.ToDouble(row.Cells[3].Value);
                }
                lblExpense.Text = expensec.ToString();
                lblprofit.Text = (income - expensec).ToString();                
            }
        }
    }
}
