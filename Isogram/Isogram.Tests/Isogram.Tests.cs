using System;
using Xunit;
using Isogram;


namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HoldTrueForEmptyString()
        {
            Assert.True(IsogramChecker.CheckIfIsogram(""));
        }
        [Fact]
        public void HoldTrueForWord()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("isogram"));
        }
        [Fact]
        public void HoldFalseForEleven()
        {
            Assert.False(IsogramChecker.CheckIfIsogram("eleven"));
        }
        [Fact]
        public void HoldTrueForLongWord()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void HoldTrueForMixedCase()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("Alphabet"));
        }
        [Fact]
        public void HoldTrueForHyphenWord()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void HoldTrueForDuplicateHyphen()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("six-year-old"));
        }
        [Fact]
        public void HoldTrueForSpaceSeparated()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("abcd efghijk"));
        }
        [Fact]
        public void HoldTrueForSpaceSeparatewd()
        {
            Assert.True(IsogramChecker.CheckIfIsogram("abcd efghijk lmno"));
        }
    }
}
