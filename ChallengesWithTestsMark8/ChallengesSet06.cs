using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true) 
            {
                word= word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containWord = words.Contains(word);
            }
            return containWord;
        }

        public bool IsPrimeNumber(int num)
        {
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex; 
            for (int i = 0; i < str.Length; i++)
            {
                uindex= true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    { 
                        uindex = false; 
                    }
                }
                if (uindex == true)
                {
                    index = i;
                }
                    
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            {
                int maxCount = 0;
                int currentCount = 1;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, currentCount);
                        currentCount = 1;
                    }
                }
                return Math.Max(maxCount, currentCount);
            }
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck= new double[0];
            if (elements == null)
            {
                return nullCheck;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n ==0)
                {
                    nthElement.Add(elements[i]);
                }
                if (n < 0 || n> elements.Count)
                {
                    nthElement.Clear();
                }
            }
            double[] finaArray = nthElement.ToArray();
            return finaArray;
        }
    }
}
