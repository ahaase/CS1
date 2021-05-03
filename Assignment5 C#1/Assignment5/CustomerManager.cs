using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Klass som hanterar en lista med Customer.
    /// </summary>
    public class CustomerManager
    {
        /// <summary>
        /// ObservableCollection används för att ListView ska uppdateras automatiskt.
        /// </summary>
        private ObservableCollection<Customer> customers;

        private int nextID;

        /// <summary>
        /// Hämtar listan med Customers.
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public CustomerManager()
        {
            customers = new ObservableCollection<Customer>();
        }

        /// <summary>
        /// Lägger till en ny Customer.
        /// </summary>
        /// <param name="c">Customer som ska läggas till.</param>
        public void AddCustomer(Customer c)
        {
            customers.Add(c);
            c.ID = nextID;
            nextID++;
        }

        /// <summary>
        /// Byter ut en Customer i vald index.
        /// </summary>
        /// <param name="c">Nya Customer</param>
        /// <param name="index">Index till den som ska bytas ut.</param>
        public void ChangeCustomer(Customer c, int index)
        {
            if(CheckIndex(index))
            {
                customers[index] = c;
            }
        }

        /// <summary>
        /// Kontrollerar att index är giltigt.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Om den är giltig.</returns>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tar bort en Customer på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Om det gick att ta bort.</returns>
        public bool DeleteCustomer(int index)
        {
            if(CheckIndex(index))
            {
                customers.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hämtar en Customer på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Vald Customer.</returns>
        public Customer GetCustomer(int index)
        {
            if (CheckIndex(index))
            {
                return customers[index];
            }
            return null;
        }

        /// <summary>
        /// Hämtar AddressInfo från Customer på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Customerns AddressInfo.</returns>
        public string GetAddressInfo(int index)
        {
            if (CheckIndex(index))
            {
                return customers[index].Contact.Address.GetAddressInfo();
            }
            return string.Empty;
        }

        /// <summary>
        /// Hämtar EmailInfo från Customer på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Customerns EmailInfo.</returns>
        public string GetEmailInfo(int index)
        {
            if (CheckIndex(index))
            {
                return customers[index].Contact.Email.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Hämtar PhonesInfo från Customer på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Customerns PhonesInfo</returns>
        public string GetPhonesInfo(int index)
        {
            if (CheckIndex(index))
            {
                return customers[index].Contact.Phone.GetPhonesInfo();
            }
            return string.Empty;
        }

        public void TestValues()
        {

        }
    }
}
