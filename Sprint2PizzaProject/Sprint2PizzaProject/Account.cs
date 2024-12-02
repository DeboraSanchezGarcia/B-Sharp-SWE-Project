using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sprint2PizzaProject
{
    internal class Account
    {
        /// <summary>
        /// Fields for account object
        /// </summary>
        private string phoneNumber, firstName, lastName, email, password;
        private bool isEmployee;
        private int cardID;
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Account()
        { 
        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="cardID"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="isEmployee"></param>
        public Account(string phoneNumber,  string firstName, string lastName, int cardID, string email, string password, bool isEmployee)
        {
            this.phoneNumber = phoneNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardID = cardID;
            this.email = email;
            this.password = password;
            this.isEmployee = isEmployee;
        }
        /// <summary>
        /// Getters and setters
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FirstName { 
            get { return firstName; } 
            set { firstName = value; } 
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsEmployee
        {
            get { return isEmployee; }
            set { isEmployee = value; }
        }
        /// <summary>
        /// Reads account from Account table
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static Account ReadAccount(string phoneNumber)
        {
            bool isEmployee = false;
            int cardID;
            Account account = new Account();
            try
            {
                // "Account.txt"
                StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Account.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] accountData = line.Split(",");
                    if (accountData[0].Equals("PhoneNumber"))
                    {
                        continue;
                    }
                    for (int x = 0; x < accountData.Length; x++)
                    {
                        accountData[x] = accountData[x].Trim();
                    }
                    if ((accountData[0] == phoneNumber) || (accountData[4] == phoneNumber))
                    {
                        if (accountData[6].ToLower() == "yes")
                        {
                            isEmployee = true;
                        }
                        if (accountData[3].Equals(""))
                        {
                            cardID = 0;
                        }
                        else
                        {
                            cardID = Convert.ToInt32(accountData[3]);
                        }
                        account = new Account(accountData[0], accountData[1], accountData[2], cardID, accountData[4], accountData[5], isEmployee);
                        return account;
                    }
                }
                sr.Close();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error:" + ioex);
            }
            return account;
        }
    }
}
