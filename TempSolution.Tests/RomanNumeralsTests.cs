using System.Collections.Generic;
using Xunit;

namespace TempSolution.Tests
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void UnitesRomainesShouldReturnUnites()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();
            List<string> unitesRomaines = new List<string>()
            {
                "I",
                "II",
                "III",
                "IV",
                "V",
                "VI",
                "VII",
                "VIII",
                "IX"
            };
            List<int> resultats = new List<int>();
            List<int> expected = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };


            // Act (When)
            foreach (string uniteRomaine in unitesRomaines)
            {
                resultats.Add(rn.Parse(uniteRomaine));
            };

            // Assert (Then)
            Assert.Equal(expected, resultats);
        }

        [Fact]
        public void IIShouldReturn2()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("II");

            // Assert (Then)
            Assert.Equal(2, number);
        }

        [Fact]
        public void IIIShouldReturn3()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("III");

            // Assert (Then)
            Assert.Equal(3, number);
        }

        [Fact]
        public void IVShouldReturn4()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("IV");

            // Assert (Then)
            Assert.Equal(4, number);
        }

        [Fact]
        public void VShouldReturn5()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("V");

            // Assert (Then)
            Assert.Equal(5, number);
        }

        [Fact]
        public void VIShouldReturn6()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("VI");

            // Assert (Then)
            Assert.Equal(6, number);
        }

        [Fact]
        public void VIIShouldReturn7()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("VII");

            // Assert (Then)
            Assert.Equal(7, number);
        }

        [Fact]
        public void VIIIShouldReturn8()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("VIII");

            // Assert (Then)
            Assert.Equal(8, number);
        }

        [Fact]
        public void IXShouldReturn9()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("IX");

            // Assert (Then)
            Assert.Equal(9, number);
        }

        [Fact]
        public void XShouldReturn10()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("X");

            // Assert (Then)
            Assert.Equal(10, number);
        }

        [Fact]
        public void XIShouldReturn11()
        {
            // Arrange (Given)
            RomanNumerals rn = new RomanNumerals();

            // Act (When)
            int number = rn.Parse("XI");

            // Assert (Then)
            Assert.Equal(11, number);
        }
    }
}