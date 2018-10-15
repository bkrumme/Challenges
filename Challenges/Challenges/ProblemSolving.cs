using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public static class ProblemSolving
    {
        public static int DiagonalDifference(int[][] arr)
        {
            var length = arr.Length - 1;
            var sum1 = 0;
            var sum2 = 0;
            for (int i = length; i >= 0; i--)
            {
                sum1 += arr[i][i];
            }

            for (int i = 0; length >= 0; i++)
            {
                sum2 += arr[length][i];
                length--;
            }
            return Math.Abs(sum1 - sum2);
        }

        public static void Staircase(int n)
        {
            var numberOfSpaces = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i).PadLeft(i + numberOfSpaces));
                numberOfSpaces--;
            }
        }

        public static void PlusMinus(int[] arr)
        {
            var numberOfitems = (double)arr.Length;
            var positiveCount = (double)arr.Count(x => x > 0);
            var negativeCount = (double)arr.Count(x => x < 0);
            var zeroCount = (double)arr.Count(x => x == 0);
            var positiveFraction = positiveCount / numberOfitems;
            var negativeFraction = negativeCount / numberOfitems;
            var zeroFraction = zeroCount / numberOfitems;
            Console.WriteLine(positiveFraction.ToString("N6"));
            Console.WriteLine(negativeFraction.ToString("N6"));
            Console.WriteLine(zeroFraction.ToString("N6"));
        }

        public static int BirthdayCakeCandles(int[] ar)
        {
            var highestValue = ar.Max();
            var highestValueCount = ar.Count(x => x == highestValue);
            return highestValueCount;
        }

        public static string TimeConversion(string s)
        {
            var stringToDate = Convert.ToDateTime(s);
            var dateToMilitaryTime = stringToDate.ToString("HH:mm:ss");
            return dateToMilitaryTime;
        }

        public static int[] GradingStudents(int[] grades)
        {
            var roundedGrades = new List<int>();
            for (int i = 0; i < grades.Length; i++)
            {
                var currentGrade = grades[i];
                if (currentGrade >= 38)
                {
                    var roundedGrade = currentGrade + (5 - currentGrade % 5);
                    roundedGrades.Add(roundedGrade - currentGrade < 3 ? roundedGrade : currentGrade);
                }
                else
                {
                    roundedGrades.Add(currentGrade);
                }
            }

            return roundedGrades.ToArray();
        }

        public static int HackerlandRadioTransmitters(int[] houses, int distance)
        {
            Array.Sort(houses);
            var minNumberOfTransmitters = 0;
            int i = 0;
            while (i < houses.Count() && houses.Count() - i > distance)
            {
                minNumberOfTransmitters++;
                var placementLocation = houses[i] + distance;
                while (i < houses.Count() && houses[i] <= placementLocation)
                {
                    i++;
                    placementLocation = houses[--i] + distance;
                    while (i < houses.Count() && houses[i] <= placementLocation)
                    {
                        i++;
                    }
                }
            }
            return minNumberOfTransmitters;
        }

        public static void MinMaxSum(int[] arr)
        {
            var minIntIndex = Array.IndexOf(arr, arr.Min());
            var maxIntIndex = Array.IndexOf(arr, arr.Max());
            Int64 minSum = 0;
            Int64 maxSum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var currentValue = arr[i];
                if (i != minIntIndex)
                {
                    maxSum += currentValue;
                }

                if (i != maxIntIndex)
                {
                    minSum += currentValue;
                }
            }
            var results = new[] { minSum, maxSum };
            Console.WriteLine($"{results[0]} {results[1]}");
        }

        public static int[] ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        public static int[] RotateLeft(int[] source, int numberOfRotations)
        {
            var sourceWithoutNumberOfRotations = source.Skip(numberOfRotations).ToList();
            var takenSourceElements = source.Take(numberOfRotations).ToList();
            sourceWithoutNumberOfRotations.AddRange(takenSourceElements);
            return sourceWithoutNumberOfRotations.ToArray();
        }

        public static void MinimumBribes(int[] q)
        {
            var totalNumberOfMoves = 0;
            for (int p = q.Length - 1; p > 0; p--)
            {
                var numberOfMoves = 0;
                for (int i = 0; i <= p - 1; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        numberOfMoves++;
                        totalNumberOfMoves++;
                        if (numberOfMoves > 2)
                        {
                            Console.WriteLine("Too chaotic");
                            return;
                        }
                        var highValue = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = highValue;
                    }
                }
            }

            Console.WriteLine(totalNumberOfMoves.ToString());
        }

        public static int MinimumSwaps(int[] arr)
        {
            int numberOfSwaps = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] != i + 1)
                {
                    var currentLocation = arr[i] - 1;
                    var temp = arr[i];
                    arr[i] = arr[currentLocation];
                    arr[currentLocation] = temp;
                    numberOfSwaps++;
                }
            }
            return numberOfSwaps;
        }

        public static int FirstFactorial(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                num = num * i;
            }
            return num;
        }
    }
}
