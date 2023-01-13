using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            {
                while (startNumber % n != 0)
                {
                    startNumber++;
                }
                return startNumber;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            {
                for (int i = 0; i < businesses.Length; i++)
                {
                    if (businesses[i].Revenue != 0)
                    {
                        continue;
                    }
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i + 1];
                    }
                }
                return sum;
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            {
                string sentence = "";
                for (int i = 0; i < words.Length; i++)
                {
                    sentence += words[i] + " ";
                }
                return sentence.TrimEnd();
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            {
                List<double> result = new List<double>();
                for (int i = 3; i < elements.Count; i += 4)
                {
                    result.Add(elements[i]);
                }
                return result.ToArray();
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            {
                HashSet<int> set = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (set.Contains(targetNumber - nums[i]))
                        return true;
                    else
                        set.Add(nums[i]);
                }
                return false;
            }
        }
    }
}
