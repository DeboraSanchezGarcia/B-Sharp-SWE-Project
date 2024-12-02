using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class OptionsPizzaIntersection
    {
        /// <summary>
        /// Fields for intersection object
        /// </summary>
        private int optionID, itemID;
        /// <summary>
        /// Empty constructor
        /// </summary>
        public OptionsPizzaIntersection()
        {

        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="optionID"></param>
        /// <param name="itemID"></param>
        public OptionsPizzaIntersection(int optionID, int itemID)
        {
            this.optionID = optionID;
            this.itemID = itemID;
        }
        /// <summary>
        /// Getters and setters for intersection objects fields
        /// </summary>
        public int OptionID { 
            get { return optionID; } 
            set { optionID = value; }
        }
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        /// <summary>
        /// Reads an intersection from the OptionsPizzaIntersection table
        /// </summary>
        /// <param name="optionID"></param>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static OptionsPizzaIntersection ReadOptionsPizzaIntersection(int optionID, int itemID)
        {
            OptionsPizzaIntersection optionsPizzaIntersection = new OptionsPizzaIntersection();
            try
            {
                // "OptionsPizzaIntersection.txt"
                StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\OptionsPizzaIntersection.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] intersectionData = line.Split(",");
                    if (intersectionData[0].Equals("ItemID"))
                    {
                        continue;
                    }
                    for (int x = 0; x < intersectionData.Length; x++)
                    {
                        intersectionData[x] = intersectionData[x].Trim();
                    }
                    if ((intersectionData[0].Equals(optionID) && (intersectionData[2].Equals(itemID))))
                    {
                        optionsPizzaIntersection = new OptionsPizzaIntersection(Convert.ToInt32(intersectionData[0]), Convert.ToInt32(intersectionData[1]));
                        return optionsPizzaIntersection;
                    }
                }
                sr.Close();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error:" + ioex);
            }
            return optionsPizzaIntersection;
        }
    }
}
