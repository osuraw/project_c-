using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_App.StockManagement
{
    class StockDetails
    {
        private int stockDetailID;

        private string stockID;
        private int productID;
        private float purchasePrice;
        private float sellingPrice;
        private DateTime manufactureDate;
        private DateTime expiryDate;
        private int Quantity;

        static DB obj = new DB();

        public void setStockDetailID(int pStockDetailID)
        {
            this.stockDetailID = pStockDetailID;
        }

        public void setStockID(string pStockID)
        {
            this.stockID = pStockID;
        }

        public void setProductID(int pProductID)
        {
            this.productID = pProductID;
        }

        public void setPurchasePrice(float pPurchasePrice)
        {
            this.purchasePrice = pPurchasePrice;
        }

        public void setSellingPrice(float pSellingPrice)
        {
            this.sellingPrice = pSellingPrice;
        }

        public void setManufactureDate(DateTime pManufactureDate)
        {
            this.manufactureDate = pManufactureDate;
        }

        public void setExpiryDate(DateTime pExpiryDate)
        {
            this.expiryDate = pExpiryDate;
        }

        public void setQuantity(int pQuantity)
        {
            this.Quantity = pQuantity;
        }

        public void insertStockDetails()
        {
            object[] data = { stockDetailID,stockID, productID, purchasePrice, sellingPrice, manufactureDate, expiryDate, Quantity };
            Console.WriteLine(stockDetailID +" " +stockID+" "+ productID+" "+ purchasePrice+" "+ sellingPrice+" "+ manufactureDate+" "+expiryDate+" "+ Quantity);
            obj.command1("INSERT INTO StockDetail VALUES(@1,@2,@3,@4,@5,@6,@7,@8)", data);

            obj.command1("UPDATE Product SET ExisitingQuantity += @8 WHERE Id = @3", data);

            MessageBox.Show("Stock Details Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Inserted Succesfully Message Box
        }

        public static void deleteStockDetails(int pStockDetailID)
        {
            obj.command1("DELETE FROM StockDetail WHERE StockDetailID = @1", pStockDetailID);

            MessageBox.Show("Stock Details Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void updateStockDetails(int pStockDetailID, string pStockID, int pProductID, float pPurchasePrice, float pSellingPrice, DateTime pManufactureDate, DateTime pExpiryDate, int pQuantity)
        {
            object[] data = { pStockID, pProductID, pPurchasePrice, pSellingPrice, pManufactureDate, pExpiryDate, pQuantity,pStockDetailID};

            obj.command1("UPDATE StockDetail SET StockID = @1,ProductID = @2,PurchasePrice = @3 ,SellingPrice = @4 ,ManufactureDate = @5 ,ExpiryDate = @6 ,Quantity = @7  WHERE StockDetailID = @8", data);


            MessageBox.Show("Stock Details Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        public static void getStockDetails()
        {
            obj.reader4("SELECT * FROM StockDetail", "StockDetail");
        }



    }
}
