using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// Räknar ut bränsleanvändning.
    /// </summary>
    class FuelCalculator
    {
        private double currReading;
        private double fuelAmount;
        private double prevReading;
        private double unitPrice;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public FuelCalculator()
        {

        }

        /// <summary>
        /// Räknar ut hur långt en liter tar en.
        /// </summary>
        /// <returns>Hur långt man kommer med en liter.</returns>
        public double CalcKilometerPerLiter()
        {
            return getDistance() / fuelAmount;
        }

        /// <summary>
        /// Räknar ut hur mycket bränsle behövs för att åka en mile.
        /// </summary>
        /// <returns>Hut mycket bränsle behövs för en mile.</returns>
        public double CalcConsumptionPerMetricMile()
        {
            const double kmToMileFactor = 0.621371192;
            return CalcFuelConsumptionPerKm() / kmToMileFactor;
        }

        /// <summary>
        /// Räknar ut hur mycket det kostar att köra en kilometer.
        /// </summary>
        /// <returns>Kostnaden för att köra en kilometer.</returns>
        public double CalcCostPerKm()
        {
            return CalcFuelConsumptionPerKm() * unitPrice;
        }

        /// <summary>
        /// Räknar ut hur mycket bränsle används för att köra en kilometer.
        /// </summary>
        /// <returns>Bränsle per kilometer.</returns>
        public double CalcFuelConsumptionPerKm()
        {
            return fuelAmount / getDistance();
        }

        /// <summary>
        /// Räknar ut hur mycket bränsle används för att köra en mil.
        /// </summary>
        /// <returns>Bränsle per mil.</returns>
        public double CalcFuelConsumptionPerSweMil()
        {
            return CalcFuelConsumptionPerKm() * 10;
        }

        /// <summary>
        /// Hämtar odometerns nuvarande värde.
        /// </summary>
        /// <returns>Hur långt bilen har kört.</returns>
        public double GetCurrentReading()
        {
            return currReading;
        }

        /// <summary>
        /// Hämtar hur mycket bränsle som tankats i bilen.
        /// </summary>
        /// <returns>Bränsle som tankats.</returns>
        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        /// <summary>
        /// Hämtar den förra mätningen.
        /// </summary>
        /// <returns>Förra mätningen i odometern.</returns>
        public double GetPreviousReading()
        {
            return prevReading;
        }

        /// <summary>
        /// Hämtar vad bränslet kostar för en liter.
        /// </summary>
        /// <returns>Pris för bränsle.</returns>
        public double GetUnitPrice()
        {
            return unitPrice;
        }

        /// <summary>
        /// Ställer in den nuvarande mätningen i odometern.
        /// </summary>
        /// <param name="newValue">Nytt värde.</param>
        public void SetCurrentReading(double newValue)
        {
            if(newValue > prevReading)
            {
                currReading = newValue;
            }
        }

        /// <summary>
        /// Ställer in hur mycket bränsle tankades sist.
        /// </summary>
        /// <param name="newValue">Senaste tankningen i liter.</param>
        public void SetFuelAmount(double newValue)
        {
            fuelAmount = newValue;
        }

        /// <summary>
        /// Ställer in den förra mätningen i odometern.
        /// </summary>
        /// <param name="newValue">Den förra mätningens värde.</param>
        public void SetPreviousReading(double newValue)
        {
            if (newValue >= 0)
            {
                prevReading = newValue;
            }
            else prevReading = 0;
        }

        /// <summary>
        /// Ställer in priset för bränslet.
        /// </summary>
        /// <param name="newValue">Pris per liter.</param>
        public void SetUnitPrice(double newValue)
        {
            if(newValue > 0)
            {
                unitPrice = newValue;
            }
        }

        /// <summary>
        /// Kontrollerar om odometern har giltiga värden.
        /// </summary>
        /// <returns>Om currReading är större än prevReading.</returns>
        public bool ValidateOdometerValues()
        {
            if(currReading >= prevReading)
            {
                return true;
            }
            return false;
        }

        private double getDistance()
        {
            return currReading - prevReading;
        }
    }
}
