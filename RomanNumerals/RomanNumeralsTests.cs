using RomanNumerals.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("i", 1)]
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
        [InlineData("XXIX", 29)]
        [InlineData("XXX", 30)]
        [InlineData("L", 50)]
        [InlineData("LI", 51)]
        [InlineData("LIV", 54)]
        [InlineData("LVI", 56)]
        [InlineData("LX", 60)]
        [InlineData("XCIX", 99)] // Upper case.
        [InlineData("xcix", 99)] // Lower case.
        [InlineData("xCIx", 99)] // Baltringue case.
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MMMDCCXXIV", 3724)]
        public void RomanShouldReturnNumeral(string roman, int expectedNumber)
        {
            RomanNumeralsService rn = new RomanNumeralsService();
            int resultNumber = rn.Parse(roman);
            Assert.Equal(expectedNumber, resultNumber);
        }

        // TODO : test chaîne vide
        // TODO : test valeur ayant des caractères valides, mais dans le "mauvais ordre".
        // TODO : test IC = 99 -> idem caractères dans le "mauvais ordre"
        // TODO : nombre jusqu'à 4999. quoi faire avec 5000 et plus.

        [Fact]
        public void RomanShouldThrowWhenInInvalidCharacter()
        {
            string badRoman = "Xartyuio";
            RomanNumeralsService rn = new RomanNumeralsService();

            Assert.Throws<ArgumentException>(() => rn.Parse(badRoman));
        }
    }
}