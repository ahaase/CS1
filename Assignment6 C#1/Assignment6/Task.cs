using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment6
{
    /// <summary>
    /// Klass som beskriver och hanterar en Task.
    /// </summary>
    public class Task : INotifyPropertyChanged
    {
        private DateTime date;
        private string description;
        private PriorityType priority;

        /// <summary>
        /// Används för ListView.
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
        /// H
        /// </summary>
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Hämtar eller ställer in string description för Task.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Hämtar eller ställer in PriorityType priority för Task.
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        /// <summary>
        /// Hämtar eller ställer in DateTime date för Task.
        /// </summary>
        public DateTime TaskDate
        {
            get { return date; }
            set
            { 
                date = value;
                TaskTimeString = ""; // För att få den att kalla NotifyPropertyChanged().
                TaskDateString = ""; // När vi gör det så uppdateras ListView.
            }
        }

        /// <summary>
        /// Property som hämtar en string med GetDateString().
        /// Egentligen readonly. Set kallar endast på NotifyPropertyChanged().
        /// </summary>
        public string TaskDateString
        {
            get { return GetDateString(); }
            set { NotifyPropertyChanged(); }
        }

        /// <summary>
        /// Property som hämtar en string med GetTimeString().
        /// Egentligen readonly. Set kallar endast på NotifyPropertyChanged().
        /// </summary>
        public string TaskTimeString
        {
            get { return GetTimeString(); }
            set { NotifyPropertyChanged(); }
        }

        /// <summary>
        /// Hämtar priority fast en string.
        /// </summary>
        /// <returns>Priority string.</returns>
        public string GetPriorityString()
        {
            return priority.ToString();
        }

        /// <summary>
        /// Hämtar en string som beskriver datumet en Task har.
        /// </summary>
        /// <returns>Datumen som en string.</returns>
        private string GetDateString()
        {
            return date.Day + "/" + date.Month + "/" + date.Year;
        }

        /// <summary>
        /// Hämtar en string som beskriver tiden en Task har.
        /// </summary>
        /// <returns>Tiden som en string.</returns>
        private string GetTimeString()
        {
            return (date.Hour < 10 ? ("0" + date.Hour.ToString()) : date.Hour.ToString()) + ":"
                + (date.Minute < 10 ? ("0" + date.Minute.ToString()) : date.Minute.ToString());
        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public Task() : this(DateTime.Now)
        {

        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="taskDate">DateTime objektet för Task-en.</param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {

        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="description">Task-ens beskrivning.</param>
        public Task(string description) : this(DateTime.Now, description, PriorityType.Normal)
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="taskDate">DateTime objektet för Task-en.</param>
        /// <param name="description">Beskrivningen av Task-en.</param>
        /// <param name="priority">Task-ens prioritet.</param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        /// <summary>
        /// Hämtar informationen i Task som en string.
        /// </summary>
        /// <returns>Informationen i Task i textformat.</returns>
        public override string ToString()
        {
            string strOut = "";
            strOut += "*Date and time:\n";
            strOut += date.Ticks + "\n";
            strOut += "*Priority:\n";
            strOut += priority.ToString() + "\n";
            strOut += "*Description:\n";
            strOut += description + "\n\n";
            return strOut;
        }
    }
}
