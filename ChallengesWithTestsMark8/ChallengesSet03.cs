using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var verdict = false;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                verdict = true;
            }
            return verdict;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var oddSum = 0;
            if(numbers != null)
            {
                foreach (int i in numbers)
                {
                    if (i %2 != 0)
                    {
                        oddSum = oddSum + i;
                    }
                }
                if (oddSum %2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lowerCheck = false;
            var upperCheck = false;
            var numCheck = false;
            foreach (char i in password) 
            { 
                if (char.IsUpper(i)) { upperCheck = true; }
                if (char.IsLower(i)) { lowerCheck = true; }
                if (char.IsNumber(i)) { numCheck = true; } 
            }
            if (upperCheck == true && lowerCheck == true && numCheck == true) { return true; }
            else { return false; }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend != 0 && divisor != 0)
            return Math.Round(dividend / divisor, 4);
            else return 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            var oddsBelow100 = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0) { oddsBelow100.Add(i); }
            }
            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
