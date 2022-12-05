using System.Diagnostics;

namespace AdventOfCode2022
{


    public class RucksackReorganization
    {
        //static void Main()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "RucksackReorganization.txt");
        //    string[] sacks = File.ReadAllLines(path);

        //    Dictionary<char, int> values = new Dictionary<char, int>()
        //    {
        //        ['a'] = 1,
        //        ['b'] = 2,
        //        ['c'] = 3,
        //        ['d'] = 4,
        //        ['e'] = 5,
        //        ['f'] = 6,
        //        ['g'] = 7,
        //        ['h'] = 8,
        //        ['i'] = 9,
        //        ['j'] = 10,
        //        ['k'] = 11,
        //        ['l'] = 12,
        //        ['m'] = 13,
        //        ['n'] = 14,
        //        ['o'] = 15,
        //        ['p'] = 16,
        //        ['q'] = 17,
        //        ['r'] = 18,
        //        ['s'] = 19,
        //        ['t'] = 20,
        //        ['u'] = 21,
        //        ['v'] = 22,
        //        ['w'] = 23,
        //        ['x'] = 24,
        //        ['y'] = 25,
        //        ['z'] = 26,
        //        ['A'] = 27,
        //        ['B'] = 28,
        //        ['C'] = 29,
        //        ['D'] = 30,
        //        ['E'] = 31,
        //        ['F'] = 32,
        //        ['G'] = 33,
        //        ['H'] = 34,
        //        ['I'] = 35,
        //        ['J'] = 36,
        //        ['K'] = 37,
        //        ['L'] = 38,
        //        ['M'] = 39,
        //        ['N'] = 40,
        //        ['O'] = 41,
        //        ['P'] = 42,
        //        ['Q'] = 43,
        //        ['R'] = 44,
        //        ['S'] = 45,
        //        ['T'] = 46,
        //        ['U'] = 47,
        //        ['V'] = 48,
        //        ['W'] = 49,
        //        ['X'] = 50,
        //        ['Y'] = 51,
        //        ['Z'] = 52
        //    };
        //    Dictionary<char, char> used = new Dictionary<char, char>();
        //    int sackSize = 0;
        //    int finalScore = 0;
        //    foreach (string sack in sacks)
        //    {
        //        used.Clear();
        //        sackSize = sack.Length / 2;
        //        for (int i = 0; i < sackSize; i++)
        //            used.TryAdd(sack[i], sack[i]);
        //        for (int i = sackSize; i < sack.Length; i++)
        //        {
        //            if (used.ContainsKey(sack[i]))
        //            {
        //                finalScore += values[sack[i]];
        //                break;
        //            }
        //        }
        //    }

        //    Debug.WriteLine(finalScore);

        //    Dictionary<char, char> used2 = new Dictionary<char, char>();
        //    finalScore = 0;

        //    for (int i = 0; i < sacks.Length; i += 3)
        //    {
        //        used.Clear();
        //        used2.Clear();
        //        foreach (char myChar in sacks[i])
        //            used.TryAdd(myChar, myChar);
        //        foreach (char myChar in sacks[i+1])
        //            used2.TryAdd(myChar, myChar);
        //        foreach (char myChar in sacks[i + 2])
        //        {
        //            if (used.ContainsKey(myChar) && used2.ContainsKey(myChar))
        //            {
        //                finalScore += values[myChar];
        //                break;
        //            }
        //        }
        //    }

        //    Debug.WriteLine(finalScore);

        //}

    }
}
