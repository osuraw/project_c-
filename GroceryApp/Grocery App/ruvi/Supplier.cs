using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace Grocery_App
{
    class Supplier
    {
        DB obj = new DB();
        public Supplier()
        {
            obj.reader1("SELECT * FROM Supplier", "Supplier");
            obj.reader1("SELECT * FROM Product", "Product");          
        }

        public object[] GetSupplierID()
        {
            int rowcount = DB.DataSet1.Tables["Supplier"].Rows.Count;
            object[] supplierId = new object[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                supplierId[i] = DB.DataSet1.Tables["Supplier"].Rows[i][0];
            }
            return supplierId;
        }

        public object[] GetProductID()
        {
            int rowcount = DB.DataSet1.Tables["Product"].Rows.Count;
            object[] productno = new object[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                productno[i] = DB.DataSet1.Tables["Product"].Rows[i][1];
            }
            return productno;
        }

        

        public bool EmailValidation(string email)
        {
            try
            {
                var mail = new MailAddress(email);

                return mail.Host.EndsWith(".com");
            }
            catch
            {
                return false;
            }
        }

        public void Update()
        {
            

        }

        /*public void SupplierValidation()
        {

        }*/
    }
}
