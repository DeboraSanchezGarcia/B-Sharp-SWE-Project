using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Options
    {
        private int optionID;
        private string optionName, optionType;
        private double optionPrice;

        public Options()
        {
            
        }
        // constructor
        public Options(string optionType, string optionName, double optionPrice)
        {
            this.optionType = optionType;
            this.optionName = optionName;
            this.optionPrice = optionPrice;
        }
        // getters and setters
        public int OptionID
        {
            get { return optionID; }
            set { optionID = value; }
        }
        public string OptionType
        {
            get { return optionType; }
            set { optionType = value; }
        }
        public string OptionName
        {
            get { return optionName; }
            set { optionName = value; }
        }
        public double OptionPrice
        {
            get { return optionPrice; }
            set { optionPrice = value; }
        }
        // method to read option by id
        public static Options ReadOption(int optionID)
        {
            Options option = new Options();
            try
            {
                // "Options.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Options.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] optionData = line.Split(',');
                        if (optionData[0].Equals("OptionID"))
                        {
                            continue;
                        }
                        if (optionData[0].Equals(optionID.ToString()))
                        {
                            option.OptionID = Convert.ToInt32(optionData[0].Trim());
                            option.OptionType = optionData[1].Trim();
                            option.OptionName = optionData[2].Trim();
                            option.OptionPrice = Convert.ToDouble(optionData[3].Trim());
                            return option;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return option; // returns default object if not found
        }
        // method to read option by name
        public static Options ReadOption(string optionName)
        {
            Options option = new Options();
            try
            {
                // "options.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Options.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] optionData = line.Split(',');
                        if (optionData[0].Equals("OptionID"))
                        {
                            continue;
                        }
                        if (optionData[2].Trim().Equals(optionName, StringComparison.OrdinalIgnoreCase))
                        {
                            option.OptionID = Convert.ToInt32(optionData[0].Trim());
                            option.OptionType = optionData[1].Trim();
                            option.OptionName = optionData[2].Trim();
                            option.OptionPrice = Convert.ToDouble(optionData[3].Trim());
                            return option;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return option; // returns a default object if not found
        }
    }
}
