using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day21
    {
        public static Dictionary<string, JobMonkey> AllMonkeys = new();

        public static bool RootFound = false;
        public static long RootFinalValue = 0;
        public static int MonkeysEliminated = 0;

        //static void Main()
        //{
        //    var path2 = Path.Combine(Directory.GetCurrentDirectory(), "Day21.txt");
        //    string[] inputs = File.ReadAllLines(path2);
            
        //    for(int i = 0; i < inputs.Length; i++)
        //    {
        //        string[] line = inputs[i].Split(": ");
        //        if (line[1].Contains('*') || line[1].Contains('/') || line[1].Contains('-') || line[1].Contains('+'))
        //        {
        //            string[] secondLine = line[1].Split(' ');
        //            JobMonkey monkey = new(line[0], secondLine[0], secondLine[2], secondLine[1]);
        //            AllMonkeys.Add(monkey.Code, monkey);
        //        }
        //        else
        //        {
        //            JobMonkey jobMonkeyValue = new(line[0], long.Parse(line[1]));
        //            AllMonkeys.Add(jobMonkeyValue.Code, jobMonkeyValue);
        //            MonkeysEliminated++;
        //        }
        //    }

        //    foreach (JobMonkey jobMonkey in AllMonkeys.Values)
        //        jobMonkey.EncountersHumn();

        //    string first = AllMonkeys["root"].FirstOperator;
        //    string second = AllMonkeys["root"].SecondOperator;

        //    for (long i = 3353687000000; i < 120000000000000; i++)
        //    {
        //        AllMonkeys["humn"].CodeValue = i;

        //        if (AllMonkeys[AllMonkeys["root"].FirstOperator].GetValue() == AllMonkeys[AllMonkeys["root"].SecondOperator].GetValue())
        //        {
        //            RootFinalValue = i;
        //            break;
        //        }
        //    }

        //    Debug.WriteLine(MonkeysEliminated);
        //    Debug.WriteLine(RootFinalValue);
        //}
    }

    public class JobMonkey
    {
        public string Code { get; set; } = "";
        public string FirstOperator { get; set; } = "";
        public string SecondOperator { get; set; } = "";
        public string Operation { get; set; } = "";
        public bool ValueFound = false;
        public long CodeValue { get; set; } = 0;

        public JobMonkey(string code, long value)
        {
            Code = code;
            CodeValue = value;
            ValueFound = true;
        }

        public JobMonkey(string code, string firstOp, string secondOp, string op)
        {
            Code = code;
            FirstOperator = firstOp;
            SecondOperator = secondOp;
            Operation = op;
        }

        public long GetValue()
        {
            if (ValueFound) return CodeValue;

            switch (Operation)
            {
                case "+":
                    CodeValue = Day21.AllMonkeys[FirstOperator].GetValue() + Day21.AllMonkeys[SecondOperator].GetValue(); break;
                case "-":
                    CodeValue = Day21.AllMonkeys[FirstOperator].GetValue() - Day21.AllMonkeys[SecondOperator].GetValue(); break;
                case "*":
                    CodeValue = Day21.AllMonkeys[FirstOperator].GetValue() * Day21.AllMonkeys[SecondOperator].GetValue(); break;
                case "/":
                    CodeValue = Day21.AllMonkeys[FirstOperator].GetValue() / Day21.AllMonkeys[SecondOperator].GetValue(); break;
            }
            return CodeValue;
        }

        public bool EncountersHumn()
        {
            if (Code == "humn" || FirstOperator == "humn" || SecondOperator == "humn") return true;
            if (ValueFound) return false;

            if (!Day21.AllMonkeys[FirstOperator].EncountersHumn() && !Day21.AllMonkeys[SecondOperator].EncountersHumn())
            {
                GetValue();
                ValueFound = true;
                Day21.MonkeysEliminated++;
                return false;
            }

            return true;          
        }
    }
}
