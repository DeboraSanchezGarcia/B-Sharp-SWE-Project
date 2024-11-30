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
        // method to create new Item
        public static void CreateItem(Items item)
        {
            try
            {
                // "Items.txt"
                using (StreamWriter sw = new StreamWriter("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Items.txt", append: true))
                {
                    // serialize object to CSV format
                    string itemData = $"{item.ItemID}, {item.ItemName}, {item.ItemPrice}, {item.ItemType}";
                    sw.WriteLine(itemData);
                }
                Console.WriteLine("Item created successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
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
        // method to update existing item
        public static void UpdateItem(Items updatedItem)
        {
            try
            {
                // "Items.txt"
                string[] lines = File.ReadAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Items.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] itemData = lines[i].Split(',');
                    if (Convert.ToInt32(itemData[0].Trim()) == updatedItem.ItemID)
                    {
                        // update line with new data
                        lines[i] = $"{updatedItem.ItemID}, {updatedItem.ItemName}, {updatedItem.ItemPrice}, {updatedItem.ItemType}";
                        break;
                    }
                }
                // "Items.txt"
                File.WriteAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Items.txt", lines); // write all lines back to file
                Console.WriteLine("Item updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }
    }
}

