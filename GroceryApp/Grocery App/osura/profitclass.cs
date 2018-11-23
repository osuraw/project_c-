using System.Data;
using System;

namespace Grocery_App
{
    class profitclass
    {
        private string query;
        DB obj=new DB();


        public void getdata()
        {
            query = "SELECT * FROM [grossprofit]";
            obj.reader3(ref query, "profit", 1);
            claculate();
        }
        public void getdata(DateTime fdate,DateTime todate)
        {
            obj.reader1("select * from [stock] where [date]>'" + fdate + "' and [date]<'" + todate + "'", "stock");
            obj.reader1("select [InvoiceId],[DateTime],[Total],[Discount] from [invoice] where [DateTime]>'" + fdate + "' and [DateTime]<'" + todate + "'", "invice1");
        }
        public void claculate()
        {
            DB.DataSet1.Tables["profit"].Columns.Add("profit");
            for (int i = 0; i < DB.DataSet1.Tables["profit"].Rows.Count; i++)
            {
                double v1 = Convert.ToDouble(DB.DataSet1.Tables["profit"].Rows[i][4]);
                double v2 = Convert.ToDouble(DB.DataSet1.Tables["profit"].Rows[i][5]);
                DB.DataSet1.Tables["profit"].Rows[i]["profit"] = v1 - v2;               
            }
        }
        public void setdata()
        {
            obj.reader3(ref query, "profit", 0);
        }
    }
}
