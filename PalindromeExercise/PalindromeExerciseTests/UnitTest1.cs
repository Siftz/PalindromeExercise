using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // test case
        [InlineData("hello", false)]   // not palindrome case
        [InlineData("Madam", true)]   // case-sensitive
        [InlineData("", true)]        // empty case
        [InlineData("A man with a plan a canal Panama", false)] // sentence w/ spacing and casing
        public void IsAPalindromeTest(string input, bool expected)
        {
            var WordSmith = new WordSmith(); // arrange
            
            var actual = WordSmith.IsPalindrome(input); // act
             
            Assert.Equal(expected, actual); // assert

        }
    }
}
