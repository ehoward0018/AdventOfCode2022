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
        public static event Action<JobMonkeyValue> NewCodeFound = null;

        public static Dictionary<string, JobMonkeyValue> AllCodeValues = new();

        public static Queue<JobMonkeyValue> NewCodesFound = new();

        public static bool RootFound = false;
        public static long RootFinalValue = 0;

        static void Main()
        {
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "Day21.txt");
            string[] inputs = File.ReadAllLines(path2);
            List<JobMonkey> monkeys = new();
            
            for(int i = 0; i < inputs.Length; i++)
            {
                while(NewCodesFound.Count > 0)
                {
                    NewCodeFound.Invoke(NewCodesFound.Dequeue());
                }
                if (RootFound) break;

                string[] line = inputs[i].Split(": ");
                if (line[1].Contains('*') || line[1].Contains('/') || line[1].Contains('-') || line[1].Contains('+'))
                {
                    string[] secondLine = line[1].Split(' ');
                    monkeys.Add(new(line[0], secondLine[0], secondLine[2], secondLine[1]));
                }
                else
                {
                    JobMonkeyValue jobMonkeyValue = new()
                    {
                        Code = line[0],
                        CodeValue = long.Parse(line[1])
                    };

                    NewCodesFound.Enqueue(jobMonkeyValue);
                    AllCodeValues.Add(jobMonkeyValue.Code, jobMonkeyValue);
                }
            }
            while (NewCodesFound.Count > 0)
            {
                if (NewCodeFound is null) break;
                NewCodeFound.Invoke(NewCodesFound.Dequeue());
            }
        }
    }

    public class JobMonkeyValue
    {
        public string Code { get; set; } = "";
        public long CodeValue { get; set; }
    }

    public class JobMonkey
    {
        public string Code { get; set; } = "";
        public string FirstOperator { get; set; } = "";
        public string SecondOperator { get; set; } = "";
        public string Operation { get; set; } = "";
        public long CodeValue { get; set; } = 0;

        public JobMonkey(string code, string firstOp, string secondOp, string op)
        {
            Code = code;
            FirstOperator = firstOp;
            SecondOperator = secondOp;
            Operation = op;

            if (!CheckForAnswer())
                Day21.NewCodeFound += ListenForValue;

        }

        private void ListenForValue(JobMonkeyValue value)
        {
            if (value.Code != FirstOperator && value.Code != SecondOperator) return;

            if (CheckForAnswer())
                Day21.NewCodeFound -= ListenForValue;
         
        }

        private bool CheckForAnswer()
        {
            if (Day21.AllCodeValues.TryGetValue(FirstOperator, out JobMonkeyValue firstValue)
               && Day21.AllCodeValues.TryGetValue(SecondOperator, out JobMonkeyValue secondValue))
            {
                switch (Operation)
                {
                    case "+":
                        CodeValue = firstValue.CodeValue + secondValue.CodeValue; break;
                    case "-":
                        CodeValue = firstValue.CodeValue - secondValue.CodeValue; break;
                    case "*":
                        CodeValue = firstValue.CodeValue * secondValue.CodeValue; break;
                    case "/":
                        CodeValue = firstValue.CodeValue / secondValue.CodeValue; break;
                }

                if (Code == "root")
                {
                    Day21.RootFinalValue = CodeValue;
                    Day21.RootFound = true;
                }

                Day21.NewCodesFound.Enqueue(new JobMonkeyValue()
                {
                    Code = Code,
                    CodeValue = CodeValue,
                });

                Day21.AllCodeValues.Add(Code, new JobMonkeyValue()
                {
                    Code = Code,
                    CodeValue = CodeValue,
                });
                return true;
            }
            return false;
        }
    }
}
