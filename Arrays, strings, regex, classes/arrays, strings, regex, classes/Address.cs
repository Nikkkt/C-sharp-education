using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public string country
        {
            get { return Country; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidCountry("Null or empty value");
                Country = value;
            }
        }

        public string city
        {
            get { return City; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidCity("Null or empty value");
                City = value;
            }
        }

        public string region
        {
            get { return Region; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidRegion("Null or empty value");
                Region = value;
            }
        }

        public int postalCode
        {
            get { return PostalCode; }
            set
            {
                if (value <= 10000 || value >= 99999) throw new InvalidPostalCode("Invalid value");
                PostalCode = value;
            }
        }

        public string street
        {
            get { return Street; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidRegion("Null or empty value");
                Street = value;
            }
        }

        public string house
        {
            get { return House; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidRegion("Null or empty value");
                House = value;
            }
        }

        public override bool Equals(object obj)
        {
            Address obj2 = obj as Address;
            if (obj == null) return false;
            return (obj2.country == this.country && obj2.city == this.city &&
                obj2.region == this.region && obj2.postalCode == this.postalCode &&
                obj2.street == this.street && obj2.house == this.house);
        }

        public static bool operator ==(Address address1, Address address2)
        {
            if (ReferenceEquals(address1, address2)) return true;
            if ((object)address1 != null) return address1.Equals(address2);
            if ((object)address2 != null) return address2.Equals(address1);
            return (address1.country == address2.country && address1.city == address2.city &&
                address1.region == address2.region && address1.postalCode == address2.postalCode &&
                address1.street == address2.street && address1.house == address2.house);
        }
        public static bool operator !=(Address address1, Address address2) { return !(address1 == address2); }

        public string toString() { return $"{Street}, {House}, {City}, {Region}, {Country}, {PostalCode}"; }
    }
}