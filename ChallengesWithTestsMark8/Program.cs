using System;
using System.Collections.Generic;
using ChallengesWithTestsMark8;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            var tempList = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var challenges = new ChallengesSet05();
            challenges.GetEveryFourthElement(tempList);
        }
    }
}
