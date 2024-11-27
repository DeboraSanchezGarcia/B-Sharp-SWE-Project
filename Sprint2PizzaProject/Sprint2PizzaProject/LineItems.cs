using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    //Will create an object to be added to each order
    internal class LineItems
    {
        private int lineItemID, orderID, itemID1, optionID1, quantity;
        private int itemID2, optionID2, itemID3, optionID3, itemID4, optionID4, itemID5, optionID5,
             itemID6, optionID6, itemID7, optionID7;
        private string description;
        private double price;
        private static int nextLineItemID = 10001;

        public LineItems()
        {

        }

        //Make a constructor that sets inputed values to the objects values. For everything except lineItemID use this.(value) = (value)

        public LineItems (int lineItemID, int orderID, int itemID1, int optionID1, int quantity, int itemID2, int optionID2, int itemID3, int optionID3, int itemID4, int optionID4, int itemID5, int optionID5,
             int itemID6, int optionID6, int itemID7, int optionID7, string description, double price) {
                
                this.lineItemID = nextLineItemID;
                this.orderID = orderID;
                this.itemID1 = itemID1;
                this.optionID1 = optionID1;
                this.quantity = quantity;
                this.itemID2 = itemID2;
                this.optionID2 = optionID2;
                this.itemID3 = itemID3;
                this.optionID3 = optionID3;
                this.itemID4 = itemID4;
                this.optionID4 = optionID4;
                this.itemID5 = itemID5;
                this.optionID5 = optionID5;
                this.itemID6 = itemID6;
                this.optionID6 = optionID6;
                this.itemID7 = itemID7;
                this.optionID7 = optionID7;
                this.description = description;
                this.price = price;

                nextLineItemID++;
             }

        //Getters and setters for all values

        public int LineItemID
        {
            get { return lineItemID; }
            set { lineItemID = value; }
        }
        public int OrderID {
            get { return orderID; }
            set { lineItemID = value; }
        }
        public int ItemID1 {
            get { return itemID1; }
            set { itemID1 = value; }
        }
        public int OptionID1 {
            get { return optionID1; }
            set { optionID1 = value; }
        }
        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }
        public int ItemID2 {
            get { return itemID2; }
            set { itemID2 = value; }
        }
        public int OptionID2 {
            get { return optionID2; }
            set { optionID2 = value; }
        }
        public int ItemID3 {
            get { return itemID3; }
            set { itemID3 = value; }
        }
        public int OptionID3 {
            get { return optionID3; }
            set { optionID3 = value; }
        }
        public int ItemID4 {
            get { return itemID4; }
            set { itemID4 = value; }
        }
        public int OptionID4 {
            get { return optionID4; }
            set { optionID4 = value; }
        }
        public int ItemID5 {
            get { return itemID5; }
            set { itemID5 = value; }
        }
        public int OptionID5 {
            get { return optionID5; }
            set { optionID5 = value; }
        }
        public int ItemID6 {
            get { return itemID6; }
            set { itemID6 = value; }
        }
        public int OptionID6 {
            get { return optionID6; }
            set { optionID6 = value; }
        }
        public int ItemID7 {
            get { return itemID7; }
            set { itemID7 = value; }
        }
        public int OptionID7 {
            get { return optionID7; }
            set { optionID7 = value; }
        }
        public string Description {
            get { return description; }
            set { description = value; }
        }
        public double Price {
            get { return price; }
            set { price = value; }
        }
        public static void CreateLineItem(LineItems lineItem)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("LineItems.txt", append: true))
                {
                    // Serialize to CSV format
                    string lineItemData = $"{lineItem.OrderID}, {lineItem.lineItemID}, {lineItem.itemID1}, {lineItem.itemID2}, {lineItem.itemID3}, {lineItem.itemID4}, {lineItem.itemID5}, {lineItem.itemID6}, {lineItem.itemID7}, " +
                        $"{lineItem.optionID1}, {lineItem.optionID2}, {lineItem.optionID3}, {lineItem.optionID4}, {lineItem.optionID5}, {lineItem.optionID6}, {lineItem.optionID7}, {lineItem.quantity}, {lineItem.description}, {lineItem.price}, ";
                    sw.WriteLine(lineItemData);
                }
                Console.WriteLine("Order created successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        public static LineItems ReadLineItem(int lineItemID)
        {
            LineItems lineItem = new LineItems();
            try
            {
                using (StreamReader sr = new StreamReader("Orders.txt"))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] lineItemData = line.Split(',');
                        for (int x = 0; x < lineItemData.Length; x++)
                        {
                            lineItemData[x] = lineItemData[x].Trim();
                        }
                        if (Convert.ToInt32(lineItemData[0]) == lineItemID)
                        {
                            lineItem.orderID = Convert.ToInt32(lineItemData[0]);
                            lineItem.lineItemID = Convert.ToInt32(lineItemData[1]);
                            lineItem.itemID1 = Convert.ToInt32(lineItemData[2]);
                            lineItem.itemID2 = Convert.ToInt32(lineItemData[3]);
                            lineItem.itemID3 = Convert.ToInt32(lineItemData[4]);
                            lineItem.itemID4 = Convert.ToInt32(lineItemData[5]);
                            lineItem.itemID5 = Convert.ToInt32(lineItemData[6]);
                            lineItem.itemID6 = Convert.ToInt32(lineItemData[7]);
                            lineItem.itemID7 = Convert.ToInt32(lineItemData[8]);
                            lineItem.optionID1 = Convert.ToInt32(lineItemData[9]);
                            lineItem.optionID2 = Convert.ToInt32(lineItemData[10]);
                            lineItem.optionID3 = Convert.ToInt32(lineItemData[11]);
                            lineItem.optionID4 = Convert.ToInt32(lineItemData[12]);
                            lineItem.optionID5 = Convert.ToInt32(lineItemData[13]);
                            lineItem.optionID6 = Convert.ToInt32(lineItemData[14]);
                            lineItem.optionID7 = Convert.ToInt32(lineItemData[15]);
                            lineItem.quantity = Convert.ToInt32(lineItemData[16]);
                            lineItem.description = lineItemData[17];
                            lineItem.price = Convert.ToDouble(lineItemData[18]);
                            return lineItem;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return lineItem; // returns default object if not found
        }

        public static void DeleteLineItem(int lineItemID)
        {

        }

        public override string ToString()
        {
            return "";
        }

    }
}
