using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_App.StockManagement
{
    class Stock
    {
        private string stockID;
        private int supplierID;

        private float totalPayment;
        private DateTime date;

        static DB obj = new DB();
        

        public void setStockID(string pStockID)
        {
            this.stockID = pStockID;
        }

        public void setSupplierID(int pSupplierID)
        {
            this.supplierID = pSupplierID;
        }


        public void setTotalPayment(float pTotalPayment)
        {
            this.totalPayment = pTotalPayment;
        }

        public void setDate(DateTime pDate)
        {
            this.date = pDate;
        }

        public void insertStock()
        {
			object[] data = { stockID,supplierID, date, totalPayment};

			obj.command1("INSERT INTO Stock VALUES(@1,@2,@3,@4)", data);

            MessageBox.Show("Stocks Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Inserted Succesfully Message Box
        }

        public static void deleteStock(string sid)
        {
            obj.command1("DELETE FROM Stock WHERE StockId = @1", sid);

            MessageBox.Show("Stocks Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void updateStock(string pSID,int pSupplierID, DateTime pDate, float pTotalAmount)
        {
            object[] data = { pSupplierID, pDate, pTotalAmount, pSID };
            obj.command1("UPDATE Stock SET SupplierId = @1,Date = @2,PaidAmount = @3 WHERE StockId = @4", data);

            MessageBox.Show("Stocks Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }


        public static void getStock()
        {
            obj.reader4("SELECT * FROM Stock", "Stock");


        }




    }
}
