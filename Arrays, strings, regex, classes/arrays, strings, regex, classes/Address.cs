using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    internal class Address
    {
        private string Country;
        private string City;
        private string Region;
        private int PostalCode;
        private string Street;
        private string House;

        public Address()
        {
            Country = "No country";
            City = "No city";
            Region = "No region";
            PostalCode = 000000;
            Street = "No street";
            House = "No house";
        }

        public Address(string country, string city, string region, int postalCode, string street, string house)
        {
            Country = country;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Street = street;
            House = house;
        }

        public string toString() { return $"{Street}, {House}, {City}, {Region}, {Country}, {PostalCode}"; }
    }
}