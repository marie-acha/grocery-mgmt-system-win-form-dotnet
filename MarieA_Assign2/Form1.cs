using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.IO; //to access StreamReader and StreamWriter
using System.Collections;

namespace MarieA_Assign2
{
    public partial class GroceryForm : Form
    {
        //CSIS 1175, Section 003
        //Marie Acha
        //300363065
        List<Grocery> GroceryList = new List<Grocery>();

        public GroceryForm()
        {
            InitializeComponent();
        }

        //event handler for 'Load Data' button
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            GroceryList.Clear();
            try
            {
                using (StreamReader loadGroceryDataStream = new StreamReader("superstore.csv"))
                {
                    string eachItem;
                    if (!loadGroceryDataStream.EndOfStream)
                    {
                        eachItem = loadGroceryDataStream.ReadLine();
                        MessageBox.Show(eachItem);
                    }
                    while (!loadGroceryDataStream.EndOfStream)
                    {
                        eachItem = loadGroceryDataStream.ReadLine();
                        string[] eachGroceryFields = eachItem.Split(',');
                        string itemCode = eachGroceryFields[0];
                        string itemName = eachGroceryFields[1];
                        string unitPriceStr = eachGroceryFields[2]; //to be parsed to double afterwards
                        string qtyMinForRestockStr = eachGroceryFields[3]; //to be parsed to int afterwards
                        string initialQtyStr = eachGroceryFields[4]; //to be parsed to int afterwards
                        string qtySoldStr = eachGroceryFields[5]; //to be parsed to int afterwards
                        string qtyRestockedStr = eachGroceryFields[6]; //to be parsed to int afterwards
                        //parsing
                        double.TryParse(unitPriceStr, out double unitPrice);
                        int.TryParse(qtyMinForRestockStr, out int qtyMinForRestock);
                        int.TryParse(initialQtyStr, out int initialQty);
                        int.TryParse(qtySoldStr, out int qtySold);
                        int.TryParse(qtyRestockedStr, out int qtyRestocked);
                        //creating the object using the items fetched in the csv.file
                        Grocery eachGroceryItem = new Grocery(itemCode, itemName, unitPrice,
                            qtyMinForRestock, initialQty, qtySold, qtyRestocked);
                        //adding to GroceryList
                        GroceryList.Add(eachGroceryItem);
                    }
                }
                LoadAllItemsToListBox(); //method to load all grocery items on the GroceryListBox
                StatusLabel.Text = "Loaded " + GroceryList.Count + " items from the input file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to load all grocery items (including additional columns: availableQty & sales) on GroceryListBox
        private void LoadAllItemsToListBox()
        {
            GroceryListBox.Items.Clear();
            //adding the header using String.Format() to align the items
            GroceryListBox.Items.Add(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}", 
                "ItemId","ItemName","UnitPrice","QtyMinForRestock","InitialQty","QtySold","QtyRestocked","AvailableQty","Sales"));
            foreach(Grocery groceryItem in GroceryList)
            {
                GroceryListBox.Items.Add(groceryItem);
            }
        }

        //event handler for 'Update Sold Qty for Selected Item' button 
        private void UpdateSoldBtn_Click(object sender, EventArgs e)
        {
           
            int labelIndex = GroceryListBox.SelectedIndex;
            if (labelIndex <= 0)
            {
                //when headerline is clicked
                StatusLabel.Text = "Please selected a grocery item to increment sold qty";
            }
            else if (GroceryList.Count > 0)
            {
                //parsing the input from the textbox
                //checking if text is a valid number, less than or equal to 0 and if input is greater than the availableQty
                if (!int.TryParse(QuantitySoldTxtBox.Text, out int quantitySold)
                || quantitySold <= 0 || quantitySold > GroceryList[labelIndex - 1].AvailableQty)
                {
                    StatusLabel.Text = "Qty Sold must be whole number greater than 0 and less than the AvailableQty";
                }else
                {
                    //process when the data is valid
                    GroceryList[labelIndex - 1].QtySold += quantitySold; //increment QtySold based on the input
                    GroceryListBox.Items[labelIndex] = GroceryList[labelIndex - 1]; //update the listbox with the new data
                    StatusLabel.Text = "Incremented Qty Sold for item with Item Code: " + GroceryList[labelIndex - 1].ItemCode;
                    QuantitySoldTxtBox.Text = "";
                }
            }
                
        }

        //event handler for 'Update Restocked Qty For Selected Item' button
        private void UpdateRestockedBtn_Click(object sender, EventArgs e)
        {
            int labelIndex = GroceryListBox.SelectedIndex;
            if (labelIndex <= 0)
            {
                //when headerline is clicked
                StatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else if (GroceryList.Count > 0)
            {
                //parsing the input from the textbox
                //checking if text is a valid number, less than or equal to 0

                if (!int.TryParse(QuantityRestockedTxtBox.Text, out int qtyRestocked) || qtyRestocked <= 0)
                {
                    StatusLabel.Text = "Restocked qty must be whole number greater than 0";
                }
                else
                {
                    //process when the data is valid
                    GroceryList[labelIndex - 1].QtyRestocked += qtyRestocked; //increment RestockedQty based on the input
                    GroceryListBox.Items[labelIndex] = GroceryList[labelIndex - 1]; //update the listbox with the new data
                    StatusLabel.Text = "Incremented Restocked Sold for item with Item Code: " + GroceryList[labelIndex - 1].ItemCode;
                    QuantityRestockedTxtBox.Text = "";
                }
            }
        }

        //event handler for 'Delete Selected Grocery Item' button
        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            int labelIndex = GroceryListBox.SelectedIndex;
            if (labelIndex <= 0)
            {
                //when headerline is clicked
                StatusLabel.Text = "Please select a grocery item to delete";
            }
            else if (GroceryList.Count > 0)
            {
                //update status label with item code of deleted grocery item
                StatusLabel.Text = "Deleted record for item with Item Code: " + GroceryList[labelIndex - 1].ItemCode;

                //delete the item
                GroceryList.RemoveAt(labelIndex - 1);

                //delete item in GroceryListBox
                GroceryListBox.Items.RemoveAt(labelIndex);
            }
        }

