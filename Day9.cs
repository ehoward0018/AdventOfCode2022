using System.Diagnostics;

namespace AdventOfCode2022
{
    internal class Day9
    {
        //static void Main()
        //{

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Day9.txt");
        //    string[] moves = File.ReadAllLines(path);

        //    HashSet<string> positions = new HashSet<string>();
        //    int[] xVals = new int[10];
        //    int[] yVals = new int[10];
        //    int xTail = 0;
        //    int yTail = 0;
        //    int xHead = 0;
        //    int yHead = 0;
        //    positions.Add($"{xTail},{yTail}");

        //    string[] moveInfo;
        //    int z;
        //    foreach (string move in moves)
        //    {
        //        moveInfo = move.Split(' ');
        //        z = int.Parse(moveInfo[1]);

        //        if (moveInfo[0] == "L")
        //        {
        //            for(int i = 0; i < z; i++)
        //            {
        //                xVals[0]--;
        //                for(int j = 1; j < 10; j++)
        //                {
        //                    if (Math.Abs(xVals[j] - xVals[j-1]) >= 2)
        //                    {
        //                        if (xVals[j] > xVals[j - 1])
        //                            xVals[j]--;
        //                        else
        //                            xVals[j]++;
        //                        if (yVals[j - 1] > yVals[j])
        //                            yVals[j]++;
        //                        if (yVals[j - 1] < yVals[j])
        //                            yVals[j]--;
        //                    }
        //                    if (Math.Abs(yVals[j] - yVals[j-1]) >= 2)
        //                    {
        //                        if (yVals[j] > yVals[j - 1])
        //                            yVals[j]--;
        //                        else
        //                            yVals[j]++;
        //                        if (xVals[j - 1] > xVals[j])
        //                            xVals[j]++;
        //                        if (xVals[j - 1] < xVals[j])
        //                            xVals[j]--;
        //                    }
        //                }
        //                positions.Add($"{xVals[9]},{yVals[9]}");

        //                //xHead--;
        //                //if (Math.Abs(xHead - xTail) >= 2)
        //                //{
        //                //    xTail--;
        //                //    if (yHead > yTail)
        //                //        yTail++;
        //                //    if (yHead < yTail)
        //                //        yTail--;
        //                //}

        //                //positions.Add($"{xTail},{yTail}");
        //                //Debug.WriteLine($"T: {xTail}, {yTail}  H: {xHead}, {yHead}");
        //            }
        //        }
        //        else if (moveInfo[0] == "R")
        //        {
        //            for (int i = 0; i < z; i++)
        //            {
        //                xVals[0]++;
        //                for (int j = 1; j < 10; j++)
        //                {
        //                    if (Math.Abs(xVals[j] - xVals[j - 1]) >= 2)
        //                    {
        //                        if (xVals[j] > xVals[j - 1])
        //                            xVals[j]--;
        //                        else
        //                            xVals[j]++;
        //                        if (yVals[j - 1] > yVals[j])
        //                            yVals[j]++;
        //                        if (yVals[j - 1] < yVals[j])
        //                            yVals[j]--;
        //                    }
        //                    if (Math.Abs(yVals[j] - yVals[j - 1]) >= 2)
        //                    {
        //                        if (yVals[j] > yVals[j - 1])
        //                            yVals[j]--;
        //                        else
        //                            yVals[j]++;
        //                        if (xVals[j - 1] > xVals[j])
        //                            xVals[j]++;
        //                        if (xVals[j - 1] < xVals[j])
        //                            xVals[j]--;
        //                    }
        //                }
        //                positions.Add($"{xVals[9]},{yVals[9]}");

        //                //xHead++;
        //                //if (Math.Abs(xHead - xTail) >= 2)
        //                //{
        //                //    xTail++;
        //                //    if (yHead > yTail)
        //                //        yTail++;
        //                //    if (yHead < yTail)
        //                //        yTail--;
        //                //}

        //                //positions.Add($"{xTail},{yTail}");
        //                //Debug.WriteLine($"T: {xTail}, {yTail}  H: {xHead}, {yHead}");
        //            }
        //        }
        //        else if (moveInfo[0] == "D")
        //        {
        //            for (int i = 0; i < z; i++)
        //            {
        //                yVals[0]--;
        //                for (int j = 1; j < 10; j++)
        //                {
        //                    if (Math.Abs(xVals[j] - xVals[j - 1]) >= 2)
        //                    {
        //                        if (xVals[j] > xVals[j - 1])
        //                            xVals[j]--;
        //                        else
        //                            xVals[j]++;
        //                        if (yVals[j - 1] > yVals[j])
        //                            yVals[j]++;
        //                        if (yVals[j - 1] < yVals[j])
        //                            yVals[j]--;
        //                    }
        //                    if (Math.Abs(yVals[j] - yVals[j - 1]) >= 2)
        //                    {
        //                        if (yVals[j] > yVals[j - 1])
        //                            yVals[j]--;
        //                        else
        //                            yVals[j]++;
        //                        if (xVals[j - 1] > xVals[j])
        //                            xVals[j]++;
        //                        if (xVals[j - 1] < xVals[j])
        //                            xVals[j]--;
        //                    }
        //                }
        //                positions.Add($"{xVals[9]},{yVals[9]}");
        //                //yHead--;
        //                //if (Math.Abs(yHead - yTail) >= 2)
        //                //{
        //                //    yTail--;
        //                //    if (xHead > xTail)
        //                //        xTail++;
        //                //    if (xHead < xTail)
        //                //        xTail--;
        //                //}
        //                //positions.Add($"{xTail},{yTail}");
        //                //Debug.WriteLine($"T: {xTail}, {yTail}  H: {xHead}, {yHead}");
        //            }
        //        }
        //        else
        //        {
        //            for (int i = 0; i < z; i++)
        //            {
        //                yVals[0]++;
        //                for (int j = 1; j < 10; j++)
        //                {
        //                    if (Math.Abs(xVals[j] - xVals[j - 1]) >= 2)
        //                    {
        //                        if (xVals[j] > xVals[j - 1])
        //                            xVals[j]--;
        //                        else
        //                            xVals[j]++;
        //                        if (yVals[j - 1] > yVals[j])
        //                            yVals[j]++;
        //                        if (yVals[j - 1] < yVals[j])
        //                            yVals[j]--;
        //                    }
        //                    if (Math.Abs(yVals[j] - yVals[j - 1]) >= 2)
        //                    {
        //                        if (yVals[j] > yVals[j - 1])
        //                            yVals[j]--;
        //                        else
        //                            yVals[j]++;
        //                        if (xVals[j - 1] > xVals[j])
        //                            xVals[j]++;
        //                        if (xVals[j - 1] < xVals[j])
        //                            xVals[j]--;
        //                    }
        //                }
        //                positions.Add($"{xVals[9]},{yVals[9]}");

        //                //yHead++;
        //                //if (Math.Abs(yHead - yTail) >= 2)
        //                //{
        //                //    yTail++;
        //                //    if (xHead > xTail)
        //                //        xTail++;
        //                //    if (xHead < xTail)
        //                //        xTail--;
        //                //}

        //                //positions.Add($"{xTail},{yTail}");
        //                //Debug.WriteLine($"T: {xTail}, {yTail}  H: {xHead}, {yHead}");
        //            }
        //        }
        //    }

        //    Debug.WriteLine(positions.Count);
        //}
    }
}
