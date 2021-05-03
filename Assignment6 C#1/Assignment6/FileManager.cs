using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment6
{
    /// <summary>
    /// Klass som öppnar och skriver till en fil.
    /// </summary>
    class FileManager
    {
        /// <summary>
        /// Konstruktor.
        /// </summary>
        public FileManager()
        {
        }

        /// <summary>
        /// Öppnar en vald fil och sparar informationen till en TaskManager.
        /// </summary>
        /// <param name="fileName">Vald fil.</param>
        /// <returns>TaskManager från filen.</returns>
        public TaskManager OpenFile(string fileName)
        {
            TaskManager newManager = new TaskManager();
            FileStream fs = null;
            StreamReader reader = null;
            if(File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Open);
                reader = new StreamReader(fs); try
                {
                    do
                    {
                        if (reader.EndOfStream)
                        {
                            return newManager;
                        }
                        DateTime date;
                        PriorityType priority;
                        string description;
                        if (reader.ReadLine().Equals("*Date and time:"))
                        {
                            date = new DateTime(long.Parse(reader.ReadLine()));
                        }
                        else throw new Exception("Invalid file! Maybe it's corrupted?");
                        if (reader.ReadLine().Equals("*Priority:"))
                        {
                            priority = PriorityTypeConverter.StringToPriorityType(reader.ReadLine());
                        }
                        else throw new Exception("Invalid file! Maybe it's corrupted?");
                        if (reader.ReadLine().Equals("*Description:"))
                        {
                            description = reader.ReadLine();
                        }
                        else throw new Exception("Invalid file! Maybe it's corrupted?");
                        newManager.Add(new Task(date, description, priority));
                    } while (reader.ReadLine() != null);
                    return newManager;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Load Failed! " + e.ToString());
                    throw e;
                }
                finally
                {
                    reader.Close();
                    fs.Close();
                }
            }
            else throw new Exception("Could not find file!");
        }

        /// <summary>
        /// Sparar informationen i en TaskManager till en textfil.
        /// </summary>
        /// <param name="fileName">Filens namn.</param>
        /// <param name="manager">TaskManagern som ska sparas.</param>
        public void SaveFile(string fileName, TaskManager manager)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            try
            {
                for(int i = 0; i < manager.Tasks.Count; i++)
                {
                    writer.Write(manager.Get(i).ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Save Failed! " + e.ToString());
                throw e;
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }
    }
}
