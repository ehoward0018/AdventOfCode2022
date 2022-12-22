using System.Diagnostics;

namespace AdventOfCode2022
{
    public class Day7
    {
        static int Total = 0;
        static int MaxMemory = 70000000;
        static int MaxMemoryClosest = 70000000;

        //static void Main()
        //{

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Day7.txt");
        //    string[] texts = File.ReadAllLines(path);
        //    string[][] splitTexts = new string[texts.Length][];
        //    for (int i = 0; i < texts.Length; i++) splitTexts[i] = texts[i].Split(' ');

        //    Dictionary<string, ElfDirectory> elfDirectories = new()
        //    {
        //        { "/", new ElfDirectory()}
        //    };
        //    List<string> currentDir = new List<string>() { "/" };
        


        //    for(int i = 1; i < splitTexts.Length; i++)
        //    {
        //        if (splitTexts[i][0] == "$")
        //        {
        //            if (splitTexts[i][1] == "ls") continue;
        //            if (splitTexts[i][1] == "cd")
        //            {
        //                if (splitTexts[i][2] == ".." && currentDir.Count > 0)
        //                    currentDir.RemoveAt(currentDir.Count - 1);
        //                else if (splitTexts[i][2] == "/")
        //                {
        //                    currentDir.Clear();
        //                    currentDir.Add("/");
        //                }
        //                else
        //                    currentDir.Add(splitTexts[i][2]);
        //            }

        //        }
        //        else if (splitTexts[i][0] == "dir")
        //        {
        //            Dictionary<string, ElfDirectory> currentElfDict = elfDirectories;
        //            for (int j = 0; j < currentDir.Count; j++)
        //            {
        //                if (currentElfDict.TryGetValue(currentDir[j], out ElfDirectory currentElfDirectory))
        //                {
        //                    currentElfDict = currentElfDirectory.innerDir;
        //                }
        //            }
        //            currentElfDict.TryAdd(splitTexts[i][1], new ElfDirectory());
        //        }
        //        else
        //        {
        //            Dictionary<string, ElfDirectory> currentElfDict = elfDirectories;
        //            ElfDirectory currentElfDirectory = null;
        //            for (int j = 0; j < currentDir.Count; j++)
        //            {
        //                if (currentElfDict.TryGetValue(currentDir[j], out currentElfDirectory))
        //                {
        //                    currentElfDict = currentElfDirectory.innerDir;
        //                }
        //            }
        //            if (currentElfDirectory is not null)
        //            {
        //                currentElfDirectory.innerFiles.TryAdd(splitTexts[i][1], int.Parse(splitTexts[i][0]));
        //            }
        //        }




        //    }
        //    int myTotal = 0;
        //    foreach(ElfDirectory elfDirectory in elfDirectories.Values)
        //    {
        //        myTotal += SumOfInnerFiles(elfDirectory);
        //        if (myTotal <= 100000) Total += myTotal;
        //    }
        //    Debug.WriteLine(myTotal);
        //    MaxMemory = 30000000 - (70000000 - myTotal);
        //    myTotal = 0;
        //    foreach (ElfDirectory elfDirectory in elfDirectories.Values)
        //    {
        //        myTotal = 0;
        //        myTotal = SumOfInnerFiles(elfDirectory);
        //        if (myTotal <= 100000) Total += myTotal;
        //        if (myTotal >= MaxMemory && myTotal < MaxMemoryClosest) MaxMemoryClosest = myTotal;
        //    }

        //    Debug.WriteLine(MaxMemoryClosest);
        //}

        static int SumOfInnerFiles(ElfDirectory elfDirectory)
        {
            int currentTotal = 0;
            if (elfDirectory.innerDir.Count > 0)
            {
                foreach (ElfDirectory dir in elfDirectory.innerDir.Values)
                    currentTotal += SumOfInnerFiles(dir);
            }
            if (elfDirectory.innerFiles.Count > 0)
            {
                foreach (int x in elfDirectory.innerFiles.Values)
                    currentTotal += x;
            }
            if (currentTotal <= 100000) Total += currentTotal;
            if (currentTotal >= MaxMemory && currentTotal < MaxMemoryClosest) MaxMemoryClosest = currentTotal;
            return currentTotal;
        }
    }

    public class ElfDirectory
    {
        public Dictionary<string, ElfDirectory> innerDir = new Dictionary<string, ElfDirectory>();
        public Dictionary<string, int> innerFiles = new Dictionary<string, int>();
    }
}
