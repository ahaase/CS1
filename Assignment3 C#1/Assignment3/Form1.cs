using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Funktionaliteten i GUI:n.
    /// </summary>
    public partial class Form1 : Form
    {
        private BMICalculator bmiCalc;
        private FuelCalculator fuelCalc;
        private CalorieCalculator bmrCalc;
        /// <summary>
        /// Konstruktor för Form1.
        /// </summary>
        public Form1()
        {
            bmiCalc = new BMICalculator();
            fuelCalc = new FuelCalculator();
            bmrCalc = new CalorieCalculator();
            InitializeComponent();
            initializeGUI();
        }

        /// <summary>
        /// Ställer in lite grejer till start-värden.
        /// </summary>
        private void initializeGUI()
        {
            metricRadioButton.Checked = true;
        }

        #region BMI stuff
        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bmiCalc.SetUnit(UnitTypes.Metric);
            heightLabel.Text = "Height (cm)";
            weightLabel.Text = "Weight (kg)";
            heightTextBoxInches.Visible = false;
        }

        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bmiCalc.SetUnit(UnitTypes.Imperial);
            heightLabel.Text = "Height (ft and in)";
            weightLabel.Text = "Weight (lbs)";
            heightTextBoxInches.Visible = true;
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            updateGUIBMI();
        }

        /// <summary>
        /// Uppdaterar BMI-delen av GUI. Sker när användaren trycker på knappen.
        /// </summary>
        private void updateGUIBMI()
        {
            readName();
            readHeight();
            readWeight();
            weightCategoryTextBox.Text = bmiCalc.BmiWeightCategory();
            BMITextBox.Text = bmiCalc.CalculateBMI().ToString("N2");
            normalWeightLabel.Text = bmiCalc.NormalWeight();
        }

        /// <summary>
        /// Läser in vad användaren har matat in i textboxen för namn och ställer in namnet.
        /// </summary>
        private void readName()
        {
            nameTextBox.Text.Trim();
            if(!string.IsNullOrEmpty(nameTextBox.Text))
            {
                bmiCalc.SetName(nameTextBox.Text);
                resultsGroupBox.Text = "Results for " + bmiCalc.GetName();
            }
            else
            {
                bmiCalc.SetName("No name");
            }
        }

        /// <summary>
        /// Läser in vad användaren har matat in för längd och ställer in längden.
        /// </summary>
        private void readHeight()
        {
            if (bmiCalc.GetUnit() == UnitTypes.Metric)
            {
                double cmValue = 0;
                if (double.TryParse(heightTextBox.Text, out cmValue))
                {
                    bmiCalc.SetHeight(cmValue / 100);
                    bmrCalc.SetHeight(cmValue);
                }
            }

            else if (bmiCalc.GetUnit() == UnitTypes.Imperial)
            {
                double ftValue = 0;
                double inchValue = 0;
                double.TryParse(heightTextBox.Text, out ftValue);
                double.TryParse(heightTextBoxInches.Text, out inchValue);
                bmiCalc.SetHeight((ftValue * 12.00) + inchValue);
                bmrCalc.SetHeight((ftValue * 12.00) + inchValue);
            }
        }

        /// <summary>
        /// Ställer in vad användaren har matat in för vikt och ställer in vikten.
        /// </summary>
        private void readWeight()
        {
            double weight = 0;

            if (double.TryParse(weightTextBox.Text, out weight))
            {
                bmiCalc.SetWeight(weight);
                bmrCalc.SetWeight(weight);
            }
        }

        #endregion

        #region Fuel stuff
        private void calculateFuelButton_Click(object sender, EventArgs e)
        {
            updateGUIFuel();
        }

        /// <summary>
        /// Uppdaterar grafiska grännsnittet efter att användaren har tryckt på knappen.
        /// Fyller i alla TextBox med den uträknade informationen.
        /// </summary>
        private void updateGUIFuel()
        {
            if(readPrev() && readCurr() && readFuelTanked() && readPricePerLiter())
            {
                if (fuelCalc.ValidateOdometerValues())
                {
                    kmLiterFCTextBox.Text = fuelCalc.CalcKilometerPerLiter().ToString("N2");
                    literKmFCTextBox.Text = fuelCalc.CalcFuelConsumptionPerKm().ToString("N2");
                    literMetricMileFCTextBox.Text = fuelCalc.CalcConsumptionPerMetricMile().ToString("N2");
                    literSweMilFCTextBox.Text = fuelCalc.CalcFuelConsumptionPerSweMil().ToString("N2");
                    costKmTextBox.Text = fuelCalc.CalcCostPerKm().ToString("N2");
                }
            }
        }

        /// <summary>
        /// Läser in och ställer in den nuvarande mätningen
        /// </summary>
        /// <returns>Om det gick att ställa in.</returns>
        private bool readCurr()
        {
            double reading = 0;
            if(double.TryParse(currentOdometerTextBox.Text, out reading))
            {
                fuelCalc.SetCurrentReading(reading);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Läser in och ställer in den förra mätningen
        /// </summary>
        /// <returns>Om det gick att ställa in.</returns>
        private bool readPrev()
        {
            double reading = 0;
            if (double.TryParse(previousOdometerTextBox.Text, out reading))
            {
                fuelCalc.SetPreviousReading(reading);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Läser in och ställer in hur mycket bränsle som har tankats.
        /// </summary>
        /// <returns>Om det gick att ställa in.</returns>
        private bool readFuelTanked()
        {
            double fuelTanked = 0;
            if (double.TryParse(fuelTankedTextBox.Text, out fuelTanked))
            {
                fuelCalc.SetFuelAmount(fuelTanked);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Läser in och ställer in hur mycket en liter kostar.
        /// </summary>
        /// <returns>Om det gick att ställa in.</returns>
        private bool readPricePerLiter()
        {
            double price = 0;
            if (double.TryParse(literPriceTextBox.Text, out price))
            {
                fuelCalc.SetUnitPrice(price);
                return true;
            }
            return false;
        }
        #endregion

        #region BMR stuff
        private void calculateBMRButton_Click(object sender, EventArgs e)
        {
            updateGUIBMR();
        }


        /// <summary>
        /// Uppdaterar grafiska grännsnittet efter att användaren har tryckt på knappen.
        /// Fyller i ListBoxen med lämplig information.
        /// </summary>
        private void updateGUIBMR()
        {
            readHeight();
            readWeight();
            readAge();
            readGender();
            readActivityLevel();
            readName();
            BMRResultsTextBox.Text = textForBMRListBox();
        }

        /// <summary>
        /// Läser in och ställer in åldern.
        /// </summary>
        /// <returns>Om det gick att ställa in.</returns>
        private bool readAge()
        {
            int age;
            if(int.TryParse(ageTextBox.Text, out age))
            {
                if(age >= 0)
                {
                    bmrCalc.SetAge(age);
                }
            }
            return false;
        }

        /// <summary>
        /// Läser in vilket kön användaren har använt.
        /// </summary>
        /// <returns>Om någon giltig RadioButton är vald.</returns>
        private bool readGender()
        {
            if(femaleRadioButton.Checked)
            {
                bmrCalc.SetGender(true);
                return true;
            }
            else if(maleRadioButton.Checked)
            {
                bmrCalc.SetGender(false);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Läser in vilken Activity Level användaren har angett.
        /// </summary>
        /// <returns>Om någon giltig RadioButton var vald.</returns>
        private bool readActivityLevel()
        {
            if(sedentaryRadioButton.Checked)
            {
                bmrCalc.SetActivityLevel(0);
                return true;
            }
            else if(lightlyActiveRadioButton.Checked)
            {
                bmrCalc.SetActivityLevel(1);
                return true;
            }
            else if(moderatelyActiveRadioButton.Checked)
            {
                bmrCalc.SetActivityLevel(2);
                return true;
            }
            else if(veryActiveRadioButton.Checked)
            {
                bmrCalc.SetActivityLevel(3);
                return true;
            }
            else if(extraActiveRadioButton.Checked)
            {
                bmrCalc.SetActivityLevel(4);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Skapar en string för ListBox med BMR resultat.
        /// </summary>
        /// <returns>String med BMR resultat.</returns>
        private string textForBMRListBox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BMR Results for " + bmiCalc.GetName());
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Your BMR (calories / day)\t\t\t\t" + bmrCalc.CalcBasMetabolicRateBMR().ToString("N2"));
            sb.AppendLine();
            sb.Append("Calories to maintain your weight\t\t\t" + bmrCalc.MaintainWeightCalories().ToString("N2"));
            sb.AppendLine();
            sb.Append("Calories to lose 0,5 kg per week\t\t\t" + bmrCalc.LoseOrGainWeightCalories(500, true).ToString("N2"));
            sb.AppendLine();
            sb.Append("Calories to lose 1 kg per week\t\t\t\t" + bmrCalc.LoseOrGainWeightCalories(1000, true).ToString("N2"));
            sb.AppendLine();
            sb.Append("Calories to gain 0,5 kg per week\t\t\t" + bmrCalc.LoseOrGainWeightCalories(500, false).ToString("N2"));
            sb.AppendLine();
            sb.Append("Calories to gain 1 kg per week\t\t\t\t" + bmrCalc.LoseOrGainWeightCalories(1000, false).ToString("N2"));
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Losing more than 1000 calories per day is to be avoided.");

            return sb.ToString();
        }
        #endregion
    }
}
