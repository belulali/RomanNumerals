using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class RomanNumerals
    {
        private readonly Dictionary<string, int> _romanNumbers = new Dictionary<string, int>()
            {
                {"M",1000}, 
                {"CM", 900}, 
                {"D" ,500}, 
                {"CD",400}, 
                {"C" ,100}, 
                {"CX",90}, 
                {"L" ,50}, 
                {"XL",40}, 
                {"X" ,10}, 
                {"IX",9}, 
                {"V" ,5}, 
                {"IV",4},
                {"I" ,1}
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
                var romanNumeral = GetRomanNumeralOf(number);
                result += romanNumeral;
                number -= GetDecimalValueOf(romanNumeral); 
            }
            return result;
            
        }

        private string GetRomanNumeralOf(int number)
        {
            return _romanNumbers.First(kv => kv.Value <= number).Key;
        }

        private int GetDecimalValueOf(string romanNumeral)
        {
            return _romanNumbers[romanNumeral];
        }
    }
}
