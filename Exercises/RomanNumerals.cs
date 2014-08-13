using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class RomanNumerals
    {
        private readonly Dictionary<int, string> _romanNumbers = new Dictionary<int, string>()
            {
                {1000, "M"}, 
                {900, "CM"}, 
                {500, "D"}, 
                {400, "CD"}, 
                {100, "C"}, 
                {90, "CX"}, 
                {50, "L"}, 
                {40, "XL"}, 
                {10, "X"}, 
                {9, "IX"}, 
                {5, "V"}, 
                {4, "IV"},
                {1, "I"}
            };

        public string Transform(int number)
        {
            // Initialize an empty variable that will contain roman numbers
            // Determine the closest roman number
            // Add the roman number to the string
            // Subtract the value of the roman number from the number
            // if number zero then exit and return string
            // Other wise start again

            var result = "";

            while (number != 0)
            {
                var closestValue = ClosestValue(number);
                result += closestValue.Single().Value;
                number -= closestValue.Single().Key; 
            }
            return result;
            
        }

        private Dictionary<int, string> ClosestValue(int number)
        {
            var romanNumeralsDictonary = new Dictionary<int, string>();
           
            foreach (var romanNumber in _romanNumbers.Keys)
            {
                if (romanNumber <= number)
                {
                    romanNumeralsDictonary.Add(romanNumber, _romanNumbers[romanNumber]);
                    return romanNumeralsDictonary;
                }

            }
            
            return romanNumeralsDictonary;
        }
    }
}
