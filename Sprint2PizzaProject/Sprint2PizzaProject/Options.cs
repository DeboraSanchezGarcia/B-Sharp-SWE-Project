using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Options
    {
        /// <summary>
        /// Fields for options object
        /// </summary>
        private int optionID;
        private string optionName, optionType;
        private double optionPrice;
        /// <summary>
        /// Empty options constructor
        /// </summary>
        public Options()
        {
            
        }
        /// <summary>
        /// Overloaded options constructor
        /// </summary>
        /// <param name="optionType"></param>
        /// <param name="optionName"></param>
        /// <param name="optionPrice"></param>
        public Options(string optionType, string optionName, double optionPrice)
        {
            this.optionType = optionType;
            this.optionName = optionName;
            this.optionPrice = optionPrice;
        }
        /// <summary>
        /// Getters and setters for fields
        /// </summary>
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
        /// <summary>
        /// Method to read option from options table using id
        /// </summary>
        /// <param name="optionID"></param>
        /// <returns></returns>
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
            return option;
        }
        /// <summary>
        /// Method to read option from Options table by name
        /// </summary>
        /// <param name="optionName"></param>
        /// <returns></returns>
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
            return option;
        }
    }
}
