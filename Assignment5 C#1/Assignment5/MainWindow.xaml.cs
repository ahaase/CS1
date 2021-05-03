using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager customerManager;

        public MainWindow()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            listView.ItemsSource = customerManager.Customers;
            resetTextBox();
        }

        /// <summary>
        /// Ställer om TextBoxen till höger i fönstret.
        /// </summary>
        private void resetTextBox()
        {
            textBox.Text = "Select a customer!";
        }

        /// <summary>
        /// Säger till användaren genom en MessageBox att den använder programmet fel.
        /// </summary>
        private void alertInvalidSelection()
        {
            MessageBox.Show("No customer selected!", "Error");
        }

        /// <summary>
        /// Gör att TextBoxen till höger i fönstret visar information om vald Customer.
        /// </summary>
        /// <param name="index">Vald index.</param>
        private void setTextBoxToCustomer(int index)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Customer information for ID: " + customerManager.GetCustomer(index).ID + "\n\n");
            sb.Append("Name: " + customerManager.GetCustomer(index).Name + "\n");
            sb.Append(customerManager.GetAddressInfo(index));
            sb.Append(customerManager.GetEmailInfo(index));
            sb.Append(customerManager.GetPhonesInfo(index));
            textBox.Text = sb.ToString();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ContactForm cf = new ContactForm(customerManager);
            cf.Show();
            listView.SelectedIndex = -1;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if(listView.SelectedIndex > -1)
            {
                ContactForm cf = new ContactForm(customerManager.GetCustomer(listView.SelectedIndex));
                cf.Show();
                listView.SelectedIndex = -1;
                return;
            }
            alertInvalidSelection();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedIndex > -1)
            {
                customerManager.DeleteCustomer(listView.SelectedIndex);
                return;
            }
            alertInvalidSelection();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listView.SelectedIndex >= 0)
            {
                setTextBoxToCustomer(listView.SelectedIndex);
                return;
            }
            resetTextBox();
        }
    }
}
