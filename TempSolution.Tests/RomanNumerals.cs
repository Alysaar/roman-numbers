using System;
using System.Linq;

namespace TempSolution.Tests
{
    public class RomanNumerals
    {
        /// <summary>
        /// Retourne le nombre associé au chiffres romains.
        /// </summary>
        /// <param name="romanNumber">Nombre sous forme de chiffres romains.</param>
        /// <returns>Le nombre associé au chiffres romains.</returns>
        public int Parse(string romanNumber)
        {
            return romanNumber switch
            {
                "I" => 1,
                "II" => 2,
                "III" => 3,
                "IV" => 4, 
                "V" => 5,
                "VI" => 6,
                "VII" => 7,
                "VIII" => 8,
                "IX" => 9,
                "X" => 10,
                "XI" => 11,
                _ => throw new NotImplementedException()
            };

            // On peut donc voir I ==> 1 
            // V ==> 5 
            // X ==> 10
            // mots de 4 lettres max


        }
    }
}