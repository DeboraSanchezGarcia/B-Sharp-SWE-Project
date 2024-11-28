using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Address
    {
        private string phoneNumber, streetAddress, city, state, zip, subdivision, nearbyLandmarks;


        public Address()
        {

        }
        //Make a constructor that sets inputted values to the objects values
        public Address (string phoneNumber, string streetAddress, string city, string state, string zip, string subdivision, string nearbyLandmarks)
        {
            this.phoneNumber = phoneNumber;
            this. streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.subdivision = subdivision;
            this.nearbyLandmarks = nearbyLandmarks;
        }

        //Getters and setters

        public string PhoneNumber {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string StreetAddress {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        public string City {
            get { return city; }
            set { city = value; }
        }
        public string State {
            get { return state; }
            set { state = value; }
        }
        public string Zip {
            get { return zip; }
            set { zip = value; }
        }
        public string Subdivision {
            get { return subdivision; }
            set { subdivision = value; }
        }
        public string NearbyLandmarks {
            get { return nearbyLandmarks; }
            set { nearbyLandmarks = value; }
        }

        public static void CreateAddress(Address address)
        {

        }

        public static Address ReadAddress(int phoneNumber)
        {
            Address address = new Address();
            try
            {
                StreamReader sr = new StreamReader("Address.txt");
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] addressData = line.Split(",");
                    for (int x = 0; x < addressData.Length; x++)
                    {
                        addressData[x] = addressData[x].Trim();
                    }
                    if (addressData[1].Equals(phoneNumber))
                    {
                        address = new Address(addressData[0], addressData[1], addressData[2], addressData[3], addressData[4], addressData[5], addressData[6]);
                        return address;
                    }
                }
                sr.Close();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error:" + ioex);
            }
            return address;
        }

        public static void UpdateAddress(Address address)
        {

        }

    }
}