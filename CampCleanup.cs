using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class CampCleanup
    {
        //static void Main()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "CampCleanup.txt");
        //    string[] assignments = File.ReadAllLines(path);

        //    string[] firstSplit;
        //    string[] leftElf;
        //    string[] rightElf;
        //    int[] values = new int[4];
        //    int fullPairs = 0;
        //    int overlapPairs = 0;

        //    foreach(string assignment in assignments)
        //    {
        //        firstSplit = assignment.Split(',');
        //        leftElf = firstSplit[0].Split('-');
        //        rightElf = firstSplit[1].Split('-');
        //        values[0] = Convert.ToInt32(leftElf[0]);
        //        values[1] = Convert.ToInt32(leftElf[1]);
        //        values[2] = Convert.ToInt32(rightElf[0]);
        //        values[3] = Convert.ToInt32(rightElf[1]);

        //        if ((values[0] >= values[2] && values[1] <= values[3])
        //            || (values[2] >= values[0] && values[3] <= values[1]))
        //            fullPairs++;

        //        if ((values[1] >= values[2] && values[1] <= values[3])
        //            || (values[0] >= values[2] && values[0] <= values[3])
        //            || (values[2] >= values[0] && values[2] <= values[1])
        //            || (values[3] >= values[0] && values[3] <= values[1]))
        //            overlapPairs++;
        //    }

        //    Debug.WriteLine(fullPairs);
        //    Debug.WriteLine(overlapPairs);
        //}
    }
}
