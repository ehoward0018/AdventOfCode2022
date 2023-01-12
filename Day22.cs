using System;
using System.Diagnostics;

namespace AdventOfCode2022
{
    public class Day22
    {
        static void Main()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Day22A.txt");
            string[] inputs = File.ReadAllLines(path);

            char[][] map = new char[inputs.Length][];

            for(int i = 0; i < inputs.Length; i++)
                map[i] = inputs[i].ToCharArray();

            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "Day22B.txt");
            string[] inputs2 = File.ReadAllLines(path2);

            List<KeyValuePair<int, string>> instructions = new();

            int x = 0;
            for(int i = 0; i < inputs2[0].Length; i++)
            {
                if (inputs2[0][i] == 'R' || inputs2[0][i] == 'L')
                {
                    instructions.Add(new KeyValuePair<int, string>(int.Parse(inputs2[0].Substring(x, i - x)), inputs2[0].Substring(i, 1)));
                    x = i + 1;
                }
            }

            //foreach (KeyValuePair<int, string> instruction in instructions)
            //    Debug.WriteLine($"{instruction.Key}, {instruction.Value}");


        }
    }
}

