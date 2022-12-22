using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day10
    {
        //static void Main()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Day10.txt");
        //    string[] moves = File.ReadAllLines(path);

        //    int cycles = 0;
        //    int total = 0;
        //    int X = 1;

        //    List<string> picture = new List<string>();

        //    string[] signalInfo;

        //    foreach(string move in moves)
        //    {
        //        if (move.Contains("noop"))
        //        {
        //            total += CalculateSignal(cycles, X);
        //            picture.Add(CalculateCRT(cycles, X));
        //            cycles++;
        //            continue;
        //        }

        //        signalInfo = move.Split(' ');

        //        picture.Add(CalculateCRT(cycles, X));
        //        cycles++;
        //        total += CalculateSignal(cycles, X);
        //        picture.Add(CalculateCRT(cycles, X));
        //        cycles++;
        //        total += CalculateSignal(cycles, X);
        //        X += int.Parse(signalInfo[1]);
        //    }

        //    for(int i = 0; i < 6; i++)
        //    {
        //        string line = "";
        //        for (int j = 0; j < 40; j++)
        //            line += picture[(i * 40) + j];
        //        Debug.WriteLine(line);
        //    }
            
        //    Debug.WriteLine(total);
        //}

        static int CalculateSignal(int cycles, int X)
        {
            Debug.WriteLine($"Cycle: {cycles%40}, {X}");
            if (cycles - 20 >= 0 && ((cycles - 20) % 40 == 0) && ((cycles - 20) / 40 <= 5))
            {
                return cycles * X;
            }
            return 0;
        }

        static string CalculateCRT(int cycles, int X)
        {
            int pos = cycles % 40;
            if (Math.Abs(X - pos) <= 1) return "#";
            return ".";
        }
    }
}
