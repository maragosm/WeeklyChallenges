using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var answer = 0;
            var currentCheck = startNumber;
            do
            {
                currentCheck++;
                if (currentCheck % n == 0) { answer = currentCheck; }
            } while (answer == 0);
            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var busine in businesses)
            {
                if (busine.TotalRevenue <= 0) { busine.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                int[] numbersOrdered = new int[numbers.Length];
                numbersOrdered = numbers;
                numbersOrdered = numbersOrdered.OrderBy(x => x).ToArray();
                if (Enumerable.SequenceEqual(numbers, numbersOrdered)) { return true; }
            }
            return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var nextIntCounts = false;
            var sumFollowEvens = 0;
            if (numbers != null && numbers.Length > 0) {
                foreach (var number in numbers)
                {
                    if (nextIntCounts == true) { sumFollowEvens = sumFollowEvens + number; }
                    if (number % 2 == 0) { nextIntCounts = true; } else { nextIntCounts = false; }
                }
            }
            return sumFollowEvens;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentence = "";
            if (words != null && words.Length > 0)
            { 
                sentence = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    words[i] = string.Join("", words[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                    if (words[i].Any(char.IsLetter))
                    {
                        sentence = sentence + " " + words[i];
                    }
                }
                sentence = sentence + ".";
                if(!sentence.Any(char.IsLetter)) { sentence = ""; }
                return sentence;
            }
            return "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourthList = new List<double>();
            if (elements != null && elements.Count > 3)
            {
                for (int i = 3; i < elements.Count; i += 4)
                {
                    fourthList.Add(elements[i]);
                }
            }
            return fourthList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == targetNumber ) return true;
                }
            }
            return false;
        }
    }
}
