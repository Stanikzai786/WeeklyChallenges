using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            {
                if (ignoreCase)
                {
                    word = word.ToLower();
                    return words.Any(w => w.ToLower().Equals(word));
                }
                else
                {
                    return words.Contains(word);
                }
            }
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
            {
                int index = -1;
                HashSet<char> set = new HashSet<char>();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (!set.Contains(str[i]))
                    {
                        index = i;
                        set.Add(str[i]);
                    }
                }
                return index;
            }
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
            {
                List<double> result = new List<double>();
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    result.Add(elements[i]);
                }
                return result.ToArray();
            }
        }
    }
}