        //event handler for 'Sort Items Based on Sales' button
        private void SortItemBtn_Click(object sender, EventArgs e)
        {
            //sorting TotalSales by descending order
            List<Grocery> SortedGrList = GroceryList.OrderByDescending(grocery => grocery.TotalSales).ToList();

            GroceryList = SortedGrList;
            LoadAllItemsToListBox();

            //update status label once TotalSales is sorted
            StatusLabel.Text = "Sorted All Items in Descending order of Sales";
        }

        //event handler for 'Save Grocery Data' button
        private void SaveGroceryDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //save all grocery items in a csv file from the GroceryListBox 
                using (StreamWriter saveGroceryItemStream = new StreamWriter("updatedgrocery.csv"))
                {
                    string headerOutput = "ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked";
                    saveGroceryItemStream.WriteLine(headerOutput);
                    foreach(Grocery grocery in GroceryList)
                    {
                        string groceryItem = grocery.ItemCode + "," + grocery.ItemName + ","
                                           + grocery.UnitPrice.ToString("C2") + "," + grocery.QtyMinForRestock + ","
                                           + grocery.InitialQty + "," + grocery.QtySold + ","
                                           + grocery.QtyRestocked;
                        saveGroceryItemStream.WriteLine(groceryItem);
                    }
                }
                StatusLabel.Text = "Saved " + GroceryList.Count + " record(s) into the output inventory file";
                GroceryList.Clear();
                GroceryListBox.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //event handler for 'Sales Report' button
        private void SaveSalesRprtBtn_Click(object sender, EventArgs e)
        {
            //sorted first the items with TotalSales > 0 using LINQ
            List<Grocery> SortedItemBasedOnSales = GroceryList.OrderByDescending(sales => sales.TotalSales).ToList();
            SortedItemBasedOnSales = (from sales in GroceryList
                          orderby sales.TotalSales
                          where sales.TotalSales > 0
                          select sales).ToList();

            try
            {
                //adding grocery items which have a sales
                using (StreamWriter saveGrocerySalesStream = new StreamWriter("grocerysales.csv."))
                {
                    string headerLine = "ItemCode,ItemName,UnitPrice,QtySold,Sales";
                    saveGrocerySalesStream.WriteLine(headerLine);
                    //used the sortedList to save the items with sales 
                    foreach (Grocery grocery in SortedItemBasedOnSales)
                    {
                        string groceryItem = grocery.ItemCode + "," + grocery.ItemName + ","
                                           + grocery.UnitPrice.ToString("C2") + "," + grocery.QtySold + ","
                                           + grocery.TotalSales.ToString("C2");
                        saveGrocerySalesStream.WriteLine(groceryItem);
                    }
                }
                StatusLabel.Text = "Saved " + SortedItemBasedOnSales.Count + " record(s) into the output sales file";
                SortedItemBasedOnSales.Clear();
                //if user has selected an item, clear the selection
                if (GroceryListBox.SelectedIndex > 0)
                {
                    GroceryListBox.ClearSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //event handler for 'Save Restock Needs Report'
        private void SaveRstckBtn_Click(object sender, EventArgs e)
        {
            //sorted first the items with AvailableQty lesser than QtyMinForRestock using LINQ
            List<Grocery> SortedItemBasedOnRestock = GroceryList.OrderByDescending(restock => restock.QtyMinForRestock).ToList();
            SortedItemBasedOnRestock = (from restock in GroceryList
                                      orderby restock.QtyMinForRestock
                                      where restock.AvailableQty < restock.QtyMinForRestock
                                      select restock).ToList();

            try
            {
                using (StreamWriter saveGroceryRestockStream = new StreamWriter("groceryrestocks.csv."))
                {
                    string headerLine = "ItemCode,ItemName,AvailableQty,QtyMinForRestock";
                    saveGroceryRestockStream.WriteLine(headerLine);
                    //used the sortedList to save the items with sales 
                    foreach (Grocery grocery in SortedItemBasedOnRestock)
                    {
                        string groceryItem = grocery.ItemCode + "," + grocery.ItemName + ","
                                           + grocery.AvailableQty + "," + grocery.QtyMinForRestock;
                        saveGroceryRestockStream.WriteLine(groceryItem);
                    }
                }
                StatusLabel.Text = "Saved " + SortedItemBasedOnRestock.Count + " record(s) into the restocks needed output file";
                SortedItemBasedOnRestock.Clear();
                //if user has selected an item, clear the selection
                if(GroceryListBox.SelectedIndex > 0)
                {
                    GroceryListBox.ClearSelected();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroceryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
