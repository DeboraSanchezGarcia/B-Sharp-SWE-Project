using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Items
    {
        /// <summary>
        /// Fields for Items object
        /// </summary>
        private int itemID;
        private string itemName, itemType;
        private double itemPrice;
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Items()
        {
            
        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="itemPrice"></param>
        /// <param name="itemType"></param>
        public Items(string itemName, double itemPrice, string itemType)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemType = itemType;
        }
        /// <summary>
        /// Getters and setters
        /// </summary>
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
        /// <summary>
        /// Reads an item from the Items table by id
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Reads an item from the Items table by name
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
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

