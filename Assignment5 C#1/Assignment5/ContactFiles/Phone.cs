using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// Klass som beskriver och hanterar ett Phone objekt.
    /// </summary>
    public class Phone
    {
        private string homePhone;
        private string workPhone;

        /// <summary>
        /// Hemtelefon.
        /// </summary>
        public string Home
        {
            get { return homePhone; }
            set { homePhone = value; }
        }
        
        /// <summary>
        /// Jobbtelefon.
        /// </summary>
        public string Work
        {
            get { return workPhone; }
            set { workPhone = value; }
        }

        /// <summary>
        /// Standardkonstruktor.
        /// </summary>
        public Phone()
        {

        }
        
        /// <summary>
        /// Konstruktor för att kopiera ett annat Phone objekt.
        /// </summary>
        /// <param name="theOther">Den som ska kopieras.</param>
        public Phone(Phone theOther)
        {
            homePhone = theOther.homePhone;
            workPhone = theOther.workPhone;
        }

        /// <summary>
        /// Konstruktor för att skapa ny Phone med nya värden.
        /// </summary>
        /// <param name="homePhone">Hemtelefon.</param>
        /// <param name="workPhone">Jobbtelefon.</param>
        public Phone(string homePhone, string workPhone)
        {
            this.homePhone = homePhone;
            this.workPhone = workPhone;
        }


        /// <summary>
        /// Hämtar en string som visar informationen i Phone objektet.
        /// </summary>
        /// <returns>En string som beskriver en Phone.</returns>
        public string GetPhonesInfo()
        {
            string strOut = "\n" + "Phones" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Home", homePhone);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Work", workPhone);

            return strOut;
        }

    }
}
