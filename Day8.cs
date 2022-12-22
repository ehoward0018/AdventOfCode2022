using System.Diagnostics;

namespace AdventOfCode2022
{
    internal class Day8
    {
        //static void Main()
        //{

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Day8.txt");
        //    string[] texts = File.ReadAllLines(path);

        //    int[][] trees = new int[texts.Length][];
        //    bool[][] treeCounted = new bool[texts.Length][];


        //    for(int i = 0; i < texts.Length; i++)
        //    {
        //        trees[i] = new int[texts[i].Length];
        //        treeCounted[i] = new bool[texts[i].Length];
        //        for (int j = 0; j < trees[i].Length; j++)
        //            trees[i][j] = int.Parse(texts[i][j].ToString());
        //    }
        //    int largestTreeInDirection = -1;
        //    for(int i = 0; i < trees.Length; i++)
        //    {
        //        largestTreeInDirection = -1;
        //        for(int j = 0; j < trees[i].Length; j++)
        //        {
        //            if (trees[i][j] > largestTreeInDirection)
        //            {
        //                largestTreeInDirection = trees[i][j];
        //                treeCounted[i][j] = true;
        //            }
        //        }

        //        largestTreeInDirection = -1;

        //        for(int j = trees[i].Length - 1; j > -1; j--)
        //        {
        //            if (trees[i][j] > largestTreeInDirection)
        //            {
        //                largestTreeInDirection = trees[i][j];
        //                treeCounted[i][j] = true;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < trees[0].Length; i++)
        //    {
        //        largestTreeInDirection = -1;
        //        for(int j = 0; j < trees.Length; j++)
        //        {
        //            if (trees[j][i] > largestTreeInDirection)
        //            {
        //                largestTreeInDirection = trees[j][i];
        //                treeCounted[j][i] = true;
        //            }
        //        }

        //        largestTreeInDirection = -1;
        //        for(int j = trees.Length - 1; j > -1; j--)
        //        {
        //            if (trees[j][i] > largestTreeInDirection)
        //            {
        //                largestTreeInDirection = trees[j][i];
        //                treeCounted[j][i] = true;
        //            }
        //        }
        //    }

        //    int finalCount = 0;

        //    for (int i = 0; i < trees.Length; i++)
        //    {
        //        for(int j = 0; j < trees[i].Length; j++)
        //        {
        //            if (treeCounted[i][j]) 
        //                finalCount++;
        //        }
        //    }

        //    Debug.WriteLine(finalCount);

        //    int highestScore = 0;
        //    int currentScore = 0;
        //    List<int> currentScores = new List<int>();
        //    int treesInDirection = 0;

        //    for(int i = 0; i < trees.Length; i++)
        //    {
        //        for (int j = 0; j < trees[i].Length; j++)
        //        {
        //            currentScores.Clear();
        //            currentScore = 1;
        //            largestTreeInDirection = trees[i][j];
        //            treesInDirection = 0;
        //            for (int k = i - 1; k > -1; k--)
        //            {
        //                treesInDirection++;
        //                if (trees[k][j] >= largestTreeInDirection) break;
        //            }
        //            currentScores.Add(treesInDirection);

        //            treesInDirection = 0;
        //            for (int k = i + 1; k < trees.Length; k++)
        //            {
        //                treesInDirection++;
        //                if (trees[k][j] >= largestTreeInDirection) break;
        //            }
        //            currentScores.Add(treesInDirection);

        //            treesInDirection = 0;
        //            for(int k = j - 1; k > -1; k--)
        //            {
        //                treesInDirection++;
        //                if (trees[i][k] >= largestTreeInDirection) break;
        //            }
        //            currentScores.Add(treesInDirection);

        //            treesInDirection = 0;
        //            for(int k = j + 1; k < trees[i].Length; k++)
        //            {
        //                treesInDirection++;
        //                if (trees[i][k] >= largestTreeInDirection) break;
        //            }
        //            currentScores.Add(treesInDirection);

        //            foreach (int z in currentScores)
        //                currentScore *= z;

        //            if (currentScore > highestScore)
        //                highestScore = currentScore;
        //        }
        //    }

        //    Debug.WriteLine(highestScore);
        //}
    }
}
