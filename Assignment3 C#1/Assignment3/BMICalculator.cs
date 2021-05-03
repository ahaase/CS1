using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// Vilken enhet. Används för att avgöra vilken uträkning som ska göras.
    /// </summary>
    enum UnitTypes
    {
        Metric,
        Imperial
    }

    /// <summary>
    /// Räknar ut BMI.
    /// </summary>
    class BMICalculator
    {
        private string name;
        private double height; //m, feet
        private double weight; //kg, lbs
        private UnitTypes unit;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public BMICalculator()
        {
            name = "No name";
            height = 0;
            weight = 0;
        }

        /// <summary>
        /// Hämtar vilken vikt-kategori användaren är i.
        /// </summary>
        /// <returns>Viktkategori.</returns>
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal weight";
            }
            else if (bmi < 30)
            {
                return "Overweight (Pre-Obesity)";
            }
            else if(bmi < 35)
            {
                return "Overweight (Obesity class I)";
            }
            else if(bmi < 40)
            {
                return "Overweight (Obesity class II)";
            }
            return "Overweight (Obesity class III)";
        }

        /// <summary>
        /// Räknar ut och hämtar BMI.
        /// </summary>
        /// <returns>BMI.</returns>
        public double CalculateBMI()
        {
            if (unit == UnitTypes.Metric)
            {
                return weight / (height * height);
            }
            else if (unit == UnitTypes.Imperial)
            {
                return 703.0 * weight / (height * height);
            }
            else return 0;
        }

        /// <summary>
        /// Hämtar vikt.
        /// </summary>
        /// <returns>Vikt</returns>
        public double GetHeight()
        {
            return height;
        }
        
        /// <summary>
        /// Hämtar namn.
        /// </summary>
        /// <returns>Namn.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Hämtar vad för enhetssystem används.
        /// </summary>
        /// <returns>Enhet Metric eller Imperial.</returns>
        public UnitTypes GetUnit()
        {
            return unit;
        }

        /// <summary>
        /// Hämtar vikt.
        /// </summary>
        /// <returns>Vikt.</returns>
        public double GetWeight()
        {
            return weight;
        }

        /// <summary>
        /// Hämtar en sträng som visar normal BMI och vikt.
        /// </summary>
        /// <returns>Vad en normal vikt och BMI är.</returns>
        public string NormalWeight()
        {
            double factor = 0;
            string unitString = "";
            if(unit == UnitTypes.Metric)
            {
                unitString = "kg";
                factor = 1;
            }
            if(unit == UnitTypes.Imperial)
            {
                unitString = "lbs";
                factor = 703;
            }

            double w = height * height / factor;
            double w1 = w * 18.50; // low limit
            double w2 = w * 24.90; // high limit

            Console.WriteLine(w1 + " " + w2);
            return "Normal BMI is between 18.50 and 24.90\nNormal weight should be between " + w1 + " and " + w2 + " " + unitString;
        }

        /// <summary>
        /// Ställer in ny längd.
        /// </summary>
        /// <param name="value">Ny längd.</param>
        public void SetHeight(double value)
        {
            if(value > 0)
            {
                height = value;
            }
        }

        /// <summary>
        /// Ställer in nytt namn.
        /// </summary>
        /// <param name="value">Nytt namn.</param>
        public void SetName(string value)
        {
            if (value.Equals(""))
            {
                name = "No name";
                return;
            }
            name = value;
        }

        /// <summary>
        /// Ställer in enhetssystem.
        /// </summary>
        /// <param name="value">Enhet Imperial eller Metric.</param>
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        /// <summary>
        /// Ställer in ny vikt.
        /// </summary>
        /// <param name="value">Ny vikt.</param>
        public void SetWeight(double value)
        {
            if(value > 0)
            {
                weight = value;
            }
        }
    }
}
