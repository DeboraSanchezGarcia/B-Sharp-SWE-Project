using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Address
    {
        /// <summary>
        /// Fields for address object
        /// </summary>
        private string phoneNumber, streetAddress, city, state, zip, subdivision, nearbyLandmarks;
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Address()
        {

        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="streetAddress"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="subdivision"></param>
        /// <param name="nearbyLandmarks"></param>
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
        /// <summary>
        /// Getters and setters
        /// </summary>
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
        /// <summary>
        /// Reads address from Address table
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static Address ReadAddress(string phoneNumber)
        {
            Address address = new Address();
            try
            {
                // "Address.txt"
                StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Address.txt");
                            string line;
            while ((line = sr.ReadLine()) != null)
                {
                    string[] addressData = line.Split(",");
                    if (addressData[0].Equals("AddressID", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    for (int x = 0; x < addressData.Length; x++)
                    {
                        addressData[x] = addressData[x].Trim();
                    }

                    if (addressData[1].Equals(phoneNumber))
                    {
                        address = new Address(
                            phoneNumber: addressData[1],
                            streetAddress: addressData[2],
                            city: addressData[3],
                            state: addressData[4],
                            zip: addressData[5],
                            subdivision: addressData[6],
                            nearbyLandmarks: addressData[7]
                        );
                        break;
                    }
                }

            }
            catch (IOException ioex)
            {
                Console.WriteLine($"Error reading address data: {ioex.Message}");
            }
            return address;
        }
    }
}
