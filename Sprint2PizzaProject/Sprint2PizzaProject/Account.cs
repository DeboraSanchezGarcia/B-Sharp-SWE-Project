using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Account
    {
        private string phoneNumber, email, firstName, lastName, password;
        private bool isEmployee;

        public Account() 
        {
            phoneNumber = null;
            email = null;
            firstName = null;
            lastName = null;
            password = null;
            isEmployee = false;
        }
        public Account(string phoneNumber, string email, string firstName, string lastName, string password, bool isEmployee)
        {
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
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
        public Account ReadAccount(string phoneNumber)
        {
        }
        public void UpdateAccount(Account account)
        {
        }
    }
}
