using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day5
    {
        static void Main()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Day5.txt");
            string[] moves = File.ReadAllLines(path);

            List<Stack<string>> crateStacks = new List<Stack<string>>()
            {
                new Stack<string>(new string[] { "P", "F", "M", "Q", "W", "G", "R", "T" }),
                new Stack<string>(new string[] { "H", "F", "R"}),
                new Stack<string>(new string[] { "P", "Z", "R", "V", "G", "H", "S", "D" }),
                new Stack<string>(new string[] { "Q", "H", "P", "B", "F", "W", "G" }),
                new Stack<string>(new string[] { "P", "S", "M", "J", "H"}),
                new Stack<string>(new string[] { "M", "Z", "T", "H", "S", "R", "P", "L" }),
                new Stack<string>(new string[] { "P", "T", "H", "N", "M", "L"}),
                new Stack<string>(new string[] { "F", "D", "Q", "R"}),
                new Stack<string>(new string[] { "D", "S", "C", "N", "L", "P", "H"})
            };

            List<Stack<string>> crateStacks2 = new List<Stack<string>>()
            {
                new Stack<string>(new string[] { "P", "F", "M", "Q", "W", "G", "R", "T" }),
                new Stack<string>(new string[] { "H", "F", "R"}),
                new Stack<string>(new string[] { "P", "Z", "R", "V", "G", "H", "S", "D" }),
                new Stack<string>(new string[] { "Q", "H", "P", "B", "F", "W", "G" }),
                new Stack<string>(new string[] { "P", "S", "M", "J", "H"}),
                new Stack<string>(new string[] { "M", "Z", "T", "H", "S", "R", "P", "L" }),
                new Stack<string>(new string[] { "P", "T", "H", "N", "M", "L"}),
                new Stack<string>(new string[] { "F", "D", "Q", "R"}),
                new Stack<string>(new string[] { "D", "S", "C", "N", "L", "P", "H"})
            };

            Stack<string> tempStack = new Stack<string>();

            foreach (string move in moves)
            {
                string[] options = move.Split(' ');
                int moveTimes = int.Parse(options[1]);
                int moveFrom = int.Parse(options[3]) - 1;
                int moveTo = int.Parse(options[5]) - 1;
                for (int i = 0; i < moveTimes; i++)
                {
                    if (crateStacks[moveFrom].Count > 0)
                        crateStacks[moveTo].Push(crateStacks[moveFrom].Pop());
                }

                for (int i = 0; i < moveTimes; i++)
                {
                    if (crateStacks2[moveFrom].Count > 0)
                        tempStack.Push(crateStacks2[moveFrom].Pop());
                }

                for (int i = 0; i < moveTimes; i++)
                    crateStacks2[moveTo].Push(tempStack.Pop());
            }

            string final = "";
            foreach (Stack<string> myStacks in crateStacks)
                final += myStacks.Peek();

            Debug.WriteLine(final);

            final = "";

            foreach (Stack<string> myStacks in crateStacks2)
                if (myStacks.Count > 0) final += myStacks.Peek();

            Debug.WriteLine(final);
        }
    }  
}
