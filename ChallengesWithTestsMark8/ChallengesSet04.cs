using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            var oddsum = 0;
            foreach (var number in numbers) 
                if (number % 2 == 0) { sum = sum + number; }
                else { oddsum = oddsum + number; } 
            return sum - oddsum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengths = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallest = new List<int> { number1, number2, number3, number4 };
            return smallest.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength2 + sideLength3 > sideLength1 &&
                    sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;
            foreach (object obj in objs) { if (obj == null) { nullCount++; } }
            if (nullCount >= ((objs.Length / 2) + 1)) { return true; }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = new List<double>();
            if (numbers != null)
            {
                foreach (int number in numbers)
                { if (number % 2 == 0) { evens.Add(number); } }
                if (evens.Count > 0) { return evens.Average(); }
            }
            return 0;
        }

        public int Factorial(int number)
        {
            var factor = 1;
            if (number >= 0)
            {
                for (int i = number; i > 0; i--)
                {
                    factor *= i;
                }
            }
            else throw new ArgumentOutOfRangeException();
            return factor;
        }
    }
}
