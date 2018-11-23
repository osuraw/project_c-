using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.Windows.Forms;

namespace Grocery_App
{
	class PurchaseOrder
	{
		DB obj2 = new DB();

		public PurchaseOrder()
		{
			obj2.reader1("SELECT * FROM Supplier","Supplier");
			//obj2.reader1("SELECT * FROM Stock", "Stock");
			obj2.reader1("SELECT * FROM PurchaseOrder", "PurchaseOrder");
		}

		public int GetOrderId()
		{
			int orderId = DB.DataSet1.Tables["PurchaseOrder"].Rows.Count;
			return orderId;
			
		}

		public object[] GetSupplierName()
		{
			int rowcount = DB.DataSet1.Tables["Supplier"].Rows.Count;
			object[] supplierName = new object[rowcount];

			for(int i=0; i<rowcount; i++)
			{
				supplierName[i] = DB.DataSet1.Tables["Supplier"].Rows[i][1];
			}

			return supplierName;
			
		}

		public void SendMail(string receipient , string description)
		{

			try
			{
				var fromAddress = "deniyayastoresproject@gmail.com";

				//var toAddress = receipient;
				var toAddress = receipient ;

				const string fromPassword = "@project1";

				string subject = "Purchase Order from DENIYAYA STORES";
				string body = "Please provide following products \n" + description;

				MailMessage mail = new MailMessage(fromAddress, toAddress, subject, body);
				SmtpClient client = new SmtpClient("smtp.gmail.com");
				client.Credentials = new NetworkCredential(fromAddress,fromPassword);
				client.Port = 587; //25----------------------------------------------------------
				client.EnableSsl = true;
				client.Send(mail);
				MessageBox.Show("Email sent");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
			}
		}

		

	}
}
