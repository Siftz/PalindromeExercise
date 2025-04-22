using System;
using System.Collections.Generic;
using System.Linq;
namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string input) // method
    {
        //return false; // temp return 
        var normalized = input.ToLower();

        var reversed = new string(normalized.Reverse().ToArray());
        return normalized == reversed;
    }

}