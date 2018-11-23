using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_App
{
    class Invoice
    {
        private int billno;       
        string invoice = "SELECT * FROM Invoice";
        DB obj = new DB();
        public Invoice()// change
        {
            obj.reader1("SELECT * FROM Product", "Product");//
            obj.reader1("SELECT * FROM StockDetail", "StockDetail");//
            obj.reader3(ref invoice, "Invoice",1);
        }

        public string GetBillNo()
        {
            billno = DB.DataSet1.Tables["Invoice"].Rows.Count+1;
            return billno.ToString();
        }//done 

        public object[] GetStockId()
        {
            int rowcount = DB.DataSet1.Tables["StockDetail"].Rows.Count-1;
            object [] productno = new object[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                productno[i] = DB.DataSet1.Tables["StockDetail"].Rows[i][0];
            }
            return productno;
        }//done stock claa

        public object[] GetStockid(object serch)
        {
            object[] data= obj.reader2("SELECT StockDetailId from StockDetail where ProductId =(SELECT Id FROM Product WHERE Name = '"+serch+"')").ToArray();
            return data;
        }

        public object[] GetProductNameList()
        {
            int rowcount = DB.DataSet1.Tables["Product"].Rows.Count-1;
            object[] productname = new object[rowcount];          
                for (int i = 0; i < rowcount; i++)
                {
                    productname[i] = DB.DataSet1.Tables["Product"].Rows[i][1];
                }
            return productname;
        }//done product class

        public object GetProductName(object product)
        {
            int rowcount = DB.DataSet1.Tables["Product"].Rows.Count-1;
            int data =Convert.ToInt16( product);
            Console.WriteLine(DB.DataSet1.Tables["Product"].Rows[1][0].GetType());
            for (int i = 0; i < rowcount; i++)
            {
                if (data==DB.DataSet1.Tables["Product"].Rows[i].Field<Int16>(0))
                {
                    product = DB.DataSet1.Tables["Product"].Rows[i][1];
                    break;
                }
                else
                    Console.WriteLine(1);
            }
            return product;
        }//done  product class

        public object[] FindStockData(object read)// check ------------------------------------
        {
            object[] data = new object[3];
            int rowcount = DB.DataSet1.Tables["StockDetail"].Rows.Count-1;
            for (int i = 0; i < rowcount; i++)
            {
                Console.WriteLine(DB.DataSet1.Tables["StockDetail"].Rows[i][0].GetType());
                Int32 aa = Convert.ToInt16(read);
                if (aa==DB.DataSet1.Tables["StockDetail"].Rows[i].Field<Int32>(0))
                {
                    data[0] = DB.DataSet1.Tables["StockDetail"].Rows[i][2];//check
                    data[1] = DB.DataSet1.Tables["StockDetail"].Rows[i][4];
                    //data[2] = DB.DataSet1.Tables["StockDetail"].Rows[i][3];
                    data[2] = 0;
                    break;
                }
            }
            return data;
        }

        public void AddInvoice(double total,double netdiscount,double paid,double balance)//done
        {
            DB.DataSet1.Tables["Invoice"].Rows.Add(billno, 0, 0, (total-netdiscount), netdiscount, paid, balance, DateTime.Now);
            obj.reader3(ref invoice, "Invoice",0);
        }

    }
}

