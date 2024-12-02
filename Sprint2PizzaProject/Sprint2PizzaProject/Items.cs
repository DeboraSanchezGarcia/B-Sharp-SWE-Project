using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Items
    {
        private int itemID;
        private string itemName, itemType;
        private double itemPrice;
        public Items()
        {
            
        }
        // constructor
        public Items(string itemName, double itemPrice, string itemType)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemType = itemType;
        }
        // getters and setters)
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        // method to read an item by id
        public static Items ReadItem(int itemID)
        {
            Items item = new Items();
            try
            {
                // "Items.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Items.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemData = line.Split(',');
                        if (itemData[0].Equals("ItemID"))
                        {
                            continue;
                        }
                        if (itemData[0].Equals(itemID.ToString())) 
                        {
                            item.ItemID = Convert.ToInt32(itemData[0].Trim());
                            item.ItemName = itemData[1].Trim();
                            item.ItemPrice = Convert.ToDouble(itemData[2].Trim());
                            item.ItemType = itemData[3].Trim();
                            return item;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return item; // returns default object if not found
        }
        // Method to read item by name
        public static Items ReadItem(string itemName)
        {
            Items item = new Items();
            try
            {
                // "Items.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Items.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemData = line.Split(',');
                        if (itemData[0].Equals("ItemID"))
                        {
                            continue;
                        }
                        if (itemData[1].Trim().Equals(itemName, StringComparison.OrdinalIgnoreCase))
                        {
                            item.ItemID = Convert.ToInt32(itemData[0].Trim());
                            item.ItemName = itemData[1].Trim();
                            item.ItemPrice = Convert.ToDouble(itemData[2].Trim());
                            item.ItemType = itemData[3].Trim();
                            return item;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return item; // returns default object if not found
        }
    }
}

