using System.ComponentModel;
using System.Diagnostics;

namespace AdventOfCode2022
{
    internal class Day12
    {
        //static void Main()
        //{
        //    Dictionary<char, int> heights = new Dictionary<char, int>()
        //    {
        //        {'S', 1},
        //        {'a', 1},
        //        {'b', 2},
        //        {'c', 3},
        //        {'d', 4},
        //        {'e', 5},
        //        {'f', 6},
        //        {'g', 7},
        //        {'h', 8},
        //        {'i', 9},
        //        {'j', 10},
        //        {'k', 11},
        //        {'l', 12},
        //        {'m', 13},
        //        {'n', 14},
        //        {'o', 15},
        //        {'p', 16},
        //        {'q', 17},
        //        {'r', 18},
        //        {'s', 19},
        //        {'t', 20},
        //        {'u', 21},
        //        {'v', 22},
        //        {'w', 23},
        //        {'x', 24},
        //        {'y', 25},
        //        {'z', 26},
        //        {'E', 26}
        //    };

        //    var path2 = Path.Combine(Directory.GetCurrentDirectory(), "Day12.txt");
        //    string[] map = File.ReadAllLines(path2);

        //    int[][] heightMap = new int[map.Length][];

        //    Node startNode = new(0, 0);
        //    Node finalNode = null;       
        //    //Setup
        //    for (int i = 0; i < map.Length; i++)
        //    {
        //        heightMap[i] = new int[map[0].Length];
        //        for (int j = 0; j < heightMap[i].Length; j++)
        //        {
        //            heightMap[i][j] = heights[map[i][j]];
        //            if (map[i][j] == 'S')
        //            {
        //                startNode = new Node(j, i);
        //            }

        //            if (map[i][j] == 'E')
        //            {
        //                finalNode = new Node(j, i);
        //            }
        //        }
        //    }
        //    int finalDistance = -1;
        //    int height = heightMap.Length;
        //    int width = heightMap[0].Length;

        //    int[] dx = new int[] { 0, 0, -1, 1 };
        //    int[] dy = new int[] { -1, 1, 0, 0 };

        //    for(int y = 0; y < height; y++)
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            if (heightMap[y][x] == 1)
        //            {
        //                startNode = new Node(x, y);

        //                int distance = -1;
        //                bool finalNodeFound = false;
        //                HashSet<string> visitedNodes = new HashSet<string>();
        //                List<Node> queue = new List<Node>();
        //                queue.Add(startNode);


        //                while (!finalNodeFound)
        //                {
        //                    distance++;
        //                    List<Node> tempQ = new List<Node>(queue);
        //                    if (tempQ.Count == 0) break;
        //                    queue.Clear();
        //                    foreach (Node node in tempQ)
        //                    {
        //                        if (node.IsEqual(finalNode))
        //                        {
        //                            finalNodeFound = true;
        //                            break;
        //                        }

        //                        if (visitedNodes.Add(node.ToString()))
        //                        {
        //                            for (int k = 0; k < dx.Length; k++)
        //                            {
        //                                Node newNode = new(node.x + dx[k], node.y + dy[k]);

        //                                if (!visitedNodes.Contains(newNode.ToString())
        //                                    && (newNode.x >= 0 && newNode.x < width)
        //                                    && (newNode.y >= 0 && newNode.y < height))
        //                                {
        //                                    if ((heightMap[newNode.y][newNode.x] >= heightMap[node.y][node.x]
        //                                        && Math.Abs(heightMap[newNode.y][newNode.x] - heightMap[node.y][node.x]) <= 1)
        //                                        || (heightMap[newNode.y][newNode.x] < heightMap[node.y][node.x]))
        //                                        queue.Add(newNode);
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //                if ((finalDistance < 0 || distance < finalDistance) && finalNodeFound)
        //                    finalDistance = distance;
        //            }
        //        }
        //    }
        //}

        public class Node
        {
            public int x, y;

            public Node(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public bool IsEqual(Node node)
            {
                return node.x == x && node.y == y;
            }

            public override string ToString()
            {
                return $"{x},{y}";
            }
        }
    }
}
