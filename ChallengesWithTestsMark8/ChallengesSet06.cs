using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            foreach (var item in words)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    if (ignoreCase) { if (item.ToLower().Contains(word.ToLower())) return true; }
                    else { if (item.Contains(word)) return true; }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            var sqrt = Math.Sqrt(num);
            for (var i = 2; i <= sqrt; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var consecCount = 0;
            var maxConsecCount = 0;
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    consecCount++;
                    if (consecCount > maxConsecCount)
                    {
                        maxConsecCount = consecCount;
                    }
                }
                else { consecCount = 0; }
            }
            return maxConsecCount + 1;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null) return new double[0];
            var newList = new List<double>();
            if (elements != null && elements.Count >= n)
            {
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    newList.Add(elements[i]);
                }
            }
            return newList.ToArray();
        }
    }
}
