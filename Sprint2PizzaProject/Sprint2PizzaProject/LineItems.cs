using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public int LineItemID { get; set; }
        public int OrderID { get; set; }
        public int ItemID1 { get; set; }
        public int OptionID1 { get; set; }
        public int Quantity { get; set; }
        public int ItemID2 { get; set; }
        public int OptionID2 { get; set; }
        public int ItemID3 { get; set; }
        public int OptionID3 { get; set; }
        public int ItemID4 { get; set; }
        public int OptionID4 { get; set; }
        public int ItemID5 { get; set; }
        public int OptionID5 { get; set; }
        public int ItemID6 { get; set; }
        public int OptionID6 { get; set; }
        public int ItemID7 { get; set; }
        public int OptionID7 { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
