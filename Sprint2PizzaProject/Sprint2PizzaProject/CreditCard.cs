using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class CreditCard
    {
        private string phoneNumber, last4Digit, cardNumber, expiration, cardType, cvv
            , streetAddress, city, state, zip;
        private bool sameAsDelivery;

        public CreditCard(string phoneNumber, string cardNumber, string expiration, string cardType, string cvv, string streetAddress, string city, string state, string zip)
        {
            this.phoneNumber = phoneNumber;
            this.cardNumber = cardNumber;
            last4Digit = cardNumber.Substring(cardNumber.Length - 4,cardNumber.Length - 1);
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
            last4Digit = cardNumber.Substring(cardNumber.Length - 4, cardNumber.Length - 1);
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

        public static void CreateCreditCard(CreditCard creditCard)
        {

        }
        /*public static CreditCard ReadCreditCard(string phoneNumber)
        {

        }
        */
        public static void UpdateCreditCard(CreditCard creditCard)
        {

        }
    }
}
