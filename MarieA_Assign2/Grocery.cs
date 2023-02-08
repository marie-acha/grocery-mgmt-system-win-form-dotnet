using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MarieA_Assign2
{
    internal class Grocery
    {
        //Marie Acha

        //properties
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public int InitialQty { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }

        //computed read-only properties
        public int AvailableQty
        {
            get
            {
                return InitialQty - QtySold + QtyRestocked;
            }
        }

        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }

        //constructor
        public Grocery(string itemCode, string itemName, double unitPrice,
            int qtyMinForRestock, int initialQty, int qtySold, int qtyResocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyResocked;
        }

        //ToString()
        public override string ToString()
        {
            //using string.format() to align the items in the GroceryListBox
            string outputGroceryItems = String.Format("{0, -20}{1, -20}{2,-20}{3,-20}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}", 
                ItemCode, ItemName, UnitPrice.ToString("C2"),QtyMinForRestock,InitialQty,QtySold,QtyRestocked,AvailableQty,TotalSales.ToString("C2"));
            return outputGroceryItems;
        }

    }
}
