using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    /// <summary>
    /// Räknar ut kaloriintag.
    /// </summary>
    class CalorieCalculator
    {
        private int activityLevel;
        private int age;
        private double height;
        private bool isFemale;
        private double weight;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public CalorieCalculator()
        {

        }


        /// <summary>
        /// Räknar ut och hämtar BMR.
        /// </summary>
        /// <returns>BMR</returns>
        public double CalcBasMetabolicRateBMR()
        {
            double bmr = (10 * weight) + (6.25 * height) - (5 * age);

            if (isFemale)
                return bmr - 161;
            return bmr + 5;
        }

        //public void DefaultValues()
        //{

        //}

        /// <summary>
        /// Hämtar åldern
        /// </summary>
        /// <returns>Åldern.</returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// Hämtar höjden.
        /// </summary>
        /// <returns>Höjden.</returns>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Hämtar vikten.
        /// </summary>
        /// <returns>Vikten.</returns>
        public double GetWeight()
        {
            return weight;
        }

        /// <summary>
        /// Hämtar hur många kalorier personen måste ta in för att gå upp eller ner i vikt.
        /// </summary>
        /// <param name="weight">Hur mycket vikt personen ska gå upp eller ner.</param>
        /// <param name="lose">Om personen ska gå ner i vikt.</param>
        /// <returns>Hur mycket personen ska äta.</returns>
        public double LoseOrGainWeightCalories(double weight, bool lose)
        {
            if (lose)
                weight = weight * -1;
            return MaintainWeightCalories() + weight;
        }

        /// <summary>
        /// Hämtar kalorier för att personen varken ska gå upp eller ner i vikt.
        /// </summary>
        /// <returns>Hur mycket personen ska äta för att inte ändra sin vikt.</returns>
        public double MaintainWeightCalories()
        {
            return CalcBasMetabolicRateBMR() * getActivityLevelFactor();
        }

        /// <summary>
        /// Ställer in Activity Level.
        /// </summary>
        /// <param name="newValue">Nya Activity Level.</param>
        public void SetActivityLevel(int newValue)
        {
            activityLevel = newValue;
        }

        /// <summary>
        /// Ställer in ålder.
        /// </summary>
        /// <param name="newValue">Nya åldern.</param>
        public void SetAge(int newValue)
        {
            age = newValue;
        }

        /// <summary>
        /// Ställer in kön.
        /// </summary>
        /// <param name="newValue">Om personen är en kvinna.</param>
        public void SetGender(bool newValue)
        {
            isFemale = newValue;
        }

        /// <summary>
        /// Ställer in höjd.
        /// </summary>
        /// <param name="newValue">Nya höjden.</param>
        public void SetHeight(double newValue)
        {
            height = newValue;
        }

        /// <summary>
        /// Ställer in vikt.
        /// </summary>
        /// <param name="newValue">Nya vikten.</param>
        public void SetWeight(double newValue)
        {
            weight = newValue;
        }

        /// <summary>
        /// Hämtar decimal-summan som ska räknas med beroende på hur aktiv personen är.
        /// </summary>
        /// <returns>Activity Level.</returns>
        private double getActivityLevelFactor()
        {
            switch(activityLevel)
            {
                case 0:
                    return 1.2;
                case 1:
                    return 1.375;
                case 2:
                    return 1.550;
                case 3:
                    return 1.725;
                case 4:
                    return 1.9;
                default:
                    return 0;
            }
        }
    }
}
