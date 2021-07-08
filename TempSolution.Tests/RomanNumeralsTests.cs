using System;
using System.Collections.Generic;
using Xunit;

namespace TempSolution.Tests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XII", 12)]
        [InlineData("XIII", 13)]
        [InlineData("XIV", 14)]
        [InlineData("XV", 15)]
        [InlineData("XVI", 16)]
        [InlineData("XVII", 17)]
        [InlineData("XVIII", 18)]
        [InlineData("XIX", 19)]
        [InlineData("XX", 20)]
        [InlineData("XXI", 21)]
        public void RomanShouldReturnNumeral(string roman, int expectedNumber)
        {
            RomanNumerals rn = new RomanNumerals();
            int resultNumber = rn.Parse(roman);
            Assert.Equal(expectedNumber, resultNumber);
        }

        [Fact]
        public void RomanShouldThrowWhenInInvalidCharacter()
        {
            string badRoman = "Xartyuio";
            RomanNumerals rn = new RomanNumerals();

            Assert.Throws<ArgumentException>(() => rn.Parse(badRoman));
        }
    }
}