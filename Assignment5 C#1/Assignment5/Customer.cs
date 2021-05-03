using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Klass som hanterar en Customer.
    /// </summary>
    public class Customer : INotifyPropertyChanged
    {
        private Contact contact;
        private int id;

        /// <summary>
        /// Jag är tvungen att delegera för att uppdatera i ListView.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Säger till ListView att Contact är uppdaterad när användaren har ändrat med ContactForm.
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Hämtar och ställer in Contact objektet.
        /// </summary>
        public Contact Contact
        {
            get { return contact; }
            set 
            { 
                contact = value;
                NotifyPropertyChanged();
            }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Hämtar namn i format: "Efternamn, Förnamn".
        /// </summary>
        public string Name
        {
            get { return contact.LastName + ", " + contact.FirstName; }
        }

        /// <summary>
        /// Standardkonstruktor.
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Konstruktor för att kopiera en annan Customer.
        /// </summary>
        /// <param name="theOther">Den andra Customer.</param>
        public Customer(Customer theOther)
        {
            contact = theOther.contact;
        }

        /// <summary>
        /// Konstruktor för göra en ny Customer med en ny Contact.
        /// </summary>
        /// <param name="firstName">Förnamn.</param>
        /// <param name="lastName">Efternamn.</param>
        /// <param name="address">Address.</param>
        /// <param name="email">Email.</param>
        /// <param name="phone">Telefon.</param>
        public Customer(string firstName, string lastName, Address address, Email email, Phone phone)
        {
            contact = new Contact(firstName, lastName, address, email, phone);
        }
    }
}
