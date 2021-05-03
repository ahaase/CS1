using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment6
{
    /// <summary>
    /// Klass som hanterar en lista med Tasks.
    /// </summary>
    class TaskManager
    {
        private ObservableCollection<Task> tasks;

        /// <summary>
        /// Hämtar listan för ListView att se.
        /// </summary>
        public ObservableCollection<Task> Tasks
        {
            get { return tasks; }
        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public TaskManager()
        {
            tasks = new ObservableCollection<Task>();
        }

        /// <summary>
        /// Kontrollerar att vald Index är inom listans gränser.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Om index är giltigt.</returns>
        public bool CheckIndex(int index)
        {
            if(index >= 0 && index < tasks.Count)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hämtar Task på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        /// <returns>Önskad Task.</returns>
        public Task Get(int index)
        {
            if(CheckIndex(index))
            {
                return tasks[index];
            }
            return null;
        }

        /// <summary>
        /// Lägger till en Task i listan.
        /// </summary>
        /// <param name="task">Task som ska läggas till.</param>
        public void Add(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// Ändrar Task på vald index genom att kopiera en vald Task.
        /// </summary>
        /// <param name="index">Vald task.</param>
        /// <param name="newTask">Ny task.</param>
        public void ChangeAt(int index, Task newTask)
        {
            if(CheckIndex(index))
            {
                tasks[index].DateAndTime = newTask.DateAndTime;
                tasks[index].Description = newTask.Description;
                tasks[index].Priority = newTask.Priority;
                tasks[index].TaskDate = newTask.TaskDate;
            }
        }

        /// <summary>
        /// Tar bort en task på vald index.
        /// </summary>
        /// <param name="index">Vald index.</param>
        public void RemoveAt(int index)
        {
            if(CheckIndex(index))
            {
                tasks.RemoveAt(index);
            }
        }
    }
}
