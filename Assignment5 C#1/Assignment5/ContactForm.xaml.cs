using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Interaction logic for ContactForm.xaml
    /// </summary>
    public partial class ContactForm : Window
    {
        private CustomerManager customerManager;
        private Customer customer;

        public ContactForm(CustomerManager cm)
        {
            InitializeComponent();
            InitializeGUI();
            customerManager = cm;
        }

        public ContactForm(Customer c)
        {
            InitializeComponent();
            InitializeGUI();
            customer = c;

            firstNameTextBox.Text = c.Contact.FirstName;
            lastNameTextBox.Text = c.Contact.LastName;
            homePhoneTextBox.Text = c.Contact.Phone.Home;
            workPhoneTextBox.Text = c.Contact.Phone.Work;
            businessEmailTextBox.Text = c.Contact.Email.Work;
            privateEmailTextBox.Text = c.Contact.Email.Personal;
            streetTextBox.Text = c.Contact.Address.Street;
            cityTextBox.Text = c.Contact.Address.City;
            zipCodeTextBox.Text = c.Contact.Address.ZipCode;
            countryComboBox.SelectedItem = c.Contact.Address.Country;
        }
        
        private void InitializeGUI()
        {
            countryComboBox.ItemsSource = Enum.GetValues(typeof(Countries));
            countryComboBox.SelectedIndex = 0;
        }

        private Customer newCustomer()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            Phone phone = new Phone(homePhoneTextBox.Text, workPhoneTextBox.Text);
            Email email = new Email(businessEmailTextBox.Text, privateEmailTextBox.Text);
            Address address = new Address(streetTextBox.Text, cityTextBox.Text,
                zipCodeTextBox.Text, (Countries)countryComboBox.SelectedItem);

            return new Customer(firstName, lastName, address, email, phone);
        }

        private void editCustomer(Customer c)
        {
            if(c.Contact.CheckData())
            {
                Phone phone = new Phone(homePhoneTextBox.Text, workPhoneTextBox.Text);
                Email email = new Email(businessEmailTextBox.Text, privateEmailTextBox.Text);
                Address address = new Address(streetTextBox.Text, cityTextBox.Text,
                    zipCodeTextBox.Text, (Countries)countryComboBox.SelectedItem);
                c.Contact = new Contact(firstNameTextBox.Text, lastNameTextBox.Text, address, email, phone);
            }
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if(customer == null)
            {
                customerManager?.AddCustomer(newCustomer());
            }
            else if(customerManager == null)
            {
                editCustomer(customer);
            }
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Close window", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
