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
    public partial class UCInvoice : UserControl
    {
        int flag = 0;
        private Invoice invoice;
        string userid,username;
        double total=0,netdiscount=0, balance = 0,totalincome = 0, paid;
        private InvoiceDetails invoiceDetails;
        object[] data = new object[3];

        public UCInvoice()
        {
            InitializeComponent();
            invoice = new Invoice();
            invoiceDetails = new InvoiceDetails();
            FillInvoice();
            userid = "0";
            username = "1111";
        }

        public void FillInvoice()
        {
            lblBillNo.Text = invoice.GetBillNo();
            cmbPOSStockId.Items.AddRange(invoice.GetStockId());
            cmbPOSProductName.Items.AddRange(invoice.GetProductNameList());
        }

        public void clear()
        {
            cmbPOSProductName.Items.Clear();
            cmbPOSStockId.Items.Clear();
            cmbPOSStockId.ResetText();
            cmbPOSProductName.ResetText();
            numQuantity.Value = 0;
            cmbPOSProductName.Enabled = true;
            FillInvoice();
            flag = 0;
        }

        private void cmbPOSStockId_SelectedIndexChanged(object sender, EventArgs e)
        {
            errQtySId.Clear();
            Console.WriteLine(cmbPOSStockId.SelectedItem.GetType());
            data = invoice.FindStockData(cmbPOSStockId.SelectedItem);
            if(flag==0)
            cmbPOSProductName.Enabled = false;
            flag = 1;
            cmbPOSProductName.Text = invoice.GetProductName(data[0]).ToString();
        }

        private void cmbPOSProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                cmbPOSStockId.Items.Clear();
                cmbPOSStockId.ResetText();
                cmbPOSStockId.Items.AddRange(invoice.GetStockid(cmbPOSProductName.SelectedItem));
                cmbPOSStockId.DroppedDown = true;
                //flag = 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPOSStockId.SelectedItem!=null)
            {
                int flag=0;
                errQtySId.Clear();
                if (numQuantity.Value>0)
                {
                    errQtySId.Clear();
                    int units = Convert.ToInt16(numQuantity.Value);
                    double price = Convert.ToDouble(data[1]) * units;
                    double discount = (Convert.ToInt16(data[2]) / 100) * price;
                    total += price;
                    netdiscount += discount;
                    foreach (DataGridViewRow row in dgvPOS.Rows)
                    {
                        if( row.Cells[0].Value.Equals(cmbPOSStockId.SelectedItem))
                        {
                            flag = 1;
                            row.Cells[4].Value =Convert.ToInt16(row.Cells[4].Value)+units;
                            row.Cells[6].Value = Convert.ToDouble(row.Cells[6].Value) + discount;
                            row.Cells[7].Value = Convert.ToDouble(row.Cells[7].Value) +price;
                        }
                    }
                    if(flag==0)
                        dgvPOS.Rows.Add(cmbPOSStockId.SelectedItem,data[0], cmbPOSProductName.SelectedItem, data[1], numQuantity.Value, data[2],  discount, price );

                    lblTotal1.Text = total.ToString();
                    lblDiscount1.Text = netdiscount.ToString();
                    lblNTotal1.Text = (total-netdiscount).ToString();
                    txtPaid.Enabled = true;
                    btnPosGenarate.Enabled = true;
                    clear();
                    flag = 0;
                }
                else
                {
                    errQtySId.SetError(numQuantity, "Select Quantity");
                }
            }
            else
            {
                errQtySId.SetError(cmbPOSStockId, "Selsect StockID");
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtPaid.Text.Length != 0)
            {
                if (double.TryParse(txtPaid.Text, out paid))
                {
                    errPaid.Clear();
                    balance = paid - double.Parse(lblNTotal1.Text);
                    lblBalance1.Text = balance.ToString();
                }
                else
                {
                    errPaid.SetError(txtPaid, "Numbers Only");
                    txtPaid.Clear();
                }
            }
        }

        private void btnPosGenarate_Click(object sender, EventArgs e)
        {
            if (balance >= 0&& txtPaid.TextLength!=0)
            {
                errQtySId.Clear();
                invoice.AddInvoice(total,netdiscount,paid,balance);
                totalincome = totalincome + total - netdiscount;
                lblBillNo.Text = invoice.GetBillNo();
                for (int i = 0; i < dgvPOS.RowCount; i++)
                {
                    invoiceDetails.AddInvoiceDetail(lblBillNo.Text,dgvPOS.Rows[i].Cells[0].Value, dgvPOS.Rows[i].Cells[1].Value, dgvPOS.Rows[i].Cells[4].Value);
                }
                total = 0;netdiscount = 0;
                clear();
                lblBillNo.Text = invoice.GetBillNo();
                dgvPOS.Rows.Clear();
                lblNTotal1.Text = "0.00"; lblDiscount1.Text = "0.00"; lblBalance1.Text = "0.00";
                lblTotal1.Text = "0.00"; btnPosGenarate.Enabled = false; txtPaid.Clear();                
            }
            else
            {
                errPaid.SetError(txtPaid, "Check payment");
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User ID : "+userid+"\nUser Name : "+username+"\nCollection for session : "+totalincome,"Session Income",MessageBoxButtons.OK);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            errQtySId.Clear();
        }

        private void btnPOSRemove_Click(object sender, EventArgs e)//----------------------------------------
        {
            foreach (DataGridViewRow row in dgvPOS.SelectedRows)
            {
                double price = Convert.ToDouble( row.Cells[7].Value);
                double discount = Convert.ToDouble(row.Cells[6].Value);
                Console.WriteLine( price);
                Console.WriteLine(discount);
                total -= price;
                netdiscount -= discount;
                lblDiscount1.Text = netdiscount.ToString();
                lblTotal1.Text = total.ToString();
                lblNTotal1.Text = (total-netdiscount).ToString();
                dgvPOS.Rows.Remove(row);
            }
            if (total == 0)
                btnPosGenarate.Enabled = false;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            errQtySId.Clear();
        }
    }
}
