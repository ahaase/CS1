using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Klass som beskriver och hanterar en Address.
    /// </summary>
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        /// <summary>
        /// Gatunamn.
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Stad.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Zipkod.
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Landet.
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Standardkonstruktor.
        /// </summary>
        public Address() : this(Countries.Sverige, string.Empty)
        {
        }

        public Address(Countries country, string city) : this(string.Empty, city, string.Empty, country)
        { 
        }

        /// <summary>
        /// Address för att kopiera en annan Address.
        /// </summary>
        /// <param name="theOther">Den som ska kopieras.</param>
        public Address(Address theOther) : this(theOther.street, theOther.city, theOther.zipCode, theOther.country)
        {
        }

        /// <summary>
        /// Konstruktor för att skapa en ny Address.
        /// </summary>
        /// <param name="street">Gatunamn.</param>
        /// <param name="city">Stad.</param>
        /// <param name="zipCode">Zipkod.</param>
        /// <param name="country">Landet.</param>
        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        /// <summary>
        /// Hämtar en string som visar informationen i Address objektet.
        /// </summary>
        /// <returns>En string som beskriver en Address.</returns>
        public string GetAddressInfo()
        {
            string strOut = "\n" + "Address" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Street", street);
            strOut += string.Format(" {0,-10} {1, -10}\n", "City", city);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Zip code", zipCode);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Country", country);

            return strOut;
        }
    }
}
