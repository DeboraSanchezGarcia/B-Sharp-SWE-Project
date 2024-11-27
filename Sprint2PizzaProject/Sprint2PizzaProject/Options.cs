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
            optionID = 0;
            optionName = "";
            optionType = "";
            optionPrice = 0.0;
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
        // method to create new option
        public void CreateOption(Options option)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Options.txt", append: true))
                {
                    // Serialize the object to CSV format
                    string optionData = $"{option.OptionID}, {option.OptionType}, {option.OptionName}, {option.OptionPrice}";
                    sw.WriteLine(optionData);
                }
                Console.WriteLine("Option created successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
        // method to read option by id
        public static Options ReadOption(int optionID)
        {
            Options option = new Options();
            try
            {
                using (StreamReader sr = new StreamReader("Options.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] optionData = line.Split(',');
                        if (Convert.ToInt32(optionData[0]) == optionID)
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
                using (StreamReader sr = new StreamReader("Options.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] optionData = line.Split(',');
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
        // method to update existing option
        public void UpdateOption(Options updatedOption)
        {
            try
            {
                string[] lines = File.ReadAllLines("Options.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] optionData = lines[i].Split(',');
                    if (Convert.ToInt32(optionData[0].Trim()) == updatedOption.OptionID)
                    {
                        // update line with new data
                        lines[i] = $"{updatedOption.OptionID}, {updatedOption.OptionType}, {updatedOption.OptionName}, {updatedOption.OptionPrice}";
                        break;
                    }
                }
                File.WriteAllLines("Options.txt", lines); // write all lines back to file
                Console.WriteLine("Option updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }
    }
}
