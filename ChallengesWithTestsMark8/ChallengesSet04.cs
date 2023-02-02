using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        result += numbers[i];
                    }
                    else
                    {
                        result -= numbers[i];
                    }
                }
                return result;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            {
                int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length };
                int minLength = int.MaxValue;
                for (int i = 0; i < lengths.Length; i++)
                {
                    if (lengths[i] < minLength)
                    {
                        minLength = lengths[i];
                    }
                }
                return minLength;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            {
                int[] numbers = { number1, number2, number3, number4 };
                int minNumber = int.MaxValue;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minNumber)
                    {
                        minNumber = numbers[i];
                    }
                }
                return minNumber;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            {
                if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
                    return true;
                else
                    return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            {
                double result;
                return double.TryParse(input, out result);
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            {
                int nullCount = 0;
                for (int i = 0; i < objs.Length; i++)
                {
                    if (objs[i] == null)
                    {
                        nullCount++;
                    }
                }
                if (nullCount > objs.Length / 2)
                    return true;
                else
                    return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var n = numbers.Where(num => num % 2 == 0);
            if (n.Count() == 0)
                return 0;

            return n.Average();
        }
        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number > 0 ? number * Factorial(number - 1) : throw new ArgumentOutOfRangeException();
        }
    }
}
