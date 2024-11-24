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

        }
        public static void UpdateOptionsPizzaIntersection(OptionsPizzaIntersection optionPizzaIntersection)
        {

        }
    }
}
