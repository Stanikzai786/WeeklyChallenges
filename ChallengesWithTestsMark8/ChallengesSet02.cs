using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (Char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                count++;
            }
            if (count % 2 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            return(number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return(num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0 )
                    { return 0; }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
           if (numbers == null )
            { 
                return 0; 
            }   
                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            while (numbers != null)
            {
                int sum =0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) 
                    {
                        sum += numbers[i];
                    }
                }return sum;
            }
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            { return false; }
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            while (number > 0)
            {
                int count = 0;
                for (int i = 1; i < number; i += 2)
                {
                    count++;
                }
                return count;
            }
            return 0;
        }
    }
}
