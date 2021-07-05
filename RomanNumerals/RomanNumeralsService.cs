using System;
using System.Linq;

namespace RomanNumerals.Services
{
    public class RomanNumeralsService
    {
        /// <summary>
        /// Retourne le nombre associé aux chiffres romains spécifiés.
        /// </summary>
        /// <param name="romanNumber">Nombre sous forme de chiffres romains.</param>
        /// <returns>Le nombre associé au chiffres romains.</returns>
        public int Parse(string romanNumber)
        {
            if (!ContainsOnlyRomanCaracters(romanNumber)) { throw new ArgumentException(nameof(romanNumber)); }

            var number = 0;
            if (romanNumber.StartsWith("XX"))
            {
                number += 20;
            }
            else if (romanNumber.StartsWith("X"))
            {
                number += 10;
            }

            int unite = GetUnit(romanNumber.TrimStart('X'));

            return number + unite;

            // On peut donc voir I ==> 1 
            // V ==> 5 
            // X ==> 10
            // mots de 4 lettres max


        }

        private bool ContainsOnlyRomanCaracters(string romanNumber)
        {
            return romanNumber
                .Replace("X", "")
                .Replace("V", "")
                .Replace("I", "")
                .Count() == 0;
        }

        private static int GetUnit(string romanNumber)
        {
            //if(romanNumber.Contains())
            int resultat = 0;
            foreach (char cha in romanNumber)
            {
                switch (cha)
                {
                    case 'I': resultat += 1; break;
                    case 'V':
                        if (resultat > 0)
                        {
                            resultat = -resultat;
                        }
                        resultat += 5;
                        break;
                    case 'X':
                        if (resultat > 0)
                        {
                            resultat = -resultat;
                        }
                        resultat += 10;
                        break;
                }
            }
            return resultat;

            /*return romanNumber.TrimStart('X') switch
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
                _ => 0,
            };*/
        }

    }
}