using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Sprint2PizzaProject
{
    internal class CreditCard
    {
        private string phoneNumber, last4Digit, cardNumber, expiration, cardType, cvv
            , streetAddress, city, state, zip;
        private bool sameAsDelivery;

        public CreditCard()
        {

        }

        public CreditCard(string phoneNumber, string cardNumber, string expiration, string cardType, string cvv, string streetAddress, string city, string state, string zip)
        {
            this.phoneNumber = phoneNumber;
            this.cardNumber = cardNumber;
            last4Digit = cardNumber.Substring(cardNumber.Length - 4);
            this.expiration = expiration;
            this.cardType = cardType;
            this.cvv = cvv;
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
        public CreditCard(string phoneNumber, string cardNumber, string expiration, string cardType, string cvv)
        {
            this.phoneNumber = phoneNumber;
            this.cardNumber = cardNumber;
            last4Digit = cardNumber.Substring(cardNumber.Length - 4);
            this.expiration = expiration;
            this.cardType = cardType;
            this.cvv = cvv;
        }

        public string PhoneNumber { 
            get { return phoneNumber; } 
            set { phoneNumber = value; }
        }
        public string CardNumber { 
            get { return cardNumber; } 
            set { cardNumber = value;
                last4Digit = cardNumber.Substring(cardNumber.Length - 4, cardNumber.Length - 1); } 
        }
        public string Last4Digit
        {
            get { return last4Digit; }
        }
        public string Expiration
        {
            get { return expiration; }
            set { expiration = value; }
        }
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }
        public bool SameAsDelivery
        {
            get { return sameAsDelivery; }
            set { sameAsDelivery = value; }
        }
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return state; }
            set { state = value; }
        }

        public static CreditCard ReadCreditCard(string phoneNumber)
        {
            CreditCard creditCard = new CreditCard();
            try
            {
                // "CreditCard.txt"
                StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\CreditCard.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] creditCardData = line.Split(",");
                    if (creditCardData[0].Equals("CardID"))
                    {
                        continue;
                    }
                    for (int x = 0; x < creditCardData.Length; x++)
                    {
                        creditCardData[x] = creditCardData[x].Trim();
                    }
                    if (creditCardData[1].Equals(phoneNumber));
                    {
                        if ((creditCardData[7].ToLower()).Equals("yes"))
                        {
                            creditCard = new CreditCard(creditCardData[1], creditCardData[3], creditCardData[4], creditCardData[5], creditCardData[6]);
                        }
                        else
                        {
                            creditCard = new CreditCard(creditCardData[1], creditCardData[3], creditCardData[4], creditCardData[5], creditCardData[6], creditCardData[8], creditCardData[9], creditCardData[10], creditCardData[11]);
                        }
                        return creditCard;
                    }
                }
                sr.Close();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error:" + ioex);
            }
            return creditCard;
        }
    }
}
