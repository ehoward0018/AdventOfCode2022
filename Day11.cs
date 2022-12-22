using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AdventOfCode2022
{
    internal class Day11
    {
        //static void Main()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Day11.txt");
        //    string[] moves = File.ReadAllLines(path);
        //    List<Monkey> monkeys = new();

        //    for (int i = 0; i < moves.Length - 5; i += 7)
        //    {
        //        Monkey monkey = new(
        //            moves[i],
        //            moves[i + 1],
        //            moves[i + 2],
        //            moves[i + 3],
        //            moves[i + 4],
        //            moves[i + 5]
        //        );
        //        monkeys.Add(monkey);
        //    }

        //    bool denominatorFound = false;
        //    int lowestCommonDenominator = 1;

        //    while (!denominatorFound)
        //    {
        //        //Debug.WriteLine(lowestCommonDenominator);
        //        for (int i = 0; i < monkeys.Count; i++)
        //        {
        //            if (lowestCommonDenominator % monkeys[i].divisibleBy == 0)
        //            {
        //                if (i == monkeys.Count - 1)
        //                {
        //                    denominatorFound = true;
        //                }
        //            }
        //            else
        //            {
        //                lowestCommonDenominator++;
        //                break;
        //            }
        //        }
        //    }

        //    Debug.WriteLine(lowestCommonDenominator);


        //    for (int k = 0; k < 10000; k++)
        //    {
        //        //Debug.WriteLine(k);
        //        for (int i = 0; i < monkeys.Count; i++)
        //        {
        //            int x = monkeys[i].items.Count;
        //            monkeys[i].inspectedItems += x;
        //            for (int j = 0; j < x; j++)
        //            {
        //                monkeys[monkeys[i].PassMonkeyIteration()].items.Add(monkeys[i].items[0]);
        //                monkeys[i].items.RemoveAt(0);
        //            }
        //        }
        //    }

        //    List<int> finalCounts = new();
        //    for (int i = 0; i < monkeys.Count; i++)
        //        finalCounts.Add(monkeys[i].inspectedItems);

        //    finalCounts.Sort();

        //    int monkeyBusiness = finalCounts[finalCounts.Count - 1] * finalCounts[finalCounts.Count - 2];
        //    Debug.WriteLine(finalCounts[finalCounts.Count - 1]);
        //    Debug.WriteLine(finalCounts[finalCounts.Count - 2]);
        //    Debug.WriteLine(monkeyBusiness);
        //}
    }

    public class Monkey
    {
        public int id;
        public int inspectedItems = 0;
        public List<long> items = new List<long>();
        string operation = "";
        string operationValue = "";
        public long divisibleBy;
        int passedMonkey;
        int failedMonkey;
        public Monkey(string idString, string startingItems, string operationString, string test, string testPassed, string testFailed)
        {
            string temp = idString.Replace("Monkey ", "");
            id = int.Parse(temp[0].ToString());

            Debug.WriteLine(id);

            temp = startingItems.Replace("Starting items: ", "");
            string[] tempItems = temp.Split(", ");
            for (int i = 0; i < tempItems.Length; i++)
                items.Add(int.Parse(tempItems[i]));

            Debug.WriteLine(String.Join(", ", items));

            temp = operationString.Replace("  Operation: new = old ", "");
            tempItems = temp.Split(" ");
            operation = tempItems[0];
            operationValue = tempItems[1];

            Debug.WriteLine($"{operation} {operationValue}");

            temp = test.Replace("Test: divisible by ", "");
            divisibleBy = int.Parse(temp);

            Debug.WriteLine(divisibleBy);

            temp = testPassed.Replace("If true: throw to monkey ", "");
            passedMonkey = int.Parse(temp);

            Debug.WriteLine(passedMonkey);

            temp = testFailed.Replace("If false: throw to monkey ", "");
            failedMonkey = int.Parse(temp);

            Debug.WriteLine(failedMonkey);
        }


        public int PassMonkeyIteration()
        {
            
            //if (items[0] > 9699690)
            //    items[0] -= ((int)Math.Floor(items[0] / 9699690.0) * 9699690);
            if (operation == "*")
            {
                if (operationValue == "old") items[0] *= items[0];
                else items[0] *= long.Parse(operationValue);
            }
            else if (operation == "+")
            {
                if (operationValue == "old") items[0] += items[0];
                else items[0] += long.Parse(operationValue);
            }

                //Debug.WriteLine(items[0]);
            items[0] = items[0] % 9699690;
                //Debug.WriteLine(items[0]);
            //items[0] = (int)Math.Floor(items[0] / 3.0);

            if (items[0] % divisibleBy  == 0)
            {
                //if (items[0] % 11 == 0
                //    && items[0] % 7 == 0
                //    && items[0] % 13 == 0
                //    && items[0] % 5 == 0
                //    && items[0] % 3 == 0
                //    && items[0] % 17 == 0
                //    && items[0] % 2 == 0
                //    && items[0] % 19 == 0)
                //    items[0] = items[0] % 9699690;
                return passedMonkey;
            }
            return failedMonkey;
        }
    }
}
