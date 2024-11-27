using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class OptionsPizzaIntersection
    {
        private int optionID, itemID;

        public OptionsPizzaIntersection()
        {

        }

        public OptionsPizzaIntersection(int optionID, int itemID)
        {
            this.optionID = optionID;
            this.itemID = itemID;
        }

        public int OptionID { 
            get { return optionID; } 
            set { optionID = value; }
        }
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public static void CreateOptionsPizzaIntersection(OptionsPizzaIntersection optionsPizzaIntersection)
        {

        } 
        public static OptionsPizzaIntersection ReadOptionsPizzaIntersection(int optionID, int itemID)
        {
            OptionsPizzaIntersection optionsPizzaIntersection = new OptionsPizzaIntersection();
            try
            {
                StreamReader sr = new StreamReader("Account.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] intersectionData = line.Split(",");
                    for (int x = 0; x < intersectionData.Length; x++)
                    {
                        intersectionData[x] = intersectionData[x].Trim();
                    }
                    if ((intersectionData[0].Equals(optionID) && (intersectionData[2].Equals(itemID))));
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
        
        public static void UpdateOptionsPizzaIntersection(OptionsPizzaIntersection optionPizzaIntersection)
        {

        }
    }
}
