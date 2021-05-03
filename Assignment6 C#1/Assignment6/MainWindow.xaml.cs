using Microsoft.Win32;
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
using System.Windows.Threading;

/// <summary>
/// Haase
/// </summary>
namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskManager taskManager;
        private DispatcherTimer timer;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
            taskManager = new TaskManager();
            listView.ItemsSource = taskManager.Tasks;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += dispatcherTimer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Startar om programmet.
        /// </summary>
        private void resetProgram()
        {
            resetInput();
            hourComboBox.Items.Clear();
            minuteComboBox.Items.Clear();
            InitializeGUI();
            taskManager = new TaskManager();
            listView.ItemsSource = taskManager.Tasks;
        }

        /// <summary>
        /// Ställer om värdena i GUI.
        /// </summary>
        private void resetInput()
        {
            toDoTextBox.Text = "";
            datePicker.SelectedDate = null;
            hourComboBox.SelectedIndex = -1;
            minuteComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Initierar GUI.
        /// </summary>
        private void InitializeGUI()
        {
            priorityComboBox.ItemsSource = Enum.GetValues(typeof(PriorityType));
            priorityComboBox.SelectedItem = PriorityType.Normal;
            changeButton.IsEnabled = false;
            deleteButton.IsEnabled = false;

            for (int i = 0; i < 24; i++)
            {
                hourComboBox.Items.Add(i);
            }

            for(int i = 0; i < 60; i += 5)
            {
                minuteComboBox.Items.Add(i);
            }
        }

        /// <summary>
        /// Hämtar en DateTime med tiden och datumen användaren har valt.
        /// </summary>
        /// <returns>Vald tid och datum.</returns>
        private DateTime getUserInputTime()
        {
            DateTime selectedDateAndTime = (DateTime)datePicker.SelectedDate;
            if (hourComboBox.SelectedIndex >= 0)
            {
                selectedDateAndTime = selectedDateAndTime.AddHours((int)hourComboBox.SelectedItem);
            }
            if (minuteComboBox.SelectedIndex >= 0)
            {
                selectedDateAndTime = selectedDateAndTime.AddMinutes((int)minuteComboBox.SelectedItem);
            }
            return selectedDateAndTime;
        }

        private void newCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure?\nUnsaved tasks will be lost.", "Confirm", MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes)
            {
                resetProgram();
            }
        }

        private void closeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit program", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(datePicker.SelectedDate != null)
            {
                taskManager.Add(new Task(getUserInputTime(), toDoTextBox.Text,
                    (PriorityType)priorityComboBox.SelectedItem));
            }
            else if (toDoTextBox.Text != string.Empty)
            {
                taskManager.Add(new Task(toDoTextBox.Text));
            }
            else
            {
                taskManager.Add(new Task());
            }
            resetInput();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            if(listView.SelectedIndex >= 0)
            {
                if(datePicker.SelectedDate != null)
                {
                    taskManager.ChangeAt(listView.SelectedIndex, new Task(getUserInputTime(),toDoTextBox.Text,
                        (PriorityType)priorityComboBox.SelectedItem));
                }
                else if(toDoTextBox.Text != string.Empty)
                {
                    taskManager.ChangeAt(listView.SelectedIndex, new Task(toDoTextBox.Text));
                }
                else
                {
                    taskManager.ChangeAt(listView.SelectedIndex, new Task());
                }
                resetInput();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(listView.SelectedIndex >= 0)
            {
                taskManager.RemoveAt(listView.SelectedIndex);
            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listView.SelectedIndex >= 0)
            {
                changeButton.IsEnabled = true;
                deleteButton.IsEnabled = true;
            }
            else
            {
                changeButton.IsEnabled = false;
                deleteButton.IsEnabled = false;
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timerLabel.Content = DateTime.Now.ToLongTimeString();
        }

        private void saveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Tasks";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != null && saveFileDialog.FileName != string.Empty)
            {
                try
                {
                    FileManager fm = new FileManager();
                    fm.SaveFile(saveFileDialog.FileName, taskManager);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }

        private void openCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text files (.txt)|*.txt";
            openFileDialog.ShowDialog();
            if(openFileDialog.FileName != null && openFileDialog.FileName != string.Empty)
            {
                try
                {
                    FileManager fm = new FileManager();
                    taskManager = fm.OpenFile(openFileDialog.FileName);
                    listView.ItemsSource = taskManager.Tasks;
                    resetInput();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }
    }
}
