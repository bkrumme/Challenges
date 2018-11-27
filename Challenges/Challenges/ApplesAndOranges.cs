using System;
using System.Linq;

namespace Challenges
{
    public static class ApplesAndOranges
    {
        public static void CountApplesAndOranges(int startOfHouse, int endOfHouse, int appleTree, int orangeTree, int[] apples, int[] oranges)
        {
            var numberOfApples = GetTotalNumberOfFruitWithinRange(apples, appleTree, startOfHouse, endOfHouse);
            var numberOfOranges = GetTotalNumberOfFruitWithinRange(oranges, orangeTree, startOfHouse, endOfHouse);
            Console.WriteLine(numberOfApples);
            Console.WriteLine(numberOfOranges);
        }

        private static int GetTotalNumberOfFruitWithinRange(int[] distancesOfFruit, int tree, int startOfHouse, int endOfHouse)
        {
            var totalFallen = 0;
            for (int i = 0; i < distancesOfFruit.Length; i++)
            {
                var distanceOfCurrentFruit = distancesOfFruit[i];
                var positionOfCurrentFruit = tree + distanceOfCurrentFruit;
                if (positionOfCurrentFruit >= startOfHouse && positionOfCurrentFruit <= endOfHouse)
                {
                    totalFallen++;
                }
            }
            return totalFallen;
        }
    }
}