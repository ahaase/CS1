using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Haase
/// </summary>
namespace Assignment6
{
    /// <summary>
    /// Enum för typ av prioritet.
    /// </summary>
    public enum PriorityType
    {
        Very_Important,
        Important,
        Normal,
        Less_Important,
        Not_Important
    }

    /// <summary>
    /// Innehåller en statisk metod som omvandlar en string till en PriorityType.
    /// </summary>
    public static class PriorityTypeConverter
    {
        /// <summary>
        /// Omvandlar en string till PriorityType.
        /// </summary>
        /// <param name="input">Inmatad string.</param>
        /// <returns>Ekvivalent PriorityType typ.</returns>
        public static PriorityType StringToPriorityType(string input)
        {
            switch(input)
            {
                case "Very_Important":
                    return PriorityType.Very_Important;
                case "Important":
                    return PriorityType.Important;
                case "Normal":
                    return PriorityType.Normal;
                case "Less_Important":
                    return PriorityType.Less_Important;
                case "Not_Important":
                    return PriorityType.Not_Important;
                default:
                    return PriorityType.Normal;
            }
        }
    }
}
