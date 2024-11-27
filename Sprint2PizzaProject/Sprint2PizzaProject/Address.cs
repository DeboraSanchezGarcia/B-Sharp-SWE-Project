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

        public string PhoneNumber {get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Subdivision { get; set; }
        public string NearbyLandmarks { get; set; }
        
    }
}