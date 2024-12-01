using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        // "PersistentNextLineItemID.txt"
        private static string txtFile = "C:\\Users\\atidw\\source\\repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\PersistentNextLineItemID.txt";
        private static int nextLineItemID = GetNextLineItemID(txtFile);

        public LineItems()
        {
            lineItemID = nextLineItemID;
            nextLineItemID++;
            SetNextLineItemID(txtFile);
        }

        

        public LineItems (int orderID, int itemID1, int optionID1, int quantity, int itemID2, int optionID2, int itemID3, int optionID3, int itemID4, int optionID4, int itemID5, int optionID5,
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
                SetNextLineItemID(txtFile);
             }

        //Getters and setters for all values

        public int LineItemID
        {
            get { return lineItemID; }
            set { lineItemID = value; }
        }
        public int OrderID {
            get { return orderID; }
            set { orderID = value; }
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
                // "LineItems.txt"
                using (StreamWriter sw = new StreamWriter("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt", append: true))
                {
                    // Serialize to CSV format
                    string lineItemData = $"{lineItem.orderID}, {lineItem.lineItemID}, {lineItem.itemID1}, {lineItem.itemID2}, {lineItem.itemID3}, {lineItem.itemID4}, {lineItem.itemID5}, {lineItem.itemID6}, {lineItem.itemID7}, " +
                        $"{lineItem.optionID1}, {lineItem.optionID2}, {lineItem.optionID3}, {lineItem.optionID4}, {lineItem.optionID5}, {lineItem.optionID6}, {lineItem.optionID7}, {lineItem.quantity}, {lineItem.description}, {lineItem.price}";
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
                // "LineItems.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt"))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] lineItemData = line.Split(',');
                        if (lineItemData[0].Equals("OrderID"))
                        {
                            continue;
                        }
                        for (int x = 0; x < lineItemData.Length; x++)
                        {
                            lineItemData[x] = lineItemData[x].Trim();
                        }
                        if (Convert.ToInt32(lineItemData[1]) == lineItemID)
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

        public static ArrayList ReadOrderLineItems(int orderID)
        {
            LineItems lineItem = new LineItems();
            ArrayList lineItems = new ArrayList();
            try
            {
                // "LineItems.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt"))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] lineItemData = line.Split(',');
                        if (lineItemData[0].Equals("OrderID"))
                        {
                            continue;
                        }
                        for (int x = 0; x < lineItemData.Length; x++)
                        {
                            lineItemData[x] = lineItemData[x].Trim();
                        }
                        if (lineItemData[0].Equals(orderID.ToString())) 
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
                            lineItems.Add(lineItem);
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return lineItems;
        }

        public static void DeleteLineItem(int lineItemID)
        {
            try
            {
                // "LineItems.txt"
                string[] lines = File.ReadAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] lineItemData = lines[i].Split(',');
                    if (lineItemData[0].Equals("OrderID"))
                    {
                        continue;
                    }
                    if ((lineItemData[1].Trim()).Equals(lineItemID.ToString()))
                    {
                        // update line with new data
                        lines[i] = "";
                        break;
                    }
                }
                ArrayList newLines = new ArrayList();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Equals(""))
                    {
                        continue;
                    }
                    else
                    {
                        newLines.Add(lines[i]);
                    }
                }
                string[] newLines2 = new string[newLines.Count];
                for (int x = 0; x < newLines.Count; x++)
                {
                    newLines2[x] = (string)newLines[x];
                }
                // "LineItems.txt"
                File.WriteAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt", newLines2); // write all lines back to file
                Console.WriteLine("Item updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }

        public override string ToString()
        {

            Items item1 = Items.ReadItem(this.itemID1);
            Options option1 = Options.ReadOption(this.optionID1);
            Items item2 = Items.ReadItem(this.itemID2);
            Options option2 = Options.ReadOption(this.optionID2);
            Items item3 = Items.ReadItem(this.itemID3);
            Options option3 = Options.ReadOption(this.optionID3);
            Items item4 = Items.ReadItem(this.itemID4);
            Options option4 = Options.ReadOption(this.optionID4);
            Items item5 = Items.ReadItem(this.itemID5);
            Options option5 = Options.ReadOption(this.optionID5);
            Items item6 = Items.ReadItem(this.itemID6);
            Options option6 = Options.ReadOption(this.optionID6);
            Items item7 = Items.ReadItem(this.itemID7);
            Options option7 = Options.ReadOption(this.optionID7);

            string[] pizzaNames = new string[14];
            if (item1.ItemID == 0)
            {
                pizzaNames[0] = "";
                pizzaNames[1] = "";
            }
            else
            {
                pizzaNames[0] = item1.ItemName;
                pizzaNames[1] = option1.OptionName;
            }
            if (item2.ItemID == 0)
            {
                pizzaNames[2] = "";
                pizzaNames[3] = "";
            }
            else
            {
                pizzaNames[2] = " " + item2.ItemName;
                pizzaNames[3] = " " + option2.OptionName;
            }
            if (item3.ItemID == 0)
            {
                pizzaNames[4] = "";
                pizzaNames[5] = "";
            }
            else
            {
                pizzaNames[4] = " " + item3.ItemName;
                pizzaNames[5] = ", " + option3.OptionName;
            }
            if (item4.ItemID == 0)
            {
                pizzaNames[6] = "";
                pizzaNames[7] = "";
            }
            else
            {
                pizzaNames[6] = " " + item4.ItemName;
                pizzaNames[7] = ", " + option4.OptionName;
            }
            if (item5.ItemID == 0)
            {
                pizzaNames[8] = "";
                pizzaNames[9] = "";
            }
            else
            {
                pizzaNames[8] = " " + item5.ItemName;
                pizzaNames[9] = ", " + option5.OptionName;
            }
            if (item6.ItemID == 0)
            {
                pizzaNames[10] = "";
                pizzaNames[11] = "";
            }
            else
            {
                pizzaNames[10] = " " + item6.ItemName;
                pizzaNames[11] = ", " + option6.OptionName;
            }
            if (item7.ItemID == 0)
            {
                pizzaNames[12] = "";
                pizzaNames[13] = "";
            }
            else
            {
                pizzaNames[12] = " " + item7.ItemName;
                pizzaNames[13] = ", " +option7.OptionName;
            }

            if (item1.ItemID == 1 || item1.ItemID == 2 || item1.ItemID == 3 || item1.ItemID == 4)
            {
                return this.Quantity + " " + option1.OptionName + " " +  item1.ItemName + "(s)";
            }
            else if (item1.ItemID == 24 || item1.ItemID == 25 || item1.ItemID == 26 || item1.ItemID == 27 || item1.ItemID == 28)
            {
                return this.Quantity + " " + option1.OptionName + " " + item1.ItemName + "(s)";
            }
            else
            {
                return this.Quantity + " " + pizzaNames[1] + " " + pizzaNames[0] + " crust pizza(s) with" + pizzaNames[3] + pizzaNames[2] +  pizzaNames[5] +  pizzaNames[4] + pizzaNames[7] + pizzaNames[6] 
                    + pizzaNames[9] + pizzaNames[8] + pizzaNames[11] + pizzaNames[10] +  pizzaNames[13] + pizzaNames[12];
            }
        }

        public static int GetNextLineItemID(string txtFile)
        {
            StreamReader sr = new StreamReader(txtFile);
            string line = sr.ReadLine();
            sr.Close();
            return Convert.ToInt32(line);
        }
        public static void SetNextLineItemID(string txtFile)
        {
            StreamWriter sw = new StreamWriter(txtFile);
            string line = nextLineItemID.ToString();
            sw.WriteLine(line);
            sw.Close();
        }

    }
}
