using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_App
{
    class InvoiceDetails
    {
        private DB obj = new DB();
        public InvoiceDetails()
        {
            DB.DataSet1.Tables.Add("InvoiceDetails");
            DB.DataSet1.Tables["InvoiceDetails"].Columns.Add("StockDetailId");
            DB.DataSet1.Tables["InvoiceDetails"].Columns.Add("InvoiceId");
            DB.DataSet1.Tables["InvoiceDetails"].Columns.Add("Quantity");
        }
        public void AddInvoiceDetail(params object [] data)
        {
            string query = "INSERT INTO InvoiceDetails VALUES ('" + data[0] + "','" + data[1] + "','" + data[3] + "')";
            obj.command(query);
            query = "UPDATE Product SET Quantity -='"+data[2]+"' WHERE Id ='"+data[2]+"' ";
            obj.command(query);
        }
    }
}
