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
        private string phoneNumber, firstName, lastName, email, password;
        private bool isEmployee;
        private int cardID;

        public Account()
        { 
            phoneNumber = "";
            firstName = "";
            lastName = "";
            cardID = 0;
            email = "";
            password = "";
            isEmployee = false;
        }
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

        public void CreateAccount(Account account)
        {
        }
        public static Account ReadAccount(string phoneNumber)
        {
            bool isEmployee = false;
            int cardID;
            Account account1 = new Account();
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\atidw\\source\\repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Account.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] account = line.Split(",");
                    Console.WriteLine(line);
                    for(int x = 0; x < account.Length; x++)
                    {
                        account[x] = account[x].Trim();
                    }
                    if ((account[0] == phoneNumber) || (account[4] == phoneNumber))
                    {
                        if (account[5].ToLower() == "yes")
                        {
                            isEmployee = true;
                        }
                        if (account[3].Equals(""))
                        {
                            cardID = 0;
                        }
                        else
                        {
                            cardID = Convert.ToInt32(account[3]);
                        }
                        account1 = new Account(account[0], account[1], account[2], cardID, account[4], account[5], isEmployee);
                        return account1;
                    }
                }
                sr.Close();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error:" + ioex);
            }
            return account1;
        }
        public void UpdateAccount(Account account)
        {
        }
    }
}
