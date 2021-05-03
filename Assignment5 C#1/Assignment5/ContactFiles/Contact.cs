using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Klass som beskriver ett Contact objekt.
    /// </summary>
    public class Contact
    {
        private Phone phone;
        private Email email;
        private Address address;

        private string firstName;
        private string lastName;

        /// <summary>
        /// Telefon.
        /// </summary>
        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// Email.
        /// </summary>
        public Email Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Address.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Förnamn.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Efternamn.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Kontrollerar att inget värde är null.
        /// </summary>
        /// <returns>Om datan går att använda.</returns>
        public bool CheckData()
        {
            if(email == null || phone == null || address == null
                || firstName == null || lastName == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Standardkonstruktor.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Konstruktor för att kopiera en Contact.
        /// </summary>
        /// <param name="theOther">Den andra contact.</param>
        public Contact(Contact theOther)
        {
            firstName = theOther.firstName;
            lastName = theOther.lastName;
            phone = theOther.phone;
            email = theOther.email;
            address = theOther.address;
        }

        /// <summary>
        /// Konstruktor för att göra en ny contact med nya värden.
        /// </summary>
        /// <param name="firstName">Förnamn.</param>
        /// <param name="lastName">Efternamn.</param>
        /// <param name="address">Address.</param>
        /// <param name="email">Email.</param>
        /// <param name="phone">Telefon.</param>
        public Contact(string firstName, string lastName, Address address, Email email, Phone phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
    }
}
