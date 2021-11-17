using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals.Services
{
    public class RomanNumeralsService
    {
        private IDictionary<char, int> _valuesByRomanChar = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        /// <summary>
        /// Retourne le nombre associé aux chiffres romains spécifiés.
        /// </summary>
        /// <param name="romanNumber">Nombre sous forme de chiffres romains.</param>
        /// <returns>Le nombre associé au chiffres romains.</returns>
        public int Parse(string romanNumber)
        {
            if (!ContainsOnlyRomanCaracters(romanNumber)) { throw new ArgumentException(nameof(romanNumber)); }

            var upperRomanNumber = romanNumber.ToUpperInvariant();
            var previousValue = 0;
            int total = 0;
            for (int i = upperRomanNumber.Length - 1; i >= 0; i--)
            {
                var romanChar = upperRomanNumber[i];
                var charValue = _valuesByRomanChar[romanChar];

                if (charValue >= previousValue)
                {
                    total += charValue;
                }
                else
                {
                    total -= charValue;
                }

                previousValue = charValue;
            }

            return total;
        }

        private bool ContainsOnlyRomanCaracters(string romanNumber)
        {
            var upperRomanNumber = romanNumber.ToUpperInvariant();
            foreach (char c in _valuesByRomanChar.Keys)
            {
                upperRomanNumber = upperRomanNumber.Replace(c.ToString(), string.Empty);
            }
            return upperRomanNumber.Length == 0;
        }
    }
}